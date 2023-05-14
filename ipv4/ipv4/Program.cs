using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string indirizzo,cidr;
            Calcolarore ipv4;
            Console.WriteLine("Inserisci l'indirizzo ip in binario, ogni ottetto dividi con un punto");
            indirizzo= Console.ReadLine();
            Console.WriteLine("Inserisci CIDR");
            cidr= Console.ReadLine();
            ipv4 = new Calcolarore(indirizzo,cidr);
            Console.WriteLine("L'indirizzo ip convertito:");
            Console.WriteLine(ipv4.generateIPv4());
            Console.WriteLine("La subnet mask convertita");
            Console.WriteLine(ipv4.generateSubnet());
            Console.ReadLine();
        }
    }
}
