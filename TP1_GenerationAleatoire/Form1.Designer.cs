namespace TP1_GenerationAleatoire
{
    partial class Form1
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
            this.diagram1 = new TP1_GenerationAleatoire.Diagram();
            ((System.ComponentModel.ISupportInitialize)(this.tbHauteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefinitionVerticale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombreClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHauteur
            // 
            this.tbHauteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHauteur.Location = new System.Drawing.Point(1391, 12);
            this.tbHauteur.Maximum = new decimal(new int[] {
            10000,
            0,
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
            this.tbDefinitionVerticale.Location = new System.Drawing.Point(1391, 38);
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
            this.tbNombreClasses.Location = new System.Drawing.Point(1391, 64);
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
            // diagram1
            // 
            this.diagram1.DefinitionVerticale = 10;
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Left;
            this.diagram1.Hauteur = 100;
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Name = "diagram1";
            this.diagram1.NombreClasse = 100;
            this.diagram1.Size = new System.Drawing.Size(1117, 474);
            this.diagram1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 474);
            this.Controls.Add(this.tbNombreClasses);
            this.Controls.Add(this.tbDefinitionVerticale);
            this.Controls.Add(this.tbHauteur);
            this.Controls.Add(this.diagram1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbHauteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefinitionVerticale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNombreClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Diagram diagram1;
        private System.Windows.Forms.NumericUpDown tbHauteur;
        private System.Windows.Forms.NumericUpDown tbDefinitionVerticale;
        private System.Windows.Forms.NumericUpDown tbNombreClasses;
    }
}