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
            InitializeComponent();
        }

        public object UserId { get; internal set; }
        public string UserLogin { get; internal set; }
        public string Role { get; internal set; }
        public LoginForm LoginForm { get; internal set; }

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

        }
        public void initFields()
        {
            LoginLabel.Text = UserLogin;
            RoleLabel.Text = Role;
            PeopleButton.Visible = Role.Equals("ADMIN") ? true : false;
            //RemoveMealButton.Visible = Role.Equals("ADMIN") ? true : false;
        }
    }
}
