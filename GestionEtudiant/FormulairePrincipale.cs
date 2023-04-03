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
    public partial class FormulairePrincipale : Form
    {
        public FormulairePrincipale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Run(new Form1());
            
            new Form1().ShowDialog();
            Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormMatiere().ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormAjoutNote().ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new rapportNote().ShowDialog();
            Close();
        }
    }
}
