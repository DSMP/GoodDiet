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
        int idOfMeal = 0;
        private int idOfProduct = 0;
        BindingSource CustomertMealsBindingSource;
        Form1 MainForm;
        public CustomersMealPanel(Form1 mainForm)
        {
            MainForm = mainForm;
            db = new DataClassesDataContext();
            InitializeComponent();
            CustomertMealsBindingSource = new BindingSource();
        }

        private void CustomersMealPanel_Load(object sender, EventArgs e)
        {
            customersTableAdapter.Fill(dataSet.Customers);
            meal_typeTableAdapter.Fill(dataSet.Meal_type);
            productsTableAdapter.Fill(dataSet.Products);
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
                string insertStatement = "Delete From Meals_products where id_meal = " + item2.id_meal;
                db.ExecuteQuery<Meals_product>(insertStatement);
            }
            try
            {
                string insertStatement = "Delete From Meals where id_meal = " + idOfMeal;
                db.ExecuteQuery<Meals_product>(insertStatement);
                ClearProductsOfMeals(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("First choose Product of Meal Then press to Removed");
            }
        }

        private void productSelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int Selectedproduct = MealProductsGridView.CurrentCell.RowIndex;
                idOfProduct = (int)MealProductsGridView.Rows[Selectedproduct].Cells[0].Value;
            }
            catch (Exception)
            {

            }
        }

        private void SelectChanged(object sender, EventArgs e)
        {
            try
            {

                int SelectedMeal = CustomerMealsGridView.CurrentCell.RowIndex;
                idOfMeal = (int)CustomerMealsGridView.Rows[SelectedMeal].Cells[0].Value;
                var queryProductsID = from productsID in db.Meals_products
                                      where productsID.id_meal == idOfMeal
                                      select new { idOfProduct = productsID.id_product };
                var queryproducts = from product in db.Products
                                    join idProduct in queryProductsID on product.id_product equals idProduct.idOfProduct
                                    select product;
                                
                MealProductsGridView.DataSource = queryproducts;
                double temp = 0;
                for (int i = 0; i < MealProductsGridView.Rows.Count; i++)
                {
                    temp += (double)MealProductsGridView.Rows[i].Cells[2].Value;
                }
                WeightSLabel.Text = "Weight: " + temp.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void AddProductToMeal_Click(object sender, EventArgs e)
        {
            String productSelected = ProductComboBox.SelectedValue.ToString();
            var productRow = from product in db.Products
                             where product.name == productSelected
                             select new { IdProduct = product.id_product};
            var mealRow = from meal in db.Meals
                          where meal.id_meal == idOfMeal
                          select new { IdMeal = meal.id_meal };
            Meals_product newPosilek = new Meals_product();
            try
            {
                string insertStatement = "Insert into Meals_products values(" + mealRow.FirstOrDefault().IdMeal + ", " +
                        productRow.FirstOrDefault().IdProduct + ")";
                db.ExecuteQuery<Meals_product>(insertStatement);
                SelectChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("First save Then choose meal");
            }
        }

        private void RemoveProductFromMeal_Click(object sender, EventArgs e)
        {
            try
            {
                string insertStatement = "Delete From Meals_products where id_meal = " + idOfMeal + " AND id_product = " + idOfProduct;
                db.ExecuteQuery<Meals_product>(insertStatement);
                SelectChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("First choose Product of Meal Then press to Removed");
            }
        }


    }
}
