using PetConn.Model;
using PetConn.Model.Requests;
using PetConn.WinUI.Home_Panels;
using PetConn.WinUI.Login_Register;
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
    public partial class KorisniciEditProfil : UserControl
    {
        APIService _servicePass = new APIService("Korisnici/changePass");
        APIService _serviceGetID = new APIService("Korisnici/getID");

        APIService _service = new APIService("Korisnici");
        public KorisniciEditProfil()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private async void KorisniciEditProfil_Load(object sender, EventArgs e)
        {
            
            List<Korisnik> kor = await _service.Get<List<Korisnik>>(new KorisnikSearchRequest { KorisnickoIme = APIService.UserName });
            Korisnik k = kor.FirstOrDefault();
            txtEmail.Text = k.Email;
            txtName.Text = k.Ime;
            txtSurname.Text = k.Prezime;
            txtUserNAme.Text = k.KorisnickoIme;
            txtPhoneNumb.Text = k.Telefon;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Width = 540;      
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                txtNewPass.PasswordChar = '\0';
                txtOldPass.PasswordChar = '\0';
                txtNewPassConfirmation.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '*';
                txtOldPass.PasswordChar = '*';
                txtNewPassConfirmation.PasswordChar = '*';
            }
        }

        private async void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtNewPassConfirmation.Text)
            { 
                MessageBox.Show("New passwords do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            KorisnikChangePass request = new KorisnikChangePass { KorisnickoIme = txtUserNAme.Text, NoviPass = txtNewPass.Text, pass = txtOldPass.Text };
            bool x = await _servicePass.ChangePass<bool>(request);
            if(x==false)
            { 
                MessageBox.Show("Old Password Incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            MessageBox.Show("Password succesfully changed !\n Please log in.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form hehe = FindForm();
            hehe.Dispose();
            hehe.Close();

            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
                
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            KorisnikUpsertRequest request = new KorisnikUpsertRequest();
            request.Email = txtEmail.Text;
            request.KorisnickoIme = txtUserNAme.Text;
            request.Ime = txtName.Text;
            request.Prezime = txtSurname.Text;
            request.Telefon = txtPhoneNumb.Text;
            int id = await _serviceGetID.Get<int>(new KorisnikSearchRequest { KorisnickoIme = APIService.UserName });
            Model.Korisnik k = await _service.Update<Korisnik>(id, request);
            MessageBox.Show("Changed completed", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtEmail.Text = k.Email;
            txtName.Text = k.Ime;
            txtSurname.Text = k.Prezime;
            txtUserNAme.Text = k.KorisnickoIme;
            txtPhoneNumb.Text = k.Telefon;
            APIService.UserName = k.KorisnickoIme;

            if (k.Email.Equals("test@email.com") &&
                    k.Ime.Equals("Unesi ime") &&
                    k.Prezime.Equals("Unesi prezime") &&
                    k.Telefon.Equals("000/000-000"))
                APIService.EditovanProfil = false;
            else APIService.EditovanProfil = true;

        }
    }
}
