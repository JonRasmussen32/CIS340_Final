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
    public partial class Invoice_Viewer : Form
    {
        public Invoice_Viewer()
        {
            InitializeComponent();
        }

        private void Invoice_Viewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Invoices_Detail' table. You can move, or remove it, as needed.
            this.invoices_DetailTableAdapter.Fill(this.ShopEasy_DBDataSet.Invoices_Detail);

        }
    }
}
