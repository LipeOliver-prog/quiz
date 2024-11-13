using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variaveisglobais.Acertos += 0;
            variaveisglobais.Erros += 0;
            frmp1 p1 = new frmp1();
            p1.ShowDialog();

        }
    }
}
