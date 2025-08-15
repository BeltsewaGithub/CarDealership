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
    public partial class EmployeesInformationFormDirector : Form
    {
        public EmployeesInformationFormDirector()
        {
            InitializeComponent();
        }

        private void EmployeesInformationFormDirector_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.carDealershipDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet.EmployeesView". При необходимости она может быть перемещена или удалена.
            this.employeesViewTableAdapter.Fill(this.carDealershipDataSet.EmployeesView);

        }

        private void buttonInsertEmployee_Click(object sender, EventArgs e)
        {
            insertEmployee.Parameters["@passport"].Value =
                Convert.ToInt32(textBoxInsertEmployeePassport.Text);
            insertEmployee.Parameters["@firstName"].Value =
                textBoxInsertEmployeeFirstName.Text;
            insertEmployee.Parameters["@surname"].Value =
                textBoxInsertEmployeeSurname.Text;
            insertEmployee.Parameters["@father"].Value =
                textBoxInsertEmployeeFather.Text;
            insertEmployee.Parameters["@birthday"].Value =
                dateTimePickerInsertEmployeeBirthday.Text;
            insertEmployee.Parameters["@conclusionDate"].Value =
                dateTimePickerInsertEmployeeConclusionDate.Text;
            insertEmployee.Parameters["@position"].Value =
                comboBoxInsertEmployeePosition.Text;
            insertEmployee.Parameters["@workShedule"].Value =
                textBoxInsertEmployeeWorkShedule.Text;
            sqlConnection1.Open();
            try
            {
                if (textBoxInsertEmployeePassport.Text == "" || textBoxInsertEmployeeFirstName.Text == "" ||
                    textBoxInsertEmployeeSurname.Text == "" || textBoxInsertEmployeeFather.Text == "" ||
                    comboBoxInsertEmployeePosition.Text == "" || textBoxInsertEmployeeWorkShedule.Text == "")
                    throw new Exception("Поля не могут быть пустыми!");
                if (DateTime.Compare(Convert.ToDateTime(dateTimePickerInsertEmployeeBirthday.Text).AddYears(18), DateTime.Now) > 0)
                    throw new Exception("Сотруднику должно быть больше 18-ти лет!");
                insertEmployee.ExecuteNonQuery();
                MessageBox.Show(Convert.ToString(insertEmployee.Parameters["@message"].Value));
                this.employeesViewTableAdapter.Fill(this.carDealershipDataSet.EmployeesView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection1.Close();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.positionsBindingSource.EndEdit();
                this.positionsTableAdapter.Update(this.carDealershipDataSet.Positions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
