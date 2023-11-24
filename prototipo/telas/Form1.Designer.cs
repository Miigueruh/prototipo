namespace prototipo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_funcao = new System.Windows.Forms.ComboBox();
            this.lorem = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_estadoCivil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(185, 411);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(100, 20);
            this.tb_cidade.TabIndex = 86;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cb_estado.Location = new System.Drawing.Point(185, 367);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(101, 21);
            this.cb_estado.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 84;
            this.label13.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Estado";
            // 
            // tb_funcao
            // 
            this.tb_funcao.FormattingEnabled = true;
            this.tb_funcao.Items.AddRange(new object[] {
            "Exemplo 1 ",
            "Exemplo 2",
            "Exemplo 3"});
            this.tb_funcao.Location = new System.Drawing.Point(588, 278);
            this.tb_funcao.Name = "tb_funcao";
            this.tb_funcao.Size = new System.Drawing.Size(100, 21);
            this.tb_funcao.TabIndex = 82;
            // 
            // lorem
            // 
            this.lorem.AutoSize = true;
            this.lorem.Location = new System.Drawing.Point(519, 419);
            this.lorem.Name = "lorem";
            this.lorem.Size = new System.Drawing.Size(32, 13);
            this.lorem.TabIndex = 81;
            this.lorem.Text = "lorem";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(429, 461);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 80;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(429, 414);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 79;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(391, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "Empresa x2a";
            // 
            // tb_salario
            // 
            this.tb_salario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salario.Location = new System.Drawing.Point(588, 320);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(100, 23);
            this.tb_salario.TabIndex = 77;
            // 
            // tb_rg
            // 
            this.tb_rg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rg.Location = new System.Drawing.Point(185, 276);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(100, 23);
            this.tb_rg.TabIndex = 76;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(588, 231);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(100, 23);
            this.tb_endereco.TabIndex = 75;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(588, 192);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 23);
            this.tb_email.TabIndex = 74;
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(186, 151);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 23);
            this.tb_nome.TabIndex = 73;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cpf.Location = new System.Drawing.Point(186, 231);
            this.tb_cpf.Mask = "000,000,000-00";
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(100, 23);
            this.tb_cpf.TabIndex = 72;
            // 
            // tb_telefone
            // 
            this.tb_telefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefone.Location = new System.Drawing.Point(588, 154);
            this.tb_telefone.Mask = "(00) 00000-0000";
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(100, 23);
            this.tb_telefone.TabIndex = 71;
            // 
            // cb_estadoCivil
            // 
            this.cb_estadoCivil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estadoCivil.FormattingEnabled = true;
            this.cb_estadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado"});
            this.cb_estadoCivil.Location = new System.Drawing.Point(185, 318);
            this.cb_estadoCivil.Name = "cb_estadoCivil";
            this.cb_estadoCivil.Size = new System.Drawing.Size(101, 25);
            this.cb_estadoCivil.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 69;
            this.label10.Text = "Salário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Função";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Estado Civil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Data de nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 89;
            this.button1.Text = "Consultar Cadastros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(268, 192);
            this.data.Mask = "0000-00-00";
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(110, 20);
            this.data.TabIndex = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 583);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_funcao);
            this.Controls.Add(this.lorem);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.tb_rg);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.cb_estadoCivil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox tb_funcao;
        private System.Windows.Forms.Label lorem;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.TextBox tb_rg;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox tb_cpf;
        private System.Windows.Forms.MaskedTextBox tb_telefone;
        private System.Windows.Forms.ComboBox cb_estadoCivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox data;
    }
}

