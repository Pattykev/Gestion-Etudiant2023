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
    public partial class FormAjoutNote : Form
    {
        public FormAjoutNote()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           string message= AccesBD.AjouterNote(txtNom.Text, txtPrenom.Text, txtFiliere.Text, txtLibelle.Text, txtDate.Text, Double.Parse(txtNote.Text));
           MessageBox.Show(message);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment quitter?");
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
