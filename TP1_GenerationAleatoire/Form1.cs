using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP1_GenerationAleatoire
{
    public partial class Form1 : Form
    {
        double[] tabDouble;
        public Form1()
        {
            InitializeComponent();
            tabDouble = Fonction.LoiUniforme(1000);
            this.diagram1.DessinerDiagram(tabDouble);
        }

        private void tbHauteur_ValueChanged(object sender, EventArgs e)
        {
            diagram1.Hauteur = (int)tbHauteur.Value;
            diagram1.Rafraichir();
        }

        private void tbDefinitionVerticale_ValueChanged(object sender, EventArgs e)
        {
            diagram1.DefinitionVerticale = (int)tbDefinitionVerticale.Value;
            diagram1.Rafraichir();
        }

        private void tbNombreClasses_ValueChanged(object sender, EventArgs e)
        {
            diagram1.NombreClasse = (int)tbNombreClasses.Value;
            this.diagram1.DessinerDiagram(tabDouble);
            diagram1.Rafraichir();
        }
    }
}
