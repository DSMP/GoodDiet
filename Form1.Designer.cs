namespace DobraDietaApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet = new DobraDietaApp.DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new DobraDietaApp.DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new DobraDietaApp.DataSetTableAdapters.TableAdapterManager();
            this.StatsButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.CustomerMealsButton = new System.Windows.Forms.Button();
            this.PeopleButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.Employees_RolesTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Meal_typeTableAdapter = null;
            this.tableAdapterManager.Meals_productsTableAdapter = null;
            this.tableAdapterManager.MealsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DobraDietaApp.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // StatsButton
            // 
            this.StatsButton.Location = new System.Drawing.Point(12, 12);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(93, 45);
            this.StatsButton.TabIndex = 1;
            this.StatsButton.Text = "Stats";
            this.StatsButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(111, 12);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(94, 45);
            this.ProductsButton.TabIndex = 2;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // CustomerMealsButton
            // 
            this.CustomerMealsButton.Location = new System.Drawing.Point(211, 12);
            this.CustomerMealsButton.Name = "CustomerMealsButton";
            this.CustomerMealsButton.Size = new System.Drawing.Size(104, 45);
            this.CustomerMealsButton.TabIndex = 3;
            this.CustomerMealsButton.Text = "Customer Meals";
            this.CustomerMealsButton.UseVisualStyleBackColor = true;
            this.CustomerMealsButton.Click += new System.EventHandler(this.CustomerMealsButton_Click);
            // 
            // PeopleButton
            // 
            this.PeopleButton.Location = new System.Drawing.Point(321, 12);
            this.PeopleButton.Name = "PeopleButton";
            this.PeopleButton.Size = new System.Drawing.Size(103, 45);
            this.PeopleButton.TabIndex = 4;
            this.PeopleButton.Text = "People";
            this.PeopleButton.UseVisualStyleBackColor = true;
            this.PeopleButton.Click += new System.EventHandler(this.PeopleButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(430, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(96, 45);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(727, 28);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Login";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(827, 28);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(29, 13);
            this.RoleLabel.TabIndex = 7;
            this.RoleLabel.Text = "Role";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 63);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(939, 529);
            this.MainPanel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 592);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.PeopleButton);
            this.Controls.Add(this.CustomerMealsButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.StatsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button CustomerMealsButton;
        private System.Windows.Forms.Button PeopleButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Panel MainPanel;
    }
}