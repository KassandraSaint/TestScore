using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Creating a mnethod to read contents of the file and add it to the list
        private void ReadAdd(List<int> scoresList)
        {
            // Trying to open and read a file
            try
            {
                StreamReader inputFile = File.OpenText("Resources/TestScores.txt");

                // While there is data reading contents from the file
                while (!inputFile.EndOfStream)
                {
                    // Adding every entry to the scoresList
                    scoresList.Add(int.Parse(inputFile.ReadLine()));
                }
                // Closing file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Creating a method that displays scores from the scoresList
        private void DisplayScores(List<int> scoresList)
        {
            // Adding every entry from the scoresList to a testScoreBox 
            foreach (int score in scoresList)
            {
                testScoreBox.Items.Add(score);
            }
        }

        // Creating a method to calculate avarage of all scores
        private double Average(List<int> scoresList)
        {
            // Initializing accumulator variabble and average variable
            int total = 0;
            double average;

            // Calculating total of all scores in a list
            foreach (int score in scoresList)
            {
                total += score;
            }
            // Calculating average of all scores
            average = (double)total / scoresList.Count;

            // Returning average
            return average;
        }

        // Creating a method to calculate number of scores that are above avarage
        private int AboveAverage(List<int> scoresList)
        {
            // Initializing a variable above to hold number of scores above average
            int above = 0;

            // Calculating avarage by calling Average method and storing it in average variable
            double average = Average(scoresList);

            // Counting number of scores that are above average
            foreach (int score in scoresList)
            {
                // If score is greater than average score adding one to above variable
                if (score > average)
                {
                    above += 1;
                }
            }
            // Returning above score
            return above;
        }

        // Creating a method to calculate number of scores that are below average
        private int BelowAverage(List<int> scoresList)
        {
            // Initializing a variable to hold number of scores below average
            int below = 0;

            // Calling Average method to calculate average of scores
            double average = Average(scoresList);

            // Calculating number of scores below average
            foreach (int score in scoresList)
            {
                // If score is below average adding 1 to below variable
                if (score < average)
                {
                    below += 1;
                }
            }
            // Returning below scores
            return below;
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            // Initializing variables to hold average score and number of scores below and above average
            double average;
            int aboveAverage;
            int belowAverage;

            // Creating a list to hold scores
            List<int> scoresList = new List<int>();

            // Calling ReadAdd method to read scores from the file and add them to a list
            ReadAdd(scoresList);

            // Calling DisplayScores method to display scores in a ListBox
            DisplayScores(scoresList);

            // Calling Average methiod to calculate average of scores
            average = Average(scoresList);
            // Displaying average in the averageLabel
            averageLabel.Text = average.ToString("n1");

            // Calling AboveAverage method to calculate number of above average scores
            aboveAverage = AboveAverage(scoresList);
            // Displaying number of scores aove average in aboveLablel
            aboveLabel.Text = aboveAverage.ToString();

            // Calling BelowAverage method to calculate number of scores below average
            belowAverage = BelowAverage(scoresList);
            // Displaying number of scores above average in belowLabel
            belowLabel.Text = belowAverage.ToString();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
