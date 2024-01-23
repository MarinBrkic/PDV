using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pitanje;
            double PDV = 0.25;
            double cijena;
            double cijena_nova;
            Console.WriteLine("PDV?(Da/Ne): ");
            pitanje = Console.ReadLine();

            if(pitanje == "Da")
            {
                Console.WriteLine("Unesite cijenu s PDV-om: ");
                cijena = Convert.ToDouble(Console.ReadLine());
                cijena_nova = cijena + cijena * PDV;
                Console.WriteLine("Cijena bez PDV-a: " + cijena_nova);
            }
            else if (pitanje == "Ne")
            {
                Console.WriteLine("Unesite cijenu bez PDV-a: ");
                cijena = Convert.ToDouble(Console.ReadLine());
                cijena_nova = cijena - cijena * PDV;
                Console.WriteLine("Cijena s PDV-om: " + cijena_nova);
            }
            Console.ReadKey();
        }
    }
}
