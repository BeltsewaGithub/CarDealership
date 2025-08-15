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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Check.Parameters["@password"].Value = 
                textBoxPassword.Text;
            Check.Parameters["@login"].Value =
                textBoxLogin.Text;
            sqlConnection1.Open();
            Check.ExecuteNonQuery();
            try
            {
                if (textBoxPassword.Text == "" || textBoxLogin.Text == "")
                {
                    throw new Exception("Поля не могут быть пустыми");
                }
                else if (Convert.ToInt16(Check.Parameters["@res"].Value) == 0)
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                else if (Convert.ToInt16(Check.Parameters["@res"].Value) == 1)
                {
                    ManagerForm form1 = new ManagerForm();
                    Checking.CurrentEmployee = Convert.ToInt32(Check.Parameters["@employee"].Value);
                    form1.Show();
                }
                else if (Convert.ToInt16(Check.Parameters["@res"].Value) == 2)
                {
                    DirectorForm form2 = new DirectorForm();
                    Checking.CurrentEmployee = Convert.ToInt32(Check.Parameters["@employee"].Value);
                    form2.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection1.Close();
        }
    }
}
