namespace Flags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.finlandBox = new System.Windows.Forms.PictureBox();
            this.franceBox = new System.Windows.Forms.PictureBox();
            this.germanyBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a flag to see the name of the country";
            // 
            // finlandBox
            // 
            this.finlandBox.Image = ((System.Drawing.Image)(resources.GetObject("finlandBox.Image")));
            this.finlandBox.Location = new System.Drawing.Point(30, 60);
            this.finlandBox.Name = "finlandBox";
            this.finlandBox.Size = new System.Drawing.Size(100, 50);
            this.finlandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandBox.TabIndex = 1;
            this.finlandBox.TabStop = false;
            this.finlandBox.Click += new System.EventHandler(this.finlandBox_Click);
            // 
            // franceBox
            // 
            this.franceBox.Image = ((System.Drawing.Image)(resources.GetObject("franceBox.Image")));
            this.franceBox.Location = new System.Drawing.Point(152, 60);
            this.franceBox.Name = "franceBox";
            this.franceBox.Size = new System.Drawing.Size(100, 50);
            this.franceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.franceBox.TabIndex = 2;
            this.franceBox.TabStop = false;
            this.franceBox.Click += new System.EventHandler(this.franceBox_Click);
            // 
            // germanyBox
            // 
            this.germanyBox.Image = ((System.Drawing.Image)(resources.GetObject("germanyBox.Image")));
            this.germanyBox.Location = new System.Drawing.Point(275, 60);
            this.germanyBox.Name = "germanyBox";
            this.germanyBox.Size = new System.Drawing.Size(100, 50);
            this.germanyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanyBox.TabIndex = 3;
            this.germanyBox.TabStop = false;
            this.germanyBox.Click += new System.EventHandler(this.germanyBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(145, 144);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(114, 23);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 176);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanyBox);
            this.Controls.Add(this.franceBox);
            this.Controls.Add(this.finlandBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Countries";
            ((System.ComponentModel.ISupportInitialize)(this.finlandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox finlandBox;
        private System.Windows.Forms.PictureBox franceBox;
        private System.Windows.Forms.PictureBox germanyBox;
        private System.Windows.Forms.Label countryLabel;
    }
}

