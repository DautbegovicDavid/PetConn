
namespace PetConn.WinUI.Home_Panels
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTakeABreak = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.txtSlidePanelTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelFilterControls = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.cmbVrstaPartnera = new System.Windows.Forms.ComboBox();
            this.cmbPartneri = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.ucPartners_Apartment = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners_PetCarer = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners_Hotel = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners_VetStation = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners_PetShop = new PetConn.WinUI.UserControls.UCPartners();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelFilterControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(759, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 44);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(709, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 44);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(806, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "PetConn Home panel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnTakeABreak);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 433);
            this.panel2.TabIndex = 1;
            // 
            // btnTakeABreak
            // 
            this.btnTakeABreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTakeABreak.BackColor = System.Drawing.Color.Teal;
            this.btnTakeABreak.FlatAppearance.BorderSize = 0;
            this.btnTakeABreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTakeABreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeABreak.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeABreak.Image")));
            this.btnTakeABreak.Location = new System.Drawing.Point(5, 378);
            this.btnTakeABreak.Name = "btnTakeABreak";
            this.btnTakeABreak.Size = new System.Drawing.Size(53, 52);
            this.btnTakeABreak.TabIndex = 5;
            this.btnTakeABreak.UseVisualStyleBackColor = false;
            this.btnTakeABreak.Click += new System.EventHandler(this.btnTakeABreak_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(5, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 52);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(5, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 52);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(5, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 52);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(5, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 52);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Teal;
            this.panelSlide.Controls.Add(this.ucPartners_Apartment);
            this.panelSlide.Controls.Add(this.ucPartners_PetCarer);
            this.panelSlide.Controls.Add(this.ucPartners_Hotel);
            this.panelSlide.Controls.Add(this.txtSlidePanelTitle);
            this.panelSlide.Controls.Add(this.ucPartners_VetStation);
            this.panelSlide.Controls.Add(this.ucPartners_PetShop);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(61, 47);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(240, 433);
            this.panelSlide.TabIndex = 2;
            // 
            // txtSlidePanelTitle
            // 
            this.txtSlidePanelTitle.AutoSize = true;
            this.txtSlidePanelTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlidePanelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSlidePanelTitle.Location = new System.Drawing.Point(70, 15);
            this.txtSlidePanelTitle.Name = "txtSlidePanelTitle";
            this.txtSlidePanelTitle.Size = new System.Drawing.Size(65, 23);
            this.txtSlidePanelTitle.TabIndex = 2;
            this.txtSlidePanelTitle.Text = "Partners";
            // 
            // timer1
            // 
            this.timer1.Interval = 7;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.panelFilterControls);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(301, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 433);
            this.panel3.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(508, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 32);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkCyan;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(300, 393);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 28);
            this.button8.TabIndex = 9;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkCyan;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(160, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "Edit";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(23, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelFilterControls
            // 
            this.panelFilterControls.Controls.Add(this.label5);
            this.panelFilterControls.Controls.Add(this.label4);
            this.panelFilterControls.Controls.Add(this.label3);
            this.panelFilterControls.Controls.Add(this.cmbGradovi);
            this.panelFilterControls.Controls.Add(this.cmbVrstaPartnera);
            this.panelFilterControls.Controls.Add(this.cmbPartneri);
            this.panelFilterControls.Location = new System.Drawing.Point(174, 13);
            this.panelFilterControls.Name = "panelFilterControls";
            this.panelFilterControls.Size = new System.Drawing.Size(328, 49);
            this.panelFilterControls.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(171, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Partner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vrsta partnera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(282, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grad";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.BackColor = System.Drawing.Color.Teal;
            this.cmbGradovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGradovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradovi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(228, 3);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(92, 23);
            this.cmbGradovi.TabIndex = 3;
            // 
            // cmbVrstaPartnera
            // 
            this.cmbVrstaPartnera.BackColor = System.Drawing.Color.Teal;
            this.cmbVrstaPartnera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVrstaPartnera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVrstaPartnera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbVrstaPartnera.FormattingEnabled = true;
            this.cmbVrstaPartnera.Location = new System.Drawing.Point(5, 2);
            this.cmbVrstaPartnera.Name = "cmbVrstaPartnera";
            this.cmbVrstaPartnera.Size = new System.Drawing.Size(102, 23);
            this.cmbVrstaPartnera.TabIndex = 5;
            this.cmbVrstaPartnera.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaPartnera_SelectedIndexChanged);
            // 
            // cmbPartneri
            // 
            this.cmbPartneri.BackColor = System.Drawing.Color.Teal;
            this.cmbPartneri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPartneri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartneri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbPartneri.FormattingEnabled = true;
            this.cmbPartneri.Location = new System.Drawing.Point(113, 2);
            this.cmbPartneri.Name = "cmbPartneri";
            this.cmbPartneri.Size = new System.Drawing.Size(109, 23);
            this.cmbPartneri.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(137, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(31, 32);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRIKAZ PODATAKA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dgvPodaci);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista svih ";
            this.groupBox1.Visible = false;
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvPodaci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPodaci.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvPodaci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPodaci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPodaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPodaci.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPodaci.EnableHeadersVisualStyles = false;
            this.dgvPodaci.GridColor = System.Drawing.Color.White;
            this.dgvPodaci.Location = new System.Drawing.Point(3, 26);
            this.dgvPodaci.Margin = new System.Windows.Forms.Padding(20);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.Size = new System.Drawing.Size(500, 289);
            this.dgvPodaci.TabIndex = 0;
            this.dgvPodaci.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPodaci_DataError);
            // 
            // ucPartners_Apartment
            // 
            this.ucPartners_Apartment.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_Apartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_Apartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_Apartment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_Apartment.Location = new System.Drawing.Point(0, 278);
            this.ucPartners_Apartment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_Apartment.Name = "ucPartners_Apartment";
            this.ucPartners_Apartment.nazivPartnera = "Apartments";
            this.ucPartners_Apartment.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_Apartment.petShopImage")));
            this.ucPartners_Apartment.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_Apartment.TabIndex = 5;
            this.ucPartners_Apartment.Click += new System.EventHandler(this.ucPartners_Apartment_Click);
            // 
            // ucPartners_PetCarer
            // 
            this.ucPartners_PetCarer.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_PetCarer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_PetCarer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_PetCarer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_PetCarer.Location = new System.Drawing.Point(0, 354);
            this.ucPartners_PetCarer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_PetCarer.Name = "ucPartners_PetCarer";
            this.ucPartners_PetCarer.nazivPartnera = "Pet Carers";
            this.ucPartners_PetCarer.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_PetCarer.petShopImage")));
            this.ucPartners_PetCarer.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_PetCarer.TabIndex = 4;
            this.ucPartners_PetCarer.Click += new System.EventHandler(this.ucPartners_PetCarer_Click);
            // 
            // ucPartners_Hotel
            // 
            this.ucPartners_Hotel.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_Hotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_Hotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_Hotel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_Hotel.Location = new System.Drawing.Point(0, 202);
            this.ucPartners_Hotel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_Hotel.Name = "ucPartners_Hotel";
            this.ucPartners_Hotel.nazivPartnera = "Hotels";
            this.ucPartners_Hotel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ucPartners_Hotel.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_Hotel.petShopImage")));
            this.ucPartners_Hotel.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_Hotel.TabIndex = 3;
            this.ucPartners_Hotel.Click += new System.EventHandler(this.ucPartners_Hotel_Click);
            // 
            // ucPartners_VetStation
            // 
            this.ucPartners_VetStation.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_VetStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_VetStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_VetStation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_VetStation.Location = new System.Drawing.Point(0, 126);
            this.ucPartners_VetStation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_VetStation.Name = "ucPartners_VetStation";
            this.ucPartners_VetStation.nazivPartnera = "Vet Stations";
            this.ucPartners_VetStation.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_VetStation.petShopImage")));
            this.ucPartners_VetStation.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_VetStation.TabIndex = 0;
            this.ucPartners_VetStation.Click += new System.EventHandler(this.ucPartners_VetStation_Click);
            // 
            // ucPartners_PetShop
            // 
            this.ucPartners_PetShop.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_PetShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_PetShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_PetShop.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_PetShop.Location = new System.Drawing.Point(0, 50);
            this.ucPartners_PetShop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_PetShop.Name = "ucPartners_PetShop";
            this.ucPartners_PetShop.nazivPartnera = "Pet Shops";
            this.ucPartners_PetShop.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_PetShop.petShopImage")));
            this.ucPartners_PetShop.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_PetShop.TabIndex = 1;
            this.ucPartners_PetShop.Click += new System.EventHandler(this.ucPartners1_PetShop_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelFilterControls.ResumeLayout(false);
            this.panelFilterControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTakeABreak;
        private System.Windows.Forms.Timer timer1;
        private UserControls.UCPartners ucPartners_PetShop;
        private System.Windows.Forms.Button btnMaximize;
        private UserControls.UCPartners ucPartners_VetStation;
        private System.Windows.Forms.Label txtSlidePanelTitle;
        private UserControls.UCPartners ucPartners_Hotel;
        private UserControls.UCPartners ucPartners_PetCarer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbPartneri;
        private System.Windows.Forms.ComboBox cmbVrstaPartnera;
        private System.Windows.Forms.Panel panelFilterControls;
        private UserControls.UCPartners ucPartners_Apartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnRefresh;
    }
}