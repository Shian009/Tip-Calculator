using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private static double s_noOfPeople = 0;
        private static double s_tip = 0.0;
        
        private void button1_Click(object sender, EventArgs e) 
        {
            double bill;
            double tip;
            double people;
            double outputTipText, outputTotalText;

            // char c = '%';
            try {
                if ((inputBill.Text.Length == 0) || (inputTip.Text.Length == 0) || (inputPerson.Text.Length == 0))
                {
                    throw (new Exception("Input Fields Can't be empty!"));
                }

                if ( IsStringCharacter(inputBill.Text) )
                {
                    throw (new Exception("Enter a valid bill amount, without $ sign!"));
                }
                if (IsStringCharacter(inputTip.Text))
                {
                    throw (new Exception("Enter a valid tip in percentage, without % sign!"));
                }
                if (IsStringCharacter(inputPerson.Text))
                {
                    throw (new Exception("Enter a valid no. of Persons!"));
                }

                bill = Convert.ToDouble(inputBill.Text);
                tip = Convert.ToDouble(inputTip.Text);
                people = Convert.ToDouble(inputPerson.Text);


                if( (bill < 0) || (tip < 0) || (people < 0))
                {
                    throw (new Exception("Input can't be negative!"));
                }

                if(people == 0)
                {
                    throw (new Exception("No. of people should be more than 0!"));
                }

                if( Math.Floor(people) != Math.Ceiling(people))
                {
                    throw (new Exception("No. of people should be an integer value!"));
                }

                outputTipText = (bill / people) * tip / 100;
                outputTotalText = (bill / people) + outputTipText;
                outputTipText = Math.Round(outputTipText, 2);
                outputTotalText = Math.Round(outputTotalText, 2);

                outputTip.Text = "$" + outputTipText.ToString();
                outputTotal.Text = "$" + outputTotalText.ToString();

            }
            catch (Exception E) {
                string title = "Invalid Input!";
                MessageBox.Show(E.Message, title);
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        public bool IsStringCharacter(string inputString)
        {
            foreach (char ch in inputString)
            {
                if (!(((ch >= '0') && (ch <= '9')) || (ch == '.') || (ch == '-')))
                    return true;
            }
            return false;
        }

       
        private void PlusTipButtonClick(object sender, EventArgs e)
        {
            if(inputTip.Text.Length != 0)
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
                        s_tip += 1;
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
                s_tip = 1;
                inputTip.Text = s_tip.ToString();
            }
            
        }

        private void MinusTipButtonClick(object sender, EventArgs e)
        {
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
        private void PlusPeopleButtonClick(object sender, EventArgs e)
        {
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
                        s_noOfPeople = temp + 1;
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
                s_noOfPeople = 1;
                inputPerson.Text = s_noOfPeople.ToString();
            }
        }

        private void MinusPeopleButtonClick(object sender, EventArgs e)
        {
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
