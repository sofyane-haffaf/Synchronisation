namespace Synchronisation
{
    partial class Authentification
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
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.l_prenom = new System.Windows.Forms.Label();
            this.l_nom = new System.Windows.Forms.Label();
            this.Connecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(107, 101);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 21);
            this.Prenom.TabIndex = 9;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(107, 64);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 21);
            this.Nom.TabIndex = 8;
            // 
            // l_prenom
            // 
            this.l_prenom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_prenom.Location = new System.Drawing.Point(33, 101);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(68, 21);
            this.l_prenom.Text = "Prénom";
            // 
            // l_nom
            // 
            this.l_nom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.l_nom.Location = new System.Drawing.Point(33, 64);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(68, 21);
            this.l_nom.Text = "Nom";
            // 
            // Connecter
            // 
            this.Connecter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Connecter.Location = new System.Drawing.Point(78, 160);
            this.Connecter.Name = "Connecter";
            this.Connecter.Size = new System.Drawing.Size(84, 23);
            this.Connecter.TabIndex = 12;
            this.Connecter.Text = "Connecter";
            this.Connecter.Click += new System.EventHandler(this.Connecter_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Connecter);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.l_prenom);
            this.Controls.Add(this.l_nom);
            this.Menu = this.mainMenu1;
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Button Connecter;
    }
}