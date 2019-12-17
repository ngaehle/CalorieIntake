using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieIntake
{
    public partial class CalorieIntake : Form
    {
        public CalorieIntake()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nameInput.Clear();
            carbInput.Clear();
            fatInput.Clear();
            proteinInput.Clear();
            fiberInput.Clear();

            dateTimePicker1.ResetText();
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fatInput_TextChanged(object sender, EventArgs e)
        {
            
            //if (System.Text.RegularExpressions.Regex.IsMatch(fatInput.Text, @"\d+(\.\d{2,2})"))
            //{
            //    fatInput.Clear();

            //    MessageBox.Show("Please enter only numbers.");
            //    return;

            //}
        }

        private void carbInput_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(carbInput.Text, "[^0-9]"))
            //{
            //    carbInput.Clear();

            //    MessageBox.Show("Please enter only numbers.");
            //    return;

            //}
        }

        private void proteinInput_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(proteinInput.Text, "[^0-9]"))
            //{
            //    proteinInput.Clear();

            //    MessageBox.Show("Please enter only numbers.");
            //    return;

            //}
        }

        private void Fiber_Click(object sender, EventArgs e)
        {

        }

        private void fiberInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(fiberInput.Text, "[^0-9]"))
            {
                fiberInput.Clear();

                MessageBox.Show("Please enter only numbers.");
                return;

            }
        }

        private void dataEntry_Click(object sender, EventArgs e)
        {
            double fatGrams, carbGrams, proteinGrams, fiberGrams;

            string ItemName;
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            fatGrams = double.Parse(fatInput.Text);
            carbGrams = double.Parse(carbInput.Text);
            proteinGrams = double.Parse(proteinInput.Text);
            fiberGrams = double.Parse(fiberInput.Text);
            ItemName = (nameInput.Text).ToString();


            if (fatGrams >= 0)
            {
                fatGrams = fatGrams * 9;
            }
            else
            {
                string message1 = "Please enter correct value of Fat";
                string title1 = "Hint";
                MessageBox.Show(message1, title1);
                return;
            }

            if (carbGrams >= 0)
            {
                carbGrams = carbGrams * 4;
            }
            else
            {
                string message2 = "Please enter correct value of Carbohydrates";
                string title2 = "Hint";
                MessageBox.Show(message2, title2);
                return;
            }

            if (proteinGrams >= 0)
            {
                proteinGrams = proteinGrams * 4;
            }
            else
            {
                string message3 = "Please enter correct value of Protein";
                string title3 = "Hint";
                MessageBox.Show(message3, title3);
                return;
            }

            if (proteinGrams >= 0)
            {
                fiberGrams = (fatGrams + carbGrams + proteinGrams) * fiberGrams;
            }
            else 
            {
                string message4 = "Please enter correct value of serving amount of container";
                string title4 = "Hint";
                MessageBox.Show(message4, title4);
                return;
            }

            if (ItemName == "")
            {
                string message5 = "Please enter correct name";
                string title5 = "Hint";
                MessageBox.Show(message5, title5);
                return;
            }


            string message = ItemName + " has Calories of : " + fiberGrams;
            string title = theDate;
            MessageBox.Show(message, title);

            //Writes to Database (future addition)

        }

        private void fatCalories_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(fatInput.Text, "[^0-9]"))
            {
                fatInput.Clear();

                MessageBox.Show("Please enter only numbers.");
                return;

            }
        }

        private void nameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
                {
                    e.Handled = true;
;

                    MessageBox.Show("Please enter only Item Name.");
                    return;
                }
            }
        }

        private void fatInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
                fatInput.Clear();

                MessageBox.Show("Please enter only numbers.");
                return;


            }
        }

        private void carbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
                carbInput.Clear();

                MessageBox.Show("Please enter only numbers.");
                return;


            }
        }

        private void proteinInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
               
                proteinInput.Clear();

                MessageBox.Show("Please enter only numbers.");
                return;

            }
            
        }
    }
 }

