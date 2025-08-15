using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealershipApp
{
    internal class Checking
    {
        public static int CurrentEmployee = 0;
        public static void FloatNumbersCheck(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 && e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        public static void MoneyCheck(KeyPressEventArgs e, String text)
        {
            FloatNumbersCheck(e);
            char number = e.KeyChar;
            if (Regex.IsMatch(text, @"\,\d\d") && number != 8)
            {
                e.Handled = true;
            }


        }
        public static void IntNumbersCheck(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 && e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        public static void SimbolsOnlyCheck(KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(e.KeyChar) && number != 8 && number != 32 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
