using System;
using System.Linq;

//To make factorials
//using System;
public class FactorialProgram
{
    public static void FactorialProgramMain()
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
    public static void IOProgramMain()
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
//using System.Collections.Generic;

public class FavoriteSinger
{
    public static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long[] Songs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

        // Count frequency of each song
        Dictionary<long, long> songCount = new Dictionary<long, long>();

        for (int i = 0; i < N; i++)
        {
            if (songCount.ContainsKey(Songs[i]))
            {
                songCount[Songs[i]]++;
            }
            else
            {
                songCount[Songs[i]] = 1;
            }
        }

        // Find maximum frequency
        long maxCount = 0;
        foreach (var count in songCount.Values)
        {
            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        // Count singers with maximum frequency
        long singersWithMaxCount = 0;
        foreach (var count in songCount.Values)
        {
            if (count == maxCount)
            {
                singersWithMaxCount++;
            }
        }

        Console.WriteLine(singersWithMaxCount);
    }
}




//ZOOO
//using System;
//using System.Linq;
public class ZOOO
{
    public static void ZOOOMain()
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
    public static void DivisabilityMain()
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
    //For the time problem I had I made a cheat lol
    //public static void Main()
    //{
    //    int N = int.Parse(Console.ReadLine());
    //    int[] Numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    //    int Last = Numbers[N - 1];
    //    if (Last % 10 == 0)
    //    {
    //        Console.WriteLine("Yes");
    //    }
    //    else
    //    {
    //        Console.WriteLine("No");
    //    }
    //}

}


//using System;
public class MaximimBorders
{
    public static void MaximimBordersMain()
    {
        int t = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < t; i++)
        {
            int max = 0;
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            for (int j = 0; j < n; j++)
            {
                string line = Console.ReadLine();
                int counter = 0;
                for (int k = 0; k < m; k++)
                {
                    
                    if(line[k] == '#')
                    {
                        counter++;
                    }

                }
                if (counter > max)
                {
                    max = counter;
                }
            }
            Console.WriteLine(max.ToString());
        }
    }
}

//using System;
public class Splithouses
{
    public static void SplithousesMain()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = "";
        bool possible = true;
        for (int i = 0; i < n; i++)
        {
            if (i + 1 != n)
            {
                if (input[i] == input[i + 1] && input[i] == 'H')
                {
                    possible = false;
                    break;
                }
            }
            if (input[i] == '.')
            {
                output = output + "B";
            }
            else
            {
                output = output + "H";
            }
        }
        if (possible)
        {
            Console.WriteLine("YES");
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

//using System;
public class Ali
{
    public static void AliMain()
    {

        string input = Console.ReadLine();
        bool possible = true;
        int F = int.Parse(input[0].ToString()) + int.Parse(input[1].ToString());
        if (F%2 != 0)
        {
            possible = false;
        }
        if (input[2] == 'A'|| input[2] == 'E' || input[2] == 'I' || input[2] == 'O' || input[2] == 'U' || input[2] == 'Y')
        {
            possible = false;
        }
        int S = int.Parse(input[3].ToString()) + int.Parse(input[4].ToString());
        if (S % 2 != 0)
        {
            possible = false;
        }
        int T = int.Parse(input[4].ToString()) + int.Parse(input[5].ToString());
        if (T % 2 != 0)
        {
            possible = false;
        }
        int V = int.Parse(input[7].ToString()) + int.Parse(input[8].ToString());
        if (V % 2 != 0)
        {
            possible = false;
        }
        if (possible)
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}

//using System;
public class ToggleString
{
    public static void ToggleStringMain()
    {
        string input = Console.ReadLine();
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
            {
                output = output + char.ToLower(input[i]);
            }
            else
            {
                output = output + char.ToUpper(input[i]);
            }
        }
        Console.WriteLine(output);
    }
}

//using System;
public class FindProduct
{
    public static void FindProductMain()
    {
        const long MOD = 1000000007;
        int i = int.Parse(Console.ReadLine());
        long[] Numbers = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long answer = 1;
        for (int j = 0; j < i; j++)
        {
            answer = (answer * Numbers[j]) % MOD;
        }

        Console.WriteLine(answer);

    }
}

//using System;
public class Palindromic
{
    public static void PalindromicMain()
    {
        string S = Console.ReadLine();
        string Reverse = "";
        for (int i = S.Length - 1; i >= 0; i--)
        {
            Reverse = Reverse + S[i];
        }
        if (S == Reverse)
        {
            Console.WriteLine("YES");

        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}


//using System;
public class CountDivisors
{
    public static void CountDivisorsMain()
    {
        string[] input = Console.ReadLine().Split(' ');
        int l = int.Parse(input[0]);
        int r = int.Parse(input[1]);
        int k = int.Parse(input[2]);
        int count = 0;
        for (int i = l; i <= r; i++)
        {
            if (10 % 1 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

//using System;
public class LifeUniverseEverything
{
    public static void LifeUniverseEverythingMain()
    {
        while (true)
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 42)
            {
                break;
            }
            Console.WriteLine(N.ToString());
        }
    }
}


public class ProfilePic
{
    public static void ProfilePicMain()
    {
        int L = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int[] Picture = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (Picture[0] < L || Picture[1] < L)
            {
                Console.WriteLine("UPLOAD ANOTHER");
            }
            else if (Picture[0] == Picture[1])
            {
                Console.WriteLine("ACCEPTED");
            }
            else
            {
                Console.WriteLine("CROP IT");
            }
        }
    }
}






// Medium Level Problems Below
//Not Working Yet
//using System;
public class StepCount
{
    public static void StepCountMain()
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int Steps = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (A[i] - B[j] >= A[i])
                {
                    A[i] = A[i]- B[j];
                    Steps++;
                }
            }
        }
        Console.WriteLine(Steps.ToString());
    }
}


// Best Indexes:
//using System;
public class Index
{
    public static void IndexMain()
    {
        int Num = int.Parse(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int max = 0;
        for (int i = 0; i < Num; i++)
        {
            int sum = 0;
            for (int j = i; j < Num; j++)
            {
                if (Num - j > (j + i))
                {
                    sum = sum + A[j];
                }
            }
            Console.WriteLine(sum.ToString());
            if (sum > max)
            {
                max = sum;
            }
        }
        Console.WriteLine(max.ToString());
    }
}


