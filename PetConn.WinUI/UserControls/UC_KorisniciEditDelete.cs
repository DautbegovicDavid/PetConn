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
    public partial class UC_KorisniciEditDelete : UserControl
    {
        APIService _service = new APIService("Korisnici");
        APIService _serviceKorisniciUloge = new APIService("KorisniciUloge");
        APIService _serviceGetIDKorisnik = new APIService("Korisnici/getID");
        APIService _serviceUloge = new APIService("Uloge");
        APIService _serviceVrstePartnera = new APIService("VrstePartnera");
        APIService _servicePartneri = new APIService("Partner");
        APIService _serviceUposlenik = new APIService("Uposlenik");


        public UC_KorisniciEditDelete()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            
        }
        public async void LoadDGV()
        {
            List<KorisniciUloge> korisniciUloge = await _serviceKorisniciUloge.Get<List<KorisniciUloge>>(null);
            List<Korisnik> korisnici = await _service.Get<List<Korisnik>>(null);
            List<Korisnik> korisnici1 = await _service.Get<List<Korisnik>>(null);

            foreach (KorisniciUloge ku in korisniciUloge)
            {
                foreach (Korisnik ko in korisnici)
                {
                    int korisnikID = await _serviceGetIDKorisnik.Get<int>(new KorisnikSearchRequest { KorisnickoIme = ko.KorisnickoIme });
                    if (ku.KorisnikId == korisnikID)
                        korisnici1.RemoveAll(x => x.KorisnickoIme ==ko.KorisnickoIme );                   
                }
                    
            }
            
            dataGridView1.DataSource = korisnici1;

            //dataGridView1.DataSource = await _service.Get<List<Korisnik>>(null);
        }
        public async void LoadCMBs()
        {
            var partneri = await _servicePartneri.Get<List<Partner>>(null);
            partneri.Insert(0, new Partner());
            cmbPartneri.DataSource = partneri;
            cmbPartneri.DisplayMember = "Naziv";
            cmbPartneri.ValueMember = "PartnerId";

            var vrstePartnera = await _serviceVrstePartnera.Get<List<VrstePartnera>>(null);
            vrstePartnera.Insert(0, new VrstePartnera());
            cmbVrstePartnera.DataSource = vrstePartnera;
            cmbVrstePartnera.DisplayMember = "Naziv";
            cmbVrstePartnera.ValueMember = "VrstaPartneraId";

            var role = await _serviceUloge.Get<List<Uloge>>(null);
            role.Insert(0, new Uloge());
            cmbRole.DataSource = role;
            cmbRole.DisplayMember = "Naziv";
            cmbRole.ValueMember = "UlogaId";

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }
        Korisnik k;
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
            if(e.ColumnIndex==2)
            {
                
                k = dataGridView1.CurrentRow.DataBoundItem as Korisnik;
                Height = 420;
                txtEmail.Text = k.Email;
                txtUsername.Text = k.KorisnickoIme;

            }
            else if(e.ColumnIndex == 3)
            {
                k = dataGridView1.CurrentRow.DataBoundItem as Korisnik;

                var result = MessageBox.Show("Do you want to delete this record :\n" + k.Ime.ToString()+" "+k.Prezime.ToString()+" "+k.KorisnickoIme + " ?", "Delete action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {                   
                    int korisnikID = await _serviceGetIDKorisnik.Get<int>(new KorisnikSearchRequest { KorisnickoIme = k.KorisnickoIme });
                    Korisnik delete = await _service.Delete<Korisnik>(korisnikID);
                    MessageBox.Show(delete.Ime.ToString()+" "+k.KorisnickoIme.ToString() + " deleted.", "Delete action successfull", // baca error ne stavi partnera kod brisanja
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDGV();
                }
            }
        }

        private async void cmbVrstePartnera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (int.TryParse(cmbVrstePartnera.SelectedValue.ToString(), out int idVP))
                x = idVP;
            var partneri = await _servicePartneri.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId=x});
            partneri.Insert(0, new Partner());
            cmbPartneri.DataSource = partneri;
            cmbPartneri.DisplayMember = "Naziv";
            cmbPartneri.ValueMember = "PartnerId";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
                     
            if (cmbPartneri.SelectedIndex == 0|| cmbRole.SelectedIndex == 0||cmbVrstePartnera.SelectedIndex == 0)
            {
                MessageBox.Show("You need to select Type of Partner, Partner & Role in order to add employee", "Warning", // baca error ne stavi partnera kod brisanja
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int korisnikID = await _serviceGetIDKorisnik.Get<int>(new KorisnikSearchRequest { KorisnickoIme = k.KorisnickoIme });

            UposlenikUpsertRequest request = new UposlenikUpsertRequest();
            if (int.TryParse(cmbPartneri.SelectedValue.ToString(), out int idP))
            {
                request.PartnerId = idP;
                request.KorisnikId = korisnikID;
                request.DatumIzmjene = DateTime.Now;
            
            }
            Uposlenik p = await _serviceUposlenik.Insert<Uposlenik>(request);

            if (int.TryParse(cmbRole.SelectedValue.ToString(), out int idRola))
            {
                await _serviceKorisniciUloge.Insert<KorisniciUloge>(new KorisniciUlogeUpsertRequest { DatumIzmjene = DateTime.Now, KorisnikId = korisnikID, UlogaId = idRola });
            }
              
            MessageBox.Show(p.DatumIzmjene.ToString()+" _ "+p.PartnerId.ToString(), "Succes", 
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            cmbPartneri.SelectedIndex = 0;
            cmbRole.SelectedIndex = 0;
            cmbVrstePartnera.SelectedIndex = 0;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            LoadDGV();

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Height = 300;
        }
    }
}
