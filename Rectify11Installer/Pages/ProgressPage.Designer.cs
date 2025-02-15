﻿namespace Rectify11Installer.Pages
{
    partial class ProgressPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new global::Rectify11Installer.Core.SingleAssemblyComponentResourceManager(typeof(Strings.Rectify11));
            this.progressText = new Rectify11Installer.Controls.DarkAwareLabel();
            this.progressInfo = new Rectify11Installer.Controls.DarkAwareLabel();
            this.SuspendLayout();
            // 
            // progressText
            // 
            this.progressText.BackColor = System.Drawing.Color.Transparent;
            this.progressText.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressText.ForeColor = System.Drawing.Color.Black;
            this.progressText.Location = new System.Drawing.Point(0, 5);
            this.progressText.Name = "progressText";
            this.progressText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.progressText.Size = new System.Drawing.Size(361, 40);
            this.progressText.TabIndex = 1;
            this.progressText.Text = resources.GetString("progressText");
            //
            // progressInfo
            //
            this.progressInfo.BackColor = System.Drawing.Color.Transparent;
            this.progressInfo.Font = new System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressInfo.Location = new System.Drawing.Point(0, 40);
            this.progressInfo.Name = "progressInfo";
            this.progressInfo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.progressInfo.Size = new System.Drawing.Size(290, 200);
            this.progressInfo.Text = "Tanks for Choosing Rectify11";
            // 
            // ProgressPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.progressInfo);
            this.Name = "ProgressPage";
            this.SideImage = global::Rectify11Installer.Properties.Resources.install;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DarkAwareLabel progressText;
        private Controls.DarkAwareLabel progressInfo;
    }
}
