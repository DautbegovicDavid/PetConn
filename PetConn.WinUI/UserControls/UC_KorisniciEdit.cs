﻿using PetConn.Model;
using PetConn.Model.Requests;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetConn.WinUI.UserControls
{
    public partial class UC_KorisniciEdit : UserControl
    {
        APIService _service = new APIService("Uposlenik");
        APIService _serviceUposlenikByRole = new APIService("Uposlenik/getByRoles");
        APIService _serviceUloge = new APIService("Uloge");
        APIService _serviceKorisniciUloge = new APIService("KorisniciUloge");
        APIService _serviceKorisniciUlogeDelete = new APIService("KorisniciUloge/byKorisnikID");

        public UC_KorisniciEdit()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void KorisniciEdit_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDGV();
        }
        public async void LoadDGVPartneri(int partnerID)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await _service.Get<List<Uposlenik>>(new UposlenikSearchRequest { PartnerId=partnerID });
        }
        private async void LoadDGV()
        {
            if(APIService.PartnerID!=0)
            dataGridView1.DataSource = await _service.Get<List<Uposlenik>>(new UposlenikSearchRequest { PartnerId = APIService.PartnerID });
            else
            dataGridView1.DataSource = await _service.Get<List<Uposlenik>>(null);
        }
        private async void LoadComboBox()
        {
            var role = await _serviceUloge.Get<List<Uloge>>(null);
            role.Insert(0, new Uloge());
            cmbRoles.DataSource = role;
            cmbRoles.DisplayMember = "Naziv";
            cmbRoles.ValueMember = "UlogaId";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDGV();
            cmbRoles.SelectedIndex = 0;
        }
        
        private async void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Uposlenik> Uposlenici = new List<Uposlenik>();
            
            if (int.TryParse(cmbRoles.SelectedValue.ToString(), out int rolaID))
            {       
                if(rolaID!=0)
                Uposlenici = await _serviceUposlenikByRole.GetbyID<List<Uposlenik>>(rolaID);
                //Uposlenici= await _service.Get<List<Uposlenik>>(null);
            }
            if (APIService.PartnerID != 0 /*&& cmbRoles.SelectedIndex!=0*/)
            {
                Uposlenici.RemoveAll(r => r.PartnerId != APIService.PartnerID);
            }
            dataGridView1.DataSource = Uposlenici;
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                var u = dataGridView1.CurrentRow.DataBoundItem as Uposlenik;

                var result = MessageBox.Show("Do you want to delete this record :\n" + u.Korisnik.ToString() + " " + u.Partner.ToString() + " ?", "Delete action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _service.Delete<Uposlenik>(u.UposlenikId);
                    await _serviceKorisniciUlogeDelete.Delete<KorisniciUloge>(u.KorisnikId);

                    MessageBox.Show(u.Korisnik.ToString() + " " + u.Partner.ToString() + " deleted.", "Delete action successfull", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDGV();
                }
            }
        }
    }
}

