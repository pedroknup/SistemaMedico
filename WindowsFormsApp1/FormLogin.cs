﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var formAtendimentos = new FormAtendimentos();
            formAtendimentos.Show();
           
        }
    }
}
