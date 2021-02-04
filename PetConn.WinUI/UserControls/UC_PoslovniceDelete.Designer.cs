
namespace PetConn.WinUI.UserControls
{
    partial class UC_PoslovniceDelete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnoVrijemeDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnoVrijemeOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoslovnicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartnerId,
            this.PartnerNaziv,
            this.RadnoVrijemeDo,
            this.RadnoVrijemeOD,
            this.PoslovnicaID,
            this.Email,
            this.Naziv,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // PartnerId
            // 
            this.PartnerId.DataPropertyName = "PartnerId";
            this.PartnerId.HeaderText = "PartnerID";
            this.PartnerId.Name = "PartnerId";
            this.PartnerId.ReadOnly = true;
            // 
            // PartnerNaziv
            // 
            this.PartnerNaziv.DataPropertyName = "Partner";
            this.PartnerNaziv.HeaderText = "PartnerNaziv";
            this.PartnerNaziv.Name = "PartnerNaziv";
            this.PartnerNaziv.ReadOnly = true;
            // 
            // RadnoVrijemeDo
            // 
            this.RadnoVrijemeDo.DataPropertyName = "RadnoVrijemeDo";
            this.RadnoVrijemeDo.HeaderText = "RadnoVrijemeDo";
            this.RadnoVrijemeDo.Name = "RadnoVrijemeDo";
            this.RadnoVrijemeDo.ReadOnly = true;
            // 
            // RadnoVrijemeOD
            // 
            this.RadnoVrijemeOD.DataPropertyName = "RadnoVrijemeOd";
            this.RadnoVrijemeOD.HeaderText = "RadnoVrijemeOD";
            this.RadnoVrijemeOD.Name = "RadnoVrijemeOD";
            this.RadnoVrijemeOD.ReadOnly = true;
            // 
            // PoslovnicaID
            // 
            this.PoslovnicaID.DataPropertyName = "PoslovnicaId";
            this.PoslovnicaID.HeaderText = "PoslovnicaID";
            this.PoslovnicaID.Name = "PoslovnicaID";
            this.PoslovnicaID.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // UC_PoslovniceDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_PoslovniceDelete";
            this.Size = new System.Drawing.Size(707, 320);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnoVrijemeDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnoVrijemeOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoslovnicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
