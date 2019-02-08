using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace FlimLibrary
{
    class DataAccess
    {
        public string SqlConnectionString = @"Server=.\SQLExpress;Database=FlimDatabase;Trusted_Connection=Yes";
    }
    #region Ajout d'une personne Bdd
    public void InsererUtilisateurEnBDD(string nomPersonne, string prenomPersonne, int datedenaissancePersonne, string adressePersonne, string villePersonne, string codepostalPersonne, int taillePersonne, int poidPersonne)
    {
        SqlConnection connection = new SqlConnection();
        connection.Open();
        SqlCommand firstInsert =
                    new SqlCommand("INSERT INTO (NomPersonne,PrenomPersonne," +
                    "DateDeNaissancePersonne,AdressePersonne,Villepersonne,CodePostalPersonne,TaillePersonne,PoidPersonne,"+
                    " VALUES (@nomPersonne,@prenomPersonne,@datedenaissancePersonne," +
                    "@adressePersonne,@villePersonne,@codepostalPersonne,@taillePersonne,@poidPersonne)", connection);

        firstInsert.Parameters.AddWithValue("@nomPersonne", nomPersonne);
        firstInsert.Parameters.AddWithValue("@prenomPersonne", prenomPersonne);
        firstInsert.Parameters.AddWithValue("@datedenaissancePersonne", datedenaissancePersonne);
        firstInsert.Parameters.AddWithValue("@adressePersonne", adressePersonne);
        firstInsert.Parameters.AddWithValue("@villePersonne", villePersonne);
        firstInsert.Parameters.AddWithValue("@codepostalPersonne", codepostalPersonne);
        firstInsert.Parameters.AddWithValue("@taillePersonne", taillePersonne);
        firstInsert.Parameters.AddWithValue("@poidPersonne", poidPersonne);

        firstInsert.ExecuteNonQuery();

        connection.Close();
    }
    #endregion


}

