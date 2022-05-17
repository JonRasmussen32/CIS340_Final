namespace ShopEasy
{
    partial class Customer_Invoice_History
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopEasy_DBDataSet = new ShopEasy.ShopEasy_DBDataSet();
            this.invoiceTableAdapter = new ShopEasy.ShopEasy_DBDataSetTableAdapters.InvoiceTableAdapter();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.invIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidForDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invIDDataGridViewTextBoxColumn,
            this.dateOfInvoiceDataGridViewTextBoxColumn,
            this.amountOfProductDataGridViewTextBoxColumn,
            this.isPaidForDataGridViewCheckBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.ShopEasy_DBDataSet;
            // 
            // ShopEasy_DBDataSet
            // 
            this.ShopEasy_DBDataSet.DataSetName = "ShopEasy_DBDataSet";
            this.ShopEasy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillBy2ToolStrip.TabIndex = 1;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Visible = false;
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // invIDDataGridViewTextBoxColumn
            // 
            this.invIDDataGridViewTextBoxColumn.DataPropertyName = "InvID";
            this.invIDDataGridViewTextBoxColumn.HeaderText = "InvID";
            this.invIDDataGridViewTextBoxColumn.Name = "invIDDataGridViewTextBoxColumn";
            this.invIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfInvoiceDataGridViewTextBoxColumn
            // 
            this.dateOfInvoiceDataGridViewTextBoxColumn.DataPropertyName = "Date Of Invoice";
            this.dateOfInvoiceDataGridViewTextBoxColumn.HeaderText = "Date Of Invoice";
            this.dateOfInvoiceDataGridViewTextBoxColumn.Name = "dateOfInvoiceDataGridViewTextBoxColumn";
            this.dateOfInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOfProductDataGridViewTextBoxColumn
            // 
            this.amountOfProductDataGridViewTextBoxColumn.DataPropertyName = "Amount Of Product";
            this.amountOfProductDataGridViewTextBoxColumn.HeaderText = "Amount Of Product";
            this.amountOfProductDataGridViewTextBoxColumn.Name = "amountOfProductDataGridViewTextBoxColumn";
            this.amountOfProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isPaidForDataGridViewCheckBoxColumn
            // 
            this.isPaidForDataGridViewCheckBoxColumn.DataPropertyName = "Is Paid For";
            this.isPaidForDataGridViewCheckBoxColumn.HeaderText = "Is Paid For";
            this.isPaidForDataGridViewCheckBoxColumn.Name = "isPaidForDataGridViewCheckBoxColumn";
            this.isPaidForDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Customer_Invoice_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_Invoice_History";
            this.Text = "Customer_Invoice_History";
            this.Load += new System.EventHandler(this.Customer_Invoice_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopEasy_DBDataSet ShopEasy_DBDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ShopEasy_DBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaidForDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
    }
}