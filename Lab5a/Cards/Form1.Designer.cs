namespace Cards
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
            this.cardFaceBox = new System.Windows.Forms.PictureBox();
            this.cardbackBox = new System.Windows.Forms.PictureBox();
            this.showFace = new System.Windows.Forms.Button();
            this.showBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFaceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFaceBox
            // 
            this.cardFaceBox.Image = ((System.Drawing.Image)(resources.GetObject("cardFaceBox.Image")));
            this.cardFaceBox.Location = new System.Drawing.Point(266, 12);
            this.cardFaceBox.Name = "cardFaceBox";
            this.cardFaceBox.Size = new System.Drawing.Size(100, 157);
            this.cardFaceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFaceBox.TabIndex = 0;
            this.cardFaceBox.TabStop = false;
            this.cardFaceBox.Visible = false;
            // 
            // cardbackBox
            // 
            this.cardbackBox.Image = ((System.Drawing.Image)(resources.GetObject("cardbackBox.Image")));
            this.cardbackBox.Location = new System.Drawing.Point(95, 12);
            this.cardbackBox.Name = "cardbackBox";
            this.cardbackBox.Size = new System.Drawing.Size(100, 157);
            this.cardbackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbackBox.TabIndex = 1;
            this.cardbackBox.TabStop = false;
            // 
            // showFace
            // 
            this.showFace.Location = new System.Drawing.Point(277, 200);
            this.showFace.Name = "showFace";
            this.showFace.Size = new System.Drawing.Size(75, 36);
            this.showFace.TabIndex = 2;
            this.showFace.Text = "Show the Card Face";
            this.showFace.UseVisualStyleBackColor = true;
            this.showFace.Click += new System.EventHandler(this.showFace_Click);
            // 
            // showBack
            // 
            this.showBack.Location = new System.Drawing.Point(109, 200);
            this.showBack.Name = "showBack";
            this.showBack.Size = new System.Drawing.Size(75, 36);
            this.showBack.TabIndex = 3;
            this.showBack.Text = "Show The Card Back";
            this.showBack.UseVisualStyleBackColor = true;
            this.showBack.Click += new System.EventHandler(this.showBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 265);
            this.Controls.Add(this.showBack);
            this.Controls.Add(this.showFace);
            this.Controls.Add(this.cardbackBox);
            this.Controls.Add(this.cardFaceBox);
            this.Name = "Form1";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardFaceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardFaceBox;
        private System.Windows.Forms.PictureBox cardbackBox;
        private System.Windows.Forms.Button showFace;
        private System.Windows.Forms.Button showBack;
    }
}

