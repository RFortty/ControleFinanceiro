using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.IO;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace teste
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void Habilitar()
        {
            //txtid.Enabled = true;
            txtUsuario.Enabled = true;
            cbNivel.Enabled = true;
            txtSenha.Enabled = true;
            txtCSenha.Enabled = true;
            
            txtUsuario.Focus(); 
        }

        private void Desabilitar()
        {
            txtid.Enabled = false;
            txtUsuario.Enabled = false;
            cbNivel.Enabled = false;
            txtSenha.Enabled = false;
            txtCSenha.Enabled = false;
        }

        private void Limpar()
        {
            txtid.Clear();
            txtUsuario.Clear();
            cbNivel.Text = "";
            txtSenha.Clear();
            txtCSenha.Clear();
            txtCadastrado.Clear();
            txtModificado.Clear();
            txtCadPor.Clear();  
            
            txtUsuario.Focus();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {           
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            Desabilitar();
            Atualizar();
        }

        private void Atualizar()
        {
            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados

            string query = "SELECT id, usuario, nivel, cadastrado, modificado, cadpor FROM login ORDER by id"; // cria uma variável para selecionar todos os usuarios da tabela login
            MySqlCommand cmd = new MySqlCommand(query, conexao.conexao); // cria um comando de conexao com o bd

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgUsuarios.DataSource = data;
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.Conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(id)+1 as IDNovo from login", conexao.conexao);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    codigo = Convert.ToInt32(dr["IDNovo"].ToString());
                    return codigo;
                }
                else
                {
                    foreach (Control ctl in this.Controls)
                    {
                        if (ctl is TextBox)
                            ctl.Text = "";
                    }
                    codigo = 1;
                    return codigo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                return 0;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void Inserir()
        {
            Conexao conexao = new Conexao();

            try
            {
                conexao.Conectar();
                MySqlCommand inserir = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                inserir.CommandText = "INSERT INTO login (id, usuario, senha, nivel, cadastrado, cadpor) VALUES (@id, @usuario, @senha, @nivel, @cadastrado, @cadpor)"; // comando para inserir registro do bd
                inserir.Parameters.AddWithValue("@id", txtid.Text);
                inserir.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                inserir.Parameters.AddWithValue("@senha", txtSenha.Text);
                inserir.Parameters.AddWithValue("@nivel", cbNivel.Text);
                inserir.Parameters.AddWithValue("@cadastrado", txtCadastrado.Text = DateTime.Now.ToString());
                inserir.Parameters.AddWithValue("@cadpor", txtCadPor.Text = Autenticacao.getUsuario());
                inserir.ExecuteNonQuery();
                
                MessageBox.Show("Dados inseridos com Sucesso !", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            catch //(Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados !", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                conexao.Desconectar(); // desconecta do banco de dados
            }
            finally
            {
                conexao.Desconectar();
                Atualizar();
            }
        }

        private void Alterar()
        {
            Conexao conexao = new Conexao();

            try
            {
                conexao.Conectar();
                
                if (txtid.Text == "1")
                {
                    MessageBox.Show("O Administrador do Sistema não pode ser Alterado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DialogResult.Yes == MessageBox.Show("Deseja realmente alterar os dados selecionados ?", "Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlCommand alterar = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                    alterar.CommandText = "UPDATE login SET id=@id, usuario=@usuario, senha=@senha, nivel=@nivel, modificado=@modificado WHERE id=@id"; // comando para inserir registro no bd
                    alterar.Parameters.AddWithValue("@id", txtid.Text);
                    alterar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    alterar.Parameters.AddWithValue("@senha", txtSenha.Text);
                    alterar.Parameters.AddWithValue("@nivel", cbNivel.Text);
                    alterar.Parameters.AddWithValue("@modificado", txtModificado.Text = DateTime.Now.ToString());
                    alterar.ExecuteNonQuery();

                    MessageBox.Show("Dados atualizados com Sucesso !", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            catch //(Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados !", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                conexao.Desconectar(); // desconecta do banco de dados
            }
            finally
            {
                conexao.Desconectar();
                Atualizar();
                Limpar();
                Desabilitar();
            }
        }

        private void Excluir()
        {
            Conexao conexao = new Conexao();

            try
            {
                conexao.Conectar();

                if (txtid.Text == "1")
                {
                    MessageBox.Show("O Administrador do Sistema não pode ser Excluido !","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                }
                else if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir os dados selecionados ?", "Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlCommand excluir = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                    excluir.CommandText = "DELETE FROM login WHERE id='" + txtid.Text + "'"; // comando para excluir registro do bd
                    excluir.ExecuteNonQuery();
      
                    MessageBox.Show("Registro apagado com sucesso !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            catch //(Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados !", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                conexao.Desconectar(); // desconecta do banco de dados
            }
            finally            
            {
                conexao.Desconectar();
                Atualizar();
                Limpar();
                Desabilitar();
            }
        }

        private void dgUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            Habilitar();
            btnAdicionar.Enabled = false; 
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
             
            txtid.Text = dgUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            txtUsuario.Text = dgUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            cbNivel.Text = dgUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            //txtSenha.Text = dgUsuarios.SelectedRows[0].Cells[3].Value.ToString();
            txtCadastrado.Text = dgUsuarios.SelectedRows[0].Cells[3].Value.ToString();
            txtModificado.Text = dgUsuarios.SelectedRows[0].Cells[4].Value.ToString();
            txtCadPor.Text = dgUsuarios.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Limpar();
            Habilitar();
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

            txtid.Text = Convert.ToString(autoIncremento());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtid.Text == "") || (txtUsuario.Text == "") || (cbNivel.Text == "") || (txtSenha.Text == ""))
            {
                MessageBox.Show("É necessário preencher todos os campos !");
            }
            else if (txtCSenha.Text == "")
            {
                MessageBox.Show("Por favor confirme a senha !");
                txtCSenha.Focus();  
            }
            else if (txtSenha.Text != txtCSenha.Text)
            {
                MessageBox.Show("As senhas digitadas estão divergentes !");
                txtSenha.Text = "";
                txtCSenha.Text = "";
                txtSenha.Focus();
            }
            else if ((txtSenha.Text == txtCSenha.Text) && (txtSenha.Text != "" && txtCSenha.Text != ""))
            {
                Inserir();
                Atualizar();
                Limpar();
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            Desabilitar();
            btnAdicionar.Enabled = true; 
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Alterar();
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false; 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false; 
        }
    }
}
