using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DobraDietaApp
{
    public partial class LoginForm : Form
    {
       
        DataClasses1DataContext db;
        public LoginForm()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            //var cos = Sha256encrypt("qwerty");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginText.Text.Equals("") || PasswordText.Text.Equals(""))
            {
                MessageBox.Show("You must fill all the fields");
            }
            else
            {
                try
                {
                    var userLogged = from employee in db.Employees
                    where (employee.login == LoginText.Text) &&
                        (employee.password == Sha256encrypt(PasswordText.Text))
                    select new { Login = employee.login };
                    if (userLogged.FirstOrDefault() != null)
                    {
                        this.Hide();
                        Form1 MainWindow = new Form1();
                        MainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Login or Password");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        public static string Sha256encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));
            return Convert.ToBase64String(hashedDataBytes);
        }
    }
}
