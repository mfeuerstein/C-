using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2___MIchael_Feuerstein
{
    public static class Validator
	{
		private static string title = "Entry Error";

		public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public static bool IsPresent(TextBox textBox, string name)
		{
			if (textBox.Text == "")
			{
                MessageBox.Show(name + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        public static bool startsWithLetter(TextBox textBox, string name)
        {
            if (!Char.IsLetter(textBox.Text[0]))
            {
                MessageBox.Show(name + " does not start with a letter.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool isAlphanumeric(TextBox textBox, string name)
        {
            if (!textBox.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show(name + " is not alphanumeric.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsPositive(TextBox textBox, string name)
        {
            if (Convert.ToInt32(textBox.Text) > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be greater than 0.", Title);
                textBox.Focus();
                return false;
            }
        }

		public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.IndexOf("@") == -1 ||
                 textBox.Text.IndexOf(".") == -1)
            {
                MessageBox.Show(textBox.Tag + " must be a valid email address.",
                    Title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool hasMinChar(TextBox textBox, string name, int minChar)
        {
            if (textBox.TextLength < minChar)
            {
                MessageBox.Show(name + " has less than " + minChar + " characters", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;

        }

        internal static void IsPresent(string p)
        {
            throw new NotImplementedException();
        }
    }
}
