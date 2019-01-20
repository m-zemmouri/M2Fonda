using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROA.TP2.Little
{
    //public class Graphe
    //{
    //    #region Fields

    //    int dimension = 2;

    //    List<Ville> villes = new List<Ville>();
    //    public List<Ville> villesDepart = new List<Ville>();
    //    public List<Ville> villesArrive = new List<Ville>();

    //    #endregion

    //    #region Properties


    //    public string Nom { get; set; }
    //    public bool Semetrique { get; set; } = true;
    //    public int[,] Matrice { get; set; } = new int[2, 2];
    //    public int[,] Reduction { get; set; } = new int[2, 2];
    //    public int[,] Regret { get; set; } = new int[2, 2];

    //    public List<Ville> Villes
    //    {
    //        get
    //        {
    //            return villes;
    //        }
    //        set
    //        {
    //            villes = value;
    //            villesDepart = value;
    //            villesArrive = value;
    //        }
    //    }

    //    public List<string> VillesReduction
    //    {
    //        get
    //        {
    //            List<string> result = new List<string>();
    //            for (int i = 0; i < Villes.Count; i++)
    //            {
    //                result.Add(Villes[i].Name);
    //            }
    //            result.Add("Min");
    //            return result;
    //        }
    //    }
    //    public int Dimension
    //    {
    //        get
    //        {
    //            return dimension;
    //        }
    //        set
    //        {
    //            if (dimension != value)
    //            {
    //                List<Ville> NewVille = new List<Ville>();
    //                int[,] NewMatrice = new int[value, value];
    //                int[,] NewReduction = new int[value + 1, value + 1];
    //                int[,] NewRegret = new int[value + 1, value + 1];
    //                int i;
    //                for (i = 0; i < Math.Min(dimension, value); i++)
    //                {
    //                    for (int j = 0; j < Math.Min(dimension, value); j++)
    //                    {
    //                        NewMatrice[i, j] = Matrice[i, j];
    //                        //NewReduction[i, j] = Reduction[i, j];
    //                        //NewRegret[i, j] = Regret[i, j];
    //                    }
    //                }
    //                while (Villes.Count > value)
    //                {
    //                    Villes.RemoveAt(Villes.Count - 1);
    //                }
    //                while (Villes.Count < value)
    //                {
    //                    Villes.Add(new Ville(Villes.Count));
    //                }
    //                dimension = value;
    //                Matrice = NewMatrice;
    //                Reduction = NewReduction;
    //                Regret = NewRegret;
    //            }
    //        }
    //    }

    //    public int Evaluation { get; set; }

    //    public ArcSeparation ArcSeparation = new ArcSeparation();
    //    public string Separation { get { return Villes[ArcSeparation.Depart] + "→" + Villes[ArcSeparation.Arrive]; } }

    //    public Graphe Avec { get; set; } = null;

    //    public int Sans { get; set; }

    //    #endregion

    //    #region Methods

    //    #region Reduction
    //    public void calculeReduction()
    //    {
    //        int min;
    //        int evaluation = 0;
    //        for (int i = 0; i < dimension; i++)
    //        {
    //            min = getMinRow(Matrice, i);
    //            for (int j = 0; j < dimension; j++)
    //            {
    //                if (Matrice[i, j] == -1 || min == -1)
    //                    Reduction[i, j] = -1;
    //                else
    //                    Reduction[i, j] = Matrice[i, j] - min;
    //            }
    //            Reduction[i, dimension] = min;
    //            evaluation += min;
    //        }

    //        for (int j = 0; j < dimension; j++)
    //        {
    //            min = getMinCol(Reduction, j);
    //            if (min > 0)
    //            {
    //                for (int i = 0; i < dimension; i++)
    //                {
    //                    if (Reduction[i, j] != -1)
    //                        Reduction[i, j] = Reduction[i, j] - min;
    //                }
    //            }
    //            Reduction[dimension, j] = min;
    //            evaluation += min;
    //        }
    //        Reduction[dimension, dimension] = evaluation;
    //        calculeRegret();
    //    }

    //    public int getMinRow(int[,] matrice, int index)
    //    {
    //        int min = -1;
    //        int val;
    //        for (int j = 0; j < Dimension; j++)
    //        {
    //            val = matrice[index, j];
    //            if (val > -1 && val < min ||
    //                val > -1 && min == -1)
    //                min = val;
    //        }
    //        return min;
    //    }
    //    public int getMinCol(int[,] matrice, int index)
    //    {
    //        int min = -1;
    //        int val;
    //        for (int i = 0; i < Dimension; i++)
    //        {
    //            val = matrice[i, index];
    //            if (val > -1 && val < min ||
    //                val > -1 && min == -1)
    //                min = val;
    //        }
    //        return min;
    //    }

    //    #endregion

    //    #region Regret
    //    public void calculeRegret()
    //    {
    //        for (int i = 0; i < Dimension; i++)
    //            rowRegret(i);
    //        for (int j = 0; j < Dimension; j++)
    //            colRegret(j);
    //        maxRegret();
    //        Sans = Evaluation + Regret[Dimension, Dimension];
    //    }

    //    public void rowRegret(int index)
    //    {
    //        int regret = -1;
    //        List<int> list = new List<int>();
    //        for (int j = 0; j < Dimension; j++)
    //        {
    //            if (Reduction[index, j] > -1)
    //            {
    //                list.Add(Reduction[index, j]);
    //            }
    //        }
    //        list.Sort();
    //        if (list.Count > 1)
    //        {
    //            regret = list[1];
    //        }
    //        for (int j = 0; j < Dimension; j++)
    //        {
    //            if (Reduction[index, j] == 0)
    //            {
    //                Regret[index, j] = regret;
    //            }
    //        }
    //        Regret[index, Dimension] = regret;
    //    }
    //    public void colRegret(int index)
    //    {
    //        int regret = -1;
    //        List<int> list = new List<int>();
    //        for (int i = 0; i < Dimension; i++)
    //        {
    //            if (Reduction[i, index] > -1)
    //            {
    //                list.Add(Reduction[i, index]);
    //            }
    //        }
    //        list.Sort();
    //        if (list.Count > 1)
    //        {
    //            regret = list[1];
    //        }
    //        for (int i = 0; i < Dimension; i++)
    //        {
    //            if (Reduction[i, index] == 0)
    //            {
    //                Regret[i, index] = regret == -1 || Regret[i, index] == -1 ? -1 : Regret[i, index] + regret;
    //            }
    //        }
    //        Regret[Dimension, index] = regret;
    //    }
    //    public void maxRegret()
    //    {
    //        for (int i = 0; i < Dimension; i++)
    //        {
    //            for (int j = 0; j < Dimension; j++)
    //            {
    //                if (Reduction[i, j] == 0)
    //                {
    //                    if (Regret[i, j] == -1 || Regret[i, j] > Regret[Dimension, Dimension])
    //                    {
    //                        Regret[Dimension, Dimension] = Regret[i, j];
    //                        ArcSeparation.Depart = i;
    //                        ArcSeparation.Arrive = j;
    //                        if (Regret[Dimension, Dimension] == -1)
    //                            return;
    //                    }
    //                }
    //            }
    //        }
    //    }

    //    #endregion

    //    #endregion

    //}

    public struct Arc
    {
        internal string Depart;
        internal string Destination;
        internal bool IsArc ;

        public Arc(string depart, string destination, bool isArc=true)
        {
            this.Depart = depart;
            this.Destination = destination;
            this.IsArc = isArc;
        }
        public override string ToString()
        {
            return Depart + (IsArc?"→": "↛") + Destination;
        }
    }  

    public class CellGraphe
    {
        private int valeur = -1;
        internal int Valeur
        {
            get
            {
                return valeur;
            }
            set
            {
                valeur = value;
                if (valeur < -1) valeur = -1;
            }
        }
        internal int Reduction { get; set; } = -1;
        internal int Regret { get; set; } = -1;
    }

    //public struct ArcSeparation { internal int Depart; internal int Destination; public override string ToString() { return ""; } };

    public class Ville
    {
        public Ville() : this("Ville")
        {
        }
        public Ville(string Name)
        {
            this.Name = Name;
        }
        public Ville(int Index)
        {
            this.Name = ((char)(65 + Index)).ToString();
        }
        public string Name { get; set; }

    }

  }
