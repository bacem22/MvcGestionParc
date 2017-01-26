using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeParc;
using System.Data.SqlClient;

namespace GestionDeParc_DAO
{
    public class ParcDAO
    {
        public string AjouterVehicule(Vehicule item)
        {
            string cnxString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Parc";
            SqlConnection cnx = new SqlConnection(cnxString);

try 
	{	        
		            cnx.Open();
            String req = "Insert Into Vehicule(Nom,Marque,Matricule,Couleur,Type_V,Date_Entrer,Date_Sortir,Montant) Values ('"+item.Nom+"','"+item.Marque+"','"+item.Matricule+"','"+item.Couleur+"','"+item.Type_V+"','"+item.Date_Entrer+"','"+item.Date_Sortir+"','"+item.Montant+"');";
            SqlCommand cmd = new SqlCommand(req, cnx);
            if(cmd.ExecuteNonQuery()>0)
            {
                cnx.Close();
                return "Insertion validé";
            }
            else
            {
                cnx.Close();
                return "Erreur !!!";
            }
	}
	catch (Exception ex)
	{
		cnx.Close();
		return "Erreur" +ex;
	}
        }

///////////////////////////////////////////////////////

        public List<Vehicule> GetAllVehicule()
        {
        List<Vehicule> allVehicule = new List<Vehicule>();
        string cnxString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Parc";
        SqlConnection cnx = new SqlConnection(cnxString);

        cnx.Open();
        String rep = "select * from Vehicule";
        SqlCommand cmd = new SqlCommand(rep, cnx);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Vehicule item = new Vehicule();
            item.IdVehicule = Int32.Parse(reader["IdVehicule"].ToString());
            item.Nom = reader["Nom"].ToString();
            item.Marque = reader["Marque"].ToString();
            item.Matricule = reader["Matricule"].ToString();
            item.Couleur = reader["Couleur"].ToString();
            item.Type_V = reader["Type_V"].ToString();
            item.Date_Entrer = reader["Date_Entrer"].ToString();
            item.Date_Sortir = reader["Date_Sortir"].ToString();
            item.Montant = Double.Parse(reader["Montant"].ToString());
            allVehicule.Add(item);

        }
        cnx.Close();
        return allVehicule;

         
        }

///////////////////////////////////////////////////////

        public string SupprimerVehicule(int id)
    {
        string cnxString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Parc";
        SqlConnection cnx = new SqlConnection(cnxString);

        try
        {

            cnx.Open();
            String rep = "delete from Vehicule where IdVehicule=" + id;
            SqlCommand cmd = new SqlCommand(rep, cnx);

            if (cmd.ExecuteNonQuery() > 0)
            {
                cnx.Close();
                return "Véhicule supprimé";
            }
            else
            {
                cnx.Close();
                return "Erreur !!!";
            }
        }
        catch (Exception ex)
        {
            cnx.Close();
            return "Erreur !"+ex;
        }
    }

//////////////////////////////////////////////////////

        public string ModifierVehicule(Vehicule Veh)
   {
       string cnxString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Parc";
       SqlConnection cnx = new SqlConnection(cnxString);

       try
       {
           cnx.Open();
           String rep = "UPDATE Vehicule SET Nom='" + Veh.Nom + "',Marque='" + Veh.Marque + "',Matricule='" + Veh.Matricule + "',Couleur='" + Veh.Couleur + "',Type_V='" + Veh.Type_V + "',Date_Entrer='" + Veh.Date_Entrer + "',Date_Sortir='" + Veh.Date_Sortir + "',Montant='" + Veh.Montant + "' WHERE IdVehicule=" + Veh.IdVehicule + ";";
           SqlCommand cmd = new SqlCommand(rep, cnx);

           if (cmd.ExecuteNonQuery() > 0)
           {
               cnx.Close();
               return "Véhicule Modifier";
           }
           else
           {
               cnx.Close();
               return "Erreur !!!";
           }
       }
       catch (Exception ex)
       {
           cnx.Close();
           return "Erreur !" + ex;
       }
   }

    }
}
