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
    public partial class ConsultarMotorista : Form
    {

        DAOMotorista motorista;
        ConsultarTdsMotoristas ConTodos;

        public ConsultarMotorista()
        {
            InitializeComponent();

            motorista = new DAOMotorista();
            ConTodos = new ConsultarTdsMotoristas();
            Campos();
        }

        public void Campos()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            comboBox1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do text box Código

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do text box Nome

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do masked text box CPF

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do masked text box Telefone

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do text box Endereço

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do Combo box CNH

        private void botaoConsultar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Nenhum Código Digitado\n\n"
                    +           "Favor digitar um código válido");
            }
            else
            {

                motorista.ConsultarCodigoMotorista();

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                maskedTextBox1.ReadOnly = false;
                maskedTextBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                comboBox1.Enabled = true;

                textBox2.Text = "" + motorista.ConsultarNome(Convert.ToInt32(textBox1.Text));
                maskedTextBox1.Text = "" + motorista.ConsultarCPF(Convert.ToInt32(textBox1.Text));
                maskedTextBox2.Text = "" + motorista.ConsultarTelefone(Convert.ToInt32(textBox1.Text));
                textBox3.Text = "" + motorista.ConsultarEndereco(Convert.ToInt32(textBox1.Text));
                comboBox1.Text = "" + motorista.ConsultarCNH(Convert.ToInt32(textBox1.Text));


                if (textBox2.Text == "Nome não Encontrado!")
                {

                    MessageBox.Show("Cadastro não encontrado!\n\n" +
                                     "Digite o Código novamente");

                    Campos();

                    textBox1.Clear();
                    textBox2.Clear();
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;

                }

            }
        }//Fim do Botão Consultar

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.ReadOnly = false;

        }//Fim do botão Limpar

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ConTodos.ShowDialog();
            this.Visible = true;

        }//Fim do Botão consultar todos

        private void ConsultarMotorista_Load(object sender, EventArgs e)
        {

        }
    }//FIm da classe
}//Fim do projeto
