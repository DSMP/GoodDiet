using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DobraDietaApp.Panels
{
    public partial class PeoplePanel : UserControl
    {
        DataClassesDataContext db;
        private byte[] bimage;

        public PeoplePanel()
        {
            db = new DataClassesDataContext();
            InitializeComponent();
            this.customersTableAdapter.Fill(dataSet.Customers);
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int SelectedCustomer = CustomersGridView.CurrentCell.RowIndex;
            int ClientID = (int)CustomersGridView.Rows[SelectedCustomer].Cells[0].Value;
            var queryMeal = from Meal in db.Meals
                            where Meal.id_customer == ClientID
                            select Meal;
            foreach (var item in queryMeal.ToList())
            {
                var queryProd_Meals = from prod_Meal in db.Meals_products
                                      where prod_Meal.id_meal == item.id_meal
                                      select prod_Meal;
                foreach (var item2 in queryProd_Meals.ToList())
                {
                    string insertStatement = "Delete From Meals_products where id_meal = " + item2.id_meal;
                    db.ExecuteQuery<Meals_product>(insertStatement);
                }
                db.Meals.DeleteOnSubmit(item);
            }


            var queryClient = from Client in db.Customers
                              where Client.id_customer == ClientID
                              select Client;
            db.Customers.DeleteOnSubmit(queryClient.First());
            db.SubmitChanges();
            customersTableAdapter.Fill(this.dataSet.Customers);

        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileDirectoryLabel.Text = open.FileName;
                }
                string image = FileDirectoryLabel.Text;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();
            }
            catch (Exception)
            {
            }

        }
        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            newEmployee.login = LoginTextBox.Text;
            newEmployee.name = NameTextBox.Text;
            newEmployee.surname = NameTextBox.Text;
            var nothing = (bimage == null ? newEmployee.photo = null : newEmployee.photo = bimage);
            if (!LoginTextBox.Text.Equals("") && !NameTextBox.Text.Equals("") && !NameTextBox.Text.Equals(""))
            {
                db.Employees.InsertOnSubmit(newEmployee);
                db.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Fill all Fields");
            }
            employeesTableAdapter.Fill(this.dataSet.Employees);
            try
            {
                string insertStatement = "insert into Employee_roles values (" + db.Employees.ToList().Last().id_employee + "," + (IsAdminCheckBox.Checked ? 1 : 2) + ")";
                db.ExecuteQuery<Employees_Role>(insertStatement);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Role " + ex.Message);
            }
        }
    }
}
