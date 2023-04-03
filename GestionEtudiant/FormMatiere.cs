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
    public partial class FormMatiere : Form
    {
        public FormMatiere()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesBD.AjouterMatiere(txtLibelle.Text, Int32.Parse(txtCoef.Text));
            MessageBox.Show("Enregistrer avec succès?");
            dg.Rows.Add(txtLibelle.Text, Int32.Parse(txtCoef.Text));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment quitter?");
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
