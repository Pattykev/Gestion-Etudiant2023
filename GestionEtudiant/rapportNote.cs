using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class rapportNote : Form
    {
        public rapportNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rapport> RList = new List<Rapport>();
            RList = AccesBD.AfficherRapport(txtFiliere.Text, txtLibelle.Text);
            foreach (Rapport r in RList)
            {
                dg.Rows.Add(r.Nom, r.Prenom, r.Note, r.DateCompos);
            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment quitter?");
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
