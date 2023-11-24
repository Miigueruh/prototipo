using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo
{
    public class Empresa
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public string RegimeTributario { get; set; }
        public string DataInicioAtividade { get; set; }
        public string Telefone { get; set; }
        public string CapitalSocial { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public double Tipo { get; set; }
        public double PorteEmpresa { get; set; }
        public double NaturezaJurídica { get; set; }
        public double NomeProprietario { get; set; }
        public double CPFproprietario { get; set; }

        public Empresa()
        {

        }
    }
}
