using System.IO;
using System;

class Solution
{

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        string s = "";
        int c1 = 0;
        int c2 = 0;
        for (int i = 0; i < 10000; i++)
        {
            x1 += v1;
            c1++;
            x2 += v2;
            c2++;
            if (x1 == x2 && c1 == c2)
                s = "YES";
                break;
        }
        if (s != "YES")
            s = "NO";
        return s;
    }

    static void Main(string[] args)
    {
        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
