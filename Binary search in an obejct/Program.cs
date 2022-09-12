using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.Arm;

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
            if (x.id > y.id)
            {
                return 1;
            }
            else if (x.id < y.id)
            {
                return -1;
            }
            else return 0;

            //return String.Compare(x.Name,y.Name);
        }

    }




    
    class porgram
    {
        static int binarysearch(List<student> stud , int low, int high, int value) // No Parameter  
        {


            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                
                if (stud[mid].id == value)
                    return mid;

             
                if (stud[mid].id > value)
                    return binarysearch(stud, low, mid - 1, value);

               
                return binarysearch(stud, mid + 1, high, value);
            }

            return -1;
        }

        static void Main(string[] args)
        {
            student st1 = new student();
            st1.id = 181400096;

            List<student> st = new List<student>() { st1};
            
            st.Add(new student { id = 181400095, Name = "Ahsan", Grade = 3.24 });
            st.Add(new student { id = 181400054, Name = "Akash", Grade = 3.80 });
            st.Add(new student { id = 181400087, Name = "Rahim", Grade = 3.11 });
            st.Add(new student { id = 181400014, Name = "sabbir", Grade = 3.04 });
            st.Add(new student { id = 181400070, Name = "arif", Grade = 3.40 });
            st.Add(new student { id = 181400010, Name = "Abir", Grade = 3.14});
            st.Add(new student { id = 181400043, Name = "Mona", Grade = 3.70});
            st.Add(new student { id = 181400073, Name = "Rasheed", Grade = 3.12 });

            //student v = new student() { id = 181400011, Name = "Ony", Grade = 3.72 };
            foreach (var student in st)
                Console.WriteLine("Roll Number : " + student.id + " " + "Name : " + student.Name + " " + "Grade : " + student.Grade);

            //sortobj obj = new sortobj();
            //st.Sort(obj);

            st.Sort(new sortobj());
            Console.WriteLine();
            foreach (var student in st)
                Console.WriteLine("Roll Number : " + student.id + " " + "Name : " + student.Name + " " + "Grade : " + student.Grade);
           



            //st.Reverse();
            //Console.WriteLine();



            //foreach (var student in st)
            //    Console.WriteLine("Roll Number : " + student.id + " " + "Name : " + student.Name + " " + "Grade : " + student.Grade);

            int find_id = 181400096;

            int result = binarysearch(st, 0, st.Count - 1, find_id);
            Console.WriteLine("Index of searched list {0}",result+1);

            //object comparer = new { id = 181400096 };
            //student studentInfo = st?.First(f=>f.id == 181400096);
            //var resultTest = st.BinarySearch(st1);
            //Console.WriteLine(resultTest);

            //int rem = st.BinarySearch(st1, comparer);
            //Console.WriteLine(rem);
            //Console.WriteLine("\nRoll Number : " + st[result].id + " " + "Name : " + st[result].Name + " " + "Grade : " + st[result].Grade);


        }
    }
}
