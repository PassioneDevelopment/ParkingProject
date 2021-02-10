using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject.Heranca_Pessoa
{
    public abstract class Pessoa
    {
        //protected abstract string NivelPermissao { get; set; }
        protected virtual string Nome { get; set; }
        protected virtual int IdFuncionario { get; set; }
        protected virtual string CPF { get; set; }
        protected virtual string RG { get; set; }
        protected virtual DateTime DataDeNascimento { get; set; }

        public Pessoa(string nome,int idFuncionario, string cpf,string rg) {
            //this.NivelPermissao = nivelPermissao;
            this.Nome = nome;
            this.IdFuncionario = idFuncionario;
            this.CPF = cpf;
            this.RG = rg;
        }
    }
}
