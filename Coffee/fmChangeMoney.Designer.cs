﻿namespace Coffee
{
    partial class fmChangeMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmChangeMoney));
            this.label1 = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnPrintRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền thừa: ";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.BackColor = System.Drawing.Color.Transparent;
            this.lbChange.Location = new System.Drawing.Point(273, 9);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(35, 41);
            this.lbChange.TabIndex = 1;
            this.lbChange.Text = "0";
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(28, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(184, 60);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnPrintRecipe
            // 
            this.btnPrintRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRecipe.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnPrintRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintRecipe.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintRecipe.Location = new System.Drawing.Point(240, 134);
            this.btnPrintRecipe.Name = "btnPrintRecipe";
            this.btnPrintRecipe.Size = new System.Drawing.Size(184, 60);
            this.btnPrintRecipe.TabIndex = 3;
            this.btnPrintRecipe.Text = "In hóa đơn";
            this.btnPrintRecipe.UseVisualStyleBackColor = true;
            this.btnPrintRecipe.Click += new System.EventHandler(this.btnPrintRecipe_Click);
            // 
            // fmChangeMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 220);
            this.Controls.Add(this.btnPrintRecipe);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "fmChangeMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnPrintRecipe;
    }
}