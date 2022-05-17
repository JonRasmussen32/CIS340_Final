using System;
using System.Data;
using System.Data.SqlClient;

namespace ShopEasy
{

    public static class DatabaseOperation
    {

        public static Person ReturnItem(String email)
        {
            try {

                SqlConnection connect = ShopEasyDB.GetConnection();

                string selectStatement =
                    "Select *"
                    + " FROM Person"
                    + " Where Email = @email";

                SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
                selectCommand.Parameters.AddWithValue("@email", email);

                Person person = PersonOperations.ReturnPerson(selectCommand, connect);
                return person;


            } catch (Exception ex) {

                throw ex;
            }
            
        }

        
        public static Person ReturnItem(Person person)
        {
            if (person.ID.ToString() == "")
            {
                person = null;
                return person;
            }
            try {
                SqlConnection connect = ShopEasyDB.GetConnection();

                string selectStatement =
               "Select *"
               + "FROM Person"
               + " Where PerID = @id";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
                selectCommand.Parameters.AddWithValue("@id", person.ID);
               
                Person person2 = PersonOperations.ReturnPerson(selectCommand, connect);
                return person2;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static Product ReturnItem(Product product)
        {
            try {
                SqlConnection connect = ShopEasyDB.GetConnection();
                string selectStatement =
               "Select *"
               + "FROM Products"
               + " Where ProdID = @id";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
                selectCommand.Parameters.AddWithValue("@id", product.ID);
                Product product2 = ProductOperations.ReturnProduct(selectCommand, connect);
                return product2;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static Invoice ReturnItem(Invoice invoice)
        {
            
            try {
                SqlConnection connect = ShopEasyDB.GetConnection();
                string selectStatement =
               "Select *"
               + "FROM Invoice"
               + " Where InvID = @id";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connect);
                selectCommand.Parameters.AddWithValue("@id", invoice.ID);
                Invoice invoice2 = InvoiceOperations.ReturnInvoice(selectCommand, connect);
                return invoice2;
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
        
        public static Boolean DeleteItem(int id, String database) {

            //Delete Item Object Parser and check if item exists
            SqlConnection connection = ShopEasyDB.GetConnection();
            SqlCommand remove;
            if (database == "Person")
            {
                Person person = new Person();
                person.ID = id;
                if (ReturnItem(person) == null)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    string removestatement =
                    "DELETE FROM " + database + " WHERE PerID = @id";
                    remove = new SqlCommand(removestatement, connection);
                    remove.Parameters.AddWithValue("@id", id);
                    return DeleteItemAction(remove, connection);
                }
            }
            else
            {
                return false;
            }
        }


        private static Boolean DeleteItemAction(SqlCommand remove, SqlConnection connection)
        {
            try
            {
                connection.Open();
                remove.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }
            return true;

        }
    

        public static Boolean AddorUpdateItem(Person person)
        {
            try
            {
                if (ReturnItem(person) == null)
                {
                    return PersonOperations.AddPerson(person);
                }
                else
                {
                    return PersonOperations.UpdatePerson(person.ID, person);
                }
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
            }

        }


        public static Boolean AddItem(Invoice invoice)
        {

            return InvoiceOperations.AddInvoice(invoice);

        }

        public static Boolean AddorUpdateItem(Product product)
        {

            try
            {
                if (ReturnItem(product) == null)
                {
                    return ProductOperations.AddProduct(product);
                }
                else
                {
                    return ProductOperations.UpdateProduct(product.ID, product);
                }
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
            }

        }
        
        
    }
}
