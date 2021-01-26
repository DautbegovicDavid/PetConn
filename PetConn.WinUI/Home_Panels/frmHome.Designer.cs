
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
            this.button7 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.ucPartners_PetCarer = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners_Hotel_Apartment = new PetConn.WinUI.UserControls.UCPartners();
            this.txtSlidePanelTitle = new System.Windows.Forms.Label();
            this.ucPartners_VetStation = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners_PetShop = new PetConn.WinUI.UserControls.UCPartners();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 47);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(759, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 44);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.btnMinimize.Click += new System.EventHandler(this.button6_Click);
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
            this.panel2.Controls.Add(this.button6);
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
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(5, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 52);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
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
            this.panelSlide.Controls.Add(this.ucPartners_PetCarer);
            this.panelSlide.Controls.Add(this.ucPartners_Hotel_Apartment);
            this.panelSlide.Controls.Add(this.txtSlidePanelTitle);
            this.panelSlide.Controls.Add(this.ucPartners_VetStation);
            this.panelSlide.Controls.Add(this.ucPartners_PetShop);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(61, 47);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(240, 433);
            this.panelSlide.TabIndex = 2;
            // 
            // ucPartners_PetCarer
            // 
            this.ucPartners_PetCarer.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_PetCarer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_PetCarer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_PetCarer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_PetCarer.Location = new System.Drawing.Point(-3, 298);
            this.ucPartners_PetCarer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_PetCarer.Name = "ucPartners_PetCarer";
            this.ucPartners_PetCarer.nazivPartnera = "Pet Carers";
            this.ucPartners_PetCarer.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_PetCarer.petShopImage")));
            this.ucPartners_PetCarer.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_PetCarer.TabIndex = 4;
            this.ucPartners_PetCarer.Click += new System.EventHandler(this.ucPartners_PetCarer_Click);
            // 
            // ucPartners_Hotel_Apartment
            // 
            this.ucPartners_Hotel_Apartment.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_Hotel_Apartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_Hotel_Apartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_Hotel_Apartment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_Hotel_Apartment.Location = new System.Drawing.Point(-3, 222);
            this.ucPartners_Hotel_Apartment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_Hotel_Apartment.Name = "ucPartners_Hotel_Apartment";
            this.ucPartners_Hotel_Apartment.nazivPartnera = "Hotels / Apartments";
            this.ucPartners_Hotel_Apartment.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_Hotel_Apartment.petShopImage")));
            this.ucPartners_Hotel_Apartment.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_Hotel_Apartment.TabIndex = 3;
            this.ucPartners_Hotel_Apartment.Click += new System.EventHandler(this.ucPartners_Hotel_Apartment_Click);
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
            // ucPartners_VetStation
            // 
            this.ucPartners_VetStation.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners_VetStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucPartners_VetStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucPartners_VetStation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners_VetStation.Location = new System.Drawing.Point(-3, 146);
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
            this.ucPartners_PetShop.Location = new System.Drawing.Point(-3, 70);
            this.ucPartners_PetShop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPartners_PetShop.Name = "ucPartners_PetShop";
            this.ucPartners_PetShop.nazivPartnera = "Pet Shops";
            this.ucPartners_PetShop.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners_PetShop.petShopImage")));
            this.ucPartners_PetShop.Size = new System.Drawing.Size(240, 66);
            this.ucPartners_PetShop.TabIndex = 1;
            this.ucPartners_PetShop.Click += new System.EventHandler(this.ucPartners1_PetShop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 7;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(301, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 433);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
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
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista svih ";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPodaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPodaci.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPodaci.EnableHeadersVisualStyles = false;
            this.dgvPodaci.GridColor = System.Drawing.Color.White;
            this.dgvPodaci.Location = new System.Drawing.Point(3, 22);
            this.dgvPodaci.Margin = new System.Windows.Forms.Padding(20);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.Size = new System.Drawing.Size(500, 359);
            this.dgvPodaci.TabIndex = 0;
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private UserControls.UCPartners ucPartners_PetShop;
        private System.Windows.Forms.Button button7;
        private UserControls.UCPartners ucPartners_VetStation;
        private System.Windows.Forms.Label txtSlidePanelTitle;
        private UserControls.UCPartners ucPartners_Hotel_Apartment;
        private UserControls.UCPartners ucPartners_PetCarer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPodaci;
    }
}