using System;

class Program
{
    //Function that take in a int parameter 
    public int Fibonnaci(int number)
    {
        //if statement that prevents a negative number input
        if (number < 1) return 0;
        // if statements that begins the fibonnaci
        if (number == 1) return 0;
        if (number == 2) return 1;
        // The function returns a recursive to create the fibonnaci
        return Fibonnaci(number -1) + Fibonnaci(number -2);
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine(p.Fibonnaci(30));
    }
}