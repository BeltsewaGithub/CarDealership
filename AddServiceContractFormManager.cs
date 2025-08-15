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
    public partial class AddServiceContractFormManager : Form
    {
        public AddServiceContractFormManager()
        {
            InitializeComponent();
        }

        private void AddServiceContractFormManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet1.ServicesAndGoods". При необходимости она может быть перемещена или удалена.
            this.servicesAndGoodsTableAdapter.Fill(this.carDealershipDataSet1.ServicesAndGoods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ClientsView". При необходимости она может быть перемещена или удалена.
            this.clientsViewTableAdapter.Fill(this.carDealershipDataSet.ClientsView);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                addContract.Parameters["@employee"].Value =
                    Checking.CurrentEmployee;
                addContract.Parameters["@client"].Value =
                    comboBoxClientName.Text;
                addContract.Parameters["@service"].Value =
                    comboBoxName.Text;
                addContract.Parameters["@date"].Value =
                    dateTimePicker.Text;
                sqlConnection1.Open();
                addContract.ExecuteNonQuery();
                MessageBox.Show("Договор создан");
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}