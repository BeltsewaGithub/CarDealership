namespace CarDealershipApp
{
    partial class AddServiceContractFormManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.clientsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDataSet = new CarDealershipApp.CarDealershipDataSet();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.servicesAndGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealershipDataSet1 = new CarDealershipApp.CarDealershipDataSet();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.addContract = new System.Data.SqlClient.SqlCommand();
            this.clientsViewTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ClientsViewTableAdapter();
            this.servicesAndGoodsTableAdapter = new CarDealershipApp.CarDealershipDataSetTableAdapters.ServicesAndGoodsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndGoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.09251F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.90749F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.Location = new System.Drawing.Point(93, 330);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(294, 47);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Создать договор";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxClientName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 302);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товар/услуга";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата заключения договора";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Клиент";
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.DataSource = this.clientsViewBindingSource;
            this.comboBoxClientName.DisplayMember = "FullName";
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(245, 93);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(208, 28);
            this.comboBoxClientName.TabIndex = 2;
            // 
            // clientsViewBindingSource
            // 
            this.clientsViewBindingSource.DataMember = "ClientsView";
            this.clientsViewBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // carDealershipDataSet
            // 
            this.carDealershipDataSet.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(245, 48);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(208, 26);
            this.dateTimePicker.TabIndex = 3;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DataSource = this.servicesAndGoodsBindingSource;
            this.comboBoxName.DisplayMember = "Name";
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(245, 3);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(208, 28);
            this.comboBoxName.TabIndex = 4;
            // 
            // servicesAndGoodsBindingSource
            // 
            this.servicesAndGoodsBindingSource.DataMember = "ServicesAndGoods";
            this.servicesAndGoodsBindingSource.DataSource = this.carDealershipDataSet1;
            // 
            // carDealershipDataSet1
            // 
            this.carDealershipDataSet1.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-B0T6AUV\\MSSQLSERVER11;Initial Catalog=CarDealership;Persist S" +
    "ecurity Info=True;User ID=sa;Password=7359";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // addContract
            // 
            this.addContract.CommandText = "addServiceContract";
            this.addContract.CommandType = System.Data.CommandType.StoredProcedure;
            this.addContract.Connection = this.sqlConnection1;
            this.addContract.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@employee", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@client", System.Data.SqlDbType.NVarChar),
            new System.Data.SqlClient.SqlParameter("@service", System.Data.SqlDbType.NVarChar),
            new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.DateTime)});
            // 
            // clientsViewTableAdapter
            // 
            this.clientsViewTableAdapter.ClearBeforeFill = true;
            // 
            // servicesAndGoodsTableAdapter
            // 
            this.servicesAndGoodsTableAdapter.ClearBeforeFill = true;
            // 
            // AddServiceContractFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddServiceContractFormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание договора об оказании услуги/продаже товара";
            this.Load += new System.EventHandler(this.AddServiceContractFormManager_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesAndGoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand addContract;
        private CarDealershipDataSet carDealershipDataSet;
        private System.Windows.Forms.BindingSource clientsViewBindingSource;
        private CarDealershipDataSetTableAdapters.ClientsViewTableAdapter clientsViewTableAdapter;
        private CarDealershipDataSet carDealershipDataSet1;
        private System.Windows.Forms.BindingSource servicesAndGoodsBindingSource;
        private CarDealershipDataSetTableAdapters.ServicesAndGoodsTableAdapter servicesAndGoodsTableAdapter;
    }
}