using System;


namespace codeforces
{
    class program
    {
       static void Main(string[] args)
        {
            long tc;
            tc=Convert.ToInt64(Console.ReadLine());
            while (tc!=0)
            {
                string st = Console.ReadLine();

                if (st.Length > 10)
                    Console.WriteLine("{0}{1}{2}", st[0], st.Length - 2, st[st.Length - 1]);
                else
                {
                    Console.WriteLine(st);
                }
                tc--;
            }
            
        }
    }
}