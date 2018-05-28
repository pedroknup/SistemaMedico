using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico
{
    public partial class FormAtendimentos : Form
    {
        public FormAtendimentos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            var formNovoAtendimento = new FormNovoAtendimento();
            formNovoAtendimento.ShowDialog();
        }

        private void label1_MouseHover(object sender, EventArgs e) {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e) {
            label1.ForeColor = Color.Black;
        }
    }
}
