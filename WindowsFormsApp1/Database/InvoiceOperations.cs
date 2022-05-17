using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ShopEasy
{

    public static class InvoiceOperations
    {
        public static Invoice ReturnInvoice(SqlCommand selectCommand, SqlConnection connect)
        {
            Invoice invoice = new Invoice();
            
            try{
                
                connect.Open();
                SqlDataReader invoiceReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (invoiceReader.Read())
                {
                    invoice.ID = (int)invoiceReader["InvID"];
                    invoice.PerID = (int)invoiceReader["PerID"];
                    invoice.DateOfInvoice = (DateTime)invoiceReader["DateOfInvoice"];
                    invoice.IsPaidFor = (bool)invoiceReader["Is Paid For"];
                    invoice.TotalCost = (decimal)invoiceReader["Total Cost"];

                    invoice = PopulateProducts(invoice, connect);
                    
                }
                else
                {
                    invoice = null;
                }

            }
            catch(Exception ex){

                throw ex;
                
            }
            finally{
                connect.Close();
            }
            
            return invoice;
            


        }

        private static Invoice PopulateProducts(Invoice invoice, SqlConnection connection){

            string invoicedetailsselect =
                "Select *"
                + " From \"Invoice Detail\""
                + " Where InvID = @id";

            SqlCommand invoicedetailsselectcommand = new SqlCommand(invoicedetailsselect, connection);

            invoicedetailsselectcommand.Parameters.AddWithValue("@id", invoice.ID);

            try
            {
                connection.Open();
                SqlDataReader productreader = invoicedetailsselectcommand.ExecuteReader(CommandBehavior.SingleRow);
                List<Product> products = new List<Product>();
                

                while(productreader.Read())
                {
                    Product tempproduct = new Product();
                    tempproduct.ID = (int)productreader["ProdID"];
                    tempproduct = DatabaseOperation.ReturnItem(tempproduct);
                    tempproduct.SetProductPurchasedQuantity((int)productreader["Quantity"]);
                    products.Add(tempproduct);

                }

                invoice.ProductsInInvoice = products;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return invoice;
            
            
        }

        
        public static void AddInvoiceDetails(Invoice invoice, SqlConnection connect)
        {

            int invoiceid = 0;
            try
            {
                string searchforinvoiceID = "Select InvID " +
                    "From Invoice " +
                    "Where \"Date Of Invoice\" = @date";

                SqlCommand invoicesearchcommand = new SqlCommand(searchforinvoiceID, connect);

                invoicesearchcommand.Parameters.AddWithValue("@Date", invoice.DateOfInvoice);
             

                connect.Open();
                SqlDataReader searchreader = invoicesearchcommand.ExecuteReader(CommandBehavior.SingleRow);
                if (searchreader.Read())
                {
                    Int32.TryParse(searchreader["InvID"].ToString(), out invoiceid);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
          

            foreach(Product product in invoice.ProductsInInvoice)
            {
                if (product != null)
                {
                    string invoicedetailsadd = "INSERT INTO \"Invoices Detail\" (InvID, ProdID, Quantity, \"Total Product Cost\") " +
                        "Values(@invid, @prodid, @quantity, @cost);";
                    SqlCommand invoicedetailsaddcommand = new SqlCommand(invoicedetailsadd, connect);

                    invoicedetailsaddcommand.Parameters.AddWithValue("@invid", invoiceid);
                    invoicedetailsaddcommand.Parameters.AddWithValue("@prodid", product.ID);
                    invoicedetailsaddcommand.Parameters.AddWithValue("@quantity", product.GetProductPurchasedQuantity());
                    invoicedetailsaddcommand.Parameters.AddWithValue("@cost", product.TotalProductPurchasedCost);

                    try
                    {
                        connect.Open();
                        
                        invoicedetailsaddcommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }


        public static Boolean AddInvoice(Invoice invoice)
        {
            if(DatabaseOperation.ReturnItem(invoice) != null)
            {
                return false;
            }
            else
            {

                SqlConnection connect = ShopEasyDB.GetConnection();

                string invoiceadd = "INSERT INTO Invoice (PerID, \"Date Of Invoice\", \"Amount Of Product\", \"Is Paid For\", \"Total Cost\") " +
                    "Values(@PerID, @Date, @Amount, @Paid, @Cost);";

                SqlCommand invoiceaddcommand = new SqlCommand(invoiceadd, connect);

                invoiceaddcommand.Parameters.AddWithValue("@PerID", invoice.PerID);
                invoiceaddcommand.Parameters.AddWithValue("@Date", invoice.DateOfInvoice);
                invoiceaddcommand.Parameters.AddWithValue("@Amount", invoice.TotalProductInInvoiceQuantity);
                invoiceaddcommand.Parameters.AddWithValue("@Paid", false);
                invoiceaddcommand.Parameters.AddWithValue("@Cost", invoice.TotalCost);
                try
                {
                    connect.Open();

                    invoiceaddcommand.ExecuteNonQuery();
                    connect.Close();
                    AddInvoiceDetails(invoice, connect);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
                return true;

            }
            

        }
        
    }

}
