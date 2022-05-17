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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            loginverification login = new loginverification();
            if(login.Verify(passwordtxt.Text, emailtxt.Text))
            {
                if (login.CheckAdmin())
                {
                    Admin_Main_Menu menu = new Admin_Main_Menu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                    
                }
                else { 

                Customer_Main_Menu menu = new Customer_Main_Menu(DatabaseOperation.ReturnItem(emailtxt.Text));
                this.Hide();
                menu.ShowDialog();
                this.Show();
                }

                emailtxt.Text = "";
                passwordtxt.Text = ""; 

            }
            else
            {
                MessageBox.Show("Wrong email or password");

            }


        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
