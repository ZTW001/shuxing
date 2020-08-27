using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 18, 20, 45, 86, 42, 65, 12, 98 ,35,47,87,52,74,63};
            for(int i = 0;i < scores.Length - 1;i++)
            {
                for (int j = 0;j <scores.Length -1-i;j++)
                {
                    if(scores[j] < scores[j + 1])
                    {
                        int temp = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = temp;
                    }
                }
            }
            for(int i = 0;i < scores.Length;i++)
            {
                Console.WriteLine(scores[i]);
            }
            Console.ReadKey();
        }
    }
}
