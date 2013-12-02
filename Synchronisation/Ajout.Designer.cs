namespace Synchronisation
{
    partial class Ajout
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.l_id = new System.Windows.Forms.Label();
            this.l_nom = new System.Windows.Forms.Label();
            this.l_prenom = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Inserer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_id
            // 
            this.l_id.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_id.Location = new System.Drawing.Point(20, 45);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(68, 21);
            this.l_id.Text = "Id";
            // 
            // l_nom
            // 
            this.l_nom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_nom.Location = new System.Drawing.Point(20, 82);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(68, 21);
            this.l_nom.Text = "Nom";
            // 
            // l_prenom
            // 
            this.l_prenom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_prenom.Location = new System.Drawing.Point(20, 119);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(68, 21);
            this.l_prenom.Text = "Prénom";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(94, 45);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 21);
            this.Id.TabIndex = 3;
            this.Id.GotFocus += new System.EventHandler(this.Id_GotFocus);
            this.Id.LostFocus += new System.EventHandler(this.Id_LostFocus);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(94, 82);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 21);
            this.Nom.TabIndex = 4;
            this.Nom.GotFocus += new System.EventHandler(this.Nom_GotFocus);
            this.Nom.LostFocus += new System.EventHandler(this.Nom_LostFocus);
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(94, 119);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 21);
            this.Prenom.TabIndex = 5;
            this.Prenom.GotFocus += new System.EventHandler(this.Prenom_GotFocus);
            this.Prenom.LostFocus += new System.EventHandler(this.Prenom_LostFocus);
            // 
            // Inserer
            // 
            this.Inserer.Location = new System.Drawing.Point(82, 188);
            this.Inserer.Name = "Inserer";
            this.Inserer.Size = new System.Drawing.Size(75, 24);
            this.Inserer.TabIndex = 6;
            this.Inserer.Text = "Inserer";
            this.Inserer.Click += new System.EventHandler(this.Inserer_Click);
            // 
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Inserer);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.l_prenom);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.l_id);
            this.Menu = this.mainMenu1;
            this.Name = "Ajout";
            this.Text = "Ajout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Button Inserer;
    }
}