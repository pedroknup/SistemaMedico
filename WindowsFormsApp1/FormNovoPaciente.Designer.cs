namespace WindowsFormsApp1 {
    partial class FormNovoPaciente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditId = new System.Windows.Forms.TextBox();
            this.EditNome = new System.Windows.Forms.TextBox();
            this.EditCPF = new System.Windows.Forms.TextBox();
            this.EditDtNasc = new System.Windows.Forms.TextBox();
            this.EditLogradouro = new System.Windows.Forms.TextBox();
            this.EditNumero = new System.Windows.Forms.TextBox();
            this.EditComplemento = new System.Windows.Forms.TextBox();
            this.EditCidade = new System.Windows.Forms.TextBox();
            this.EditEstadoCivil = new System.Windows.Forms.ComboBox();
            this.EditSexo = new System.Windows.Forms.ComboBox();
            this.EditEstado = new System.Windows.Forms.ComboBox();
            this.RbObitoNao = new System.Windows.Forms.RadioButton();
            this.RbObitoSim = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.ButtonRemoverFoto = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logradouro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Complemento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Location = new System.Drawing.Point(634, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Foto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Id";
            // 
            // EditId
            // 
            this.EditId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EditId.Enabled = false;
            this.EditId.Location = new System.Drawing.Point(16, 37);
            this.EditId.Name = "EditId";
            this.EditId.Size = new System.Drawing.Size(100, 20);
            this.EditId.TabIndex = 13;
            // 
            // EditNome
            // 
            this.EditNome.Location = new System.Drawing.Point(16, 87);
            this.EditNome.Name = "EditNome";
            this.EditNome.Size = new System.Drawing.Size(370, 20);
            this.EditNome.TabIndex = 0;
            // 
            // EditCPF
            // 
            this.EditCPF.Location = new System.Drawing.Point(16, 134);
            this.EditCPF.Name = "EditCPF";
            this.EditCPF.Size = new System.Drawing.Size(116, 20);
            this.EditCPF.TabIndex = 1;
            // 
            // EditDtNasc
            // 
            this.EditDtNasc.Location = new System.Drawing.Point(146, 134);
            this.EditDtNasc.Name = "EditDtNasc";
            this.EditDtNasc.Size = new System.Drawing.Size(126, 20);
            this.EditDtNasc.TabIndex = 2;
            // 
            // EditLogradouro
            // 
            this.EditLogradouro.Location = new System.Drawing.Point(15, 239);
            this.EditLogradouro.Name = "EditLogradouro";
            this.EditLogradouro.Size = new System.Drawing.Size(257, 20);
            this.EditLogradouro.TabIndex = 5;
            // 
            // EditNumero
            // 
            this.EditNumero.Location = new System.Drawing.Point(287, 239);
            this.EditNumero.Name = "EditNumero";
            this.EditNumero.Size = new System.Drawing.Size(99, 20);
            this.EditNumero.TabIndex = 6;
            // 
            // EditComplemento
            // 
            this.EditComplemento.Location = new System.Drawing.Point(403, 239);
            this.EditComplemento.Name = "EditComplemento";
            this.EditComplemento.Size = new System.Drawing.Size(99, 20);
            this.EditComplemento.TabIndex = 7;
            // 
            // EditCidade
            // 
            this.EditCidade.Location = new System.Drawing.Point(16, 292);
            this.EditCidade.Name = "EditCidade";
            this.EditCidade.Size = new System.Drawing.Size(256, 20);
            this.EditCidade.TabIndex = 8;
            // 
            // EditEstadoCivil
            // 
            this.EditEstadoCivil.FormattingEnabled = true;
            this.EditEstadoCivil.Location = new System.Drawing.Point(16, 186);
            this.EditEstadoCivil.Name = "EditEstadoCivil";
            this.EditEstadoCivil.Size = new System.Drawing.Size(116, 21);
            this.EditEstadoCivil.TabIndex = 4;
            // 
            // EditSexo
            // 
            this.EditSexo.FormattingEnabled = true;
            this.EditSexo.Location = new System.Drawing.Point(287, 134);
            this.EditSexo.Name = "EditSexo";
            this.EditSexo.Size = new System.Drawing.Size(99, 21);
            this.EditSexo.TabIndex = 3;
            // 
            // EditEstado
            // 
            this.EditEstado.FormattingEnabled = true;
            this.EditEstado.Location = new System.Drawing.Point(287, 292);
            this.EditEstado.Name = "EditEstado";
            this.EditEstado.Size = new System.Drawing.Size(99, 21);
            this.EditEstado.TabIndex = 9;
            // 
            // RbObitoNao
            // 
            this.RbObitoNao.AutoSize = true;
            this.RbObitoNao.Location = new System.Drawing.Point(60, 348);
            this.RbObitoNao.Name = "RbObitoNao";
            this.RbObitoNao.Size = new System.Drawing.Size(45, 17);
            this.RbObitoNao.TabIndex = 11;
            this.RbObitoNao.TabStop = true;
            this.RbObitoNao.Text = "Não";
            this.RbObitoNao.UseVisualStyleBackColor = true;
            // 
            // RbObitoSim
            // 
            this.RbObitoSim.AutoSize = true;
            this.RbObitoSim.Location = new System.Drawing.Point(14, 348);
            this.RbObitoSim.Name = "RbObitoSim";
            this.RbObitoSim.Size = new System.Drawing.Size(42, 17);
            this.RbObitoSim.TabIndex = 10;
            this.RbObitoSim.TabStop = true;
            this.RbObitoSim.Text = "Sim";
            this.RbObitoSim.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Óbito";
            // 
            // ButtonRemoverFoto
            // 
            this.ButtonRemoverFoto.Location = new System.Drawing.Point(579, 213);
            this.ButtonRemoverFoto.Name = "ButtonRemoverFoto";
            this.ButtonRemoverFoto.Size = new System.Drawing.Size(140, 23);
            this.ButtonRemoverFoto.TabIndex = 13;
            this.ButtonRemoverFoto.Text = "Remover Foto";
            this.ButtonRemoverFoto.UseVisualStyleBackColor = true;
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Image = global::WindowsFormsApp1.Properties.Resources.if_ic_save_48px_352084;
            this.ButtonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSalvar.Location = new System.Drawing.Point(606, 406);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(113, 49);
            this.ButtonSalvar.TabIndex = 12;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(579, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 169);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormNovoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 467);
            this.Controls.Add(this.ButtonRemoverFoto);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.RbObitoNao);
            this.Controls.Add(this.RbObitoSim);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EditEstado);
            this.Controls.Add(this.EditSexo);
            this.Controls.Add(this.EditEstadoCivil);
            this.Controls.Add(this.EditCidade);
            this.Controls.Add(this.EditComplemento);
            this.Controls.Add(this.EditNumero);
            this.Controls.Add(this.EditLogradouro);
            this.Controls.Add(this.EditDtNasc);
            this.Controls.Add(this.EditCPF);
            this.Controls.Add(this.EditNome);
            this.Controls.Add(this.EditId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormNovoPaciente";
            this.Text = "Novo Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EditId;
        private System.Windows.Forms.TextBox EditNome;
        private System.Windows.Forms.TextBox EditCPF;
        private System.Windows.Forms.TextBox EditDtNasc;
        private System.Windows.Forms.TextBox EditLogradouro;
        private System.Windows.Forms.TextBox EditNumero;
        private System.Windows.Forms.TextBox EditComplemento;
        private System.Windows.Forms.TextBox EditCidade;
        private System.Windows.Forms.ComboBox EditEstadoCivil;
        private System.Windows.Forms.ComboBox EditSexo;
        private System.Windows.Forms.ComboBox EditEstado;
        private System.Windows.Forms.RadioButton RbObitoNao;
        private System.Windows.Forms.RadioButton RbObitoSim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonRemoverFoto;
    }
}