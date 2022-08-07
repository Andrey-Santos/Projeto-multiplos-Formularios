using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjParametroResposta.Forma1
{
    public partial class FrmForma1Formulario2 : Form
    {
        private TextBox txtResposta;

        public FrmForma1Formulario2()
        {
            InitializeComponent();
        }
        public FrmForma1Formulario2(TextBox txt) : this()
        {
            txtResposta = txt;
        }

        private void FrmForma2Formulario2_Load(object sender, EventArgs e)
        {

        }

        private void txtRespostaRecebida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            txtResposta.Text = txtRespostaDevolver.Text;
            Close();
        }
    }
}
