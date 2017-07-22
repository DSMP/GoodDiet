using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobraDietaApp.Panels
{
    public partial class PeoplePanel : UserControl
    {
        DataClassesDataContext db;
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
            int SelectedCustomer = customersDataGridView.CurrentCell.RowIndex;
            int ClientID = (int)customersDataGridView.Rows[SelectedCustomer].Cells[0].Value;
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
    }
}
