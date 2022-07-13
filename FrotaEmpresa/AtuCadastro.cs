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
    public partial class AtuCadastro : Form
    {

        AtuCadastroMotorista atualizarMotorista;
        AtuCadastroVeiculo atualizarVeiculo;

        public AtuCadastro()
        {
            InitializeComponent();
            atualizarMotorista = new AtuCadastroMotorista();
            atualizarVeiculo = new AtuCadastroVeiculo();

        }

        private void BotaoAtuMotorista_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            atualizarMotorista.ShowDialog();
            this.Visible = true;
        }//Fim do Botão Atualizar Motorista

        private void BotaoAtuVeiculo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            atualizarVeiculo.ShowDialog();
            this.Visible = true;
        }//Fim do Botão Atualizar Veiculo

    }//Fim da classe
}//Fim do projeto
