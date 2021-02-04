using PetConn.Model;
using PetConn.Model.HelpModels;
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
using System.Reflection;
using PetConn.WinUI.UserControls;
using System.IO;

namespace PetConn.WinUI.Home_Panels
{
    public partial class frmHome : Form
    {

        APIService _serviceVP = new APIService("VrstePartnera");
        APIService _serviceP = new APIService("Partner");
        APIService _servicePoslovnica = new APIService("Poslovnica");
        APIService _serviceGrad = new APIService("Grad");
        APIService _serviceLokacija = new APIService("Lokacija");

        int VrstaPartneraID;


        int panelWidth;
        bool Hidden;
        public frmHome()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
            Hidden = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlide.Width = panelSlide.Width + 15;
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
                if (panelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    Refresh();
                }
            }
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            panelFilterControls.Visible = false;
            groupBox1.Visible = true;
            LoadPartneri(0);
            LoadGradovi();
            LoadVrstePartnera();
            LoadPoslovnice();
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            dgvPodaci.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgvPodaci, true, null);

        }
        //frm Actions
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
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




        //HOME PANEL CONTROLS

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Partners")
            {
                txtSlidePanelTitle.Text = "Partners";
                if (Hidden)
                    timer1.Start();
            }
            else
                timer1.Start();
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
                timer1.Start();
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
                timer1.Start();
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
                timer1.Start();
        }

        //load ComboBoxS
        private async void LoadPartneri(int VPid)
        {
            var listPartneri = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VPid });
            listPartneri.Insert(0, new Partner { Naziv = "Partner" });
            cmbPartneri.DataSource = listPartneri;
            cmbPartneri.DisplayMember = "Naziv";
            cmbPartneri.ValueMember = "PartnerId";
        }
        private async void UC_LoadPartneri(int VPid, ComboBox cmb, bool selectLastItem)
        {
            var listPartneri = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VPid });
            listPartneri.Insert(0, new Partner { Naziv = "Partner" });
            cmb.DataSource = listPartneri;
            cmb.DisplayMember = "Naziv";
            cmb.ValueMember = "PartnerId";
            if (selectLastItem)
                cmb.SelectedIndex = cmb.Items.Count - 1;
        }
        private async void LoadGradovi()
        {
            var listGradovi = await _serviceGrad.Get<List<Grad>>(null);
            listGradovi.Insert(0, new Grad { Naziv = "Grad" });
            cmbGradovi.DataSource = listGradovi;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
        }
        private async void UC_LoadLokacija(ComboBox cmb, bool selectLastItem)
        {
            var listLokacije = await _serviceLokacija.Get<List<Lokacija>>(null);
            listLokacije.Insert(0, new Lokacija { Naziv = "Location" });
            cmb.DataSource = listLokacije;
            cmb.DisplayMember = "Naziv";
            cmb.ValueMember = "LokacijaId";
            if (selectLastItem)
                cmb.SelectedIndex = cmb.Items.Count - 1;
        }
        private async void LoadVrstePartnera()
        {
            var listVrstePartnera = await _serviceVP.Get<List<VrstePartnera>>(null);
            listVrstePartnera.Insert(0, new VrstePartnera { Naziv = "Vrste Partnera" });
            cmbVrstaPartnera.DataSource = listVrstePartnera;
            cmbVrstaPartnera.DisplayMember = "Naziv";
            cmbVrstaPartnera.ValueMember = "VrstaPartneraId";
        }

        //load DGVs
        private async Task LoadPartnerskePoslovnice(int VPid)
        {
            List<int> partneri = await _serviceP.GetPartnresIDs<List<int>>(new PartneriSearchRequest { VrstaPartneraId = VPid });
            List<Model.Poslovnica> poslovnicas = new List<Poslovnica>();
            foreach (var x in partneri)
            {
                poslovnicas.AddRange(await _servicePoslovnica.Get<List<Poslovnica>>(new PoslovnicaSearchRequest { PartnerId = x }));
            }

            dgvPodaci.DataSource = poslovnicas.ToList();
        }
        private async void LoadPoslovnice()
        {
            dgvPodaci.DataSource = await _servicePoslovnica.Get<List<Poslovnica>>(null);
        }

        //GET Vrsta Partnera ID
        private async Task<int> GetVrstaPartneraID(string naziv)
        {
            return await _serviceVP.GetVrstaPartneraID<int>(new VrstaPartnera { Naziv = naziv });
        }

        //controls CLICKs
        private async void ucPartners1_PetShop_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text == "Partners")
                groupBox1.Text = "Business places - Pet Shops";

            groupBox1.Visible = true;

            //DGV Fill
            VrstaPartneraID = await GetVrstaPartneraID("Pet Shop");

            //CMBs Fill
            LoadPartneri(VrstaPartneraID);
            LoadGradovi();
            cmbPartneri.Visible = true;
            cmbGradovi.Visible = true;
            cmbVrstaPartnera.Visible = true;
            cmbVrstaPartnera.SelectedIndex = cmbVrstaPartnera.FindString("Pet Shop");

            await LoadPartnerskePoslovnice(VrstaPartneraID); 
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async void ucPartners_PetCarer_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text == "Partners")
                groupBox1.Text = "Business places - Pet Carers";
            VrstaPartneraID = await GetVrstaPartneraID("Pet Carer");

            //CMBs Fill
            cmbVrstaPartnera.SelectedIndex = cmbVrstaPartnera.FindString("Pet Carer");
            LoadPartneri(VrstaPartneraID);
            cmbPartneri.Visible = true;
            cmbGradovi.Visible = true;
            //DGV Fill
            await LoadPartnerskePoslovnice(VrstaPartneraID);
        }
        private async void ucPartners_Hotel_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text == "Partners")
                groupBox1.Text = "Business places - Hotels";
            VrstaPartneraID = await GetVrstaPartneraID("Hotel");


            cmbVrstaPartnera.SelectedIndex = cmbVrstaPartnera.FindString("Hotel");
            LoadPartneri(VrstaPartneraID);
            LoadGradovi();

            groupBox1.Visible = true;
            await LoadPartnerskePoslovnice(VrstaPartneraID);
        }
        private async void ucPartners_VetStation_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text == "Partners")
                groupBox1.Text = "Business places - Vet Stations";

            VrstaPartneraID = await GetVrstaPartneraID("Vet Station");

            //CMBs Fill
            LoadPartneri(VrstaPartneraID);
            LoadGradovi();
            cmbPartneri.Visible = true;
            cmbGradovi.Visible = true;
            //DGV FIll
            await LoadPartnerskePoslovnice(VrstaPartneraID);
        }
        private async void ucPartners_Apartment_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text == "Partners")
                groupBox1.Text = "Business places - Apartments";
            VrstaPartneraID = await GetVrstaPartneraID("Apartment");

            cmbVrstaPartnera.SelectedIndex = cmbVrstaPartnera.FindString("Apartment");
            LoadPartneri(VrstaPartneraID);
            LoadGradovi();
            await LoadPartnerskePoslovnice(VrstaPartneraID);

            groupBox1.Visible = true;
        }


        //FILTRIRANJE
        private async void btnFilter_Click(object sender, EventArgs e)
        {
            //VISUAL CHANGES
            if (panelFilterControls.Visible == false)
            {
                btnFilter.Location = new Point(460, 13);
                btnRefresh.Location = new Point(495, 13);

                panelFilterControls.Location = new Point(130, 15);
                panelFilterControls.Visible = true;

                return;
            }

            dgvPodaci.DataSource = null;
            dgvPodaci.Rows.Clear();

            List<Poslovnica> poslovnice = new List<Poslovnica>(); 
            List<dynamic> poslovniceDynamic = new List<dynamic>();




            //FILTER U ODNOSU STA PISE TJ KOJI JE SELEKTOVAN
            if (/*cmbGradovi.SelectedIndex != 0 || */cmbPartneri.SelectedIndex != 0)
            {

                if (int.TryParse(cmbGradovi.SelectedValue.ToString(), out int idGrad)) 
                {
                    List<Lokacija> listLokacija = await _serviceLokacija.Get<List<Lokacija>>(new LokacijaSearchRequest { GradId = idGrad });

                    if (int.TryParse(cmbPartneri.SelectedValue.ToString(), out int idPartner))
                    {
                        foreach (var item in listLokacija)
                        {
                            poslovnice.AddRange(await _servicePoslovnica.Get<List<Poslovnica>>(new PoslovnicaSearchRequest { LokacijaId = item.LokacijaId, PartnerId = idPartner }));
                        }
                    }

                }
                poslovniceDynamic.AddRange(poslovnice);
                dgvPodaci.DataSource = poslovniceDynamic.ToList();
                

            }
            else if (cmbVrstaPartnera.SelectedIndex != 0 && cmbGradovi.SelectedIndex != 0)
            {
                if (int.TryParse(cmbVrstaPartnera.SelectedValue.ToString(), out int idVP)) 
                {
                    List<int> partneri = await _serviceP.GetPartnresIDs<List<int>>(new PartneriSearchRequest { VrstaPartneraId = idVP });
                    foreach (var x in partneri)
                    {
                        poslovnice.AddRange(await _servicePoslovnica.Get<List<Poslovnica>>(new PoslovnicaSearchRequest { PartnerId = x }));
                    }
                }
                if (cmbGradovi.SelectedIndex != 0)
                {
                    
                    List<Lokacija> _Lokacija = new List<Lokacija>();
                    if (int.TryParse(cmbGradovi.SelectedValue.ToString(), out int idGrad))
                    {
                        _Lokacija = await _serviceLokacija.Get<List<Lokacija>>(new LokacijaSearchRequest { GradId = idGrad });

                    }
                    List<Poslovnica> temp = new List<Poslovnica>();

                    foreach (Poslovnica p in poslovnice.ToList())
                    {
                        foreach (var Lokacija in _Lokacija)
                        {
                            if (p.LokacijaId == Lokacija.LokacijaId)
                                temp.Add(p);
                        }
                    }

                    poslovnice.Clear();
                    poslovnice = temp;


                }
                poslovniceDynamic.AddRange(poslovnice);
                dgvPodaci.DataSource = poslovniceDynamic.ToList();

            }
            else if (cmbVrstaPartnera.SelectedIndex != 0)
            {
                if (int.TryParse(cmbVrstaPartnera.SelectedValue.ToString(), out int idVP))
                {

                    List<int> partneri = await _serviceP.GetPartnresIDs<List<int>>(new PartneriSearchRequest { VrstaPartneraId = idVP });
                    foreach (var x in partneri)
                    {
                        poslovnice.AddRange(await _servicePoslovnica.Get<List<Poslovnica>>(new PoslovnicaSearchRequest { PartnerId = x }));
                    }


                }
                poslovniceDynamic.AddRange(poslovnice);
                dgvPodaci.DataSource = poslovniceDynamic.ToList();
            }
            else if (cmbGradovi.SelectedIndex != 0)
            {
                List<Lokacija> _Lokacija = new List<Lokacija>();
                if (int.TryParse(cmbGradovi.SelectedValue.ToString(), out int idGrad))
                {
                    _Lokacija = await _serviceLokacija.Get<List<Lokacija>>(new LokacijaSearchRequest { GradId = idGrad });
                }
                foreach (var item in _Lokacija)
                {
                    poslovnice.AddRange(await _servicePoslovnica.Get<List<Poslovnica>>(new PoslovnicaSearchRequest { LokacijaId = item.LokacijaId }));

                }
                poslovniceDynamic.AddRange(poslovnice);
                dgvPodaci.DataSource = poslovniceDynamic.ToList();
            }
            else
                LoadPoslovnice();

        }

        private void cmbVrstaPartnera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbVrstaPartnera.SelectedValue.ToString(), out int idVP))
            {
                LoadPartneri(idVP);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPoslovnice();
            LoadPartneri(0);
            LoadVrstePartnera();
            LoadGradovi();
            groupBox1.Text = "Business places ";
        }



        private void dgvPodaci_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private async void SetUserHelpControl(UCHelpInsert uc)
        {
            uc.Show();
            if (uc.Name == "UC_Lokacija")
            {
                var listGradovi = await _serviceGrad.Get<List<Grad>>(null);
                listGradovi.Insert(0, new Grad { Naziv = "Town" });
                uc.cmbBox.DataSource = listGradovi;
                uc.cmbBox.DisplayMember = "Naziv";
                uc.cmbBox.ValueMember = "GradId";
                uc.lblComboBox.Text = "Town";
                uc.lblFirstEntryField.Text = "Name of location";
                uc.lblSecondEntryField.Text = "Address";
                uc.lblHeader.Text = "Enter location";
                uc.Location = new Point(370, 500);
                panel3.Controls.Add(uc);


            }
            if (uc.Name == "UC_Partner")
            {
                var listVrstePartnera = await _serviceVP.Get<List<VrstePartnera>>(null);
                listVrstePartnera.Insert(0, new VrstePartnera { Naziv = "Type of Partner" });
                uc.cmbBox.DataSource = listVrstePartnera;
                uc.cmbBox.DisplayMember = "Naziv";
                uc.cmbBox.ValueMember = "VrstaPartneraId";
                uc.lblComboBox.Text = "Type of partner";
                uc.lblFirstEntryField.Text = "Name of partner";
                uc.lblSecondEntryField.Visible = false;
                uc.txtBoxSecond.Visible = false;
                uc.lblHeader.Text = "Enter Partner";
                uc.Location = new Point(400, 500);
                panel3.Controls.Add(uc);
            }
        }
        private async void UC_SaveBtn_Click(object sender, EventArgs e, UCHelpInsert uc)
        {

            if (uc.Name == "UC_Lokacija")
            {
                LokacijaUpsertRequest request = new LokacijaUpsertRequest();
                request.Adresa = uc.txtBoxSecond.Text;
                request.Naziv = uc.txtBoxFirst.Text;
                if (int.TryParse(uc.cmbBox.SelectedValue.ToString(), out int idGrad))
                    request.GradId = idGrad;
                await _serviceLokacija.Insert<dynamic>(request);
                MessageBox.Show("Location successfully added", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UC_LoadLokacija(Poslovnica.cmbLokacija, true);
                uc.Visible = false;
            }
            if (uc.Name == "UC_Partner")
            {
                PartneriUpsertRequest request = new PartneriUpsertRequest();
                request.Naziv = uc.txtBoxFirst.Text;
                if (int.TryParse(uc.cmbBox.SelectedValue.ToString(), out int idVP))
                    request.VrstaPartneraId = idVP;
                await _serviceP.Insert<dynamic>(request);
                LoadPartneri(0);
                MessageBox.Show("Partner successfully added", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UC_LoadPartneri(0, Poslovnica.cmbPartner, true);
                uc.Visible = false;
            }
        }

        public UCPoslovnicaInsert Poslovnica = new UCPoslovnicaInsert();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (panel3.Controls.Find("Poslovnica", true).Length == 1)
            {
                Control p = panel3.Controls.Find("Poslovnica", true).FirstOrDefault();
                if (p.Visible == true)
                    return;
            }


            Poslovnica.Name = "Poslovnica";
            Poslovnica.Visible = true;
            panel3.Controls.Add(Poslovnica);
            Poslovnica.Location = new Point(10, 500);

            UC_LoadLokacija(Poslovnica.cmbLokacija, false);
            UC_LoadPartneri(0, Poslovnica.cmbPartner, false);

            UCHelpInsert Lokacija = new UCHelpInsert();
            Lokacija.Name = "UC_Lokacija";

            UCHelpInsert Partner = new UCHelpInsert();
            Partner.Name = "UC_Partner";

            Poslovnica.btnAddLocation.Click += delegate (object sen, EventArgs er)
              {
                  UC_ShowHelpInsertAdders(sender, e, Lokacija);
              };
            Poslovnica.btnAddPartner.Click += delegate (object sen, EventArgs er)
            {
                UC_ShowHelpInsertAdders(sender, e, Partner);
            };
            Poslovnica.btnSave.Click += delegate (object sen, EventArgs er)
            {
                UC_SaveBtn_PoslovnicaInsert(sender, e, Poslovnica);
            };
            Poslovnica.btnAddPicture.Click += delegate (object sen, EventArgs er)
              {
                  UC_btnDodajSliku_Click(sender, e, Poslovnica);
              };
            Lokacija.btnSave.Click += delegate (object sen, EventArgs er)
            {
                UC_SaveBtn_Click(sender, e, Lokacija);
            };
            Partner.btnSave.Click += delegate (object sen, EventArgs er)
            {
                UC_SaveBtn_Click(sender, e, Partner);
            };

        }
        PoslovnicaUpsertRequest request = new PoslovnicaUpsertRequest();
        private async void UC_SaveBtn_PoslovnicaInsert(object sender, EventArgs e, UCPoslovnicaInsert uc)
        {

            request.RadnoVrijemeDo = Poslovnica.vrijemeEntryDo.TimeOfDay;
            request.RadnoVrijemeOd = Poslovnica.vrijemeEntryOd.TimeOfDay;
            if (int.TryParse(uc.cmbLokacija.SelectedValue.ToString(), out int idLokacija))
                request.LokacijaId = idLokacija;
            if (int.TryParse(uc.cmbPartner.SelectedValue.ToString(), out int idPartner))
                request.PartnerId = idPartner;
            request.Naziv = uc.nazivEntry;
            request.Email = uc.emailEntry;
            request.Telefon = uc.phoneEntry;
            await _servicePoslovnica.Insert<Poslovnica>(request);
            MessageBox.Show("Place of business successfully added", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            uc.Visible = false;
            uc.CleanForm();

        }
        private void UC_ShowHelpInsertAdders(object sender, EventArgs e, UCHelpInsert uc)
        {
            SetUserHelpControl(uc);
        }

        private void UC_btnDodajSliku_Click(object sender, EventArgs e, UCPoslovnicaInsert uc)
        {
            var result = Poslovnica.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = Poslovnica.openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;


                Image image = Image.FromFile(fileName);//ucitali sliku sa putanje
                Poslovnica.pictureBoxPoslovnica.Image = image;//prikazali u boxu

                Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                thumb.Save(Path.ChangeExtension(fileName, "thumb"));
                request.SlikaThumb = imageToByteArray(thumb);//radi ali nesto ne valja
            }

        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private async void button8_Click(object sender, EventArgs e)// BUTTON NA MAIN FORMI Klikom otvara user contorlu,DGV
        {
            
            UC_PoslovniceDelete uc_delete = new UC_PoslovniceDelete();
            uc_delete.Name = "UC_Delete";
            panel3.Controls.Add(uc_delete);
            uc_delete.Location = new Point(20, 500);

            uc_delete.dataGridView1.AutoGenerateColumns = false;

            uc_delete.DataSource = null;
            uc_delete.DataSource = await _servicePoslovnica.Get<List<Poslovnica>>(null);
                    

            uc_delete.dataGridView1.CellContentClick += delegate (object sen, DataGridViewCellEventArgs er)
            {
                UC_Delete_Poslovnica(sender, er, uc_delete);
            };

        }
        private void UC_Delete_Poslovnica(object sender, DataGridViewCellEventArgs e, UC_PoslovniceDelete uc)
        {

           

            if (e.ColumnIndex==6)// U pocetku je radilo sa zadnjim sada je na NULI(DELETE BTN) KAKO NEZZ -- zbog autogenerate
            {
                  var _posl =uc.dataGridView1.CurrentRow.DataBoundItem as Poslovnica; //currentRow ispravio prob, kako nemam blage veze (ISTRAZITI)
                    if (_posl != null)
                    {
                        MessageBox.Show("partner ok", _posl.PoslovnicaId.ToString(),
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            
        }

    }
}

