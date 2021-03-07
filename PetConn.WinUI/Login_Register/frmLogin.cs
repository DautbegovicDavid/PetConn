
using PetConn.Model;
using PetConn.Model.Requests;
using PetConn.WinUI.Home_Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetConn.WinUI.Login_Register
{

    // reducirati nepotrebne pozve
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService _serviceku = new APIService("KorisniciUloge");
        private readonly APIService _serviceVP = new APIService("VrstePartnera");
        APIService _serviceGetIDKorisnik = new APIService("Korisnici/getID");
        APIService _serviceGetUlogasID = new APIService("Korisnici/getUlogaIDs");
        APIService _serviceUloge = new APIService("Uloge");

        APIService _serviceUposlenik = new APIService("Uposlenik");
        APIService _servicePartner = new APIService("Partner/IDsByVrstaPartneraID");
        APIService _servicePartnerGet = new APIService("Partner");

        APIService _serviceUPOSLENICI = new APIService("Uposlenik");


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "")
                MessageBox.Show("Empty fields are not allowwed !", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {

                
                APIService.UserName = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                APIService.PartnerID = 0;
                List<Korisnik> kor= await _service.Get<List<Korisnik>>(new KorisnikSearchRequest { KorisnickoIme=txtUsername.Text});

                
                //imam korisnika

                if (kor.Count==0)
                {
                    MessageBox.Show("Wrogn Username or Password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                Korisnik k = kor.First();
                if (k.Email.Equals("test@email.com") &&
                    k.Ime.Equals("Unesi ime") &&
                    k.Prezime.Equals("Unesi prezime") &&
                    k.Telefon.Equals("000/000-000"))
                    APIService.EditovanProfil = false;
                else APIService.EditovanProfil = true;

                
                
                
                //imam ID
                int korisnikID = await _serviceGetIDKorisnik.Get<int>(new KorisnikSearchRequest { KorisnickoIme = txtUsername.Text });
              

                //Imam listu ulog koje su dodijeljne
                List<int> listaUloga= await _serviceGetUlogasID.GetbyID<List<int>>(korisnikID);
                if(listaUloga.Count==0)
                {
                    MessageBox.Show("You have Not been AUTHORIZED to use system yet !\n \n*Please Contact your supervisor.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                Uloge u = await _serviceUloge.GetbyID<Uloge>(listaUloga.First());
                APIService.Uloga = u.Naziv;


                int VrstaPartneraID=await _serviceVP.GetVrstaPartneraID<int>(new VrstaPartnera { Naziv = "Pet Shop" });
                int PetShopVpID = await _serviceVP.GetVrstaPartneraID<int>(new VrstaPartnera { Naziv = "Pet Shop" });
                int VetShopVpID = await _serviceVP.GetVrstaPartneraID<int>(new VrstaPartnera { Naziv = "Vet Station" });


                //// Get Partnere s obzirom na vrstu Partnera
                List<int> IDsPartneri = await _servicePartner.Get<List<int>>(new PartneriSearchRequest { VrstaPartneraId=VrstaPartneraID});


                List<Uposlenik> uposlenici = await _serviceUPOSLENICI.Get<List<Uposlenik>>(new UposlenikSearchRequest { KorisnikId=korisnikID});
                
                //provjera da nije glavni admin sistema
                if (uposlenici.Count != 0)
                {
                    int uposlenikPartnerID = uposlenici.FirstOrDefault().PartnerId;
                    APIService.PartnerID = uposlenikPartnerID;

                    List<Partner> partnerUposlenika = await _servicePartnerGet.Get<List<Partner>>(new PartneriSearchRequest { PartnerId = uposlenikPartnerID });// VRACA CITAV NIZ NE VALJA FILTER
                    int uposlenikVrstaPartneraID = partnerUposlenika.FirstOrDefault().VrstaPartneraId; // dodijeli prvi iz niza!!!!

                    APIService.NazivPartnera = partnerUposlenika.FirstOrDefault().Naziv;
                    // pocetni skrin
                    if (uposlenikVrstaPartneraID == PetShopVpID)
                    {
                        new frmHomePetShop().Show();
                        Hide();
                        return;
                    }
                }






               


                new frmHome().Show();
                //new frmHomePetShop().Show();
                Hide();     

                
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Atuhentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassVisibilty.Checked)           
                txtPassword.PasswordChar = '\0';              
            else
                txtPassword.PasswordChar = '•';      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the application?";
            const string caption = "Exit application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);

            // If the no button was pressed ...  
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.  
                Close();

            }
        }
    }
}
