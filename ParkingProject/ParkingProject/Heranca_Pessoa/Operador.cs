using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject.Heranca_Pessoa
{
    public class Operador : Pessoa
    {
        public Operador(string usuario, string senha, string nome, int idFuncionario, string cpf, string rg, DateTime dataNascimento) : base(usuario, senha, nome, idFuncionario, cpf, rg, dataNascimento,"OPERADOR") { }       
    }
}
