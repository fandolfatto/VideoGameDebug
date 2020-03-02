namespace VideoGamesMgt
{
    partial class frmAddDeveloper
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lstDev = new System.Windows.Forms.ListBox();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.lblDevExisting = new System.Windows.Forms.Label();
            this.lblNewDev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(12, 383);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(102, 38);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(169, 383);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(102, 38);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lstDev
            // 
            this.lstDev.FormattingEnabled = true;
            this.lstDev.ItemHeight = 16;
            this.lstDev.Location = new System.Drawing.Point(12, 78);
            this.lstDev.Name = "lstDev";
            this.lstDev.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDev.Size = new System.Drawing.Size(339, 196);
            this.lstDev.TabIndex = 2;
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(12, 330);
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(339, 22);
            this.txtDev.TabIndex = 3;
            // 
            // lblDevExisting
            // 
            this.lblDevExisting.AutoSize = true;
            this.lblDevExisting.Location = new System.Drawing.Point(9, 41);
            this.lblDevExisting.Name = "lblDevExisting";
            this.lblDevExisting.Size = new System.Drawing.Size(214, 17);
            this.lblDevExisting.TabIndex = 4;
            this.lblDevExisting.Text = "Liste des développeurs existants";
            // 
            // lblNewDev
            // 
            this.lblNewDev.AutoSize = true;
            this.lblNewDev.Location = new System.Drawing.Point(14, 293);
            this.lblNewDev.Name = "lblNewDev";
            this.lblNewDev.Size = new System.Drawing.Size(148, 17);
            this.lblNewDev.TabIndex = 5;
            this.lblNewDev.Text = "Nouveau développeur";
            // 
            // frmAddDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.lblNewDev);
            this.Controls.Add(this.lblDevExisting);
            this.Controls.Add(this.txtDev);
            this.Controls.Add(this.lstDev);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddDeveloper";
            this.Text = "Ajout développeurs";
            this.Load += new System.EventHandler(this.frmAddDeveloper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ListBox lstDev;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.Label lblDevExisting;
        private System.Windows.Forms.Label lblNewDev;
    }
}