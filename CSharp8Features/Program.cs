#nullable enable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace CSharp8Features
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //DoNullableReferenceTypes();
            //await DoAsyncStreams();
            //DoRanges();
            //DoDefaultInterfaces();
            //Console.WriteLine($"X = {DoSwitchExpressions()}");
            DoPatternMatching();
        }
        
        static void DoNullableReferenceTypes()
        {
            Person? person = new Person();
            person = null;

            if (person != null)
            {
                Console.WriteLine($"Hello {person.Name}!");
            }
        }

        private static async Task DoAsyncStreams()
        {
            await foreach (var number in FetchData())
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }

        static async IAsyncEnumerable<int> FetchData()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000); // Simulate waiting on a server...
                yield return i;
            }
        }

        private static void DoRanges()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var first2Numbers = numbers[..2];
            Console.WriteLine($"First tow numbers are: { String.Join(", ", first2Numbers) }");

            var lastTwoNumbers = numbers[^2..];

            Console.WriteLine($"Last tow numbers are: { String.Join(", ", lastTwoNumbers) }");

            var middleNumbers = numbers[1..^1];
            Console.WriteLine($"Middle numbers are: { String.Join(", ", middleNumbers) }");
        }
        
        private static void DoDefaultInterfaces()
        {
            IDefaultInterfacesExample example = new DefaultInterfacesExample();
            example.DoSomethingDifferent("test");
        }

        private static string DoSwitchExpressions()
        {
            var point = new Point(10, 20);

            return point switch
            {
                Point p when p.X == 10 => "X is inderdaad 10 :)",
                Point p when p.X == 20 => "X is 20...",
                _                      => "Onbekend"
            };
        }

        private static void DoPatternMatching()
        {
            var point = new Point(2, 3);

            // C# 7.0
            if (point is Point p && p.X == 2)
            {
                Console.WriteLine($"C# 7.0 ==> Het betreft een point met X waarde 2 en y waarde {p.Y}");
            }

            // C# 8.0
            if (point is Point { X: 2, Y: int yWaarde})
            {
                Console.WriteLine($"C# 8.0 ==>Het betreft een point met X waarde 2 en Y waarde {yWaarde}");
            }
        }
    }
}
