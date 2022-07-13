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
    public partial class Form1 : Form
    {
        CadastroVeiculo cadVeiculo;
        CadastroMotorista cadMotorista;
        Gasto gasto;
        ConsultarGasto conGasto;
        ExcluirCadastro excluir;
        AtuCadastro atualizar;
        ConsultarCadastro consultar;

        public Form1()
        {
            InitializeComponent();
            cadVeiculo = new CadastroVeiculo();
            cadMotorista = new CadastroMotorista();
            gasto = new Gasto();
            conGasto = new ConsultarGasto();
            excluir = new ExcluirCadastro();
            atualizar = new AtuCadastro();
            consultar = new ConsultarCadastro();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//Fim titulo

        private void registrarGasto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gasto.ShowDialog();
            this.Visible = true;
        }//Fim Botão registrar Gasto

        private void CadastrarVeiculo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadVeiculo.ShowDialog();
            this.Visible = true;
        }//Fim Botão Cadastrar Veiculo

        private void CadastrarMotorista_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadMotorista.ShowDialog();
            this.Visible = true;
        }//Fim Botão Cadastrar Motorista

        private void atuCadastroVeiculo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            consultar.ShowDialog();
            this.Visible = true;
        }//Fim Botão Atualizar Cadastro do Veiculo

        private void atuCadastroMotorista_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            atualizar.ShowDialog();
            this.Visible = true;
        }//Fim Botão Atualizar Cadastro do Motorista

        private void consultarGasto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            conGasto.ShowDialog();
            this.Visible = true;
        }//Fim Botão Consultar Gasto

        private void excluirCadastro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            excluir.ShowDialog();
            this.Visible = true;
        }//Fim Botão Excluir cadastro
    }
}
