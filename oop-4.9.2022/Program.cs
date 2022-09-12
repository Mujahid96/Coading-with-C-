using System;
using System.Data.Common;
using System.Xml.Linq;

namespace oop
{


    public class student
    {
        /*  public int Id { get; set; }
          public string Name { get; set; }
          public int classcode { get; set; }
          public void display(){
              Console.WriteLine("Student info");
              Console.WriteLine("student id ::{0}\n student name :: {1} \n calasscode :: {2}\n", Id, Name, classcode);

   }

        public int Id = 1242;
        private string name="Azizul Haque";
        protected string univrsity = "Eastern";
        internal string dept = "Cse";
        protected internal string ad ="dhaka";
        public void display()
        {
            Console.WriteLine("Student info");

            Console.WriteLine(Id);
            Console.WriteLine(name);
            Console.WriteLine(univrsity);
            Console.WriteLine(dept);
            Console.WriteLine(ad);
            
        }*/

        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public string email { get; set; }
        public student()
        {

            email = "mujahid914919@gmail.com";

        }

        public student(int Id,string Name,int stid,string Email)
        {

            this.Id = Id;
            this.Name = Name;
            this.StudentId = stid;
            email = Email;

        }




    }
    /*
    public class info : student
    {
        public void show()
        {
            Console.WriteLine("Student info");
            Console.WriteLine(Id);
          //  Console.WriteLine(name);
            Console.WriteLine(univrsity);
            Console.WriteLine(dept);
            Console.WriteLine(ad);
        }

    }
    */




    class program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Please enter  you documents");
             student st = new student();
             st.Id = 181400096;
             st.Name = "Mujahidul Islam Tahmid";

             st.classcode = 3254;
             st.display();
             Console.ReadKey();

            student st = new student();
             st.display();
            

            info inf = new info();
            inf.show();

            inf.display();
            */

            student stt = new student();
            Console.WriteLine(stt.email);
      stt.Name = "Rahman@gmail.com";
            stt.email = "asi@gmail.com";
            Console.WriteLine(stt.email);
            student param = new student(181400096,"Tahmid",6592,"xt@gmail.com");
            Console.WriteLine(param.Id);
            Console.WriteLine(param.Name);
            Console.WriteLine(param.StudentId);

            Console.WriteLine(param.email);






        }
    }
}
