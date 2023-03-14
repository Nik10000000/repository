using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class Country
    {
        public Country()
        {
            Console.Write("Введите страну: ");
            string title = Convert.ToString(Console.ReadLine());
            Console.Write("Введите форму правления: ");
            string form_pravlenia = Convert.ToString(Console.ReadLine());
            float square = 120;
            Console.WriteLine(title);
            Console.WriteLine(form_pravlenia);
            Console.WriteLine("Площадь: "+square);
            /*Console.ReadLine();*/
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            Console.WriteLine();
            Console.ReadKey();
                
        }
    }
}
