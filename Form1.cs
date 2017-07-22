using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobraDietaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormClosing += Application_ApplicationExit;
            InitializeComponent();
        }

        public int UserId { get; internal set; }
        public string UserLogin { get; internal set; }
        public string Role { get; internal set; }
        public LoginForm LoginForm { get; internal set; }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            this.LoginForm.Close();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dataSet.Customers);
            MainPanel.Dock = DockStyle.None;

        }
        public void InitFields()
        {
            LoginLabel.Text = UserLogin;
            RoleLabel.Text = Role;
            PeopleButton.Visible = Role.Equals("ADMIN") ? true : false;
            //RemoveMealButton.Visible = Role.Equals("ADMIN") ? true : false;
        }

        private void CustomerMealsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Panels.CustomersMealPanel(this));
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Panels.ProductsPanel());
        }

        private void PeopleButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Panels.PeoplePanel());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.LoginForm.Show();
            this.FormClosing -= Application_ApplicationExit;
            LoginForm.Logout();
            this.Close();
        }
    }
}
