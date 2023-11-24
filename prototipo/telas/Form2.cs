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
    public partial class Form2 : Form
    {
        public List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public Form2()
        {
            InitializeComponent();
            Consultar();
        }
        public void Consultar()
        {

            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Funcionario");

                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Funcionario f = new Funcionario();
                    f.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    f.DataNascimento = DAOHelper.GetString(leitor, "data_nasc_fun");
                    f.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    f.Rg = DAOHelper.GetString(leitor, "rg_fun");
                    f.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    f.Email = DAOHelper.GetString(leitor, "email_fun");
                    f.Endereco = DAOHelper.GetString(leitor, "endereco_fun");
                    f.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    f.Salario = DAOHelper.GetDouble(leitor, "salario_fun");
                    f.EstadoCivil = DAOHelper.GetString(leitor, "estado_civil_fun");

                    listaFuncionarios.Add(f);
                }

                dgv_Funcionario.DataSource = null;
                dgv_Funcionario.Refresh();
                dgv_Funcionario.DataSource = listaFuncionarios;
            }

            catch
            {
                throw;
            }
        }
        private void dgv_Funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
