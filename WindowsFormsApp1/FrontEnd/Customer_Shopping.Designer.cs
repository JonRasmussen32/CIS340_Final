namespace ShopEasy
{
    partial class Customer_Shopping
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productaddbtn = new System.Windows.Forms.Button();
            this.prodidtxt = new System.Windows.Forms.TextBox();
            this.prodidlbl = new System.Windows.Forms.Label();
            this.productqtytxt = new System.Windows.Forms.TextBox();
            this.productqtylbl = new System.Windows.Forms.Label();
            this.Purchasebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.estimatedlbl = new System.Windows.Forms.Label();
            this.completelbl = new System.Windows.Forms.Label();
            this.userewardschkbx = new System.Windows.Forms.CheckBox();
            this.estimatedtxt = new System.Windows.Forms.TextBox();
            this.completetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(752, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 373);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(405, 373);
            this.dataGridView2.TabIndex = 1;
            // 
            // productaddbtn
            // 
            this.productaddbtn.Location = new System.Drawing.Point(549, 363);
            this.productaddbtn.Name = "productaddbtn";
            this.productaddbtn.Size = new System.Drawing.Size(75, 23);
            this.productaddbtn.TabIndex = 2;
            this.productaddbtn.Text = "Add Product";
            this.productaddbtn.UseVisualStyleBackColor = true;
            this.productaddbtn.Click += new System.EventHandler(this.productaddbtn_Click);
            // 
            // prodidtxt
            // 
            this.prodidtxt.Location = new System.Drawing.Point(549, 79);
            this.prodidtxt.Name = "prodidtxt";
            this.prodidtxt.Size = new System.Drawing.Size(100, 20);
            this.prodidtxt.TabIndex = 3;
            // 
            // prodidlbl
            // 
            this.prodidlbl.AutoSize = true;
            this.prodidlbl.Location = new System.Drawing.Point(485, 82);
            this.prodidlbl.Name = "prodidlbl";
            this.prodidlbl.Size = new System.Drawing.Size(58, 13);
            this.prodidlbl.TabIndex = 4;
            this.prodidlbl.Text = "Product ID";
            // 
            // productqtytxt
            // 
            this.productqtytxt.Location = new System.Drawing.Point(549, 150);
            this.productqtytxt.Name = "productqtytxt";
            this.productqtytxt.Size = new System.Drawing.Size(100, 20);
            this.productqtytxt.TabIndex = 5;
            // 
            // productqtylbl
            // 
            this.productqtylbl.AutoSize = true;
            this.productqtylbl.Location = new System.Drawing.Point(450, 153);
            this.productqtylbl.Name = "productqtylbl";
            this.productqtylbl.Size = new System.Drawing.Size(95, 13);
            this.productqtylbl.TabIndex = 6;
            this.productqtylbl.Text = "Amount of Product";
            this.productqtylbl.Click += new System.EventHandler(this.productqtylbl_Click);
            // 
            // Purchasebtn
            // 
            this.Purchasebtn.Location = new System.Drawing.Point(343, 448);
            this.Purchasebtn.Name = "Purchasebtn";
            this.Purchasebtn.Size = new System.Drawing.Size(75, 23);
            this.Purchasebtn.TabIndex = 7;
            this.Purchasebtn.Text = "Buy";
            this.Purchasebtn.UseVisualStyleBackColor = true;
            this.Purchasebtn.Click += new System.EventHandler(this.Purchasebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(752, 447);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // estimatedlbl
            // 
            this.estimatedlbl.AutoSize = true;
            this.estimatedlbl.Location = new System.Drawing.Point(448, 281);
            this.estimatedlbl.Name = "estimatedlbl";
            this.estimatedlbl.Size = new System.Drawing.Size(80, 13);
            this.estimatedlbl.TabIndex = 9;
            this.estimatedlbl.Text = "Estimated Total";
            // 
            // completelbl
            // 
            this.completelbl.AutoSize = true;
            this.completelbl.Location = new System.Drawing.Point(450, 318);
            this.completelbl.Name = "completelbl";
            this.completelbl.Size = new System.Drawing.Size(78, 13);
            this.completelbl.TabIndex = 10;
            this.completelbl.Text = "Complete Total";
            // 
            // userewardschkbx
            // 
            this.userewardschkbx.AutoSize = true;
            this.userewardschkbx.Location = new System.Drawing.Point(549, 236);
            this.userewardschkbx.Name = "userewardschkbx";
            this.userewardschkbx.Size = new System.Drawing.Size(90, 17);
            this.userewardschkbx.TabIndex = 11;
            this.userewardschkbx.Text = "Use Rewards";
            this.userewardschkbx.UseVisualStyleBackColor = true;
            this.userewardschkbx.CheckedChanged += new System.EventHandler(this.userewardschkbx_CheckedChanged);
            // 
            // estimatedtxt
            // 
            this.estimatedtxt.Enabled = false;
            this.estimatedtxt.Location = new System.Drawing.Point(549, 281);
            this.estimatedtxt.Name = "estimatedtxt";
            this.estimatedtxt.Size = new System.Drawing.Size(100, 20);
            this.estimatedtxt.TabIndex = 12;
            // 
            // completetxt
            // 
            this.completetxt.Enabled = false;
            this.completetxt.Location = new System.Drawing.Point(549, 318);
            this.completetxt.Name = "completetxt";
            this.completetxt.Size = new System.Drawing.Size(100, 20);
            this.completetxt.TabIndex = 13;
            // 
            // Customer_Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 540);
            this.Controls.Add(this.completetxt);
            this.Controls.Add(this.estimatedtxt);
            this.Controls.Add(this.userewardschkbx);
            this.Controls.Add(this.completelbl);
            this.Controls.Add(this.estimatedlbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Purchasebtn);
            this.Controls.Add(this.productqtylbl);
            this.Controls.Add(this.productqtytxt);
            this.Controls.Add(this.prodidlbl);
            this.Controls.Add(this.prodidtxt);
            this.Controls.Add(this.productaddbtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_Shopping";
            this.Text = "Customer_Shopping";
            this.Load += new System.EventHandler(this.Customer_Shopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopEasy_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button productaddbtn;
        private System.Windows.Forms.TextBox prodidtxt;
        private System.Windows.Forms.Label prodidlbl;
        private System.Windows.Forms.TextBox productqtytxt;
        private System.Windows.Forms.Label productqtylbl;
        private System.Windows.Forms.Button Purchasebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label estimatedlbl;
        private System.Windows.Forms.Label completelbl;
        private System.Windows.Forms.CheckBox userewardschkbx;
        private System.Windows.Forms.TextBox estimatedtxt;
        private System.Windows.Forms.TextBox completetxt;
    }
}