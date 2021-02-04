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
    public partial class UCPoslovnicaInsert : UserControl
    {
        public UCPoslovnicaInsert()
        {
            InitializeComponent();
            SetFormat();
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

        
        public void CleanForm()
        {
            Controls.Clear();

            InitializeComponent();


        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
        public void SetFormat()
        {

            vrijemeOD.Format = DateTimePickerFormat.Custom;
            vrijemeOD.CustomFormat = "HH:mm";
            

            vrijemeDo.Format = DateTimePickerFormat.Custom;
            vrijemeDo.CustomFormat = "HH:mm";

            
            //vrijemeDo.Format = DateTimePickerFormat.Time;
            //vrijemeOD.Format = DateTimePickerFormat.Time;

            

            
            vrijemeDo.ShowUpDown = true;
            vrijemeOD.ShowUpDown = true;

        }

      
    }
}
