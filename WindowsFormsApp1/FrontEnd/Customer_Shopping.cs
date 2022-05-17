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
    public partial class Customer_Shopping : Form
    {
        Person customer;
        Invoice invoice;
        CalculateInvoiceTotal calculations;

        public Customer_Shopping(Person customer)
        {
            InitializeComponent();
            this.customer = customer;
            calculations = new CalculateInvoiceTotal();
            invoice = new Invoice();
            invoice.PerID = customer.ID;
        }

        private void Update_Totals()
        {
            invoice = calculations.CalculateEstimatedInvoiceWithoutBonus(invoice);
            estimatedtxt.Text = invoice.TotalCost.ToString();
            invoice = calculations.CalculateInvoice(customer, invoice, userewardschkbx.Checked);
            completetxt.Text = invoice.TotalCost.ToString();
        }

        private void Customer_Shopping_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.ShopEasy_DBDataSet.Products);

        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            using (Confirmation form = new Confirmation("Are you sure you want to make this purchase?"))
            {

                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    invoice = calculations.CalculateInvoice(customer, invoice, userewardschkbx.Checked);
                    invoice.DateOfInvoice = DateTime.Now;
                    if (DatabaseOperation.AddItem(invoice))
                    {
                        MessageBox.Show("Successfully added the item into the database.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, please try again");
                    }
                }

               
            }



                
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userewardschkbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void productaddbtn_Click(object sender, EventArgs e)
        {
            
            if(Int32.TryParse(prodidtxt.Text, out int id) && Int32.TryParse(productqtytxt.Text, out int productqty))
            {
                Product product = new Product();
                product.ID = id;
                product = DatabaseOperation.ReturnItem(product);

                product.ProductPurchasedQuantity = productqty;
                invoice.AddProduct(product);
                Update_Totals();
            }
            else
            {
                MessageBox.Show("Please put in a number in the product id and amount of product.");
            }
        }

        private void productqtylbl_Click(object sender, EventArgs e)
        {

        }
    }
}
