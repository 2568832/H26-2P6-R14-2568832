namespace AppExceptions
{
    partial class FrmPrincipal
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
            this.BtnExemple2 = new System.Windows.Forms.Button();
            this.BtnExemple4 = new System.Windows.Forms.Button();
            this.BtnExemple5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExemple1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExemple2
            // 
            this.BtnExemple2.Location = new System.Drawing.Point(35, 155);
            this.BtnExemple2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExemple2.Name = "BtnExemple2";
            this.BtnExemple2.Size = new System.Drawing.Size(729, 44);
            this.BtnExemple2.TabIndex = 1;
            this.BtnExemple2.Text = "Exemple #2 : Provoquer une erreur avec un tableau à 1D";
            this.BtnExemple2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExemple2.UseVisualStyleBackColor = true;
            this.BtnExemple2.Click += new System.EventHandler(this.BtnExemple2_Click);
            // 
            // BtnExemple4
            // 
            this.BtnExemple4.Location = new System.Drawing.Point(35, 225);
            this.BtnExemple4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExemple4.Name = "BtnExemple3";
            this.BtnExemple4.Size = new System.Drawing.Size(729, 44);
            this.BtnExemple4.TabIndex = 3;
            this.BtnExemple4.Text = "Exemple #3 : Provoquer une erreur de conversion avec int.Parse";
            this.BtnExemple4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExemple4.UseVisualStyleBackColor = true;
            this.BtnExemple4.Click += new System.EventHandler(this.BtnExemple3_Click);
            // 
            // BtnExemple5
            // 
            this.BtnExemple5.Location = new System.Drawing.Point(35, 292);
            this.BtnExemple5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExemple5.Name = "BtnExemple4";
            this.BtnExemple5.Size = new System.Drawing.Size(729, 44);
            this.BtnExemple5.TabIndex = 4;
            this.BtnExemple5.Text = "Exemple #4 : Problème lors de la lecture d\'un fichier texte";
            this.BtnExemple5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExemple5.UseVisualStyleBackColor = true;
            this.BtnExemple5.Click += new System.EventHandler(this.BtnExemple4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFichier
            // 
            this.MnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichierQuitter});
            this.MnuFichier.Name = "MnuFichier";
            this.MnuFichier.Size = new System.Drawing.Size(66, 24);
            this.MnuFichier.Text = "&Fichier";
            // 
            // MnuFichierQuitter
            // 
            this.MnuFichierQuitter.Name = "MnuFichierQuitter";
            this.MnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MnuFichierQuitter.Size = new System.Drawing.Size(191, 26);
            this.MnuFichierQuitter.Text = "&Quitter";
            this.MnuFichierQuitter.Click += new System.EventHandler(this.MnuFichierQuitter_Click);
            // 
            // BtnExemple1
            // 
            this.BtnExemple1.Location = new System.Drawing.Point(35, 81);
            this.BtnExemple1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExemple1.Name = "BtnExemple1";
            this.BtnExemple1.Size = new System.Drawing.Size(729, 44);
            this.BtnExemple1.TabIndex = 0;
            this.BtnExemple1.Text = "Exemple #1 : Provoquer une erreur avec notre classe Thermostat";
            this.BtnExemple1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExemple1.UseVisualStyleBackColor = true;
            this.BtnExemple1.Click += new System.EventHandler(this.BtnExemple1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 454);
            this.Controls.Add(this.BtnExemple1);
            this.Controls.Add(this.BtnExemple5);
            this.Controls.Add(this.BtnExemple4);
            this.Controls.Add(this.BtnExemple2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traitement des exceptions (Démo)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExemple2;
        private System.Windows.Forms.Button BtnExemple4;
        private System.Windows.Forms.Button BtnExemple5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFichier;
        private System.Windows.Forms.ToolStripMenuItem MnuFichierQuitter;
        private System.Windows.Forms.Button BtnExemple1;
    }
}

