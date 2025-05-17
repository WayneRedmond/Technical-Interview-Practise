using System;
using System.Linq;

//To make factorials
public class FactorialProgram
{
    public static void Main()
    {
        int output = 1;
        int N = int.Parse(Console.ReadLine());
        for (int i = N; i > 0; i--)
        {
            output = output * i;
        }
        Console.WriteLine(output.ToString());
    }
}

//Basic input and output
//uing System;
public class IOProgram
{
    public static void Main()
    {
        int In = int.Parse(Console.ReadLine());
        string Input = Console.ReadLine();
        In = In * 2;
        Console.WriteLine(In.ToString());
        Console.WriteLine(Input.ToString());
    }
}
//Favorite Singer Reading and counting arrays
//using System;
public class FavoriteSinger
{
    public static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long[] Songs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long Singer = 0;
        long Counter = 0;
        for (int i = 0; i < N; i++)
        {
            bool alreadyCounted = false;
            for (int k = 0; k < i; k++)
            {
                if (Songs[k] == Songs[i])
                {
                    alreadyCounted = true;
                    break;
                }
            }
            if (!alreadyCounted)
            {
                long count = 0;
                for (int j = 0; j < N; j++)
                {
                    if (Songs[j] == Songs[i])
                        count++;
                }

                if (count > Counter)
                {
                    Counter = count;
                    Singer = 1;
                }
                else if (count == Counter)
                {
                    Singer++;
                }
            }
        }
        Console.WriteLine(Singer.ToString());
    }
}

//ZOOO
//using System;
//using System.Linq;
public class ZOOO
{
    public static void Main()
    {
        string Input = Console.ReadLine().ToUpper();
        int Z = 0;
        int O = 0;
        Z = Input.Count(c => c == 'Z');
        O = Input.Count(c => c == 'O');
        
        if (2 * Z == O)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

//Divisibility
//using System;
public class Divisability
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] Numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        string Output= "";
        for (int i = 0; i < N; i++)
        {
            string Number = Numbers[i].ToString();
            Output = Output + Number.Last();
        }
        if (Output.Last() == '0')
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

}


