using Extension.Validateur;
using Moteur.Entities;
using Moteur.Interfaces.Services;
using Moteur.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IConnexionServices connexionServices = new ConnexionServices();
            connexionServices.Ajouter(new Connexion(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name));

            Console.ReadKey();
        }
    }
}
