namespace teste
{
    partial class frmMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacao));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gbMovimentacao = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtModificado = new System.Windows.Forms.TextBox();
            this.lblModificado = new System.Windows.Forms.Label();
            this.txtCadastrado = new System.Windows.Forms.TextBox();
            this.lblCadastrado = new System.Windows.Forms.Label();
            this.dgMovimentacao = new System.Windows.Forms.DataGridView();
            this.txtCadPor = new System.Windows.Forms.TextBox();
            this.lblCadPor = new System.Windows.Forms.Label();
            this.gbMovimentacao.SuspendLayout();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::teste.Properties.Resources.filesave;
            this.btnSalvar.Location = new System.Drawing.Point(597, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 42);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::teste.Properties.Resources.button_cancel;
            this.btnCancelar.Location = new System.Drawing.Point(160, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::teste.Properties.Resources.eraser;
            this.btnExcluir.Location = new System.Drawing.Point(454, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 42);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::teste.Properties.Resources.korganizer;
            this.btnAlterar.Location = new System.Drawing.Point(307, 6);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 42);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "A&lterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::teste.Properties.Resources.plus;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(93, 42);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // gbMovimentacao
            // 
            this.gbMovimentacao.Controls.Add(this.txtValor);
            this.gbMovimentacao.Controls.Add(this.lblSituacao);
            this.gbMovimentacao.Controls.Add(this.txtSituacao);
            this.gbMovimentacao.Controls.Add(this.label1);
            this.gbMovimentacao.Controls.Add(this.cbSubCategoria);
            this.gbMovimentacao.Controls.Add(this.lblCategoria);
            this.gbMovimentacao.Controls.Add(this.cbCategoria);
            this.gbMovimentacao.Controls.Add(this.txtDescricao);
            this.gbMovimentacao.Controls.Add(this.lblDescricao);
            this.gbMovimentacao.Controls.Add(this.gbTipo);
            this.gbMovimentacao.Controls.Add(this.dtVencimento);
            this.gbMovimentacao.Controls.Add(this.lblValor);
            this.gbMovimentacao.Controls.Add(this.txtCod);
            this.gbMovimentacao.Controls.Add(this.lblVencimento);
            this.gbMovimentacao.Controls.Add(this.lblCod);
            this.gbMovimentacao.Location = new System.Drawing.Point(13, 68);
            this.gbMovimentacao.Name = "gbMovimentacao";
            this.gbMovimentacao.Size = new System.Drawing.Size(677, 207);
            this.gbMovimentacao.TabIndex = 13;
            this.gbMovimentacao.TabStop = false;
            this.gbMovimentacao.Text = "Cadastro de Movimentações";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Info;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(515, 27);
            this.txtValor.MaxLength = 15;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(126, 21);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress_1);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(500, 83);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 29;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtSituacao
            // 
            this.txtSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSituacao.Location = new System.Drawing.Point(558, 80);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(83, 20);
            this.txtSituacao.TabIndex = 28;
            this.txtSituacao.TabStop = false;
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sub-Categoria:";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(99, 170);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbSubCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(31, 126);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 13);
            this.lblCategoria.TabIndex = 25;
            this.lblCategoria.Text = "* Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(99, 123);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(99, 80);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(300, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(28, 83);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 13);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "* Descrição:";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbReceber);
            this.gbTipo.Controls.Add(this.rbPagar);
            this.gbTipo.Location = new System.Drawing.Point(441, 111);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(200, 80);
            this.gbTipo.TabIndex = 6;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "* Tipo:";
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReceber.Location = new System.Drawing.Point(111, 38);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(83, 17);
            this.rbReceber.TabIndex = 16;
            this.rbReceber.TabStop = true;
            this.rbReceber.Text = "RECEBER";
            this.rbReceber.UseVisualStyleBackColor = true;
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagar.Location = new System.Drawing.Point(7, 38);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(67, 17);
            this.rbPagar.TabIndex = 15;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "PAGAR";
            this.rbPagar.UseVisualStyleBackColor = true;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(270, 29);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(129, 20);
            this.dtVencimento.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(438, 32);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(73, 13);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "* Valor:  R$";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(98, 29);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(54, 20);
            this.txtCod.TabIndex = 0;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(191, 32);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(73, 13);
            this.lblVencimento.TabIndex = 1;
            this.lblVencimento.Text = "* Vencimento:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(56, 32);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(36, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "* Cod:";
            // 
            // txtModificado
            // 
            this.txtModificado.Location = new System.Drawing.Point(358, 532);
            this.txtModificado.MaxLength = 100;
            this.txtModificado.Name = "txtModificado";
            this.txtModificado.ReadOnly = true;
            this.txtModificado.Size = new System.Drawing.Size(119, 20);
            this.txtModificado.TabIndex = 13;
            this.txtModificado.TabStop = false;
            // 
            // lblModificado
            // 
            this.lblModificado.AutoSize = true;
            this.lblModificado.Location = new System.Drawing.Point(243, 535);
            this.lblModificado.Name = "lblModificado";
            this.lblModificado.Size = new System.Drawing.Size(109, 13);
            this.lblModificado.TabIndex = 10;
            this.lblModificado.Text = "Data de Modificação:";
            // 
            // txtCadastrado
            // 
            this.txtCadastrado.Location = new System.Drawing.Point(114, 532);
            this.txtCadastrado.MaxLength = 100;
            this.txtCadastrado.Name = "txtCadastrado";
            this.txtCadastrado.ReadOnly = true;
            this.txtCadastrado.Size = new System.Drawing.Size(119, 20);
            this.txtCadastrado.TabIndex = 12;
            this.txtCadastrado.TabStop = false;
            // 
            // lblCadastrado
            // 
            this.lblCadastrado.AutoSize = true;
            this.lblCadastrado.Location = new System.Drawing.Point(15, 535);
            this.lblCadastrado.Name = "lblCadastrado";
            this.lblCadastrado.Size = new System.Drawing.Size(93, 13);
            this.lblCadastrado.TabIndex = 4;
            this.lblCadastrado.Text = "Data de Cadastro:";
            // 
            // dgMovimentacao
            // 
            this.dgMovimentacao.AllowUserToAddRows = false;
            this.dgMovimentacao.AllowUserToDeleteRows = false;
            this.dgMovimentacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMovimentacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgMovimentacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovimentacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMovimentacao.Location = new System.Drawing.Point(13, 281);
            this.dgMovimentacao.Name = "dgMovimentacao";
            this.dgMovimentacao.ReadOnly = true;
            this.dgMovimentacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMovimentacao.Size = new System.Drawing.Size(677, 242);
            this.dgMovimentacao.TabIndex = 12;
            this.dgMovimentacao.TabStop = false;
            this.dgMovimentacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovimentacao_CellContentClick);
            // 
            // txtCadPor
            // 
            this.txtCadPor.Location = new System.Drawing.Point(571, 532);
            this.txtCadPor.MaxLength = 100;
            this.txtCadPor.Name = "txtCadPor";
            this.txtCadPor.ReadOnly = true;
            this.txtCadPor.Size = new System.Drawing.Size(119, 20);
            this.txtCadPor.TabIndex = 14;
            this.txtCadPor.TabStop = false;
            // 
            // lblCadPor
            // 
            this.lblCadPor.AutoSize = true;
            this.lblCadPor.Location = new System.Drawing.Point(483, 535);
            this.lblCadPor.Name = "lblCadPor";
            this.lblCadPor.Size = new System.Drawing.Size(82, 13);
            this.lblCadPor.TabIndex = 20;
            this.lblCadPor.Text = "Cadastrado por:";
            // 
            // frmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 557);
            this.Controls.Add(this.txtCadPor);
            this.Controls.Add(this.lblCadPor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtCadastrado);
            this.Controls.Add(this.txtModificado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblCadastrado);
            this.Controls.Add(this.lblModificado);
            this.Controls.Add(this.gbMovimentacao);
            this.Controls.Add(this.dgMovimentacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Movimentação :.";
            this.Load += new System.EventHandler(this.frmMovimentacao_Load);
            this.gbMovimentacao.ResumeLayout(false);
            this.gbMovimentacao.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gbMovimentacao;
        private System.Windows.Forms.TextBox txtModificado;
        private System.Windows.Forms.Label lblModificado;
        private System.Windows.Forms.TextBox txtCadastrado;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCadastrado;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.DataGridView dgMovimentacao;
        private System.Windows.Forms.TextBox txtCadPor;
        private System.Windows.Forms.Label lblCadPor;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.TextBox txtValor;
    }
}