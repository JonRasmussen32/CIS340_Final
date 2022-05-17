using System;
using System.Data;
using System.Data.SqlClient;

namespace ShopEasy
{
    public static class PersonOperations
    {
        
        public static Person ReturnPerson(SqlCommand selectCommand, SqlConnection connect)
        {

            Person person = new Person();
            try
            {

                connect.Open();
                SqlDataReader personReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (personReader.Read())
                {
                    person.ID = (int)personReader["PerID"];
                    person.FName = personReader["Fname"].ToString();
                    person.LName = personReader["Lname"].ToString();
                    person.Phone_Number = personReader["Phone Number"].ToString();
                    person.Email = personReader["Email"].ToString();
                    int reward = 0;
                    Int32.TryParse(personReader["Reward Points"].ToString(), out reward);

                    person.Set_Reward_Points(reward);
                    person.IsTeacher = (Boolean)personReader["Is_Teacher"];
                    person.IsAdmin = (Boolean)personReader["Is_Admin"];
                    person.IsSenior = (Boolean)personReader["Is_Senior"];
                    person.IsVeteran = (Boolean)personReader["Is_Veteran"];
                    person.Password = personReader["password"].ToString();


                }
                else
                {
                    person = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();

            }

            return person;


        }


        public static Boolean AddPerson(Person person)
        {

            if(DatabaseOperation.ReturnItem(person) != null)
            {
                return false;
            }
	    
            SqlConnection connection = ShopEasyDB.GetConnection();
            string addStatement = "INSERT INTO Person (Fname, Lname, \"Phone Number\", Email, \"Reward Points\", password, Is_Teacher, Is_Admin, Is_Senior, Is_Veteran) "
                +"Values(@FName, @LName, @Phone_Number, @Email, " 
                +"@Reward_Points, @Password, @IsTeacher, @IsAdmin, @IsSenior, @IsVeteran); ";
            SqlCommand addCommand = new SqlCommand(addStatement, connection);
            addCommand.Parameters.AddWithValue("@FName", person.FName);
            addCommand.Parameters.AddWithValue("@LName", person.LName);
            addCommand.Parameters.AddWithValue("@Phone_Number", person.Phone_Number);
            addCommand.Parameters.AddWithValue("@Email", person.Email);
            addCommand.Parameters.AddWithValue("@Reward_Points", person.Reward_Points);
            addCommand.Parameters.AddWithValue("@Password", person.Password);
            addCommand.Parameters.AddWithValue("@IsTeacher", person.IsTeacher);
            addCommand.Parameters.AddWithValue("@IsAdmin", person.IsAdmin);
            addCommand.Parameters.AddWithValue("@IsSenior", person.IsSenior);
            addCommand.Parameters.AddWithValue("@IsVeteran", person.IsVeteran);

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

        public static Boolean UpdatePerson(int id, Person person)
        {
            if(DatabaseOperation.ReturnItem(person) == null)
            {
                return false;

            }

            SqlConnection connection = ShopEasyDB.GetConnection();
            string updateStatement = "UPDATE Person SET " +
                "FName = @FName, " +
                "LName = @LName, " +
                "\"Phone Number\" = @Phone_Number, " +
                "Email = @Email, " +
                "\"Reward Points\" = @Reward_Points, " +
                "password = @Password, " +
                "Is_Teacher = @IsTeacher, " +
                "Is_Admin = @IsAdmin, " +
                "Is_Senior = @IsSenior, " +
                "Is_Veteran = @IsVeteran " +
                "WHERE PerID = @ID;";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

	   
            updateCommand.Parameters.AddWithValue("@FName", person.FName);
            updateCommand.Parameters.AddWithValue("@LName", person.LName);
            updateCommand.Parameters.AddWithValue("@Phone_Number", person.Phone_Number);
            updateCommand.Parameters.AddWithValue("@Email", person.Email);
            updateCommand.Parameters.AddWithValue("@Reward_Points", person.Reward_Points);
            updateCommand.Parameters.AddWithValue("@Password", person.Password);
            updateCommand.Parameters.AddWithValue("@IsTeacher", person.IsTeacher);
            updateCommand.Parameters.AddWithValue("@IsAdmin", person.IsAdmin);
            updateCommand.Parameters.AddWithValue("@IsSenior", person.IsSenior);
            updateCommand.Parameters.AddWithValue("@IsVeteran", person.IsVeteran);
            updateCommand.Parameters.AddWithValue("@ID", person.ID);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();

            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return true;

        }

    }
}
