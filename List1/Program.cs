using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Samuel");
            list.Add("Sampeur");
            list.Add("Louis");
            list.Add("Pardieu");
            list.Insert(2, "Marcos");

            foreach (string element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); /// Lambda function
            Console.WriteLine("First item in list begin with 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last item in list begin with 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.ReadLine();
        }
    }
}
