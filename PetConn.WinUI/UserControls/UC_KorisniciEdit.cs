﻿using PetConn.Model;
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

namespace PetConn.WinUI.UserControls
{
    public partial class UC_KorisniciEdit : UserControl
    {
        APIService _service = new APIService("Uposlenik");
        APIService _serviceUloge = new APIService("Uloge");
        APIService _serviceKorisniciUloge = new APIService("KorisniciUloge");


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
            LoadDGV();
            LoadComboBox();
        }
        private async void LoadDGV()
        {          
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
            List<Uposlenik> Uposlenici=new List<Uposlenik>();
            if (int.TryParse(cmbRoles.SelectedValue.ToString(), out int rolaID))
            {
                List<KorisniciUloge> lista = await _serviceKorisniciUloge.Get<List<KorisniciUloge>>(new KorisniciUlogeSearchRequest { UlogaId = rolaID });
                foreach (KorisniciUloge item in lista)
                {
                    List<Uposlenik> uposlenici =  await _service.Get<List<Uposlenik>>(new UposlenikSearchRequest { KorisnikId=item.KorisnikId});
                    Uposlenici.AddRange(uposlenici);
                }


            }
            dataGridView1.DataSource = Uposlenici;

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3&&e.RowIndex!=0)
            {
                var u = dataGridView1.CurrentRow.DataBoundItem as Uposlenik;

                var result = MessageBox.Show("Do you want to delete this record :\n" + u.Korisnik.ToString()+ " " + u.Partner.ToString() +" ?", "Delete action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    Uposlenik delete = await _service.Delete<Uposlenik>(u.UposlenikId);
                    MessageBox.Show(u.Korisnik.ToString() + " " + u.Partner.ToString() + " deleted.", "Delete action successfull", // baca error ne stavi partnera kod brisanja
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDGV();
                }
            }
        }
    }
}
