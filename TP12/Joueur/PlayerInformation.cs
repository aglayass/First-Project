using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP12.Joueur.DS1TableAdapters;

namespace TP12.Joueur
{
    public partial class PlayerInformation : Form
    {
        public PlayerInformation()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void joueurBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        public void Actualiser()
        {
            DS1 ds = new DS1();
            new JoueurTableAdapter().Fill(ds.Joueur);
            new EquipeTableAdapter().Fill(ds.Equipe);
            bindingSource1.DataSource = ds.Joueur.ToList<DS1.JoueurRow>();
        }

        private void PlayerInformation_Load(object sender, EventArgs e)
        {
            this.Actualiser();
            cmbIdEquipe.DataSource = new EquipeTableAdapter().GetData();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Nouveau")
            {
                txtId.Text = "";
                txtLastName.Text = "";
                txtName.Text = "";
                txtNationality.Text = "";
                btnAjouter.Text = "Ajouter";
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                

            }



            else if (btnAjouter.Text == "Ajouter" && txtId.Text != "" && txtName.Text != "" && txtLastName.Text != "" && txtNationality.Text != "")
            {
                JoueurTableAdapter Player = new JoueurTableAdapter();
                Player.Insert(txtName.Text, txtLastName.Text, txtNationality.Text, Convert.ToInt32(cmbIdEquipe.SelectedValue));
                this.Actualiser();
                btnAjouter.Text = "Nouveau";
               
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DS1.JoueurRow J = new JoueurTableAdapter().GetData().FindById(Convert.ToInt32(txtId.Text));
            J.Nom = txtLastName.Text;
            J.Prenom = txtName.Text;
            J.Natonalite = txtNationality.Text;
            J.idEquipe = (int)cmbIdEquipe.SelectedValue;
            new JoueurTableAdapter().Update(J);
            this.Actualiser();
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string message = "est tu sur de supprimer ce Joueur";
            if (MessageBox.Show(message, "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DS1.JoueurRow J = new JoueurTableAdapter().GetData().FindById(Convert.ToInt32(txtId.Text));

                J.Delete();
                new JoueurTableAdapter().Update(J);
                this.Actualiser();
            }
        }
    }
}