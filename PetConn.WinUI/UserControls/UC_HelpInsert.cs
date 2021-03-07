using PetConn.Model;
using PetConn.Model.HelpModels;
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
using static System.Windows.Forms.ComboBox;

namespace PetConn.WinUI.UserControls
{
    public partial class UC_HelpInsert : UserControl
    {
        private readonly APIService _service = new APIService("Lokacija");
        private readonly APIService _serviceGrad = new APIService("Grad");
        private readonly APIService _serviceVrstaPartnera = new APIService("VrstePartnera");
        private readonly APIService _servicePartner = new APIService("Partner");



        public UC_HelpInsert()
        {
            InitializeComponent();
            
        }
        public event EventHandler SaveBtnClick
        {
            add { btnSave.Click += value; } 
            remove { btnSave.Click -= value; }
        }
        public string firstEntry { get { return txtBoxFirst.Text; } set { txtBoxFirst.Text = value; } }
      
        public string secondEntry { get { return txtBoxSecond.Text; } set { txtBoxSecond.Text = value; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObjectCollection ComboItems
        {
            get
            {
                return cmbBox.Items;
            }
            set
            {
                cmbBox.Items.Clear();
                foreach (var i in value)
                    cmbBox.Items.Add(i);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbBox.SelectedIndex == 0 || firstEntry.Length == 0)
            {
                MessageBox.Show("\n Empty fields are not allowed !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblSecondEntryField.Visible == false)
            {
                PartneriUpsertRequest request = new PartneriUpsertRequest();
                request.Naziv = txtBoxFirst.Text;
                if (int.TryParse(cmbBox.SelectedValue.ToString(), out int idVP))
                    request.VrstaPartneraId = idVP;

                //if (p == null)
                    await _servicePartner.Insert<dynamic>(request);
                MessageBox.Show("Partner successfully updated", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LokacijaUpsertRequest request = new LokacijaUpsertRequest();
                request.Adresa = txtBoxSecond.Text;
                request.Naziv = txtBoxFirst.Text;
                if (int.TryParse(cmbBox.SelectedValue.ToString(), out int idGrad))
                    request.GradId = idGrad;
                await _service.Insert<dynamic>(request);
                MessageBox.Show("Location successfully added", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Visible = false;
            //Dispose();// ??
            
        }

        public async void Load_Lokacija()
        {
            lblComboBox.Text = "Town";
            lblFirstEntryField.Text = "Name of location";
            lblSecondEntryField.Text = "Address";
            lblHeader.Text = "Enter location";

            var listGradovi = await _serviceGrad.Get<List<Grad>>(null);
            listGradovi.Insert(0, new Grad { Naziv = "Town" });

            cmbBox.DataSource = listGradovi;
            cmbBox.DisplayMember = "Naziv";
            cmbBox.ValueMember = "GradId";  
            
            //if (selectLastItem)
            //    cmbBox.SelectedIndex = cmbBox.Items.Count - 1;--- SEtam na drugoj UC
        }
        public async void Load_Partner()
        {
            lblHeader.Text = "Enter Partner";
            lblComboBox.Text = "Type of partner";
            lblFirstEntryField.Text = "Name of partner";
            lblSecondEntryField.Visible = false;
            txtBoxSecond.Visible = false;

            var listVrstePartnera = await _serviceVrstaPartnera.Get<List<VrstePartnera>>(null);
            listVrstePartnera.Insert(0, new VrstePartnera { Naziv = "Type of Partner" });

            cmbBox.DataSource = listVrstePartnera;
            cmbBox.DisplayMember = "Naziv";
            cmbBox.ValueMember = "VrstaPartneraId";                  
        }

       
    }
}
