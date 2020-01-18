using System;
using System.Collections.Generic;


/// <summary>
/// HashSet is an unordered collection of unique elements. 
/// ... This collection is of the generic type collection and it is defined under System. Collections. Generic namespace. 
/// It is generally used when we want to prevent duplicate elements from being placed in the collection.
/// </summary>

namespace HashSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ConjuntoA = new HashSet<int>();
            HashSet<int> ConjuntoB = new HashSet<int>();

            ConjuntoA.Add(3);
            ConjuntoA.Add(5);
            ConjuntoA.Add(8);
            ConjuntoA.Add(9);

            ConjuntoB.Add(3);
            ConjuntoB.Add(4);
            ConjuntoB.Add(5);

            ConjuntoB.Remove(4);
            ConjuntoA.ExceptWith(ConjuntoB);
            ConjuntoA.UnionWith(ConjuntoB);
            ConjuntoA.IntersectWith(ConjuntoB);

            foreach (int conjunto in ConjuntoB)
            {
                Console.WriteLine(conjunto);
            }
            Console.WriteLine("Enter an integer number: ");
            int N = int.Parse(Console.ReadLine());

            if (ConjuntoB.Contains(N))
            {
                Console.WriteLine(N + " Belongs to the Hashset of B");
            }
            else
            {
                Console.WriteLine(N + " Does not belongs to the Hashset fo A");
            }

            Console.ReadLine();
        }
    }
}
