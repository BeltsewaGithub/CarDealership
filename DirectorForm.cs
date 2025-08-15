using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }


        private void DirectorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.CarsView1". При необходимости она может быть перемещена или удалена.
            this.carsView1TableAdapter.Fill(this.carDealershipDataSet2.CarsView1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.ServicesAndGoods". При необходимости она может быть перемещена или удалена.
            this.servicesAndGoodsTableAdapter.Fill(this.carDealershipDataSet2.ServicesAndGoods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.Manufacturers". При необходимости она может быть перемещена или удалена.
            this.manufacturersTableAdapter.Fill(this.carDealershipDataSet2.Manufacturers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.GearboxTypes". При необходимости она может быть перемещена или удалена.
            this.gearboxTypesTableAdapter.Fill(this.carDealershipDataSet2.GearboxTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.EngineTypes". При необходимости она может быть перемещена или удалена.
            this.engineTypesTableAdapter.Fill(this.carDealershipDataSet2.EngineTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.Colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.carDealershipDataSet2.Colors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.carDealershipDataSet2.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.CarBodyTypes". При необходимости она может быть перемещена или удалена.
            this.carBodyTypesTableAdapter.Fill(this.carDealershipDataSet2.CarBodyTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet2.Models". При необходимости она может быть перемещена или удалена.
            this.modelsTableAdapter.Fill(this.carDealershipDataSet2.Models);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carDealershipDataSet1.Models". При необходимости она может быть перемещена или удалена.
            
        }

        private void buttonInsertCar_Click(object sender, EventArgs e)
        {
            insertCar.Parameters["@VIN"].Value =
                textBoxInsertCarVIN.Text;
            insertCar.Parameters["@model"].Value =
                comboBoxInsertCarModel.Text;
            insertCar.Parameters["@carBodyType"].Value =
                comboBoxInsertCarCarBodyType.Text;
            insertCar.Parameters["@category"].Value =
                comboBoxInsertCarCategory.Text;
            insertCar.Parameters["@color"].Value =
                comboBoxInsertCarColor.Text;
            insertCar.Parameters["@engineType"].Value =
                comboBoxInsertCarEngineType.Text;
            insertCar.Parameters["@gearboxType"].Value =
                comboBoxInsertCarGearboxType.Text;
            insertCar.Parameters["@manufacturer"].Value =
                comboBoxInsertCarManufacturer.Text;
            insertCar.Parameters["@engineCapacity"].Value =
                textBoxInsertCarEngineCapacity.Text;
            insertCar.Parameters["@enginePower"].Value =
                textBoxInsertCarEnginePower.Text;
            insertCar.Parameters["@releaseYear"].Value =
                textBoxInsertCarReleaseYear.Text;
            insertCar.Parameters["@price"].Value =
                textBoxInsertCarPrice.Text;
            sqlConnection1.Open();
            try
            {
                insertCar.ExecuteNonQuery();
                MessageBox.Show(Convert.ToString(insertCar.Parameters["@message"].Value));
                this.carsView1TableAdapter.Fill(this.carDealershipDataSet2.CarsView1);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection1.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                if (openFileDialog1.FileName != "openFileDialog1")
                {
                    addImage.Parameters["@VIN"].Value =
                    textBoxInsertCarVIN.Text;
                    addImage.Parameters["@imagePath"].Value =
                        openFileDialog1.FileName;
                    sqlConnection1.Open();
                    addImage.ExecuteNonQuery();
                }
                else
                    throw new Exception("Не было выбрано ни одного файла!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection1.Close();
        }

        private List<String> getImages(String VIN)
        {
            //sqlConnection1.Open();
            List<String> list = new List<String>();
            var getPhotoesByVIN = "SELECT ImagePath FROM Images WHERE Car = '" + VIN + "'";
            var command = new SqlCommand(getPhotoesByVIN, sqlConnection1);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(reader.GetValue(0).ToString());
                }

                reader.Close();
            }

            return list;
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                pictureBox1.Image = Image.FromFile(Convert.ToString(this.getImages(textBoxInsertCarVIN.Text)[0]));
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int imageNum = 0;
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                if (this.imageNum > 0)
                {
                    this.imageNum--;
                    pictureBox1.Image = Image.FromFile(Convert.ToString(this.getImages(textBoxInsertCarVIN.Text)[this.imageNum]));
                }
                else
                {
                    this.imageNum = this.getImages(textBoxInsertCarVIN.Text).ToArray().Length - 1;
                    pictureBox1.Image = Image.FromFile(Convert.ToString(this.getImages(textBoxInsertCarVIN.Text)[this.imageNum]));
                }
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                if (imageNum < this.getImages(textBoxInsertCarVIN.Text).ToArray().Length - 1)
                {
                    this.imageNum++;
                    pictureBox1.Image = Image.FromFile(Convert.ToString(this.getImages(textBoxInsertCarVIN.Text)[this.imageNum]));
                }
                else
                {
                    imageNum = 0;
                    pictureBox1.Image = Image.FromFile(Convert.ToString(this.getImages(textBoxInsertCarVIN.Text)[this.imageNum]));
                }
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.servicesAndGoodsBindingSource.EndEdit();
                this.servicesAndGoodsTableAdapter.Update(this.carDealershipDataSet2.ServicesAndGoods);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxInsertEmployeeFirstName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxInsertCarEngineCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checking.IntNumbersCheck(e);
        }

        private void textBoxInsertCarReleaseYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checking.IntNumbersCheck(e);
        }

        private void textBoxInsertCarPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checking.MoneyCheck(e, textBoxInsertCarPrice.Text);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesInformationFormDirector form = new EmployeesInformationFormDirector();
            form.Show();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsInformationFormDirector form = new ClientsInformationFormDirector();
            form.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesFormDirector form = new SalesFormDirector();
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.servicesAndGoodsTableAdapter.Fill(this.carDealershipDataSet2.ServicesAndGoods);
        }
    }
}
