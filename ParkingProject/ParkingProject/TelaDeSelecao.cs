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
    public partial class TelaDeSelecao : Form
    {
        private TelaLogin telaLogin;
        private DateTime dataDeHoje = DateTime.Today;
        public TelaDeSelecao(TelaLogin telaLogin)
        {
            InitializeComponent();
            this.telaLogin = telaLogin;
            tbDataAtual.Text = dataDeHoje.ToString();
        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {
            telaLogin.Show();
            this.Visible = false;
        }
    }
}
