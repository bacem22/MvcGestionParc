using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeParc;
using GestionDeParc_DAO;

namespace GestionDeParc_Forms
{
   
    public partial class Affichage : Form
    {
        ParcDAO parc = new ParcDAO();
        public Affichage()
        {
            InitializeComponent();
        }

        private void Affichage_Load(object sender, EventArgs e)
        {


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            list_Veh.Items.AddRange(parc.GetAllVehicule().ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicule veh = list_Veh.SelectedItem as Vehicule;
            Vehicule v = veh as Vehicule;
            textBox_id.Text = v.IdVehicule.ToString();
            textBox_Nom.Text = v.Nom.ToString();
            textBox_Marq.Text = v.Marque.ToString();
            textBox_Mat.Text = v.Matricule.ToString();
            textBox_Cou.Text = v.Couleur.ToString();
            textBox_type.Text = v.Type_V.ToString();
            dateTimePicker1.Text = v.Date_Entrer.ToString();
            dateTimePicker2.Text = v.Date_Sortir.ToString();
            textBox_Montant.Text = v.Montant.ToString();
        }

        private void but_mod_Click(object sender, EventArgs e)
        {
            Vehicule item = new Vehicule();
            item.IdVehicule = Int32.Parse(textBox_id.Text);
            item.Nom = textBox_Nom.Text;
            item.Marque = textBox_Marq.Text;
            item.Matricule = textBox_Mat.Text;
            item.Couleur = textBox_Cou.Text;
            if (textBox_type.Text == "Voiture")
            {
                item.Type_V = "Voiture";
            }
            else if (textBox_type.Text == "Camion")
            {
                item.Type_V = "Camion";
            }
            else if (textBox_type.Text == "Moto")
            {
                item.Type_V = "Moto";
            }
            else
            {
                MessageBox.Show("Selection le type de véhicule");
            }
            item.Date_Entrer = dateTimePicker1.Text;
            item.Date_Sortir = dateTimePicker2.Text;
            item.Montant = Double.Parse(textBox_Montant.Text);

            MessageBox.Show(parc.ModifierVehicule(item));
        }

        private void but_sup_Click(object sender, EventArgs e)
        {
            Vehicule veh = list_Veh.SelectedItem as Vehicule;
            if (list_Veh.SelectedItem == null)
            {
                MessageBox.Show("Séléctionné véhicule");
            }
            else
            {
                MessageBox.Show(parc.SupprimerVehicule(veh.IdVehicule));
            }
        }
    }
}
