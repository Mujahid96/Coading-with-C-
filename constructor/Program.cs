using System;

namespace constructor;

public class constra
{
    public static int c = 1;
    static constra()
    {
        c++;
        Console.WriteLine("static constractor : : : {0}",c);
        
    }
    /*
    private constra()
    {
      
    }
    */
    public static int play()
    {
        return 5;

    }
}
class program
{
static void Main(string[] args)
    {
        constra con = new constra();
        constra cona = new constra();
        constra conaa = new constra();


        Console.WriteLine("Value is {0} ", constra.play());

    }

}
