using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_GenerationAleatoire
{
    public static class Fonction
    {
        private static Random r = new Random();
        /// <summary>
        /// Génération d'un nombre aléatoire en utilisant la loi Uniforme
        /// </summary>
        /// <param name="size">Nombre de valeur à générer</param>
        /// <returns>Tableau de valeur de type double</returns>
        public static double[] LoiUniforme(int size)
        {
            double[] v = new double[size];

            for (int i = 0; i < size; i++)
            {
                v[i] = r.NextDouble();
            }
            return v;
        }
        /// <summary>
        /// Génération d'un nombre aléatoire en utilisant la loi Exponentielle
        /// </summary>
        /// <param name="size">Nombre de valeur à générer</param>
        /// <param name="alpha">valeur du paramètre alpha de la formule </param>
        /// <returns></returns>
        public static double[] LoiExponentielle(int size, double alpha)
        {
            double[] v = new double[size];

            for (int i = 0; i < size; i++)
            {
                double value = r.NextDouble();
                v[i] = -(Math.Log(1 - value)) / alpha;
            }

            return v;
        }
        public static double LoiRepartitionExponentielleSingle(double alpha)
        {
            double value = r.NextDouble();
            return -(Math.Log(1 - value)) / alpha;
        }
        public static double LoiExponentielleSingle(double lambda, double ix)
        {
            double value = r.NextDouble();
            return lambda * Math.Exp(-lambda * ix);
        }
        public static double[] LoiNormale(int size)
        {
            double[] U = new double[size];
            double[] V = new double[size];
            double[] x = new double[size];
            U = LoiUniforme(size);
            V = LoiUniforme(size);

            for (int i = 0; i < size; i++)
            {   
                //x : racine(-2*ln*u) * cos * 2 * pi * v
                x[i] = Math.Sqrt(-2 * Math.Log(U[i])) * Math.Cos(2 * Math.PI * V[i]);

            }

            return x;
        }

        public static long Factoriel(long n)
        {
            return n > 1 ? n * Factoriel(n - 1) : 1;
        }

        public static int[] LoiPoisson(int size, double alpha)
        {
            int[] x = new int[size];

            for (int i = 0; i < size; i++)
            {
                x[i] = -1;
                double p = 0;
                while (p < 1) 
                {
                    p = p + Fonction.LoiRepartitionExponentielleSingle(alpha);
                    x[i]++;
                }
            }
            return x;
        }
        public static double[] LoiWeibull(int size, double alpha, double beta)
        {
            double[] v = new double[size];

            for (int i = 0; i < size; i++)
            {
                double value = r.NextDouble();
                v[i] = -(Math.Pow(Math.Log(1 - value), (1.00 / beta))) / alpha;
                v[i] = Math.Pow(-(Math.Log(1 - value) / (Math.Pow(alpha, beta))), (1.00 / beta));
            }

            return v;
        }
        public static double[] ProcessusPoisson(int size, double alpha)
        {
            double[] tableauCount = new double[size];
            for (int i = 0; i < size; i++)
            {
                double exp = LoiRepartitionExponentielleSingle(alpha);
                tableauCount[i] = (i > 0) ? exp + tableauCount[i - 1] : exp;
            }
            return tableauCount;
        }
    }
}
