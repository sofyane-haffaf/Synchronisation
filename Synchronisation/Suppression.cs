using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using Synchronisation.Classe;

namespace Synchronisation
{
    public partial class Suppression : Form
    {
        Traitement tr = new Traitement();
        public Suppression()
        {
            InitializeComponent();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Id.Text);
            s = int.Parse(Id.Text);
            tr.Supprimer(s, Nom.Text, Prenom.Text);
            Close();
            var fr2 = new Acceuil();
            fr2.Show();
        }

        private void Suppression_Load(object sender, EventArgs e)
        {
            personneTableAdapter.Fill(eurequatDataSet.personne);
            SqlCeDataReader dtr3 = null;
            int s = Convert.ToInt32(Id.Text);
            s = int.Parse(Id.Text);
            dtr3 = tr.Charger(s);
            while (dtr3.Read())
            {
                Nom.Text = dtr3["nom"].ToString();
                Prenom.Text = dtr3["prenom"].ToString();
            }
        }

        private void Id_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCeDataReader dtr3 = null;
            int k = Convert.ToInt32(Id.Text);
            k = int.Parse(Id.Text);
            dtr3 = tr.Charger(k);
            while (dtr3.Read())
            {
                Nom.Text = dtr3["nom"].ToString();
                Prenom.Text = dtr3["prenom"].ToString();
            }
        }
    }
}