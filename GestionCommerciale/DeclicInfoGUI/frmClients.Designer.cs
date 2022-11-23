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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtFactRue = new System.Windows.Forms.TextBox();
            this.txtFactNum = new System.Windows.Forms.TextBox();
            this.txtLivrCodePostal = new System.Windows.Forms.TextBox();
            this.txtLivrVille = new System.Windows.Forms.TextBox();
            this.txtLivrRue = new System.Windows.Forms.TextBox();
            this.txtLivrNum = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtFactVille = new System.Windows.Forms.TextBox();
            this.txtFactCodePostal = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(-6, 2);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(927, 634);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1207, 65);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Précédent";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // txtFactRue
            // 
            this.txtFactRue.Location = new System.Drawing.Point(1152, 358);
            this.txtFactRue.Name = "txtFactRue";
            this.txtFactRue.Size = new System.Drawing.Size(100, 20);
            this.txtFactRue.TabIndex = 2;
            // 
            // txtFactNum
            // 
            this.txtFactNum.Location = new System.Drawing.Point(1046, 358);
            this.txtFactNum.Name = "txtFactNum";
            this.txtFactNum.Size = new System.Drawing.Size(100, 20);
            this.txtFactNum.TabIndex = 3;
            // 
            // txtLivrCodePostal
            // 
            this.txtLivrCodePostal.Location = new System.Drawing.Point(1369, 311);
            this.txtLivrCodePostal.Name = "txtLivrCodePostal";
            this.txtLivrCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtLivrCodePostal.TabIndex = 4;
            // 
            // txtLivrVille
            // 
            this.txtLivrVille.Location = new System.Drawing.Point(1258, 311);
            this.txtLivrVille.Name = "txtLivrVille";
            this.txtLivrVille.Size = new System.Drawing.Size(100, 20);
            this.txtLivrVille.TabIndex = 5;
            // 
            // txtLivrRue
            // 
            this.txtLivrRue.Location = new System.Drawing.Point(1152, 311);
            this.txtLivrRue.Name = "txtLivrRue";
            this.txtLivrRue.Size = new System.Drawing.Size(100, 20);
            this.txtLivrRue.TabIndex = 6;
            // 
            // txtLivrNum
            // 
            this.txtLivrNum.Location = new System.Drawing.Point(1046, 311);
            this.txtLivrNum.Name = "txtLivrNum";
            this.txtLivrNum.Size = new System.Drawing.Size(100, 20);
            this.txtLivrNum.TabIndex = 7;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(1230, 221);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1082, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(1082, 182);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 10;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(1230, 182);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 11;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(1385, 182);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 12;
            // 
            // txtFactVille
            // 
            this.txtFactVille.Location = new System.Drawing.Point(1258, 358);
            this.txtFactVille.Name = "txtFactVille";
            this.txtFactVille.Size = new System.Drawing.Size(100, 20);
            this.txtFactVille.TabIndex = 13;
            // 
            // txtFactCodePostal
            // 
            this.txtFactCodePostal.Location = new System.Drawing.Point(1369, 358);
            this.txtFactCodePostal.Name = "txtFactCodePostal";
            this.txtFactCodePostal.Size = new System.Drawing.Size(100, 20);
            this.txtFactCodePostal.TabIndex = 14;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(1152, 456);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(1230, 531);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 16;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(1294, 455);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 648);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtFactCodePostal);
            this.Controls.Add(this.txtFactVille);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtLivrNum);
            this.Controls.Add(this.txtLivrRue);
            this.Controls.Add(this.txtLivrVille);
            this.Controls.Add(this.txtLivrCodePostal);
            this.Controls.Add(this.txtFactNum);
            this.Controls.Add(this.txtFactRue);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.dgvClients);
            this.Name = "frmClients";
            this.Text = "frmClients";
            this.Load += new System.EventHandler(this.frmClients_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtFactRue;
        private System.Windows.Forms.TextBox txtFactNum;
        private System.Windows.Forms.TextBox txtLivrCodePostal;
        private System.Windows.Forms.TextBox txtLivrVille;
        private System.Windows.Forms.TextBox txtLivrRue;
        private System.Windows.Forms.TextBox txtLivrNum;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtFactVille;
        private System.Windows.Forms.TextBox txtFactCodePostal;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnSupprimer;
    }
}