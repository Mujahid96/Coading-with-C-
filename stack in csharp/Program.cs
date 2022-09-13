using System;
namespace stack
{
    public class stack{
      private int[] arr;
        private int top;
        private int max;

       public stack(int size)
        {
            arr = new int[size];
            top = -1;
            max = size;
        }
        public void push(int value)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack is full and you can not insert to the stack");
            }
            else
            {
                top++;
                arr[top] = value;
            }

        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                
                arr[top--] = 0;
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
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }




    class program
    {

       static void Main(string[] args)
        {
            Console.WriteLine("Stack in C#");
            stack st = new stack(5);
            st.push(25);
            st.push(14);
            st.push(147);
            st.push(785);
            st.push(987);
            st.push(1477);
            st.print();
            Console.WriteLine("*************");
            st.pop();
            st.pop();
            st.pop();
          
            st.print();

            st.peek();
        }
    }
}