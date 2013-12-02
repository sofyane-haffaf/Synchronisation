using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;

namespace Synchronisation.Classe
{
    class Traitement
    {
        DataSet ds1;
        int j;

        public int Connecter(string p2, string o2)
        {
            int u=0;
            var sl = new Selection();
            ds1 = sl.Connex(p2, o2);
            if (ds1.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("nom d'utilisateur ou mot de passe incorrect");
                u = -1;
            }
            return u;
        }

        public SqlCeDataReader Charger(int l)
        {
            var sl = new Selection();
            SqlCeDataReader dtr1 = sl.M2(l);
            if (dtr1 == null)
            {
                MessageBox.Show("echec chargement");
            }
            return dtr1;
        }

        public void Inserer(int i,string p, string o)
        {
            var ins = new Insertion();
            j = ins.Inser(i,p, o);
            MessageBox.Show(j != 0 ? "insertion réussis" : "insertion echoué");
        }

        public void Modifier(int i, string p, string o)
        {
            var msj = new Misajour();
            j = msj.Modif(i, p, o);
            MessageBox.Show(j != 0 ? "mise à jour réussis" : "mise à jour echoué");
        }

        public void Supprimer(int i, string p, string o)
        {
            var msj = new Misajour();
            j = msj.Supp(i, p, o);
            MessageBox.Show(j != 0 ? "suppression réussis" : "suppression echoué");
        }
    }
}
