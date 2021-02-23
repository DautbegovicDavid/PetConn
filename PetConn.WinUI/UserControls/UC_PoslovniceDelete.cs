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

namespace PetConn.WinUI.UserControls
{
    public partial class UC_PoslovniceDelete : UserControl
    {
        public UC_PoslovniceDelete()
        {
            
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ClearSelection();
            


        }
        public object DataSource
        {
            get { return dataGridView1.DataSource; }
            set { dataGridView1.DataSource = value; }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Hide();
            
        }
    }
}
