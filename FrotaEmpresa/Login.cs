using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FrotaEmpresa
{
    public partial class Login : Form
    {

        Form1 TelaInicial;
        
        private bool Logado = false;

        public Login()
        {
            InitializeComponent();
            TelaInicial = new Form1();
            
        }

        bool VerificaLogin()
        {
            bool result = false;
            string StringDeConexao = @"Data Source = localhost; Initial Catalog = frotaEmpresa; User Id = root; Password = ;";
            using (MySqlConnection cn = new MySqlConnection())
            {
                cn.ConnectionString = StringDeConexao;

                try
                {
                    MySqlCommand cmd = new MySqlCommand("select * from login where usuario = '" +textBox1.Text + "' and senha = '" +textBox2.Text + "';", cn);
                    cn.Open();
                    MySqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;

                }
                catch (MySqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;
        }//Fim do Método COnsultar Login


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Text box usuario

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }//Fim do texte box Senha

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {

            bool result = VerificaLogin();

            Logado = result;

            if (result)
            {

                MessageBox.Show("Seja bem vindo!");

                this.Visible = false;
                TelaInicial.ShowDialog();
                this.Visible = true;

                textBox1.Clear();
                textBox2.Clear();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }

            
        }//Fim do botão entrar

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }//Fim da Classe
}//Fim do projeto
