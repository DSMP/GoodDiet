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
    public partial class CustomersMealPanel : UserControl
    {
        DataClassesDataContext db;
        BindingSource CustomertMealsBindingSource;
        Form1 MainForm;
        public CustomersMealPanel(Form1 mainForm)
        {
            MainForm = mainForm;
            db = new DataClassesDataContext();
            InitializeComponent();
            CustomertMealsBindingSource = new BindingSource();
            customersTableAdapter.Fill(dataSet.Customers);
            meal_typeTableAdapter.Fill(dataSet.Meal_type);
            customersBindingSource.DataSourceChanged += CustomersBindingSource_DataSourceChanged;
        }

        private void CustomersBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            ClearProductsOfMeals(sender, e);
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }
        private void ClearProductsOfMeals(object sender, EventArgs e) // next client id
        {
            MealProductsGridView.DataSource = from produkt in db.Products
                                                   where produkt.id_product < 1
                                                   select produkt;

            var fillMealTable = from meal in db.Meals
                                where meal.id_customer == Convert.ToInt32(id_customerTextBox.Text)
                                select new
                                {
                                    meal.id_meal,
                                    meal.meal_date,
                                    TypeOfMeal = (from mealType in db.Meal_types
                                                  where mealType.id_meal_type == meal.id_meal_type
                                                  select new { mealType.name }).First().name,
                                    EmployeeName = (from employee in db.Employees
                                                    where employee.id_employee == meal.id_employee
                                                    select new { employee.name }).First().name,
                                    meal.date_inserted
                                };
            CustomertMealsBindingSource.DataSource = fillMealTable;
            CustomerMealsGridView.DataSource = CustomertMealsBindingSource;
        }
        private void AddMealButton_Click(object sender, EventArgs e)
        {
            if (MealDatePicker.Value <= DateTime.Now) return;
            db.Meals.InsertOnSubmit(new Meal
            {
                meal_date = MealDatePicker.Value,
                date_inserted = DateTime.Now,
                id_employee = MainForm.UserId,
                id_customer = Convert.ToInt32(id_customerTextBox.Text),
                id_meal_type = MealTypeComboBox.SelectedIndex + 1
            });
            CustomerMealsGridView.DataSource = CustomertMealsBindingSource;
            db.SubmitChanges();
            ClearProductsOfMeals(sender, e);
        }

        private void RemoveMealButton_Click(object sender, EventArgs e)
        {
            int SelectedMeal = CustomerMealsGridView.CurrentCell.RowIndex;
            int idOfMeal = (int)CustomerMealsGridView.Rows[SelectedMeal].Cells[0].Value;
            var queryProd_Meals = from prod_Meal in db.Meals_products
                                  where prod_Meal.id_meal == idOfMeal
                                  select prod_Meal;
            foreach (var item2 in queryProd_Meals.ToList())
            {
                string insertStatement = "Delete From Posilek_produkty where id_posilku = " + item2.id_meal;
                db.ExecuteQuery<Meals_product>(insertStatement);
            }
            try
            {
                string insertStatement = "Delete From Posilek where id_posilku = " + idOfMeal;
                db.ExecuteQuery<Meals_product>(insertStatement);
                ClearProductsOfMeals(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("First choose Product of Meal Then press to Removed");
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.meal_typeTableAdapter.FillBy(this.dataSet.Meal_type);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.meal_typeTableAdapter.Fill(this.dataSet.Meal_type);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
