﻿
namespace PetConn.WinUI.UserControls
{
    partial class UCPoslovnicaInsert
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPoslovnicaInsert));
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblPartner = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.vrijemeOD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.vrijemeDo = new System.Windows.Forms.DateTimePicker();
            this.txtNazivPoslovnice = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.pictureBoxPoslovnica = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnAddPartner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoslovnica)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(31, 93);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(100, 21);
            this.cmbLokacija.TabIndex = 0;
            // 
            // cmbPartner
            // 
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(191, 93);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(119, 21);
            this.cmbPartner.TabIndex = 1;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLokacija.Location = new System.Drawing.Point(28, 73);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(59, 16);
            this.lblLokacija.TabIndex = 3;
            this.lblLokacija.Text = "Location";
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPartner.Location = new System.Drawing.Point(188, 73);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(51, 16);
            this.lblPartner.TabIndex = 4;
            this.lblPartner.Text = "Partner";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(115, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(143, 25);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Unesite poslovnicu";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(341, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // vrijemeOD
            // 
            this.vrijemeOD.CustomFormat = "";
            this.vrijemeOD.Location = new System.Drawing.Point(31, 148);
            this.vrijemeOD.Name = "vrijemeOD";
            this.vrijemeOD.Size = new System.Drawing.Size(100, 20);
            this.vrijemeOD.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Work Hours";
            // 
            // vrijemeDo
            // 
            this.vrijemeDo.CustomFormat = "";
            this.vrijemeDo.Location = new System.Drawing.Point(31, 174);
            this.vrijemeDo.Name = "vrijemeDo";
            this.vrijemeDo.Size = new System.Drawing.Size(100, 20);
            this.vrijemeDo.TabIndex = 22;
            // 
            // txtNazivPoslovnice
            // 
            this.txtNazivPoslovnice.Location = new System.Drawing.Point(31, 229);
            this.txtNazivPoslovnice.Name = "txtNazivPoslovnice";
            this.txtNazivPoslovnice.Size = new System.Drawing.Size(123, 20);
            this.txtNazivPoslovnice.TabIndex = 23;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNaziv.Location = new System.Drawing.Point(28, 210);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 16);
            this.lblNaziv.TabIndex = 24;
            this.lblNaziv.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(28, 264);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Phone number";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(31, 338);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(123, 20);
            this.txtTelefon.TabIndex = 27;
            // 
            // pictureBoxPoslovnica
            // 
            this.pictureBoxPoslovnica.Location = new System.Drawing.Point(191, 148);
            this.pictureBoxPoslovnica.Name = "pictureBoxPoslovnica";
            this.pictureBoxPoslovnica.Size = new System.Drawing.Size(166, 101);
            this.pictureBoxPoslovnica.TabIndex = 29;
            this.pictureBoxPoslovnica.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPicture.FlatAppearance.BorderSize = 2;
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPicture.Location = new System.Drawing.Point(273, 264);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(84, 25);
            this.btnAddPicture.TabIndex = 30;
            this.btnAddPicture.Text = "Add picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(191, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLocation.Image")));
            this.btnAddLocation.Location = new System.Drawing.Point(134, 80);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(44, 44);
            this.btnAddLocation.TabIndex = 32;
            this.btnAddLocation.UseVisualStyleBackColor = true;
            
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPartner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPartner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPartner.FlatAppearance.BorderSize = 0;
            this.btnAddPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartner.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPartner.Image")));
            this.btnAddPartner.Location = new System.Drawing.Point(313, 80);
            this.btnAddPartner.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(44, 44);
            this.btnAddPartner.TabIndex = 33;
            this.btnAddPartner.UseVisualStyleBackColor = true;
            
            // 
            // UCPoslovnicaInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pictureBoxPoslovnica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNazivPoslovnice);
            this.Controls.Add(this.vrijemeDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vrijemeOD);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblPartner);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.cmbPartner);
            this.Controls.Add(this.cmbLokacija);
            this.Name = "UCPoslovnicaInsert";
            this.Size = new System.Drawing.Size(385, 399);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoslovnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbLokacija;
        public System.Windows.Forms.ComboBox cmbPartner;
        public System.Windows.Forms.Label lblLokacija;
        public System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DateTimePicker vrijemeOD;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker vrijemeDo;
        public System.Windows.Forms.TextBox txtNazivPoslovnice;
        public System.Windows.Forms.Label lblNaziv;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.PictureBox pictureBoxPoslovnica;
        public System.Windows.Forms.Button btnAddPicture;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnAddLocation;
        public System.Windows.Forms.Button btnAddPartner;
    }
}