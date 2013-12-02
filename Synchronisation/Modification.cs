using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using Synchronisation.Classe;

namespace Synchronisation
{
    public partial class Modification : Form
    {
        Traitement tr = new Traitement();
        public Modification()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (Nom.Text == "" || Prenom.Text == "")
                MessageBox.Show("Veuillez remplir tous les champs");
            else
            {
                int k = Convert.ToInt32(Id.Text);
                k = int.Parse(Id.Text);
                tr.Modifier(k, Nom.Text, Prenom.Text);
                Close();
                var fr2 = new Acceuil();
                fr2.Show();
            }
        }

        private void Modification_Load(object sender, EventArgs e)
        {
           personneTableAdapter.Fill(eurequatDataSet.personne);
            SqlCeDataReader dtr2 = null;
            int k = Convert.ToInt32(Id.Text);
            k = int.Parse(Id.Text);
            dtr2 = tr.Charger(k);
            while (dtr2.Read())
            {
                Nom.Text = dtr2["nom"].ToString();
                Prenom.Text = dtr2["prenom"].ToString();
            }
        }

        private void Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeDataReader dtr2 = null;
            int k = Convert.ToInt32(Id.Text);
            k = int.Parse(Id.Text);
            dtr2 = tr.Charger(k);
            while (dtr2.Read())
            {
                Nom.Text = dtr2["nom"].ToString();
                Prenom.Text = dtr2["prenom"].ToString();
            }
        }
            

    }
}