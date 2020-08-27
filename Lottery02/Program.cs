using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery02
{

    class Program

    {

        static void Main(string[] args)

        {

            List<KeyValuePair<long, double>> elements = new List<KeyValuePair<long, double>>();



            elements.Add(new KeyValuePair<long, double>(1, 0.01));



            elements.Add(new KeyValuePair<long, double>(2, 0.04));



            elements.Add(new KeyValuePair<long, double>(3, 0.02));



            elements.Add(new KeyValuePair<long, double>(4, 0.03));



            elements.Add(new KeyValuePair<long, double>(5, 0.9));



            //概率计算

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



            Random random = new Random();



            long selectedElement = 0;



            while (true)

            {

                //连抽20次已查看中奖分布情况，5为不中奖

                for (int n = 0; n < 20; n++)

                {

                    double diceRoll = random.NextDouble();



                    double cumulative = 0.0;



                    for (int i = 0; i < elements.Count; i++)

                    {

                        cumulative += elements[i].Value;



                        if (diceRoll <= cumulative)

                        {

                            selectedElement = elements[i].Key;



                            break;

                        }

                    }



                    Console.WriteLine(selectedElement);

                }



                string read = Console.ReadLine();



                if (read == "e")

                {

                    break;

                }

            }



            Console.WriteLine(selectedElement);



            Console.ReadLine();

        }

    }

}
