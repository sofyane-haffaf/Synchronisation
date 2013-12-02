using System;
using System.IO;
using System.Reflection;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace Synchronisation
{
    class Connexion
    {
        public static string FileBase;
        public SqlCeConnection Conne;

        //recupérer la chaine de connexion
        public static void DataBasePath(string database)
        {
            string exePath = Assembly.GetExecutingAssembly().GetName().CodeBase;
            string startupPath = Path.GetDirectoryName(exePath);
            FileBase = Path.Combine(startupPath, database);
            if (!File.Exists(FileBase))
            {
                MessageBox.Show("erreur de connexion");
            }
        }


        // etablire et ouvrir la connexion 
        public SqlCeConnection OpenConnection()
        {
            DataBasePath("Eurequat.sdf");
            string cS = String.Format("DATA SOURCE = '{0}';", FileBase);
            Conne = new SqlCeConnection {ConnectionString = cS};
            try
            {
                Conne.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("erreur BDD");
                Application.Exit();
            }
            return Conne;
        }
    }
}
