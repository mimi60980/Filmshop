using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using FlimLibrary;
using System.Threading.Tasks;

namespace FlimLibrary
{
     abstract class Personne
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public int Age => Calcul.Ageat(this.DateDeNaissance,DateTime.Now);

        abstract public void AddFlim(Flim newFlim);
        protected List<Flim> m_flims = new List<Flim>();

        abstract public void AddPersonnes(Personne newPersonnes);
        protected List<Personne> m_personnes = new List<Personne>();

    }
}

static class Calcul
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