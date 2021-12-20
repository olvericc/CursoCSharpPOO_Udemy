using System;
using System.Collections.Generic;

namespace Lists {
    internal class Program {
        static void Main(string[] args) {

            // LISTS

            // creating a empty list
            List<string> l1 = new List<string>();

            // creating not empty list
            List<string> example = new List<string> { "maria", "alex", "bob" };

            // adding elements for the list -> .Add
            l1.Add("MARIA");
            l1.Add("ALEX");
            l1.Add("BOB");
            l1.Add("ANNA");

            /*
            // printing a list
                foreach (string s in l1) {
                    Console.WriteLine(s);
                }
            */

            // adding elements and position for the list -> .Insert 
            l1.Insert(2, "MARCO");

            /*
            // printing a list
                foreach (string s in l1) {
                    Console.WriteLine(s);
                }
            */

            // list size -> .Count

            foreach (string s in l1) {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("list size: " + l1.Count);

            // finding the first or last element in the
            // list respecting a predicate -> .Find or .FindLast

            // first
            string s1 = l1.Find(x => x[0] == 'A'); // predicate
            Console.WriteLine("first 'A': " + s1);

            // last
            string s2 = l1.FindLast(x => x[0] == 'A');
            Console.WriteLine("last 'A': " + s2);

            // finding the first or last element position
            // in the list respection a predicate -> .FindIndex or .FindLastIndex

            // first
            int pos1 = l1.FindIndex(x => x[0] == 'A');
            Console.WriteLine("first position 'A': " + pos1);

            // last
            int pos2 = l1.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("last position 'A': " + pos2);

            // filtering a list based on a predicate -> .FindAll
            List<string> l2 = l1.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------");

            foreach (string s in l2) {
                Console.WriteLine(s);
            }

            // removing elements in list -> .Remove or .RemoveAll
            // or .RemoveAt or .RemoveRange

            // remove
            Console.WriteLine("---------------------------");
            l1.Remove("ALEX");

            foreach (string s in l1) {
                Console.WriteLine(s);
            }

            // remove all
            l1.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------");
            foreach (string s in l1) {
                Console.WriteLine(s);
            }

            /*
                // remove *does not exists*
                l1.Remove("ALEXX");
                foreach (string s in l1) {
                    Console.WriteLine(s);
                }
            */

            // remove at
            Console.WriteLine("---------------------------");
            l1.RemoveAt(0);
            foreach (string s in l1) {
                Console.WriteLine(s);
            }

            // remove range
            Console.WriteLine("---------------------------");
            l1.RemoveRange(1, 0);
            foreach (string s in l1) {
                Console.WriteLine(s);
            }
        }
    }
}
