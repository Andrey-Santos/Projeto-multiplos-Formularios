using ProjParametroResposta.Forma1;
using ProjParametroResposta.Forma2;
using ProjParametroResposta.Forma3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjParametroResposta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForma1Formulario1 frm = new FrmForma1Formulario1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void forma2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForma2Formulario1 frm = new FrmForma2Formulario1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void forma3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForma3Formulario1 frm = new FrmForma3Formulario1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
