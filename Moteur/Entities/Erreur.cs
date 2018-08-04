using Extension.Validateur;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Moteur.Entities
{
    [Table("t_erreur")]
    public class Erreur
    {
        [Key]
        public int Cle { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Message { get; set; }

        public string StackTrace { get; set; }





        public void Ajouter(Erreur erreur)
        {
            erreur.Valider(nameof(erreur)).NonNull();

            using (var db = new Entity())
            {
                db.Erreurs.Add(erreur);
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
