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
            string testString = "zaeqsd";

            try
            {
                testString.Valider(nameof(testString)).NonNul().Obligatoire().LongueurMaximale(78).LongueurMinimale(78);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
