using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSolution.Sorting
{
    public static class Sorts
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Hoán đổi
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                // Nếu không có hoán đổi nào, mảng đã được sắp xếp
                if (!swapped)
                    break;
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int current = arr[i];
                int j = i - 1;

                // Dịch các phần tử lớn hơn sang phải
                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current; // Chèn phần tử vào đúng vị trí
            }
        }
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Tìm chỉ số phần tử nhỏ nhất từ i đến cuối
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Hoán đổi nếu cần
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}
