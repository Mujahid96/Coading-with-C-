using System;

namespace abst{
    public class table
{
    public string ab="table";
    public void display()
    {
        Console.WriteLine("Its {0} class ",ab);


    }
}

public class chair : table
{
    public string ab="Chair";
        public void display()
        {
            Console.WriteLine("Its {0} class ", ab);
        }
}


class program
{
    static void Main(string[] args)
    {

        table table = new table();
        table.display();
            chair ch = new chair();
            ch.display();
        }

}



}
