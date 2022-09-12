using System;
using System.Runtime.Intrinsics.X86;

namespace bubblesort
{
   
   
    class program
    {
        static void bblsort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void selectionsort(int[] a)
        {
            for(int i = 0; i < a.Length - 1; i++)
            {
                int min = i;
                for(int j= i+1; j < a.Length ; j++)
                {
                    if(a[j] < a[min])
                    {
                        min = j;
                    }
                }

                int temp= a[min];
                a[min] = a[i];
                a[i] = temp;
            }
        }
        static void  Main(string[] args)
        {
            /*
            int[] arr = { 12, 5, 1, 47, 58, 10, 0, 14 };
            bblsort(arr);
            Console.WriteLine("Bubble Sort O(n2)");
           foreach (int i in arr) Console.Write(i+" ");
            int[] arr2 = { 1,12,5,4,55,12,0,0 };
            selectionsort(arr2);
            Console.WriteLine();
            Console.WriteLine("selction Sort O(n2)");
            foreach (int i in arr2) Console.Write(i + " ");
            */

          
            int tc;
           
                int n= Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[100000];
                for(int i=0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                }
                int temp = 0;
                for (int i = n-1; i >=0; i--)
                {
                    if (arr[i] == -1) temp = i;
                }
                int cnt=0;
                int minus = 0;
                for (int i = 0; i <= temp; i++)
                {
                    if (arr[i] > 0) cnt++;
                    else minus++;
                }
                Console.WriteLine(cnt);

            
           




        }
    }
}