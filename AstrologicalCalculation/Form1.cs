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
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxOutput_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListBoxOutput.SelectedItem != null)
            {
                TextBoxInput.Text = ListBoxOutput.SelectedItem.ToString();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int lowBound = 0;
            int highBound = max;
            int target;
            if (!(Int32.TryParse(TextBoxInput.Text, out target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            while (lowBound <= highBound)
            {
                int mid = (lowBound + highBound) / 2;
                if (myArray[mid] == target)
                {
                    MessageBox.Show("Found at index " + mid);
                    return;
                }
                else if (myArray[mid] < target)
                {
                    lowBound = mid + 1;
                }
                else
                {
                    highBound = mid - 1;
                }

            }
            MessageBox.Show("Not found. Try again.");
        }

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
    }
}
