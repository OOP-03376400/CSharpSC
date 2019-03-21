namespace Qu2
{
    partial class Navigation
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
            this.Addbtn = new System.Windows.Forms.Button();
            this.FillorCancelbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(51, 40);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(123, 23);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Add an Account";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // FillorCancelbtn
            // 
            this.FillorCancelbtn.Location = new System.Drawing.Point(39, 116);
            this.FillorCancelbtn.Name = "FillorCancelbtn";
            this.FillorCancelbtn.Size = new System.Drawing.Size(149, 23);
            this.FillorCancelbtn.TabIndex = 1;
            this.FillorCancelbtn.Text = "Fill or cancel an order";
            this.FillorCancelbtn.UseVisualStyleBackColor = true;
            this.FillorCancelbtn.Click += new System.EventHandler(this.FillorCancelbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(207, 170);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 220);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.FillorCancelbtn);
            this.Controls.Add(this.Addbtn);
            this.Name = "Navigation";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button FillorCancelbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

