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
    public partial class ConsultarTdsVeiculos : Form
    {

        private MySqlConnection Conexao;
        private string data_source = "server=localhost;DataBase=frotaEmpresa;Uid=root;password=";

        public ConsultarTdsVeiculos()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Scrollable = true;

            listView1.Columns.Add("Código Veículo", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Modelo", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Placa", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Cor", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Combustível", 100, HorizontalAlignment.Left);
        }

        private void ConsultarTdsVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void botaoConsultar_Click(object sender, EventArgs e)
        {

            try
            {

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM veiculo";

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),                       
                    };

                    var linha_listview = new ListViewItem(row);

                    listView1.Items.Add(linha_listview);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                Conexao.Close();
            }

        }//Fim do Botão COnsultar

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Fim do List view todos os veiculos cadastrados

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

        }//Fim do botão Limpar
    }//Fim da classe
}//Fim do projeto
