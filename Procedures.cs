using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Globalization;

namespace PizzaDelivery
{
    class Procedures
    {
        public static string TitleText(TextBox tb)
        {
            var text = tb.Text.Trim();
            var textInfo = new CultureInfo("ru-RU").TextInfo;
            string resText = textInfo.ToTitleCase(textInfo.ToLower(text)).ToString();

            return resText;
        }

        public static void LetterOnly(KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '-')
            {
                e.Handled = true;
            }
        }

        public static void DigitsOnly(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
