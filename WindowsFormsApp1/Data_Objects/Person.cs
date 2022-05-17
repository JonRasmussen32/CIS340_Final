using System;

namespace ShopEasy
{

    public class Person : Item
    {
        
        private int reward_point;

        public String FName
        {
            get;
            set;
        }

        public String LName
        {
            get;
            set;
        }

        public String Phone_Number
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public Boolean IsAdmin
        {
            get;
            set;
        }

        public Boolean IsTeacher
        {
            get;
            set;
        }

        public Boolean IsVeteran
        {
            get;
            set;
        }

        public Boolean IsSenior
        {
            get;
            set;
        }

        public int Reward_Points
        {
            get
            {
                return reward_point;
            }

        }

        public void Set_Reward_Points(int value)
        {
            if(value < 0)
            {
                throw new DataMisalignedException();
            }
            else
            {
                reward_point = value;
            }
        }

        public void Add_Reward_Points(int reward) => Set_Reward_Points(reward_point += reward);
        
        public void Subtract_Reward_Points(int reward) => Set_Reward_Points(reward_point -= reward);


    }

}
