using System;
using System.Windows.Forms;
using Microsoft.Synchronization.Data;

namespace Synchronisation
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Synchroniser_Click(object sender, EventArgs e)
        {
            // The WCF Service
            var webSvcProxy = new EurequatProxy.EurequatCacheSyncService();

            // The Remote Server Provider Proxy
            var serverProvider = new ServerSyncProviderProxy(webSvcProxy);

            // The Sync Agent
            var syncAgent = new EurequatCacheSyncAgent
                {
                    RemoteProvider = serverProvider,
                    personne = {SyncDirection = SyncDirection.Bidirectional}
                };

            // Synchronize the databases
            SyncStatistics stats = syncAgent.Synchronize();

            // Show synchronization statistics
            MessageBox.Show("Changement téléchargés: " + stats.TotalChangesDownloaded + "\r\n" + "Changement uplodés: " + stats.TotalChangesUploaded);

            if (personneTableAdapter != null) personneTableAdapter.Fill(eurequatDataSet.personne);
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            if (EurequatDataSetUtil.DesignerUtil.IsRunTime())
            {
                personneTableAdapter.Fill(eurequatDataSet.personne);
            }

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            var fr = new Ajout();
            fr.Show();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            var fr1 = new Modification();
            fr1.Show();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var fr2 = new Suppression();
            fr2.Show();
        }
    }
}