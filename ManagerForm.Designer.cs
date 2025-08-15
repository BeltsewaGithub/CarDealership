namespace CarDealershipApp
{
    partial class ManagerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.carsView1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDataSet = new CarDealershipApp.CarDealershipDataSet();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBodyTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.engineTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gearboxTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesAndGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsView1TableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.CarsView1TableAdapter();
            this.modelsTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ModelsTableAdapter();
            this.carBodyTypesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.CarBodyTypesTableAdapter();
            this.categoriesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.CategoriesTableAdapter();
            this.colorsTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ColorsTableAdapter();
            this.engineTypesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.EngineTypesTableAdapter();
            this.gearboxTypesTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.GearboxTypesTableAdapter();
            this.manufacturersTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ManufacturersTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.servicesAndGoodsTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ServicesAndGoodsTableAdapter();
            this.clientsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsViewTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ClientsViewTableAdapter();
            this.tabPageServicesAndGoods = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonClearFiltersService = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.buttonFilterName = new System.Windows.Forms.Button();
            this.buttonFilterServiceType = new System.Windows.Forms.Button();
            this.buttonFilterPriceService = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFilterServicePriceEnd = new System.Windows.Forms.TextBox();
            this.textBoxFilterServicePriceStart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBodyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearboxTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilterReleaseYearEnd = new System.Windows.Forms.TextBox();
            this.textBoxFilterReleaseYearStart = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFilterEnginePowerEnd = new System.Windows.Forms.TextBox();
            this.textBoxFilterEnginePowerStart = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilterEngineCapacityEnd = new System.Windows.Forms.TextBox();
            this.textBoxFilterEngineCapacityStart = new System.Windows.Forms.TextBox();
            this.textBoxFilterVIN = new System.Windows.Forms.TextBox();
            this.comboBoxFilterModel = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterCarBodyType = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterColor = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterEngineType = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterGearboxType = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterManufacturer = new System.Windows.Forms.ComboBox();
            this.buttonFilterVIN = new System.Windows.Forms.Button();
            this.buttonFilterModel = new System.Windows.Forms.Button();
            this.buttonFilterCarBodyType = new System.Windows.Forms.Button();
            this.buttonFilterCategory = new System.Windows.Forms.Button();
            this.buttonFilterColor = new System.Windows.Forms.Button();
            this.buttonFilterEngineType = new System.Windows.Forms.Button();
            this.buttonFilterGearboxType = new System.Windows.Forms.Button();
            this.buttonFilterManufacturer = new System.Windows.Forms.Button();
            this.buttonFilterEngineCapacity = new System.Windows.Forms.Button();
            this.buttonFilterEnginePower = new System.Windows.Forms.Button();
            this.buttonEngineReleaseYear = new System.Windows.Forms.Button();
            this.buttonFilterPrice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFilterPriceEnd = new System.Windows.Forms.TextBox();
            this.textBoxFilterPriceStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2Update = new System.Windows.Forms.Button();
            this.button1UpdateSales = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.serviceContractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conractNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceContractsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.saleContractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conractNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleContractsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonCreateCarSale = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.saleContractsViewTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.SaleContractsViewTableAdapter();
            this.serviceContractsViewTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ServiceContractsViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carsView1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBodyTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndGoodsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewBindingSource)).BeginInit();
            this.tabPageServicesAndGoods.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPageCars.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceContractsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleContractsViewBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsView1BindingSource
            // 
            this.carsView1BindingSource.DataMember = "CarsView1";
            this.carsView1BindingSource.DataSource = this.carDealershipDataSet;
            // 
            // carDealershipDataSet
            // 
            this.carDealershipDataSet.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // carBodyTypesBindingSource
            // 
            this.carBodyTypesBindingSource.DataMember = "CarBodyTypes";
            this.carBodyTypesBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // engineTypesBindingSource
            // 
            this.engineTypesBindingSource.DataMember = "EngineTypes";
            this.engineTypesBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // gearboxTypesBindingSource
            // 
            this.gearboxTypesBindingSource.DataMember = "GearboxTypes";
            this.gearboxTypesBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "Manufacturers";
            this.manufacturersBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // servicesAndGoodsBindingSource
            // 
            this.servicesAndGoodsBindingSource.DataMember = "ServicesAndGoods";
            this.servicesAndGoodsBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1655, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // carsView1TableAdapter
            // 
            this.carsView1TableAdapter.ClearBeforeFill = true;
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
            // clientsViewBindingSource
            // 
            this.clientsViewBindingSource.DataMember = "ClientsView";
            this.clientsViewBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // clientsViewTableAdapter
            // 
            this.clientsViewTableAdapter.ClearBeforeFill = true;
            // 
            // tabPageServicesAndGoods
            // 
            this.tabPageServicesAndGoods.BackColor = System.Drawing.Color.White;
            this.tabPageServicesAndGoods.Controls.Add(this.tableLayoutPanel2);
            this.tabPageServicesAndGoods.Location = new System.Drawing.Point(4, 29);
            this.tabPageServicesAndGoods.Name = "tabPageServicesAndGoods";
            this.tabPageServicesAndGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServicesAndGoods.Size = new System.Drawing.Size(1647, 957);
            this.tabPageServicesAndGoods.TabIndex = 4;
            this.tabPageServicesAndGoods.Text = "Товары и услуги";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65692F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.34308F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1641, 951);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Name,
            this.Description,
            this.Price,
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.servicesAndGoodsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(703, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(935, 945);
            this.dataGridView1.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Товар/услуга";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Название";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonClearFiltersService);
            this.groupBox7.Controls.Add(this.tableLayoutPanel3);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(694, 945);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Фильтры";
            // 
            // buttonClearFiltersService
            // 
            this.buttonClearFiltersService.Location = new System.Drawing.Point(197, 248);
            this.buttonClearFiltersService.Name = "buttonClearFiltersService";
            this.buttonClearFiltersService.Size = new System.Drawing.Size(301, 62);
            this.buttonClearFiltersService.TabIndex = 2;
            this.buttonClearFiltersService.Text = "Сбросить фильтры";
            this.buttonClearFiltersService.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxFilterName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxFilterType, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonFilterName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonFilterServiceType, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonFilterPriceService, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox11, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(668, 173);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilterName.Location = new System.Drawing.Point(3, 3);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(336, 26);
            this.textBoxFilterName.TabIndex = 1;
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Items.AddRange(new object[] {
            "Тов",
            "Усл"});
            this.comboBoxFilterType.Location = new System.Drawing.Point(3, 58);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterType.TabIndex = 2;
            // 
            // buttonFilterName
            // 
            this.buttonFilterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterName.Location = new System.Drawing.Point(345, 3);
            this.buttonFilterName.Name = "buttonFilterName";
            this.buttonFilterName.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterName.TabIndex = 5;
            this.buttonFilterName.Text = "Поиск по названию";
            this.buttonFilterName.UseVisualStyleBackColor = true;
            this.buttonFilterName.Click += new System.EventHandler(this.buttonFilterName_Click);
            // 
            // buttonFilterServiceType
            // 
            this.buttonFilterServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterServiceType.Location = new System.Drawing.Point(345, 58);
            this.buttonFilterServiceType.Name = "buttonFilterServiceType";
            this.buttonFilterServiceType.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterServiceType.TabIndex = 5;
            this.buttonFilterServiceType.Text = "Товар/услуга";
            this.buttonFilterServiceType.UseVisualStyleBackColor = true;
            this.buttonFilterServiceType.Click += new System.EventHandler(this.buttonFilterServiceType_Click);
            // 
            // buttonFilterPriceService
            // 
            this.buttonFilterPriceService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterPriceService.Location = new System.Drawing.Point(345, 113);
            this.buttonFilterPriceService.Name = "buttonFilterPriceService";
            this.buttonFilterPriceService.Size = new System.Drawing.Size(320, 57);
            this.buttonFilterPriceService.TabIndex = 5;
            this.buttonFilterPriceService.Text = "Фильтр по цене";
            this.buttonFilterPriceService.UseVisualStyleBackColor = true;
            this.buttonFilterPriceService.Click += new System.EventHandler(this.buttonFilterPriceService_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.textBoxFilterServicePriceEnd);
            this.groupBox11.Controls.Add(this.textBoxFilterServicePriceStart);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 113);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(336, 57);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "-";
            // 
            // textBoxFilterServicePriceEnd
            // 
            this.textBoxFilterServicePriceEnd.Location = new System.Drawing.Point(198, 16);
            this.textBoxFilterServicePriceEnd.Name = "textBoxFilterServicePriceEnd";
            this.textBoxFilterServicePriceEnd.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterServicePriceEnd.TabIndex = 7;
            // 
            // textBoxFilterServicePriceStart
            // 
            this.textBoxFilterServicePriceStart.Location = new System.Drawing.Point(27, 16);
            this.textBoxFilterServicePriceStart.Name = "textBoxFilterServicePriceStart";
            this.textBoxFilterServicePriceStart.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterServicePriceStart.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 0;
            // 
            // tabPageCars
            // 
            this.tabPageCars.BackColor = System.Drawing.Color.White;
            this.tabPageCars.Controls.Add(this.tableLayoutPanel1);
            this.tabPageCars.Location = new System.Drawing.Point(4, 29);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(1647, 957);
            this.tabPageCars.TabIndex = 3;
            this.tabPageCars.Text = "Автомобили в продаже";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.34308F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1641, 951);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.categoryDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.engineTypeDataGridViewTextBoxColumn,
            this.gearboxTypeDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.engineCapacityDataGridViewTextBoxColumn,
            this.enginePowerDataGridViewTextBoxColumn,
            this.releaseYearDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.carsView1BindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(703, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(935, 945);
            this.dataGridView3.TabIndex = 2;
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
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Завод-производитель";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineCapacityDataGridViewTextBoxColumn
            // 
            this.engineCapacityDataGridViewTextBoxColumn.DataPropertyName = "EngineCapacity";
            this.engineCapacityDataGridViewTextBoxColumn.HeaderText = "Объём двигателя";
            this.engineCapacityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.engineCapacityDataGridViewTextBoxColumn.Name = "engineCapacityDataGridViewTextBoxColumn";
            this.engineCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enginePowerDataGridViewTextBoxColumn
            // 
            this.enginePowerDataGridViewTextBoxColumn.DataPropertyName = "EnginePower";
            this.enginePowerDataGridViewTextBoxColumn.HeaderText = "Мощность двигателя";
            this.enginePowerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enginePowerDataGridViewTextBoxColumn.Name = "enginePowerDataGridViewTextBoxColumn";
            this.enginePowerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            this.releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
            this.releaseYearDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.releaseYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            this.releaseYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonClearFilters);
            this.groupBox1.Controls.Add(this.tableLayoutPanel9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 945);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(608, 25);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(63, 49);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearFilters.Location = new System.Drawing.Point(187, 835);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(320, 62);
            this.buttonClearFilters.TabIndex = 2;
            this.buttonClearFilters.Text = "Сбросить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.tableLayoutPanel9.Controls.Add(this.groupBox5, 0, 10);
            this.tableLayoutPanel9.Controls.Add(this.groupBox4, 0, 9);
            this.tableLayoutPanel9.Controls.Add(this.groupBox3, 0, 8);
            this.tableLayoutPanel9.Controls.Add(this.textBoxFilterVIN, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxFilterModel, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxFilterCarBodyType, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxFilterCategory, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxFilterColor, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxFilterEngineType, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxFilterGearboxType, 0, 6);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxFilterManufacturer, 0, 7);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterVIN, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterModel, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterCarBodyType, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterCategory, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterColor, 1, 4);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterEngineType, 1, 5);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterGearboxType, 1, 6);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterManufacturer, 1, 7);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterEngineCapacity, 1, 8);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterEnginePower, 1, 9);
            this.tableLayoutPanel9.Controls.Add(this.buttonEngineReleaseYear, 1, 10);
            this.tableLayoutPanel9.Controls.Add(this.buttonFilterPrice, 1, 11);
            this.tableLayoutPanel9.Controls.Add(this.groupBox2, 0, 11);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 93);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 12;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(668, 712);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxFilterReleaseYearEnd);
            this.groupBox5.Controls.Add(this.textBoxFilterReleaseYearStart);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 585);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 60);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // textBoxFilterReleaseYearEnd
            // 
            this.textBoxFilterReleaseYearEnd.Location = new System.Drawing.Point(198, 17);
            this.textBoxFilterReleaseYearEnd.Name = "textBoxFilterReleaseYearEnd";
            this.textBoxFilterReleaseYearEnd.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterReleaseYearEnd.TabIndex = 7;
            // 
            // textBoxFilterReleaseYearStart
            // 
            this.textBoxFilterReleaseYearStart.Location = new System.Drawing.Point(27, 17);
            this.textBoxFilterReleaseYearStart.Name = "textBoxFilterReleaseYearStart";
            this.textBoxFilterReleaseYearStart.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterReleaseYearStart.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxFilterEnginePowerEnd);
            this.groupBox4.Controls.Add(this.textBoxFilterEnginePowerStart);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 67);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            // 
            // textBoxFilterEnginePowerEnd
            // 
            this.textBoxFilterEnginePowerEnd.Location = new System.Drawing.Point(198, 20);
            this.textBoxFilterEnginePowerEnd.Name = "textBoxFilterEnginePowerEnd";
            this.textBoxFilterEnginePowerEnd.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterEnginePowerEnd.TabIndex = 7;
            // 
            // textBoxFilterEnginePowerStart
            // 
            this.textBoxFilterEnginePowerStart.Location = new System.Drawing.Point(27, 20);
            this.textBoxFilterEnginePowerStart.Name = "textBoxFilterEnginePowerStart";
            this.textBoxFilterEnginePowerStart.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterEnginePowerStart.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxFilterEngineCapacityEnd);
            this.groupBox3.Controls.Add(this.textBoxFilterEngineCapacityStart);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 63);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // textBoxFilterEngineCapacityEnd
            // 
            this.textBoxFilterEngineCapacityEnd.Location = new System.Drawing.Point(198, 25);
            this.textBoxFilterEngineCapacityEnd.Name = "textBoxFilterEngineCapacityEnd";
            this.textBoxFilterEngineCapacityEnd.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterEngineCapacityEnd.TabIndex = 5;
            // 
            // textBoxFilterEngineCapacityStart
            // 
            this.textBoxFilterEngineCapacityStart.Location = new System.Drawing.Point(27, 25);
            this.textBoxFilterEngineCapacityStart.Name = "textBoxFilterEngineCapacityStart";
            this.textBoxFilterEngineCapacityStart.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterEngineCapacityStart.TabIndex = 5;
            // 
            // textBoxFilterVIN
            // 
            this.textBoxFilterVIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilterVIN.Location = new System.Drawing.Point(3, 3);
            this.textBoxFilterVIN.Name = "textBoxFilterVIN";
            this.textBoxFilterVIN.Size = new System.Drawing.Size(336, 26);
            this.textBoxFilterVIN.TabIndex = 1;
            // 
            // comboBoxFilterModel
            // 
            this.comboBoxFilterModel.DataSource = this.modelsBindingSource;
            this.comboBoxFilterModel.DisplayMember = "Model";
            this.comboBoxFilterModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterModel.FormattingEnabled = true;
            this.comboBoxFilterModel.Location = new System.Drawing.Point(3, 58);
            this.comboBoxFilterModel.Name = "comboBoxFilterModel";
            this.comboBoxFilterModel.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterModel.TabIndex = 2;
            // 
            // comboBoxFilterCarBodyType
            // 
            this.comboBoxFilterCarBodyType.DataSource = this.carBodyTypesBindingSource;
            this.comboBoxFilterCarBodyType.DisplayMember = "CarBodyType";
            this.comboBoxFilterCarBodyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterCarBodyType.FormattingEnabled = true;
            this.comboBoxFilterCarBodyType.Location = new System.Drawing.Point(3, 113);
            this.comboBoxFilterCarBodyType.Name = "comboBoxFilterCarBodyType";
            this.comboBoxFilterCarBodyType.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterCarBodyType.TabIndex = 3;
            // 
            // comboBoxFilterCategory
            // 
            this.comboBoxFilterCategory.DataSource = this.categoriesBindingSource;
            this.comboBoxFilterCategory.DisplayMember = "Category";
            this.comboBoxFilterCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterCategory.FormattingEnabled = true;
            this.comboBoxFilterCategory.Location = new System.Drawing.Point(3, 168);
            this.comboBoxFilterCategory.Name = "comboBoxFilterCategory";
            this.comboBoxFilterCategory.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterCategory.TabIndex = 3;
            // 
            // comboBoxFilterColor
            // 
            this.comboBoxFilterColor.DataSource = this.colorsBindingSource;
            this.comboBoxFilterColor.DisplayMember = "Color";
            this.comboBoxFilterColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterColor.FormattingEnabled = true;
            this.comboBoxFilterColor.Location = new System.Drawing.Point(3, 223);
            this.comboBoxFilterColor.Name = "comboBoxFilterColor";
            this.comboBoxFilterColor.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterColor.TabIndex = 3;
            // 
            // comboBoxFilterEngineType
            // 
            this.comboBoxFilterEngineType.DataSource = this.engineTypesBindingSource;
            this.comboBoxFilterEngineType.DisplayMember = "EngineType";
            this.comboBoxFilterEngineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterEngineType.FormattingEnabled = true;
            this.comboBoxFilterEngineType.Location = new System.Drawing.Point(3, 278);
            this.comboBoxFilterEngineType.Name = "comboBoxFilterEngineType";
            this.comboBoxFilterEngineType.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterEngineType.TabIndex = 3;
            // 
            // comboBoxFilterGearboxType
            // 
            this.comboBoxFilterGearboxType.DataSource = this.gearboxTypesBindingSource;
            this.comboBoxFilterGearboxType.DisplayMember = "GearboxType";
            this.comboBoxFilterGearboxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterGearboxType.FormattingEnabled = true;
            this.comboBoxFilterGearboxType.Location = new System.Drawing.Point(3, 333);
            this.comboBoxFilterGearboxType.Name = "comboBoxFilterGearboxType";
            this.comboBoxFilterGearboxType.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterGearboxType.TabIndex = 3;
            // 
            // comboBoxFilterManufacturer
            // 
            this.comboBoxFilterManufacturer.DataSource = this.manufacturersBindingSource;
            this.comboBoxFilterManufacturer.DisplayMember = "Manufacturer";
            this.comboBoxFilterManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFilterManufacturer.FormattingEnabled = true;
            this.comboBoxFilterManufacturer.Location = new System.Drawing.Point(3, 388);
            this.comboBoxFilterManufacturer.Name = "comboBoxFilterManufacturer";
            this.comboBoxFilterManufacturer.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFilterManufacturer.TabIndex = 3;
            // 
            // buttonFilterVIN
            // 
            this.buttonFilterVIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterVIN.Location = new System.Drawing.Point(345, 3);
            this.buttonFilterVIN.Name = "buttonFilterVIN";
            this.buttonFilterVIN.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterVIN.TabIndex = 5;
            this.buttonFilterVIN.Text = "Поиск по VIN";
            this.buttonFilterVIN.UseVisualStyleBackColor = true;
            this.buttonFilterVIN.Click += new System.EventHandler(this.buttonFilterVIN_Click);
            // 
            // buttonFilterModel
            // 
            this.buttonFilterModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterModel.Location = new System.Drawing.Point(345, 58);
            this.buttonFilterModel.Name = "buttonFilterModel";
            this.buttonFilterModel.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterModel.TabIndex = 5;
            this.buttonFilterModel.Text = "Поиск по модели";
            this.buttonFilterModel.UseVisualStyleBackColor = true;
            this.buttonFilterModel.Click += new System.EventHandler(this.buttonFilterModel_Click);
            // 
            // buttonFilterCarBodyType
            // 
            this.buttonFilterCarBodyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterCarBodyType.Location = new System.Drawing.Point(345, 113);
            this.buttonFilterCarBodyType.Name = "buttonFilterCarBodyType";
            this.buttonFilterCarBodyType.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterCarBodyType.TabIndex = 5;
            this.buttonFilterCarBodyType.Text = "Поиск по типу кузова";
            this.buttonFilterCarBodyType.UseVisualStyleBackColor = true;
            this.buttonFilterCarBodyType.Click += new System.EventHandler(this.buttonFilterCarBodyType_Click);
            // 
            // buttonFilterCategory
            // 
            this.buttonFilterCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterCategory.Location = new System.Drawing.Point(345, 168);
            this.buttonFilterCategory.Name = "buttonFilterCategory";
            this.buttonFilterCategory.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterCategory.TabIndex = 5;
            this.buttonFilterCategory.Text = "Фильтр по категории";
            this.buttonFilterCategory.UseVisualStyleBackColor = true;
            this.buttonFilterCategory.Click += new System.EventHandler(this.buttonFilterCategory_Click);
            // 
            // buttonFilterColor
            // 
            this.buttonFilterColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterColor.Location = new System.Drawing.Point(345, 223);
            this.buttonFilterColor.Name = "buttonFilterColor";
            this.buttonFilterColor.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterColor.TabIndex = 5;
            this.buttonFilterColor.Text = "Фильтр по цвету";
            this.buttonFilterColor.UseVisualStyleBackColor = true;
            this.buttonFilterColor.Click += new System.EventHandler(this.buttonFilterColor_Click);
            // 
            // buttonFilterEngineType
            // 
            this.buttonFilterEngineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterEngineType.Location = new System.Drawing.Point(345, 278);
            this.buttonFilterEngineType.Name = "buttonFilterEngineType";
            this.buttonFilterEngineType.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterEngineType.TabIndex = 5;
            this.buttonFilterEngineType.Text = "Фильтр по типу двигателя";
            this.buttonFilterEngineType.UseVisualStyleBackColor = true;
            this.buttonFilterEngineType.Click += new System.EventHandler(this.buttonFilterEngineType_Click);
            // 
            // buttonFilterGearboxType
            // 
            this.buttonFilterGearboxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterGearboxType.Location = new System.Drawing.Point(345, 333);
            this.buttonFilterGearboxType.Name = "buttonFilterGearboxType";
            this.buttonFilterGearboxType.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterGearboxType.TabIndex = 5;
            this.buttonFilterGearboxType.Text = "Фильтр по типу коробки";
            this.buttonFilterGearboxType.UseVisualStyleBackColor = true;
            this.buttonFilterGearboxType.Click += new System.EventHandler(this.buttonFilterGearboxType_Click);
            // 
            // buttonFilterManufacturer
            // 
            this.buttonFilterManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterManufacturer.Location = new System.Drawing.Point(345, 388);
            this.buttonFilterManufacturer.Name = "buttonFilterManufacturer";
            this.buttonFilterManufacturer.Size = new System.Drawing.Size(320, 49);
            this.buttonFilterManufacturer.TabIndex = 5;
            this.buttonFilterManufacturer.Text = "Фильтр по производителю";
            this.buttonFilterManufacturer.UseVisualStyleBackColor = true;
            this.buttonFilterManufacturer.Click += new System.EventHandler(this.buttonFilterManufacturer_Click);
            // 
            // buttonFilterEngineCapacity
            // 
            this.buttonFilterEngineCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterEngineCapacity.Location = new System.Drawing.Point(345, 443);
            this.buttonFilterEngineCapacity.Name = "buttonFilterEngineCapacity";
            this.buttonFilterEngineCapacity.Size = new System.Drawing.Size(320, 63);
            this.buttonFilterEngineCapacity.TabIndex = 5;
            this.buttonFilterEngineCapacity.Text = "Фильтр по объёму двигателя";
            this.buttonFilterEngineCapacity.UseVisualStyleBackColor = true;
            this.buttonFilterEngineCapacity.Click += new System.EventHandler(this.buttonFilterEngineCapacity_Click);
            // 
            // buttonFilterEnginePower
            // 
            this.buttonFilterEnginePower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterEnginePower.Location = new System.Drawing.Point(345, 512);
            this.buttonFilterEnginePower.Name = "buttonFilterEnginePower";
            this.buttonFilterEnginePower.Size = new System.Drawing.Size(320, 67);
            this.buttonFilterEnginePower.TabIndex = 5;
            this.buttonFilterEnginePower.Text = "Фильтр по мощности";
            this.buttonFilterEnginePower.UseVisualStyleBackColor = true;
            this.buttonFilterEnginePower.Click += new System.EventHandler(this.buttonFilterEnginePower_Click);
            // 
            // buttonEngineReleaseYear
            // 
            this.buttonEngineReleaseYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEngineReleaseYear.Location = new System.Drawing.Point(345, 585);
            this.buttonEngineReleaseYear.Name = "buttonEngineReleaseYear";
            this.buttonEngineReleaseYear.Size = new System.Drawing.Size(320, 60);
            this.buttonEngineReleaseYear.TabIndex = 5;
            this.buttonEngineReleaseYear.Text = "Фильтр по году выпуска";
            this.buttonEngineReleaseYear.UseVisualStyleBackColor = true;
            this.buttonEngineReleaseYear.Click += new System.EventHandler(this.buttonEngineReleaseYear_Click);
            // 
            // buttonFilterPrice
            // 
            this.buttonFilterPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFilterPrice.Location = new System.Drawing.Point(345, 651);
            this.buttonFilterPrice.Name = "buttonFilterPrice";
            this.buttonFilterPrice.Size = new System.Drawing.Size(320, 58);
            this.buttonFilterPrice.TabIndex = 5;
            this.buttonFilterPrice.Text = "Фильтр по цене";
            this.buttonFilterPrice.UseVisualStyleBackColor = true;
            this.buttonFilterPrice.Click += new System.EventHandler(this.buttonFilterPrice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxFilterPriceEnd);
            this.groupBox2.Controls.Add(this.textBoxFilterPriceStart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 651);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            // 
            // textBoxFilterPriceEnd
            // 
            this.textBoxFilterPriceEnd.Location = new System.Drawing.Point(198, 16);
            this.textBoxFilterPriceEnd.Name = "textBoxFilterPriceEnd";
            this.textBoxFilterPriceEnd.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterPriceEnd.TabIndex = 7;
            // 
            // textBoxFilterPriceStart
            // 
            this.textBoxFilterPriceStart.Location = new System.Drawing.Point(27, 16);
            this.textBoxFilterPriceStart.Name = "textBoxFilterPriceStart";
            this.textBoxFilterPriceStart.Size = new System.Drawing.Size(112, 26);
            this.textBoxFilterPriceStart.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.Controls.Add(this.groupBox6);
            this.tabPageMain.Location = new System.Drawing.Point(4, 29);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1647, 957);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главная";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2Update);
            this.groupBox6.Controls.Add(this.button1UpdateSales);
            this.groupBox6.Controls.Add(this.dataGridView4);
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Controls.Add(this.buttonClients);
            this.groupBox6.Controls.Add(this.buttonService);
            this.groupBox6.Controls.Add(this.buttonCreateCarSale);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1641, 951);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Мои продажи";
            // 
            // button2Update
            // 
            this.button2Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2Update.FlatAppearance.BorderSize = 0;
            this.button2Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Update.Image = ((System.Drawing.Image)(resources.GetObject("button2Update.Image")));
            this.button2Update.Location = new System.Drawing.Point(861, 561);
            this.button2Update.Name = "button2Update";
            this.button2Update.Size = new System.Drawing.Size(63, 49);
            this.button2Update.TabIndex = 4;
            this.button2Update.UseVisualStyleBackColor = true;
            this.button2Update.Click += new System.EventHandler(this.button2Update_Click);
            // 
            // button1UpdateSales
            // 
            this.button1UpdateSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1UpdateSales.FlatAppearance.BorderSize = 0;
            this.button1UpdateSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1UpdateSales.Image = ((System.Drawing.Image)(resources.GetObject("button1UpdateSales.Image")));
            this.button1UpdateSales.Location = new System.Drawing.Point(861, 65);
            this.button1UpdateSales.Name = "button1UpdateSales";
            this.button1UpdateSales.Size = new System.Drawing.Size(63, 49);
            this.button1UpdateSales.TabIndex = 4;
            this.button1UpdateSales.UseVisualStyleBackColor = true;
            this.button1UpdateSales.Click += new System.EventHandler(this.button1UpdateSales_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceContractNumberDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.conclusionDataGridViewTextBoxColumn,
            this.conractNumberDataGridViewTextBoxColumn1,
            this.clientNameDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.serviceContractsViewBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(59, 552);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(796, 352);
            this.dataGridView4.TabIndex = 1;
            // 
            // serviceContractNumberDataGridViewTextBoxColumn
            // 
            this.serviceContractNumberDataGridViewTextBoxColumn.DataPropertyName = "ServiceContractNumber";
            this.serviceContractNumberDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.serviceContractNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serviceContractNumberDataGridViewTextBoxColumn.Name = "serviceContractNumberDataGridViewTextBoxColumn";
            this.serviceContractNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conclusionDataGridViewTextBoxColumn
            // 
            this.conclusionDataGridViewTextBoxColumn.DataPropertyName = "Conclusion";
            this.conclusionDataGridViewTextBoxColumn.HeaderText = "Дата заключения договора";
            this.conclusionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.conclusionDataGridViewTextBoxColumn.Name = "conclusionDataGridViewTextBoxColumn";
            this.conclusionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conractNumberDataGridViewTextBoxColumn1
            // 
            this.conractNumberDataGridViewTextBoxColumn1.DataPropertyName = "ConractNumber";
            this.conractNumberDataGridViewTextBoxColumn1.HeaderText = "Номер договора клиента";
            this.conractNumberDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.conractNumberDataGridViewTextBoxColumn1.Name = "conractNumberDataGridViewTextBoxColumn1";
            this.conractNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "ФИО клиента";
            this.clientNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            this.clientNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Товар/услуга";
            this.typeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn3
            // 
            this.priceDataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn3.Name = "priceDataGridViewTextBoxColumn3";
            this.priceDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // serviceContractsViewBindingSource
            // 
            this.serviceContractsViewBindingSource.DataMember = "ServiceContractsView";
            this.serviceContractsViewBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleContractNumberDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.conclusionDateDataGridViewTextBoxColumn,
            this.conractNumberDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.saleContractsViewBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(59, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(796, 352);
            this.dataGridView2.TabIndex = 1;
            // 
            // saleContractNumberDataGridViewTextBoxColumn
            // 
            this.saleContractNumberDataGridViewTextBoxColumn.DataPropertyName = "SaleContractNumber";
            this.saleContractNumberDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.saleContractNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saleContractNumberDataGridViewTextBoxColumn.Name = "saleContractNumberDataGridViewTextBoxColumn";
            this.saleContractNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            this.carDataGridViewTextBoxColumn.HeaderText = "VIN авто";
            this.carDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            this.carDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conclusionDateDataGridViewTextBoxColumn
            // 
            this.conclusionDateDataGridViewTextBoxColumn.DataPropertyName = "ConclusionDate";
            this.conclusionDateDataGridViewTextBoxColumn.HeaderText = "Дата заключения договора";
            this.conclusionDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.conclusionDateDataGridViewTextBoxColumn.Name = "conclusionDateDataGridViewTextBoxColumn";
            this.conclusionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conractNumberDataGridViewTextBoxColumn
            // 
            this.conractNumberDataGridViewTextBoxColumn.DataPropertyName = "ConractNumber";
            this.conractNumberDataGridViewTextBoxColumn.HeaderText = "Номер договора клиента";
            this.conractNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.conractNumberDataGridViewTextBoxColumn.Name = "conractNumberDataGridViewTextBoxColumn";
            this.conractNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn2.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // saleContractsViewBindingSource
            // 
            this.saleContractsViewBindingSource.DataMember = "SaleContractsView";
            this.saleContractsViewBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(968, 552);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(439, 84);
            this.buttonClients.TabIndex = 0;
            this.buttonClients.Text = "Создать запись о новом клиенте";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonService
            // 
            this.buttonService.Location = new System.Drawing.Point(968, 452);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(439, 84);
            this.buttonService.TabIndex = 0;
            this.buttonService.Text = "Создать договор об оказании услуги/продаже товара";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonCreateCarSale
            // 
            this.buttonCreateCarSale.Location = new System.Drawing.Point(968, 353);
            this.buttonCreateCarSale.Name = "buttonCreateCarSale";
            this.buttonCreateCarSale.Size = new System.Drawing.Size(439, 84);
            this.buttonCreateCarSale.TabIndex = 0;
            this.buttonCreateCarSale.Text = "Создать договор о продаже автомобиля";
            this.buttonCreateCarSale.UseVisualStyleBackColor = true;
            this.buttonCreateCarSale.Click += new System.EventHandler(this.buttonCreateCarSale_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageCars);
            this.tabControl1.Controls.Add(this.tabPageServicesAndGoods);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1655, 990);
            this.tabControl1.TabIndex = 0;
            // 
            // saleContractsViewTableAdapter
            // 
            this.saleContractsViewTableAdapter.ClearBeforeFill = true;
            // 
            // serviceContractsViewTableAdapter
            // 
            this.serviceContractsViewTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 1023);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            //
            //this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосалон (Менеджер)";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsView1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBodyTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndGoodsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewBindingSource)).EndInit();
            this.tabPageServicesAndGoods.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPageCars.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageMain.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceContractsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleContractsViewBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private CarDealershipDataSet carDealershipDataSet;
        private System.Windows.Forms.BindingSource carsView1BindingSource;
        private CarDealershipDataSetTableAdapters.CarsView1TableAdapter carsView1TableAdapter;
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource servicesAndGoodsBindingSource;
        private CarDealershipDataSetTableAdapters.ServicesAndGoodsTableAdapter servicesAndGoodsTableAdapter;
        private System.Windows.Forms.BindingSource clientsViewBindingSource;
        private CarDealershipDataSetTableAdapters.ClientsViewTableAdapter clientsViewTableAdapter;
        private System.Windows.Forms.TabPage tabPageServicesAndGoods;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonClearFiltersService;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.Button buttonFilterName;
        private System.Windows.Forms.Button buttonFilterServiceType;
        private System.Windows.Forms.Button buttonFilterPriceService;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFilterServicePriceEnd;
        private System.Windows.Forms.TextBox textBoxFilterServicePriceStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageCars;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBodyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearboxTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilterReleaseYearEnd;
        private System.Windows.Forms.TextBox textBoxFilterReleaseYearStart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilterEnginePowerEnd;
        private System.Windows.Forms.TextBox textBoxFilterEnginePowerStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilterEngineCapacityEnd;
        private System.Windows.Forms.TextBox textBoxFilterEngineCapacityStart;
        private System.Windows.Forms.TextBox textBoxFilterVIN;
        private System.Windows.Forms.ComboBox comboBoxFilterModel;
        private System.Windows.Forms.ComboBox comboBoxFilterCarBodyType;
        private System.Windows.Forms.ComboBox comboBoxFilterCategory;
        private System.Windows.Forms.ComboBox comboBoxFilterColor;
        private System.Windows.Forms.ComboBox comboBoxFilterEngineType;
        private System.Windows.Forms.ComboBox comboBoxFilterGearboxType;
        private System.Windows.Forms.ComboBox comboBoxFilterManufacturer;
        private System.Windows.Forms.Button buttonFilterVIN;
        private System.Windows.Forms.Button buttonFilterModel;
        private System.Windows.Forms.Button buttonFilterCarBodyType;
        private System.Windows.Forms.Button buttonFilterCategory;
        private System.Windows.Forms.Button buttonFilterColor;
        private System.Windows.Forms.Button buttonFilterEngineType;
        private System.Windows.Forms.Button buttonFilterGearboxType;
        private System.Windows.Forms.Button buttonFilterManufacturer;
        private System.Windows.Forms.Button buttonFilterEngineCapacity;
        private System.Windows.Forms.Button buttonFilterEnginePower;
        private System.Windows.Forms.Button buttonEngineReleaseYear;
        private System.Windows.Forms.Button buttonFilterPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilterPriceEnd;
        private System.Windows.Forms.TextBox textBoxFilterPriceStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonCreateCarSale;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource saleContractsViewBindingSource;
        private CarDealershipDataSetTableAdapters.SaleContractsViewTableAdapter saleContractsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleContractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1UpdateSales;
        private System.Windows.Forms.Button button2Update;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource serviceContractsViewBindingSource;
        private CarDealershipDataSetTableAdapters.ServiceContractsViewTableAdapter serviceContractsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceContractNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conractNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
    }
}

