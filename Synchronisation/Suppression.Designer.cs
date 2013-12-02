namespace Synchronisation
{
    partial class Suppression
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eurequatDataSet = new Synchronisation.EurequatDataSet();
            this.Id = new System.Windows.Forms.ComboBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.personneTableAdapter = new Synchronisation.EurequatDataSetTableAdapters.personneTableAdapter();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.l_prenom = new System.Windows.Forms.Label();
            this.l_nom = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eurequatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataMember = "personne";
            this.personneBindingSource.DataSource = this.eurequatDataSet;
            // 
            // eurequatDataSet
            // 
            this.eurequatDataSet.DataSetName = "EurequatDataSet";
            this.eurequatDataSet.Prefix = "";
            this.eurequatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Id
            // 
            this.Id.DataSource = this.personneBindingSource;
            this.Id.DisplayMember = "id";
            this.Id.Location = new System.Drawing.Point(107, 51);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 22);
            this.Id.TabIndex = 23;
            this.Id.SelectedIndexChanged += new System.EventHandler(this.Id_SelectedIndexChanged_1);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(95, 194);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 24);
            this.Supprimer.TabIndex = 22;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // personneTableAdapter
            // 
            this.personneTableAdapter.ClearBeforeFill = true;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(107, 125);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 21);
            this.Prenom.TabIndex = 21;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(107, 88);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 21);
            this.Nom.TabIndex = 20;
            // 
            // l_prenom
            // 
            this.l_prenom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_prenom.Location = new System.Drawing.Point(33, 125);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(68, 21);
            this.l_prenom.Text = "Prénom";
            // 
            // l_nom
            // 
            this.l_nom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_nom.Location = new System.Drawing.Point(33, 88);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(68, 21);
            this.l_nom.Text = "Nom";
            // 
            // l_id
            // 
            this.l_id.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_id.Location = new System.Drawing.Point(33, 51);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(68, 21);
            this.l_id.Text = "Id";
            // 
            // Suppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.l_prenom);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.l_id);
            this.Menu = this.mainMenu1;
            this.Name = "Suppression";
            this.Text = "Suppression";
            this.Load += new System.EventHandler(this.Suppression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eurequatDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource personneBindingSource;
        private EurequatDataSet eurequatDataSet;
        private System.Windows.Forms.ComboBox Id;
        private System.Windows.Forms.Button Supprimer;
        private Synchronisation.EurequatDataSetTableAdapters.personneTableAdapter personneTableAdapter;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label l_id;
    }
}