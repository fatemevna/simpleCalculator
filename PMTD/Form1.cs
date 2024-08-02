using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTD
{
    public partial class tbOperation : Form
    {
        int result;
        int firstnumber;
        int secondnumber;

        public tbOperation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            bool isNumber = int.TryParse(tbFirstNumber.Text , out firstnumber);
            if (isNumber == false)
            {
                tbFirstNumber.Text = "Enter a number moron!";
            }
            else
            {
                firstnumber = Int32.Parse(tbFirstNumber.Text);
            }
            bool isNumber2 = int.TryParse(tbSecondNumber.Text, out secondnumber);
            if (isNumber2 == false)
            {
                tbSecondNumber.Text = "Enter a number moron!";
            }
            else
            {
                secondnumber = Int32.Parse(tbSecondNumber.Text);
            }

            
            
            
           
            if (textBoxOperation.Text == "+")
            {
                result = firstnumber + secondnumber;
            }
            else if (textBoxOperation.Text == "-")
            {

                result = firstnumber - secondnumber;
            }
            else if (textBoxOperation.Text == "/")
            {
                result = firstnumber / secondnumber;
            }
            else if ( textBoxOperation.Text == "*")
            {
                result = firstnumber * secondnumber;
            }

            if (result <= 50)
            {
                labelResult.ForeColor = Color.Red;
            }
            else if (result > 50)
            {
                labelResult.ForeColor = Color.Green;
            }

            labelResult.Text = result.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
