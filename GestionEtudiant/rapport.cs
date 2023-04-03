using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEtudiant
{
    class Rapport
    {
       public string Nom { get; set; } 
       public string Prenom { get; set; } 
       public double Note { get; set; } 
       public string DateCompos { get; set; }

       public Rapport(string nom, string prénom, double note, string dateCompos)
       {
           Nom = nom;
           Prenom = prénom;
           Note = note;
           DateCompos = dateCompos;
       }
    }
}
