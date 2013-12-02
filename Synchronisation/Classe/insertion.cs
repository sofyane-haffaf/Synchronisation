namespace Synchronisation.Classe
{
    class Insertion
    {
        public int Inser(int i,string p, string o)
        {
            try
            {
                string req = "insert into personne (id,nom,prenom) values (" + i + ",'" + p + "','" + o + "')";
                int j = Requete.ExecuteUpdate(req);
                return j;
            }
            catch { return 0; }
        }
    }
}
