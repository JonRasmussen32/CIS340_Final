namespace ShopEasy
{
    partial class Login
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(31, 181);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 0;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(31, 40);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(216, 20);
            this.emailtxt.TabIndex = 1;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(31, 110);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(216, 20);
            this.passwordtxt.TabIndex = 2;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(31, 21);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(32, 13);
            this.emaillbl.TabIndex = 3;
            this.emaillbl.Text = "Email";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(31, 91);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 4;
            this.passwordlbl.Text = "Password";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(172, 181);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 236);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.submitbtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Button exitbtn;
    }
}