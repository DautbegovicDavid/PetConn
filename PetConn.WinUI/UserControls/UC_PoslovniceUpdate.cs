using PetConn.Model;
using PetConn.Model.Requests;
using PetConn.WinUI.Helpers;
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
    public partial class UC_PoslovniceUpdate : UserControl
    {
        private readonly APIService _service = new APIService("Poslovnica");
        public UC_PoslovniceUpdate()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;            
        }
        public object DataSource
        {
            get { return dataGridView1.DataSource; }
            set { dataGridView1.DataSource = value; }
        }
       
        public void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Hide();
        }
        public  async void LoadDgv(int partnerID)
        {
            dataGridView1.DataSource = await _service.Get<List<Poslovnica>>(new PoslovnicaSearchRequest { PartnerId=partnerID});
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {               
                dataGridView1.Rows[e.RowIndex].Selected = true;
                var poslovnica = dataGridView1.CurrentRow.DataBoundItem as Poslovnica;

                if (poslovnica != null)
                {
                    if (Parent.Controls.Find("UC_PoslovnicaUpsert", true).Length > 0)
                        Helper.UkloniKontrolu(Parent, "UC_PoslovnicaUpsert");
                    
                    UCPoslovnicaUpsert editPoslovnica = new UCPoslovnicaUpsert(poslovnica);
                    Helper.UcDodajKontrolu(Parent, editPoslovnica, "UC_PoslovnicaUpsert", new Point(20, 500));                  
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             LoadDgv(APIService.PartnerID);
        }
    }
}
