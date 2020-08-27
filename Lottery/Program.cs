using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{

    class Program

    {

        static void Main(string[] args)

        {

            List<KeyValuePair<long, double>> elements = new List<KeyValuePair<long, double>>();





            elements.Add(new KeyValuePair<long, double>(0, 0.000002));





            elements.Add(new KeyValuePair<long, double>(1, 0.000004));





            elements.Add(new KeyValuePair<long, double>(2, 0.0001));





            elements.Add(new KeyValuePair<long, double>(3, 0.0001));





            elements.Add(new KeyValuePair<long, double>(4, 0.0003));





            elements.Add(new KeyValuePair<long, double>(5, 0.000004));





            elements.Add(new KeyValuePair<long, double>(6, 0.000004));





            elements.Add(new KeyValuePair<long, double>(7, 0.00016));





            elements.Add(new KeyValuePair<long, double>(8, 0.000008));





            elements.Add(new KeyValuePair<long, double>(9, 0.00012));





            elements.Add(new KeyValuePair<long, double>(10, 0.0));





            elements.Add(new KeyValuePair<long, double>(11, 0.999198));





            Dictionary<long, string> prize = new Dictionary<long, string>();





            prize.Add(0, @"奖品1");





            prize.Add(1, @"奖品2");





            prize.Add(2, @"奖品3");





            prize.Add(3, @"奖品4");





            prize.Add(4, @"奖品5");





            prize.Add(5, @"奖品6");





            prize.Add(6, @"奖品7");





            prize.Add(7, @"奖品8");





            prize.Add(8, @"奖品9");





            prize.Add(9, @"奖品10");





            prize.Add(10, @"奖品11");





            prize.Add(11, @"谢谢参与！");





            //求出概率基数





            long basicNumber = 0;





            double[] array = new double[elements.Count];





            int m = 0;





            foreach (KeyValuePair<long, double> item in elements)

            {

                array[m] = item.Value;





                m++;

            }





            basicNumber = ToolMethods.GetBaseNumber(array);









            //判断设置的概率

            double allRate = 0;





            foreach (var item in elements)

            {

                allRate += item.Value;

            }





            if (allRate != 1)

            {

                Console.WriteLine("奖品概率设置错误！");





                Console.WriteLine(allRate);





                Console.ReadLine();





                return;

            }





            //抽奖

            Random random = new Random();





            long selectedElement = 0;





            while (true)

            {

                for (int n = 0; n < 20; n++)

                {

                    long diceRoll = ToolMethods.GetRandomNumber(random, 1, basicNumber);





                    long cumulative = 0;





                    for (int i = 0; i < elements.Count; i++)

                    {

                        cumulative += (long)(elements[i].Value * basicNumber);





                        if (diceRoll <= cumulative)

                        {

                            selectedElement = elements[i].Key;





                            break;

                        }

                    }





                    Console.WriteLine(prize[selectedElement]);

                }





                string read = Console.ReadLine();





                if (read == "e")

                {

                    break;

                }

            }





            Console.ReadLine();

        }

    }

}
