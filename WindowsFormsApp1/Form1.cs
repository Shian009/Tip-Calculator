using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tip Calculator by Shivank Maheshwari
// Dated: 17-05-2021

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // static variables to hold data of tip and no. of people

        private static double s_noOfPeople = 0;
        private static double s_tip = 0.0;
        
        // function to be called after pressing the 'Generate Bill' 
        // Button
        private void GenerateBill(object sender, EventArgs e) 
        {

            // data members 
            double bill;
            double tip;
            double people;
            double outputTipText, outputTotalText;

            // try-catch block to handle errors or malicious inputs 
            // given by the user
            try 
            {
                // removing leading and trailing whitespaces if any
                inputBill.Text = inputBill.Text.Trim();
                inputTip.Text = inputTip.Text.Trim();
                inputPerson.Text = inputPerson.Text.Trim();

                // checking if any field is Empty or not
                if ((inputBill.Text.Length == 0) || (inputTip.Text.Length == 0) || (inputPerson.Text.Length == 0))
                {
                    // if any field is Empty, throw an Exception!
                    throw (new Exception("Input Fields Can't be empty!"));
                }
                
                // checking if Bill entered by the user is a string or a number
                // if not a number then throw an Exception
                if ( IsStringCharacter(inputBill.Text) )
                {
                    throw (new Exception("Enter a valid bill amount, without $ sign!"));
                }
                // checking if Tip entered by the user is a string or a number
                // if not a number then throw an Exception
                if (IsStringCharacter(inputTip.Text))
                {
                    throw (new Exception("Enter a valid tip in percentage, without % sign!"));
                }
                // checking if No. of Persons entered by the user is a string or a number
                // if not a number then throw an Exception
                if (IsStringCharacter(inputPerson.Text))
                {
                    throw (new Exception("Enter a valid no. of Persons!"));
                }

                // parse the input from string to double
                bill = Convert.ToDouble(inputBill.Text);
                tip = Convert.ToDouble(inputTip.Text);
                people = Convert.ToDouble(inputPerson.Text);

                // if any input field is negative then throw an Exception
                if( (bill < 0) || (tip < 0) || (people < 0))
                {
                    throw (new Exception("Input can't be negative!"));
                }

                // if people input is 0, throw an Exception
                if(people == 0)
                {
                    throw (new Exception("No. of people should be more than 0!"));
                }
                
                // logic to check, if the no. of people is an integer or not
                // eg: value enter = 4.6, then floor value = 4 and ceil Value = 5
                if( Math.Floor(people) != Math.Ceiling(people))
                {
                    throw (new Exception("No. of people should be an integer value!"));
                }

                // calculating tip per person
                outputTipText = (bill / people) * tip / 100;
                //calculating total Bill per person
                outputTotalText = (bill / people) + outputTipText;
                
                // rounding upto two digits
                outputTipText = Math.Round(outputTipText, 2);
                outputTotalText = Math.Round(outputTotalText, 2);

                // displaying the result on the panel
                outputTip.Text = "$" + outputTipText.ToString();
                outputTotal.Text = "$" + outputTotalText.ToString();

            }
            catch (Exception E) {
                
                // title variable for MessageBox 
                string title = "Invalid Input!";
                // displaying message through MessageBox
                MessageBox.Show(E.Message, title);
                
                // reloading the form again
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            }
        }
        // function to check whether the given input String 
        // contains a alphabetical character or not.
        public bool IsStringCharacter(string inputString)
        {
            foreach (char ch in inputString)
            {
                if (!(((ch >= '0') && (ch <= '9')) || (ch == '.') || (ch == '-')))
                    return true;
            }
            return false;
        }

       // function to handle the event when plus button of tip input is pressed
        private void PlusTipButtonClick(object sender, EventArgs e)
        {
            // checking whether tip has some prior input or not
            if(inputTip.Text.Length != 0)
            {
                // try-catch to handle errors or malicious inputs
                try
                {
                    // checking if Tip entered by the user is a string or a number
                    // if not a number then throw an Exception
                    if (IsStringCharacter(inputTip.Text))
                    {
                        throw (new Exception("Enter a valid tip in percentage, without % sign!"));
                    }
                    else
                    {
                        // convert to Double value 
                        s_tip = Convert.ToDouble(inputTip.Text);
                        // increment the tip
                        s_tip += 1;
                        // reflect the changes in the input field
                        inputTip.Text = s_tip.ToString();
                    }
                }
                catch (Exception E)
                {
                    // title variable for MessageBox 
                    string title = "Invalid Input!";
                    // displaying message through MessageBox
                    MessageBox.Show(E.Message, title);

                    // reloading the form again
                    Form1 NewForm = new Form1();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            else
            {
                // no prior input is there 
                // simply update the tip
                s_tip = 1;
                inputTip.Text = s_tip.ToString();
            }
            
        }
        // function to handle the event when minus button of tip input is pressed
        private void MinusTipButtonClick(object sender, EventArgs e)
        {
            // Everything is same as previous function, i.e. PlusTipButtonClick
            if (inputTip.Text.Length != 0)
            {
                try
                {
                    if (IsStringCharacter(inputTip.Text))
                    {
                        throw (new Exception("Enter a valid tip in percentage, without % sign!"));
                    }
                    else
                    {
                        s_tip = Convert.ToDouble(inputTip.Text);
                        // except here
                        s_tip -= 1;
                        inputTip.Text = s_tip.ToString();
                    }
                }
                catch (Exception E)
                {
                    string title = "Invalid Input!";
                    MessageBox.Show(E.Message, title);
                    Form1 NewForm = new Form1();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            else
            {
                s_tip = 0;
                inputTip.Text = s_tip.ToString();
            }
        }
        // function to handle the event when Plus button of Person input is pressed
        private void PlusPeopleButtonClick(object sender, EventArgs e)
        {
            // checking whether tip has some prior input or not
            if (inputPerson.Text.Length != 0)
            {
                // try-catch to handle errors or malicious inputs
                try
                {
                    // checking if Tip entered by the user is a string or a number
                    // if not a number then throw an Exception
                    if (IsStringCharacter(inputPerson.Text))
                    {
                        throw (new Exception("Enter a valid no. of Persons!"));
                    }
                    else
                    {
                        // converting to double value from String type
                        double temp = Convert.ToDouble(inputPerson.Text);
                        // checking if the value is an integer or not
                        // if not then throw an error
                        if (Math.Floor(temp) != Math.Ceiling(temp))
                        {
                            throw (new Exception("No. of people should be an integer value!"));
                        }
                        // increment the no. of people
                        s_noOfPeople = temp + 1;
                        // reflect the changes in the input field
                        inputPerson.Text = s_noOfPeople.ToString();
                    }
                }
                catch (Exception E)
                {
                    // title variable for MessageBox 
                    string title = "Invalid Input!";
                    // displaying message through MessageBox
                    MessageBox.Show(E.Message, title);

                    // reloading the form again
                    Form1 NewForm = new Form1();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            else
            {
                // no prior input is there 
                // simply update the no. of people
                s_noOfPeople = 1;
                inputPerson.Text = s_noOfPeople.ToString();
            }
        }
        // function to handle the event when Minus button of Person input is pressed
        private void MinusPeopleButtonClick(object sender, EventArgs e)
        {
            // Everything is same as previous function, i.e. PlusPeopleButtonClick
            if (inputPerson.Text.Length != 0)
            {
                try
                {
                    if (IsStringCharacter(inputPerson.Text))
                    {
                        throw (new Exception("Enter a valid no. of Persons!"));
                    }
                    else
                    {
                        double temp = Convert.ToDouble(inputPerson.Text);
                        if (Math.Floor(temp) != Math.Ceiling(temp))
                        {
                            throw (new Exception("No. of people should be an integer value!"));
                        }
                        // except here
                        s_noOfPeople = temp - 1;
                        inputPerson.Text = s_noOfPeople.ToString();
                    }
                }
                catch (Exception E)
                {
                    string title = "Invalid Input!";
                    MessageBox.Show(E.Message, title);
                    Form1 NewForm = new Form1();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            else
            {
                s_noOfPeople = 0;
                inputPerson.Text = s_noOfPeople.ToString();
            }

        }
    }
}
