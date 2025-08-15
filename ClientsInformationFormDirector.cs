using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class ClientsInformationFormDirector : Form
    {
        public ClientsInformationFormDirector()
        {
            InitializeComponent();
        }

        private void ClientsInformationFormDirector_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.ClientsView". При необходимости она может быть перемещена или удалена.
            this.clientsViewTableAdapter.Fill(this.carDealershipDataSet.ClientsView);

        }

        private void buttonInsertClient_Click(object sender, EventArgs e)
        {
            insertClient.Parameters["@passport"].Value =
               Convert.ToInt64(textBoxInsertClientPassport.Text);
            insertClient.Parameters["@firstName"].Value =
                textBoxInsertClientFirstName.Text;
            insertClient.Parameters["@surname"].Value =
                textBoxInsertClientSurname.Text;
            insertClient.Parameters["@father"].Value =
                textBoxInsertClientFather.Text;
            insertClient.Parameters["@birthday"].Value =
                dateTimePickerInsertClientBirthday.Text;
            insertClient.Parameters["@conclusionDate"].Value =
                dateTimePickerInsertClientConclusionDate.Text;
            sqlConnection1.Open();
            try
            {
                if (textBoxInsertClientPassport.Text == "" || textBoxInsertClientFirstName.Text == "" ||
                    textBoxInsertClientSurname.Text == "" || textBoxInsertClientFather.Text == "")
                    throw new Exception("Поля не могут быть пустыми!");
                if (DateTime.Compare(Convert.ToDateTime(dateTimePickerInsertClientBirthday.Text).AddYears(18), DateTime.Now) > 0)
                    throw new Exception("Сотруднику должно быть больше 18-ти лет!");
                insertClient.ExecuteNonQuery();
                MessageBox.Show(Convert.ToString(insertClient.Parameters["@message"].Value));
                this.clientsViewTableAdapter.Fill(this.carDealershipDataSet.ClientsView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection1.Close();
        }

        private void textBoxInsertClientPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checking.IntNumbersCheck(e);
        }
    }
}
