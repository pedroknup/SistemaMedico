using SistemaMedicoSolucao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class FormInicial : Form {
        public FormInicial() {
            InitializeComponent();
        }

        private void atendimentosToolStripMenuItem_Click(object sender, EventArgs e) {
            var _formAtendimentos = new FormAtendimentos();
            _formAtendimentos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e) {
            var _formCadastroPaciente = new FormCadastroPaciente();
            _formCadastroPaciente.ShowDialog();
        }
    }
}
