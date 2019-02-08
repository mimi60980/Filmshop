using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlimLibrary
{
    class Personne
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public int Age => calcul.Ageat(this.DateDeNaissance,DateTime.Now);
    }
}

static class calcul
{
    public static int Ageat(DateTime naissance , DateTime jour)
    {
        int annee = naissance.Year - jour.Year;
        if (naissance.Month < jour.Month || naissance.Month == jour.Month && naissance.Day < jour.Day)
            return annee - 1;
        else
            return annee;

    }





}