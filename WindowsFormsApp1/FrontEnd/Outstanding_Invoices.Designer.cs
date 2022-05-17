namespace ShopEasy
{
    partial class Outstanding_Invoices
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
            this.invIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidForDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopEasy_DBDataSet = new ShopEasy.ShopEasy_DBDataSet();
            this.invoiceTableAdapter = new ShopEasy.ShopEasy_DBDataSetTableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invIDDataGridViewTextBoxColumn,
            this.perIDDataGridViewTextBoxColumn,
            this.dateOfInvoiceDataGridViewTextBoxColumn,
            this.amountOfProductDataGridViewTextBoxColumn,
            this.isPaidForDataGridViewCheckBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 252);
            this.dataGridView1.TabIndex = 0;

            // 
            // invIDDataGridViewTextBoxColumn
            // 
            this.invIDDataGridViewTextBoxColumn.DataPropertyName = "InvID";
            this.invIDDataGridViewTextBoxColumn.HeaderText = "InvID";
            this.invIDDataGridViewTextBoxColumn.Name = "invIDDataGridViewTextBoxColumn";
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            // 
            // dateOfInvoiceDataGridViewTextBoxColumn
            // 
            this.dateOfInvoiceDataGridViewTextBoxColumn.DataPropertyName = "Date Of Invoice";
            this.dateOfInvoiceDataGridViewTextBoxColumn.HeaderText = "Date Of Invoice";
            this.dateOfInvoiceDataGridViewTextBoxColumn.Name = "dateOfInvoiceDataGridViewTextBoxColumn";
            // 
            // amountOfProductDataGridViewTextBoxColumn
            // 
            this.amountOfProductDataGridViewTextBoxColumn.DataPropertyName = "Amount Of Product";
            this.amountOfProductDataGridViewTextBoxColumn.HeaderText = "Amount Of Product";
            this.amountOfProductDataGridViewTextBoxColumn.Name = "amountOfProductDataGridViewTextBoxColumn";
            // 
            // isPaidForDataGridViewCheckBoxColumn
            // 
            this.isPaidForDataGridViewCheckBoxColumn.DataPropertyName = "Is Paid For";
            this.isPaidForDataGridViewCheckBoxColumn.HeaderText = "Is Paid For";
            this.isPaidForDataGridViewCheckBoxColumn.Name = "isPaidForDataGridViewCheckBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
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
            // Outstanding_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Outstanding_Invoices";
            this.Text = "Outstanding_Invoices";
            this.Load += new System.EventHandler(this.Outstanding_Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopEasy_DBDataSet ShopEasy_DBDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ShopEasy_DBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaidForDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
    }
}