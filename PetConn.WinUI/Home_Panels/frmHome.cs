using PetConn.Model.Requests;
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

namespace PetConn.WinUI.Home_Panels
{
    public partial class frmHome : Form
    {
        APIService _serviceVP = new APIService("VrstePartnera");
        APIService _serviceP = new APIService("Partner");
        APIService _servicePoslovnica = new APIService("Poslovnica");


        int panelWidth;
        bool Hidden;
        public frmHome()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
            Hidden = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Partners")
            {
                txtSlidePanelTitle.Text = "Partners";
                if (Hidden)
                    timer1.Start();
            }
            else
            {
                timer1.Start();
            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
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
                Application.Exit();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {   
                panelSlide.Width = panelSlide.Width+15;
                if (panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    Refresh();

                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 15;
                if(panelSlide.Width<=0)
                {
                    timer1.Stop();
                    Hidden = true;
                    Refresh();
                }
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Wanna take a break ?", "Sign out",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();               
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
                else
            WindowState = FormWindowState.Maximized;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Add users")
            {
                txtSlidePanelTitle.Text = "Add users";
                if (Hidden)
                    timer1.Start();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Manage users")
            {
                txtSlidePanelTitle.Text = "Manage users";
                if (Hidden)
                    timer1.Start();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Add partner")
            {
                txtSlidePanelTitle.Text = "Add partner";
                if (Hidden)
                    timer1.Start();
            }
            else
            {
                timer1.Start();
            }
        }

      

        private async void ucPartners1_PetShop_Click(object sender, EventArgs e)
        {
            
            int vrstaPartneraID = await _serviceVP.GetVrstaPartneraID<int>(new VrstaPartnera { Naziv="Pet Shop"});
            
            List<int> partneri = await _serviceP.GetPartnresIDs<List<int>>(new PartneriSearchRequest { VrstaPartneraId = vrstaPartneraID });//cannot convert- __FIX__ -  var jObj2 = JsonConvert.DeserializeObject<List<Model.Print>>(strJson);
            foreach(var x in partneri)
            {
                dgvPodaci.DataSource += await _servicePoslovnica.Get<dynamic>(new PoslovnicaSearchRequest { PartnerId = x });
            }
            
            groupBox1.Text = "Poslovnice";
            
           

        }

        

        private async void ucPartners_PetCarer_Click(object sender, EventArgs e)
        {
            var vrstaPartneraID = await _serviceVP.GetVrstaPartneraID<dynamic>(new VrstaPartnera { Naziv = "Pet Carer" });

        }

        private async void ucPartners_Hotel_Apartment_Click(object sender, EventArgs e)
        {
            var vrstaPartneraAID = await _serviceVP.GetVrstaPartneraID<dynamic>(new VrstaPartnera { Naziv = "Apartment" });
            var vrstaPartneraHiD = await _serviceVP.GetVrstaPartneraID<dynamic>(new VrstaPartnera { Naziv = "Hotel" });

        }

        private void ucPartners_VetStation_Click(object sender, EventArgs e)
        {

        }

        
    }
}
