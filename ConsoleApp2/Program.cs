using Moteur.Application.Interface.ServicesExterne;
using Moteur.Application.ServicesExterne;
using Moteur.Domain.Entities;
using Moteur.Domain.Entities.Utilisateur;
using Moteur.Domain.Interfaces.Entities.Utlisateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
            IWSMoteur wSMoteur = new WSMoteur();
            wSMoteur.EnregistrerNouvelUtilisateur();

            Console.ReadKey();
        }
    }
}
