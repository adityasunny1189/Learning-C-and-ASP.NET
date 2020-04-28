using System;
using System.Collections.Generic;

namespace newDir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Program!");
            Console.WriteLine("Enter the size of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int> {};
            getInput(arr, size);
            printArray(arr);
            Console.WriteLine("Enter Element To Search: ");
            int elementToSearch = Convert.ToInt32(Console.ReadLine());
            bool elementFound = binarySearch(arr, elementToSearch, size);
            if(elementFound) {
                Console.WriteLine("Element Found In The Array");
            } else {
                Console.WriteLine("Element Not Found In The Array");
            }
        }

        static void getInput(List<int> arr, int size) {
            for(int i = 0; i < size; i++) {
                Console.WriteLine("Enter the Element: ");
                int num = Convert.ToInt32(Console.ReadLine());
                arr.Add(num);
            }
        }

        static void printArray(List<int> arr) {
            Console.WriteLine("The Array Content is: ");
            foreach(var no in arr) {
                Console.WriteLine(no);
            }
        }

        static bool binarySearch(List<int> arr, int num, int size) {
            int start = 0;
            int end = size - 1;
            while(start < end) {
                int mid = (start + end) / 2;
                if(num == arr[mid]) {
                    return true;
                }
                else if(num > arr[mid]) {
                    start = mid + 1;
                }
                else {
                    end = mid - 1;
                }
            }
            return false;
        }
    }
}
