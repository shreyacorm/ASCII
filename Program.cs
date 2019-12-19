using System;
using System.Collections.Generic;
using System.Linq;

namespace TestAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter then number of test cases");
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter the type");
            string type = "";
           // type = Console.ReadLine();
            while (!String.IsNullOrWhiteSpace(type = Console.ReadLine()))
            {
                //but here it seems to be an infinite loop 
                List<int> types = new List<int>();
                for (var i = 0; i < type.Length; i++)
                {
                    for (var j = 0; j < i; j++)
                    {
                        if (type[i] == type[j])
                        {
                            types.Add((int)type[i]);
                        }
                    }
                }
                var arryy = types.Distinct().ToArray();

                if (arryy.Count() == 1)
                {
                    Console.WriteLine(Convert.ToChar(arryy[0]));
                }
                else
                {
                    int prev = 0;
                    foreach (var current in arryy.OrderBy(x => x))
                    {
                        if (prev > 0 && prev < current)
                        {
                            Console.WriteLine(Convert.ToChar(prev));
                            // do stuff
                        }
                        // don't forget the next row!
                        prev = current;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
