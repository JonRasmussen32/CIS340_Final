using System;
using System.Collections.Generic;


namespace ShopEasy
{

    public class Invoice : Item
    {

        List<Product> productsininvoice;
        int totalproductininvoicequantity;

        public Invoice(){
            totalproductininvoicequantity = 0;
            productsininvoice = new List<Product>();
        }
        
        public int PerID{
            get;
            set;
        }


        public DateTime DateOfInvoice{

            get;
            set;

        }

        public Boolean IsPaidFor{
            get;
            set;
        }


        public int AmountofProducts{
            get{

                return ProductsInInvoice.Count;

            }
        }
        
        public Decimal TotalCost{

            get;
            set;

        }

        
        
        public List<Product> ProductsInInvoice{
            get
            {
                return productsininvoice;
            }
            set
            {
                productsininvoice = value;
            }
        }

        public int TotalProductInInvoiceQuantity{

            get{

                totalproductininvoicequantity = 0;
                
                foreach(Product products in ProductsInInvoice)
                {
                    totalproductininvoicequantity += products.GetProductPurchasedQuantity();
                }
                
                return totalproductininvoicequantity;
            }

        }


        public Product GetProduct(int id){
            
            return ProductsInInvoice.Find(product => product.ID == id);
        }

        public void AddProduct(Product product){

            
            if (!ProductsInInvoice.Exists(e => e.ID == product.ID) && product != null)
            {

                ProductsInInvoice.Add(product);
            }
            else if(product != null)
            {

                Product temp = ProductsInInvoice.Find(e => e.ID == product.ID);
                int qauntitytemp = temp.GetProductPurchasedQuantity() + product.GetProductPurchasedQuantity();
                temp.SetProductPurchasedQuantity(qauntitytemp);
                int index = ProductsInInvoice.FindIndex(e => e.ID == temp.ID);
                ProductsInInvoice[index] = temp;

            }
        }

        public void RemoveProduct(int id) => ProductsInInvoice.Remove(ProductsInInvoice.Find(products => products.ID == id));

    }
}

