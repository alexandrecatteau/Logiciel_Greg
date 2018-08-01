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
            string testString = "";

            var v = testString.Valider(nameof(testString)).Obligatoire();

            Console.ReadKey();
        }
    }
}
