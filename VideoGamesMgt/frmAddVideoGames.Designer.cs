namespace VideoGamesMgt
{
    partial class frmAddVideoGame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblDeveloppers = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDateOutput = new System.Windows.Forms.DateTimePicker();
            this.lstPlatform = new System.Windows.Forms.ListBox();
            this.cboTypeVG = new System.Windows.Forms.ComboBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lstEditor = new System.Windows.Forms.ListBox();
            this.cmdAddEditor = new System.Windows.Forms.Button();
            this.cmdDeleteEditor = new System.Windows.Forms.Button();
            this.cmdAddDev = new System.Windows.Forms.Button();
            this.cmdDeleteDev = new System.Windows.Forms.Button();
            this.cmdAddPlatform = new System.Windows.Forms.Button();
            this.cmdDeletePlatform = new System.Windows.Forms.Button();
            this.lstDev = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(77, 50);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom";
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Location = new System.Drawing.Point(77, 112);
            this.lblDateOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(121, 17);
            this.lblDateOut.TabIndex = 1;
            this.lblDateOut.Text = "Date sortie initiale";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(77, 174);
            this.lblPlatform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(83, 17);
            this.lblPlatform.TabIndex = 2;
            this.lblPlatform.Text = "Plateformes";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(77, 235);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Genre";
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Location = new System.Drawing.Point(77, 297);
            this.lblEditor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(60, 17);
            this.lblEditor.TabIndex = 4;
            this.lblEditor.Text = "Editeurs";
            // 
            // lblDeveloppers
            // 
            this.lblDeveloppers.AutoSize = true;
            this.lblDeveloppers.Location = new System.Drawing.Point(77, 374);
            this.lblDeveloppers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeveloppers.Name = "lblDeveloppers";
            this.lblDeveloppers.Size = new System.Drawing.Size(96, 17);
            this.lblDeveloppers.TabIndex = 5;
            this.lblDeveloppers.Text = "Développeurs";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 47);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 22);
            this.txtName.TabIndex = 6;
            // 
            // dtpDateOutput
            // 
            this.dtpDateOutput.Location = new System.Drawing.Point(197, 109);
            this.dtpDateOutput.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOutput.Name = "dtpDateOutput";
            this.dtpDateOutput.Size = new System.Drawing.Size(268, 22);
            this.dtpDateOutput.TabIndex = 7;
            // 
            // lstPlatform
            // 
            this.lstPlatform.FormattingEnabled = true;
            this.lstPlatform.ItemHeight = 16;
            this.lstPlatform.Location = new System.Drawing.Point(197, 156);
            this.lstPlatform.Margin = new System.Windows.Forms.Padding(4);
            this.lstPlatform.Name = "lstPlatform";
            this.lstPlatform.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPlatform.Size = new System.Drawing.Size(268, 52);
            this.lstPlatform.TabIndex = 8;
            this.lstPlatform.Click += new System.EventHandler(this.lstPlatform_Click);
            // 
            // cboTypeVG
            // 
            this.cboTypeVG.FormattingEnabled = true;
            this.cboTypeVG.Location = new System.Drawing.Point(197, 231);
            this.cboTypeVG.Margin = new System.Windows.Forms.Padding(4);
            this.cboTypeVG.Name = "cboTypeVG";
            this.cboTypeVG.Size = new System.Drawing.Size(268, 24);
            this.cboTypeVG.TabIndex = 9;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(80, 453);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(152, 39);
            this.cmdSave.TabIndex = 12;
            this.cmdSave.Text = "Enregistrer";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(301, 450);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(164, 42);
            this.cmdCancel.TabIndex = 13;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lstEditor
            // 
            this.lstEditor.FormattingEnabled = true;
            this.lstEditor.ItemHeight = 16;
            this.lstEditor.Location = new System.Drawing.Point(197, 279);
            this.lstEditor.Name = "lstEditor";
            this.lstEditor.Size = new System.Drawing.Size(268, 52);
            this.lstEditor.TabIndex = 14;
            this.lstEditor.Click += new System.EventHandler(this.lstEditor_Click);
            // 
            // cmdAddEditor
            // 
            this.cmdAddEditor.Location = new System.Drawing.Point(504, 279);
            this.cmdAddEditor.Name = "cmdAddEditor";
            this.cmdAddEditor.Size = new System.Drawing.Size(109, 27);
            this.cmdAddEditor.TabIndex = 15;
            this.cmdAddEditor.Text = "Ajouter";
            this.cmdAddEditor.UseVisualStyleBackColor = true;
            this.cmdAddEditor.Click += new System.EventHandler(this.cmdAddEditor_Click);
            // 
            // cmdDeleteEditor
            // 
            this.cmdDeleteEditor.Location = new System.Drawing.Point(504, 312);
            this.cmdDeleteEditor.Name = "cmdDeleteEditor";
            this.cmdDeleteEditor.Size = new System.Drawing.Size(112, 27);
            this.cmdDeleteEditor.TabIndex = 16;
            this.cmdDeleteEditor.Text = "Supprimer";
            this.cmdDeleteEditor.UseVisualStyleBackColor = true;
            this.cmdDeleteEditor.Click += new System.EventHandler(this.cmdDeleteEditor_Click);
            // 
            // cmdAddDev
            // 
            this.cmdAddDev.Location = new System.Drawing.Point(504, 356);
            this.cmdAddDev.Name = "cmdAddDev";
            this.cmdAddDev.Size = new System.Drawing.Size(109, 27);
            this.cmdAddDev.TabIndex = 17;
            this.cmdAddDev.Text = "Ajouter";
            this.cmdAddDev.UseVisualStyleBackColor = true;
            this.cmdAddDev.Click += new System.EventHandler(this.cmdAddDev_Click);
            // 
            // cmdDeleteDev
            // 
            this.cmdDeleteDev.Location = new System.Drawing.Point(504, 389);
            this.cmdDeleteDev.Name = "cmdDeleteDev";
            this.cmdDeleteDev.Size = new System.Drawing.Size(109, 27);
            this.cmdDeleteDev.TabIndex = 18;
            this.cmdDeleteDev.Text = "Supprimer";
            this.cmdDeleteDev.UseVisualStyleBackColor = true;
            this.cmdDeleteDev.Click += new System.EventHandler(this.cmdDeleteDev_Click);
            // 
            // cmdAddPlatform
            // 
            this.cmdAddPlatform.Location = new System.Drawing.Point(502, 156);
            this.cmdAddPlatform.Name = "cmdAddPlatform";
            this.cmdAddPlatform.Size = new System.Drawing.Size(109, 27);
            this.cmdAddPlatform.TabIndex = 19;
            this.cmdAddPlatform.Text = "Ajouter";
            this.cmdAddPlatform.UseVisualStyleBackColor = true;
            this.cmdAddPlatform.Click += new System.EventHandler(this.cmdAddPlatform_Click);
            // 
            // cmdDeletePlatform
            // 
            this.cmdDeletePlatform.Location = new System.Drawing.Point(502, 190);
            this.cmdDeletePlatform.Name = "cmdDeletePlatform";
            this.cmdDeletePlatform.Size = new System.Drawing.Size(109, 27);
            this.cmdDeletePlatform.TabIndex = 20;
            this.cmdDeletePlatform.Text = "Supprimer";
            this.cmdDeletePlatform.UseVisualStyleBackColor = true;
            this.cmdDeletePlatform.Click += new System.EventHandler(this.cmdDeletePlatform_Click);
            // 
            // lstDev
            // 
            this.lstDev.FormattingEnabled = true;
            this.lstDev.ItemHeight = 16;
            this.lstDev.Location = new System.Drawing.Point(197, 356);
            this.lstDev.Name = "lstDev";
            this.lstDev.Size = new System.Drawing.Size(268, 52);
            this.lstDev.TabIndex = 21;
            this.lstDev.Click += new System.EventHandler(this.lstDev_Click);
            // 
            // frmAddVideoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 516);
            this.Controls.Add(this.lstDev);
            this.Controls.Add(this.cmdDeletePlatform);
            this.Controls.Add(this.cmdAddPlatform);
            this.Controls.Add(this.cmdDeleteDev);
            this.Controls.Add(this.cmdAddDev);
            this.Controls.Add(this.cmdDeleteEditor);
            this.Controls.Add(this.cmdAddEditor);
            this.Controls.Add(this.lstEditor);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cboTypeVG);
            this.Controls.Add(this.lstPlatform);
            this.Controls.Add(this.dtpDateOutput);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDeveloppers);
            this.Controls.Add(this.lblEditor);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblDateOut);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddVideoGame";
            this.Text = "Ajout jeu video";
            this.Load += new System.EventHandler(this.frmVideoGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.Label lblDeveloppers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDateOutput;
        private System.Windows.Forms.ListBox lstPlatform;
        private System.Windows.Forms.ComboBox cboTypeVG;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ListBox lstEditor;
        private System.Windows.Forms.Button cmdAddEditor;
        private System.Windows.Forms.Button cmdDeleteEditor;
        private System.Windows.Forms.Button cmdAddDev;
        private System.Windows.Forms.Button cmdDeleteDev;
        private System.Windows.Forms.Button cmdAddPlatform;
        private System.Windows.Forms.Button cmdDeletePlatform;
        private System.Windows.Forms.ListBox lstDev;
    }
}

