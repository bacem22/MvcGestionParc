using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParc
{
   public class Vehicule
    {
       private int idVehicule;
       private string nom;
       private string marque;
       private string matricule;
       private string couleur;
       private string type_v;
       private string date_entrer;
       private string date_sortir;
       private double montant;

       public int IdVehicule
       {
           get { return idVehicule; }
           set { idVehicule = value; }
       }
       public string Nom
       {
           get { return nom; }
           set { nom = value; }
       }
       public string Marque
       {
           get { return marque; }
           set { marque = value; }
       }
       public string Matricule
       {
           get { return matricule; }
           set { matricule = value; }
       }
       public string Couleur
       {
           get { return couleur; }
           set { couleur = value; }
       }
       public string Type_V
       {
           get { return type_v; }
           set { type_v = value; }
       }
       public string Date_Entrer
       {
           get { return date_entrer; }
           set { date_entrer = value; }
       }

       public string Date_Sortir
       {
           get { return date_sortir; }
           set { date_sortir = value; }
       }
       public double Montant
       {
           get { return montant; }
           set { montant = value; }
       }


       public Vehicule(int id, string nom, string mar, string mat, string cou, string type, string date_e,
           string date_s, double mon)
       {
           IdVehicule = id;
           Nom = nom;
           Marque = mar;
           Matricule = mat;
           Couleur = cou;
           Type_V = type;
           Date_Entrer = date_e;
           Date_Sortir = date_s;
           Montant = mon;

       }

       public Vehicule ()
       {

       }

       public override string ToString()
       {
           return "Nom: "+Nom+ "Marque: "+Marque+ "Maricule :"+Matricule+
               "Couleur: "+Couleur+ "Type véhicule: "+Type_V+ "Date d'entrer: "+Date_Entrer+
               "Date de sortir: "+Date_Sortir+ "Montant de parc: "+Montant;
       }

       public void afficher ()
       {
           Console.WriteLine(ToString());
       }
    }
}
