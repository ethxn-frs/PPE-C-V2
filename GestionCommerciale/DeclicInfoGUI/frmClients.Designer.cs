namespace DeclicInfoGUI
{
    partial class frmClients
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFactVille = new System.Windows.Forms.TextBox();
            this.txtFactRue = new System.Windows.Forms.TextBox();
            this.txtLivrCodePostal = new System.Windows.Forms.TextBox();
            this.txtLivrVille = new System.Windows.Forms.TextBox();
            this.txtLivrRue = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtFactCodePostal = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtLivrNum = new System.Windows.Forms.TextBox();
            this.txtFactNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(956, 39);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 0;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(56, 39);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(341, 349);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(757, 392);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(659, 376);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(857, 376);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(678, 185);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 6;
            // 
            // txtFactVille
            // 
            this.txtFactVille.Location = new System.Drawing.Point(805, 293);
            this.txtFactVille.Name = "txtFactVille";
            this.txtFactVille.Size = new System.Drawing.Size(100, 20);
            this.txtFactVille.TabIndex = 7;
            // 
            // txtFactRue
            // 
            this.txtFactRue.Location = new System.Drawing.Point(678, 293);
            this.txtFactRue.Name = "txtFactRue";
            this.txtFactRue.Size = new System.Drawing.Size(100, 20);
            this.txtFactRue.TabIndex = 8;
            // 
            // txtLivrCodePostal
            // 
            this.txtLivrCodePostal.Location = new System.Drawing.Point(931, 245);
            this.txtLivrCodePostal.Name = "txtLivrCodePostal";
            this.txtLivrCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtLivrCodePostal.TabIndex = 9;
            // 
            // txtLivrVille
            // 
            this.txtLivrVille.Location = new System.Drawing.Point(805, 245);
            this.txtLivrVille.Name = "txtLivrVille";
            this.txtLivrVille.Size = new System.Drawing.Size(100, 20);
            this.txtLivrVille.TabIndex = 10;
            // 
            // txtLivrRue
            // 
            this.txtLivrRue.Location = new System.Drawing.Point(678, 245);
            this.txtLivrRue.Name = "txtLivrRue";
            this.txtLivrRue.Size = new System.Drawing.Size(100, 20);
            this.txtLivrRue.TabIndex = 11;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(931, 185);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 12;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(805, 185);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 13;
            // 
            // txtFactCodePostal
            // 
            this.txtFactCodePostal.Location = new System.Drawing.Point(931, 293);
            this.txtFactCodePostal.Name = "txtFactCodePostal";
            this.txtFactCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtFactCodePostal.TabIndex = 14;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(744, 125);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 15;
            // 
            // txtLivrNum
            // 
            this.txtLivrNum.Location = new System.Drawing.Point(553, 245);
            this.txtLivrNum.Name = "txtLivrNum";
            this.txtLivrNum.Size = new System.Drawing.Size(100, 20);
            this.txtLivrNum.TabIndex = 16;
            // 
            // txtFactNum
            // 
            this.txtFactNum.Location = new System.Drawing.Point(553, 293);
            this.txtFactNum.Name = "txtFactNum";
            this.txtFactNum.Size = new System.Drawing.Size(100, 20);
            this.txtFactNum.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(553, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 511);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFactNum);
            this.Controls.Add(this.txtLivrNum);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtFactCodePostal);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtLivrRue);
            this.Controls.Add(this.txtLivrVille);
            this.Controls.Add(this.txtLivrCodePostal);
            this.Controls.Add(this.txtFactRue);
            this.Controls.Add(this.txtFactVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnPrecedent);
            this.Name = "frmClients";
            this.Text = "frmClients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFactVille;
        private System.Windows.Forms.TextBox txtFactRue;
        private System.Windows.Forms.TextBox txtLivrCodePostal;
        private System.Windows.Forms.TextBox txtLivrVille;
        private System.Windows.Forms.TextBox txtLivrRue;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtFactCodePostal;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtLivrNum;
        private System.Windows.Forms.TextBox txtFactNum;
        private System.Windows.Forms.TextBox txtEmail;
    }
}