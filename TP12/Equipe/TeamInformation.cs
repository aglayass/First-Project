using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP12.Equipe.DSTableAdapters;

namespace TP12.Equipe
{
    public partial class TeamInformation : Form
    {
        public TeamInformation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Actualiser()
        {

            bindingSource1.DataSource = new EquipeTableAdapter().GetData();
        }

        private void TeamInformation_Load(object sender, EventArgs e)

        {
            this.Actualiser();
            txtId.DataBindings.Add("Text", bindingSource1, "id");
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (btnAjouter.Text == "Nouveau")
            {
                    txtId.Text = "";
                txtName.Text = "";
                txtPays.Text = "";
                txtClassement.Text = "";
                btnAjouter.Text = "Ajouter";
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
               
            }
                
            

            else if (btnAjouter.Text == "Ajouter" && txtId.Text != "" && txtName.Text != "" && txtPays.Text != "" && txtClassement.Text != "")
            {
                EquipeTableAdapter Team = new EquipeTableAdapter();
                Team.Insert(txtName.Text, txtPays.Text, Convert.ToInt32(txtClassement.Text));
                this.Actualiser();
                btnAjouter.Text = "Nouveau";
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;

            }


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DS.EquipeRow E = new EquipeTableAdapter().GetData().FindById(Convert.ToInt32(txtId.Text));
            E.Nom = txtName.Text;
            E.Pays = txtPays.Text;
            E.ClassementMondial =Convert.ToInt32(txtClassement.Text);
            new EquipeTableAdapter().Update(E);
            this.Actualiser();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string message = "est tu sur de supprimer ce Equipe";
            if (MessageBox.Show(message, "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DS.EquipeRow E = new EquipeTableAdapter().GetData().FindById(Convert.ToInt32(txtId.Text));

                E.Delete();
                new EquipeTableAdapter().Update(E);
                this.Actualiser();
            }
        }
    }
}
