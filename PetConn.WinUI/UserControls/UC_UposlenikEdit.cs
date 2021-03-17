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
    public partial class UC_UposlenikEdit : UserControl
    {
        private readonly  APIService _serviceUposlenikByRole = new APIService("Uposlenik/getByRoles");
        private readonly APIService _service = new APIService("Uposlenik");
        private readonly APIService _serviceUloge = new APIService("Uloge");

        public UC_UposlenikEdit()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
        private void UC_UposlenikEdit_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDGV();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDGV();
            cmbRoles.SelectedIndex = 0;
        }
        private async void LoadDGV()
        {
            if (APIService.PartnerID != 0)
                dataGridView1.DataSource = await _service.Get<List<Uposlenik>>(new UposlenikSearchRequest { PartnerId = APIService.PartnerID });
            else
                dataGridView1.DataSource = await _service.Get<List<Uposlenik>>(null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                var uposlenik = dataGridView1.CurrentRow.DataBoundItem as Uposlenik;

                if (uposlenik != null)
                {
                    if (Parent.Controls.Find("UC_UposlenikUpsert", true).Length > 0)
                        Helper.UkloniKontrolu(Parent, "UC_UposlenikUpsert");

                    UCUposlenikUpsert editUposlenik = new UCUposlenikUpsert(uposlenik);
                    Helper.UcDodajKontrolu(Parent, editUposlenik, "UC_UposlenikUpsert", new Point(20, 500));

                }

                
            }
        }

        private async void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Uposlenik> Uposlenici = new List<Uposlenik>();

            if (int.TryParse(cmbRoles.SelectedValue.ToString(), out int rolaID))
            {
                if (rolaID != 0)
                    Uposlenici = await _serviceUposlenikByRole.GetbyID<List<Uposlenik>>(rolaID);
                
            }
            if (APIService.PartnerID != 0)
            {
                Uposlenici.RemoveAll(r => r.PartnerId != APIService.PartnerID);
            }
            dataGridView1.DataSource = Uposlenici;
        }

       
        private async void LoadComboBox()
        {
            var role = await _serviceUloge.Get<List<Uloge>>(null);
            role.Insert(0, new Uloge());
            cmbRoles.DataSource = role;
            cmbRoles.DisplayMember = "Naziv";
            cmbRoles.ValueMember = "UlogaId";
        }
    }
}
