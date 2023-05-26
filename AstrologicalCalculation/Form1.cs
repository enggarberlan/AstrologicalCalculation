using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AstrologicalCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillArray();
            DisplayInteractions();
        }

        static int max = 24;
        int[] myArray = new int[max];


        private void DisplayInteractions()
        {
            ListBoxOutput.Items.Clear();
            foreach (var interactions in myArray)
            {
                ListBoxOutput.Items.Add(interactions);
            }


        }

        #region Unused 
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion Unused

        private void ListBoxOutput_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListBoxOutput.SelectedItem != null)
            {
                TextBoxInput.Text = ListBoxOutput.SelectedItem.ToString();
            }
        }

        #region Search Button
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int target;
            if(!int.TryParse(TextBoxInput.Text, out target))
            if (!(Int32.TryParse(TextBoxInput.Text, out target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            int index = Array.IndexOf(myArray, target);
            if (index != -1)
            {
                MessageBox.Show("Found at index " + index);
            }
            else
            {
                MessageBox.Show("Not found. Try again, mate");
            }
            
        }
        #endregion Search Button

        #region Edit Button
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxInput.Text))
            {
                MessageBox.Show("Please type any value on text box");
                return;
            }

            if (ListBoxOutput.SelectedItem != null)
            {
                int newValue;
                if (Int32.TryParse(TextBoxInput.Text, out newValue))
                {
                    myArray[ListBoxOutput.SelectedIndex] = newValue;
                    DisplayInteractions();
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }
        #endregion Edit Button

        #region Sort Button
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            for (int outer = 0; outer < max - 1; outer++)
            {
                for (int inner = 0; inner < max - 1; inner++)
                {
                    if (myArray[inner] > myArray[inner + 1])
                    {
                        //Swap routine
                        int temp = myArray[inner];
                        myArray[inner] = myArray[inner + 1];
                        myArray[inner + 1] = temp;

                        DisplayInteractions();
                        Application.DoEvents();
                        Thread.Sleep(20);
                    }


                }
            }

        }
        #endregion Sort Button

        #region Methods
        //Method to fill Array with random numbers
        private void FillArray()
        {
            //Create a random number
            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                //Random number0..100
                myArray[i] = rand.Next(10, 99);
            }
        }

        //Method for calculate mid-extreme
        private double CalculateMidExtreme()
        {
            
            double min = myArray.Min();
            double max = myArray.Max();
            return (min + max) / 2;
        }

        //Method to calculate mode
        private int CalculateMode()
        {
            var groups = myArray.GroupBy(x => x);
            int maxCount = groups.Max(g=>g.Count());
            int mode = groups.First(g=>g.Count() == maxCount).Key;
            return mode;
        }

        //Method to calculate average
        private double CalculateAverage()
        {
            double average = myArray.Average();
            return average;
        }

        //Method to calculate range
        private int CalculateRange()
        {
            int range = myArray.Max() - myArray.Min();
            return range;
        }
        #endregion Methods

        #region Mid Extreme Button
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            double midExtreme = CalculateMidExtreme();
            TextBoxOutput.Text = "Mid Extreme: (" + myArray.Min() + " + " + myArray.Max()
                + ") / 2 = " + midExtreme;
        }
        #endregion Mid Extreme Button

        #region Mode Button
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            int mode = CalculateMode();
            TextBoxOutput.Text = "Mode: " + mode.ToString(); 
        }
        #endregion Mode Button

        #region Average Button
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            double arraySum = Convert.ToDouble(myArray.Sum());
            double arrayAverage = arraySum / max;
            TextBoxOutput.Text = "Average: " + String.Format("{0:N2}", arrayAverage);
        }


        #endregion Average Button

        #region Range Button
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            
        }
        #endregion Range Button
    }
}
