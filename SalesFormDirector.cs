using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class SalesFormDirector : Form
    {
        public SalesFormDirector()
        {
            InitializeComponent();
        }

        private void SalesFormDirector_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ClientsView". При необходимости она может быть перемещена или удалена.
            this.clientsViewTableAdapter.Fill(this.carDealershipDataSet.ClientsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.EmployeesView". При необходимости она может быть перемещена или удалена.
            this.employeesViewTableAdapter.Fill(this.carDealershipDataSet.EmployeesView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ServicesAndGoods". При необходимости она может быть перемещена или удалена.
            this.servicesAndGoodsTableAdapter.Fill(this.carDealershipDataSet.ServicesAndGoods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet1.ServiceContractsView". При необходимости она может быть перемещена или удалена.
            this.serviceContractsViewTableAdapter.Fill(this.carDealershipDataSet1.ServiceContractsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.SaleContractsView". При необходимости она может быть перемещена или удалена.
            this.saleContractsViewTableAdapter.Fill(this.carDealershipDataSet.SaleContractsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.SaleContractsView". При необходимости она может быть перемещена или удалена.
            this.saleContractsViewTableAdapter.Fill(this.carDealershipDataSet.SaleContractsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.SaleContractsView". При необходимости она может быть перемещена или удалена.
            this.saleContractsViewTableAdapter.Fill(this.carDealershipDataSet.SaleContractsView);

        }

        private void buttonFilterServiceName_Click(object sender, EventArgs e)
        {
            serviceContractsViewBindingSource.Filter = "Service = '" + comboBox1.Text + "'";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saleContractsViewBindingSource1.Filter = "ClientName = '" + comboBox7.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saleContractsViewBindingSource1.Filter = "EmployeeName = '" + comboBox6.Text + "'";
        }

        private void buttonFilterClientName_Click(object sender, EventArgs e)
        {
            serviceContractsViewBindingSource.Filter = "ClientName = '" + comboBox2.Text + "'";
        }

        private void buttonFilterEmploteeName_Click(object sender, EventArgs e)
        {
            serviceContractsViewBindingSource.Filter = "EmployeeName = '" + comboBox3.Text + "'";
        }

        private void buttonFilterServiceType_Click(object sender, EventArgs e)
        {
            saleContractsViewBindingSource1.Filter = "Type = '" + comboBox4.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serviceContractsViewBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saleContractsViewBindingSource1.Filter = "";
        }
    }
}
