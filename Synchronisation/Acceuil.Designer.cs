namespace Synchronisation
{
    partial class Acceuil
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
            System.Windows.Forms.DataGridTextBoxColumn idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn nomDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn prenomDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.Ajouter = new System.Windows.Forms.MenuItem();
            this.Modifier = new System.Windows.Forms.MenuItem();
            this.Synchroniser = new System.Windows.Forms.Button();
            this.eurequatDataSet = new Synchronisation.EurequatDataSet();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personneTableAdapter = new Synchronisation.EurequatDataSetTableAdapters.personneTableAdapter();
            this.personneDataGrid = new System.Windows.Forms.DataGrid();
            this.personneTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.Supprimer = new System.Windows.Forms.MenuItem();
            idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            nomDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            prenomDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eurequatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idDataGridColumnStyleDataGridTextBoxColumn
            // 
            idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            idDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "id";
            idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "id";
            // 
            // nomDataGridColumnStyleDataGridTextBoxColumn
            // 
            nomDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            nomDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            nomDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "nom";
            nomDataGridColumnStyleDataGridTextBoxColumn.MappingName = "nom";
            // 
            // prenomDataGridColumnStyleDataGridTextBoxColumn
            // 
            prenomDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            prenomDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            prenomDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "prenom";
            prenomDataGridColumnStyleDataGridTextBoxColumn.MappingName = "prenom";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.Ajouter);
            this.mainMenu1.MenuItems.Add(this.Modifier);
            this.mainMenu1.MenuItems.Add(this.Supprimer);
            // 
            // Ajouter
            // 
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Text = "Modifier";
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Synchroniser
            // 
            this.Synchroniser.Location = new System.Drawing.Point(75, 196);
            this.Synchroniser.Name = "Synchroniser";
            this.Synchroniser.Size = new System.Drawing.Size(91, 27);
            this.Synchroniser.TabIndex = 0;
            this.Synchroniser.Text = "Synchroniser";
            this.Synchroniser.Click += new System.EventHandler(this.Synchroniser_Click);
            // 
            // eurequatDataSet
            // 
            this.eurequatDataSet.DataSetName = "EurequatDataSet";
            this.eurequatDataSet.Prefix = "";
            this.eurequatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataMember = "personne";
            this.personneBindingSource.DataSource = this.eurequatDataSet;
            // 
            // personneTableAdapter
            // 
            this.personneTableAdapter.ClearBeforeFill = true;
            // 
            // personneDataGrid
            // 
            this.personneDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.personneDataGrid.DataSource = this.personneBindingSource;
            this.personneDataGrid.Location = new System.Drawing.Point(29, 46);
            this.personneDataGrid.Name = "personneDataGrid";
            this.personneDataGrid.Size = new System.Drawing.Size(181, 115);
            this.personneDataGrid.TabIndex = 1;
            this.personneDataGrid.TableStyles.Add(this.personneTableStyleDataGridTableStyle);
            // 
            // personneTableStyleDataGridTableStyle
            // 
            this.personneTableStyleDataGridTableStyle.GridColumnStyles.Add(idDataGridColumnStyleDataGridTextBoxColumn);
            this.personneTableStyleDataGridTableStyle.GridColumnStyles.Add(nomDataGridColumnStyleDataGridTextBoxColumn);
            this.personneTableStyleDataGridTableStyle.GridColumnStyles.Add(prenomDataGridColumnStyleDataGridTextBoxColumn);
            this.personneTableStyleDataGridTableStyle.MappingName = "personne";
            // 
            // Supprimer
            // 
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.personneDataGrid);
            this.Controls.Add(this.Synchroniser);
            this.Menu = this.mainMenu1;
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eurequatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Synchroniser;
        private EurequatDataSet eurequatDataSet;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private Synchronisation.EurequatDataSetTableAdapters.personneTableAdapter personneTableAdapter;
        private System.Windows.Forms.DataGrid personneDataGrid;
        private System.Windows.Forms.DataGridTableStyle personneTableStyleDataGridTableStyle;
        private System.Windows.Forms.MenuItem Ajouter;
        private System.Windows.Forms.MenuItem Modifier;
        private System.Windows.Forms.MenuItem Supprimer;
    }
}

