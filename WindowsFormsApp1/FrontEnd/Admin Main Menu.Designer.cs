namespace ShopEasy
{
    partial class Admin_Main_Menu
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
            this.Person_Viewerbtn = new System.Windows.Forms.Button();
            this.Product_viewerbtn = new System.Windows.Forms.Button();
            this.Invoice_Viewerbtn = new System.Windows.Forms.Button();
            this.Personupdatorbtn = new System.Windows.Forms.Button();
            this.Productupdatorbtn = new System.Windows.Forms.Button();
            this.invoiceoutstandingbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Person_Viewerbtn
            // 
            this.Person_Viewerbtn.Location = new System.Drawing.Point(284, 237);
            this.Person_Viewerbtn.Name = "Person_Viewerbtn";
            this.Person_Viewerbtn.Size = new System.Drawing.Size(177, 23);
            this.Person_Viewerbtn.TabIndex = 0;
            this.Person_Viewerbtn.Text = "Person Viewer";
            this.Person_Viewerbtn.UseVisualStyleBackColor = true;
            this.Person_Viewerbtn.Click += new System.EventHandler(this.PersonViewerbtn_Click);
            // 
            // Product_viewerbtn
            // 
            this.Product_viewerbtn.Location = new System.Drawing.Point(51, 59);
            this.Product_viewerbtn.Name = "Product_viewerbtn";
            this.Product_viewerbtn.Size = new System.Drawing.Size(175, 23);
            this.Product_viewerbtn.TabIndex = 1;
            this.Product_viewerbtn.Text = "Product Viewer";
            this.Product_viewerbtn.UseVisualStyleBackColor = true;
            this.Product_viewerbtn.Click += new System.EventHandler(this.Product_viewerbtn_Click);
            // 
            // Invoice_Viewerbtn
            // 
            this.Invoice_Viewerbtn.Location = new System.Drawing.Point(530, 59);
            this.Invoice_Viewerbtn.Name = "Invoice_Viewerbtn";
            this.Invoice_Viewerbtn.Size = new System.Drawing.Size(168, 23);
            this.Invoice_Viewerbtn.TabIndex = 2;
            this.Invoice_Viewerbtn.Text = "Invoice Viewer";
            this.Invoice_Viewerbtn.UseVisualStyleBackColor = true;
            this.Invoice_Viewerbtn.Click += new System.EventHandler(this.Invoice_Viewerbtn_Click);
            // 
            // Personupdatorbtn
            // 
            this.Personupdatorbtn.Location = new System.Drawing.Point(284, 315);
            this.Personupdatorbtn.Name = "Personupdatorbtn";
            this.Personupdatorbtn.Size = new System.Drawing.Size(177, 23);
            this.Personupdatorbtn.TabIndex = 3;
            this.Personupdatorbtn.Text = "Person Updator Or Adder";
            this.Personupdatorbtn.UseVisualStyleBackColor = true;
            this.Personupdatorbtn.Click += new System.EventHandler(this.Personupdatorbtn_Click);
            // 
            // Productupdatorbtn
            // 
            this.Productupdatorbtn.Location = new System.Drawing.Point(51, 132);
            this.Productupdatorbtn.Name = "Productupdatorbtn";
            this.Productupdatorbtn.Size = new System.Drawing.Size(175, 23);
            this.Productupdatorbtn.TabIndex = 4;
            this.Productupdatorbtn.Text = "Product Updator Or Adder";
            this.Productupdatorbtn.UseVisualStyleBackColor = true;
            this.Productupdatorbtn.Click += new System.EventHandler(this.Productupdatorbtn_Click);
            // 
            // invoiceoutstandingbtn
            // 
            this.invoiceoutstandingbtn.Location = new System.Drawing.Point(530, 132);
            this.invoiceoutstandingbtn.Name = "invoiceoutstandingbtn";
            this.invoiceoutstandingbtn.Size = new System.Drawing.Size(168, 23);
            this.invoiceoutstandingbtn.TabIndex = 5;
            this.invoiceoutstandingbtn.Text = "Outstanding Invoices";
            this.invoiceoutstandingbtn.UseVisualStyleBackColor = true;
            this.invoiceoutstandingbtn.Click += new System.EventHandler(this.invoiceoutstandingbtn_Click);
            // 
            // Admin_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invoiceoutstandingbtn);
            this.Controls.Add(this.Productupdatorbtn);
            this.Controls.Add(this.Personupdatorbtn);
            this.Controls.Add(this.Invoice_Viewerbtn);
            this.Controls.Add(this.Product_viewerbtn);
            this.Controls.Add(this.Person_Viewerbtn);
            this.Name = "Admin_Main_Menu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Person_Viewerbtn;
        private System.Windows.Forms.Button Product_viewerbtn;
        private System.Windows.Forms.Button Invoice_Viewerbtn;
        private System.Windows.Forms.Button Personupdatorbtn;
        private System.Windows.Forms.Button Productupdatorbtn;
        private System.Windows.Forms.Button invoiceoutstandingbtn;
    }
}