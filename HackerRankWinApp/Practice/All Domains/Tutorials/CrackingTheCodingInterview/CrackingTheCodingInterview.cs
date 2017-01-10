using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HackerRank.Practice.All_Domains.Tutorials
{
    public class CrackingTheCodingInterview
    {
        public class DataStructures
        {
            public static void ArraysLeftRotation(string[] args, TextBox txtConsoleOutput)
            {
                int[] tokens_n = args[0].Split().Select(Int32.Parse).ToArray();
                int n = tokens_n[0], k = tokens_n[1];
                int[] a = args[1].Split().Select(Int32.Parse).ToArray();

                int endIndex = (n + k);
                for (int x = 0; x < n; x++)
                {
                    int index = ((endIndex + x) % n);
                    txtConsoleOutput.Text += " " + a[index];
                }
            }

            public static void StringsMakingAnagrams(string[] args, TextBox txtConsoleOutput)
            {
                string inputStrA = args[0];//Console.ReadLine().Trim();
                string inputStrB = args[1];//Console.ReadLine().Trim();
                int countA = 0, countB = 0, counter = 0;

                for (int x = 0; x < inputStrA.Length;)
                {
                    char curChar = inputStrA[x];
                    countA = inputStrA.Count(c => c == curChar);
                    countB = inputStrB.Count(c => c == curChar);
                    counter += Math.Abs(countA - countB);
                    inputStrA = inputStrA.Replace(curChar.ToString(), string.Empty);
                    inputStrB = inputStrB.Replace(curChar.ToString(), string.Empty);
                }

                counter += inputStrB.Length;
                txtConsoleOutput.Text += " " + counter;
            }

            public static void HashTablesRansomNote(string[] args, TextBox txtConsoleOutput)
            {
                string[] tokens_m = args[0].Split();//Console.ReadLine().Split(' ');
                int m = Convert.ToInt32(tokens_m[0]);
                int n = Convert.ToInt32(tokens_m[1]);
                List<string> magazine = args[1].Split().OrderBy(x => x).ToList();//Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
                List<string> ransom = args[2].Split().OrderBy(x => x).ToList();//Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
                bool yesOrNo = true;

                if (n > m)
                {
                    txtConsoleOutput.Text += "No";
                    //Console.WriteLine("No");
                    return;
                }

                foreach (string strA in ransom)
                {
                    if (!magazine.Remove(strA))
                    {
                        yesOrNo = false;
                        break;
                    }
                }
                if (yesOrNo)
                {
                    txtConsoleOutput.Text += "Yes";
                    //Console.WriteLine("Yes");
                }
                else
                {
                    txtConsoleOutput.Text += "No";
                    //Console.WriteLine("No");
                }
            }

            public static void LinkedListsDetectACycle(string[] args, TextBox txtConsoleOutput)
            {
                Node head = new Node();
                txtConsoleOutput.Text += HasCycle(head);
            }

            static bool HasCycle(Node head)
            {
                if (head == null) return false;
                ArrayList dataList = new ArrayList();
                while (head != null)
                {
                    if (dataList.Contains(head))
                        return true;

                    dataList.Add(head);
                    head = head.Next;
                }
                return false;
            }

            public class Node
            {
                public int data;
                public Node left;
                public Node right;
                public Node Next;
            }

            public static void StacksBalancedBrackets(string[] args, TextBox txtConsoleOutput)
            {
                int t = Convert.ToInt32(args[0]);//Convert.ToInt32(Console.ReadLine());
                Stack<char> stack1;

                for (int a0 = 0; a0 < t; a0++)
                {
                    string expression = args[a0 + 1];//Console.ReadLine();
                    int expLen = expression.Length;
                    if (expLen % 2 != 0)
                    {
                        txtConsoleOutput.Text += Environment.NewLine + "NO";
                        //Console.WriteLine("NO");
                    }
                    else
                    {
                        stack1 = new Stack<char>();
                        bool yesOrNo = true;
                        foreach (char x in expression)
                        {
                            if (x == '[') stack1.Push(x);
                            else if (x == '{') stack1.Push(x);
                            else if (x == '(') stack1.Push(x);
                            else
                            {
                                if (stack1.Count > 0)
                                {
                                    if ((stack1.Peek() != '(' & x == ')') || (stack1.Peek() != '{' & x == '}') || (stack1.Peek() != '[' & x == ']'))
                                    {
                                        yesOrNo = false;
                                    }
                                    stack1.Pop();
                                }
                                else
                                    yesOrNo = false;
                            }
                        }

                        if (yesOrNo && stack1.Count == 0)
                        {
                            txtConsoleOutput.Text += Environment.NewLine + "YES";
                            //Console.WriteLine("YES");
                        }
                        else
                        {
                            txtConsoleOutput.Text += Environment.NewLine + "NO";
                            //Console.WriteLine("NO");
                        }
                    }
                }
            }

            public static void QueuesATaleOfTwoStacks(string[] args, TextBox txtConsoleOutput)
            {
                int n = Convert.ToInt32(args[0].Trim());//Convert.ToInt32(Console.ReadLine().Trim());
                Stack<int> stack1 = new Stack<int>();
                Stack<int> stack2 = new Stack<int>();

                for (int x = 0; x < n; x++)
                {
                    int[] arr = Array.ConvertAll(args[x + 1].Trim().Split(), Int32.Parse);//Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);
                    int queryType = arr[0];
                    if (queryType == 1)//ENQUEUE
                    {
                        int pushVal = arr[1];
                        stack1.Push(pushVal);
                    }
                    else if (queryType == 2)//DEQUEUE
                    {
                        int popVal = 0;
                        if (stack2.Count == 0)
                        {
                            while (stack1.Count > 0)
                            {
                                int val = stack1.Pop();
                                stack2.Push(val);
                            }
                        }

                        if (stack2.Count > 0) popVal = stack2.Pop();
                    }
                    else if (queryType == 3)//PEEK
                    {
                        int peekVal = 0;
                        if (stack2.Count == 0)
                        {
                            while (stack1.Count > 0)
                            {
                                int val = stack1.Pop();
                                stack2.Push(val);
                            }
                        }

                        if (stack2.Count > 0) peekVal = stack2.Peek();
                        //Console.WriteLine(peekVal);
                        txtConsoleOutput.Text += Environment.NewLine + peekVal;
                    }
                }
            }

            public static void TreesIsThisABinarySearchTree(string[] args, TextBox txtConsoleOutput)
            {
                bool val = CheckBST(new Node());
            }

            public static bool CheckBST(Node root)
            {
                return Check(root, int.MinValue, int.MaxValue);
            }

            public static bool Check(Node n, int min, int max)
            {
                if (n == null) return true;
                return (n.data > min && n.data < max && Check(n.left, min, n.data) && Check(n.right, n.data, max));
            }

        }

        public class Algorithms
        {
            public static void SortingBubbleSort(string[] args, TextBox txtConsoleOutput)
            {
                int n = Convert.ToInt32(args[0]);//Convert.ToInt32(Console.ReadLine());
                string[] a_temp = args[1].Split();//Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                int outerLength = a.Length, innerLength = a.Length - 1, noOfSwaps = 0;
                for (int i = 0; i < outerLength; i++)
                {
                    for (int j = 0; j < innerLength; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                            noOfSwaps++;
                        }
                    }
                }

                txtConsoleOutput.Text += Environment.NewLine + $"Array is sorted in {noOfSwaps} swaps.";
                txtConsoleOutput.Text += Environment.NewLine + $"First Element: {a[0]}";
                txtConsoleOutput.Text += Environment.NewLine + $"Last Element: {a[a.Length - 1]}";

                //Console.WriteLine($"Array is sorted in {noOfSwaps} swaps.");
                //Console.WriteLine($"First Element: {a[0]}");
                //Console.WriteLine($"Last Element: {a[a.Length - 1]}");
            }

            public static void MergeSortCountingInversions(string[] args, TextBox txtConsoleOutput)
            {
                int t = Convert.ToInt32(args[0].Trim());//Convert.ToInt32(Console.ReadLine());
                for (int a0 = 0; a0 < args.Length - 1; a0++)
                {
                    if ((a0 & 1) != 0) continue;
                    int ab = a0 + 1;
                    int n = Convert.ToInt32(args[ab].Trim());//Convert.ToInt32(Console.ReadLine());
                    string[] arr_temp = args[ab + 1].Split();//Console.ReadLine().Split(' ');
                    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                    //Console.WriteLine(CountInversions(arr));
                    txtConsoleOutput.Text += Environment.NewLine + CountInversions(arr);
                }
            }

            static long CountInversions(int[] array)
            {
                int[] auxArray = (int[])array.Clone();
                long invCounter = 0;
                invCounter = MergeSort(array, 0, array.Length - 1, auxArray);
                return invCounter;
            }

            static long MergeSort(int[] array, int p, int r, int[] auxArray)
            {
                if (p >= r) return 0;
                int q = (p + r) / 2;
                long counter = 0;
                counter += MergeSort(auxArray, p, q, array);
                counter += MergeSort(auxArray, q + 1, r, array);
                counter += AuxArrayMerge(array, p, q, r, auxArray);
                return counter;
            }

            static long AuxArrayMerge(int[] arr, int lo, int mid, int hi, int[] aux)
            {
                long count = 0;
                int i = lo, j = mid + 1, k = lo;
                while (i <= mid || j <= hi)
                {
                    if (i > mid)
                    {
                        arr[k++] = aux[j++];
                    }
                    else if (j > hi)
                    {
                        arr[k++] = aux[i++];
                    }
                    else if (aux[i] <= aux[j])
                    {
                        arr[k++] = aux[i++];
                    }
                    else
                    {
                        arr[k++] = aux[j++];
                        count += mid + 1 - i;
                    }
                }

                return count;
            }

            public static void BinarySearchIceCreamParlor(string[] args, TextBox txtConsoleOutput)
            {
                int t = Convert.ToInt32(args[0].Trim());//Convert.ToInt32(Console.ReadLine());
                for (int a0 = 1; a0 < args.Length; a0++)
                {
                    int m = Convert.ToInt32(args[a0]);// Convert.ToInt32(Console.ReadLine());
                    int n = Convert.ToInt32(args[++a0]);// Convert.ToInt32(Console.ReadLine());
                    string[] a_temp = args[++a0].Split();//Console.ReadLine().Split(' ');
                    int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                    int x = SearchUsingCustomBinarySearch(a, m);
                    int index1 = -1, index2 = -1;
                    int complement = m - x;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (index1 == -1 && a[i] == x)
                        {
                            index1 = i;
                        }
                        else if (a[i] == complement)
                            index2 = i;
                    }
                    if (index1 < index2)
                    {
                        //Console.WriteLine($"{++index1} {++index2}");
                        txtConsoleOutput.Text += $"{Environment.NewLine}{++index1} {++index2}";
                    }
                    else
                    {
                        txtConsoleOutput.Text += $"{Environment.NewLine}{++index2} {++index1}";
                        //Console.WriteLine($"{++index2} {++index1}");
                    }
                }
            }

            static int SearchUsingCustomBinarySearch(int[] a, int searchValue)
            {
                int[] inputArray = new int[a.Length];
                a.CopyTo(inputArray, 0);
                Array.Sort(inputArray);
                for (int x = 0; x < inputArray.Length; x++)
                {
                    int complement = searchValue - inputArray[x];
                    int searchedIndex = BinarySearch(inputArray, 0, inputArray.Length - 1, complement);
                    if (searchedIndex >= 0)
                    {
                        return inputArray[x];
                    }
                }
                return -1;
            }

            static int BinarySearch(int[] a, int leftStart, int rightEnd, int searchValue)
            {
                int output = -1;
                if (leftStart >= rightEnd) return -1;

                int leftEndRightStart = (rightEnd + leftStart) / 2;
                if (searchValue == a[leftEndRightStart]) { return leftEndRightStart; }
                else if (searchValue < a[leftEndRightStart]) output = BinarySearch(a, leftStart, leftEndRightStart, searchValue);
                else output = BinarySearch(a, leftEndRightStart + 1, rightEnd, searchValue);
                return output;
            }

            public static void DFSConnectedCellInAGrid(string[] args, TextBox txtConsoleOutput)
            {
                int n = Convert.ToInt32(args[0]);//Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(args[1]); //Convert.ToInt32(Console.ReadLine());
                List<KeyValuePair<int, int>> visitedCells = new List<KeyValuePair<int, int>>();
                int[][] grid = new int[n][];
                for (int row = 0; row < n; row++)
                {
                    int index = row + 2;
                    string[] grid_temp = args[index].Split();//Console.ReadLine().Split(' ');
                    grid[row] = Array.ConvertAll(grid_temp, Int32.Parse);
                }

                int prevCount = 0;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        int count = 0;
                        KeyValuePair<int, int> pair = new KeyValuePair<int, int>(row, col);
                        visitedCells.Add(pair);
                        if (grid[row][col] == 1)
                        {
                            count++;
                            SearchConnectedCells(grid, n, m, row, col, visitedCells, ref count);
                        }

                        if (count > prevCount)
                            prevCount = count;
                    }
                }
                //Console.WriteLine($"{prevCount}");
                txtConsoleOutput.Text += $"{Environment.NewLine}{prevCount}";
            }

            static void SearchConnectedCells(int[][] grid, int rows, int cols, int rowIndex, int colIndex, IList<KeyValuePair<int, int>> visitedCells, ref int count)
            {
                int tempColIndex;
                KeyValuePair<int, int> pair;

                int tempRowIndex = rowIndex;
                tempColIndex = colIndex - 1;
                if (tempColIndex >= 0)
                {
                    pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                    if (!visitedCells.Contains(pair))
                    {
                        visitedCells.Add(pair);
                        if (grid[tempRowIndex][tempColIndex] == 1)
                        {
                            count++;
                            SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                        }
                    }
                }

                tempColIndex = colIndex + 1;
                if (tempColIndex < cols)
                {
                    pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                    if (!visitedCells.Contains(pair))
                    {
                        visitedCells.Add(pair);
                        if (grid[tempRowIndex][tempColIndex] == 1)
                        {
                            count++;
                            SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                        }
                    }
                }

                tempRowIndex = rowIndex - 1;
                if (tempRowIndex >= 0)
                {
                    tempColIndex = colIndex;
                    pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                    if (!visitedCells.Contains(pair))
                    {
                        visitedCells.Add(pair);
                        if (grid[tempRowIndex][tempColIndex] == 1)
                        {
                            count++;
                            SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                        }
                    }

                    tempColIndex = colIndex - 1;
                    if (tempColIndex >= 0)
                    {
                        pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                        if (!visitedCells.Contains(pair))
                        {
                            visitedCells.Add(pair);
                            if (grid[tempRowIndex][tempColIndex] == 1)
                            {
                                count++;
                                SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                            }
                        }
                    }

                    tempColIndex = colIndex + 1;
                    if (tempColIndex < cols)
                    {
                        pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                        if (!visitedCells.Contains(pair))
                        {
                            visitedCells.Add(pair);
                            if (grid[tempRowIndex][tempColIndex] == 1)
                            {
                                count++;
                                SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                            }
                        }
                    }
                }

                tempRowIndex = rowIndex + 1;
                if (tempRowIndex < rows)
                {
                    tempColIndex = colIndex;
                    pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                    if (!visitedCells.Contains(pair))
                    {
                        visitedCells.Add(pair);
                        if (grid[tempRowIndex][tempColIndex] == 1)
                        {
                            count++;
                            SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                        }
                    }

                    tempColIndex = colIndex - 1;
                    if (tempColIndex >= 0)
                    {
                        pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                        if (!visitedCells.Contains(pair))
                        {
                            visitedCells.Add(pair);
                            if (grid[tempRowIndex][tempColIndex] == 1)
                            {
                                count++;
                                SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                            }
                        }
                    }

                    tempColIndex = colIndex + 1;
                    if (tempColIndex < cols)
                    {
                        pair = new KeyValuePair<int, int>(tempRowIndex, tempColIndex);
                        if (!visitedCells.Contains(pair))
                        {
                            visitedCells.Add(pair);
                            if (grid[tempRowIndex][tempColIndex] == 1)
                            {
                                count++;
                                SearchConnectedCells(grid, rows, cols, tempRowIndex, tempColIndex, visitedCells, ref count);
                            }
                        }
                    }
                }
            }
        }

        public class Techniques
        {
            public static void TimeComplexityPrimality(string[] args, TextBox txtConsoleOutput)
            {
                int p = Convert.ToInt32(args[0]);//Convert.ToInt32(Console.ReadLine());
                for (int a0 = 1; a0 < args.Length; a0++)
                {
                    int n = Convert.ToInt32(args[a0]);//Convert.ToInt32(Console.ReadLine());
                    if (CheckPrimality(n))
                    {
                        //Console.WriteLine("Prime");
                        txtConsoleOutput.Text += $"{Environment.NewLine}Prime";
                    }
                    else
                    {
                        txtConsoleOutput.Text += $"{Environment.NewLine}Not Prime";//Console.WriteLine("Not prime");

                    }
                }
            }

            static bool CheckPrimality(int inputNumber)
            {
                if (inputNumber > 1 && (inputNumber & 1) != 0)
                {
                    int higherLimit = (int)Math.Sqrt(inputNumber);
                    for (int x = 3; x <= higherLimit; x += 2)
                    {
                        if (inputNumber % x == 0) return false;
                    }
                    return true;
                }
                else return inputNumber == 2;

            }

            public static void FibonacciNumbers(string[] args, TextBox txtConsoleOutput)
            {
                int n = Convert.ToInt32(args[0]);//Convert.ToInt32(Console.ReadLine());
                txtConsoleOutput.Text += Fibonacci(n);//Console.WriteLine(Fibonacci(n));
            }

            static int Fibonacci(int n)
            {
                if (n == 0 || n == 1) return n;
                int fibSum = Fibonacci(n - 1) + Fibonacci(n - 2);
                return fibSum;
            }

            public static void RecursionDavisStaircase(string[] args, TextBox txtConsoleOutput)
            {
                int s = Convert.ToInt32(args[0]);//Convert.ToInt32(Console.ReadLine());
                for (int a0 = 1; a0 < args.Length; a0++)
                {
                    int n = Convert.ToInt32(args[a0]);//Convert.ToInt32(Console.ReadLine());
                    int[] memoizationArr = new int[n];
                    int x = NoOfWaysToClimbStairs(n - 1, memoizationArr) + NoOfWaysToClimbStairs(n - 2, memoizationArr) + NoOfWaysToClimbStairs(n - 3, memoizationArr);
                    txtConsoleOutput.Text += $"{Environment.NewLine}{x}";//Console.WriteLine(x);
                }
            }

            static int NoOfWaysToClimbStairs(int n, int[] memoizationArr)
            {
                if (n < 0) return 0;
                if (n == 0 || n == 1) return 1;
                if (n == 2) return 2;
                if (n == 3) return 4;
                if (memoizationArr[n] != 0) return memoizationArr[n];

                memoizationArr[n] = NoOfWaysToClimbStairs(n - 1, memoizationArr) + NoOfWaysToClimbStairs(n - 2, memoizationArr) + NoOfWaysToClimbStairs(n - 3, memoizationArr);
                return memoizationArr[n];
            }

            public static void BitManipulationLonelyInteger(string[] args, TextBox txtConsoleOutput)
            {
                int n = Convert.ToInt32(args[0]);//Convert.ToInt32(Console.ReadLine());
                string[] a_temp = args[1].Split();//Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                int result = 0;
                a.ToList().ForEach(x => { result ^= x; });
                txtConsoleOutput.Text += $"{result}";//Console.WriteLine(result);
            }
        }
    }
}
