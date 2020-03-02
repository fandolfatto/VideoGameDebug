namespace VideoGamesMgt
{
    partial class frmAddPlatform
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
            this.lstPlatform = new System.Windows.Forms.ListBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPlatform
            // 
            this.lstPlatform.FormattingEnabled = true;
            this.lstPlatform.ItemHeight = 16;
            this.lstPlatform.Location = new System.Drawing.Point(21, 84);
            this.lstPlatform.Name = "lstPlatform";
            this.lstPlatform.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPlatform.Size = new System.Drawing.Size(335, 196);
            this.lstPlatform.TabIndex = 0;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(18, 36);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(210, 17);
            this.lblPlatform.TabIndex = 1;
            this.lblPlatform.Text = "Liste des plateformes existantes";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(21, 317);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(108, 40);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(160, 317);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(108, 40);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmAddPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lstPlatform);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPlatform";
            this.Text = "Ajout plateforme";
            this.Load += new System.EventHandler(this.frmAddPlatform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlatform;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdCancel;
    }
}