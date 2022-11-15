namespace DeclicInfoGUI
{
    partial class frmMenu
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
            this.lblQsvf = new System.Windows.Forms.Label();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.btnSynthèse = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQsvf
            // 
            this.lblQsvf.AutoSize = true;
            this.lblQsvf.Location = new System.Drawing.Point(497, 96);
            this.lblQsvf.Name = "lblQsvf";
            this.lblQsvf.Size = new System.Drawing.Size(133, 13);
            this.lblQsvf.TabIndex = 0;
            this.lblQsvf.Text = "Que souhaitez vous faire ?";
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(288, 267);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(100, 23);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Gérer Les Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(434, 267);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(107, 23);
            this.btnProduits.TabIndex = 2;
            this.btnProduits.Text = "Gérer Les Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            this.btnProduits.Click += new System.EventHandler(this.btnProduits_Click);
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(616, 267);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(100, 23);
            this.btnDevis.TabIndex = 3;
            this.btnDevis.Text = "Gérer Les Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            this.btnDevis.Click += new System.EventHandler(this.btnDevis_Click);
            // 
            // btnSynthèse
            // 
            this.btnSynthèse.Location = new System.Drawing.Point(792, 267);
            this.btnSynthèse.Name = "btnSynthèse";
            this.btnSynthèse.Size = new System.Drawing.Size(125, 23);
            this.btnSynthèse.TabIndex = 4;
            this.btnSynthèse.Text = "Synthèse Des Clients";
            this.btnSynthèse.UseVisualStyleBackColor = true;
            this.btnSynthèse.Click += new System.EventHandler(this.btnSynthèse_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(520, 405);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(110, 23);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 511);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnSynthèse);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.lblQsvf);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQsvf;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Button btnSynthèse;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}