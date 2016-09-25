namespace Fractals_Cross
{
    partial class Form1
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pbxFractal = new System.Windows.Forms.PictureBox();
            this.numUpDownLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFractal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(203, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(40, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(22, 13);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "n =";
            // 
            // pbxFractal
            // 
            this.pbxFractal.Location = new System.Drawing.Point(12, 32);
            this.pbxFractal.Name = "pbxFractal";
            this.pbxFractal.Size = new System.Drawing.Size(800, 600);
            this.pbxFractal.TabIndex = 3;
            this.pbxFractal.TabStop = false;
            // 
            // numUpDownLevel
            // 
            this.numUpDownLevel.Location = new System.Drawing.Point(77, 7);
            this.numUpDownLevel.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numUpDownLevel.Name = "numUpDownLevel";
            this.numUpDownLevel.Size = new System.Drawing.Size(120, 20);
            this.numUpDownLevel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 666);
            this.Controls.Add(this.numUpDownLevel);
            this.Controls.Add(this.pbxFractal);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Fun with Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFractal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox pbxFractal;
        private System.Windows.Forms.NumericUpDown numUpDownLevel;
    }
}

