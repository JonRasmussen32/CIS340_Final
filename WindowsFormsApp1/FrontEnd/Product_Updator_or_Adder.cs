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
    public partial class Product_Updator_or_Adder : Form
    {

        Product product;
        
        public Product_Updator_or_Adder()
        {
            InitializeComponent();
        }

        private void Update_Dataset(){

            this.productsTableAdapter.Fill(this.ShopEasy_DBDataSet.Products);
            

        }

        private Boolean ProductObjectFill()
        {
            
            product = new Product();

            if (Int32.TryParse(prodidtxt.Text, out int id)){
                string coststring = String.Format("{0:c}", costtxt.Text);
                if(decimal.TryParse(coststring, out decimal cost)){

                    product.ID = id;
                    product.Name = nametxt.Text;
                    product.Description = descriptiontxt.Text;
                    product.Cost = cost;
                    product.ProductType = producttypetxt.Text;
                    return true;
                }
            }
            

            MessageBox.Show("Make sure that the id and cost is a number");
            return false;


        }
        

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if(ProductObjectFill())
            {
                if(DatabaseOperation.AddorUpdateItem(product)){
                    
                    MessageBox.Show("Addition or modification to the database is a success");
                    Update_Dataset();
                    
                    
                }
                else{
                    MessageBox.Show("Unable to add or modify the database, please try again later");
                    
                }
                
                
            }
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(prodidtxt.Text);
            
            using (var form = new Confirmation())
            {

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (DatabaseOperation.DeleteItem(id, "Product") == false)
                    {

                        MessageBox.Show("ID doesn't exist, can't delete.");
                    }
                }
            }
            Update_Dataset();
        }

        private void getproductbtn_Click(object sender, EventArgs e)
        {
            int id;

            if(Int32.TryParse(prodidtxt.Text, out id))
            {
                product = new Product();
                product.ID = id;

                product = DatabaseOperation.ReturnItem(product);
                if(product != null)
                {


                }

            }


        }

        private void Product_Updator_or_Adder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.ShopEasy_DBDataSet.Products);

        }


    }
}
