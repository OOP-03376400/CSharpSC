namespace Language_Translate
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
            this.germanButton = new System.Windows.Forms.Button();
            this.SpanishButton = new System.Windows.Forms.Button();
            this.italianButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.translationLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(341, 103);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(75, 23);
            this.germanButton.TabIndex = 0;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // SpanishButton
            // 
            this.SpanishButton.Location = new System.Drawing.Point(199, 103);
            this.SpanishButton.Name = "SpanishButton";
            this.SpanishButton.Size = new System.Drawing.Size(75, 23);
            this.SpanishButton.TabIndex = 1;
            this.SpanishButton.Text = "Spanish";
            this.SpanishButton.UseVisualStyleBackColor = true;
            this.SpanishButton.Click += new System.EventHandler(this.SpanishButton_Click);
            // 
            // italianButton
            // 
            this.italianButton.Location = new System.Drawing.Point(55, 103);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(75, 23);
            this.italianButton.TabIndex = 2;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a language and I will say good morning";
            // 
            // translationLebel
            // 
            this.translationLebel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLebel.Location = new System.Drawing.Point(143, 56);
            this.translationLebel.Name = "translationLebel";
            this.translationLebel.Size = new System.Drawing.Size(186, 21);
            this.translationLebel.TabIndex = 4;
            this.translationLebel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 146);
            this.Controls.Add(this.translationLebel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.SpanishButton);
            this.Controls.Add(this.germanButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Button SpanishButton;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translationLebel;
    }
}

