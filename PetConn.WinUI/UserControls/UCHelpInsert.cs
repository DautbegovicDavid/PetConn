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
    public partial class UCHelpInsert : UserControl
    {
        public UCHelpInsert()
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
        }
    }
}
