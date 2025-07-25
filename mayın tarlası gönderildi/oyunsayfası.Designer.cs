using System;

namespace _230229074_zehraözdemir
{
    partial class oyunsayfası
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
            // kaynakları serbest bırakır
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
            this.backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.RosyBrown;
            this.backbutton.Location = new System.Drawing.Point(630, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 0;
            this.backbutton.Text = "Geri";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 375);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // oyunsayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_230229074_zehraözdemir.Properties.Resources.baslangic;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbutton);
            this.Name = "oyunsayfası";
            this.Text = "oyunsayfası";
            this.Load += new System.EventHandler(this.oyunsayfası_Load);
            this.ResumeLayout(false);

        }

        #endregion
        // kullanılan araçları tanımlar
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Panel panel1;
    }
}