using HackerRank.Practice.All_Domains.Tutorials;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace HackerRank
{
    public partial class TestRunner : Form
    {
        public TestRunner()
        {
            InitializeComponent();
        }

        private void btnClearResults_Click(object sender, EventArgs eventArgs)
        {
            txtConsoleOutput.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs eventArgs)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int linesCount = txtConsoleInput.Lines.Count();
            string[] args = new string[linesCount];
            for (int x = 0; x < linesCount; x++)
            {
                args[x] = txtConsoleInput.Lines[x].Trim();
            }

            /** DATA STRUCTURES **/
            //CrackingTheCodingInterview.DataStructures.ArraysLeftRotation(args, txtConsoleOutput);
            //CrackingTheCodingInterview.DataStructures.StringsMakingAnagrams(args, txtConsoleOutput);
            //CrackingTheCodingInterview.DataStructures.HashTablesRansomNote(args, txtConsoleOutput);
            //CrackingTheCodingInterview.DataStructures.StacksBalancedBrackets(args, txtConsoleOutput);
            //CrackingTheCodingInterview.DataStructures.QueuesATaleOfTwoStacks(args, txtConsoleOutput); 

            /** ALGORITHMS **/
            //CrackingTheCodingInterview.Algorithms.SortingBubbleSort(args, txtConsoleOutput);
            //CrackingTheCodingInterview.Algorithms.MergeSortCountingInversions(args, txtConsoleOutput);
            //CrackingTheCodingInterview.Algorithms.BinarySearchIceCreamParlor(args, txtConsoleOutput);
            //CrackingTheCodingInterview.Algorithms.DFSConnectedCellInAGrid(args, txtConsoleOutput);

            /** TECHNIQUES **/
            //CrackingTheCodingInterview.Techniques.TimeComplexityPrimality(args, txtConsoleOutput);
            //CrackingTheCodingInterview.Techniques.FibonacciNumbers(args, txtConsoleOutput);
            //CrackingTheCodingInterview.Techniques.RecursionDavisStaircase(args, txtConsoleOutput);
            CrackingTheCodingInterview.Techniques.BitManipulationLonelyInteger(args, txtConsoleOutput);
        }
    }
}
