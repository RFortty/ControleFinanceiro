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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void Habilitar()
        {
            //txtCodigo.Enabled = true;
            txtCategoria.Enabled = true;
            txtCategoria.Focus();
        }

        private void Desabilitar()
        {
            txtCodigo.Enabled = false;
            txtCategoria.Enabled = false;
        }

        private void Limpar()
        {
            txtCodigo.Clear();
            txtCategoria.Clear();
            txtCadastrado.Clear();
            txtModificado.Clear();
            txtCadPor.Clear();

            txtCategoria.Focus();
        }

        private void Atualizar()
        {
            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados

            string query = "SELECT * FROM categoria ORDER BY descat"; // cria uma variável para selecionar todos os usuarios da tabela login
            MySqlCommand cmd = new MySqlCommand(query, conexao.conexao); // cria um comando de conexao com o bd

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgCategorias.DataSource = data;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            Desabilitar();
            Atualizar();
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.Conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(codcat)+1 as IDNovo from categoria", conexao.conexao);
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
                inserir.CommandText = "INSERT INTO categoria (codcat, descat, cadastrado, cadpor) VALUES (@codcat, @descat, @cadastrado, @cadpor)"; // comando para inserir registro do bd
                inserir.Parameters.AddWithValue("@codcat", txtCodigo.Text);
                inserir.Parameters.AddWithValue("@usuario", txtCategoria.Text);
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

                if (DialogResult.Yes == MessageBox.Show("Deseja realmente alterar os dados selecionados ?", "Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlCommand alterar = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                    alterar.CommandText = "UPDATE categoria SET codcat=@codcat, descat=@descat, modificado=@modificado WHERE codcat=@codcat"; // comando para inserir registro no bd
                    alterar.Parameters.AddWithValue("@codcat", txtCodigo.Text);
                    alterar.Parameters.AddWithValue("@descat", txtCategoria.Text);
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

                if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir os dados selecionados ?", "Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlCommand excluir = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                    excluir.CommandText = "DELETE FROM categoria WHERE codcat='" + txtCodigo.Text + "'"; // comando para excluir registro do bd
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

        private void dgCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            Habilitar();
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;

            txtCodigo.Text = dgCategorias.SelectedRows[0].Cells[0].Value.ToString();
            txtCategoria.Text = dgCategorias.SelectedRows[0].Cells[1].Value.ToString();
            txtCadastrado.Text = dgCategorias.SelectedRows[0].Cells[2].Value.ToString();
            txtModificado.Text = dgCategorias.SelectedRows[0].Cells[3].Value.ToString();
            txtCadPor.Text = dgCategorias.SelectedRows[0].Cells[4].Value.ToString();

            if (Autenticacao.getNivel() == "Usuário")
            {
                btnExcluir.Enabled = false; // Desabilita o botão Excluir
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Limpar();
            Habilitar();
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

            txtCodigo.Text = Convert.ToString(autoIncremento());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == "") || (txtCategoria.Text == ""))
            {
                MessageBox.Show("Por favor preencha o campo Categoria !");
                txtCategoria.Focus();  
            }

            else
            {
                Inserir();
                Atualizar();
                Limpar();
            }
            GerarPDF(); 
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
            GerarPDF(); 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            GerarPDF(); 
        }

        private void GerarPDF()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgCategorias.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 98;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dgCategorias.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgCategorias.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs_ControleFinanceiro\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Categorias.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("RELATÓRIO DE CATEGORIAS :"));
                pdfDoc.Add(new Paragraph(" " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss")));
                pdfDoc.Add(new Paragraph(" "));

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                //Process.Start(folderPath);
            }
        }
    }
}
