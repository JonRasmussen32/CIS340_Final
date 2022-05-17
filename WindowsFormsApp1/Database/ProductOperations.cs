using System;
using System.Data;
using System.Data.SqlClient;

namespace ShopEasy
{

    public static class ProductOperations
    {

        public static Product ReturnProduct(SqlCommand selectCommand, SqlConnection connect)
        {
            Product product = new Product();

            try{
                
                connect.Open();
                SqlDataReader productReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (productReader.Read())
                {

                    product.ID = (int)productReader["ProdID"];
                    product.Name =  productReader["Name"].ToString();
                    product.Cost = (decimal)productReader["Cost"];
                    product.ProductType =  productReader["Product Type"].ToString();
                    product.Description =  productReader["Description"].ToString();
                    product.SetProductPurchasedQuantity(0);


                }

            }
            catch(Exception ex){

                throw ex;
                
            }
            finally{
                connect.Close();
            }


            return product;
            


        }
        
        public static Boolean AddProduct(Product product)
        {
            if(DatabaseOperation.ReturnItem(product) != null)
            {
                return false;
            }

            SqlConnection connection = ShopEasyDB.GetConnection();
            string addStatement = "INSERT INTO Products (Name, Description, Cost, \"Product Type\") "
                + "Values(@Name, @Description, @Cost, @ProductType); ";
            SqlCommand addCommand = new SqlCommand(addStatement, connection);
            addCommand.Parameters.AddWithValue("@Name", product.Name);
            addCommand.Parameters.AddWithValue("@Description", product.Description);
            addCommand.Parameters.AddWithValue("@Cost", product.Cost);
            addCommand.Parameters.AddWithValue("@ProductType", product.ProductType);
             
            try{
                connection.Open();
                addCommand.ExecuteNonQuery();
            }
            catch(Exception ex){
                throw ex;
            }
            finally{
                connection.Close();
            }
            return true;
        }

        public static Boolean UpdateProduct(int id, Product product)
        {
            if(DatabaseOperation.ReturnItem(product) == null){
                return false;
            }

            
            SqlConnection connection = ShopEasyDB.GetConnection();
            string updateStatement = "UPDATE Products SET "
                + "Name = @Name"
                + "Description = @Description"
                + "Cost = @Cost"
                + "\"Product Type\" = @ProductType"
                + "WHERE PerID = @ID;";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
        
            updateCommand.Parameters.AddWithValue("@Name", product.Name);
            updateCommand.Parameters.AddWithValue("@Description", product.Description);
            updateCommand.Parameters.AddWithValue("@Cost", product.Cost);
            updateCommand.Parameters.AddWithValue("@ProductType", product.ProductType);
            updateCommand.Parameters.AddWithValue("@ID", product.ID);
        
            try{
                connection.Open();
                updateCommand.ExecuteNonQuery();
            
            }
            catch(Exception ex){
                throw ex;
            }
            finally{
                connection.Close();
            }
            return true;
        }

    }

}
