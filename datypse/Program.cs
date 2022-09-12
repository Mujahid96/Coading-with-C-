using System;

namespace datatype
{
    enum who{
        ami,
        tumi, 
        she,
        ttttttttttttttttttttttttttttttttt,
        tem =12
    }
class program
    {
         static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
           Console.WriteLine(dateTime.ToString());
            byte byt = 120;
            sbyte sbyt = 127;
            Console.WriteLine(sbyt);
            decimal dec = 70000000000000000000000000000M;
            long x= 9223372036854775807;
            float f = 3.5f;
            double d = 3.6d;
            double de = Math.Pow(2, 22); // return maybe double allways
            Console.WriteLine(de);
            Console.WriteLine(x);

           
          
            Console.WriteLine(who.ttttttttttttttttttttttttttttttttt);
            Console.WriteLine(Convert.ToInt32(who.tem));
            
            Console.WriteLine(5.GetType());





        }
      
    }
}