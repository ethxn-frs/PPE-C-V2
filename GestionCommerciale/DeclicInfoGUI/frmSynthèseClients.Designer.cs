﻿namespace DeclicInfoGUI
{
    partial class frmSynthèseClients
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
            this.btnPrécédent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrécédent
            // 
            this.btnPrécédent.Location = new System.Drawing.Point(989, 68);
            this.btnPrécédent.Name = "btnPrécédent";
            this.btnPrécédent.Size = new System.Drawing.Size(75, 23);
            this.btnPrécédent.TabIndex = 0;
            this.btnPrécédent.Text = "Précédent";
            this.btnPrécédent.UseVisualStyleBackColor = true;
            this.btnPrécédent.Click += new System.EventHandler(this.btnPrécédent_Click);
            // 
            // frmSynthèseClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 511);
            this.Controls.Add(this.btnPrécédent);
            this.Name = "frmSynthèseClients";
            this.Text = "frmSynthèseClients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrécédent;
    }
}