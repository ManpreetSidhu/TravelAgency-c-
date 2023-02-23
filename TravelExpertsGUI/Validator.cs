// this is used to validate the data entered by the user.
// created by Manpreet Sidhu on Jan 2022

using System;
using System.Windows.Forms;

namespace TravelExpertsGUI
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// tests if text box has input in it (assumes that is has Tag property that states meaning)
        /// </summary>
        /// <param name="inputBox"> text box to validate </param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsProvided(TextBox inputBox)
        {
            bool isValid = true; // valid unless proven otherwise

            if (inputBox.Text == "")// bad!
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " is required");
                inputBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// tests if combo box has a value selected (assumes that is has Tag property that states meaning)
        /// </summary>
        /// <param name="comboBox"> combo box to validate </param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsSelected(ComboBox comboBox)
        {
            bool isValid = true; // valid unless proven otherwise

            if (comboBox.SelectedIndex == -1)// no selection!
            {
                isValid = false;
                MessageBox.Show(comboBox.Tag.ToString() + " must be selected");
                comboBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        ///  tests if text box contains non-negative int (assumes that is has Tag property that states meaning)
        /// </summary>
        /// <param name="inputBox">text box to validate</param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox inputBox)
        {
            bool isValid = true;
            int result; // result from parsing
            if (!Int32.TryParse(inputBox.Text, out result)) // if not an int
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " should be a whole number");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }
            else if (result < 0)// it is an int, but could be negative
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " has to be greater than or equal to zero");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }

            return isValid;
        }

        public static bool IsValid(TextBox inputBox)
        {
            bool isValid = true; // valid unless proven otherwise

            if (inputBox.Text == "")// bad!
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " is required");
                inputBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        ///  tests if text box contains non-negative number (assumes that is has Tag property that states meaning)
        /// </summary>
        /// <param name="inputBox">text box to validate</param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox inputBox)
        {
            bool isValid = true;
            double result; // result from parsing
            if (!Double.TryParse(inputBox.Text, out result)) // if not a number
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " should be a number");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }
            else if (result < 0)// it is a number, but could be negative
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " has to be greater than or equal to zero");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }

            return isValid;
        }

        /// <summary>
        ///  tests if text box contains non-negative number (assumes that is has Tag property that states meaning)
        /// </summary>
        /// <param name="inputBox">text box to validate</param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox inputBox)
        {
            bool isValid = true;
            decimal result; // result from parsing
            if (!Decimal.TryParse(inputBox.Text, out result)) // if not a number
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " should be a number");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }
            else if (result < 0)// it is a number, but could be negative
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " has to be greater than or equal to zero");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }

            return isValid;
        }

        /// <summary>
        ///  tests if text box contains valid percent (0-1 decimal) (assumes that is has Tag property that states meaning)
        /// </summary>
        /// <param name="inputBox">text box to validate</param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsPercentDecimal(TextBox inputBox)
        {
            bool isValid = true;
            decimal result; // result from parsing
            if (!Decimal.TryParse(inputBox.Text, out result)) // if not a number
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " should be a decimal number 0 .. 1");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }
            else if (result < 0 || result > 1)// it is a number, but could be outside percent range
            {
                isValid = false;
                MessageBox.Show(inputBox.Tag.ToString() + " has to be between 0 and 1");
                // prepare for fixing
                inputBox.SelectAll(); // highlight the content
                inputBox.Focus();
            }

            return isValid;
        }

        /// <summary>
        /// test if the end date must be later than start date
        /// </summary>
        /// <param name="dateTimePicker"></param>
        /// <returns>true is valid and false is not </returns>
      
        public static bool IsCompareDate(DateTimePicker dateTimePicker, DateTimePicker dateTimePicker1)
        {
            bool isValid = true;
           
             if (dateTimePicker != null)
            {
                // compare start date and end date
                DateTime dt1= dateTimePicker.Value;
                DateTime dt2 = dateTimePicker1.Value;

                if (dt2.CompareTo(dt1)>0)
                {
                    isValid = true;

                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Package End date myst be later than Package Start Date");
                }
            }


            return isValid;
        }
        /// <summary>
        /// to test the maximum number of letters in a textbox
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns> true if valid or false if not  valid</returns>
        public static bool isValidLength(TextBox textBox)
        {
            bool isValid = true;
            // check the length of data in the textbox is not more than 10
            if(textBox.TextLength <=  10)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                MessageBox.Show(textBox.Tag.ToString() + " should not be more than 10 characters long");
            }
            return isValid;
        }
        /// <summary>
        /// test the textlength is not more than 50  characters long
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if valid or false if not valid</returns>
        public static bool isValidLength1(TextBox textBox)
        {
            bool isValid = true;
            // chekc the length of text in the textbox
            if (textBox.TextLength <= 50)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                MessageBox.Show(textBox.Tag.ToString() + " should not be more than 50 characters long");
            }
            return isValid;
        }
        public static bool CompareCommissiontoBase(TextBox baseprice,TextBox commission)
        {
            bool isValid = true;
            decimal bsprice = Convert.ToDecimal(baseprice.Text);
            decimal agcommission = Convert.ToDecimal(commission.Text);
            if (bsprice > agcommission)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                MessageBox.Show(" Agency Commission cannot be greater than the Base Price");
            }
            return isValid;
        }
    } // class
}// namespace
