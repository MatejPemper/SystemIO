using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sytemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi putanju direktorija: ");
            string putanja =Console.ReadLine();

            //provijera postjanja direktorija
            if (Directory.Exists(putanja)){
                //ako postoji, ispisujemo sve datoteku u direktoriju
                Console.WriteLine("Datoteke: ");

                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }

            }

            string putanjaPoddirektorija = "\\Test";
            string novaPutanja = putanja + putanjaPoddirektorija;

            if (!Directory.Exists(novaPutanja))
            {
                Directory.CreateDirectory(novaPutanja);
            }
            else
            {
                Console.WriteLine("Direktorij već postoji!");
            }

            if (Directory.Exists(putanja))
            {
                //ako postoji, ispisujemo sve datoteku u direktoriju
                Console.WriteLine("Poddirektorij: ");

                foreach (string poddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }

            }

            Directory.Delete(novaPutanja);

            if (Directory.Exists(putanja))
            {
                //ako postoji, ispisujemo sve datoteku u direktoriju
                Console.WriteLine("Nakon brisanja: ");

                foreach (string brisanjePoddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(brisanjePoddirektorij);
                }

            }





            Console.ReadKey();

        }
    }
}
