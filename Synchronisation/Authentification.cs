using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Synchronisation.Classe;

namespace Synchronisation
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }
        Traitement tr = new Traitement();
        private void Connecter_Click(object sender, EventArgs e)
        {
            if (Nom.Text == "" || Prenom.Text == "")
                MessageBox.Show("Veuillez remplir tous les champs");
            else
            {
                int y= tr.Connecter(Nom.Text, Prenom.Text);
                if (y!=-1)
                {
                    var fr2 = new Acceuil();
                    fr2.Show();
                    Hide();
                }
            }
        }

    }
}