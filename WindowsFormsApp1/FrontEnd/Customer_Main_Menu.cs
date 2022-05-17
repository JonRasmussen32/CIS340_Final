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
    public partial class Customer_Main_Menu : Form
    {
        Person customer;
        public Customer_Main_Menu()
        {
            InitializeComponent();
            customer = null;
        }

        public Customer_Main_Menu(Person customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        public void Set_Customer(Person customer)
        {
            this.customer = customer;
        }

        private void Customer_Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shoppingbtn_Click(object sender, EventArgs e)
        {
            Customer_Shopping shopping = new Customer_Shopping(customer);
            shopping.ShowDialog();
        }

        private void Invoicebtn_Click(object sender, EventArgs e)
        {
            Customer_Invoice_History invoice = new Customer_Invoice_History(customer);
            invoice.ShowDialog();
        }
    }
}
