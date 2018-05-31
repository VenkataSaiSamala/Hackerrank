using System;

class Solution
{

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int ordist, apdist = 0;
        int apcount = 0;
        int orcount = 0;
        foreach(var ap in apples)
        {
            if (ap > 0)
            {
                apdist = a + ap;
                if (apdist >= s && apdist <= t)
                {
                    apcount++;
                }
            }
        }
        foreach(var or in oranges)
        {
            if(or < 0)
            {
                ordist = b + or;
                if (ordist >= s && ordist <= t)
                {
                    orcount++;
                }
            }
        }
        Console.WriteLine(apcount);
        Console.WriteLine(orcount);
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
