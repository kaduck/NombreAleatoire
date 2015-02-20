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
    public partial class MainForm : Form
    {
        double[] tabDouble;
        int[] tabInt;
        public MainForm()
        {
            InitializeComponent();
            tabDouble = Fonction.LoiUniforme(1000);
            this.diagram1.DessinerDiagram(tabDouble);
            btKhiPoisson.Visible = false;
            btKhiUniforme.Visible = false;
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

        private void btChoixMethode_Click(object sender, EventArgs e)
        {
            double alpha, beta;
            if (double.TryParse(tbAlpha.Text, out alpha) && double.TryParse(tbBeta.Text, out beta) && alpha > 0d && beta > 0d)
            {
                switch (cbMethodes.Text)
                {
                    case "Uniforme":
                        //TODO
                        tabDouble = Fonction.LoiUniforme((int)tbNbValeurs.Value);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = true;
                        break;
                    case "Exponentielle":
                        //TODO
                        tabDouble = Fonction.LoiExponentielle((int)tbNbValeurs.Value, alpha);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = false;
                        break;
                    case "Normale":
                        //TODO
                        tabDouble = Fonction.LoiNormale((int)tbNbValeurs.Value);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = false;
                        break;
                    case "Poisson":
                        //TODO
                        tabInt = Fonction.LoiPoisson((int)tbNbValeurs.Value, alpha);
                        diagram1.DessinerDiagram(tabInt);
                        btKhiPoisson.Visible = true;
                        btKhiUniforme.Visible = false;
                        break;
                    case "Weibull":
                        //TODO
                        tabDouble = Fonction.LoiWeibull((int)tbNbValeurs.Value, alpha, beta);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = false;
                        break;
                    default:
                        tabDouble = Fonction.LoiUniforme((int)tbNbValeurs.Value);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = false;
                        break;
                }
            }
            else
            {
                MessageBox.Show("alpha et beta doivent être deux rééls positifs");
            }
        }
        private enum enumMethodes
        {
            Uniforme,
            Exponentielle,
            Weibull,
            Normale,
            Poisson
        }

        private void btKhiPoisson_Click(object sender, EventArgs e)
        {
            RetourKhi2 khi = Khi_Deux.TesterPoisson(tabInt.Length, tabInt);
            MessageBox.Show("Distance théorique calculée : " + khi.d +"\nDistance obtenue : " + khi.khi2);
        }

        private void btKhiUniforme_Click(object sender, EventArgs e)
        {
            RetourKhi2 khi = Khi_Deux.TesterUniforme(tabDouble.Length, tabDouble);
            MessageBox.Show("Distance théorique calculée : " + khi.d + "\nDistance obtenue : " + khi.khi2);
        }

        private void diagram1_Load(object sender, EventArgs e)
        {

        }
    }
}
