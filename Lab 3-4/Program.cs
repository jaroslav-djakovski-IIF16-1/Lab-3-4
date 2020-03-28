using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    class Program
    {
        public static void Galutinis(string[] v, string [] p, int i)
        {
            Console.WriteLine("iveskite stringa: ");
            v[0] = Console.ReadLine();


        }
        static void Main(string[] args)
        {
            string[] vard = new string[100000];
            string[] pav = new string[100000];
            int i, vid;
            string s = new String('-', 50);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Vardas", "Pavardė", "Galutinis (Vid.)"));
            Console.WriteLine(s);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Bill", "Gates", 51));
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Edna", "Parker", 114));
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Johnny", "Depp", 44));
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
