using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_AE
{
    class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno Hrast = new Bjelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(true);
            Console.WriteLine(Hrast.OpadajuListovi);
            Console.WriteLine(Bor.OpadajuListovi);
            Console.ReadKey();

        }
    }
}
