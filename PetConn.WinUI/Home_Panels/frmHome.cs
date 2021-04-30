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
using PetConn.WinUI.Helpers;



namespace PetConn.WinUI.Home_Panels
{
    public partial class frmHome : Form
    {

        private readonly APIService _serviceVP = new APIService("VrstePartnera");
        private readonly APIService _serviceP = new APIService("Partner");
        private readonly APIService _servicePoslovnica = new APIService("Poslovnica");
        private readonly APIService _serviceGrad = new APIService("Grad");
        private readonly APIService _serviceLokacija = new APIService("Lokacija");
        private readonly APIService _serviceUloge = new APIService("Uloge");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        
        //Korisnici bez Rola, Uredjen profil
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer3_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
            if (APIService.EditovanProfil == false)
                pictureBoxProfileInfo.Visible = true;
        }   
        private void timer3_Tick(object sender, EventArgs e)
        {
            GetBrojNeregistrovanihKorisnika();
            if(APIService.EditovanProfil == true)
                pictureBoxProfileInfo.Visible = false;
        }

        int VrstaPartneraID = 0;
        int panelWidth;
        bool Hidden;
        
        // User Controls
        UC_PartneriEdit uc_partneri_edit;
        UC_PartneriDelete uc_partneri_delete;//=new() baca erro na samom pocetku
        UC_PoslovniceUpdate uc_PoslovnicaUpdate;//tabele tj dgv mozda preimenovati ??
        UC_PoslovniceDelete uc_PoslovnicaDelete;
        UCPoslovnicaUpsert UC_PoslovnicaUpsert;
        //Requests
        PoslovnicaUpsertRequest request = new PoslovnicaUpsertRequest();
       
        public frmHome()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
            Hidden = false;
            lblKorisnickoIme.Text = APIService.UserName+" "+APIService.Uloga;
            
            //lblKorisnickoIme.Text = APIService.PartnerID.ToString();
        }
     
        private async void GetBrojNeregistrovanihKorisnika()
        {
            UC_KorisniciEditDelete uc_korisniciEditDelete = new UC_KorisniciEditDelete();
            int brKor = await uc_korisniciEditDelete.GetBrojKorisnika();
            if (brKor > 0)
            {
                txtNotifikacija.Visible = true;
                txtNotifikacija.Text = brKor.ToString();
            }
            else
            {
                txtNotifikacija.Visible = false;
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
            dgvPodaci.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgvPodaci, true, null);
            //GetBrojNeregistrovanihKorisnika();
            InitTimer();
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
        private void dgvPodaci_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

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
                lblManageBtnSHeader.Text = "Manage Business Places";
                panelAddDelEd.Visible = true;
                lblManageBtnSHeader.Location = new Point(491, 393);

                if (Hidden)
                    timer1.Start();
            }
            else
                timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Manage users")
            {
                txtSlidePanelTitle.Text = "Manage users";
                lblManageBtnSHeader.Text = "Manage Users";
                panelAddDelEd.Visible = true;
                lblManageBtnSHeader.Location = new Point(491, 393);

                if (Hidden)
                    timer1.Start();
            }
            else
                timer1.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Manage partners")
            {
                txtSlidePanelTitle.Text = "Manage partners";
                lblManageBtnSHeader.Text = "Manage Partners";
                lblManageBtnSHeader.Location = new Point(491, 393);
                
                panelAddDelEd.Visible = true;

                if (Hidden)
                    timer1.Start();
            }
            else
                timer1.Start();
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            if (txtSlidePanelTitle.Text != "Users")
            {
                txtSlidePanelTitle.Text = "Users";
                lblManageBtnSHeader.Text = "Manage User / Workplace";
                lblManageBtnSHeader.Location = new Point(60, 385);

                panelAddDelEd.Visible = false;
                UC_KorisniciEditDelete uc_korisniciEditDelete = new UC_KorisniciEditDelete();               
                Helper.DodajKontrolu(uc_korisniciEditDelete, "UC_Edit_Delete_Korisnici", new Point(20, 450), panel3);

                //Resizisng additional controls (20,500)->(20,450)
               

                await uc_korisniciEditDelete.LoadDGV();
                
                uc_korisniciEditDelete.LoadCMBs();
                UC_KorisniciEdit uc_korisniciEdit = new UC_KorisniciEdit();               
                Helper.DodajKontrolu(uc_korisniciEdit, "UC_Edit_Korisnici", new Point(550, 450), panel3);
                

                if (Hidden)
                    timer1.Start();
                return;
                
            }
            else
                timer1.Start();
        }
       


        //___LOAD COMBO BOXES___
        //load ComboBoxS
        private async void LoadPartneri(int VPid)
        {
            var listPartneri = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VPid });
            listPartneri.Insert(0, new Partner { Naziv = "Partner" });
            cmbPartneri.DataSource = listPartneri;
            cmbPartneri.DisplayMember = "Naziv";
            cmbPartneri.ValueMember = "PartnerId";
        }
        private async void LoadGradovi()
        {
            var listGradovi = await _serviceGrad.Get<List<Grad>>(null);
            listGradovi.Insert(0, new Grad { Naziv = "Grad" });
            cmbGradovi.DataSource = listGradovi;
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
        }
        private async void LoadVrstePartnera()
        {
            var listVrstePartnera = await _serviceVP.Get<List<VrstePartnera>>(null);
            listVrstePartnera.Insert(0, new VrstePartnera { Naziv = "Vrste Partnera" });
            cmbVrstaPartnera.DataSource = listVrstePartnera;
            cmbVrstaPartnera.DisplayMember = "Naziv";
            cmbVrstaPartnera.ValueMember = "VrstaPartneraId";
        }
        // Load UCs ComboBoxS
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
        private async void UC_LoadPartneriUpdate(int VPid, ComboBox cmb, Poslovnica p)
        {
            var listPartneri = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VPid });
            listPartneri.Insert(0, new Partner { Naziv = "Partner" });
            cmb.DataSource = listPartneri;
            cmb.DisplayMember = "Naziv";
            cmb.ValueMember = "PartnerId";

            //cmb.SelectedIndex = cmb.Items.IndexOf(p.Partner);
            cmb.SelectedValue = p.PartnerId;

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
        private async void UC_LoadLokacijaUpdate(ComboBox cmb, Poslovnica p)
        {
            var listLokacije = await _serviceLokacija.Get<List<Lokacija>>(null);
            listLokacije.Insert(0, new Lokacija { Naziv = "Location" });
            cmb.DataSource = listLokacije;
            cmb.DisplayMember = "Naziv";
            cmb.ValueMember = "LokacijaId";

            cmb.SelectedValue = p.LokacijaId;
        }

        //load Main Forms DGV
        private async Task LoadPartnerskePoslovnice(int VPid)
        {
            List<int> partneri = await _serviceP.GetPartnresIDs<List<int>>(new PartneriSearchRequest { VrstaPartneraId = VPid });
            List<Poslovnica> poslovnicas = new List<Poslovnica>();
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
            //UC PArtnerDelete Setter
            if(uc_partneri_delete!=null)
            uc_partneri_delete.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });
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
            //UC PArtnerDelete Setter
            if(uc_partneri_delete!=null)
            uc_partneri_delete.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });

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
            //UC PArtnerDelete Setter
            if(uc_partneri_delete != null)
            uc_partneri_delete.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });

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
            //UC PArtnerDelete Setter\
            if(uc_partneri_delete!=null)
            uc_partneri_delete.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });//kad kliknem na controle ,nsm inicijalizovao kontrolu a dodajem joj , NULLLLLL
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
            //UC PArtnerDelete Setter
            if(uc_partneri_delete != null)
            uc_partneri_delete.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });

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
            if (cmbPartneri.SelectedIndex != 0)
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
            VrstaPartneraID = 0;
        }

        //Insert UC Location/Partner
        private async void Set_HelpInsert_UCs(UC_HelpInsert uc, Partner p)
        {
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
                if (p != null)
                {
                    uc.firstEntry = p.Naziv;
                    uc.cmbBox.SelectedValue = p.VrstaPartneraId; //
                    uc.Location = new Point(360, 500);
                    return;
                }
            }

            panel3.Controls.Add(uc);
            uc.Show();

            if (UC_PoslovnicaUpsert != null)
            {
                if (UC_PoslovnicaUpsert.Location == new Point(740, 500))
                {
                    uc.Location = new Point(1150, 500);
                    return;
                }
            }
            if(uc.Location.IsEmpty)
            uc.Location = new Point(420, 500);
        }
        private void UC_ShowHelpInsertAdders(object sender, EventArgs e, UC_HelpInsert uc)
        {
            Set_HelpInsert_UCs(uc, null);
        }

        private async void UC_HelpInsertSaveBtn_Click(object sender, EventArgs e, UC_HelpInsert uc, Partner p)
        {
            if (uc.cmbBox.SelectedIndex == 0||uc.firstEntry.Length==0)
            {
                MessageBox.Show("Choose type of partner !\n Empty fields are not allowed !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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
                UC_LoadLokacija(UC_PoslovnicaUpsert.cmbLokacija, true);//setam na insertu da selecte zadnju POSLOVNICEUPSERT
                uc.Visible = false;
            }
            if (uc.Name == "UC_Partner")
            {
                PartneriUpsertRequest request = new PartneriUpsertRequest();
                request.Naziv = uc.txtBoxFirst.Text;
                if (int.TryParse(uc.cmbBox.SelectedValue.ToString(), out int idVP))
                    request.VrstaPartneraId = idVP;

                if(p==null)
                    await _serviceP.Insert<dynamic>(request);
                //zasto else sta radi ??
                else
                {
                    await _serviceP.Update<dynamic>(p.PartnerId, request);
                    uc_partneri_edit.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });
                    MessageBox.Show("Partner successfully updated", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc.Visible = false;
                    return;

                }

                LoadPartneri(0);
                MessageBox.Show("Partner successfully added", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (UC_PoslovnicaUpsert != null)
                {
                    UC_LoadPartneri(0, UC_PoslovnicaUpsert.cmbPartner, true);
                    uc.Visible = false;
                }
            }
        }

        private bool ProvjeriKontrolu(string nazivKontrole)
        {
            if (panel3.Controls.Find(nazivKontrole, true).Length == 1)
            {
                Control p = panel3.Controls.Find(nazivKontrole, true).FirstOrDefault();
                if (p.Visible == true)
                    return true;
            }
            return false;  
        }
        private void UkloniKontrolu()
        {
            if (panel3.Controls.Find("Poslovnica", true).Length == 1)//neki drugi naziv
                panel3.Controls.Remove(UC_PoslovnicaUpsert);   
        }
        private bool ProvjeriHeader(string lblHeader)
        {  
            if (lblManageBtnSHeader.Text == lblHeader)          
               return true;            
            return false;
        }
        //--------------------------------------------------------------------


        //___ADDING___
        private void btnAdd_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            // odradjen custom control 


            if(ProvjeriHeader("Manage Partners"))
            {
                if (ProvjeriKontrolu("UC_Partner"))
                    return;

                UC_HelpInsert uc_partner = new UC_HelpInsert { Name="UC_Partner"};
                uc_partner.Location = new Point(20, 500);
                Set_HelpInsert_UCs(uc_partner, null);
                
                uc_partner.btnSave.Click += delegate (object sen, EventArgs er)
                {
                    UC_HelpInsertSaveBtn_Click(sender, e, uc_partner,null);
                };

                return;
            }
            
            if (ProvjeriKontrolu("Poslovnica"))
                return;

   
            UCPoslovnicaUpsert nova = new UCPoslovnicaUpsert();
            UC_PoslovnicaUpsert=nova;
            UC_PoslovnicaUpsert.Name = "Poslovnica";
            UC_PoslovnicaUpsert.lblHeader.Text = "Add place of business";
            UC_PoslovnicaUpsert.Visible = true;
            panel3.Controls.Add(UC_PoslovnicaUpsert);
            UC_PoslovnicaUpsert.Location = new Point(20, 450);//500->450

            UC_LoadLokacija(UC_PoslovnicaUpsert.cmbLokacija, false);
            UC_LoadPartneri(0, UC_PoslovnicaUpsert.cmbPartner, false);

            UC_HelpInsert Lokacija = new UC_HelpInsert();
            Lokacija.Name = "UC_Lokacija";

            UC_HelpInsert Partner = new UC_HelpInsert();
            Partner.Name = "UC_Partner";

            //UC Helpers Show/Add
            UC_PoslovnicaUpsert.btnAddLocation.Click += delegate (object sen, EventArgs er)
              {
                  UC_ShowHelpInsertAdders(sender, e, Lokacija);
              };
            UC_PoslovnicaUpsert.btnAddPartner.Click += delegate (object sen, EventArgs er)
            {
                UC_ShowHelpInsertAdders(sender, e, Partner);
            };
            Lokacija.btnSave.Click += delegate (object sen, EventArgs er)
            {
                UC_HelpInsertSaveBtn_Click(sender, e, Lokacija,null);
            };
            Partner.btnSave.Click += delegate (object sen, EventArgs er)
            {
                UC_HelpInsertSaveBtn_Click(sender, e, Partner,null);
            };
            //Poslovnica Add
            UC_PoslovnicaUpsert.btnAddPicture.Click += delegate (object sen, EventArgs er)
            {
                UC_btnDodajSliku_Click(sender, e, UC_PoslovnicaUpsert);
            };
            UC_PoslovnicaUpsert.btnSave.Click += delegate (object sen, EventArgs er)
            {
                UC_PoslovnicaUpsert_SaveBtn_Click(sender, e, UC_PoslovnicaUpsert,null);
            };
 
        }    
        private async void UC_PoslovnicaUpsert_SaveBtn_Click(object sender, EventArgs e, UCPoslovnicaUpsert uc,Poslovnica poslovnica)//vidi mozda objekat zadrzi id ???
        {
            request.RadnoVrijemeDo = uc.vrijemeEntryDo.TimeOfDay;
            request.RadnoVrijemeOd = uc.vrijemeEntryOd.TimeOfDay;
            if (int.TryParse(uc.cmbLokacija.SelectedValue.ToString(), out int idLokacija))
                request.LokacijaId = idLokacija;
            if (int.TryParse(uc.cmbPartner.SelectedValue.ToString(), out int idPartner))
                request.PartnerId = idPartner;
            request.Naziv = uc.nazivEntry;
            request.Email = uc.emailEntry;
            request.Telefon = uc.phoneEntry;
            if (uc.pictureBoxPoslovnica.Image != null)
                request.Slika = Helper.FromImageToByte(uc.pictureBoxPoslovnica.Image);
            if (uc.pictureBoxPoslovnica.Image != null)
                    request.SlikaThumb = Helper.FromImageToByteTHUMB(uc.pictureBoxPoslovnica.Image);


            if (poslovnica == null)
            {
                await _servicePoslovnica.Insert<Poslovnica>(request);

                MessageBox.Show("Place of business successfully added", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await _servicePoslovnica.Update<Poslovnica>(poslovnica.PoslovnicaId, request);

                MessageBox.Show("Place of business successfully updated", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                PoslovnicaUpsertRequest novi = new PoslovnicaUpsertRequest();//provjeriti ovo
                request = novi;

                SetPoslovnicaUpdateDGV();
            }

            uc.Visible = false;
            uc.CleanForm();

        }
        //___DELETING___
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            if (ProvjeriHeader("Manage Partners"))
            {
                if (ProvjeriKontrolu("UC_Delete_Partner"))
                    return;

                uc_partneri_delete=new UC_PartneriDelete();
                //testMetodaDGV(uc_partneri_delete, "UC_Delete_Partner", new Point(20, 500));
                Helper.DodajKontrolu(uc_partneri_delete, "UC_Delete_Partner", new Point(20, 450), panel3);//500->450
                
                uc_partneri_delete.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });

                uc_partneri_delete.dataGridView1.CellContentClick += delegate (object sen, DataGridViewCellEventArgs er)
                {
                    UC_Delete_Partner(sender, er, uc_partneri_delete);
                };
                return;
            }
            if (ProvjeriHeader("Manage Users"))
            {

                UC_KorisniciEditDelete uc_korisniciEditDelete = new UC_KorisniciEditDelete();
                //testMetodaDGV(uc_korisniciEditDelete, "UC_Delete_Partner", new Point(20, 500));
                Helper.DodajKontrolu(uc_korisniciEditDelete, "UC_Delete_Partner", new Point(20, 450), panel3);//500->450

                uc_korisniciEditDelete.dataGridView1.DataSource = await _serviceKorisnici.Get<List<Korisnik>>(null);

                uc_korisniciEditDelete.dataGridView1.CellContentClick += delegate (object sen, DataGridViewCellEventArgs er)
                {

                    //UC_Delete_Partner(sender, er, uc_partneri_delete);
                };
                return;
            }

            if (ProvjeriKontrolu("UC_Delete"))
                return;

            uc_PoslovnicaDelete = new UC_PoslovniceDelete();
            //testMetodaDGV(uc_PoslovnicaDelete, "UC_Delete", new Point(20, 500));
            Helper.DodajKontrolu(uc_PoslovnicaDelete, "UC_Delete", new Point(20, 450), panel3);//500->450

            uc_PoslovnicaDelete.DataSource = await _servicePoslovnica.Get<List<Poslovnica>>(null);
            uc_PoslovnicaDelete.dataGridView1.ClearSelection();

            uc_PoslovnicaDelete.dataGridView1.CellContentClick += delegate (object sen, DataGridViewCellEventArgs er)
            {
                UC_Delete_Poslovnica(sender, er, uc_PoslovnicaDelete);
            };

        }
        
        private async void UC_Delete_Partner(object sender, DataGridViewCellEventArgs e, UC_PartneriDelete uc)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)//U pocetku je radilo sa zadnjim sada je na NULI(DELETE BTN) KAKO NEZZ -- zbog autogenerate
            {
                uc_partneri_delete.dataGridView1.Rows[e.RowIndex].Selected = true;
                var _partner = uc.dataGridView1.CurrentRow.DataBoundItem as Partner; //currentRow ispravio prob, kako nemam blage veze (ISTRAZITI)
                if (_partner != null)
                {
                    var result = MessageBox.Show("Do you want to delete this record :\n" + _partner.Naziv.ToString() + " ?", "Delete action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Partner delete = await _serviceP.Delete<Partner>(_partner.PartnerId);

                        MessageBox.Show(delete.Naziv.ToString() + " deleted.", "Delete action successfull", // baca error ne stavi partnera kod brisanja
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        uc_partneri_delete.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID }); ;
                        return;
                    }
                }
            }
        }
        private async void UC_Delete_Poslovnica(object sender, DataGridViewCellEventArgs e, UC_PoslovniceDelete uc)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1)//U pocetku je radilo sa zadnjim sada je na NULI(DELETE BTN) KAKO NEZZ -- zbog autogenerate
            {
                uc_PoslovnicaDelete.dataGridView1.Rows[e.RowIndex].Selected = true;
                var _posl = uc.dataGridView1.CurrentRow.DataBoundItem as Poslovnica; //currentRow ispravio prob, kako nemam blage veze (ISTRAZITI)
                if (_posl != null)
                {
                    var result = MessageBox.Show("Do you want to delete this record :\n" + _posl.Partner.ToString() + " " + _posl.Naziv.ToString() + "?", "Delete action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Poslovnica delete = await _servicePoslovnica.Delete<Poslovnica>(_posl.PoslovnicaId);

                        MessageBox.Show(delete.Naziv.ToString() + " deleted.", "Delete action successfull", // baca error ne stavi partnera kod brisanja
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        uc_PoslovnicaDelete.DataSource = await _servicePoslovnica.Get<List<Poslovnica>>(null);
                        return;
                    }
                }
            }
        }

        private async void SetPoslovnicaUpdateDGV()
        {
            uc_PoslovnicaUpdate.dataGridView1.AutoGenerateColumns = false;

            uc_PoslovnicaUpdate.DataSource = null;
            uc_PoslovnicaUpdate.DataSource = await _servicePoslovnica.Get<List<Poslovnica>>(null);
            uc_PoslovnicaUpdate.dataGridView1.ClearSelection();
        }
        //___EDITING ___
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            if (ProvjeriHeader("Manage Partners"))
            {
                if (ProvjeriKontrolu("UC_Edit_Partner"))
                    return;
            
                
                uc_partneri_edit = new UC_PartneriEdit();

                //testMetodaDGV(uc_partneri_edit, "UC_Edit_Partner", new Point(20, 500));
                Helper.DodajKontrolu(uc_partneri_edit, "UC_Edit_Partner", new Point(20, 450), panel3);//500->450


                uc_partneri_edit.dataGridView1.DataSource = await _serviceP.Get<List<Partner>>(new PartneriSearchRequest { VrstaPartneraId = VrstaPartneraID });

                uc_partneri_edit.dataGridView1.CellContentClick += delegate (object sen, DataGridViewCellEventArgs er)
                {                   
                    UC_Edit_Partner(sender, er, uc_partneri_edit);
                };
                return;
            }

            if (ProvjeriKontrolu("UC_Update"))
                return;           
          
            uc_PoslovnicaUpdate = new UC_PoslovniceUpdate();

            //testMetodaDGV(uc_PoslovnicaUpdate, "UC_Update", new Point(20, 500)); 
            Helper.DodajKontrolu(uc_PoslovnicaUpdate, "UC_Update", new Point(20, 450), panel3);//500->450

            SetPoslovnicaUpdateDGV();

            uc_PoslovnicaUpdate.dataGridView1.CellContentClick += delegate (object sen, DataGridViewCellEventArgs er)
            {
                UkloniKontrolu();
                UC_Update_Poslovnica(sender, er, uc_PoslovnicaUpdate);
            };

        }
        private void UC_Edit_Partner(object sender, DataGridViewCellEventArgs e, UC_PartneriEdit uc)//'izbrisao async ??
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                uc.dataGridView1.Rows[e.RowIndex].Selected = true;
                var _partner = uc.dataGridView1.CurrentRow.DataBoundItem as Partner; 
                if (_partner != null)
                {

                    UC_HelpInsert edit = new UC_HelpInsert();
                    Helper.DodajKontrolu(edit, "UC_Partner", new Point(20, 450),panel3);//500->450
                    //Helper.DodajKontrolu(uc_PoslovnicaUpdate, "UC_Update", new Point(20, 500), panel3);

                    Set_HelpInsert_UCs(edit, _partner);
 
                    edit.btnSave.Click += delegate (object sen, EventArgs er)
                    {
                        UC_HelpInsertSaveBtn_Click(sender, e, edit,_partner);
                    };          
                }
            }

        }
        private void UC_Update_Poslovnica(object sender, DataGridViewCellEventArgs e, UC_PoslovniceUpdate uc)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                uc_PoslovnicaUpdate.dataGridView1.Rows[e.RowIndex].Selected = true;
                var _posl = uc.dataGridView1.CurrentRow.DataBoundItem as Poslovnica;


                if (panel3.Controls.Find("Poslovnica", true).Length == 1)
                {
                    Control p = panel3.Controls.Find("Poslovnica", true).FirstOrDefault();
                    if (p.Visible == true)
                        return;
                }

                
                UC_PoslovnicaUpsert = new UCPoslovnicaUpsert();
                //testMetodaDGV(UC_PoslovnicaUpsert, "Poslovnica", new Point(740, 500));
                Helper.DodajKontrolu(UC_PoslovnicaUpsert, "Poslovnica", new Point(740, 450), panel3);//500->450
                
                UC_LoadLokacijaUpdate(UC_PoslovnicaUpsert.cmbLokacija, _posl);
                UC_LoadPartneriUpdate(0, UC_PoslovnicaUpsert.cmbPartner, _posl);
          
                SetPoslovnicaEdit(_posl);

                UC_HelpInsert Lokacija = new UC_HelpInsert { Name = "UC_Lokacija" };
                UC_HelpInsert Partner = new UC_HelpInsert { Name = "UC_Partner" };
                

                UC_PoslovnicaUpsert.btnAddLocation.Click += delegate (object sen, EventArgs er)
                {
                    UC_ShowHelpInsertAdders(sender, e, Lokacija);
                };
                UC_PoslovnicaUpsert.btnAddPartner.Click += delegate (object sen, EventArgs er)
                {
                    UC_ShowHelpInsertAdders(sender, e, Partner);
                };
                UC_PoslovnicaUpsert.btnSave.Click += delegate (object sen, EventArgs er)
                {
                    UC_PoslovnicaUpsert_SaveBtn_Click(sender, e, UC_PoslovnicaUpsert, _posl);
                };
                UC_PoslovnicaUpsert.btnAddPicture.Click += delegate (object sen, EventArgs er)
                {
                    UC_btnDodajSliku_Click(sender, e, UC_PoslovnicaUpsert);
                };

                Lokacija.btnSave.Click += delegate (object sen, EventArgs er)
                {
                    UC_HelpInsertSaveBtn_Click(sender, e, Lokacija, null);
                };
                Partner.btnSave.Click += delegate (object sen, EventArgs er)
                {
                    UC_HelpInsertSaveBtn_Click(sender, e, Partner, null);
                };
            }
        }

        private void SetPoslovnicaEdit(Poslovnica p)
        {           
            UC_PoslovnicaUpsert.nazivEntry = p.Naziv;
            UC_PoslovnicaUpsert.phoneEntry = p.Telefon;
            UC_PoslovnicaUpsert.emailEntry = p.Email;
            UC_PoslovnicaUpsert.vrijemeEntryDo = new DateTime(2012,05,28).Add(p.RadnoVrijemeDo.Value);
            UC_PoslovnicaUpsert.vrijemeEntryOd = new DateTime(2012, 05, 28).Add(p.RadnoVrijemeOd.Value);
            if(p.Slika.Length!=0)
            UC_PoslovnicaUpsert.pictureBoxPoslovnica.Image = Helper.FromByteToImage(p.Slika);
            UC_PoslovnicaUpsert.lblHeader.Text = "Edit place of business";
        }
       
        private void UC_btnDodajSliku_Click(object sender, EventArgs e, UCPoslovnicaUpsert uc)
        {
            var result = UC_PoslovnicaUpsert.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = UC_PoslovnicaUpsert.openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;

                Image image = Image.FromFile(fileName);//ucitali sliku sa putanje
                UC_PoslovnicaUpsert.pictureBoxPoslovnica.Image = image;//prikazali u boxu

                Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                thumb.Save(Path.ChangeExtension(fileName, "thumb"));
                request.SlikaThumb = Helper.FromImageToByteTHUMB(thumb);//radi ali nesto ne valja
                
            }

        }

        private void btnUrediProfil_Click(object sender, EventArgs e)
        {
            KorisniciEditProfil uc_editProfil = new KorisniciEditProfil();
            //testMetoda(uc_editProfil, "UrediKorisnickiProfil", new Point(20,  500));
            Helper.DodajKontrolu(uc_editProfil, "UrediKorisnickiProfil", new Point(20, 450), panel3);//500->450
            //groupBox1.Visible = false;
            //panel3.Controls.Add(uc_editProfil);//nije potebno s obzxirom da sam vec dodao u helper metodi
    
        }

       
    }
}