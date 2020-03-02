namespace VideoGamesMgt
{
    partial class frmVideoGamesList
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
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdDisplay = new System.Windows.Forms.Button();
            this.dgvVideoGamesList = new System.Windows.Forms.DataGridView();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoGamesList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(1026, 41);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(173, 48);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1026, 261);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(173, 48);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Fermer";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdDisplay
            // 
            this.cmdDisplay.Location = new System.Drawing.Point(1026, 97);
            this.cmdDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDisplay.Name = "cmdDisplay";
            this.cmdDisplay.Size = new System.Drawing.Size(173, 48);
            this.cmdDisplay.TabIndex = 3;
            this.cmdDisplay.Text = "Visualiser";
            this.cmdDisplay.UseVisualStyleBackColor = true;
            this.cmdDisplay.Click += new System.EventHandler(this.cmdDisplay_Click);
            // 
            // dgvVideoGamesList
            // 
            this.dgvVideoGamesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideoGamesList.Location = new System.Drawing.Point(16, 41);
            this.dgvVideoGamesList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVideoGamesList.MultiSelect = false;
            this.dgvVideoGamesList.Name = "dgvVideoGamesList";
            this.dgvVideoGamesList.Size = new System.Drawing.Size(968, 293);
            this.dgvVideoGamesList.TabIndex = 4;
            this.dgvVideoGamesList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvVideoGamesList_RowStateChanged);
            // 
            // cmdModify
            // 
            this.cmdModify.Location = new System.Drawing.Point(1026, 152);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(173, 48);
            this.cmdModify.TabIndex = 5;
            this.cmdModify.Text = "Modifier";
            this.cmdModify.UseVisualStyleBackColor = true;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(1026, 206);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(173, 48);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "Supprimer";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // frmVideoGamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 362);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.dgvVideoGamesList);
            this.Controls.Add(this.cmdDisplay);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVideoGamesList";
            this.Text = "Liste de jeux vidéos";
            this.Load += new System.EventHandler(this.frmVideoGamesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoGamesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdDisplay;
        private System.Windows.Forms.DataGridView dgvVideoGamesList;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdDelete;
    }
}