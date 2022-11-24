namespace DeclicInfoGUI
{
    partial class frmConfirmationModificationProduit
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(276, 111);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(212, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Souhaitez vous vraiment modifier ce produit";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(252, 263);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(479, 263);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(75, 23);
            this.btnOui.TabIndex = 2;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // frmConfirmationModificationProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmConfirmationModificationProduit";
            this.Text = "frmConfirmationModificationProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnOui;
    }
}