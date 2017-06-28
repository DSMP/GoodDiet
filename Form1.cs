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
        DataClasses1DataContext db;
        DataSet1 dt;
        int idOfMeal = 0;
        List<int> productsRowsRemoved;
        private int idOfProduct = 0;
        List<Panel> panels;

        public string UserLogin { get; internal set; }
        public string Role { get; internal set; }

        public Form1()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
            dt = new DataSet1();
            productsRowsRemoved = new List<int>();
            panels = new List<Panel>();
            panels.Add(CustomerPanel);
            panels.Add(UsersPanel);
        }        
        private void visibleOffPannels()
        {
            foreach (var item in panels)
            {
                item.Visible = false;
            }
        }

        public void initFields()
        {
            LoginLabel.Text = UserLogin;
            PermissionLabel.Text = Role;
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            var query = from product in db.Produkties
            select product;
            MealsProductsDataGridView.DataSource = query;
            visibleOffPannels();
            CustomerPanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);
            // TODO: This line of code loads data into the 'dataSet1.Posilek_produkty' table. You can move, or remove it, as needed.
            this.posilek_produktyTableAdapter.Fill(this.dataSet1.Posilek_produkty);
            // TODO: This line of code loads data into the 'dataSet1.Produkty' table. You can move, or remove it, as needed.
            this.produktyTableAdapter.Fill(this.dataSet1.Produkty);
            // TODO: This line of code loads data into the 'dataSet1.Posilek' table. You can move, or remove it, as needed.
            this.posilekTableAdapter.Fill(this.dataSet1.Posilek);
            // TODO: This line of code loads data into the 'dataSet1.Klienci' table. You can move, or remove it, as needed.
            this.klienciTableAdapter.Fill(this.dataSet1.Klienci);
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.dataSet1.Employees);
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.dataSet1.Employees);

        }        

        private void klienciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.klienciBindingSource.EndEdit();
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);

            }
            catch (Exception)
            {
                MessageBox.Show("Error with saving");
                this.klienciTableAdapter.Fill(this.dataSet1.Klienci);
            }

        }

        private void SelectChanged(object sender, EventArgs e)
        {
            try
            {

                int SelectedMeal = posilekDataGridView.CurrentCell.RowIndex;
                idOfMeal = (int)posilekDataGridView.Rows[SelectedMeal].Cells[0].Value;
                var queryProductsID = from productsID in db.Posilek_produkties
                                      where productsID.id_posilku == idOfMeal
                                      select new { idOfProduct = productsID.id_produktu };
                var queryproducts = from product in db.Produkties
                                    join idProduct in queryProductsID on product.id_produkty equals idProduct.idOfProduct
                                    select product;

                MealsProductsDataGridView.DataSource = queryproducts;
            }
            catch (Exception)
            {
                
            }
        }

        private void ClearProductsOfMeals(object sender, EventArgs e)
        {
            MealsProductsDataGridView.DataSource = from produkt in db.Produkties
                                                   where produkt.id_produkty < 1
                                                   select produkt;
        }

        private void AddProductToMeal_Click(object sender, EventArgs e)
        {
            String productSelected = ProductsList.SelectedValue.ToString();
            var productRow = from product in db.Produkties
                        where product.nazwa == productSelected
                        select new { IdProduct = product.id_produkty };
            var mealRow = from meal in db.Posileks
                          where meal.id_posilku == idOfMeal
                          select new { IdMeal = meal.id_posilku };
            Posilek_produkty newPosilek = new Posilek_produkty();
            try
            {
                string insertStatement = "Insert into Posilek_produkty values(" + mealRow.FirstOrDefault().IdMeal + ", " +
                        productRow.FirstOrDefault().IdProduct + ")";
                db.ExecuteQuery<Posilek_produkty>(insertStatement);
                SelectChanged(sender,e);
            }
            catch (Exception)
            {
                MessageBox.Show("First save Then choose meal");
            }
            //db.Posilek_produkties.InsertOnSubmit(newPosilek);
            //dt.Posilek_produkty.AddPosilek_produktyRow(mealRow.FirstOrDefault().IdMeal, productRow.FirstOrDefault().IdProduct);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(id_klientTextBox.Text);
            //int ClientID = bindingNavigatorDeleteItem.;
            var queryMeal = from Meal in db.Posileks
                            where Meal.id_klient == ClientID
                            select Meal;
            foreach (var item in queryMeal.ToList())
            {
                var queryProd_Meals = from prod_Meal in db.Posilek_produkties
                                      where prod_Meal.id_posilku == item.id_posilku
                                      select prod_Meal;
                foreach (var item2 in queryProd_Meals.ToList())
                {
                    string insertStatement = "Delete From Posilek_produkty where id_posilku = " + item2.id_posilku;
                    db.ExecuteQuery<Posilek_produkty>(insertStatement);
                }
                db.Posileks.DeleteOnSubmit(item);
            }


            var queryClient = from Client in db.Kliencis
                              where Client.id_klient == ClientID
                              select Client;
            db.Kliencis.DeleteOnSubmit(queryClient.First());
            db.SubmitChanges();
            klienciTableAdapter.Fill(this.dataSet1.Klienci);

        }

        private void productSelectionChanged(object sender, EventArgs e)
        {
            int Selectedproduct = MealsProductsDataGridView.CurrentCell.RowIndex;
            idOfProduct = (int)MealsProductsDataGridView.Rows[Selectedproduct].Cells[0].Value;
        }

        private void RemoveProductFromMeal_Click(object sender, EventArgs e)
        {
            try
            {
                string insertStatement = "Delete From Posilek_produkty where id_posilku = " + idOfMeal + " AND id_produktu = " + idOfProduct;
                db.ExecuteQuery<Posilek_produkty>(insertStatement);
                SelectChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("First choose Product of Meal Then press to Removed");
            }
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            visibleOffPannels();
            UsersPanel.Visible = true;
        }

        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
