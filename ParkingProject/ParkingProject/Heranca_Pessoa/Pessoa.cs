using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject.Heranca_Pessoa
{
    public abstract class Pessoa
    {
        public virtual string Usuario { get; set; }
        public virtual string Senha { get; set; }
        public virtual string NivelPermissao { get; }
        public virtual string Nome { get; set; }
        public virtual int IdFuncionario { get; set; }
        public virtual string CPF { get; set; }
        public virtual string RG { get; set; }
        public virtual DateTime DataDeNascimento { get; set; }

        public Pessoa(string usuario,string senha,string nome,int idFuncionario, string cpf,string rg,DateTime dataDeNascimento,string nivelPermissao) {
            this.Usuario = usuario;
            this.Senha = senha;          
            this.Nome = nome;
            this.IdFuncionario = idFuncionario;
            this.CPF = cpf;
            this.RG = rg;
            this.DataDeNascimento = dataDeNascimento;
            this.NivelPermissao = nivelPermissao;
        }
    }
}
