namespace CarDealershipApp
{
    partial class DirectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorForm));
            this.insertCar = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addImage = new System.Data.SqlClient.SqlCommand();
            this.getPhoto = new System.Data.SqlClient.SqlCommand();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.carsView1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDataSet2 = new CarDealershipApp.CarDealershipDataSet();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBodyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearboxTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxInsertCarVIN = new System.Windows.Forms.TextBox();
            this.comboBoxInsertCarModel = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxInsertCarCarBodyType = new System.Windows.Forms.ComboBox();
            this.carBodyTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxInsertCarCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxInsertCarColor = new System.Windows.Forms.ComboBox();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxInsertCarEngineType = new System.Windows.Forms.ComboBox();
            this.engineTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxInsertCarGearboxType = new System.Windows.Forms.ComboBox();
            this.gearboxTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxInsertCarManufacturer = new System.Windows.Forms.ComboBox();
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxInsertCarEngineCapacity = new System.Windows.Forms.TextBox();
            this.textBoxInsertCarEnginePower = new System.Windows.Forms.TextBox();
            this.textBoxInsertCarReleaseYear = new System.Windows.Forms.TextBox();
            this.textBoxInsertCarPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonInsertCar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.tabPageServicesAndGoods = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxAddServiceNamd = new System.Windows.Forms.TextBox();
            this.servicesAndGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxAddServiceDescription = new System.Windows.Forms.TextBox();
            this.textBoxAddServicePrice = new System.Windows.Forms.TextBox();
            this.comboBoxAddServiceType = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ModelsTableAdapter();
            this.carBodyTypesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.CarBodyTypesTableAdapter();
            this.categoriesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.CategoriesTableAdapter();
            this.colorsTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ColorsTableAdapter();
            this.engineTypesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.EngineTypesTableAdapter();
            this.gearboxTypesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.GearboxTypesTableAdapter();
            this.manufacturersTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ManufacturersTableAdapter();
            this.servicesAndGoodsTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ServicesAndGoodsTableAdapter();
            this.carsView1TableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.CarsView1TableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCars.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsView1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBodyTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageServicesAndGoods.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndGoodsBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insertCar
            // 
            this.insertCar.CommandText = "insertCar";
            this.insertCar.CommandType = System.Data.CommandType.StoredProcedure;
            this.insertCar.Connection = this.sqlConnection1;
            this.insertCar.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@VIN", System.Data.SqlDbType.VarChar, 17),
            new System.Data.SqlClient.SqlParameter("@model", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@category", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@carBodyType", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@engineType", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@gearboxType", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@manufacturer", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@releaseYear", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@color", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Decimal),
            new System.Data.SqlClient.SqlParameter("@enginePower", System.Data.SqlDbType.VarChar, 200),
            new System.Data.SqlClient.SqlParameter("@engineCapacity", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "1"),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-B0T6AUV\\MSSQLSERVER11;Initial Catalog=CarDealership;Persist S" +
    "ecurity Info=True;User ID=sa;Password=7359";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            // 
            // addImage
            // 
            this.addImage.CommandText = "addImage";
            this.addImage.CommandType = System.Data.CommandType.StoredProcedure;
            this.addImage.Connection = this.sqlConnection1;
            this.addImage.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@VIN", System.Data.SqlDbType.VarChar, 17),
            new System.Data.SqlClient.SqlParameter("@imagePath", System.Data.SqlDbType.VarChar, 1000)});
            // 
            // getPhoto
            // 
            this.getPhoto.CommandText = "getPhoto";
            this.getPhoto.CommandType = System.Data.CommandType.StoredProcedure;
            this.getPhoto.Connection = this.sqlConnection1;
            this.getPhoto.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@VIN", System.Data.SqlDbType.VarChar, 17),
            new System.Data.SqlClient.SqlParameter("@photo", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1936, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // organizationToolStripMenuItem
            // 
            this.organizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeesToolStripMenuItem,
            this.ClientsToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
            this.organizationToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.organizationToolStripMenuItem.Text = "Организация";
            // 
            // EmployeesToolStripMenuItem
            // 
            this.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem";
            this.EmployeesToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.EmployeesToolStripMenuItem.Text = "Сотрудники";
            this.EmployeesToolStripMenuItem.Click += new System.EventHandler(this.EmployeesToolStripMenuItem_Click);
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.ClientsToolStripMenuItem.Text = "Клиенты";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.salesToolStripMenuItem.Text = "Продажи";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPageCars);
            this.tabControl1.Controls.Add(this.tabPageServicesAndGoods);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1944, 975);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageCars
            // 
            this.tabPageCars.BackColor = System.Drawing.Color.White;
            this.tabPageCars.Controls.Add(this.tableLayoutPanel7);
            this.tabPageCars.Location = new System.Drawing.Point(28, 4);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(1912, 967);
            this.tabPageCars.TabIndex = 3;
            this.tabPageCars.Text = "Автомобили";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.21852F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.78148F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1906, 961);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bindingNavigator3);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(769, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1134, 955);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Автомобили";
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.carsView1BindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 919);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(1128, 33);
            this.bindingNavigator3.TabIndex = 1;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            // 
            // carsView1BindingSource
            // 
            this.carsView1BindingSource.DataMember = "CarsView1";
            this.carsView1BindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // carDealershipDataSet2
            // 
            this.carDealershipDataSet2.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 33);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vINDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.carBodyTypeDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.engineTypeDataGridViewTextBoxColumn,
            this.gearboxTypeDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.engineCapacityDataGridViewTextBoxColumn,
            this.enginePowerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.releaseYearDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.carsView1BindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1128, 930);
            this.dataGridView3.TabIndex = 0;
            // 
            // vINDataGridViewTextBoxColumn
            // 
            this.vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            this.vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            this.vINDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            this.vINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.brandNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carBodyTypeDataGridViewTextBoxColumn
            // 
            this.carBodyTypeDataGridViewTextBoxColumn.DataPropertyName = "CarBodyType";
            this.carBodyTypeDataGridViewTextBoxColumn.HeaderText = "Тип кузова";
            this.carBodyTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carBodyTypeDataGridViewTextBoxColumn.Name = "carBodyTypeDataGridViewTextBoxColumn";
            this.carBodyTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineTypeDataGridViewTextBoxColumn
            // 
            this.engineTypeDataGridViewTextBoxColumn.DataPropertyName = "EngineType";
            this.engineTypeDataGridViewTextBoxColumn.HeaderText = "Тип двигателя";
            this.engineTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.engineTypeDataGridViewTextBoxColumn.Name = "engineTypeDataGridViewTextBoxColumn";
            this.engineTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gearboxTypeDataGridViewTextBoxColumn
            // 
            this.gearboxTypeDataGridViewTextBoxColumn.DataPropertyName = "GearboxType";
            this.gearboxTypeDataGridViewTextBoxColumn.HeaderText = "Тип коробки передач";
            this.gearboxTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gearboxTypeDataGridViewTextBoxColumn.Name = "gearboxTypeDataGridViewTextBoxColumn";
            this.gearboxTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineCapacityDataGridViewTextBoxColumn
            // 
            this.engineCapacityDataGridViewTextBoxColumn.DataPropertyName = "EngineCapacity";
            this.engineCapacityDataGridViewTextBoxColumn.HeaderText = "Объём двигателя (см^3)";
            this.engineCapacityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.engineCapacityDataGridViewTextBoxColumn.Name = "engineCapacityDataGridViewTextBoxColumn";
            this.engineCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enginePowerDataGridViewTextBoxColumn
            // 
            this.enginePowerDataGridViewTextBoxColumn.DataPropertyName = "EnginePower";
            this.enginePowerDataGridViewTextBoxColumn.HeaderText = "Мощность (л.с.)";
            this.enginePowerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enginePowerDataGridViewTextBoxColumn.Name = "enginePowerDataGridViewTextBoxColumn";
            this.enginePowerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            this.releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
            this.releaseYearDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.releaseYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            this.releaseYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonInsertCar, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.20327F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.79673F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(760, 955);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label19, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.label20, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.label21, 0, 6);
            this.tableLayoutPanel9.Controls.Add(this.label22, 0, 8);
            this.tableLayoutPanel9.Controls.Add(this.label23, 0, 9);
            this.tableLayoutPanel9.Controls.Add(this.label24, 0, 7);
            this.tableLayoutPanel9.Controls.Add(this.label25, 0, 11);
            this.tableLayoutPanel9.Controls.Add(this.label29, 0, 10);
            this.tableLayoutPanel9.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.textBoxInsertCarVIN, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxInsertCarModel, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxInsertCarCarBodyType, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxInsertCarCategory, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxInsertCarColor, 1, 4);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxInsertCarEngineType, 1, 5);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxInsertCarGearboxType, 1, 6);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxInsertCarManufacturer, 1, 7);
            this.tableLayoutPanel9.Controls.Add(this.textBoxInsertCarEngineCapacity, 1, 8);
            this.tableLayoutPanel9.Controls.Add(this.textBoxInsertCarEnginePower, 1, 9);
            this.tableLayoutPanel9.Controls.Add(this.textBoxInsertCarReleaseYear, 1, 10);
            this.tableLayoutPanel9.Controls.Add(this.textBoxInsertCarPrice, 1, 11);
            this.tableLayoutPanel9.Controls.Add(this.button1, 1, 12);
            this.tableLayoutPanel9.Controls.Add(this.buttonPhoto, 0, 12);
            this.tableLayoutPanel9.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 13;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(754, 496);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "VIN";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(326, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Цвет";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(252, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Тип двигателя";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(204, 217);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Тип коробки передач";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(227, 287);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Объём двигателя";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(200, 322);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Мощность двигателя";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(192, 252);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(182, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "Завод-производитель";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(326, 392);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Цена";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(271, 357);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 20);
            this.label29.TabIndex = 0;
            this.label29.Text = "Год выпуска";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(304, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Модель";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Тип кузова";
            // 
            // textBoxInsertCarVIN
            // 
            this.textBoxInsertCarVIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInsertCarVIN.Location = new System.Drawing.Point(380, 3);
            this.textBoxInsertCarVIN.Name = "textBoxInsertCarVIN";
            this.textBoxInsertCarVIN.Size = new System.Drawing.Size(371, 26);
            this.textBoxInsertCarVIN.TabIndex = 1;
            // 
            // comboBoxInsertCarModel
            // 
            this.comboBoxInsertCarModel.DataSource = this.modelsBindingSource;
            this.comboBoxInsertCarModel.DisplayMember = "Model";
            this.comboBoxInsertCarModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInsertCarModel.FormattingEnabled = true;
            this.comboBoxInsertCarModel.Location = new System.Drawing.Point(380, 38);
            this.comboBoxInsertCarModel.Name = "comboBoxInsertCarModel";
            this.comboBoxInsertCarModel.Size = new System.Drawing.Size(371, 28);
            this.comboBoxInsertCarModel.TabIndex = 2;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // comboBoxInsertCarCarBodyType
            // 
            this.comboBoxInsertCarCarBodyType.DataSource = this.carBodyTypesBindingSource;
            this.comboBoxInsertCarCarBodyType.DisplayMember = "CarBodyType";
            this.comboBoxInsertCarCarBodyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInsertCarCarBodyType.FormattingEnabled = true;
            this.comboBoxInsertCarCarBodyType.Location = new System.Drawing.Point(380, 73);
            this.comboBoxInsertCarCarBodyType.Name = "comboBoxInsertCarCarBodyType";
            this.comboBoxInsertCarCarBodyType.Size = new System.Drawing.Size(371, 28);
            this.comboBoxInsertCarCarBodyType.TabIndex = 3;
            // 
            // carBodyTypesBindingSource
            // 
            this.carBodyTypesBindingSource.DataMember = "CarBodyTypes";
            this.carBodyTypesBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // comboBoxInsertCarCategory
            // 
            this.comboBoxInsertCarCategory.DataSource = this.categoriesBindingSource;
            this.comboBoxInsertCarCategory.DisplayMember = "Category";
            this.comboBoxInsertCarCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInsertCarCategory.FormattingEnabled = true;
            this.comboBoxInsertCarCategory.Location = new System.Drawing.Point(380, 108);
            this.comboBoxInsertCarCategory.Name = "comboBoxInsertCarCategory";
            this.comboBoxInsertCarCategory.Size = new System.Drawing.Size(371, 28);
            this.comboBoxInsertCarCategory.TabIndex = 3;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // comboBoxInsertCarColor
            // 
            this.comboBoxInsertCarColor.DataSource = this.colorsBindingSource;
            this.comboBoxInsertCarColor.DisplayMember = "Color";
            this.comboBoxInsertCarColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInsertCarColor.FormattingEnabled = true;
            this.comboBoxInsertCarColor.Location = new System.Drawing.Point(380, 143);
            this.comboBoxInsertCarColor.Name = "comboBoxInsertCarColor";
            this.comboBoxInsertCarColor.Size = new System.Drawing.Size(371, 28);
            this.comboBoxInsertCarColor.TabIndex = 3;
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // comboBoxInsertCarEngineType
            // 
            this.comboBoxInsertCarEngineType.DataSource = this.engineTypesBindingSource;
            this.comboBoxInsertCarEngineType.DisplayMember = "EngineType";
            this.comboBoxInsertCarEngineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInsertCarEngineType.FormattingEnabled = true;
            this.comboBoxInsertCarEngineType.Location = new System.Drawing.Point(380, 178);
            this.comboBoxInsertCarEngineType.Name = "comboBoxInsertCarEngineType";
            this.comboBoxInsertCarEngineType.Size = new System.Drawing.Size(371, 28);
            this.comboBoxInsertCarEngineType.TabIndex = 3;
            // 
            // engineTypesBindingSource
            // 
            this.engineTypesBindingSource.DataMember = "EngineTypes";
            this.engineTypesBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // comboBoxInsertCarGearboxType
            // 
            this.comboBoxInsertCarGearboxType.DataSource = this.gearboxTypesBindingSource;
            this.comboBoxInsertCarGearboxType.DisplayMember = "GearboxType";
            this.comboBoxInsertCarGearboxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInsertCarGearboxType.FormattingEnabled = true;
            this.comboBoxInsertCarGearboxType.Location = new System.Drawing.Point(380, 213);
            this.comboBoxInsertCarGearboxType.Name = "comboBoxInsertCarGearboxType";
            this.comboBoxInsertCarGearboxType.Size = new System.Drawing.Size(371, 28);
            this.comboBoxInsertCarGearboxType.TabIndex = 3;
            // 
            // gearboxTypesBindingSource
            // 
            this.gearboxTypesBindingSource.DataMember = "GearboxTypes";
            this.gearboxTypesBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // comboBoxInsertCarManufacturer
            // 
            this.comboBoxInsertCarManufacturer.DataSource = this.manufacturersBindingSource;
            this.comboBoxInsertCarManufacturer.DisplayMember = "Manufacturer";
            this.comboBoxInsertCarManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInsertCarManufacturer.FormattingEnabled = true;
            this.comboBoxInsertCarManufacturer.Location = new System.Drawing.Point(380, 248);
            this.comboBoxInsertCarManufacturer.Name = "comboBoxInsertCarManufacturer";
            this.comboBoxInsertCarManufacturer.Size = new System.Drawing.Size(371, 28);
            this.comboBoxInsertCarManufacturer.TabIndex = 3;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "Manufacturers";
            this.manufacturersBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // textBoxInsertCarEngineCapacity
            // 
            this.textBoxInsertCarEngineCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInsertCarEngineCapacity.Location = new System.Drawing.Point(380, 283);
            this.textBoxInsertCarEngineCapacity.Name = "textBoxInsertCarEngineCapacity";
            this.textBoxInsertCarEngineCapacity.Size = new System.Drawing.Size(371, 26);
            this.textBoxInsertCarEngineCapacity.TabIndex = 4;
            this.textBoxInsertCarEngineCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInsertCarEngineCapacity_KeyPress);
            // 
            // textBoxInsertCarEnginePower
            // 
            this.textBoxInsertCarEnginePower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInsertCarEnginePower.Location = new System.Drawing.Point(380, 318);
            this.textBoxInsertCarEnginePower.Name = "textBoxInsertCarEnginePower";
            this.textBoxInsertCarEnginePower.Size = new System.Drawing.Size(371, 26);
            this.textBoxInsertCarEnginePower.TabIndex = 4;
            // 
            // textBoxInsertCarReleaseYear
            // 
            this.textBoxInsertCarReleaseYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInsertCarReleaseYear.Location = new System.Drawing.Point(380, 353);
            this.textBoxInsertCarReleaseYear.Name = "textBoxInsertCarReleaseYear";
            this.textBoxInsertCarReleaseYear.Size = new System.Drawing.Size(371, 26);
            this.textBoxInsertCarReleaseYear.TabIndex = 4;
            this.textBoxInsertCarReleaseYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInsertCarReleaseYear_KeyPress);
            // 
            // textBoxInsertCarPrice
            // 
            this.textBoxInsertCarPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInsertCarPrice.Location = new System.Drawing.Point(380, 388);
            this.textBoxInsertCarPrice.Name = "textBoxInsertCarPrice";
            this.textBoxInsertCarPrice.Size = new System.Drawing.Size(371, 26);
            this.textBoxInsertCarPrice.TabIndex = 4;
            this.textBoxInsertCarPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInsertCarPrice_KeyPress);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(380, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить новое фото";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPhoto.Location = new System.Drawing.Point(3, 423);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(371, 70);
            this.buttonPhoto.TabIndex = 6;
            this.buttonPhoto.Text = "Загрузить текущие фото автомобиля";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(285, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Категория";
            // 
            // buttonInsertCar
            // 
            this.buttonInsertCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInsertCar.Location = new System.Drawing.Point(3, 505);
            this.buttonInsertCar.Name = "buttonInsertCar";
            this.buttonInsertCar.Size = new System.Drawing.Size(754, 61);
            this.buttonInsertCar.TabIndex = 2;
            this.buttonInsertCar.Text = "Создать запись об автомобиле";
            this.buttonInsertCar.UseVisualStyleBackColor = true;
            this.buttonInsertCar.Click += new System.EventHandler(this.buttonInsertCar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel10);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 572);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 380);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel10.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.buttonRight, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.buttonLeft, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(748, 355);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(63, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRight.Location = new System.Drawing.Point(691, 3);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(54, 349);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeft.Location = new System.Drawing.Point(3, 3);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(54, 349);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // tabPageServicesAndGoods
            // 
            this.tabPageServicesAndGoods.Controls.Add(this.tableLayoutPanel11);
            this.tabPageServicesAndGoods.Location = new System.Drawing.Point(28, 4);
            this.tabPageServicesAndGoods.Name = "tabPageServicesAndGoods";
            this.tabPageServicesAndGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServicesAndGoods.Size = new System.Drawing.Size(1912, 967);
            this.tabPageServicesAndGoods.TabIndex = 4;
            this.tabPageServicesAndGoods.Text = "Товары и услуги";
            this.tabPageServicesAndGoods.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.41451F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.58549F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1906, 961);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.buttonUpdate, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.67347F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(764, 955);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.95833F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.04167F));
            this.tableLayoutPanel13.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label28, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.label30, 0, 3);
            this.tableLayoutPanel13.Controls.Add(this.textBoxAddServiceNamd, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.textBoxAddServiceDescription, 1, 2);
            this.tableLayoutPanel13.Controls.Add(this.textBoxAddServicePrice, 1, 3);
            this.tableLayoutPanel13.Controls.Add(this.comboBoxAddServiceType, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 5;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(758, 793);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 20);
            this.label26.TabIndex = 0;
            this.label26.Text = "Тип";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Название";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 77);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "Описание";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 112);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 20);
            this.label30.TabIndex = 0;
            this.label30.Text = "Цена";
            // 
            // textBoxAddServiceNamd
            // 
            this.textBoxAddServiceNamd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAddServiceNamd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesAndGoodsBindingSource, "Name", true));
            this.textBoxAddServiceNamd.Location = new System.Drawing.Point(184, 39);
            this.textBoxAddServiceNamd.Name = "textBoxAddServiceNamd";
            this.textBoxAddServiceNamd.Size = new System.Drawing.Size(270, 26);
            this.textBoxAddServiceNamd.TabIndex = 1;
            // 
            // servicesAndGoodsBindingSource
            // 
            this.servicesAndGoodsBindingSource.DataMember = "ServicesAndGoods";
            this.servicesAndGoodsBindingSource.DataSource = this.carDealershipDataSet2;
            // 
            // textBoxAddServiceDescription
            // 
            this.textBoxAddServiceDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAddServiceDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesAndGoodsBindingSource, "Description", true));
            this.textBoxAddServiceDescription.Location = new System.Drawing.Point(184, 74);
            this.textBoxAddServiceDescription.Name = "textBoxAddServiceDescription";
            this.textBoxAddServiceDescription.Size = new System.Drawing.Size(270, 26);
            this.textBoxAddServiceDescription.TabIndex = 1;
            // 
            // textBoxAddServicePrice
            // 
            this.textBoxAddServicePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAddServicePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesAndGoodsBindingSource, "Price", true));
            this.textBoxAddServicePrice.Location = new System.Drawing.Point(184, 109);
            this.textBoxAddServicePrice.Name = "textBoxAddServicePrice";
            this.textBoxAddServicePrice.Size = new System.Drawing.Size(270, 26);
            this.textBoxAddServicePrice.TabIndex = 1;
            // 
            // comboBoxAddServiceType
            // 
            this.comboBoxAddServiceType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxAddServiceType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesAndGoodsBindingSource, "Type", true));
            this.comboBoxAddServiceType.FormattingEnabled = true;
            this.comboBoxAddServiceType.Items.AddRange(new object[] {
            "Тов",
            "Усл"});
            this.comboBoxAddServiceType.Location = new System.Drawing.Point(184, 3);
            this.comboBoxAddServiceType.Name = "comboBoxAddServiceType";
            this.comboBoxAddServiceType.Size = new System.Drawing.Size(270, 28);
            this.comboBoxAddServiceType.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.Location = new System.Drawing.Point(192, 838);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(380, 77);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.bindingNavigator1);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(773, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1130, 955);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.servicesAndGoodsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 919);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1124, 33);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.servicesAndGoodsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 930);
            this.dataGridView1.TabIndex = 3;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // carBodyTypesTableAdapter
            // 
            this.carBodyTypesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // engineTypesTableAdapter
            // 
            this.engineTypesTableAdapter.ClearBeforeFill = true;
            // 
            // gearboxTypesTableAdapter
            // 
            this.gearboxTypesTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // servicesAndGoodsTableAdapter
            // 
            this.servicesAndGoodsTableAdapter.ClearBeforeFill = true;
            // 
            // carsView1TableAdapter
            // 
            this.carsView1TableAdapter.ClearBeforeFill = true;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1936, 1005);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосалон (Директор)";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCars.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsView1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBodyTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageServicesAndGoods.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndGoodsBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.SqlClient.SqlCommand insertCar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Data.SqlClient.SqlCommand addImage;
        private System.Data.SqlClient.SqlCommand getPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCars;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxInsertCarVIN;
        private System.Windows.Forms.ComboBox comboBoxInsertCarModel;
        private System.Windows.Forms.ComboBox comboBoxInsertCarCarBodyType;
        private System.Windows.Forms.ComboBox comboBoxInsertCarCategory;
        private System.Windows.Forms.ComboBox comboBoxInsertCarColor;
        private System.Windows.Forms.ComboBox comboBoxInsertCarEngineType;
        private System.Windows.Forms.ComboBox comboBoxInsertCarGearboxType;
        private System.Windows.Forms.ComboBox comboBoxInsertCarManufacturer;
        private System.Windows.Forms.TextBox textBoxInsertCarEngineCapacity;
        private System.Windows.Forms.TextBox textBoxInsertCarEnginePower;
        private System.Windows.Forms.TextBox textBoxInsertCarReleaseYear;
        private System.Windows.Forms.TextBox textBoxInsertCarPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonInsertCar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.TabPage tabPageServicesAndGoods;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxAddServiceNamd;
        private System.Windows.Forms.TextBox textBoxAddServiceDescription;
        private System.Windows.Forms.TextBox textBoxAddServicePrice;
        private System.Windows.Forms.ComboBox comboBoxAddServiceType;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarDealershipDataSet carDealershipDataSet2;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private CarDealershipDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.BindingSource carBodyTypesBindingSource;
        private CarDealershipDataSetTableAdapters.CarBodyTypesTableAdapter carBodyTypesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private CarDealershipDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private CarDealershipDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter;
        private System.Windows.Forms.BindingSource engineTypesBindingSource;
        private CarDealershipDataSetTableAdapters.EngineTypesTableAdapter engineTypesTableAdapter;
        private System.Windows.Forms.BindingSource gearboxTypesBindingSource;
        private CarDealershipDataSetTableAdapters.GearboxTypesTableAdapter gearboxTypesTableAdapter;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private CarDealershipDataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.BindingSource servicesAndGoodsBindingSource;
        private CarDealershipDataSetTableAdapters.ServicesAndGoodsTableAdapter servicesAndGoodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource carsView1BindingSource;
        private CarDealershipDataSetTableAdapters.CarsView1TableAdapter carsView1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBodyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearboxTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
    }
}