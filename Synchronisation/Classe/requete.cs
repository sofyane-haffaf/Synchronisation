using System;
using System.Data.SqlServerCe;
using System.Data;

namespace Synchronisation.Classe
{
    class Requete
    {
        internal static int ExecuteUpdate(string requête)
        {
            // on gère les éventuelles exceptions
            try
            {
                var con = new Connexion();
                // ouverture connexion
                SqlCeConnection conne = con.OpenConnection();
                // exécute sqlCommand avec requête de mise à jour
                var sqlCommand = new SqlCeCommand(requête, conne);
                int nbLignes = sqlCommand.ExecuteNonQuery();
                return nbLignes;

            }
            catch (Exception)
            {
                return -1;
            }
        }

        internal static DataSet ExecuteSelect(string requête)
        {
            // on gère les éventuelles exceptions
            try
            {
                var con = new Connexion();
                SqlCeConnection connexion = con.OpenConnection();
                SqlCeCommand cmd = connexion.CreateCommand();
                cmd.CommandText = requête;
                var da = new SqlCeDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

        }

        internal static SqlCeDataReader ExecuteReader(string req)
        {
            try
            {
                var con = new Connexion();
                SqlCeConnection conne = con.OpenConnection();
                var sqlCommand = new SqlCeCommand(req, conne);
                SqlCeDataReader myReader = sqlCommand.ExecuteReader();
                return myReader;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }   
    }
}