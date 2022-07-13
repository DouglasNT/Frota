using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FrotaEmpresa
{
    class DAOLogin
    {
        public MySqlConnection conexaoLogin;

        public DAOLogin()
        {

            conexaoLogin = new MySqlConnection("server=localhost;DataBase=frotaEmpresa;Uid=root;password=");

            try
            {
                conexaoLogin.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro);
                conexaoLogin.Close();
            }

        }//fim do método DAO Login

    }//Fim da Classe
}//Fim do projeto
