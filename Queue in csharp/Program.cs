using System;
namespace queue
{
    public class Queue
    {
        private int[] arr;
        private int top;
        private int front;
        private int max;

        public Queue(int size)
        {
            arr = new int[size];
            top = -1;
            front = 0;
            max = size;
        }
        public void enqueue(int value)
        {
            if (top == max - 1)
            {
                Console.WriteLine($"Stack is full and you can not insert to the stack : : {value}");
            }
            else
            {
                top++;
                arr[top] = value;
            }

        }

        public void dequeue()
        {
            if (front == top+1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine($"Dequed from front : : {arr[front]}");
              
                //Hear I delete front value from queue
                arr = arr.Skip(1).ToArray();
                Array.Resize(ref arr, 5);
                top--;

               
            }

        }

        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine(top);
                return -1;
            }
            else
            {
                Console.WriteLine($"Peek data from stack {arr[top]}");
                return arr[top];


            }
        }

       public void print()
        {
            Console.WriteLine("Array Lenght" + arr.Length);
            //  front++;
            foreach (int item in arr)
            {
                Console.WriteLine($"rest value is {item}");
            }
        }



    }




    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Stack in C#");
            Queue st = new Queue(5);
            st.enqueue(2);
            st.enqueue(5);
            st.enqueue(15);
            st.enqueue(85);
            st.enqueue(75);
            st.print();
            st.enqueue(99);
           
            //st.print();
            Console.WriteLine("*************");
            st.dequeue();
            st.print();
            st.dequeue();
            st.print();
            st.enqueue(75);
            st.print();
            st.enqueue(35);
            st.print();
            st.enqueue(14);
            st.print();
            st.enqueue(100);
            st.dequeue();
            st.print();

        }
    }
}