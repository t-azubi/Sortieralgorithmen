using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestMalen
{
    public partial class Form1 : Form
    {
        Chart chart = new Chart();
        int[] unsorted;
        public Form1()
        {

            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            int y;
            int.TryParse(textBox1.Text, out y);
            chart1.Series.Clear();
            var listIndex = listBox1.SelectedIndex;
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Stock

            };
            chart1.ResetAutoValues();
            this.chart1.Series.Add(series1);
            int[] blub = new int[y];
            if (listIndex == 0)
            {
                blub = bestCase(y);
            }
            else if (listIndex == 1)
            {
                blub = averageCase(y);
            }
            else if (listIndex ==2)
            {
                blub = worstCase(y);
            }
            for (int i = 0; i < y; i++)
            {
                series1.Points.AddXY(i, blub[i]);
            }
            chart1.Invalidate();
            chart = chart1;
            unsorted = blub;
        }
        private int[] averageCase(int y)
        {
            Random ran = new Random();
            int[] iInput = new int[y];
            for (int i = 0; i < y; i++)
            {
                iInput[i] = i + 1;
            }
            for (int i = 0; i < y; i++)
            {
                var random = ran.Next(0, y);
                var temp = iInput[i];
                iInput[i] = random;
                iInput[random] = temp;
            }
            return iInput;
        }
        private int[] worstCase(int y)
        {
            List<int> List = new List<int>();
            for (int i = 0; i < y; i++)
            {
                List.Add(i);
            }
            List.Reverse();
            return List.ToArray();
        }
        private int[] bestCase(int y)
        {
            List<int> List = new List<int>();
            for (int i = 0; i < y; i++)
            {
                List.Add(i);
            }
            return List.ToArray();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int y;
            int.TryParse(textBox1.Text, out y);
            Sorting sort = new Sorting();
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Stock
            };
            this.chart1.Series.Add(series1);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var array = sort.BubbleSortMethod(unsorted);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Ticks / 10000000,
                ts.Ticks / 100000, ts.Ticks / 1000, ts.Ticks / 10);
            textBox2.Text = elapsedTime;
            for (int i = 0; i < y; i++)
            {
                series1.Points.AddXY(i, array[i]);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int y;
            int.TryParse(textBox1.Text, out y);
            Sorting sort = new Sorting();
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Stock
            };
            this.chart1.Series.Add(series1);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var array = sort.QuickSortMethod(unsorted);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Ticks / 10000000,
                ts.Ticks / 100000, ts.Ticks / 1000, ts.Ticks / 10);
            textBox2.Text = elapsedTime;
            for (int i = 0; i < y; i++)
            {
                series1.Points.AddXY(i, array[i]);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int y;
            int.TryParse(textBox1.Text, out y);
            Sorting sort = new Sorting();
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Stock
            };
            this.chart1.Series.Add(series1);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var array = sort.MergeSort(unsorted);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                 ts.Ticks / 10000000,
                 ts.Ticks / 100000, ts.Ticks / 1000, ts.Ticks / 10);
            textBox2.Text = elapsedTime;
            for (int i = 0; i < y; i++)
            {
                series1.Points.AddXY(i, array[i]);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int y;
            int.TryParse(textBox1.Text, out y);
            Sorting sort = new Sorting();
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Stock
            };
            this.chart1.Series.Add(series1);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var array = sort.ShellSort(unsorted);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Ticks / 10000000,
                ts.Ticks / 100000, ts.Ticks / 1000, ts.Ticks / 10);
            textBox2.Text = elapsedTime;
            for (int i = 0; i < y; i++)
            {
                series1.Points.AddXY(i, array[i]);
            }
        }

    }

    class Sorting
    {
        public int[] BubbleSortMethod(int[] iInput)
        {

            for (int i = 0; i < iInput.Length; i++)
            {
                for (int j = 0; j < iInput.Length - 1; j++)
                {
                    if (iInput[j] > iInput[j + 1])
                    {
                        int temp = iInput[j];
                        iInput[j] = iInput[j + 1];
                        iInput[j + 1] = temp;
                    }
                }
            }
            return iInput;
        }
        public int[] QuickSortMethod(int[] iInput)
        {
            iInput = Quicksort(iInput, 0, iInput.Length - 1);
            return iInput;
        }

        public static int[] Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            var pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    var tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }

            return elements;
        }
        public int[] MergeSortStart(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSortStart(input, low, middle);
                MergeSortStart(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
            return input;
        }

        public int[] MergeSort(int[] input)
        {
            input = MergeSortStart(input, 0, input.Length - 1);
           return input;
        }

        private int[] Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
            return input;
        }
        public int[] ShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = array[j];

                    while (j - gap >= 0 && temp < array[j - gap])
                    {
                        array[j] = array[j - gap];
                        j = j - gap;
                    }

                    array[j] = temp;
                }

                gap = gap / 2;
            }
            return array;
        }
    }
}
