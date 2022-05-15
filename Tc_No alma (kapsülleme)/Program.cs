using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tc_No_alma__kapsülleme_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Tc Kimlik Numaranızı Giriniz:");
            string tcGiris = Console.ReadLine();
            personel p1 = new personel();
            p1.TC = tcGiris;
            Console.WriteLine("TC Kimlik Numaranız: " + p1.TC);
            Console.ReadLine();
        }
    }
}
