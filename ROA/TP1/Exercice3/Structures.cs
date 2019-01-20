using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROA.TP1.Exercice3
{
    public class Graphe
    {
        int dimension = 2;
        public string Nom { get; set; }
        public int? Temps { get; set; } = null;
        public bool Parallel { get; set; } = false;
        public bool[,] Matrice { get; set; } = new bool[2, 2];
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
                    dimension = value;
                    Matrice = new bool[dimension, dimension];
                }
            }
        }
        public bool IsConnexe { get; set; }
        public bool IsEulerien { get; set; }
    }
}
