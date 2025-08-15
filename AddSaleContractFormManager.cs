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
    public partial class AddSaleContractFormManager : Form
    {
        public AddSaleContractFormManager()
        {
            InitializeComponent();
        }

        private void AddSaleContractFormManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.CarsView1". При необходимости она может быть перемещена или удалена.
            this.carsView1TableAdapter.Fill(this.carDealershipDataSet.CarsView1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ClientsView". При необходимости она может быть перемещена или удалена.
            this.clientsViewTableAdapter.Fill(this.carDealershipDataSet.ClientsView);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AddContract.Parameters["@employee"].Value =
                    Checking.CurrentEmployee;
                AddContract.Parameters["@client"].Value =
                    comboBoxClientName.Text;
                AddContract.Parameters["@car"].Value =
                    comboBoxName.Text;
                AddContract.Parameters["@date"].Value =
                    dateTimePicker.Text;
                sqlConnection1.Open();
                AddContract.ExecuteNonQuery();
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
