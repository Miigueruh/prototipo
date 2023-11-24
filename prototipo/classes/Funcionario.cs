using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prototipo
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string EstadoCivil { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }

        public Funcionario() 
        {
            


        }
    }
}
