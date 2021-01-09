
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
            if (txtPassword.Text == "" || txtUsername.Text == "")
                MessageBox.Show("Empty fields are not allowwed !", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                

                APIService.UserName = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                await _service.Get<dynamic>(null);

                new Form1().Show();
                Hide();     
                
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            const string message =
                 "Are you sure that you would like to close the application?";
            const string caption = "Exit application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);

            // If the no button was pressed ...  
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.  
                Close();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassVisibilty.Checked)           
                txtPassword.PasswordChar = '\0';              
            else
                txtPassword.PasswordChar = '•';      
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }
    }
}
