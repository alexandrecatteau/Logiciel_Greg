using Extension.Validateur;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Extension.Entities
{
    [Table("t_erreur")]
    public class Erreur
    {
        [Key]
        public int Cle { get; set; }

        public DateTime Date { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public Erreur(string message, string stackTrace)
        {
            this.Date = DateTime.Now;
            this.Message = message;
            this.StackTrace = stackTrace;
        }



        public void Ajouter()
        {
            using (var db = new Entity())
            {
                db.Erreurs.Add(this);
                db.SaveChanges();
            }
        }

        public List<Erreur> ObtenirErreurs()
        {
            using (var db = new Entity())
            {
                return db.Erreurs.Where(x => x.Cle != 0).ToList();
            }
        }
    }
}
