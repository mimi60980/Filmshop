using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlimLibrary
{
    class Personne
    {
        private string Nom;
        private string Prénom;
        private DateTime DateDeNaissance;
        private string Nationalite;
        public string Producteur;
        public string Acteurs;


        public Personne(string Nom, string Prenom, DateTime)
        {

        }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prénom1 { get => Prénom; set => Prénom = value; }

        public DateTime DateDeNaissance1 { get => DateDeNaissance; set => DateDeNaissance = value; }
    }
}
