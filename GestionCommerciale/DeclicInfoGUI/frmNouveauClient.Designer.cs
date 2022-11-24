namespace DeclicInfoGUI
{
    partial class frmNouveauClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFactNum = new System.Windows.Forms.TextBox();
            this.txtLivrNum = new System.Windows.Forms.TextBox();
            this.txtFactCodePostal = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtLivrRue = new System.Windows.Forms.TextBox();
            this.txtLivrVille = new System.Windows.Forms.TextBox();
            this.txtLivrCodePostal = new System.Windows.Forms.TextBox();
            this.txtFactRue = new System.Windows.Forms.TextBox();
            this.txtFactVille = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau Client";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(365, 354);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(206, 354);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Text = "francois.beaujoir@gmail.com";
            // 
            // txtFactNum
            // 
            this.txtFactNum.Location = new System.Drawing.Point(103, 260);
            this.txtFactNum.Name = "txtFactNum";
            this.txtFactNum.Size = new System.Drawing.Size(100, 20);
            this.txtFactNum.TabIndex = 29;
            this.txtFactNum.Text = "335";
            // 
            // txtLivrNum
            // 
            this.txtLivrNum.Location = new System.Drawing.Point(103, 212);
            this.txtLivrNum.Name = "txtLivrNum";
            this.txtLivrNum.Size = new System.Drawing.Size(100, 20);
            this.txtLivrNum.TabIndex = 28;
            this.txtLivrNum.Text = "35";
            // 
            // txtFactCodePostal
            // 
            this.txtFactCodePostal.Location = new System.Drawing.Point(481, 260);
            this.txtFactCodePostal.Name = "txtFactCodePostal";
            this.txtFactCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtFactCodePostal.TabIndex = 27;
            this.txtFactCodePostal.Text = "60880";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(355, 152);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 26;
            this.txtTelephone.Text = "0786176266";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(481, 152);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 25;
            this.txtFax.Text = "0232032324";
            // 
            // txtLivrRue
            // 
            this.txtLivrRue.Location = new System.Drawing.Point(228, 212);
            this.txtLivrRue.Name = "txtLivrRue";
            this.txtLivrRue.Size = new System.Drawing.Size(100, 20);
            this.txtLivrRue.TabIndex = 24;
            this.txtLivrRue.Text = "rue des tarterets";
            // 
            // txtLivrVille
            // 
            this.txtLivrVille.Location = new System.Drawing.Point(355, 212);
            this.txtLivrVille.Name = "txtLivrVille";
            this.txtLivrVille.Size = new System.Drawing.Size(100, 20);
            this.txtLivrVille.TabIndex = 23;
            this.txtLivrVille.Text = "Compiegne";
            // 
            // txtLivrCodePostal
            // 
            this.txtLivrCodePostal.Location = new System.Drawing.Point(481, 212);
            this.txtLivrCodePostal.Name = "txtLivrCodePostal";
            this.txtLivrCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtLivrCodePostal.TabIndex = 22;
            this.txtLivrCodePostal.Text = "60200";
            // 
            // txtFactRue
            // 
            this.txtFactRue.Location = new System.Drawing.Point(228, 260);
            this.txtFactRue.Name = "txtFactRue";
            this.txtFactRue.Size = new System.Drawing.Size(100, 20);
            this.txtFactRue.TabIndex = 21;
            this.txtFactRue.Text = "rue des vignes";
            // 
            // txtFactVille
            // 
            this.txtFactVille.Location = new System.Drawing.Point(355, 260);
            this.txtFactVille.Name = "txtFactVille";
            this.txtFactVille.Size = new System.Drawing.Size(100, 20);
            this.txtFactVille.TabIndex = 20;
            this.txtFactVille.Text = "Jaux";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(228, 152);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 19;
            this.txtNom.Text = "Beaujoir";
            // 
            // frmNouveauClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 537);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFactNum);
            this.Controls.Add(this.txtLivrNum);
            this.Controls.Add(this.txtFactCodePostal);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtLivrRue);
            this.Controls.Add(this.txtLivrVille);
            this.Controls.Add(this.txtLivrCodePostal);
            this.Controls.Add(this.txtFactRue);
            this.Controls.Add(this.txtFactVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Name = "frmNouveauClient";
            this.Text = "frmNouveauClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFactNum;
        private System.Windows.Forms.TextBox txtLivrNum;
        private System.Windows.Forms.TextBox txtFactCodePostal;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtLivrRue;
        private System.Windows.Forms.TextBox txtLivrVille;
        private System.Windows.Forms.TextBox txtLivrCodePostal;
        private System.Windows.Forms.TextBox txtFactRue;
        private System.Windows.Forms.TextBox txtFactVille;
        private System.Windows.Forms.TextBox txtNom;
    }
}