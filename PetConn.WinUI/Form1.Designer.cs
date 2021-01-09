
namespace PetConn.WinUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaIme = new System.Windows.Forms.TextBox();
            this.txtPretragaPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVrstaPartnera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisnici);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 16);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.Size = new System.Drawing.Size(770, 284);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(710, 63);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime:";
            // 
            // txtPretragaIme
            // 
            this.txtPretragaIme.Location = new System.Drawing.Point(45, 63);
            this.txtPretragaIme.Name = "txtPretragaIme";
            this.txtPretragaIme.Size = new System.Drawing.Size(182, 20);
            this.txtPretragaIme.TabIndex = 3;
            // 
            // txtPretragaPrezime
            // 
            this.txtPretragaPrezime.Location = new System.Drawing.Point(431, 63);
            this.txtPretragaPrezime.Name = "txtPretragaPrezime";
            this.txtPretragaPrezime.Size = new System.Drawing.Size(182, 20);
            this.txtPretragaPrezime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // cmbUloge
            // 
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(106, 21);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(121, 21);
            this.cmbUloge.TabIndex = 6;
            this.cmbUloge.SelectedIndexChanged += new System.EventHandler(this.cmbUloge_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uloga";
            // 
            // cmbVrstaPartnera
            // 
            this.cmbVrstaPartnera.FormattingEnabled = true;
            this.cmbVrstaPartnera.Location = new System.Drawing.Point(492, 24);
            this.cmbVrstaPartnera.Name = "cmbVrstaPartnera";
            this.cmbVrstaPartnera.Size = new System.Drawing.Size(121, 21);
            this.cmbVrstaPartnera.TabIndex = 8;
            this.cmbVrstaPartnera.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaPartnera_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vrsta partnera";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(249, 101);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(0, 13);
            this.lblKorisnickoIme.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PARTNER";
            // 
            // txtPartner
            // 
            this.txtPartner.Location = new System.Drawing.Point(375, 94);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(100, 20);
            this.txtPartner.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPartner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVrstaPartnera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUloge);
            this.Controls.Add(this.txtPretragaPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretragaIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaIme;
        private System.Windows.Forms.TextBox txtPretragaPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUloge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVrstaPartnera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartner;
    }
}

