namespace Synchronisation.Classe
{
    class Misajour
    {
        public int Modif(int i,string n, string p)
        {
            try
            {
                string req = "UPDATE personne SET nom='" + n + "',prenom='" + p + "' WHERE (id LIKE '" + i + "');";
                int j = Requete.ExecuteUpdate(req);
                return j;
            }
            catch { return 0; }
        }

        public int Supp(int i, string n, string p)
        {
            try
            {
                string req = "DELETE From personne WHERE (id ='" + i + "');";
                int j = Requete.ExecuteUpdate(req);
                return j;
            }
            catch { return 0; }
        }
    }
}
