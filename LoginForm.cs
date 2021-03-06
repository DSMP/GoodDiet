﻿using System;
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
       
        DataClassesDataContext db;
        public LoginForm()
        {
            InitializeComponent();
            db = new DataClassesDataContext();
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
                        ((employee.password == Sha256encrypt(PasswordText.Text)) || employee.password == null)
                    select new { UserID = employee.id_employee, Login = employee.login, Pass = employee.password };
                    if (userLogged.FirstOrDefault() != null)
                    {
                        if (userLogged.First().Pass == null)
                        {
                            Employee userNewPass = (from employeePass in db.Employees
                                              where employeePass.id_employee == userLogged.First().UserID
                                              select employeePass).First();
                            userNewPass.password = Sha256encrypt(PasswordText.Text);
                            db.SubmitChanges();
                        }
                        Form1 MainWindow = new Form1();
                        MainWindow.UserId = userLogged.First().UserID;
                        MainWindow.UserLogin = LoginText.Text;
                        MainWindow.Role = (from role in db.Roles
                                          where role.id_role == (from empl_role in db.Employees_Roles
                                                                 where empl_role.id_employee == (from employee in db.Employees
                                                                                                   where employee.login == LoginText.Text
                                                                                                   select new { EmployeeId = employee.id_employee }).First().EmployeeId
                                                                 select new { IdRole = empl_role.id_role }).First().IdRole
                                          select role).First().name;
                        MainWindow.LoginForm = this;
                        MainWindow.Show();
                        MainWindow.InitFields();
                        this.Hide();
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

        internal void Logout()
        {
            PasswordText.Text = "";
        }
    }
}
