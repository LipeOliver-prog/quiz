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
    public partial class frmp2 : Form
    {
        public frmp2()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtCerta.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                variaveisglobais.Acertos += 1;
                frmp3 p3 = new frmp3();
                p3.ShowDialog();
                this.Dispose();
            }
            else if (rbtCerta2.Checked || rbtCerta3.Checked || rbtCerta4.Checked)
            {
                MessageBox.Show("Esta Incorreta", "QUIZ");
                variaveisglobais.Erros += 1;
                frmp3 p3 = new frmp3();
                p3.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa", "QUIZ");
            }
        }
    }
}
