using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DubnaParallel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cтруктура для хранения статистики по сортировке
        public struct SortResult
        {
            public ulong Comparisons;
            public ulong Swaps;

            public SortResult(ulong comparisons, ulong swaps)
            {
                Comparisons = comparisons;
                Swaps = swaps;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelForStatistics.Text = string.Empty;
            int arraySize = int.Parse(this.arraySize.Text);
            int minRange = int.Parse(startRange.Text);
            int maxRange = int.Parse(endRange.Text);

            int[] array = GenerateArray(arraySize, minRange, maxRange);
            initArray.Items.Clear();
            sortedArray.Items.Clear();
            initArray.Items.AddRange(array.Select(x => x.ToString()).ToArray());

            SortAndDisplay(array, "BubbleSort");
            SortAndDisplay(array, "QuickSort");
            SortAndDisplay(array, "InsertionSort");
        }

        // Функция генерации массива
        private int[] GenerateArray(int size, int min, int max)
        {
            Random random = new Random();
            return Enumerable.Range(0, size).Select(x => random.Next(min, max + 1)).ToArray();
        }

        // Функция выполнения, сбора статистики по определенному алгоритму сортировки
        private void SortAndDisplay(int[] originalArray, string algorithm)
        {
            SortResult result;
            int[] arrayToSort = (int[])originalArray.Clone();
            Thread sortThread = new Thread(() =>
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                switch (algorithm)
                {
                    case "BubbleSort":
                        result = BubbleSort(arrayToSort);
                        break;
                    case "QuickSort":
                        result = QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
                        break;
                    case "InsertionSort":
                        result = InsertionSort(arrayToSort);
                        break;
                    default:
                        throw new Exception("invalid algorithm");
                }
                // Замер длительности выполнения сортировки
                stopwatch.Stop();

                this.Invoke((MethodInvoker)delegate
                {
                    if (sortedArray.Items.Count == 0)
                    {
                        // Добавление отсортированного массива
                        sortedArray.Items.AddRange(arrayToSort.Select(x => x.ToString()).ToArray());
                    }
                    // Добавление статистики по выполнению сортировки
                    labelForStatistics.Text += $"{algorithm} completed in {stopwatch.ElapsedMilliseconds} ms with {result.Comparisons} comparisons and {result.Swaps} swaps.\n";
                });
            });
            // Запуск параллельного процесса
            sortThread.Start();
        }

        // Функция сортировки пузырьком
        private SortResult BubbleSort(int[] array)
        {
            ulong comparisons = 0;
            ulong swaps = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    comparisons++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swaps++;
                    }
                }
            }
            return new SortResult(comparisons, swaps);
        }

        // Функция быстрой сортировки
        private SortResult QuickSort(int[] array, int low, int high)
        {
            ulong comparisons = 0;
            ulong swaps = 0;
            QuickSortInternal(array, low, high, ref comparisons, ref swaps);
            return new SortResult(comparisons, swaps);
        }

        private void QuickSortInternal(int[] array, int low, int high, ref ulong comparisons, ref ulong swaps)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high, ref comparisons, ref swaps);
                QuickSortInternal(array, low, pivot - 1, ref comparisons, ref swaps);
                QuickSortInternal(array, pivot + 1, high, ref comparisons, ref swaps);
            }
        }

        private int Partition(int[] array, int low, int high, ref ulong comparisons, ref ulong swaps)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                comparisons++;
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    swaps++;
                }
            }
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            swaps++;
            return i + 1;
        }

        // Функция сортировки вставками
        private SortResult InsertionSort(int[] array)
        {
            ulong comparisons = 0;
            ulong swaps = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    comparisons++;
                    array[j + 1] = array[j];
                    swaps++;
                    j = j - 1;
                }
                array[j + 1] = key;
                if (i != j + 1) swaps++;
            }
            return new SortResult(comparisons, swaps);
        }
    }
}
