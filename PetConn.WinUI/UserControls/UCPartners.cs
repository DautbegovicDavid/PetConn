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
    public partial class UCPartners : UserControl
    {
        public UCPartners()
        {
            InitializeComponent();
        }
        public Image petShopImage { get { return pictureBox1.Image; } set { pictureBox1.Image = value; } }
        public string nazivPartnera { get { return txtNazivPartnera.Text; } set { txtNazivPartnera.Text = value; } }

        

        
    }
}
