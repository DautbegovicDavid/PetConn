using PetConn.Model;
using PetConn.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetConn.WinUI.UserControls
{
    public partial class UCUposlenikUpsert : UserControl
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _serviceGetIDKorisnik = new APIService("Korisnici/getID");
        private readonly APIService _serviceUposlenik = new APIService("Uposlenik");
        private readonly APIService _serviceKorisniciUloge = new APIService("KorisniciUloge");
        private readonly APIService _serviceKorisniciUlogeDELETE = new APIService("KorisniciUloge/byKorisnikID");
        private readonly APIService _serviceUloge = new APIService("Uloge");


        int KORISNIKID = 0;
        private Uposlenik requestUpdate = null;
        public UCUposlenikUpsert(Uposlenik u=null)
        {
            InitializeComponent();
            
            SetFormat(u);
        }
        public async void SetFormat(Uposlenik u)
        {
            
            if (u != null)
            {
                Korisnik k = await _service.GetbyID<Korisnik>(u.KorisnikId);
                txtEmail.Text = k.Email;
                txtPhone.Text = k.Telefon;
                txtUserName.Text = k.KorisnickoIme;
                txtName.Text = k.Ime;
                txtSurName.Text = k.Prezime;
                KORISNIKID = await _serviceGetIDKorisnik.Get<int>(new KorisnikSearchRequest { KorisnickoIme = txtUserName.Text });
                List<KorisniciUloge> lista = await _serviceKorisniciUloge.Get<List<KorisniciUloge>>(new KorisniciUlogeSearchRequest { KorisnikId = KORISNIKID });
                KorisniciUloge ku = lista.FirstOrDefault();
                LoadCMB(ku.UlogaId);
                requestUpdate = new Uposlenik();
                requestUpdate = u;
                return;

            }
            LoadCMB(null);
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Hide();
        }
        private async void LoadCMB(int ?x)
        {
            
            
            var role = await _serviceUloge.Get<List<Uloge>>(null);
          
            role.Insert(0, new Uloge());
            cmbRole.DataSource = role;
            cmbRole.DisplayMember = "Naziv";
            cmbRole.ValueMember = "UlogaId";
            if (x != null)
                cmbRole.SelectedValue = x;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            KorisnikUpsertRequest request=new KorisnikUpsertRequest{
                
                Ime=txtName.Text,
                Prezime=txtSurName.Text,
                KorisnickoIme=txtUserName.Text,
                Email=txtEmail.Text,
                Telefon=txtPhone.Text,
                Password="test",
                PasswordConfirmation="test"               
                
            };
            if (requestUpdate == null)
            {
                await _service.Insert<Korisnik>(request);


                int korisnikID = await _serviceGetIDKorisnik.Get<int>(new KorisnikSearchRequest { KorisnickoIme = txtUserName.Text });

                UposlenikUpsertRequest uposlenikRequest = new UposlenikUpsertRequest
                {

                    PartnerId = APIService.PartnerID,
                    KorisnikId = korisnikID,
                    DatumIzmjene = DateTime.Now
                };




                await _serviceUposlenik.Insert<Uposlenik>(uposlenikRequest);

                if (int.TryParse(cmbRole.SelectedValue.ToString(), out int idRola))
                {
                    await _serviceKorisniciUloge.Insert<KorisniciUloge>(new KorisniciUlogeUpsertRequest { DatumIzmjene = DateTime.Now, KorisnikId = korisnikID, UlogaId = idRola });
                }

                MessageBox.Show("Successfully created User", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
            {
                await _service.Update<Korisnik>(KORISNIKID, request);
                await  _serviceKorisniciUlogeDELETE.Delete<KorisniciUloge>(KORISNIKID);
                if (int.TryParse(cmbRole.SelectedValue.ToString(), out int idRola))
                {
                    await _serviceKorisniciUloge.Insert<KorisniciUloge>(new KorisniciUlogeUpsertRequest { DatumIzmjene = DateTime.Now, KorisnikId = KORISNIKID, UlogaId = idRola });
                }
                MessageBox.Show("User successfully updated", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


        }
    }
}
