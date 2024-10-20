using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // adiciona a biblioteca para conexao com o banco de dados em MySQL

namespace teste
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados

            string query = "SELECT usuario FROM login ORDER BY usuario"; // cria uma variável para selecionar todos os usuarios da tabela login
            MySqlCommand cmd = new MySqlCommand(query, conexao.conexao); // cria um comando de conexao com o bd
            
            MySqlDataReader dr = cmd.ExecuteReader(); // abre um canal de execução de dados no bd (OBS: o DataReader mantem a informação com o bd mas não guarda essas informações)
            
            DataTable dt = new DataTable(); // cria um canal de execução da tabela na memória RAM com oque veio do DataReader
            dt.Load(dr); // carrega a tabela na memória RAM 
            cbUsuario.DisplayMember = "usuario"; // mostra somente os usuários da tabela no combobox
            cbUsuario.DataSource = dt; // especifica para o DataSource (que faz referencia ao bd) a origem dos dados q veio do DataTable, carregando os dados no combobox 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.Conectar();
            string query = "SELECT * FROM login WHERE usuario=@usuario AND senha=@senha";

            //cria um command para query nesta conexao
            MySqlCommand cmd = new MySqlCommand (query, conexao.conexao);
            //define os parametros utilizados na query
            cmd.Parameters.AddWithValue("@usuario", cbUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            //executa a query em um data reader
            MySqlDataReader dr = cmd.ExecuteReader();
            
            //verifica se no meu data reader filtrou algum valor conforme a query

            if (dr.Read())
            {
                Autenticacao.login(dr["usuario"].ToString(), dr["senha"].ToString(), dr["nivel"].ToString()); // captura os campos especificados da tabela no bd

                frmPrincipal principal = new frmPrincipal(); // cria o método p/ chamar o formulário principal
                principal.Show();
                this.Visible = false;
                
            }
            else
            {
                MessageBox.Show("A Senha digitada está Incorreta !", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSenha.Text = "";
                txtSenha.Focus();
            }
            //fecha o data reader
            dr.Close();
            //fecha a conexao com o banco de dados
            conexao.Desconectar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
