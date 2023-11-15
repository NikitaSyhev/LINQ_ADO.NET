using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqMethod();
        }

        private static void LinqMethod()
        {
            string[] countries =
              {
            "Arabica", "Albania", "Austria","Russia","Monaco","Cuba","Montenegro","Spain",
              };

            //var result = from c in countries               //LINQ запрос. синтаксис отличается от SQL
            //             where c.StartsWith("S")
            //             select c;

            /*var result = countries.Where(x => x.StartsWith("A")).OrderBy(x=>x);*/ // сортировка по алфавиту 

            //var result = countries.Max(x=> (x.Length, x));

            var result = from c in countries
                         where c.Length==countries.Max(x=>x.Length)
                         select c;

            Console.WriteLine(result);

            //foreach (var q in result)
            //{
            //    Console.WriteLine(q);
            //}
            Console.WriteLine("Press Enter to complete");




            Console.ReadLine();
        }
    }
}
