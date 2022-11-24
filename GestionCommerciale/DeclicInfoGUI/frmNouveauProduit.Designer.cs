namespace DeclicInfoGUI
{
    partial class frmNouveauProduit
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
            this.lblNouveauProduit = new System.Windows.Forms.Label();
            this.txtLibellé = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.txtPdv = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNouveauProduit
            // 
            this.lblNouveauProduit.AutoSize = true;
            this.lblNouveauProduit.Location = new System.Drawing.Point(340, 54);
            this.lblNouveauProduit.Name = "lblNouveauProduit";
            this.lblNouveauProduit.Size = new System.Drawing.Size(87, 13);
            this.lblNouveauProduit.TabIndex = 0;
            this.lblNouveauProduit.Text = "Nouveau Produit";
            // 
            // txtLibellé
            // 
            this.txtLibellé.Location = new System.Drawing.Point(409, 131);
            this.txtLibellé.Name = "txtLibellé";
            this.txtLibellé.Size = new System.Drawing.Size(100, 20);
            this.txtLibellé.TabIndex = 2;
            this.txtLibellé.Text = "Libellé";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(247, 206);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(100, 21);
            this.cmbCategorie.TabIndex = 3;
            this.cmbCategorie.Text = "Catégorie";
            // 
            // txtPdv
            // 
            this.txtPdv.Location = new System.Drawing.Point(409, 207);
            this.txtPdv.Name = "txtPdv";
            this.txtPdv.Size = new System.Drawing.Size(100, 20);
            this.txtPdv.TabIndex = 4;
            this.txtPdv.Text = "Prix De Vente";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(272, 294);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(409, 294);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmNouveauProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtPdv);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.txtLibellé);
            this.Controls.Add(this.lblNouveauProduit);
            this.Name = "frmNouveauProduit";
            this.Text = "frmNouveauProduit";
            this.Load += new System.EventHandler(this.frmNouveauProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouveauProduit;
        private System.Windows.Forms.TextBox txtLibellé;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.TextBox txtPdv;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
    }
}