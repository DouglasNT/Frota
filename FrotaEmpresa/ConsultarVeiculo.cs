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
    public partial class ConsultarVeiculo : Form
    {

        DAOVeiculo veiculo;
        ConsultarTdsVeiculos TodosVeiculos;

        public ConsultarVeiculo()
        {
            InitializeComponent();

            veiculo = new DAOVeiculo();
            TodosVeiculos = new ConsultarTdsVeiculos();

            Campos();

        }

        public void Campos()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            comboBox1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do text box Código

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do masked tex box Placa

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do text box Modelo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do text box Cor

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do combo box Combustivel

        private void botaoConsultar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Nenhum Código Digitado\n\n"
                    + "Favor digitar um código válido");
            }
            else
            {

                veiculo.ConsultarCodigoVeiculo();

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                maskedTextBox1.ReadOnly = false;
                textBox3.ReadOnly = false;
                comboBox1.Enabled = true;

                textBox2.Text = "" + veiculo.ConsultarModelo(Convert.ToInt32(textBox1.Text));
                maskedTextBox1.Text = "" + veiculo.ConsultarPlaca(Convert.ToInt32(textBox1.Text));
                textBox3.Text = "" + veiculo.ConsultarCor(Convert.ToInt32(textBox1.Text));
                comboBox1.Text = "" + veiculo.ConsultarCombustivel(Convert.ToInt32(textBox1.Text));

                if (textBox2.Text == "Modelo não Encontrado!")
                {

                    MessageBox.Show("Veículo não encontrado!\n\n" +
                                     "Digite o Código novamente");

                    Campos();

                    textBox1.Clear();
                    textBox2.Clear();
                    maskedTextBox1.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;

                }

            }

        }//Fim do Botão Consultar

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.ReadOnly = false;

        }//Fim do Botão Limpar

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            TodosVeiculos.ShowDialog();
            this.Visible = true;

        }//Fim do Botão Consultar todos os Veiculos
    }//Fim da classe
}//Fim do projeto
