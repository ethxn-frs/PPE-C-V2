namespace DeclicInfoGUI
{
    partial class frmProduits
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
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtLibellé = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.txtPdv = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(970, 26);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(125, 49);
            this.btnPrecedent.TabIndex = 0;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Location = new System.Drawing.Point(76, 100);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.ReadOnly = true;
            this.dgvProduits.Size = new System.Drawing.Size(422, 311);
            this.dgvProduits.TabIndex = 1;
            this.dgvProduits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduits_CellClick);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(908, 145);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Détails";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(808, 177);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.Text = "Code";
            // 
            // txtLibellé
            // 
            this.txtLibellé.Location = new System.Drawing.Point(946, 177);
            this.txtLibellé.Name = "txtLibellé";
            this.txtLibellé.Size = new System.Drawing.Size(100, 20);
            this.txtLibellé.TabIndex = 4;
            this.txtLibellé.Text = "Libellé";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(808, 232);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorie.TabIndex = 5;
            this.cmbCategorie.Text = "Catégorie";
            // 
            // txtPdv
            // 
            this.txtPdv.Location = new System.Drawing.Point(946, 232);
            this.txtPdv.Name = "txtPdv";
            this.txtPdv.Size = new System.Drawing.Size(100, 20);
            this.txtPdv.TabIndex = 6;
            this.txtPdv.Text = "Prix De Vente";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(833, 298);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(946, 298);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(891, 350);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // frmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 511);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtPdv);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.txtLibellé);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.btnPrecedent);
            this.Name = "frmProduits";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtLibellé;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.TextBox txtPdv;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
    }
}