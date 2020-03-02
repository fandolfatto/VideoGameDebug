namespace VideoGamesMgt
{
    partial class frmDisplayVideoGames
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
            this.CmdOK = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblOutputDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblValueName = new System.Windows.Forms.Label();
            this.lblValueOutputDate = new System.Windows.Forms.Label();
            this.lblValueEditor = new System.Windows.Forms.Label();
            this.lblValueType = new System.Windows.Forms.Label();
            this.lblValueDev = new System.Windows.Forms.Label();
            this.lblValuePlatform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdOK
            // 
            this.CmdOK.Location = new System.Drawing.Point(51, 375);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(4);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(119, 36);
            this.CmdOK.TabIndex = 0;
            this.CmdOK.Text = "OK";
            this.CmdOK.UseVisualStyleBackColor = true;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(145, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Fiche d\'information";
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Location = new System.Drawing.Point(51, 189);
            this.lblEditor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(65, 17);
            this.lblEditor.TabIndex = 2;
            this.lblEditor.Text = "Editeur : ";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(51, 273);
            this.lblDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(97, 17);
            this.lblDev.TabIndex = 3;
            this.lblDev.Text = "Développeur :";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(51, 315);
            this.lblPlatform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(91, 17);
            this.lblPlatform.TabIndex = 4;
            this.lblPlatform.Text = "Plateformes :";
            // 
            // lblOutputDate
            // 
            this.lblOutputDate.AutoSize = true;
            this.lblOutputDate.Location = new System.Drawing.Point(51, 147);
            this.lblOutputDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputDate.Name = "lblOutputDate";
            this.lblOutputDate.Size = new System.Drawing.Size(105, 17);
            this.lblOutputDate.TabIndex = 5;
            this.lblOutputDate.Text = "Date de sortie :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(51, 231);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 17);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Genre :";
            // 
            // lblValueName
            // 
            this.lblValueName.AutoSize = true;
            this.lblValueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueName.Location = new System.Drawing.Point(191, 66);
            this.lblValueName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueName.Name = "lblValueName";
            this.lblValueName.Size = new System.Drawing.Size(59, 20);
            this.lblValueName.TabIndex = 7;
            this.lblValueName.Text = "ggggg";
            // 
            // lblValueOutputDate
            // 
            this.lblValueOutputDate.AutoSize = true;
            this.lblValueOutputDate.Location = new System.Drawing.Point(175, 147);
            this.lblValueOutputDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueOutputDate.Name = "lblValueOutputDate";
            this.lblValueOutputDate.Size = new System.Drawing.Size(48, 17);
            this.lblValueOutputDate.TabIndex = 8;
            this.lblValueOutputDate.Text = "ggggg";
            // 
            // lblValueEditor
            // 
            this.lblValueEditor.AutoSize = true;
            this.lblValueEditor.Location = new System.Drawing.Point(175, 189);
            this.lblValueEditor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueEditor.Name = "lblValueEditor";
            this.lblValueEditor.Size = new System.Drawing.Size(48, 17);
            this.lblValueEditor.TabIndex = 9;
            this.lblValueEditor.Text = "ggggg";
            // 
            // lblValueType
            // 
            this.lblValueType.AutoSize = true;
            this.lblValueType.Location = new System.Drawing.Point(175, 231);
            this.lblValueType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueType.Name = "lblValueType";
            this.lblValueType.Size = new System.Drawing.Size(64, 17);
            this.lblValueType.TabIndex = 10;
            this.lblValueType.Text = "ggggggg";
            // 
            // lblValueDev
            // 
            this.lblValueDev.AutoSize = true;
            this.lblValueDev.Location = new System.Drawing.Point(175, 273);
            this.lblValueDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueDev.Name = "lblValueDev";
            this.lblValueDev.Size = new System.Drawing.Size(48, 17);
            this.lblValueDev.TabIndex = 11;
            this.lblValueDev.Text = "ggggg";
            // 
            // lblValuePlatform
            // 
            this.lblValuePlatform.AutoSize = true;
            this.lblValuePlatform.Location = new System.Drawing.Point(175, 315);
            this.lblValuePlatform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValuePlatform.Name = "lblValuePlatform";
            this.lblValuePlatform.Size = new System.Drawing.Size(56, 17);
            this.lblValuePlatform.TabIndex = 12;
            this.lblValuePlatform.Text = "gggggg";
            // 
            // frmDisplayVideoGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 474);
            this.Controls.Add(this.lblValuePlatform);
            this.Controls.Add(this.lblValueDev);
            this.Controls.Add(this.lblValueType);
            this.Controls.Add(this.lblValueEditor);
            this.Controls.Add(this.lblValueOutputDate);
            this.Controls.Add(this.lblValueName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblOutputDate);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblEditor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.CmdOK);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDisplayVideoGames";
            this.Text = "Information jeu vidéo";
            this.Load += new System.EventHandler(this.frmDisplayVideoGames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblOutputDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblValueName;
        private System.Windows.Forms.Label lblValueOutputDate;
        private System.Windows.Forms.Label lblValueEditor;
        private System.Windows.Forms.Label lblValueType;
        private System.Windows.Forms.Label lblValueDev;
        private System.Windows.Forms.Label lblValuePlatform;
    }
}