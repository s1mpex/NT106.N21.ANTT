﻿namespace lab4
{
    partial class Lab04_Bai03
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
            this.url = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.rtbSourceCode = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(12, 26);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(414, 20);
            this.url.TabIndex = 0;
            this.url.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(12, 52);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(414, 20);
            this.path.TabIndex = 1;
            // 
            // rtbSourceCode
            // 
            this.rtbSourceCode.Location = new System.Drawing.Point(12, 90);
            this.rtbSourceCode.Name = "rtbSourceCode";
            this.rtbSourceCode.Size = new System.Drawing.Size(534, 249);
            this.rtbSourceCode.TabIndex = 2;
            this.rtbSourceCode.Text = "";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(471, 23);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab04_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.rtbSourceCode);
            this.Controls.Add(this.path);
            this.Controls.Add(this.url);
            this.Name = "Lab04_Bai03";
            this.Text = "Lab04_Bai03";
            this.Load += new System.EventHandler(this.Lab04_Bai03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.RichTextBox rtbSourceCode;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnExit;
    }
}