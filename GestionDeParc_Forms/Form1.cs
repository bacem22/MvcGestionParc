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
    public partial class Form1 : Form
    {
        ParcDAO parc = new ParcDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_Type.Items.Add("Voiture");
            combo_Type.Items.Add("Camion");
            combo_Type.Items.Add("Moto");

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm:ss";

        }

        private void butn_Ajouter_Click(object sender, EventArgs e)
        {
 
            Vehicule item = new Vehicule();
            item.Nom = textBox_Nom.Text;
            item.Marque = textBox_Marq.Text;
            item.Matricule = textBox_Mat.Text;
            item.Couleur = textBox_Cou.Text;
            if (combo_Type.SelectedIndex == 0)
            {
                item.Type_V = "Voiture";
            }
            else if (combo_Type.SelectedIndex == 1)
            {
                item.Type_V = "Camion";
            }
            else if (combo_Type.SelectedIndex == 2)
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

            MessageBox.Show(parc.AjouterVehicule(item));
        }

        private void butn_Afficher_Click(object sender, EventArgs e)
        {
            Affichage aff = new Affichage();
            aff.Show();
            this.Hide();
        }
    }
}
