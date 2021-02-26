
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePetShop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.ucPartners1 = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners2 = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners3 = new PetConn.WinUI.UserControls.UCPartners();
            this.ucPartners4 = new PetConn.WinUI.UserControls.UCPartners();
            this.btnTakeABreak = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
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
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.lblUserName);
            this.panelButtons.Controls.Add(this.btnTakeABreak);
            this.panelButtons.Controls.Add(this.ucPartners4);
            this.panelButtons.Controls.Add(this.ucPartners3);
            this.panelButtons.Controls.Add(this.ucPartners2);
            this.panelButtons.Controls.Add(this.ucPartners1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 50);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(268, 509);
            this.panelButtons.TabIndex = 2;
            // 
            // ucPartners1
            // 
            this.ucPartners1.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners1.Location = new System.Drawing.Point(10, 91);
            this.ucPartners1.Name = "ucPartners1";
            this.ucPartners1.nazivPartnera = "Shops";
            this.ucPartners1.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners1.petShopImage")));
            this.ucPartners1.Size = new System.Drawing.Size(258, 70);
            this.ucPartners1.TabIndex = 3;
            // 
            // ucPartners2
            // 
            this.ucPartners2.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners2.Location = new System.Drawing.Point(10, 167);
            this.ucPartners2.Name = "ucPartners2";
            this.ucPartners2.nazivPartnera = "Items";
            this.ucPartners2.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners2.petShopImage")));
            this.ucPartners2.Size = new System.Drawing.Size(258, 70);
            this.ucPartners2.TabIndex = 4;
            // 
            // ucPartners3
            // 
            this.ucPartners3.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners3.Location = new System.Drawing.Point(10, 243);
            this.ucPartners3.Name = "ucPartners3";
            this.ucPartners3.nazivPartnera = "Orders";
            this.ucPartners3.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners3.petShopImage")));
            this.ucPartners3.Size = new System.Drawing.Size(258, 70);
            this.ucPartners3.TabIndex = 5;
            // 
            // ucPartners4
            // 
            this.ucPartners4.BackColor = System.Drawing.Color.DarkCyan;
            this.ucPartners4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartners4.Location = new System.Drawing.Point(10, 319);
            this.ucPartners4.Name = "ucPartners4";
            this.ucPartners4.nazivPartnera = "Employees";
            this.ucPartners4.petShopImage = ((System.Drawing.Image)(resources.GetObject("ucPartners4.petShopImage")));
            this.ucPartners4.Size = new System.Drawing.Size(258, 70);
            this.ucPartners4.TabIndex = 6;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(267, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 509);
            this.panel2.TabIndex = 8;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(12, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 19);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Welcome";
            // 
            // frmHomePetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(974, 559);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomePetShop";
            this.Text = "frmHomePetShop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
        private UserControls.UCPartners ucPartners4;
        private UserControls.UCPartners ucPartners3;
        private UserControls.UCPartners ucPartners2;
        private UserControls.UCPartners ucPartners1;
        private System.Windows.Forms.Button btnTakeABreak;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel2;
    }
}