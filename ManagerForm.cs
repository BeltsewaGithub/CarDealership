using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void Form2ReferenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorForm form = new DirectorForm();
            form.Show();
        }

        private void buttonFilterVIN_Click(object sender, EventArgs e)
        {
            carsView1BindingSource.Filter = "VIN = '" + textBoxFilterVIN.Text + "'";
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ServiceContractsView". При необходимости она может быть перемещена или удалена.
            this.serviceContractsViewTableAdapter.Fill(this.carDealershipDataSet.ServiceContractsView);
            serviceContractsViewBindingSource.Filter = "EmploymentContractNumber = " + Checking.CurrentEmployee;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.SaleContractsView". При необходимости она может быть перемещена или удалена.
            this.saleContractsViewTableAdapter.Fill(this.carDealershipDataSet.SaleContractsView);
            saleContractsViewBindingSource.Filter = "EmploymentContractNumber = " + Checking.CurrentEmployee;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ClientsView". При необходимости она может быть перемещена или удалена.
            this.clientsViewTableAdapter.Fill(this.carDealershipDataSet.ClientsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ServicesAndGoods". При необходимости она может быть перемещена или удалена.
            this.servicesAndGoodsTableAdapter.Fill(this.carDealershipDataSet.ServicesAndGoods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.Manufacturers". При необходимости она может быть перемещена или удалена.
            this.manufacturersTableAdapter.Fill(this.carDealershipDataSet.Manufacturers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.GearboxTypes". При необходимости она может быть перемещена или удалена.
            this.gearboxTypesTableAdapter.Fill(this.carDealershipDataSet.GearboxTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.EngineTypes". При необходимости она может быть перемещена или удалена.
            this.engineTypesTableAdapter.Fill(this.carDealershipDataSet.EngineTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.Colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.carDealershipDataSet.Colors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.carDealershipDataSet.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.CarBodyTypes". При необходимости она может быть перемещена или удалена.
            this.carBodyTypesTableAdapter.Fill(this.carDealershipDataSet.CarBodyTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.Models". При необходимости она может быть перемещена или удалена.
            this.modelsTableAdapter.Fill(this.carDealershipDataSet.Models);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.GearboxTypes". При необходимости она может быть перемещена или удалена.
            this.gearboxTypesTableAdapter.Fill(this.carDealershipDataSet.GearboxTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.CarsView1". При необходимости она может быть перемещена или удалена.
            this.carsView1TableAdapter.Fill(this.carDealershipDataSet.CarsView1);

        }

        private void buttonFilterCarBodyType_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "CarBodyType = '" + comboBoxFilterCarBodyType.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterCategory_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "Category = '" + comboBoxFilterCategory.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterColor_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "Color = '" + comboBoxFilterColor.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterEngineType_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "EngineType = '" + comboBoxFilterEngineType.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterGearboxType_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "GearboxType = '" + comboBoxFilterGearboxType.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterManufacturer_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "Manufacturer = '" + comboBoxFilterManufacturer.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterEngineCapacity_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "EngineCapacity > " + textBoxFilterEngineCapacityStart.Text + "AND EngineCapacity < " + textBoxFilterEngineCapacityEnd.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterEnginePower_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "EnginePower > " + textBoxFilterEnginePowerStart.Text + "AND EnginePower < " + textBoxFilterEnginePowerEnd.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEngineReleaseYear_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "ReleaseYear > " + textBoxFilterReleaseYearStart.Text + "AND ReleaseYear < " + textBoxFilterReleaseYearEnd.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterModel_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "Model = '" + comboBoxFilterModel.Text + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterPrice_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "Price > " + textBoxFilterPriceStart.Text + "AND Price < " + textBoxFilterPriceEnd.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            carsView1BindingSource.Filter = "";
        }

        private void buttonFilterName_Click(object sender, EventArgs e)
        {
            servicesAndGoodsBindingSource.Filter = "Name = '" + textBoxFilterName.Text + "'";
        }

        private void buttonFilterServiceType_Click(object sender, EventArgs e)
        {
            servicesAndGoodsBindingSource.Filter = "Type = '" + comboBoxFilterType.Text + "'";
        }

        private void buttonFilterPriceService_Click(object sender, EventArgs e)
        {
            try
            {
                carsView1BindingSource.Filter = "Price > " + textBoxFilterServicePriceStart.Text + "AND Price < " + textBoxFilterServicePriceEnd.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCreateCarSale_Click(object sender, EventArgs e)
        {
            AddSaleContractFormManager form = new AddSaleContractFormManager();
            form.Show();
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            AddServiceContractFormManager form = new AddServiceContractFormManager();
            form.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ClientsInformationFormDirector form = new ClientsInformationFormDirector();
            form.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.carsView1TableAdapter.Fill(this.carDealershipDataSet.CarsView1);
        }

        private void button1UpdateSales_Click(object sender, EventArgs e)
        {
            this.saleContractsViewTableAdapter.Fill(this.carDealershipDataSet.SaleContractsView);
            saleContractsViewBindingSource.Filter = "EmploymentContractNumber = " + Checking.CurrentEmployee;
        }

        private void button2Update_Click(object sender, EventArgs e)
        {
            this.serviceContractsViewTableAdapter.Fill(this.carDealershipDataSet.ServiceContractsView);
            serviceContractsViewBindingSource.Filter = "EmploymentContractNumber = " + Checking.CurrentEmployee;
        }
    }
}
