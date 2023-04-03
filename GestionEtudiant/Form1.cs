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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesBD.AjouterEtudiant(txtNom.Text, txtPrénom.Text, txtDate.Text, txtFiliere.Text);
            MessageBox.Show("Enregistrer avec succès?");
            dg.Rows.Add(txtNom.Text, txtPrénom.Text, txtDate.Text, txtFiliere.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
            txtNom.Text = Convert.ToString(dg.SelectedRows[0].Cells[0].Value);
            txtPrénom.Text = Convert.ToString(dg.SelectedRows[0].Cells[1].Value);
            txtDate.Text = Convert.ToString(dg.SelectedRows[0].Cells[2].Value);
            txtFiliere.Text = Convert.ToString(dg.SelectedRows[0].Cells[3].Value);
        }
    }
}
