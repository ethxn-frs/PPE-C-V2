namespace DeclicInfoGUI
{
    partial class frmConfirmationSuppressionClient
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
            this.lblQuitter = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.Location = new System.Drawing.Point(309, 161);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(205, 13);
            this.lblQuitter.TabIndex = 0;
            this.lblQuitter.Text = "Voulez vous vraiment supprimer ce client?";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(280, 300);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(460, 300);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(75, 23);
            this.btnOui.TabIndex = 2;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // frmConfirmationSuppressionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblQuitter);
            this.Name = "frmConfirmationSuppressionClient";
            this.Text = "frmConfirmationSuppressionClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnOui;
    }
}