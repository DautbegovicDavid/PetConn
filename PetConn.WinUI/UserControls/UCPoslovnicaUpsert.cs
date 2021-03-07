using PetConn.Model.HelpModels;
using PetConn.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;
using System.IO;
using PetConn.WinUI.Helpers;
using PetConn.Model.Requests;

namespace PetConn.WinUI.UserControls
{
    public partial class UCPoslovnicaUpsert : UserControl
    {
        private readonly APIService _service = new APIService("Poslovnica");
        private readonly APIService _serviceLokacija = new APIService("Lokacija");
        private readonly APIService _servicePartner = new APIService("Partner");
        private readonly APIService _servicePoslovnica = new APIService("Poslovnica");


        PoslovnicaUpsertRequest request = new PoslovnicaUpsertRequest();
        Poslovnica requestUpdate = null;

        public UCPoslovnicaUpsert(Poslovnica p=null)
        {
            InitializeComponent();
            //LoadCMBs();
            SetFormat(p);
        }
        public void SetFormat(Poslovnica p)
        {
            vrijemeOD.Format = DateTimePickerFormat.Custom;
            vrijemeOD.CustomFormat = "HH:mm";

            vrijemeDo.Format = DateTimePickerFormat.Custom;
            vrijemeDo.CustomFormat = "HH:mm";

            vrijemeDo.ShowUpDown = true;
            vrijemeOD.ShowUpDown = true;
            if (p != null)
            {
                LoadPartner(p.PartnerId);
                LoadLokacije(p.LokacijaId);
                nazivEntry = p.Naziv;
                phoneEntry = p.Telefon;
                emailEntry = p.Email;
                vrijemeEntryDo = new DateTime(2012, 05, 28).Add(p.RadnoVrijemeDo.Value);
                vrijemeEntryOd = new DateTime(2012, 05, 28).Add(p.RadnoVrijemeOd.Value);
                if (p.Slika.Length != 0)
                    pictureBoxPoslovnica.Image = Helper.FromByteToImage(p.Slika);
                lblHeader.Text = "Edit place of business";

                requestUpdate=new Poslovnica();
                requestUpdate = p;
                return;
            }
            LoadCMBs();
        }

        public event EventHandler SaveBtnClick
        {
            add { btnSave.Click += value; }
            remove { btnSave.Click -= value; }
        }
        //public DateTime vrijemeOD { get { return vrijemeOD} }
        public DateTime vrijemeEntryOd { get { return vrijemeOD.Value; } set { vrijemeOD.Value = value; } }
        public DateTime vrijemeEntryDo { get { return vrijemeDo.Value; } set { vrijemeDo.Value = value; } }

        public string nazivEntry { get { return txtNazivPoslovnice.Text; } set { txtNazivPoslovnice.Text = value; } }
        public Image petShopImage { get { return pictureBoxPoslovnica.Image; } set { pictureBoxPoslovnica.Image = value; } }
        public string emailEntry { get { return txtEmail.Text; } set { txtEmail.Text = value; } }
        public string phoneEntry { get { return txtTelefon.Text; } set { txtTelefon.Text = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObjectCollection ComboItemsLocation
        {
            get
            {
                return cmbLokacija.Items;
            }
            set
            {
                cmbLokacija.Items.Clear();
                foreach (var i in value)
                    cmbLokacija.Items.Add(i);
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObjectCollection ComboItemsPartner
        {
            get
            {
                return cmbPartner.Items;
            }
            set
            {
                cmbPartner.Items.Clear();
                foreach (var i in value)
                    cmbPartner.Items.Add(i);
            }
        }

       /// <summary>
       /// ////////////////////////////////////////////////////////////
       /// </summary>
        
        public void CleanForm()//provjeriti gdje se koristi
        {
            Controls.Clear();
            LoadCMBs();
            pictureBoxPoslovnica.Image = null;
            InitializeComponent();        
            Location = new Point(10, 500);
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }
       
        private async void LoadCMBs()
        {
            var listLokacije = await _serviceLokacija.Get<List<Lokacija>>(null);
            listLokacije.Insert(0, new Lokacija { Naziv = "Location" });
            cmbLokacija.DataSource = listLokacije;
            cmbLokacija.DisplayMember = "Naziv";
            cmbLokacija.ValueMember = "LokacijaId";

            var listPartneri = await _servicePartner.Get<List<Partner>>(null);
            listPartneri.Insert(0, new Partner { Naziv = "Partner" });
            cmbPartner.DataSource = listPartneri;
            cmbPartner.DisplayMember = "Naziv";
            cmbPartner.ValueMember = "PartnerId";
            
        }
        private async void LoadPartner(int PartnerID)
        {
            var listPartneri = await _servicePartner.Get<List<Partner>>(new PartneriSearchRequest { PartnerId = PartnerID });
            cmbPartner.DataSource = listPartneri;
            cmbPartner.DisplayMember = "Naziv";
            cmbPartner.ValueMember = "PartnerId";
            cmbPartner.Enabled = false;
        }
        private async void LoadLokacije(int LokID)
        {
            var listLok = await _serviceLokacija.Get<List<Lokacija>>(null);
            cmbLokacija.DataSource = listLok;
            cmbLokacija.DisplayMember = "Naziv";
            cmbLokacija.ValueMember = "LokacijaId";
            cmbLokacija.SelectedValue = LokID;            
        }

       

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            UC_HelpInsert Lokacija = new UC_HelpInsert();
            Helper.UcDodajKontrolu(Parent,Lokacija, "UC_Lokacija", new Point(400, 500));
            Lokacija.Load_Lokacija();          
        }
        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            UC_HelpInsert Partner = new UC_HelpInsert();
            Helper.UcDodajKontrolu(Parent, Partner, "UC_Partner", new Point(400, 500));
            Partner.Load_Partner();
        }

        
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            //Update Metoda NE radi
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;


                Image image = Image.FromFile(fileName);//ucitali sliku sa putanje
                pictureBoxPoslovnica.Image = image;//prikazali u boxu

                Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                thumb.Save(Path.ChangeExtension(fileName, "thumb"));
                request.SlikaThumb = Helper.FromImageToByteTHUMB(thumb);//radi ali nesto ne valja


            }
        }
        

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.RadnoVrijemeDo = vrijemeEntryDo.TimeOfDay;
            request.RadnoVrijemeOd = vrijemeEntryOd.TimeOfDay;
            if (int.TryParse(cmbLokacija.SelectedValue.ToString(), out int idLokacija))
                request.LokacijaId = idLokacija;
            if (int.TryParse(cmbPartner.SelectedValue.ToString(), out int idPartner))
                request.PartnerId = idPartner;
            request.Naziv = nazivEntry;
            request.Email = emailEntry;
            request.Telefon = phoneEntry;
            if (pictureBoxPoslovnica.Image != null)
                request.Slika = Helper.FromImageToByte(pictureBoxPoslovnica.Image);
            if (pictureBoxPoslovnica.Image != null)
                request.SlikaThumb = Helper.FromImageToByteTHUMB(pictureBoxPoslovnica.Image);


            if (requestUpdate == null)
            {
                await _servicePoslovnica.Insert<Poslovnica>(request);

                MessageBox.Show("Place of business successfully added", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
            {
                await _servicePoslovnica.Update<Poslovnica>(requestUpdate.PoslovnicaId, request);

                MessageBox.Show("Place of business successfully updated", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                //PoslovnicaUpsertRequest novi = new PoslovnicaUpsertRequest();//provjeriti ovo
                //request = novi;

               
            }
            
            //uc.Visible = false;
            //CleanForm();
            Dispose();
        }
        public void SetajZadnjiSelektovanILIPoPartneru()
        {

        }
        
        public PoslovnicaUpsertRequest GetPoslovnica()
        {
            return request;
        }
        public void SetPoslovnica(PoslovnicaUpsertRequest request)
        {
            this.request = request;
        }

    }
}
