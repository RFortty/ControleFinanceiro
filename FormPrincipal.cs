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
using System.Diagnostics; // biblioteca para poder chamar a calculadora 

namespace teste
{
    public partial class frmPrincipal : Form
    {
        DateTime DataHora; //variável que receberá a data e hora do sistema.

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e) // Obs: a propriedade Interval = 1000 do componente Timer corresponde a 1 segundo na mudança de tempo
        {
            //INTERVAL = 1000 -> 1 segundo
            DataHora = DateTime.Now; // a variável DataHora recebe a data e hora agora.
            //txtDataHora.Text = DataHora.ToLongDateString() + " - [ " + DataHora.ToLongTimeString() + " ]"; // mostrando a data e a hora no textbox
            txtDataHora.Text = DataHora.ToLongTimeString(); // mostrando a hora no textbox
            Calcular(); 
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios(); // cria o método p/ chamar o formulário principal
            usuarios.ShowDialog(); // mostro o form Usuarios sem permitir clicar no form Principal                 
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o formulario Principal
 
            Autenticacao.logout();
  
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void Calcular()
        {
            decimal totalP = 0;
            decimal totalR = 0;
            decimal SaldoTotal = 0;

            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados

            try
            {
                string query2 = "SELECT COALESCE(SUM(valor),0) FROM movimentacao WHERE tipomov = 'P' AND situacao = 'em aberto'"; // cria uma variável para somar todos os dados da coluna valores da tabela movimentacao --> COALESCE = PEGA UM CAMPO NULO(DEFAULT) E RETORNA O VALOR ESPECIFICADO.
                MySqlCommand cmd2 = new MySqlCommand(query2, conexao.conexao);

                totalP = decimal.Parse(cmd2.ExecuteScalar().ToString()); // joga na variável a Soma dos valores da coluna no banco de dados
                txtPagar.Text = totalP.ToString("C");
            }
            catch(Exception ex)
            {
                totalP = 0;
                txtPagar.Text = totalP.ToString();
                MessageBox.Show("ERRO: " + ex); 
            }
                
            try
            {
                string query3 = "SELECT COALESCE(SUM(valor),0) FROM movimentacao WHERE tipomov = 'R' AND situacao = 'em aberto'"; // cria uma variável para somar todos os dados da coluna valores da tabela movimentacao --> COALESCE = PEGA UM CAMPO NULO(DEFAULT) E RETORNA O VALOR ESPECIFICADO.
                MySqlCommand cmd3 = new MySqlCommand(query3, conexao.conexao);

                totalR = decimal.Parse(cmd3.ExecuteScalar().ToString()); //joga na variável a Soma dos valores de uma coluna no banco de dados
                txtReceber.Text = totalR.ToString("C"); // C formata com 2 casas decimais e mostra o $
            }
            catch (Exception ex)
            {
                totalR = 0;
                txtReceber.Text = totalR.ToString("C"); // C formata com 2 casas decimais e mostra o $
                MessageBox.Show("ERRO: " + ex); 
            }
                                                
            SaldoTotal = totalR - totalP;
            txtTotalL.Text = SaldoTotal.ToString("C"); // C formata com 2 casas decimais e mostra o $

            if (SaldoTotal < 0)
            {
                txtTotalL.ForeColor = Color.Red;
            }
            else
            {
                txtTotalL.ForeColor = Color.DodgerBlue;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //menuStrip1.Items[0].Enabled = false; // Desabilita os itens do menu principal

            Conexao conexao = new Conexao(); // Chama a Classe conexao
            conexao.Conectar(); // conecta ao banco de dados
            
            string query = "SELECT nivel FROM login WHERE usuario=@usuario AND senha=@senha"; // cria uma variável para selecionar todos os usuarios da tabela login
            MySqlCommand cmd = new MySqlCommand(); // cria um comando de conexao com o bd
                                                           
           if (Autenticacao.getNivel() == "Usuário")
            {                               
                //menuStrip1.Items[2].Enabled = false; // Desabilita os itens do menu principal
                UsuariosToolStripMenuItem.Enabled = false; // Desabilita o sub-menu indicado
            }
            //conexao.Desconectar();

            lblUsuario.Text = Autenticacao.getUsuario();
            //Calcular();           
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o Controle Financeiro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog(); 
        }

        private void CategoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }

        private void SubCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubCategorias subcategorias = new frmSubCategorias();
            subcategorias.ShowDialog();
        }

        private void MovimentacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacao movimentacao = new frmMovimentacao();
            movimentacao.ShowDialog();  
        }

        private void PagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagar pagar = new frmPagar();
            pagar.ShowDialog(); 
        }

        private void ReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceber receber = new frmReceber();
            receber.ShowDialog();  
        }

        private void CalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe"); //executa a Calculadora do Windows
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\Controle Financeiro\PDFs_ControleFinanceiro\Movimentação.pdf");            
        }

        private void RelCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\Controle Financeiro\PDFs_ControleFinanceiro\Categorias.pdf");
        }

        private void RelSubCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\Controle Financeiro\PDFs_ControleFinanceiro\SubCategorias.pdf");
        }
    }
}
