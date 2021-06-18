using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EnumeratorSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Enumerable.Range(0, 100).SelectAt((a,q) =>
            {
                if (a % 2 == 0) q.Remove();
                return a;
            });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
