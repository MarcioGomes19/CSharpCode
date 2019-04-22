using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Core
{
    public class Functions
    {
        public static bool StringCompare(string value1, string value2)
        {
            if (string.IsNullOrWhiteSpace(value1) && string.IsNullOrWhiteSpace(value2))
                return true;

            if (string.IsNullOrWhiteSpace(value1) || string.IsNullOrWhiteSpace(value2))
                return false;

            return value1.Trim().ToUpper().Equals(value2.Trim().ToUpper());
        }

        public static bool StringStart(string value1, string value2)
        {
            if (string.IsNullOrWhiteSpace(value1) && string.IsNullOrWhiteSpace(value2))
                return true;

            if (string.IsNullOrWhiteSpace(value1) || string.IsNullOrWhiteSpace(value2))
                return false;

            return value1.Trim().ToUpper().StartsWith(value2.Trim().ToUpper());
        }

        public static void AddCombobox(ref ComboBox control, string id, object value)
        {
            DictionaryEntry dic;
            if (!string.IsNullOrWhiteSpace(id) && value != null)
            {
                dic = new DictionaryEntry(id, value);
            }
            else
            {
                dic = new DictionaryEntry(null, null);
            }

            control.ValueMember = "Key";
            control.DisplayMember = "Value";

            control.Items.Add(dic);
        }

        public static T getSelectValue<T>(ref ComboBox control)
        {
            if (control.SelectedItem == null) return default(T);
            return (T)((DictionaryEntry)control.SelectedItem).Value;
        }

        public static void clearCombobox(ref ComboBox control)
        {
            control.Items.Clear();
            control.Tag = null;
            control.Text = string.Empty;
            control.DataSource = null;            
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static decimal getOnlyNumbers(string value)
        {
            string numbers = "0123456789";
            StringBuilder onlyNumbers = new StringBuilder();
            foreach(char c in value)
            {
                if (numbers.Contains(c.ToString()))
                {
                    onlyNumbers.Append(c.ToString());
                }
            }

            decimal number;
            decimal.TryParse(onlyNumbers.ToString(), out number);
            return number;
        }
    }
}
