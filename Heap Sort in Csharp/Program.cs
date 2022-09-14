using System;

//Heap sort time complexity O(NlogN)

namespace heapsort
{
    class program
    {

        public static void heapify(int[] arr, int current_value_index, int last_inedex)
        {
            int leftchild = (current_value_index * 2) + 1;
            int rightchild = (current_value_index * 2) + 2;
            int maxvalue_index = current_value_index;

         

         
            // If left child is larger than root
            if (leftchild < last_inedex && arr[leftchild] > arr[maxvalue_index])
                maxvalue_index = leftchild;

            // If right child is larger than largest so far
            if (rightchild < last_inedex && arr[rightchild] > arr[maxvalue_index])
                maxvalue_index = rightchild;

           
            if (maxvalue_index> current_value_index)
            {
                int swap= arr[current_value_index];
                arr[current_value_index]= arr[maxvalue_index];
                arr[maxvalue_index]=swap;
               heapify(arr, maxvalue_index, last_inedex);

            }

           




            
        }

        static void Main(string[] args)
        {

            int[] heaparray = { 1, 12, 6, 5, 10, 3 };

            for(int i=heaparray.Length-1; i>=0; i--)
            {
                heapify(heaparray, i, heaparray.Length - 1);
            }

         
            
            for (int i =heaparray.Length - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = heaparray[0];
                heaparray[0] = heaparray[i];
                heaparray[i] = temp;

                
                heapify(heaparray, 0, i);
            }

            //printing sorted array

            foreach(int val in heaparray)
            {
                Console.Write($"{val} ");
            }

        }
    }
}