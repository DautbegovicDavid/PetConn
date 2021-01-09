using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Claims;
using PetConn.Model.Requests;



namespace PetConn.WinUI
{
    public partial class Form1 : Form
    {
        private readonly APIService _service=new APIService("Korisnici");
        private readonly APIService _serviceUloge = new APIService("Uloge");
        private readonly APIService _serviceVrstePartnera = new APIService("VrstePartnera");
        //promijeni korisnici intefrejs i kontroller da bi dobio patrnera

        public Form1()
        {
            InitializeComponent();
            

            // Access claims
           

            // Access IClaimsIdentity which contains claims
            
        }
        KorisnikSearchRequest request = new KorisnikSearchRequest();

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            // var uloge = clbRole.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();    //ovaj radi OVO JE ZA ONE KAD IH JE VISE

            
                request.Ime = txtPretragaIme.Text;
            
                request.Prezime = txtPretragaPrezime.Text;




            var list =await _service.Get<List<Model.Korisnik>>(request);//ne moze ne valja mi mapiranje 
           

            dgvKorisnici.DataSource = list;
             
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var list = await _serviceUloge.Get<List<Model.Uloge>>(null);
            list.Insert(0, new Model.Uloge());
            cmbUloge.DataSource = list;
            cmbUloge.DisplayMember = "Naziv";
            cmbUloge.ValueMember = "UlogaId";
            //cmbUloge.SelectedIndex = -1;

            var list1 = await _serviceVrstePartnera.Get<List<Model.VrstePartnera>>(null);
            list1.Insert(0, new Model.VrstePartnera());
            cmbVrstaPartnera.DataSource = list1;
            cmbVrstaPartnera.DisplayMember = "Naziv";
            cmbVrstaPartnera.ValueMember = "VrstaPartneraId";
            //cmbVrstaPartnera.SelectedIndex = -1;

            var Partner = await _service.GetPartner<Model.Partner>(new KorisnikSearchRequest { KorisnickoIme = "string" });
            txtPartner.Text = Partner.Naziv;

        }

        private void cmbUloge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUloge.SelectedValue != null)
            {
                if (int.TryParse(cmbUloge.SelectedValue.ToString(), out int idU))
                {
                    request.UlogaId = idU;
                }
            }
        }
        //private async Task Load_VrsteProizvoda()
        //{
        //    var result = await _serviceVrsteProizvoda.Get<List<Model.VrsteProizvoda>>(null);
        //    result.Insert(0, new Model.VrsteProizvoda());//da nam ne selektuje u pocetku
        //    cmbVrstaProizvoda.DataSource = result;
        //    cmbVrstaProizvoda.ValueMember = "VrstaId";
        //    cmbVrstaProizvoda.DisplayMember = "Naziv";//idem na klasu i vidim koji su atributi

        //}

        private void cmbVrstaPartnera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVrstaPartnera.SelectedValue != null)
            {
                
                    if (int.TryParse(cmbVrstaPartnera.SelectedValue.ToString(), out int idVP))
                    {
                        request.VrstaPartneraId = idVP;
                    }
                
            }
        }
    }
}
