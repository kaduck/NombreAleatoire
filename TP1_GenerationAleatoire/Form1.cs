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
                        tabDouble = Fonction.LoiUniforme((int)tbNbValeurs.Value);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = true;
                        break;
                    case "Exponentielle":
                        tabDouble = Fonction.LoiExponentielle((int)tbNbValeurs.Value, alpha);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = false;
                        break;
                    case "Normale":
                        tabDouble = Fonction.LoiNormale((int)tbNbValeurs.Value);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = false;
                        break;
                    case "Poisson":
                        tabInt = Fonction.LoiPoisson((int)tbNbValeurs.Value, alpha);
                        diagram1.DessinerDiagram(tabInt);
                        btKhiPoisson.Visible = true;
                        btKhiUniforme.Visible = false;
                        break;
                    case "Weibull":
                        tabDouble = Fonction.LoiWeibull((int)tbNbValeurs.Value, alpha, beta);
                        diagram1.DessinerDiagram(tabDouble);
                        btKhiPoisson.Visible = false;
                        btKhiUniforme.Visible = false;
                        break;
                    case "Processus Poisson":
                        tabDouble = Fonction.ProcessusPoisson((int)tbNbValeurs.Value, alpha);
                        tabInt = Fonction.LoiPoisson((int)tbNbValeurs.Value, alpha);
                        diagram1.IsProcessusPoisson = true;
                        diagram1.DessinerDiagram(tabDouble);
                        diagram1.IsProcessusPoisson = false;
                        double max = tabDouble.Max();
                        double valueClasse = (double)tbNombreClasses.Value / max;
                        int classeParIntervalle = (int)Math.Round(tbTailleIntervallePoisson.Value) / (int)Math.Round(valueClasse);
                        int nombreIntervalle = (int)Math.Round(max) / (int)Math.Round(tbTailleIntervallePoisson.Value);
                        int sommePoisson = 0;
                        dgvPoisson.Rows.Clear();
                        for (int i = 0; i*(int)tbTailleIntervallePoisson.Value < max; i++)
                        {
                            int index = dgvPoisson.Rows.Add();
                            dgvPoisson.Rows[index].Cells["Intervalle"].Value = "[ " + (int)tbTailleIntervallePoisson.Value * (i) + " - " + (int)tbTailleIntervallePoisson.Value * (i + 1) + " [";
                            dgvPoisson.Rows[index].Cells["Simule"].Value = tabDouble.Where(t => t > (int)tbTailleIntervallePoisson.Value * i && t < (int)tbTailleIntervallePoisson.Value * (i + 1)).Count();
                            sommePoisson = 0;
                            for (int j = (int)tbTailleIntervallePoisson.Value * i; j <= ((int)tbTailleIntervallePoisson.Value * (i + 1))-1 && j < tabInt.Length-1; j++)
                            {
                                sommePoisson += tabInt[j];
                            }
                            int sommmetotale =0 ;
                            for (int j = 0; j < tabInt.Length - 1; j++)
                            {
                                sommmetotale += tabInt[j];
                            }
                            dgvPoisson.Rows[index].Cells["Calcule"].Value = sommePoisson;
                            //dgvPoisson.Rows[index].Cells["Calcule"].Value = tabInt.Where(t => t > (int)tbTailleIntervallePoisson.Value * i && t < (int)tbTailleIntervallePoisson.Value * (i + 1)).Count();

                        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            RetourKhi2 khi = Khi_Deux.TesterExponentielle(tabDouble.Length, tabDouble);
            MessageBox.Show("Distance théorique calculée : " + khi.d + "\nDistance obtenue : " + khi.khi2);
        }

        private void cbMethodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
