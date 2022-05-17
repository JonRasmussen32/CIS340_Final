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
    public partial class Customer_Invoice_History : Form
    {
        int? invoiceid;
        Person customer;
        public Customer_Invoice_History()
        {
            InitializeComponent();
            invoiceid = null;
            customer = null;
        }

        public Customer_Invoice_History(Person customer)
        {
            InitializeComponent();
            invoiceid = null;
            this.customer = customer;
        }

        private void Customer_Invoice_History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.FillBy1(this.ShopEasy_DBDataSet.Invoice, customer.ID);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];

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
    }
}
