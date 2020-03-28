using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    class Program
    {
        public static void vidurkis(List<string> a, int sk)
        {
            double vid = 0;
            int c = 0;
            double[] g = new double[10000];
            for (int i = 0; i < sk; i++)
            {
                string ab = a[i + 2 + c];
                string[] paz = ab.Split(' ');
                int[] pazymiai = Array.ConvertAll(paz, int.Parse);
                foreach (int p in pazymiai)
                {
                    vid = vid + p;
                }
                int e = Convert.ToInt32(a[i + 3 + c]);
                vid = vid / pazymiai.Length;
                g[i] = (0.3 * vid) + (0.7 * e);
                vid = 0;
                c = c + 3;
            }
            c = 0;
            string s = new String('-', 50);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Vardas", "Pavardė", "Galutinis (Vid.)"));
            Console.WriteLine(s);
            for (int i = 0; i < sk; i++)
            {

                Console.WriteLine(String.Format("{0,-15} {1,-25} {2:.##}", a[i + c], a[i + 1 + c], g[i]));
                c = c + 3;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static void mediana(List<string> a, int sk)
        {
            double med;
            double[] g = new double[10000];
            int c = 0;
            for (int i = 0; i < sk; i++)
            {
                string ab = a[i + 2 + c];
                string[] paz = ab.Split(' ');
                int[] pazymiai = Array.ConvertAll(paz, int.Parse);
                Array.Sort(pazymiai);

                if (pazymiai.Length % 2 == 1)
                {
                    med = pazymiai[pazymiai.Length / 2];
                }
                else
                {
                    med = (pazymiai[(pazymiai.Length / 2) - 1] + pazymiai[(pazymiai.Length / 2)]);
                    med = med / 2;
                }
                int e = Convert.ToInt32(a[i + 3 + c]);
                g[i] = (0.3 * med) + (0.7 * e);
                c = c + 3;
            }
            c = 0;
            string s = new String('-', 50);
            Console.WriteLine(String.Format("{0,-15} {1,-15} {2,5}", "Vardas", "Pavardė", "Galutinis (Med.)"));
            Console.WriteLine(s);
            for (int i = 0; i < sk; i++)
            {

                Console.WriteLine(String.Format("{0,-15} {1,-25} {2:.##}", a[i + c], a[i + 1 + c], g[i]));
                c = c + 3;
            }
            Console.WriteLine(s);
            Console.ReadLine();

        }

        public static string random() {
            Random rnd = new Random();
            int b;
            int  nr;
            string result = "";
            nr = rnd.Next(1, 11);
            for (int i = 0; i < nr; i++){
                b= rnd.Next(1, 11);
                result = result + b;
                if (i < nr - 1)
                    result = result + " ";
            }
            return result;
        }

        public static string randomegz()
        {
            Random rnd = new Random();
            int nr;
            string result;
            nr = rnd.Next(1, 11);
            result = nr + "";
            return result;
        }

        public static void menu() {

            Console.WriteLine("Norite duomenys nuskaityti is failo ar ivesite ranka? (iveskite 'file' ar 'ranka'). Jei norite uzdaryti programa parasykite 'exit' ");
            string a = Console.ReadLine();
            a = a.ToLower();
            switch (a)
            {
                case "file":
                    file();
                    menu();
                    break;
                case "ranka":
                    ranka();
                    menu();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Blogas pasirinkimas");
                    menu();
                    break;
            }

        }

        public static void ranka() {

            string vard, pazymiai, egz;
            double[] galutinis = new double[10000];
            int a = 0;
            List<string> studentai = new List<string>();
            string check;

            Console.WriteLine("Iveskite studentu skaiciu ");
            int studsk = Convert.ToInt32(Console.ReadLine());

            while (studsk > 0)
            {
                Console.WriteLine("Iveskite studento vardą ir pavardę. ");
                vard = Console.ReadLine();
                string[] split = vard.Split(' ');
                Console.WriteLine("ar norite sugenetruoti atsitiktinius namu darbu balus ir ju skaiciu? (irasykite 'taip' jei norite generuoti) ");
                check = Console.ReadLine();
                if (check == "taip")
                    pazymiai = random();
                else
                {
                    Console.WriteLine("iveskite studento pazymius. ");
                    pazymiai = Console.ReadLine();
                }
                Console.WriteLine("ar norite sugenetruoti atsitiktini egzamino bala? (irasykite 'taip' jei norite generuoti) ");
                check = Console.ReadLine();
                if (check == "taip")
                {
                    egz = randomegz();
                }
                else
                {
                    Console.WriteLine("iveskite studento egzamino pazymi. ");
                    egz = Console.ReadLine();
                }
                studentai.Add(split[0]);
                studentai.Add(split[1]);
                studentai.Add(pazymiai);
                studentai.Add(egz);
                a++;
                studsk--;

            }
            Console.WriteLine("Pazymis skaiciuosite su mediana ar su vidurkiu? (iveskite 'mediana' ar 'vidurkis') ");
            check = Console.ReadLine();

            if (check == "vidurkis")
                vidurkis(studentai, a);

            if (check == "mediana")
                mediana(studentai, a);

        }

        public static void file() {
            Console.WriteLine("work in progress ");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
