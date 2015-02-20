using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP1_GenerationAleatoire
{
    public struct RetourKhi2
    {
        public double khi2;
        public double d;
    }

    public class Khi_Deux
    {
        public Khi_Deux()
        { }

        public static RetourKhi2 TesterUniforme(int size, double[] x)
        {
            // On tri le tableau
            Array.Sort(x);

            // On le range par classe
            List<double[]> classe = new List<double[]>();
            //

            var ranges = new[] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };

            var outval = x.GroupBy(a => ranges.FirstOrDefault(r => r > a))
                      .Select(g => new { Classe = g.Key, Effectif = g.Count() })
                      .ToList();

            foreach (var item in outval)
            {
                double[] tmp = new double[2];
                tmp[0] = (double)item.Classe;
                tmp[1] = item.Effectif;
                classe.Add(tmp);
            }

            // On calcule la moyenne
            double moy = 0.00;
            foreach (double[] myClass in classe)
            {
                moy += (myClass[1] * myClass[0]);
            }
            moy /= size;

            // On calcule les valeur theorique de la loi uniforme
            List<double[]> TheoUniforme = new List<double[]>();
            foreach (double[] myClass in classe)
            {
                double[] tmp = new double[2];
                tmp[0] = myClass[0];
                tmp[1] = size / ranges.Count();
                TheoUniforme.Add(tmp);
            }

            // On calcule le khi2 observé
            double d = 0;
            for (int i = 0; i < classe.Count; i++)
            {
                d += Math.Pow((double)classe[i][1] - TheoUniforme[i][1], 2) / TheoUniforme[i][1];
            }

            // On calcule le khi2
            double khi2 = alglib.invchisquaredistribution(classe.Count - 1, 0.05);

            RetourKhi2 ret;
            ret.d = d;
            ret.khi2 = khi2;
            return ret;
        }

        public static RetourKhi2 TesterPoisson(int size, int[] x)
        {
            // On tri le tableau
            Array.Sort(x);

            // On le range par classe
            List<int[]> classe = new List<int[]>();
            var outval = from ii in x group ii by ii into iiGroup select new { iiGroup, iiCount = iiGroup.Count() };
            foreach (var item in outval)
            {
                int[] tmp = new int[2];
                tmp[0] = (int)item.iiGroup.Key;
                tmp[1] = item.iiCount;
                classe.Add(tmp);
            }

            // On calcule la moyenne
            double moy = 0.00;
            foreach (int[] myClass in classe)
            {
                moy += (myClass[1] * myClass[0]);
            }
            moy /= size;

            // On calcule les valeur theorique de la loi de poisson
            List<double[]> TheoPoisson = new List<double[]>();
            foreach (int[] myClass in classe)
            {
                double[] tmp = new double[2];
                tmp[0] = myClass[0];
                tmp[1] = size * (Math.Exp(-moy) * Math.Pow(moy, myClass[0]) / Fonction.Factoriel(myClass[0]));
                TheoPoisson.Add(tmp);
            }

            // On calcule le khi2 observé
            double d = 0;
            for (int i = 0; i < classe.Count; i++)
            {
                d += Math.Pow((double)classe[i][1] - TheoPoisson[i][1], 2) / TheoPoisson[i][1];
            }

            // On calcule le khi2
            double khi2 = alglib.invchisquaredistribution(classe.Count - 1, 0.05);

            RetourKhi2 ret;
            ret.d = d;
            ret.khi2 = khi2;
            return ret;
        }
    }
}
