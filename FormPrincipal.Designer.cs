namespace teste
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovimentacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SubCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RelCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RelSubCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.txtTotalL = new System.Windows.Forms.TextBox();
            this.lblReceber = new System.Windows.Forms.Label();
            this.lblPagar = new System.Windows.Forms.Label();
            this.txtReceber = new System.Windows.Forms.TextBox();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.ConsultaToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.CalculadoraToolStripMenuItem,
            this.SobreToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovimentacoesToolStripMenuItem,
            this.toolStripSeparator2,
            this.CategoriasToolStripMenuItem,
            this.toolStripSeparator1,
            this.UsuariosToolStripMenuItem,
            this.toolStripSeparator3,
            this.LogOutToolStripMenuItem});
            this.MenuToolStripMenuItem.Image = global::teste.Properties.Resources.file_manager1;
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.MenuToolStripMenuItem.Tag = "Menu de Cadastros";
            this.MenuToolStripMenuItem.Text = "&Menu";
            // 
            // MovimentacoesToolStripMenuItem
            // 
            this.MovimentacoesToolStripMenuItem.Image = global::teste.Properties.Resources.Money;
            this.MovimentacoesToolStripMenuItem.Name = "MovimentacoesToolStripMenuItem";
            this.MovimentacoesToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.MovimentacoesToolStripMenuItem.Text = "Cadastro de Movimentações";
            this.MovimentacoesToolStripMenuItem.Click += new System.EventHandler(this.MovimentacoesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(290, 6);
            // 
            // CategoriasToolStripMenuItem
            // 
            this.CategoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriasToolStripMenuItem1,
            this.SubCategoriasToolStripMenuItem});
            this.CategoriasToolStripMenuItem.Image = global::teste.Properties.Resources.color_swatch;
            this.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem";
            this.CategoriasToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.CategoriasToolStripMenuItem.Text = "Cadastro de Tipos";
            // 
            // CategoriasToolStripMenuItem1
            // 
            this.CategoriasToolStripMenuItem1.Image = global::teste.Properties.Resources.notebook;
            this.CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1";
            this.CategoriasToolStripMenuItem1.Size = new System.Drawing.Size(203, 38);
            this.CategoriasToolStripMenuItem1.Text = "Categorias";
            this.CategoriasToolStripMenuItem1.Click += new System.EventHandler(this.CategoriasToolStripMenuItem1_Click);
            // 
            // SubCategoriasToolStripMenuItem
            // 
            this.SubCategoriasToolStripMenuItem.Image = global::teste.Properties.Resources.sitemap;
            this.SubCategoriasToolStripMenuItem.Name = "SubCategoriasToolStripMenuItem";
            this.SubCategoriasToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.SubCategoriasToolStripMenuItem.Text = "Sub-Categorias";
            this.SubCategoriasToolStripMenuItem.Click += new System.EventHandler(this.SubCategoriasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(290, 6);
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Image = global::teste.Properties.Resources.Login_Manager;
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.UsuariosToolStripMenuItem.Text = "Cadastro de Usuários";
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(290, 6);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Image = global::teste.Properties.Resources.exitz;
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.LogOutToolStripMenuItem.Text = "LogOut";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PagarToolStripMenuItem,
            this.ReceberToolStripMenuItem});
            this.ConsultaToolStripMenuItem.Image = global::teste.Properties.Resources.xmag;
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.ConsultaToolStripMenuItem.Text = "&Consulta";
            // 
            // PagarToolStripMenuItem
            // 
            this.PagarToolStripMenuItem.Image = global::teste.Properties.Resources.Money_Calculator;
            this.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem";
            this.PagarToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.PagarToolStripMenuItem.Text = "Contas à Pagar";
            this.PagarToolStripMenuItem.Click += new System.EventHandler(this.PagarToolStripMenuItem_Click);
            // 
            // ReceberToolStripMenuItem
            // 
            this.ReceberToolStripMenuItem.Image = global::teste.Properties.Resources.Money_Pig;
            this.ReceberToolStripMenuItem.Name = "ReceberToolStripMenuItem";
            this.ReceberToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.ReceberToolStripMenuItem.Text = "Contas à Receber";
            this.ReceberToolStripMenuItem.Click += new System.EventHandler(this.ReceberToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçõesToolStripMenuItem,
            this.RelCategoriasToolStripMenuItem,
            this.RelSubCategoriasToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Image = global::teste.Properties.Resources.pdf;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.relatoriosToolStripMenuItem.Text = "&Relatorios";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.Image = global::teste.Properties.Resources.Money;
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(206, 38);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            this.movimentaçõesToolStripMenuItem.Click += new System.EventHandler(this.movimentaçõesToolStripMenuItem_Click);
            // 
            // RelCategoriasToolStripMenuItem
            // 
            this.RelCategoriasToolStripMenuItem.Image = global::teste.Properties.Resources.notebook;
            this.RelCategoriasToolStripMenuItem.Name = "RelCategoriasToolStripMenuItem";
            this.RelCategoriasToolStripMenuItem.Size = new System.Drawing.Size(206, 38);
            this.RelCategoriasToolStripMenuItem.Text = "Categorias";
            this.RelCategoriasToolStripMenuItem.Click += new System.EventHandler(this.RelCategoriasToolStripMenuItem_Click);
            // 
            // RelSubCategoriasToolStripMenuItem
            // 
            this.RelSubCategoriasToolStripMenuItem.Image = global::teste.Properties.Resources.sitemap;
            this.RelSubCategoriasToolStripMenuItem.Name = "RelSubCategoriasToolStripMenuItem";
            this.RelSubCategoriasToolStripMenuItem.Size = new System.Drawing.Size(206, 38);
            this.RelSubCategoriasToolStripMenuItem.Text = "Sub-Categorias";
            this.RelSubCategoriasToolStripMenuItem.Click += new System.EventHandler(this.RelSubCategoriasToolStripMenuItem_Click);
            // 
            // CalculadoraToolStripMenuItem
            // 
            this.CalculadoraToolStripMenuItem.Image = global::teste.Properties.Resources.calculator;
            this.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem";
            this.CalculadoraToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.CalculadoraToolStripMenuItem.Text = "C&alculadora";
            this.CalculadoraToolStripMenuItem.Click += new System.EventHandler(this.CalculadoraToolStripMenuItem_Click);
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.Image = global::teste.Properties.Resources.info;
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.SobreToolStripMenuItem.Text = "&Sobre";
            this.SobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Image = global::teste.Properties.Resources.exit;
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.SairToolStripMenuItem.Text = "Sai&r";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txtDataHora
            // 
            this.txtDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataHora.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataHora.Font = new System.Drawing.Font("Square721 Cn BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHora.Location = new System.Drawing.Point(829, 40);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(111, 33);
            this.txtDataHora.TabIndex = 2;
            this.txtDataHora.TabStop = false;
            this.txtDataHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.lblUsuario.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(932, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(78, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbTotal
            // 
            this.gbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotal.BackColor = System.Drawing.Color.Transparent;
            this.gbTotal.Controls.Add(this.lblSaldoTotal);
            this.gbTotal.Controls.Add(this.txtTotalL);
            this.gbTotal.Controls.Add(this.lblReceber);
            this.gbTotal.Controls.Add(this.lblPagar);
            this.gbTotal.Controls.Add(this.txtReceber);
            this.gbTotal.Controls.Add(this.txtPagar);
            this.gbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(798, 525);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(187, 193);
            this.gbTotal.TabIndex = 4;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "C O N T A S :";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.BackColor = System.Drawing.SystemColors.Info;
            this.lblSaldoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSaldoTotal.Location = new System.Drawing.Point(6, 147);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(86, 17);
            this.lblSaldoTotal.TabIndex = 7;
            this.lblSaldoTotal.Text = "Saldo Total:";
            // 
            // txtTotalL
            // 
            this.txtTotalL.BackColor = System.Drawing.Color.White;
            this.txtTotalL.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalL.ForeColor = System.Drawing.Color.Black;
            this.txtTotalL.Location = new System.Drawing.Point(44, 161);
            this.txtTotalL.Name = "txtTotalL";
            this.txtTotalL.ReadOnly = true;
            this.txtTotalL.Size = new System.Drawing.Size(137, 26);
            this.txtTotalL.TabIndex = 6;
            this.txtTotalL.TabStop = false;
            this.txtTotalL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReceber
            // 
            this.lblReceber.AutoSize = true;
            this.lblReceber.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblReceber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceber.ForeColor = System.Drawing.Color.White;
            this.lblReceber.Location = new System.Drawing.Point(6, 86);
            this.lblReceber.Name = "lblReceber";
            this.lblReceber.Size = new System.Drawing.Size(69, 17);
            this.lblReceber.TabIndex = 3;
            this.lblReceber.Text = "Receitas:";
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.BackColor = System.Drawing.Color.Red;
            this.lblPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagar.ForeColor = System.Drawing.Color.White;
            this.lblPagar.Location = new System.Drawing.Point(6, 32);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(76, 17);
            this.lblPagar.TabIndex = 2;
            this.lblPagar.Text = "Despesas:";
            // 
            // txtReceber
            // 
            this.txtReceber.BackColor = System.Drawing.Color.White;
            this.txtReceber.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtReceber.Location = new System.Drawing.Point(44, 99);
            this.txtReceber.Name = "txtReceber";
            this.txtReceber.ReadOnly = true;
            this.txtReceber.Size = new System.Drawing.Size(137, 26);
            this.txtReceber.TabIndex = 1;
            this.txtReceber.TabStop = false;
            this.txtReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPagar
            // 
            this.txtPagar.BackColor = System.Drawing.Color.White;
            this.txtPagar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagar.ForeColor = System.Drawing.Color.Red;
            this.txtPagar.Location = new System.Drawing.Point(44, 45);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.ReadOnly = true;
            this.txtPagar.Size = new System.Drawing.Size(137, 26);
            this.txtPagar.TabIndex = 0;
            this.txtPagar.TabStop = false;
            this.txtPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(769, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::teste.Properties.Resources.back_fin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = ".: Controle Financeiro :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovimentacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReceberToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SubCategoriasToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Label lblReceber;
        private System.Windows.Forms.Label lblPagar;
        private System.Windows.Forms.TextBox txtReceber;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.TextBox txtTotalL;
        private System.Windows.Forms.ToolStripMenuItem CalculadoraToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RelSubCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RelCategoriasToolStripMenuItem;
    }
}

