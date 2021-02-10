using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingProject
{
    public partial class TelaLogin : Form
    {
        private TelaDeSelecao telaDeSelecaoOperador;

        //Simular o banco de dados
        private string[] Usuario { get; set; } = {"1","tubaroso"};
        private string[] Senha { get; set; } = {"1","jare"};

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaDeSelecaoOperador = new TelaDeSelecao(this);

            if (Logar(tbUsuario.Text, tbSenha.Text))
            {
                telaDeSelecaoOperador.Show();
                this.Visible = false;
            }
            else {
                lbMensagemErro.Text = "Usuario ou senha inválidos!";
            }
        }

        public Boolean Logar(string login, string senha) {
            int contador = 0;          
            foreach (string item in Usuario) {
                contador++;
                if (tbUsuario.Text.Equals(Usuario[contador - 1]))
                {
                    if (tbSenha.Text.Equals(Senha[contador - 1]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }
            return false;
        }
    }
}
