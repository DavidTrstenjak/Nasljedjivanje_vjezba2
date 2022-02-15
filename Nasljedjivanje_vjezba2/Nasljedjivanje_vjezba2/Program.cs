using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_vjezba2
{
    internal class Program
    {
        class ProgramskiJezik
        {
            double postotak;

            public double Postotak { get => postotak; set => postotak = value; }
        }

        class Proceduralni : ProgramskiJezik
        {
            
        }

        class Objektni : ProgramskiJezik
        {

        }

        class Funkcionalni : ProgramskiJezik
        {

        }

        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Unesite postotak za proceduralni: ");
            int postotak1 = Convert.ToInt32 (Console.ReadLine());
            x.Postotak = postotak1;

            Console.WriteLine("Unesite postotak za objektni: ");
            int postotak2 = Convert.ToInt32(Console.ReadLine());
            y.Postotak = postotak2;

            Console.WriteLine("Unesite postotak za funkcionalni: ");
            int postotak3 = Convert.ToInt32(Console.ReadLine());
            z.Postotak = postotak3;

            int zbrojPostotaka = postotak1 + postotak2 + postotak3;

            if (zbrojPostotaka != 100)
            {
                Console.WriteLine("Unijeli ste neispravne podatke.");
            }

            else
            {
                if (postotak1 > postotak2 && postotak1 > postotak3)
                {
                    Console.WriteLine("Najzastupljeniji je proceduralni programski jezik sa " + postotak1 + "%.");
                }

                if (postotak2 > postotak1 && postotak2 > postotak3)
                {
                    Console.WriteLine("Najzastupljeniji je objektni programski jezik sa " + postotak2 + "%.");
                }

                if (postotak3 > postotak2 && postotak3 > postotak1)
                {
                    Console.WriteLine("Najzastupljeniji je funkcionalni programski jezik sa " + postotak3 + "%.");
                }
            }

            Console.ReadKey();
        }
    }
}
