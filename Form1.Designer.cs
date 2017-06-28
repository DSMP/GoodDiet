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
            System.Windows.Forms.Label id_klientLabel;
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label wiekLabel;
            System.Windows.Forms.Label wagaLabel;
            System.Windows.Forms.Label wzrostLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductsList = new System.Windows.Forms.ComboBox();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DobraDietaApp.DataSet1();
            this.MealsProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.posilekDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posilekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_klientTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.wiekTextBox = new System.Windows.Forms.TextBox();
            this.wagaTextBox = new System.Windows.Forms.TextBox();
            this.wzrostTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.klienciTableAdapter = new DobraDietaApp.DataSet1TableAdapters.KlienciTableAdapter();
            this.tableAdapterManager = new DobraDietaApp.DataSet1TableAdapters.TableAdapterManager();
            this.posilek_produktyTableAdapter = new DobraDietaApp.DataSet1TableAdapters.Posilek_produktyTableAdapter();
            this.posilekTableAdapter = new DobraDietaApp.DataSet1TableAdapters.PosilekTableAdapter();
            this.produktyTableAdapter = new DobraDietaApp.DataSet1TableAdapters.ProduktyTableAdapter();
            this.klienciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.klienciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.posilek_produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKidproduktuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            id_klientLabel = new System.Windows.Forms.Label();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            wiekLabel = new System.Windows.Forms.Label();
            wagaLabel = new System.Windows.Forms.Label();
            wzrostLabel = new System.Windows.Forms.Label();
            this.CustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MealsProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posilekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posilekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).BeginInit();
            this.klienciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posilek_produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKidproduktuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_klientLabel
            // 
            id_klientLabel.AutoSize = true;
            id_klientLabel.Location = new System.Drawing.Point(29, 33);
            id_klientLabel.Name = "id_klientLabel";
            id_klientLabel.Size = new System.Drawing.Size(46, 13);
            id_klientLabel.TabIndex = 0;
            id_klientLabel.Text = "id klient:";
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(29, 59);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(28, 13);
            imieLabel.TabIndex = 2;
            imieLabel.Text = "imie:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(29, 85);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(54, 13);
            nazwiskoLabel.TabIndex = 4;
            nazwiskoLabel.Text = "nazwisko:";
            // 
            // wiekLabel
            // 
            wiekLabel.AutoSize = true;
            wiekLabel.Location = new System.Drawing.Point(29, 111);
            wiekLabel.Name = "wiekLabel";
            wiekLabel.Size = new System.Drawing.Size(32, 13);
            wiekLabel.TabIndex = 6;
            wiekLabel.Text = "wiek:";
            // 
            // wagaLabel
            // 
            wagaLabel.AutoSize = true;
            wagaLabel.Location = new System.Drawing.Point(29, 137);
            wagaLabel.Name = "wagaLabel";
            wagaLabel.Size = new System.Drawing.Size(36, 13);
            wagaLabel.TabIndex = 8;
            wagaLabel.Text = "waga:";
            // 
            // wzrostLabel
            // 
            wzrostLabel.AutoSize = true;
            wzrostLabel.Location = new System.Drawing.Point(29, 163);
            wzrostLabel.Name = "wzrostLabel";
            wzrostLabel.Size = new System.Drawing.Size(40, 13);
            wzrostLabel.TabIndex = 10;
            wzrostLabel.Text = "wzrost:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Meals";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(283, 28);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(90, 35);
            this.CustomersButton.TabIndex = 2;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(422, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Controls.Add(this.button6);
            this.CustomerPanel.Controls.Add(this.button3);
            this.CustomerPanel.Controls.Add(this.ProductsList);
            this.CustomerPanel.Controls.Add(this.MealsProductsDataGridView);
            this.CustomerPanel.Controls.Add(this.posilekDataGridView);
            this.CustomerPanel.Controls.Add(id_klientLabel);
            this.CustomerPanel.Controls.Add(this.id_klientTextBox);
            this.CustomerPanel.Controls.Add(imieLabel);
            this.CustomerPanel.Controls.Add(this.imieTextBox);
            this.CustomerPanel.Controls.Add(nazwiskoLabel);
            this.CustomerPanel.Controls.Add(this.nazwiskoTextBox);
            this.CustomerPanel.Controls.Add(wiekLabel);
            this.CustomerPanel.Controls.Add(this.wiekTextBox);
            this.CustomerPanel.Controls.Add(wagaLabel);
            this.CustomerPanel.Controls.Add(this.wagaTextBox);
            this.CustomerPanel.Controls.Add(wzrostLabel);
            this.CustomerPanel.Controls.Add(this.wzrostTextBox);
            this.CustomerPanel.Location = new System.Drawing.Point(12, 73);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(893, 485);
            this.CustomerPanel.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 261);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Remove Product From Meal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.RemoveProductFromMeal_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add product to meal\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddProductToMeal_Click);
            // 
            // ProductsList
            // 
            this.ProductsList.DataSource = this.produktyBindingSource;
            this.ProductsList.DisplayMember = "nazwa";
            this.ProductsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Location = new System.Drawing.Point(20, 203);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(185, 21);
            this.ProductsList.TabIndex = 14;
            this.ProductsList.ValueMember = "nazwa";
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MealsProductsDataGridView
            // 
            this.MealsProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MealsProductsDataGridView.Location = new System.Drawing.Point(211, 203);
            this.MealsProductsDataGridView.Name = "MealsProductsDataGridView";
            this.MealsProductsDataGridView.Size = new System.Drawing.Size(679, 179);
            this.MealsProductsDataGridView.TabIndex = 13;
            this.MealsProductsDataGridView.SelectionChanged += new System.EventHandler(this.productSelectionChanged);
            // 
            // posilekDataGridView
            // 
            this.posilekDataGridView.AutoGenerateColumns = false;
            this.posilekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posilekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.posilekDataGridView.DataSource = this.posilekBindingSource;
            this.posilekDataGridView.Location = new System.Drawing.Point(211, 30);
            this.posilekDataGridView.Name = "posilekDataGridView";
            this.posilekDataGridView.Size = new System.Drawing.Size(679, 166);
            this.posilekDataGridView.TabIndex = 12;
            this.posilekDataGridView.SelectionChanged += new System.EventHandler(this.SelectChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_posilku";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Meal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_klient";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Customer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_typ_posilku";
            this.dataGridViewTextBoxColumn3.HeaderText = "Meal Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_posilku";
            this.dataGridViewTextBoxColumn4.HeaderText = "Meal Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_employee";
            this.dataGridViewTextBoxColumn5.HeaderText = "Who Entered";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_wprowadzenia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Entered";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // posilekBindingSource
            // 
            this.posilekBindingSource.DataMember = "FK_id_klient";
            this.posilekBindingSource.DataSource = this.klienciBindingSource;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.dataSet1;
            // 
            // id_klientTextBox
            // 
            this.id_klientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "id_klient", true));
            this.id_klientTextBox.Location = new System.Drawing.Point(89, 30);
            this.id_klientTextBox.Name = "id_klientTextBox";
            this.id_klientTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_klientTextBox.TabIndex = 1;
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(89, 56);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(100, 20);
            this.imieTextBox.TabIndex = 3;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(89, 82);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoTextBox.TabIndex = 5;
            // 
            // wiekTextBox
            // 
            this.wiekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "wiek", true));
            this.wiekTextBox.Location = new System.Drawing.Point(89, 108);
            this.wiekTextBox.Name = "wiekTextBox";
            this.wiekTextBox.Size = new System.Drawing.Size(100, 20);
            this.wiekTextBox.TabIndex = 7;
            // 
            // wagaTextBox
            // 
            this.wagaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "waga", true));
            this.wagaTextBox.Location = new System.Drawing.Point(89, 134);
            this.wagaTextBox.Name = "wagaTextBox";
            this.wagaTextBox.Size = new System.Drawing.Size(100, 20);
            this.wagaTextBox.TabIndex = 9;
            // 
            // wzrostTextBox
            // 
            this.wzrostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "wzrost", true));
            this.wzrostTextBox.Location = new System.Drawing.Point(89, 160);
            this.wzrostTextBox.Name = "wzrostTextBox";
            this.wzrostTextBox.Size = new System.Drawing.Size(100, 20);
            this.wzrostTextBox.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.KlienciTableAdapter = this.klienciTableAdapter;
            this.tableAdapterManager.Posilek_produktyTableAdapter = this.posilek_produktyTableAdapter;
            this.tableAdapterManager.PosilekTableAdapter = this.posilekTableAdapter;
            this.tableAdapterManager.pracownik_rolaTableAdapter = null;
            this.tableAdapterManager.ProduktyTableAdapter = this.produktyTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.typ_posilkuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DobraDietaApp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // posilek_produktyTableAdapter
            // 
            this.posilek_produktyTableAdapter.ClearBeforeFill = true;
            // 
            // posilekTableAdapter
            // 
            this.posilekTableAdapter.ClearBeforeFill = true;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // klienciBindingNavigator
            // 
            this.klienciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klienciBindingNavigator.BindingSource = this.klienciBindingSource;
            this.klienciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klienciBindingNavigator.DeleteItem = null;
            this.klienciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.klienciBindingNavigatorSaveItem});
            this.klienciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klienciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klienciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klienciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klienciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klienciBindingNavigator.Name = "klienciBindingNavigator";
            this.klienciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klienciBindingNavigator.Size = new System.Drawing.Size(917, 25);
            this.klienciBindingNavigator.TabIndex = 7;
            this.klienciBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.ClearProductsOfMeals);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.ClearProductsOfMeals);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // klienciBindingNavigatorSaveItem
            // 
            this.klienciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klienciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klienciBindingNavigatorSaveItem.Image")));
            this.klienciBindingNavigatorSaveItem.Name = "klienciBindingNavigatorSaveItem";
            this.klienciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.klienciBindingNavigatorSaveItem.Text = "Save Data";
            this.klienciBindingNavigatorSaveItem.Click += new System.EventHandler(this.klienciBindingNavigatorSaveItem_Click);
            // 
            // posilek_produktyBindingSource
            // 
            this.posilek_produktyBindingSource.DataMember = "FK_id_posilek";
            this.posilek_produktyBindingSource.DataSource = this.posilekBindingSource;
            // 
            // fKidproduktuBindingSource
            // 
            this.fKidproduktuBindingSource.DataMember = "FK_id_produktu";
            this.fKidproduktuBindingSource.DataSource = this.produktyBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 558);
            this.Controls.Add(this.klienciBindingNavigator);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MealsProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posilekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posilekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).EndInit();
            this.klienciBindingNavigator.ResumeLayout(false);
            this.klienciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posilek_produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKidproduktuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.Button button5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private DataSet1TableAdapters.KlienciTableAdapter klienciTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klienciBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton klienciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_klientTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox wiekTextBox;
        private System.Windows.Forms.TextBox wagaTextBox;
        private System.Windows.Forms.TextBox wzrostTextBox;
        private DataSet1TableAdapters.PosilekTableAdapter posilekTableAdapter;
        private System.Windows.Forms.BindingSource posilekBindingSource;
        private System.Windows.Forms.DataGridView posilekDataGridView;
        private DataSet1TableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private DataSet1TableAdapters.Posilek_produktyTableAdapter posilek_produktyTableAdapter;
        private System.Windows.Forms.BindingSource posilek_produktyBindingSource;
        private System.Windows.Forms.DataGridView MealsProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox ProductsList;
        private System.Windows.Forms.BindingSource fKidproduktuBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
    }
}

