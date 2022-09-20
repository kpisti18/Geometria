using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Kor kor = new Kor(2);
            Haromszog haromszog = new Haromszog(1,1,3);
            
            try
            {
                kor.Sugar = 2;

                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\nA kör átmérője: {kor.Atmero:N2}\nA kör kerülete: {kor.Kerulet():N2}\nA kör területe: {kor.Terulet():N2}\n");

                kor.Sugar = 7;

                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\nA kör átmérője: {kor.Atmero:N2}\nA kör kerülete: {kor.Kerulet():N2}\nA kör területe: {kor.Terulet():N2}\n");

                kor.Sugar = -2;

                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\nA kör átmérője: {kor.Atmero:N2}\nA kör kerülete: {kor.Kerulet():N2}\nA kör területe: {kor.Terulet():N2}\n");

                kor.Sugar = 11; //ez már le se fog futni, mivel a -2-nél már exception-be fut

                Console.WriteLine($"A kör sugara: {kor.Sugar:N2}\nA kör átmérője: {kor.Atmero:N2}\nA kör kerülete: {kor.Kerulet():N2}\nA kör területe: {kor.Terulet():N2}\n");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            

            try
            {
                haromszog.AOldal = double.Parse(Console.ReadLine());
                haromszog.BOldal = double.Parse(Console.ReadLine());
                haromszog.COldal = double.Parse(Console.ReadLine());

                Console.WriteLine($"\n{haromszog.SzerkeszthetoE()}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("A program vége!");
            Console.ReadKey();
        }
    }
}
