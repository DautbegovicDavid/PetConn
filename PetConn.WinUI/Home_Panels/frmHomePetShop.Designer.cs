
namespace PetConn.WinUI.Home_Panels
{
    partial class frmHomePetShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePetShop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPartnerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUrediProfil = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnTakeABreak = new System.Windows.Forms.Button();
            this.ucEmployees = new PetConn.WinUI.UserControls.UCPartners();
            this.ucOrders = new PetConn.WinUI.UserControls.UCPartners();
            this.ucItems = new PetConn.WinUI.UserControls.UCPartners();
            this.ucShops = new PetConn.WinUI.UserControls.UCPartners();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxEditovanProfil = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditovanProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblPartnerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 50);
            this.panel1.TabIndex = 1;
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPartnerName.Location = new System.Drawing.Point(200, 13);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(75, 24);
            this.lblPartnerName.TabIndex = 12;
            this.lblPartnerName.Text = "Partner:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pet Shop home panel";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(883, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 44);
            this.btnMaximize.TabIndex = 10;
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
            this.btnMinimize.Location = new System.Drawing.Point(833, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 44);
            this.btnMinimize.TabIndex = 8;
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
            this.btnClose.Location = new System.Drawing.Point(930, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.pictureBoxEditovanProfil);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnUrediProfil);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.lblUser);
            this.panelButtons.Controls.Add(this.lblUserName);
            this.panelButtons.Controls.Add(this.btnTakeABreak);
            this.panelButtons.Controls.Add(this.ucEmployees);
            this.panelButtons.Controls.Add(this.ucOrders);
            this.panelButtons.Controls.Add(this.ucItems);
            this.panelButtons.Controls.Add(this.ucShops);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 50);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(261, 509);
            this.panelButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(138, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUrediProfil
            // 
            this.btnUrediProfil.FlatAppearance.BorderSize = 0;
            this.btnUrediProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrediProfil.Image")));
            this.btnUrediProfil.Location = new System.Drawing.Point(204, 33);
            this.btnUrediProfil.Name = "btnUrediProfil";
            this.btnUrediProfil.Size = new System.Drawing.Size(53, 52);
            this.btnUrediProfil.TabIndex = 11;
            this.btnUrediProfil.UseVisualStyleBackColor = true;
            this.btnUrediProfil.Click += new System.EventHandler(this.btnUrediProfil_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(138, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(12, 51);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "UserName";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(12, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(64, 23);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Welcome";
            // 
            // btnTakeABreak
            // 
            this.btnTakeABreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTakeABreak.BackColor = System.Drawing.Color.Teal;
            this.btnTakeABreak.FlatAppearance.BorderSize = 0;
            this.btnTakeABreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTakeABreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeABreak.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeABreak.Image")));
            this.btnTakeABreak.Location = new System.Drawing.Point(0, 457);
            this.btnTakeABreak.Name = "btnTakeABreak";
            this.btnTakeABreak.Size = new System.Drawing.Size(53, 52);
            this.btnTakeABreak.TabIndex = 7;
            this.btnTakeABreak.UseVisualStyleBackColor = false;
            this.btnTakeABreak.Click += new System.EventHandler(this.btnTakeABreak_Click);
            // 
            // ucEmployees
            // 
            this.ucEmployees.BackColor = System.Drawing.Color.DarkCyan;
            this.ucEmployees.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEmployees.Location = new System.Drawing.Point(0, 319);
            this.ucEmployees.Name = "ucEmployees";
            this.ucEmployees.nazivPartnera = "Employees";
            this.ucEmployees.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucEmployees.petShopImage")));
            this.ucEmployees.Size = new System.Drawing.Size(258, 70);
            this.ucEmployees.TabIndex = 6;
            this.ucEmployees.Click += new System.EventHandler(this.ucEmployees_Click);
            // 
            // ucOrders
            // 
            this.ucOrders.BackColor = System.Drawing.Color.DarkCyan;
            this.ucOrders.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucOrders.Location = new System.Drawing.Point(0, 243);
            this.ucOrders.Name = "ucOrders";
            this.ucOrders.nazivPartnera = "Orders";
            this.ucOrders.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucOrders.petShopImage")));
            this.ucOrders.Size = new System.Drawing.Size(258, 70);
            this.ucOrders.TabIndex = 5;
            // 
            // ucItems
            // 
            this.ucItems.BackColor = System.Drawing.Color.DarkCyan;
            this.ucItems.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucItems.Location = new System.Drawing.Point(0, 167);
            this.ucItems.Name = "ucItems";
            this.ucItems.nazivPartnera = "Items";
            this.ucItems.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucItems.petShopImage")));
            this.ucItems.Size = new System.Drawing.Size(258, 70);
            this.ucItems.TabIndex = 4;
            // 
            // ucShops
            // 
            this.ucShops.BackColor = System.Drawing.Color.DarkCyan;
            this.ucShops.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucShops.Location = new System.Drawing.Point(0, 91);
            this.ucShops.Name = "ucShops";
            this.ucShops.nazivPartnera = "Shops";
            this.ucShops.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucShops.petShopImage")));
            this.ucShops.Size = new System.Drawing.Size(258, 70);
            this.ucShops.TabIndex = 3;
            this.ucShops.Click += new System.EventHandler(this.ucShops_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkCyan;
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(261, 50);
            this.panelMain.Margin = new System.Windows.Forms.Padding(20, 10, 5, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(713, 509);
            this.panelMain.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(413, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 491);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxEditovanProfil
            // 
            this.pictureBoxEditovanProfil.BackColor = System.Drawing.Color.White;
            this.pictureBoxEditovanProfil.Enabled = false;
            this.pictureBoxEditovanProfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEditovanProfil.Image")));
            this.pictureBoxEditovanProfil.Location = new System.Drawing.Point(241, 33);
            this.pictureBoxEditovanProfil.Name = "pictureBoxEditovanProfil";
            this.pictureBoxEditovanProfil.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxEditovanProfil.TabIndex = 14;
            this.pictureBoxEditovanProfil.TabStop = false;
            this.pictureBoxEditovanProfil.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHomePetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(974, 559);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomePetShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHomePetShop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditovanProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
        private UserControls.UCPartners ucEmployees;
        private UserControls.UCPartners ucOrders;
        private UserControls.UCPartners ucItems;
        private UserControls.UCPartners ucShops;
        private System.Windows.Forms.Button btnTakeABreak;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPartnerName;
        private System.Windows.Forms.Button btnUrediProfil;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxEditovanProfil;
        private System.Windows.Forms.Timer timer1;
    }
}