using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParc
{
    class Parc
    {
        private int idParc;
        private string nom_em;
        private string taille;

        public int IdParc
        {
            get { return idParc; }
            set { idParc = value; }
        }
        public string Nom_Em
        {
            get { return nom_em; }
            set { nom_em = value; }
        }
        public string Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public Parc (int id, string nom, string taille)
        {
            IdParc = id;
            Nom_Em = nom;
            Taille = taille;
        }
        public Parc()
        {

        }

        public override string ToString()
        {
            return "Nom de l'emplacement: "+Nom_Em+ "Taille de lemplacement: "+Taille;
        }
        public void afficher ()
        {
            Console.WriteLine(ToString()); 
        }
    }
}
