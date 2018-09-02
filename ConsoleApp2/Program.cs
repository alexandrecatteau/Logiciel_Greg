using Extension.Validateur;
using Moteur.Application.Interface.ServicesExterne;
using Moteur.Application.ServicesExterne;
using Moteur.Domain.Entities;
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

            IWSMoteur wSMoteur = new WSMoteur();

            //Connexion connexion = new Connexion(AppDomain.CurrentDomain.FriendlyName);
            //wSMoteur.AjouterConnexion(connexion);

            Utilisateur utilisateur = wSMoteur.ObtenirUtilisateur(Environment.MachineName);

            for (int i = 0; i < 100; i++)
            {
                wSMoteur.AjouterConnexion(utilisateur, AppDomain.CurrentDomain.FriendlyName);
            }

            
            

            Console.ReadKey();
        }
    }
}

