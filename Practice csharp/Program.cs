using System;

// The topic I cover here is:: 
//string related all method






namespace Pracice
{
    class program
    {

        void print(int a)
        {
            if (a == 1)
                Console.WriteLine("console pritned");

            int f = 5;
            string s = Convert.ToString(f);
          //  Console.WriteLine(s.GetType());
            double x = Math.Pow(2, 41);
            //Console.WriteLine(x);

            //Console.WriteLine(double.IsInfinity(x));
            string adress = "My name Is Muajaidul islam tahmid. i will be a great programmer in the universe";
            Console.WriteLine(adress);
            char[] separator = { ' ','.' };

            string[] str=adress.Split(separator,5, StringSplitOptions.RemoveEmptyEntries);

            string strings="";
            foreach(var y in str)
            {
                Console.WriteLine(y);
                strings =strings+ y;
            }
            //strings.Reverse();
            strings=strings.Remove(1,15);

            Console.WriteLine("removed Sting is : : " +strings);

            Console.WriteLine("Ekhane Ki kora hocceh"+strings.IndexOf(str[4])+" : : : " + str[4]);

            Console.WriteLine("Adress :: size :: "+adress.Length);

            Console.WriteLine("*************************************************");
            foreach(var i in adress.Split(separator,StringSplitOptions.RemoveEmptyEntries))
            {
                Console.WriteLine(i);
            }

            char ch = Convert.ToChar(97);
            Console.WriteLine(ch);

            Console.WriteLine($"AMin tumi{s} okiiiti {f}");
        }

        string reverse(string s)
        {
            char[] st = s.ToCharArray();
            Array.Reverse(st);
            return new string(st);
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Dhaka");


            program program = new program();
           Console.WriteLine( program.reverse("AKasher oi nile vavchi jabo chole"));
           

            program.print(1);



        }

    }
}