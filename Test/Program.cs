using Extension.Validateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInt = 897;

            testInt.Valider(nameof(testInt)).Entre(6, 10);

            Console.ReadKey();
        }
    }
}
