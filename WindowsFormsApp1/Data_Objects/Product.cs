using System;

namespace ShopEasy
{

    public class Product : Item
    {

        private Decimal cost;
        private int productpurchasedquantity;

        public Product() {

            cost = 0;
            productpurchasedquantity = 0;

        }

        public String Description{

            set;
            get;

        }

        public Decimal Cost{

            get{
                
                return cost;

            }

            set{

                cost = value;
            }

        }


        public String ProductType{

            get;
            set;

        }

        public Decimal TotalProductPurchasedCost => cost * productpurchasedquantity;

        public int ProductPurchasedQuantity{

            get{

                return productpurchasedquantity;
            }   
            set
            {
                productpurchasedquantity = value;
            }
        }

        public int GetProductPurchasedQuantity()
        {
           if(ProductPurchasedQuantity < 0)
            {
                ProductPurchasedQuantity = 0;
                return 0;
            }
            else
            {
                return ProductPurchasedQuantity;
            }
        }
            

        public void SetProductPurchasedQuantity(int quantity)
        {
            if(quantity < 0)
            {
                ProductPurchasedQuantity = 0;
            }
            else
            {
                ProductPurchasedQuantity = quantity;
            }
        }

    }

}
