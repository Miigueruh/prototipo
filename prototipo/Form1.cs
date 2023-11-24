using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class Form1 : Form
    {
        public List <Funcionario> listaFuncionarios = new List<Funcionario>();
        public Form1()
        {
            InitializeComponent();
            lorem.Text = string.Empty;
        }

        public void Inserir(Funcionario funcionario)
        {

            try
            {
                
                
                Conexao conexao = new Conexao();

                var comando = conexao.Comando(
                    "INSERT INTO funcionario (nome_fun, data_nasc_fun, cpf_fun, rg_fun, telefone_fun, email_fun, endereco_fun, estado_civil_fun, funcao_fun, salario_fun) VALUES (@nome, @dataNascimento, @cpf, @rg, @telefone, @email, @endereco, @estadoCivil, @funcao, @salario)"
                    );
                

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void salvar_Click(object sender, EventArgs e)
        {
            

            string valor = tb_cpf.Text;

            if (tb_nome.Text == string.Empty ||
            tb_email.Text == string.Empty ||
            tb_cpf.Text == string.Empty ||
            tb_rg.Text == string.Empty ||
            tb_endereco.Text == string.Empty ||
            tb_funcao.Text == string.Empty ||
            tb_salario.Text == string.Empty ||
            cb_estadoCivil.Text == string.Empty ||
            tb_telefone.Text == string.Empty ||
            tb_cidade.Text == string.Empty ||
            cb_estado.Text == string.Empty)
            {
                lorem.Text = "Preencha todos os campos!";
            }

            else
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = tb_nome.Text;
                funcionario.DataNascimento = data.Text;
                funcionario.Cpf = tb_cpf.Text;
                funcionario.Rg = tb_rg.Text;
                funcionario.Telefone = tb_telefone.Text;
                funcionario.Email = tb_email.Text;
                funcionario.Endereco = tb_endereco.Text;
                funcionario.EstadoCivil = cb_estadoCivil.Text;
                funcionario.Funcao = tb_funcao.Text;
                funcionario.Salario = Convert.ToDouble(tb_salario.Text);

                Inserir(funcionario);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_cpf.Text = string.Empty;
            tb_rg.Text = string.Empty;
            tb_endereco.Text = string.Empty;
            tb_funcao.Text = string.Empty;
            tb_salario.Text = string.Empty;
            cb_estadoCivil.Text = string.Empty;
            data.Text = string.Empty;
            tb_telefone.Text = string.Empty;
            tb_cidade.Text = string.Empty;
            cb_estado.Text = string.Empty;
            lorem.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
