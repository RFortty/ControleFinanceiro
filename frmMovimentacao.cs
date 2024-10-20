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
    public partial class frmMovimentacao : Form
    {
        public frmMovimentacao()
        {
            InitializeComponent();
        }

        int opcao; 
        
        private void Habilitar()
        {
            //txtCod.Enabled = true;
            dtVencimento.Enabled = true;
            txtValor.Enabled = true;
            txtDescricao.Enabled = true;
            cbCategoria.Enabled = true;
            cbSubCategoria.Enabled = true;
            gbTipo.Enabled = true;
 
            txtValor.Focus();
        }

        private void Desabilitar()
        {
            txtCod.Enabled = false;
            dtVencimento.Enabled = false;
            txtValor.Enabled = false;
            txtDescricao.Enabled = false;
            cbCategoria.Enabled = false;
            cbSubCategoria.Enabled = false;
            gbTipo.Enabled = false;
        }

        private void Limpar()
        {
            txtCod.Clear();
            dtVencimento.Text = "";
            txtValor.Clear();
            txtDescricao.Clear();
            cbCategoria.Text = "";
            cbSubCategoria.Text = "";
            rbPagar.Checked = false;
            rbReceber.Checked = false;
            txtSituacao.Clear();  
            txtCadastrado.Clear();
            txtModificado.Clear();
            txtCadPor.Clear();

            txtValor.Focus();
        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
                      
            Desabilitar();
            Atualizar();
            Limpar();

            dgMovimentacao.Columns["valor"].DefaultCellStyle.Format = "C2"; //exibe valores monetarios com duas casas decimais no datagridview
        }

        private void Atualizar()
        {
            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados

            string query = "SELECT codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor FROM movimentacao ORDER by codmov"; // cria uma variável para selecionar todos os usuarios da tabela movimentacao
            MySqlCommand cmd = new MySqlCommand(query, conexao.conexao); // cria um comando de conexao com o bd

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                     
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgMovimentacao.DataSource = data;


            string query2 = "SELECT descat FROM categoria ORDER BY descat"; // cria uma variável para selecionar todos as categorias da tabela categoria
            MySqlCommand cmd2 = new MySqlCommand(query2, conexao.conexao); // cria um comando de conexao com o bd

            MySqlDataReader dr2 = cmd2.ExecuteReader(); // abre um canal de execução de dados no bd (OBS: o DataReader mantem a informação com o bd mas não guarda essas informações)

            DataTable data2 = new DataTable(); // cria um canal de execução da tabela na memória RAM com oque veio do DataReader
            data2.Load(dr2); // carrega a tabela na memória RAM 
            cbCategoria.DisplayMember = "descat"; // mostra somente as categorias da tabela no combobox
            cbCategoria.DataSource = data2; // especifica para o DataSource (que faz referencia ao bd) a origem dos dados q veio do DataTable, carregando os dados no combobox 
        

            string query3 = "SELECT desubcat FROM categoria, subcategoria WHERE categoria.codcat = subcategoria.codsub ORDER BY desubcat"; // cria uma variável para selecionar todos as sub-categorias da tabela subcategoria
            MySqlCommand cmd3 = new MySqlCommand(query3, conexao.conexao); // cria um comando de conexao com o bd

            MySqlDataReader dr3 = cmd3.ExecuteReader(); // abre um canal de execução de dados no bd (OBS: o DataReader mantem a informação com o bd mas não guarda essas informações)

            DataTable data3 = new DataTable(); // cria um canal de execução da tabela na memória RAM com oque veio do DataReader
            data3.Load(dr3); // carrega a tabela na memória RAM 
            cbSubCategoria.DisplayMember = "desubcat"; // mostra somente as sub-categorias da tabela no combobox
            cbSubCategoria.DataSource = data3; // especifica para o DataSource (que faz referencia ao bd) a origem dos dados q veio do DataTable, carregando os dados no combobox 
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.Conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(codmov)+1 as IDNovo from movimentacao", conexao.conexao);
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
            catch (Exception)
            {
               // MessageBox.Show("Não há nenhum Registro de Movimentações cadastrado !", "Aviso");
                return 1;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //PERMITIR APENAS NÚMEROS
        public void AllowNumber(KeyPressEventArgs e)
        {
            /*if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar)) //Espaço
                //char.IsPunctuation(e.KeyChar)) //Pontuação

                e.Handled = true; //Não permitir*/
            //Com o script acima é possível utilizar Números, 'Del', 'BackSpace'..

            //Abaixo só é permitido de 0 a 9
            //if ((e.KeyChar < '0') || (e.KeyChar > '9')) e.Handled = true; //Allow only numbers

            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e);
        }

        private void Inserir()
        {
            Conexao conexao = new Conexao();

            try
            {                
                conexao.Conectar();
                MySqlCommand inserir = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                inserir.CommandText = "INSERT INTO movimentacao (codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor) VALUES (@codmov, @vencimento, @valor, @descmov, @descat, @desubcat, @tipomov, @situacao, @cadastrado, @modificado, @cadpor)"; // comando para inserir registro do bd
                inserir.Parameters.AddWithValue("@codmov", txtCod.Text);
                inserir.Parameters.AddWithValue("@vencimento", dtVencimento.Text);
                inserir.Parameters.AddWithValue("@valor", Convert.ToDouble(txtValor.Text));
                inserir.Parameters.AddWithValue("@descmov", txtDescricao.Text);
                inserir.Parameters.AddWithValue("@descat", cbCategoria.Text );
                inserir.Parameters.AddWithValue("@desubcat", cbSubCategoria.Text);
                if (rbPagar.Checked == true)
                {
                    inserir.Parameters.AddWithValue("@tipomov", gbTipo.Text = "P");
                }
                else if (rbReceber.Checked == true)
                {
                    inserir.Parameters.AddWithValue("@tipomov", gbTipo.Text = "R");
                }
                inserir.Parameters.AddWithValue("@situacao", txtSituacao.Text = "em aberto");
                inserir.Parameters.AddWithValue("@cadastrado", txtCadastrado.Text = DateTime.Now.ToString());
                inserir.Parameters.AddWithValue("@modificado", txtModificado.Text);
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
                if ((txtCod.Text == "-1") || (txtCod.Text == "0"))
                {
                    MessageBox.Show("Este Registro não pode ser Alterado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DialogResult.Yes == MessageBox.Show("Deseja realmente alterar os dados selecionados ?", "Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlCommand alterar = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                    alterar.CommandText = "UPDATE movimentacao SET codmov=@codmov, vencimento=@vencimento, valor=@valor, descmov=@descmov, descat=@descat, desubcat=@desubcat, tipomov=@tipomov, situacao=@situacao, cadastrado=@cadastrado, modificado=@modificado, cadpor=@cadpor WHERE codmov=@codmov"; // comando para inserir registro no bd
                    alterar.Parameters.AddWithValue("@codmov", txtCod.Text);
                    alterar.Parameters.AddWithValue("@vencimento", dtVencimento.Text);
                    alterar.Parameters.AddWithValue("@valor", Convert.ToDouble(txtValor.Text));
                    alterar.Parameters.AddWithValue("@descmov", txtDescricao.Text);
                    alterar.Parameters.AddWithValue("@descat", cbCategoria.Text );
                    alterar.Parameters.AddWithValue("@desubcat", cbSubCategoria.Text);
                    if (rbPagar.Checked == true)
                    {
                        alterar.Parameters.AddWithValue("@tipomov", gbTipo.Text = "P");
                    }
                    else if (rbReceber.Checked == true)
                    {
                        alterar.Parameters.AddWithValue("@tipomov", gbTipo.Text = "R");
                    }
                    alterar.Parameters.AddWithValue("@situacao", txtSituacao.Text = "em aberto");
                    alterar.Parameters.AddWithValue("@cadastrado", txtCadastrado.Text);
                    alterar.Parameters.AddWithValue("@modificado", txtModificado.Text =  DateTime.Now.ToString());
                    alterar.Parameters.AddWithValue("@cadpor", txtCadPor.Text);
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

                if ((txtCod.Text == "-1") || (txtCod.Text == "0"))
                {
                    MessageBox.Show("Este Registro não pode ser Excluido !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir os dados selecionados ?", "Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlCommand excluir = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                    excluir.CommandText = "DELETE FROM movimentacao WHERE codmov='" + txtCod.Text + "'"; // comando para excluir registro do bd
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

        private void dgMovimentacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Desabilitar();
            btnAdicionar.Enabled = false; 
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
             
            txtCod.Text = dgMovimentacao.SelectedRows[0].Cells[0].Value.ToString();
            dtVencimento.Text = dgMovimentacao.SelectedRows[0].Cells[1].Value.ToString();
            txtValor.Text = dgMovimentacao.SelectedRows[0].Cells[2].Value.ToString();
            txtDescricao.Text = dgMovimentacao.SelectedRows[0].Cells[3].Value.ToString();
            cbCategoria.Text = dgMovimentacao.SelectedRows[0].Cells[4].Value.ToString();
            cbSubCategoria.Text = dgMovimentacao.SelectedRows[0].Cells[5].Value.ToString();
            gbTipo.Text = "Tipo:"; //dgMovimentacao.SelectedRows[0].Cells[6].Value.ToString();
            txtSituacao.Text = dgMovimentacao.SelectedRows[0].Cells[7].Value.ToString();
            txtCadastrado.Text = dgMovimentacao.SelectedRows[0].Cells[8].Value.ToString();
            txtModificado.Text = dgMovimentacao.SelectedRows[0].Cells[9].Value.ToString();
            txtCadPor.Text = dgMovimentacao.SelectedRows[0].Cells[10].Value.ToString();

            if (dgMovimentacao.SelectedRows[0].Cells[6].Value.ToString() == "P")
            {
                rbPagar.Checked = true; 
            }
            else if (dgMovimentacao.SelectedRows[0].Cells[6].Value.ToString() == "R")
            {
                rbReceber.Checked = true;
            }

            if (Autenticacao.getNivel() == "Usuário")
            {
                btnExcluir.Enabled = false; // Desabilita o botão Excluir
                btnAlterar.Enabled = false; // Desabilita o botão Alterar
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {            
            opcao = 1;
                        
            Limpar();
            Habilitar();
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            
            txtCod.Text = Convert.ToString(autoIncremento());
            btnAdicionar.Enabled = false; 
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            if (opcao == 1)
            {
                try
                {
                    if ((txtCod.Text == "") || (txtValor.Text == "") || (txtDescricao.Text == "") || (cbCategoria.Text == "") || (rbPagar.Checked == false) && (rbReceber.Checked == false))
                    {
                        MessageBox.Show("É necessário preencher todos os campos !");
                        txtValor.Focus();  
                    }

                    else
                    { 
                        Inserir();
                        Atualizar();
                        Limpar();
                        Desabilitar(); 
                        btnAdicionar.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnSalvar.Enabled = false; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                }
                finally
                {
                    conexao.Desconectar();
                }
            }
            else if (opcao == 2)
            {
                try
                {
                    Alterar();
                    Atualizar();
                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                }
                finally
                {
                    conexao.Desconectar();

                    btnAdicionar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
            gbTipo.Text = "Tipo:";
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            opcao = 2;

            Habilitar();
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
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
            PdfPTable pdfTable = new PdfPTable(dgMovimentacao.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 98;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
                       
            //Adding Header row
            foreach (DataGridViewColumn column in dgMovimentacao.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgMovimentacao.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\Controle Financeiro\\PDFs_ControleFinanceiro\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Movimentação.pdf", FileMode.Create))
            { 
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f); 
                PdfWriter.GetInstance(pdfDoc, stream);                           
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("RELATÓRIO DE MOVIMENTAÇÕES :"));
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
