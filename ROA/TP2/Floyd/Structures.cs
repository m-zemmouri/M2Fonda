using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROA.TP2.Floyd
{
    public class Graphe
    {
        int dimension = 2;
        public string Nom { get; set; }
        public int? Temps { get; set; } = null;
        public bool Parallel { get; set; } = false;
        public bool Semetrique { get; set; } = true;
        public int[,] Matrice { get; set; } = new int[2, 2];
        public int[,] Cout { get; set; } = new int[2, 2];
        public int[,] Suivant { get; set; } = new int[2, 2];
        public int Dimension
        {
            get
            {
                return dimension;
            }
            set
            {
                if (dimension != value)
                {
                    int[,] NewMatrice = new int[value, value];
                    int[,] NewCout = new int[value, value];
                    int[,] NewSuivant = new int[value, value];
                    for (int i = 0; i < Math.Min(dimension, value); i++)
                    {
                        for (int j = 0; j < Math.Min(dimension, value); j++)
                        {
                            NewMatrice[i, j] = Matrice[i, j];
                            NewCout[i, j] = Cout[i, j];
                            NewSuivant[i, j] = Suivant[i, j];
                        }
                    }
                    dimension = value;
                    Matrice = NewMatrice;
                    Cout = NewCout;
                    Suivant = NewSuivant;
                }
            }
        }
        public string Solution { get; set; }
    }
}
