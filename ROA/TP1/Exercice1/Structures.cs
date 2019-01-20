using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROA.TP1.Exercice1
{
    public class Objet
    {
        public string Nom { get; set; }
        public int Poids { get; set; }
        public int Utilite { get; set; }
    }

    public class Combinaison
    {
        public Combinaison(List<Objet> objets, int value)
        {

            this.value = value;

            valueString = Convert.ToString(value, 2).PadLeft(objets.Count, '0');
            for (int i = 0; i < valueString.Length; i++)
            {
                if (valueString[i] == '1')
                {
                    Poids += objets[i].Poids;
                    Utilite += objets[i].Utilite;
                }
            }
        }
        int value;
        string valueString;
        public int Poids { get; set; }
        public int Utilite { get; set; }
        public int Value { get { return value; } }
        public string String { get { return valueString; } }
        public string toString()
        {
            return "{Poids: " + Poids + ", Utilité: " + Utilite + ", Combinaison: " + String + "}";
        }
    }
    public class Jeu
    {
        public string Nom { get; set; }
        public int? Temps { get; set; } = null;
        public bool Parallel { get; set; } = false;
        public int Poids_Max { get; set; } = 50;
        public int Nombre_Objet { get { return Objets.Count; } }
        public List<Objet> Objets { get; set; } = new List<Objet>();
        public List<Combinaison> Combinaisons { get; set; } = new List<Combinaison>();
        public List<Combinaison> Resultats
        {
            get
            {
                List<Combinaison> resultat = new List<Combinaison>();
                int utilite = -1;
                foreach (Combinaison item in Combinaisons)
                {
                    if (item.Poids <= Poids_Max)
                    {
                        if (item.Utilite == utilite) resultat.Add(item);
                        else if (item.Utilite > utilite) { resultat.Clear(); resultat.Add(item); utilite = item.Utilite; }
                    }
                }
                return resultat;
            }
        }

        public string ResultatString
        {
            get
            {
                return Resultats.Count == 0 ? "" : Resultats[0].toString();
            }
        }
        public int ResultatPoids
        {
            get
            {
                return Resultats.Count == 0 ? 0 : Resultats[0].Poids;
            }
        }
        public int ResultatUtilite
        {
            get
            {
                return Resultats.Count == 0 ? 0 : Resultats[0].Utilite;
            }
        }
        public int ResultatNombre
        {
            get
            {
                return Resultats.Count;
            }
        }
    }
}
