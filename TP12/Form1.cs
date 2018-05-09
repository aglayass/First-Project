using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipe.TeamInformation form = new Equipe.TeamInformation();
            form.ShowDialog();
        }

        private void gestionJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Joueur.PlayerInformation formPl = new Joueur.PlayerInformation();
            formPl.ShowDialog();

        }
    }
}
