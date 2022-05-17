using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopEasy.FrontEnd
{
    public partial class Admin_Unpaid_Invoice : Form
    {
        public Admin_Unpaid_Invoice()
        {
            InitializeComponent();
        }

        private void Admin_Unpaid_Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.ShopEasy_DBDataSet.Invoice);

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillBy2(this.ShopEasy_DBDataSet.Invoice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillBy2(this.ShopEasy_DBDataSet.Invoice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
