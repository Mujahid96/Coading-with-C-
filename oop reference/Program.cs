using System;
using System.Xml.Linq;
using oop;

namespace oop_reference
{

    public class sample : student
    {
        public void dekhao()
        {
            Console.WriteLine("Student info");
            Console.WriteLine(Id);
            Console.WriteLine(name);
            Console.WriteLine(univrsity);
            Console.WriteLine(dept);
            Console.WriteLine(ad);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            sample sm=new sample();
            sm.display;

        }
    }
  
}