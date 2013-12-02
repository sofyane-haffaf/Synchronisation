using System;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;
using Synchronisation.Classe;

namespace Synchronisation
{
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }

        private void Inserer_Click(object sender, EventArgs e)
        {
            var tr = new Traitement();
            if (Nom.Text == "" || Prenom.Text == "")
                MessageBox.Show("Veuillez remplir tous les champs");
            else
            {
                int k = Convert.ToInt32(Id.Text);
                k = int.Parse(Id.Text);
                tr.Inserer(k, Nom.Text, Prenom.Text);
                Close();
                var fr2 = new Acceuil();
                fr2.Show();
            }
        }

        InputPanel InputPanel1 = new InputPanel();
        private void Id_GotFocus(object sender, EventArgs e) { InputPanel1.Enabled = true; }
        private void Id_LostFocus(object sender, EventArgs e) { InputPanel1.Enabled = false; }
        private void Nom_GotFocus(object sender, EventArgs e) { InputPanel1.Enabled = true; }
        private void Nom_LostFocus(object sender, EventArgs e) { InputPanel1.Enabled = false; }
        private void Prenom_GotFocus(object sender, EventArgs e) { InputPanel1.Enabled = true; }
        private void Prenom_LostFocus(object sender, EventArgs e) { InputPanel1.Enabled = false; }
    }
}