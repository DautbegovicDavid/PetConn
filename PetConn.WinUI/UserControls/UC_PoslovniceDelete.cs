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
    public partial class UC_PoslovniceDelete : UserControl
    {
        private readonly APIService _service = new APIService("Poslovnica");
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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Hide();            
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                var _posl = dataGridView1.CurrentRow.DataBoundItem as Poslovnica;
                if (_posl != null)
                {
                    var result = MessageBox.Show("Do you want to delete this record :\n" + _posl.Partner.ToString() + " " + _posl.Naziv.ToString() + "?", "Delete action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Poslovnica delete = await _service.Delete<Poslovnica>(_posl.PoslovnicaId);

                        MessageBox.Show(delete.Naziv.ToString() + " deleted.", "Delete action successfull", // baca error ne stavi partnera kod brisanja
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDgv(APIService.PartnerID);
                        return;
                    }
                }
            }
        }
        public async void LoadDgv(int partnerID)
        {
            if(partnerID!=0)
            dataGridView1.DataSource = await _service.Get<List<Poslovnica>>(new PoslovnicaSearchRequest { PartnerId = partnerID });
            else
            dataGridView1.DataSource = await _service.Get<List<Poslovnica>>(null);

        }


    }
}
