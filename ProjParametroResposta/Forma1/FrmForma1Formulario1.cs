﻿using System;
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
    public partial class FrmForma1Formulario1 : Form
    {
        public FrmForma1Formulario1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           FrmForma1Formulario2 frm = new FrmForma1Formulario2(txtRespostaRecebida);
            frm.txtParametroRecebido.Text = txtParametroEnviar.Text;
            frm.Show();
        }
    }
}
