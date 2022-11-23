namespace DeclicInfoGUI
{
    partial class frmAuthentification
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
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(610, 255);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(418, 255);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(585, 120);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(585, 178);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(415, 127);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(86, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom d\'Utilisateur";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(415, 185);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(74, 13);
            this.lblMdp.TabIndex = 5;
            this.lblMdp.Text = "Mot De Passe";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.DarkRed;
            this.txtError.Location = new System.Drawing.Point(415, 331);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(303, 13);
            this.txtError.TabIndex = 6;
            this.txtError.Text = "Le mot de passe ou le nom d\'utilisateur est incorrect";
            this.txtError.Visible = false;
            this.txtError.Click += new System.EventHandler(this.txtError_Click);
            // 
            // frmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 511);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConnexion);
            this.Name = "frmAuthentification";
            this.Text = "frmAuthentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label txtError;
    }
}