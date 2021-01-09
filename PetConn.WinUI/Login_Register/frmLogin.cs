
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetConn.WinUI.Login_Register
{


    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Drzava");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                

                APIService.UserName = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                await _service.Get<dynamic>(null);

                // string KorisncikoIme = Environment.UserName; -- dobijem ime usera logovanog na komp

                

               


                Form1 frm = new Form1();
                frm.Show();
                
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Atuhentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            Hide();
        }
    }
}
