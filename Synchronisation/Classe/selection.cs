using System.Data;
using System.Data.SqlServerCe;

namespace Synchronisation.Classe
{
    class Selection
    {
        public DataSet Connex(string p, string o)
        {
            try
            {
                string req = "select * from personne where (nom='" + p + "' and prenom='" + o + "')";
                DataSet ds = Requete.ExecuteSelect(req);
                return ds;
            }
            catch { return null; }
        }
        public SqlCeDataReader M2(int l)
        {
            try
            {
                string req = "select * from personne where (id=" + l + ")";
                SqlCeDataReader dtr = Requete.ExecuteReader(req);
                return dtr;
            }
            catch { return null; }
        }
    }
}
