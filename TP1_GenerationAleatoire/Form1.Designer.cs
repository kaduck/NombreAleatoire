namespace TP1_GenerationAleatoire
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tbHauteur = new System.Windows.Forms.NumericUpDown();
            this.tbDefinitionVerticale = new System.Windows.Forms.NumericUpDown();
            this.tbNombreClasses = new System.Windows.Forms.NumericUpDown();
            this.lbHauteur = new System.Windows.Forms.Label();
            this.lbNbClasses = new System.Windows.Forms.Label();
            this.lbEchelleVerticale = new System.Windows.Forms.Label();
            this.cbMethodes = new System.Windows.Forms.ComboBox();
            this.lbChoixMethodes = new System.Windows.Forms.Label();
            this.btChoixMethode = new System.Windows.Forms.Button();
            this.tbBeta = new System.Windows.Forms.TextBox();
            this.tbAlpha = new System.Windows.Forms.TextBox();
            this.lbAlpha = new System.Windows.Forms.Label();
            this.lbBeta = new System.Windows.Forms.Label();
            this.tbNbValeurs = new System.Windows.Forms.NumericUpDown();
            this.lbNbValeurs = new System.Windows.Forms.Label();
            this.btKhiPoisson = new System.Windows.Forms.Button();
            this.btKhiUniforme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTailleIntervallePoisson = new System.Windows.Forms.NumericUpDown();
            this.dgvPoisson = new System.Windows.Forms.DataGridView();
            this.diagram1 = new TP1_GenerationAleatoire.Diagram();
            this.Intervalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Simule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calcule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbHauteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefinitionVerticale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombreClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbValeurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTailleIntervallePoisson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoisson)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHauteur
            // 
            this.tbHauteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHauteur.Location = new System.Drawing.Point(1059, 12);
            this.tbHauteur.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.tbHauteur.Name = "tbHauteur";
            this.tbHauteur.Size = new System.Drawing.Size(59, 20);
            this.tbHauteur.TabIndex = 1;
            this.tbHauteur.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tbHauteur.ValueChanged += new System.EventHandler(this.tbHauteur_ValueChanged);
            // 
            // tbDefinitionVerticale
            // 
            this.tbDefinitionVerticale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefinitionVerticale.Location = new System.Drawing.Point(1059, 38);
            this.tbDefinitionVerticale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbDefinitionVerticale.Name = "tbDefinitionVerticale";
            this.tbDefinitionVerticale.Size = new System.Drawing.Size(59, 20);
            this.tbDefinitionVerticale.TabIndex = 2;
            this.tbDefinitionVerticale.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbDefinitionVerticale.ValueChanged += new System.EventHandler(this.tbDefinitionVerticale_ValueChanged);
            // 
            // tbNombreClasses
            // 
            this.tbNombreClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreClasses.Location = new System.Drawing.Point(1059, 64);
            this.tbNombreClasses.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbNombreClasses.Name = "tbNombreClasses";
            this.tbNombreClasses.Size = new System.Drawing.Size(59, 20);
            this.tbNombreClasses.TabIndex = 3;
            this.tbNombreClasses.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tbNombreClasses.ValueChanged += new System.EventHandler(this.tbNombreClasses_ValueChanged);
            // 
            // lbHauteur
            // 
            this.lbHauteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHauteur.AutoSize = true;
            this.lbHauteur.Location = new System.Drawing.Point(994, 14);
            this.lbHauteur.Name = "lbHauteur";
            this.lbHauteur.Size = new System.Drawing.Size(51, 13);
            this.lbHauteur.TabIndex = 4;
            this.lbHauteur.Text = "Hauteur :";
            // 
            // lbNbClasses
            // 
            this.lbNbClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNbClasses.AutoSize = true;
            this.lbNbClasses.Location = new System.Drawing.Point(942, 66);
            this.lbNbClasses.Name = "lbNbClasses";
            this.lbNbClasses.Size = new System.Drawing.Size(103, 13);
            this.lbNbClasses.TabIndex = 5;
            this.lbNbClasses.Text = "Nombre de classes :";
            // 
            // lbEchelleVerticale
            // 
            this.lbEchelleVerticale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEchelleVerticale.AutoSize = true;
            this.lbEchelleVerticale.Location = new System.Drawing.Point(954, 40);
            this.lbEchelleVerticale.Name = "lbEchelleVerticale";
            this.lbEchelleVerticale.Size = new System.Drawing.Size(91, 13);
            this.lbEchelleVerticale.TabIndex = 6;
            this.lbEchelleVerticale.Text = "Echelle verticale :";
            // 
            // cbMethodes
            // 
            this.cbMethodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMethodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethodes.FormattingEnabled = true;
            this.cbMethodes.Items.AddRange(new object[] {
            "Uniforme",
            "Exponentielle",
            "Normale",
            "Poisson",
            "Weibull",
            "Processus Poisson"});
            this.cbMethodes.Location = new System.Drawing.Point(988, 152);
            this.cbMethodes.Name = "cbMethodes";
            this.cbMethodes.Size = new System.Drawing.Size(121, 21);
            this.cbMethodes.TabIndex = 7;
            this.cbMethodes.SelectedIndexChanged += new System.EventHandler(this.cbMethodes_SelectedIndexChanged);
            // 
            // lbChoixMethodes
            // 
            this.lbChoixMethodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChoixMethodes.AutoSize = true;
            this.lbChoixMethodes.Location = new System.Drawing.Point(873, 155);
            this.lbChoixMethodes.Name = "lbChoixMethodes";
            this.lbChoixMethodes.Size = new System.Drawing.Size(109, 13);
            this.lbChoixMethodes.TabIndex = 8;
            this.lbChoixMethodes.Text = "Choix de la méthode :";
            // 
            // btChoixMethode
            // 
            this.btChoixMethode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChoixMethode.Location = new System.Drawing.Point(1035, 244);
            this.btChoixMethode.Name = "btChoixMethode";
            this.btChoixMethode.Size = new System.Drawing.Size(75, 23);
            this.btChoixMethode.TabIndex = 9;
            this.btChoixMethode.Text = "Génerer";
            this.btChoixMethode.UseVisualStyleBackColor = true;
            this.btChoixMethode.Click += new System.EventHandler(this.btChoixMethode_Click);
            // 
            // tbBeta
            // 
            this.tbBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBeta.Location = new System.Drawing.Point(1083, 182);
            this.tbBeta.Name = "tbBeta";
            this.tbBeta.Size = new System.Drawing.Size(27, 20);
            this.tbBeta.TabIndex = 10;
            // 
            // tbAlpha
            // 
            this.tbAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlpha.Location = new System.Drawing.Point(1003, 182);
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(27, 20);
            this.tbAlpha.TabIndex = 11;
            // 
            // lbAlpha
            // 
            this.lbAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlpha.AutoSize = true;
            this.lbAlpha.Location = new System.Drawing.Point(957, 185);
            this.lbAlpha.Name = "lbAlpha";
            this.lbAlpha.Size = new System.Drawing.Size(40, 13);
            this.lbAlpha.TabIndex = 12;
            this.lbAlpha.Text = "Alpha :";
            // 
            // lbBeta
            // 
            this.lbBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBeta.AutoSize = true;
            this.lbBeta.Location = new System.Drawing.Point(1042, 185);
            this.lbBeta.Name = "lbBeta";
            this.lbBeta.Size = new System.Drawing.Size(35, 13);
            this.lbBeta.TabIndex = 13;
            this.lbBeta.Text = "Beta :";
            // 
            // tbNbValeurs
            // 
            this.tbNbValeurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNbValeurs.Location = new System.Drawing.Point(1059, 208);
            this.tbNbValeurs.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbNbValeurs.Name = "tbNbValeurs";
            this.tbNbValeurs.Size = new System.Drawing.Size(59, 20);
            this.tbNbValeurs.TabIndex = 14;
            this.tbNbValeurs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbNbValeurs
            // 
            this.lbNbValeurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNbValeurs.AutoSize = true;
            this.lbNbValeurs.Location = new System.Drawing.Point(943, 210);
            this.lbNbValeurs.Name = "lbNbValeurs";
            this.lbNbValeurs.Size = new System.Drawing.Size(102, 13);
            this.lbNbValeurs.TabIndex = 15;
            this.lbNbValeurs.Text = "Nombre de valeurs :";
            // 
            // btKhiPoisson
            // 
            this.btKhiPoisson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btKhiPoisson.Location = new System.Drawing.Point(1023, 273);
            this.btKhiPoisson.Name = "btKhiPoisson";
            this.btKhiPoisson.Size = new System.Drawing.Size(86, 23);
            this.btKhiPoisson.TabIndex = 16;
            this.btKhiPoisson.Text = "Khi 2 Poisson";
            this.btKhiPoisson.UseVisualStyleBackColor = true;
            this.btKhiPoisson.Click += new System.EventHandler(this.btKhiPoisson_Click);
            // 
            // btKhiUniforme
            // 
            this.btKhiUniforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btKhiUniforme.Location = new System.Drawing.Point(1023, 302);
            this.btKhiUniforme.Name = "btKhiUniforme";
            this.btKhiUniforme.Size = new System.Drawing.Size(86, 23);
            this.btKhiUniforme.TabIndex = 17;
            this.btKhiUniforme.Text = "Khi 2 Uniforme";
            this.btKhiUniforme.UseVisualStyleBackColor = true;
            this.btKhiUniforme.Click += new System.EventHandler(this.btKhiUniforme_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1023, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Khi 2 Expo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(962, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Taille intervalle :";
            // 
            // tbTailleIntervallePoisson
            // 
            this.tbTailleIntervallePoisson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTailleIntervallePoisson.Location = new System.Drawing.Point(1059, 93);
            this.tbTailleIntervallePoisson.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTailleIntervallePoisson.Name = "tbTailleIntervallePoisson";
            this.tbTailleIntervallePoisson.Size = new System.Drawing.Size(59, 20);
            this.tbTailleIntervallePoisson.TabIndex = 20;
            this.tbTailleIntervallePoisson.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dgvPoisson
            // 
            this.dgvPoisson.AllowUserToAddRows = false;
            this.dgvPoisson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoisson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalle,
            this.Simule,
            this.Calcule});
            this.dgvPoisson.Location = new System.Drawing.Point(615, 20);
            this.dgvPoisson.Name = "dgvPoisson";
            this.dgvPoisson.ReadOnly = true;
            this.dgvPoisson.RowHeadersVisible = false;
            this.dgvPoisson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPoisson.Size = new System.Drawing.Size(255, 150);
            this.dgvPoisson.TabIndex = 21;
            // 
            // diagram1
            // 
            this.diagram1.DefinitionVerticale = 10;
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Left;
            this.diagram1.Hauteur = 100;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Name = "diagram1";
            this.diagram1.NombreClasse = 100;
            this.diagram1.Size = new System.Drawing.Size(601, 474);
            this.diagram1.TabIndex = 0;
            this.diagram1.Load += new System.EventHandler(this.diagram1_Load);
            // 
            // Intervalle
            // 
            this.Intervalle.HeaderText = "Intervalle";
            this.Intervalle.Name = "Intervalle";
            this.Intervalle.ReadOnly = true;
            this.Intervalle.Width = 101;
            // 
            // Simule
            // 
            this.Simule.HeaderText = "Simulé";
            this.Simule.Name = "Simule";
            this.Simule.ReadOnly = true;
            this.Simule.Width = 75;
            // 
            // Calcule
            // 
            this.Calcule.HeaderText = "Calculé";
            this.Calcule.Name = "Calcule";
            this.Calcule.ReadOnly = true;
            this.Calcule.Width = 75;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 474);
            this.Controls.Add(this.dgvPoisson);
            this.Controls.Add(this.tbTailleIntervallePoisson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btKhiUniforme);
            this.Controls.Add(this.btKhiPoisson);
            this.Controls.Add(this.lbNbValeurs);
            this.Controls.Add(this.tbNbValeurs);
            this.Controls.Add(this.lbBeta);
            this.Controls.Add(this.lbAlpha);
            this.Controls.Add(this.tbAlpha);
            this.Controls.Add(this.tbBeta);
            this.Controls.Add(this.btChoixMethode);
            this.Controls.Add(this.lbChoixMethodes);
            this.Controls.Add(this.cbMethodes);
            this.Controls.Add(this.lbEchelleVerticale);
            this.Controls.Add(this.lbNbClasses);
            this.Controls.Add(this.lbHauteur);
            this.Controls.Add(this.tbNombreClasses);
            this.Controls.Add(this.tbDefinitionVerticale);
            this.Controls.Add(this.tbHauteur);
            this.Controls.Add(this.diagram1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbHauteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefinitionVerticale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombreClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbValeurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTailleIntervallePoisson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoisson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Diagram diagram1;
        private System.Windows.Forms.NumericUpDown tbHauteur;
        private System.Windows.Forms.NumericUpDown tbDefinitionVerticale;
        private System.Windows.Forms.NumericUpDown tbNombreClasses;
        private System.Windows.Forms.Label lbHauteur;
        protected System.Windows.Forms.Label lbNbClasses;
        private System.Windows.Forms.Label lbEchelleVerticale;
        private System.Windows.Forms.ComboBox cbMethodes;
        protected System.Windows.Forms.Label lbChoixMethodes;
        private System.Windows.Forms.Button btChoixMethode;
        private System.Windows.Forms.TextBox tbBeta;
        private System.Windows.Forms.TextBox tbAlpha;
        protected System.Windows.Forms.Label lbAlpha;
        protected System.Windows.Forms.Label lbBeta;
        private System.Windows.Forms.NumericUpDown tbNbValeurs;
        protected System.Windows.Forms.Label lbNbValeurs;
        private System.Windows.Forms.Button btKhiPoisson;
        private System.Windows.Forms.Button btKhiUniforme;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbTailleIntervallePoisson;
        private System.Windows.Forms.DataGridView dgvPoisson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calcule;
    }
}