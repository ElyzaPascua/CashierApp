using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp
{
    public partial class Form2 : Form
    {
        private cashier sampleCashier = new cashier("Elyza Pascua", "Finance", "elyza", "password123");
        public Form2()
        {
            InitializeComponent();
        }
        public class account
        {
            protected string full_name;
            protected string user_name;
            protected string user_password;

            public account(string fname, string uname, string password)
            {
                full_name = fname;
                user_name = uname;     
                user_password = password;
            }
            public bool validate(string uname, string password)
            {
                return user_name.Equals(uname) && user_password.Equals(password);
            }
            public string getFullname()
            {
                return full_name;
            }
        }
        public class cashier : account
        {
            private string department;

            public cashier(string fname, string department, string uname, string password):base(fname, uname, password)
            {
                this.department = department;
            }
            public string getDepartment()
            {
                return department;
            }

        }
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cb_show.Checked ? '\0' : '*';
        }

        private void butt_Login_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text;
            string password = txt_password.Text;

            if(sampleCashier.validate(username, password))
            {
                
                MessageBox.Show("Welcome " + sampleCashier.getFullname() + " from " + sampleCashier.getDepartment() + ".");
                this.Hide();
                Form1 regForm = new Form1();
                regForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
            
            
            
             
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cb_show.Checked ? '\0' : '*';
        }
    }
}
