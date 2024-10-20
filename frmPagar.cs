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
    public partial class frmPagar : Form
    {
        public frmPagar()
        {
            InitializeComponent();
        }

    private void TelaInicial()
    {
        //rbCod.Checked = true;
        rbVencimento.Checked = false;
        rbValor.Checked = false;
        rbCategoria.Checked = false;
        rbSubCategoria.Checked = false;

        lblLocalizar.Text = "-:";
        txtLocalizar.Text = "";
        txtLocalizar.Focus();  
    }

    private decimal ValorTotal()
    {
        decimal total = 0;
        int i = 0;
        for (i = 0; i < dgPagar.Rows.Count; i++)
        {
            total = total + Convert.ToDecimal(dgPagar.Rows[i].Cells["valor"].Value);
        }
        return total;
    }
    private void CalculaValorTotalGrid()
    {
        if (dgPagar.Rows.Count > 0)
            txtTotalP.Text = ValorTotal().ToString("c");
    }

        private void frmPagar_Load(object sender, EventArgs e)
        {            
            TelaInicial();
            Atualizar();
            CalculaValorTotalGrid();

            dgPagar.Columns["valor"].DefaultCellStyle.Format = "C2"; //exibe valores monetarios com duas casas decimais no datagridview
        }

        private void Atualizar()
        {
            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados

            string query = "SELECT codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor FROM movimentacao WHERE tipomov = 'P' AND situacao = 'em aberto' ORDER by codmov"; // cria uma variável para selecionar todos os usuarios da tabela movimentacao
            MySqlCommand cmd = new MySqlCommand(query, conexao.conexao); // cria um comando de conexao com o bd

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgPagar.DataSource = data;            
        }

        private void Ordenar()
        {
            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados

            if (rbCod.Checked == true)
            {                
                dgPagar.Sort(dgPagar.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                lblLocalizar.Text = "Código:";
                txtLocalizar.Focus();

                string query = "SELECT codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor FROM movimentacao WHERE codmov LIKE @codmov AND tipomov = 'P' AND situacao = 'em aberto' ORDER by codmov";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conexao.conexao);
                //Passagem por parâmetros.
                da.SelectCommand.Parameters.AddWithValue("@codmov","%" + txtLocalizar.Text + "%");
                
                DataSet ds = new DataSet();
                da.Fill(ds, "movimentacao");
                dgPagar.DataSource = ds.Tables["movimentacao"];
            }

            else if (rbVencimento.Checked == true)
            {
                dgPagar.Sort(dgPagar.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                lblLocalizar.Text = "Vencimento:";
                txtLocalizar.Focus();

                string query = "SELECT codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor FROM movimentacao WHERE vencimento LIKE @vencimento AND tipomov = 'P' AND situacao = 'em aberto' ORDER by vencimento";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conexao.conexao);
                //Passagem por parâmetros.
                da.SelectCommand.Parameters.AddWithValue("@vencimento","%" + txtLocalizar.Text + "%");

                DataSet ds = new DataSet();
                da.Fill(ds, "movimentacao");
                dgPagar.DataSource = ds.Tables["movimentacao"];
            }

            else if (rbValor.Checked == true)
            {
                dgPagar.Sort(dgPagar.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
                lblLocalizar.Text = "Valor:";
                txtLocalizar.Focus();

                string query = "SELECT codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor FROM movimentacao WHERE valor LIKE @valor AND tipomov = 'P' AND situacao = 'em aberto' ORDER by valor";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conexao.conexao);
                //Passagem por parâmetros.
                da.SelectCommand.Parameters.AddWithValue("@valor","%" + txtLocalizar.Text + "%");

                DataSet ds = new DataSet();
                da.Fill(ds, "movimentacao");
                dgPagar.DataSource = ds.Tables["movimentacao"];
            }
            
            else if (rbCategoria.Checked == true)
            {
                dgPagar.Sort(dgPagar.Columns[4], System.ComponentModel.ListSortDirection.Ascending);
                lblLocalizar.Text = "Categoria:";
                txtLocalizar.Focus();

                string query = "SELECT codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor FROM movimentacao WHERE descat LIKE @descat AND tipomov = 'P' AND situacao = 'em aberto' ORDER by descat";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conexao.conexao);
                //Passagem por parâmetros.
                da.SelectCommand.Parameters.AddWithValue("@descat",txtLocalizar.Text + "%");

                DataSet ds = new DataSet();
                da.Fill(ds, "movimentacao");
                dgPagar.DataSource = ds.Tables["movimentacao"];
            }
            
            else if (rbSubCategoria.Checked == true)
            {
                dgPagar.Sort(dgPagar.Columns[5], System.ComponentModel.ListSortDirection.Ascending);
                lblLocalizar.Text = "Sub-Categoria:";
                txtLocalizar.Focus();

                string query = "SELECT codmov, vencimento, valor, descmov, descat, desubcat, tipomov, situacao, cadastrado, modificado, cadpor FROM movimentacao WHERE desubcat LIKE @desubcat AND tipomov = 'P' AND situacao = 'em aberto' ORDER by desubcat";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conexao.conexao);
                //Passagem por parâmetros.
                da.SelectCommand.Parameters.AddWithValue("@desubcat",txtLocalizar.Text + "%");

                DataSet ds = new DataSet();
                da.Fill(ds, "movimentacao");
                dgPagar.DataSource = ds.Tables["movimentacao"];
            }
        }
                
        private void rbCod_CheckedChanged(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void rbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void rbValor_CheckedChanged(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void rbSubCategoria_CheckedChanged(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void Baixa()
        {
            Conexao conexao = new Conexao();
            
            try
            {
                conexao.Conectar();

                if (dgPagar.SelectedRows[0].Cells[0].Value == "-1")// vamos ocultar a primeira linha
                {
                    dgPagar.Rows[0].Visible = false; 
                }
                else if (DialogResult.Yes == MessageBox.Show("Deseja realmente dar baixa nos dados selecionados ?", "Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlCommand update = conexao.conexao.CreateCommand(); // habilita a criação de um comando p/ inserir na tabela
                    update.CommandText = "UPDATE movimentacao SET situacao=@situacao WHERE codmov=@codmov"; // comando para alterar registro do bd
                    update.Parameters.AddWithValue("@codmov", dgPagar.SelectedRows[0].Cells[0].Value.ToString());
                    update.Parameters.AddWithValue("@situacao", dgPagar.SelectedRows[0].Cells[7].Value="pago"); //atualiza a coluna 'Situação' do DataGridView
                    //dgPagar.Rows.Remove(dgPagar.Rows[dgPagar.CurrentRow.Index]); // remove a linha do datagrid que está selecionada
                    update.ExecuteNonQuery();

                    MessageBox.Show("Dados Baixados com Sucesso !", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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
            }
        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {
            if (dgPagar.RowCount == 0)//verifica se o datagrid está vazio
            {
                MessageBox.Show("Não há Registro para ser dado Baixa !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (dgPagar.SelectedRows[0].Cells[7].Value == "em aberto")
                {
                    MessageBox.Show("É necessário selecionar um item abaixo !");
                }    
            else
            {
                Baixa();
                CalculaValorTotalGrid(); 
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Ordenar();
            txtLocalizar.Text = ""; 
        }

        private void GerarPDF()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgPagar.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 98;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dgPagar.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgPagar.Rows)   
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
            using (FileStream stream = new FileStream(folderPath + "ContasPagar.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("RELATÓRIO DE CONTAS À PAGAR :"));
                pdfDoc.Add(new Paragraph(" " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss")));
                pdfDoc.Add(new Paragraph(" "));

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                //Process.Start(folderPath);
            }
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            GerarPDF();
            System.Diagnostics.Process.Start(@"c:\Controle Financeiro\PDFs_ControleFinanceiro\ContasPagar.pdf");
        }
    }
}
