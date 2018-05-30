using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades, int n)
    {
        List<int> lst = new List<int>();
        int tot = 0;
        foreach (var g in grades)
        {
            if (g >= 38 && g % 5 != 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    tot = g + i;
                    if(tot % 5 == 0)
                    {
                        if (tot - g >= 3)
                        {
                            lst.Add(g);
                            break;
                        }
                        else
                        {
                            lst.Add(tot);
                            break;
                        }
                    }
                   
                }
            }
            else if(g < 38)
            {
                lst.Add(g);
            }
            else
            {
                lst.Add(g);
            }
        }
        return lst.ToArray();
    }

    static void Main(string[] args)
    {
       
        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int[n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades, n);

        }
}
