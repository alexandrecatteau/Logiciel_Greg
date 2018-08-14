using Moteur.Application.Interface.ServicesExterne;
using Moteur.Application.ServicesExterne;
using Moteur.Domain.Entities.Utilisateur;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
            IWSMoteur wSMoteur = new WSMoteur(Environment.MachineName);
            wSMoteur.AjouterConnexion(new Moteur.Domain.Entities.Connexion(AppDomain.CurrentDomain.FriendlyName));


            Console.ReadKey();
        }
    }
}

