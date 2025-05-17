using System;
using System.IO;
using System.Linq;


public class HelloWorld
{
    static public void Main()
    {
        String line;
        String A;
        A = Console.ReadLine();
        String P;
        P = Console.ReadLine();

        int out_ = count_like_dislike(A, P);
        Console.Out.WriteLine(out_);
    }

    static int count_like_dislike(String A, String P)
    {
        int count = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == P[i])
            { 
                count++;
            }
        }
        return count;

    }

}