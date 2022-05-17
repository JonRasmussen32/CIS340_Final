namespace ShopEasy
{
    partial class Invoice_Viewer
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
            this.ShopEasy_DBDataSet = new ShopEasy.ShopEasy_DBDataSet();
            this.invoicesDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoices_DetailTableAdapter = new ShopEasy.ShopEasy_DBDataSetTableAdapters.Invoices_DetailTableAdapter();
            this.invIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProductCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDetailBindingSource)).BeginInit();
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
            this.prodIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalProductCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoicesDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(711, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShopEasy_DBDataSet
            // 
            this.ShopEasy_DBDataSet.DataSetName = "ShopEasy_DBDataSet";
            this.ShopEasy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesDetailBindingSource
            // 
            this.invoicesDetailBindingSource.DataMember = "Invoices Detail";
            this.invoicesDetailBindingSource.DataSource = this.ShopEasy_DBDataSet;
            // 
            // invoices_DetailTableAdapter
            // 
            this.invoices_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // invIDDataGridViewTextBoxColumn
            // 
            this.invIDDataGridViewTextBoxColumn.DataPropertyName = "InvID";
            this.invIDDataGridViewTextBoxColumn.HeaderText = "InvID";
            this.invIDDataGridViewTextBoxColumn.Name = "invIDDataGridViewTextBoxColumn";
            this.invIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodIDDataGridViewTextBoxColumn
            // 
            this.prodIDDataGridViewTextBoxColumn.DataPropertyName = "ProdID";
            this.prodIDDataGridViewTextBoxColumn.HeaderText = "ProdID";
            this.prodIDDataGridViewTextBoxColumn.Name = "prodIDDataGridViewTextBoxColumn";
            this.prodIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalProductCostDataGridViewTextBoxColumn
            // 
            this.totalProductCostDataGridViewTextBoxColumn.DataPropertyName = "Total Product Cost";
            this.totalProductCostDataGridViewTextBoxColumn.HeaderText = "Total Product Cost";
            this.totalProductCostDataGridViewTextBoxColumn.Name = "totalProductCostDataGridViewTextBoxColumn";
            this.totalProductCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Invoice_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Invoice_Viewer";
            this.Text = "Invoice_Viewer";
            this.Load += new System.EventHandler(this.Invoice_Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopEasy_DBDataSet ShopEasy_DBDataSet;
        private System.Windows.Forms.BindingSource invoicesDetailBindingSource;
        private ShopEasy_DBDataSetTableAdapters.Invoices_DetailTableAdapter invoices_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProductCostDataGridViewTextBoxColumn;
    }
}