using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopEasy
{
    public partial class Product_Viewer : Form
    {
        public Product_Viewer()
        {
            InitializeComponent();
        }

        private void Product_Viewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.ShopEasy_DBDataSet.Products);

        }
    }
}
