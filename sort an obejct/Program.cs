using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace sortobject
{

    public class student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
    }


public class sortobj : IComparer<student>
    {

        public int Compare(student x, student y)
        {
            if (x.Grade > y.Grade)
            {
                return 1;
            }
            else if (x.Grade < y.Grade)
            {
                return -1;
            }
            else return 0;

            //return String.Compare(x.Name,y.Name);
        }

    }

   


    class porgram
    {
        static void Main(string[] args)
        {
            List<student> st = new List<student>()
            {
                new student(){id=181400096,Name="Tahmid",Grade=3.94},
                  new student(){id=181400094,Name="Mahin",Grade=3.1},
                    new student(){id=1814000112,Name="Atiq",Grade=3.87},
                      new student(){id=181400011,Name="Ony",Grade=3.72},
                        new student(){id=181400015,Name="Arif",Grade=3.38},
                          new student(){id=181400010,Name="Kamal",Grade=3.40},
            };
            foreach (var student in st)
                Console.WriteLine("Roll Number : " + student.id + " " + "Name : " + student.Name + " " + "Grade : " + student.Grade);

            //sortobj obj = new sortobj();
            //st.Sort(obj);

            st.Sort(new sortobj());
            Console.WriteLine();



            foreach (var student in st)
                Console.WriteLine("Roll Number : " + student.id + " " + "Name : " + student.Name + " " + "Grade : " + student.Grade);

            st.Reverse();
            Console.WriteLine();



            foreach (var student in st)
                Console.WriteLine("Roll Number : " + student.id + " " + "Name : " + student.Name + " " + "Grade : " + student.Grade);


        }
    }
}
