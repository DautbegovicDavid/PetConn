using PetConn.WinUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetConn.WinUI.Login_Register;
using PetConn.WinUI.Helpers;

namespace PetConn.WinUI.Home_Panels
{
    public partial class frmHomePetShop : Form
    {
        public frmHomePetShop()
        {
            InitializeComponent();
            lblUser.Text = APIService.UserName;
            lblPartnerName.Text = APIService.NazivPartnera;
            flowLayoutPanel1.Visible = false;
            InitTimer();
            
        }
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
            if (APIService.EditovanProfil == false)
                pictureBoxEditovanProfil.Visible = true;
        }     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (APIService.EditovanProfil == true)
                pictureBoxEditovanProfil.Visible = false;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            { 
                WindowState = FormWindowState.Normal;
                flowLayoutPanel1.Visible = false;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
                flowLayoutPanel1.Visible = true;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the application?";
            const string caption = "Exit application";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnTakeABreak_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to take a break ?", "Sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }
        
        // ------------------------------------------------------------//
        

        private void ucShops_Click(object sender, EventArgs e)
        {
            UC_PoslovniceUpdate poslovnice = new UC_PoslovniceUpdate();
            Helper.DodajKontrolu(poslovnice, "uc_poslovnice_edit", new Point(10, 60), panelMain);
            poslovnice.LoadDgv(APIService.PartnerID);

            if(btnAdd.Text!= "Add New SHOP")
                btnAdd.Text = "Add New SHOP";
        }
        private void ucEmployees_Click(object sender, EventArgs e)
        {
            UC_KorisniciEdit uposlenici = new UC_KorisniciEdit();
            Helper.DodajKontrolu(uposlenici, "uc_uposlenici_edit", new Point(10, 60), panelMain);
            //uposlenici.LoadDGVPartneri(APIService.PartnerID);
            
            if (btnAdd.Text != "Add New Employee")
                btnAdd.Text = "Add New Employee";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //jedinstvenu kontrolu saltat uslove u odnosu sta je kliklnuto  mogu preko txt koji biti posl zaposlenici itd..
            UCPoslovnicaUpsert poslovnicaUpsert = new UCPoslovnicaUpsert();
            Helper.DodajKontrolu(poslovnicaUpsert, "uc_poslovnica_upsert", new Point(10, 500), panelMain);
            WindowState = FormWindowState.Maximized;

        }

        

        

        private void btnUrediProfil_Click(object sender, EventArgs e)
        {
            KorisniciEditProfil uc_editProfil = new KorisniciEditProfil();
            //testMetoda(uc_editProfil, "UrediKorisnickiProfil", new Point(20,  500));
            Helper.DodajKontrolu(uc_editProfil, "UrediKorisnickiProfil", new Point(20, 500), panelMain);
        }

        
    }
}
