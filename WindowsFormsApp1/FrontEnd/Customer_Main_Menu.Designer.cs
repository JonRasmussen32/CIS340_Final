namespace ShopEasy
{
    partial class Customer_Main_Menu
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
            this.Shoppingbtn = new System.Windows.Forms.Button();
            this.Invoicebtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Shoppingbtn
            // 
            this.Shoppingbtn.Location = new System.Drawing.Point(61, 114);
            this.Shoppingbtn.Name = "Shoppingbtn";
            this.Shoppingbtn.Size = new System.Drawing.Size(223, 23);
            this.Shoppingbtn.TabIndex = 0;
            this.Shoppingbtn.Text = "Shopping";
            this.Shoppingbtn.UseVisualStyleBackColor = true;
            this.Shoppingbtn.Click += new System.EventHandler(this.Shoppingbtn_Click);
            // 
            // Invoicebtn
            // 
            this.Invoicebtn.Location = new System.Drawing.Point(61, 206);
            this.Invoicebtn.Name = "Invoicebtn";
            this.Invoicebtn.Size = new System.Drawing.Size(223, 23);
            this.Invoicebtn.TabIndex = 1;
            this.Invoicebtn.Text = "Shopping History";
            this.Invoicebtn.UseVisualStyleBackColor = true;
            this.Invoicebtn.Click += new System.EventHandler(this.Invoicebtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(61, 294);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(223, 23);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.Text = "Log out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Customer_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.Invoicebtn);
            this.Controls.Add(this.Shoppingbtn);
            this.Name = "Customer_Main_Menu";
            this.Text = "Customer_Main_Menu";
            this.Load += new System.EventHandler(this.Customer_Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Shoppingbtn;
        private System.Windows.Forms.Button Invoicebtn;
        private System.Windows.Forms.Button logoutbtn;
    }
}