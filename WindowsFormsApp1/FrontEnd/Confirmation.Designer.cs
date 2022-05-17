namespace ShopEasy
{
    partial class Confirmation
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
            this.confirmationlbl = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmationlbl
            // 
            this.confirmationlbl.AutoSize = true;
            this.confirmationlbl.Location = new System.Drawing.Point(79, 49);
            this.confirmationlbl.Name = "confirmationlbl";
            this.confirmationlbl.Size = new System.Drawing.Size(230, 13);
            this.confirmationlbl.TabIndex = 0;
            this.confirmationlbl.Text = "Please confirm that you want to delete the item.";
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(82, 143);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 1;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(233, 143);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Delete_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 220);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.confirmationlbl);
            this.Name = "Delete_Confirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Delete_Confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmationlbl;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}