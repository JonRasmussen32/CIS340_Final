using System;
using System.Collections.Generic;

namespace ShopEasy
{

    public class CalculateInvoiceTotal {

        public Invoice CalculateInvoice(Person customer, Invoice invoice, Boolean useRewards){

            invoice.TotalCost = 0;
            
            foreach(Product products in invoice.ProductsInInvoice){

                if((products.ProductType == "Books") && (customer.IsTeacher == true)){


                    invoice.TotalCost += products.TotalProductPurchasedCost - (products.TotalProductPurchasedCost * .1m);
                    

                }

                invoice.TotalCost += products.TotalProductPurchasedCost;
                

            }

            if((customer.IsSenior == false) || (customer.IsVeteran == false)){

                invoice.TotalCost += invoice.TotalCost * .055m;

            }
            else if((customer.IsVeteran) && (customer.IsSenior)){

                invoice.TotalCost -= invoice.TotalCost * .15m;
                
            }
            else if(customer.IsVeteran){

                invoice.TotalCost -= invoice.TotalCost * .10m;
                
            }
            else if(customer.IsSenior){

                invoice.TotalCost -= invoice.TotalCost * .05m;
                
            }
            
            
            while((useRewards == true) && (customer.Reward_Points >= 100)){

                invoice.TotalCost -= 5;
                customer.Subtract_Reward_Points(100);
                    
            }

            if((invoice.TotalCost >= 50)){
                
                customer.Add_Reward_Points(Convert.ToInt32(invoice.TotalCost));
            }
            
            return invoice;

        }

        public Invoice CalculateEstimatedInvoiceWithoutBonus(Invoice invoice)
        {
            invoice.TotalCost = 0;
            foreach(Product products in invoice.ProductsInInvoice){
                       
                invoice.TotalCost += products.TotalProductPurchasedCost;
            }
            //total with tax
            invoice.TotalCost += invoice.TotalCost * .055m;

            return invoice;
            
        }
            
    }


}
