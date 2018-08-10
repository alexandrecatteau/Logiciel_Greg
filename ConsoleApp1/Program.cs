using Moteur.Application.Interface.ServicesExterne;
using Moteur.Application.ServicesExterne;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            IWSMoteur moteur = new WSMoteur();

            moteur.EnregistrerConnexion(new Moteur.CommonType.Mapper.ConnexionPourDetail
            {
                NomProjet = AppDomain.CurrentDomain.FriendlyName
            });



            var v = moteur.ObtenirListeConnexions();

            foreach (var item in v)
            {
                Console.WriteLine($"{item.Cle} : le {item.Date} sur {item.NomProjet} avec le nom {item.NomUtilisateur}.");
            }


            Console.ReadKey();
        }
    }
}
