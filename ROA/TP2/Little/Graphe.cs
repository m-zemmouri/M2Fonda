using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROA.TP2.Little
{
    public class Graphe
    {
        #region Fields

        //float evaluation;
        public Dictionary<Arc, float> traget = new Dictionary<Arc, float>();
        public Arc CurrentArc = new Arc();
        public List<string> villesDepart = new List<string>();
        public List<string> villesDestination = new List<string>();
        List<Ville> villesName = new List<Ville>();

        Dictionary<Arc, float> Valeur = new Dictionary<Arc, float>();
        Dictionary<Arc, float> Reduction = new Dictionary<Arc, float>();
        Dictionary<Arc, float> Regret = new Dictionary<Arc, float>();

        
        #endregion

        #region Constructor

        public Graphe()
        {

        }

        public Graphe(int Dimension)
        {
            this.Dimension = Dimension;
        }



        #endregion

        #region Properties

        public string Nom { get; set; }
        public bool Semetrique { get; set; } = true;

        public List<Ville> VillesName
        {
            get
            {
                return villesName;
            }
            set
            {
                if (value != villesName)
                {
                    if (value != null && value.Count > 0)
                        villesName = value;
                    else
                        villesName.Clear();

                    if (Dimension != villesName.Count)
                        Dimension = villesName.Count;
                    else
                        RebuildVilles();
                }
            }
        }

        public int Dimension
        {
            get
            {
                return villesDepart.Count - 1;
            }
            set
            {
                if (Dimension != value)
                {
                    ChangeVilles(value);
                }
            }
        }

        public float Evaluation
        {
            get
            {
                return traget.Sum(t => t.Value);
            }
        }

        public Graphe Avec { get; set; } = null;

        public Graphe Sans { get; set; } = null;

        public bool IsSolution { get { return Dimension==0 && !Evaluation.IsInfinity(); } }

        #endregion

        #region Methods

        public void Read(float[,] matrice)
        {
            Dimension = Math.Min(matrice.GetLength(0), matrice.GetLength(1));
            Valeur.Clear();
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    //if (!float.IsPositiveInfinity(matrice[i, j]) && matrice[i, j] > -1)
                    if (!matrice[i, j].IsInfinity())
                    {
                        Arc arc = new Arc(villesDepart[i], villesDestination[j]);
                        Valeur[arc] = matrice[i, j];
                    }
                }
            }
        }

        public void RebuildVilles()
        {
            try
            {
                villesDepart.Clear();
                if (VillesName != null)
                    villesDepart = VillesName.Select(v => v.Name).ToList();
                villesDepart.Add("Min");

                villesDestination.Clear();
                villesDestination.AddRange(villesDepart);
            }
            catch (Exception ex)
            {
            }
        }

        void ChangeVilles(int NewDimension)
        {
            int OldDimention = villesName.Count;

            if (NewDimension < OldDimention)
                villesName.RemoveRange(NewDimension, OldDimention - NewDimension);
            else if (NewDimension > OldDimention)
            {
                if (NewDimension > villesName.Capacity)
                    villesName.Capacity = NewDimension;
                for (int i = OldDimention; i < NewDimension; i++)
                    villesName.Add(new Ville(i));
            }
            RebuildVilles();
            ClearGraphe();
        }

        public void ClearGraphe()
        {
            Valeur = Valeur.
                            Where(val => villesDepart.Any(v => v == val.Key.Depart) &&
                            villesDestination.Any(v => v == val.Key.Destination) &&
                            val.Key.Depart != "Min" && val.Key.Destination != "Min")
                            .ToDictionary(t => t.Key, t => t.Value);
            Reduction.Clear();
            Regret.Clear();
            Sans = null;
            Avec = null;
        }

        #endregion

        #region Reduction & Evaluation

        public float Evaluer(float bestSolution=float.PositiveInfinity)
        {
            float CurrentEvaluation = 0;
            try
            {
                float min;

                ClearGraphe();

                for (int i = 0; i < Dimension; i++)
                {
                    min = float.NaN;
                    var collection = from val in Valeur
                                     where val.Key.Depart == villesDepart[i] && val.Key.Destination != "Min"
                                     orderby val.Value
                                     select val.Value;

                    if (collection != null && collection.Count() > 0)
                        min = collection.First();

                    if (!float.IsNaN(min))
                    {
                        var tmpReduction = Valeur
                                    .Where(val => val.Key.Depart == villesDepart[i] && val.Key.Destination != "Min")
                                    .ToDictionary(t => t.Key, t => t.Value - min);

                        foreach (var entry in tmpReduction)
                            Reduction[entry.Key] = entry.Value;
                    }
                    else
                    {
                        min = float.PositiveInfinity;
                    }
                    Valeur[new Arc(villesDepart[i], "Min")] = min;

                    CurrentEvaluation += min;
                }

                for (int j = 0; j < Dimension; j++)
                {
                    min = 0;
                    var collection = from val in Reduction
                                     where val.Key.Destination == villesDestination[j] && val.Key.Depart != "Min"
                                     orderby val.Value
                                     select val.Value;

                    if (collection != null && collection.Count() > 0)
                    {
                        min = collection.First();
                        if (min > 0)
                        {
                            var tmpReduction = Reduction
                                                    .Where(val => val.Key.Destination == villesDestination[j] && val.Key.Depart != "Min")
                                                    .ToDictionary(t => t.Key, t => t.Value - min);

                            foreach (var entry in tmpReduction)
                                Reduction[entry.Key] = entry.Value;
                        }
                    }
                    Reduction[new Arc("Min", villesDestination[j])] = min;
                    CurrentEvaluation += min;
                }

                traget[CurrentArc] = CurrentEvaluation;
                Valeur[new Arc("Min", "Min")] = Evaluation;

                if (IsSolution)
                    bestSolution = Math.Min(bestSolution, Evaluation);
                else if (Evaluation < bestSolution)
                    bestSolution = Math.Min(bestSolution, Explore(bestSolution));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bestSolution;
        }

        #endregion

        #region Exploration & Separation
        public void calculeRegret()
        {
            float regret;

            for (int i = 0; i < Dimension; i++)
            {
                regret = float.PositiveInfinity;
                var collection = from val in Reduction
                                 where val.Key.Depart == villesDepart[i] && val.Key.Destination != "Min"
                                 orderby val.Value
                                 select val.Value;

                if (collection != null && collection.Count() > 1)
                    regret = collection.ElementAt(1);

                var tmpRegret = Reduction
                       .Where(item => item.Key.Depart == villesDepart[i] && item.Value == 0)
                       .ToDictionary(item => item.Key, item => regret);

                foreach (var entry in tmpRegret)
                    Regret[entry.Key] = entry.Value;

                Regret[new Arc(villesDepart[i], "Min")] = regret;
            }

            for (int j = 0; j < Dimension; j++)
            {
                regret = float.PositiveInfinity;
                var collection = from val in Reduction
                                 where val.Key.Destination == villesDestination[j] && val.Key.Depart != "Min"
                                 orderby val.Value
                                 select val.Value;

                if (collection != null && collection.Count() > 1)
                    regret = collection.ElementAt(1);

                var tmpRegret = Regret
                       .Where(item => item.Key.Destination == villesDestination[j])
                       .ToDictionary(item => item.Key, item => item.Value + regret);

                foreach (var entry in tmpRegret)
                    Regret[entry.Key] = entry.Value;

                Regret[new Arc("Min", villesDestination[j])] = regret;
            }
        }

        float Explore(float bestSolution)
        {
            //if (!Evaluation.IsInfinity())
            //if (Evaluation < bestSolution || bestSolution.IsInfinity())
            //{
            calculeRegret();

            //Max Regret
            var collection = from val in Regret
                             where val.Key.Depart != "Min" && val.Key.Destination != "Min"
                             orderby val.Value descending
                             select val;

            if (collection != null && collection.Count() > 0)
            {
                var maxRegret = collection.First();
                Regret[new Arc("Min", "Min")] = maxRegret.Value;
                if (Dimension > 0)
                {
                    Arc Separation = maxRegret.Key;
                    Avec = Separer(Separation);
                    bestSolution = Math.Min(bestSolution, Avec.Evaluer(bestSolution));

                    Separation.IsArc = false;
                    Sans = Separer(Separation);
                    //Sans.traget[Separation] = maxRegret.Value;
                    bestSolution = Math.Min(bestSolution, Sans.Evaluer(bestSolution));
                }
            }
            //}
            return bestSolution;
        }

        Graphe Separer(Arc arc)
        {
            Graphe result = new Graphe();

            result.CurrentArc = arc;
            //result.VillesName = VillesName;
            result.villesDepart.AddRange(villesDepart);
            result.villesDestination.AddRange(villesDestination);

            //Copy Valeur
            foreach (var entry in Reduction)
                result.Valeur[entry.Key] = entry.Value;

            //Copy traget
            foreach (var entry in traget)
                result.traget[entry.Key] = entry.Value;


            if (arc.IsArc)
            {
                result.villesDepart.Remove(arc.Depart);
                result.villesDestination.Remove(arc.Destination);
                if (Dimension > 2)
                    result.Valeur.Remove(new Arc(arc.Destination, arc.Depart));
            }
            else
            {
                //if (Dimension > 2)
                    result.Valeur.Remove(new Arc(arc.Depart, arc.Destination));
            }

            result.ClearGraphe();

            return result;
        }

        #endregion

        #region Indexer
        public float getValeur(string depart, string destination)
        {
            float result;
            Arc arc = new Arc(depart, destination);
            if (!Valeur.TryGetValue(arc, out result))
                result = float.PositiveInfinity;
            return result;
        }
        public float getValeur(int i, int j)
        {
            return getValeur(villesDepart[i], villesDestination[j]);
        }
        public float getReduction(string depart, string destination)
        {
            float result;
            Arc arc = new Arc(depart, destination);
            if (!Reduction.TryGetValue(arc, out result))
                result = float.PositiveInfinity;
            return result;
        }
        public float getReduction(int i, int j)
        {
            return getReduction(villesDepart[i], villesDestination[j]);
        }

        public float getRegret(string depart, string destination)
        {
            float result;
            Arc arc = new Arc(depart, destination);
            if (!Regret.TryGetValue(arc, out result))
                result = float.PositiveInfinity;
            return result;
        }
        public float getRegret(int i, int j)
        {
            return getRegret(villesDepart[i], villesDestination[j]);
        }
        #endregion
    }
}