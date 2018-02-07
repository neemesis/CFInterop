using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharp;
using Domain;
using Microsoft.FSharp.Collections;

namespace CFInterop {
    static class Program {
        static void Main(string[] args) {

            var pList = InitList();

            var helloFsharp = FSharp.Say.hello("C#");
            Console.WriteLine(helloFsharp);

            var fsharpAvg = FSharp.Say.avgHeight(ListModule.OfSeq(pList));
            Console.WriteLine($"F# Avg. Height: {fsharpAvg}");
            Console.WriteLine($"C# Avg. Height: {pList.Average(x => x.Height)}");

            Console.ReadKey();
        }

        static List<Person> InitList() {
            return new List<Person> {
                new Person("Person  1", 160, 22),
                new Person("Person  2", 172, 45),
                new Person("Person  3", 196, 63),
                new Person("Person  4", 154, 18),
                new Person("Person  5", 178, 64),
                new Person("Person  6", 187, 35),
                new Person("Person  7", 169, 27),
                new Person("Person  8", 186, 45),
                new Person("Person  9", 167, 36),
                new Person("Person 10", 190, 65),
            };
        }
    }
}



