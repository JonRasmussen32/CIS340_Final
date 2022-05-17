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
    public partial class Person_UpdateorAdder : Form
    {

        Person person;

        public Person_UpdateorAdder()
        {
            InitializeComponent();
        }

	    private Boolean PersonObjectFill()
	    {
            
            if (Int32.TryParse(Rewardptstxt.Text, out int reward))
            {
                person = new Person();


                if (Int32.TryParse(IDtxt.Text, out int id))
                {
                    person.ID = id;

                    person.FName = FNametxt.Text;
                    person.LName = LNametxt.Text;
                    person.Email = Emailtxt.Text;
                    person.Phone_Number = Phonetxt.Text;
                    person.Set_Reward_Points(reward);
                    person.Password = Passwordtxt.Text;
                    person.IsTeacher = Isteacherchkbx.Checked;
                    person.IsSenior = Isseniorchkbx.Checked;
                    person.IsVeteran = Isveteranchkbx.Checked;
                    person.IsAdmin = Isadminchkbx.Checked;
                    return true;
                }
                else
                {
                    MessageBox.Show("Unable to parse, id.  The id has to be a number.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Unable to parse reward points, need to have the reward points be numbers.");
                return false;
            }
	    }
	
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (PersonObjectFill()){
               // if (PersonOperations.AddorUpdatePerson(person))
                if(DatabaseOperation.AddorUpdateItem(person))
                {
                    MessageBox.Show("Addition or modification to the database is a success");
                    Update_Dataset();
                }
                else
                {
                    MessageBox.Show("Unable to add or modify the database, please try again later");
                }
            }

        }

        private void Getcustomerbtn_Click(object sender, EventArgs e)
        {
            int perid = 0;
            if (Int32.TryParse(IDtxt.Text, out perid))
            {
                person = new Person();
                person.ID = perid;
                person = DatabaseOperation.ReturnItem(person);
                if (person != null)
                {
                    IDtxt.Text = person.ID.ToString();
                    FNametxt.Text = person.FName;
                    LNametxt.Text = person.LName;
                    Phonetxt.Text = person.Phone_Number;
                    Emailtxt.Text = person.Email;
                    Rewardptstxt.Text = person.Reward_Points.ToString();
                    Passwordtxt.Text = person.Password;
                    Isteacherchkbx.Checked = person.IsTeacher;
                    Isseniorchkbx.Checked = person.IsSenior;
                    Isveteranchkbx.Checked = person.IsVeteran;
                    Isadminchkbx.Checked = person.IsAdmin;
                }
                else
                {
                    Reset_Text();
                    MessageBox.Show("You have selected a empty id, cannot edit or filled.");
                }
            }
            else
            {
                MessageBox.Show("Can't convert id box into a number, please put in a number into the id box.");
            }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(IDtxt.Text);


            using (var form = new Confirmation())
            {

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (DatabaseOperation.DeleteItem(id, "Person") == false)
                    {

                        MessageBox.Show("ID doesn't exist, can't delete.");
                    }
                }
            }
            Update_Dataset();
        }

        private void Reset_Text()
        {
            IDtxt.Text = "";
            FNametxt.Text = "";
            LNametxt.Text = "";
            Phonetxt.Text = "";
            Emailtxt.Text = "";
            Rewardptstxt.Text = "";
            Passwordtxt.Text = "";
            Isteacherchkbx.Checked = false;
            Isseniorchkbx.Checked = false;
            Isveteranchkbx.Checked = false;
            Isadminchkbx.Checked = false;


        }

        private void Update_Dataset()
        {
            this.personTableAdapter.Fill(this.ShopEasy_DBDataSet.Person);
        }

        private void Person_UpdateorAdder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ShopEasy_DBDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.ShopEasy_DBDataSet.Person);

        }
    }
}
