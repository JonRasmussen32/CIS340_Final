using System;

namespace ShopEasy
{

    public class loginverification {

        Person person;

        public loginverification()
        {
            person = null;
        }

        public Boolean Verify(String password, String email){

            if(password == "" || email == ""){

                return false;

            }

            person = DatabaseOperation.ReturnItem(email);

            if(person == null)
            {
                return false;
            }
            else if(person.Password == password){
                return true;
            }
            else{
                return false;
            }
            
        }
        
        public Boolean CheckAdmin()
        {
            if(person == null)
            {
                return false;
            }
            if (person.IsAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
