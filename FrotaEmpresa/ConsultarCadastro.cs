using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrotaEmpresa
{
    public partial class ConsultarCadastro : Form
    {

        ConsultarMotorista ConMotorista;
        ConsultarVeiculo ConVeiculo;

        public ConsultarCadastro()
        {
            InitializeComponent();
            ConMotorista = new ConsultarMotorista();
            ConVeiculo = new ConsultarVeiculo();
        }

        private void BotaoConsultarMotorista_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConMotorista.ShowDialog();
            this.Visible = true;
        }//Fim do Botão Consultar Motorista

        private void BotaoConsultarVeiculo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConVeiculo.ShowDialog();
            this.Visible = true;
        }//Fim do botão Consultar Veiculo

        private void ConsultarCadastro_Load(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto
