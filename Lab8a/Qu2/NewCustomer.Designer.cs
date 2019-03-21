namespace Qu2
{
    partial class NewCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateAccountbtn = new System.Windows.Forms.Button();
            this.PlaceOrderbtn = new System.Windows.Forms.Button();
            this.AddAnotherAccount = new System.Windows.Forms.Button();
            this.Finishedbtn = new System.Windows.Forms.Button();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Account";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(136, 48);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(112, 22);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpOrderDate);
            this.groupBox2.Controls.Add(this.numOrderAmount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 78);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order Amount:";
            // 
            // CreateAccountbtn
            // 
            this.CreateAccountbtn.Location = new System.Drawing.Point(266, 72);
            this.CreateAccountbtn.Name = "CreateAccountbtn";
            this.CreateAccountbtn.Size = new System.Drawing.Size(118, 23);
            this.CreateAccountbtn.TabIndex = 5;
            this.CreateAccountbtn.Text = "Create Account";
            this.CreateAccountbtn.UseVisualStyleBackColor = true;
            this.CreateAccountbtn.Click += new System.EventHandler(this.CreateAccountbtn_Click);
            // 
            // PlaceOrderbtn
            // 
            this.PlaceOrderbtn.Location = new System.Drawing.Point(266, 124);
            this.PlaceOrderbtn.Name = "PlaceOrderbtn";
            this.PlaceOrderbtn.Size = new System.Drawing.Size(118, 23);
            this.PlaceOrderbtn.TabIndex = 6;
            this.PlaceOrderbtn.Text = "Place Order";
            this.PlaceOrderbtn.UseVisualStyleBackColor = true;
            this.PlaceOrderbtn.Click += new System.EventHandler(this.PlaceOrderbtn_Click);
            // 
            // AddAnotherAccount
            // 
            this.AddAnotherAccount.Location = new System.Drawing.Point(219, 246);
            this.AddAnotherAccount.Name = "AddAnotherAccount";
            this.AddAnotherAccount.Size = new System.Drawing.Size(140, 23);
            this.AddAnotherAccount.TabIndex = 7;
            this.AddAnotherAccount.Text = "Add Another Account";
            this.AddAnotherAccount.UseVisualStyleBackColor = true;
            this.AddAnotherAccount.Click += new System.EventHandler(this.AddAnotherAccount_Click);
            // 
            // Finishedbtn
            // 
            this.Finishedbtn.Location = new System.Drawing.Point(34, 246);
            this.Finishedbtn.Name = "Finishedbtn";
            this.Finishedbtn.Size = new System.Drawing.Size(75, 23);
            this.Finishedbtn.TabIndex = 8;
            this.Finishedbtn.Text = "Finish";
            this.Finishedbtn.UseVisualStyleBackColor = true;
            this.Finishedbtn.Click += new System.EventHandler(this.Finishedbtn_Click);
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(112, 20);
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(100, 20);
            this.numOrderAmount.TabIndex = 4;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(112, 46);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(100, 20);
            this.dtpOrderDate.TabIndex = 9;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 311);
            this.Controls.Add(this.Finishedbtn);
            this.Controls.Add(this.AddAnotherAccount);
            this.Controls.Add(this.PlaceOrderbtn);
            this.Controls.Add(this.CreateAccountbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateAccountbtn;
        private System.Windows.Forms.Button PlaceOrderbtn;
        private System.Windows.Forms.Button AddAnotherAccount;
        private System.Windows.Forms.Button Finishedbtn;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
    }
}