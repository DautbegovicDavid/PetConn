using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetConn.WinUI.Login_Register
{
    public partial class frmRegister : Form
    {
        private readonly APIService _service=new APIService("Korisnici");
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassConf.Text == "" || txtPassword.Text == "" || txtUsername.Text == "")
                MessageBox.Show("Empty fields are not allowwed !", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (txtPassConf.Text != txtPassword.Text)
            { 
                MessageBox.Show("Unmatching passwords !", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                txtPassword.Text="";
                txtPassConf.Text="";
                txtPassword.Focus();
                return;
            }
            
            Model.Requests.KorisnikUpsertRequest request = new Model.Requests.KorisnikUpsertRequest();
            request.KorisnickoIme = txtUsername.Text;
            request.Password = txtPassword.Text;
            request.PasswordConfirmation = txtPassConf.Text;
            request.Email = "test@email.com";
            request.Ime = "Unesi ime";
            request.Prezime = "Unesi prezime";
            request.Telefon = "000/000-000";
            



            await _service.Insert<Model.Korisnik>(request);
            txtPassword.Text = "";
            txtPassConf.Text = "";
            txtUsername.Text = "";
            MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPassVisibility.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassConf.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtPassConf.PasswordChar = '•';

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassConf.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
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

             
            if (result == DialogResult.Yes)
            {
                  
                Close();

            }


        }

      
    }
}
