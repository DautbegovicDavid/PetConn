
namespace PetConn.WinUI.UserControls
{
    partial class UC_HelpInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HelpInsert));
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.txtBoxFirst = new System.Windows.Forms.TextBox();
            this.lblComboBox = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFirstEntryField = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSecondEntryField = new System.Windows.Forms.Label();
            this.txtBoxSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(34, 92);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(125, 21);
            this.cmbBox.TabIndex = 0;
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.Location = new System.Drawing.Point(189, 93);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.Size = new System.Drawing.Size(125, 20);
            this.txtBoxFirst.TabIndex = 4;
            // 
            // lblComboBox
            // 
            this.lblComboBox.AutoSize = true;
            this.lblComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboBox.Location = new System.Drawing.Point(31, 72);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(92, 16);
            this.lblComboBox.TabIndex = 5;
            this.lblComboBox.Text = "Vrsta partnera";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(112, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(116, 23);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Unesite Partnera";
            // 
            // lblFirstEntryField
            // 
            this.lblFirstEntryField.AutoSize = true;
            this.lblFirstEntryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstEntryField.Location = new System.Drawing.Point(186, 74);
            this.lblFirstEntryField.Name = "lblFirstEntryField";
            this.lblFirstEntryField.Size = new System.Drawing.Size(42, 16);
            this.lblFirstEntryField.TabIndex = 7;
            this.lblFirstEntryField.Text = "Naziv";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(189, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(301, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSecondEntryField
            // 
            this.lblSecondEntryField.AutoSize = true;
            this.lblSecondEntryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondEntryField.Location = new System.Drawing.Point(31, 139);
            this.lblSecondEntryField.Name = "lblSecondEntryField";
            this.lblSecondEntryField.Size = new System.Drawing.Size(42, 16);
            this.lblSecondEntryField.TabIndex = 19;
            this.lblSecondEntryField.Text = "Naziv";
            // 
            // txtBoxSecond
            // 
            this.txtBoxSecond.Location = new System.Drawing.Point(34, 158);
            this.txtBoxSecond.Name = "txtBoxSecond";
            this.txtBoxSecond.Size = new System.Drawing.Size(125, 20);
            this.txtBoxSecond.TabIndex = 18;
            // 
            // UCHelpInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.lblSecondEntryField);
            this.Controls.Add(this.txtBoxSecond);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFirstEntryField);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.txtBoxFirst);
            this.Controls.Add(this.cmbBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "UCHelpInsert";
            this.Size = new System.Drawing.Size(345, 235);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cmbBox;
        public System.Windows.Forms.TextBox txtBoxFirst;
        public System.Windows.Forms.TextBox txtBoxSecond;
        public System.Windows.Forms.Label lblComboBox;
        public System.Windows.Forms.Label lblFirstEntryField;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblSecondEntryField;
        public System.Windows.Forms.Label lblHeader;
    }
}
