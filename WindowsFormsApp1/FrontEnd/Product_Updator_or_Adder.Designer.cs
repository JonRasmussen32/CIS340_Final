namespace ShopEasy
{
    partial class Product_Updator_or_Adder
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
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopEasy_DBDataSet = new ShopEasy.ShopEasy_DBDataSet();
            this.productsTableAdapter = new ShopEasy.ShopEasy_DBDataSetTableAdapters.ProductsTableAdapter();
            this.prodidlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.desclbl = new System.Windows.Forms.Label();
            this.costlbl = new System.Windows.Forms.Label();
            this.prodtyplbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.prodidtxt = new System.Windows.Forms.TextBox();
            this.producttypetxt = new System.Windows.Forms.TextBox();
            this.costtxt = new System.Windows.Forms.TextBox();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.getproductbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(673, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // prodIDDataGridViewTextBoxColumn
            // 
            this.prodIDDataGridViewTextBoxColumn.DataPropertyName = "ProdID";
            this.prodIDDataGridViewTextBoxColumn.HeaderText = "ProdID";
            this.prodIDDataGridViewTextBoxColumn.Name = "prodIDDataGridViewTextBoxColumn";
            this.prodIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "Product Type";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Product Type";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.ShopEasy_DBDataSet;
            // 
            // ShopEasy_DBDataSet
            // 
            this.ShopEasy_DBDataSet.DataSetName = "ShopEasy_DBDataSet";
            this.ShopEasy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // prodidlbl
            // 
            this.prodidlbl.AutoSize = true;
            this.prodidlbl.Location = new System.Drawing.Point(12, 63);
            this.prodidlbl.Name = "prodidlbl";
            this.prodidlbl.Size = new System.Drawing.Size(43, 13);
            this.prodidlbl.TabIndex = 1;
            this.prodidlbl.Text = "Prod ID";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(13, 129);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 2;
            this.namelbl.Text = "Name";
            // 
            // desclbl
            // 
            this.desclbl.AutoSize = true;
            this.desclbl.Location = new System.Drawing.Point(12, 177);
            this.desclbl.Name = "desclbl";
            this.desclbl.Size = new System.Drawing.Size(60, 13);
            this.desclbl.TabIndex = 3;
            this.desclbl.Text = "Description";
            // 
            // costlbl
            // 
            this.costlbl.AutoSize = true;
            this.costlbl.Location = new System.Drawing.Point(12, 226);
            this.costlbl.Name = "costlbl";
            this.costlbl.Size = new System.Drawing.Size(28, 13);
            this.costlbl.TabIndex = 4;
            this.costlbl.Text = "Cost";
            // 
            // prodtyplbl
            // 
            this.prodtyplbl.AutoSize = true;
            this.prodtyplbl.Location = new System.Drawing.Point(12, 274);
            this.prodtyplbl.Name = "prodtyplbl";
            this.prodtyplbl.Size = new System.Drawing.Size(71, 13);
            this.prodtyplbl.TabIndex = 5;
            this.prodtyplbl.Text = "Product Type";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(133, 129);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 6;
            // 
            // prodidtxt
            // 
            this.prodidtxt.Location = new System.Drawing.Point(133, 63);
            this.prodidtxt.Name = "prodidtxt";
            this.prodidtxt.Size = new System.Drawing.Size(100, 20);
            this.prodidtxt.TabIndex = 7;
            // 
            // producttypetxt
            // 
            this.producttypetxt.Location = new System.Drawing.Point(133, 274);
            this.producttypetxt.Name = "producttypetxt";
            this.producttypetxt.Size = new System.Drawing.Size(100, 20);
            this.producttypetxt.TabIndex = 8;
            // 
            // costtxt
            // 
            this.costtxt.Location = new System.Drawing.Point(133, 226);
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(100, 20);
            this.costtxt.TabIndex = 9;
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(133, 177);
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(100, 20);
            this.descriptiontxt.TabIndex = 10;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(16, 371);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(158, 371);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 12;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // getproductbtn
            // 
            this.getproductbtn.Location = new System.Drawing.Point(324, 60);
            this.getproductbtn.Name = "getproductbtn";
            this.getproductbtn.Size = new System.Drawing.Size(75, 23);
            this.getproductbtn.TabIndex = 13;
            this.getproductbtn.Text = "Get Product";
            this.getproductbtn.UseVisualStyleBackColor = true;
            this.getproductbtn.Click += new System.EventHandler(this.getproductbtn_Click);
            // 
            // Product_Updator_or_Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.getproductbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.costtxt);
            this.Controls.Add(this.producttypetxt);
            this.Controls.Add(this.prodidtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.prodtyplbl);
            this.Controls.Add(this.costlbl);
            this.Controls.Add(this.desclbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.prodidlbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product_Updator_or_Adder";
            this.Text = "Product_Updator_or_Adder";
            this.Load += new System.EventHandler(this.Product_Updator_or_Adder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopEasy_DBDataSet ShopEasy_DBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ShopEasy_DBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label prodidlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label desclbl;
        private System.Windows.Forms.Label costlbl;
        private System.Windows.Forms.Label prodtyplbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox prodidtxt;
        private System.Windows.Forms.TextBox producttypetxt;
        private System.Windows.Forms.TextBox costtxt;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button getproductbtn;
    }
}