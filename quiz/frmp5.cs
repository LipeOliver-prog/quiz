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
    public partial class frmp5 : Form
    {
        public frmp5()
        {
            InitializeComponent();
        }

        private void rbtCerta3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                variaveisglobais.Acertos += 1;
                frmfinal final = new frmfinal();
               final.ShowDialog();
                this.Dispose();
            }
            else if (rbtCerta2.Checked || rbtCerta3.Checked || rbtCerta4.Checked)
            {
                MessageBox.Show("Esta Incorreta", "QUIZ");
                variaveisglobais.Erros += 1;
                frmfinal final = new frmfinal();
                final.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa", "QUIZ");
            }
        }
    }
}
