using Extension.Validateur;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Moteur.Entities
{
    [Table("T_CNX")]
    public class Connexion : DbContext
    {
        [Key]
        [Column("CLE")]
        public int Cle { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }

        [Column("NOMUTILISATEUR")]
        public string NomUtilisateur { get; set; }

        [Column("NOMPROJET")]
        public string NomProjet { get; set; }

        public Connexion(string nomProjet)
        {
            this.NomUtilisateur = System.Environment.MachineName;
            this.Date = DateTime.Now;
            this.NomProjet = nomProjet;
        }
    }
}
