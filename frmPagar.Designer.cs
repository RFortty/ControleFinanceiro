namespace teste
{
    partial class frmPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagar));
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.rbSubCategoria = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.rbVencimento = new System.Windows.Forms.RadioButton();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.dgPagar = new System.Windows.Forms.DataGridView();
            this.lblLocalizar = new System.Windows.Forms.Label();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.txtTotalP = new System.Windows.Forms.TextBox();
            this.lblTotalP = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.btnBaixa = new System.Windows.Forms.Button();
            this.gbOpcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.rbSubCategoria);
            this.gbOpcao.Controls.Add(this.rbCategoria);
            this.gbOpcao.Controls.Add(this.rbValor);
            this.gbOpcao.Controls.Add(this.rbVencimento);
            this.gbOpcao.Controls.Add(this.rbCod);
            this.gbOpcao.Location = new System.Drawing.Point(12, 12);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(301, 135);
            this.gbOpcao.TabIndex = 0;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Opção de Ordenação:";
            // 
            // rbSubCategoria
            // 
            this.rbSubCategoria.AutoSize = true;
            this.rbSubCategoria.Location = new System.Drawing.Point(178, 69);
            this.rbSubCategoria.Name = "rbSubCategoria";
            this.rbSubCategoria.Size = new System.Drawing.Size(110, 17);
            this.rbSubCategoria.TabIndex = 4;
            this.rbSubCategoria.TabStop = true;
            this.rbSubCategoria.Text = "por Sub-Categoria";
            this.rbSubCategoria.UseVisualStyleBackColor = true;
            this.rbSubCategoria.CheckedChanged += new System.EventHandler(this.rbSubCategoria_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(178, 35);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(88, 17);
            this.rbCategoria.TabIndex = 3;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "por Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Location = new System.Drawing.Point(6, 103);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(107, 17);
            this.rbValor.TabIndex = 2;
            this.rbValor.TabStop = true;
            this.rbValor.Text = "por Valor à Pagar";
            this.rbValor.UseVisualStyleBackColor = true;
            this.rbValor.CheckedChanged += new System.EventHandler(this.rbValor_CheckedChanged);
            // 
            // rbVencimento
            // 
            this.rbVencimento.AutoSize = true;
            this.rbVencimento.Location = new System.Drawing.Point(6, 69);
            this.rbVencimento.Name = "rbVencimento";
            this.rbVencimento.Size = new System.Drawing.Size(99, 17);
            this.rbVencimento.TabIndex = 1;
            this.rbVencimento.TabStop = true;
            this.rbVencimento.Text = "por Vencimento";
            this.rbVencimento.UseVisualStyleBackColor = true;
            this.rbVencimento.CheckedChanged += new System.EventHandler(this.rbVencimento_CheckedChanged);
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Location = new System.Drawing.Point(6, 35);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(76, 17);
            this.rbCod.TabIndex = 0;
            this.rbCod.TabStop = true;
            this.rbCod.Text = "por Código";
            this.rbCod.UseVisualStyleBackColor = true;
            this.rbCod.CheckedChanged += new System.EventHandler(this.rbCod_CheckedChanged);
            // 
            // dgPagar
            // 
            this.dgPagar.AllowUserToAddRows = false;
            this.dgPagar.AllowUserToDeleteRows = false;
            this.dgPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPagar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPagar.Location = new System.Drawing.Point(12, 153);
            this.dgPagar.Name = "dgPagar";
            this.dgPagar.ReadOnly = true;
            this.dgPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagar.Size = new System.Drawing.Size(677, 392);
            this.dgPagar.TabIndex = 13;
            this.dgPagar.TabStop = false;
            // 
            // lblLocalizar
            // 
            this.lblLocalizar.AutoSize = true;
            this.lblLocalizar.Location = new System.Drawing.Point(328, 26);
            this.lblLocalizar.Name = "lblLocalizar";
            this.lblLocalizar.Size = new System.Drawing.Size(13, 13);
            this.lblLocalizar.TabIndex = 14;
            this.lblLocalizar.Text = "-:";
            this.lblLocalizar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Location = new System.Drawing.Point(400, 23);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(187, 20);
            this.txtLocalizar.TabIndex = 5;
            // 
            // txtTotalP
            // 
            this.txtTotalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalP.ForeColor = System.Drawing.Color.Red;
            this.txtTotalP.Location = new System.Drawing.Point(589, 551);
            this.txtTotalP.Name = "txtTotalP";
            this.txtTotalP.Size = new System.Drawing.Size(100, 22);
            this.txtTotalP.TabIndex = 15;
            this.txtTotalP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalP
            // 
            this.lblTotalP.AutoSize = true;
            this.lblTotalP.Location = new System.Drawing.Point(492, 556);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(91, 13);
            this.lblTotalP.TabIndex = 16;
            this.lblTotalP.Text = "Total à Pagar: R$";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.SystemColors.Info;
            this.btnLocalizar.Image = global::teste.Properties.Resources.find;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(593, 21);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 6;
            this.btnLocalizar.Text = "&Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.Image = global::teste.Properties.Resources.PDFFile;
            this.btnGerarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarPDF.Location = new System.Drawing.Point(593, 124);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGerarPDF.TabIndex = 17;
            this.btnGerarPDF.Text = "GerarPDF";
            this.btnGerarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);
            // 
            // btnBaixa
            // 
            this.btnBaixa.BackColor = System.Drawing.SystemColors.Control;
            this.btnBaixa.Image = global::teste.Properties.Resources.arrow_270;
            this.btnBaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixa.Location = new System.Drawing.Point(460, 124);
            this.btnBaixa.Name = "btnBaixa";
            this.btnBaixa.Size = new System.Drawing.Size(75, 23);
            this.btnBaixa.TabIndex = 7;
            this.btnBaixa.Text = "Dar Baixa";
            this.btnBaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaixa.UseVisualStyleBackColor = false;
            this.btnBaixa.Click += new System.EventHandler(this.btnBaixa_Click);
            // 
            // frmPagar
            // 
            this.AcceptButton = this.btnLocalizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 580);
            this.Controls.Add(this.btnGerarPDF);
            this.Controls.Add(this.lblTotalP);
            this.Controls.Add(this.txtTotalP);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnBaixa);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.lblLocalizar);
            this.Controls.Add(this.dgPagar);
            this.Controls.Add(this.gbOpcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Consulta Contas à Pagar :.";
            this.Load += new System.EventHandler(this.frmPagar_Load);
            this.gbOpcao.ResumeLayout(false);
            this.gbOpcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.DataGridView dgPagar;
        private System.Windows.Forms.RadioButton rbSubCategoria;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.RadioButton rbVencimento;
        private System.Windows.Forms.RadioButton rbCod;
        private System.Windows.Forms.Label lblLocalizar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Button btnBaixa;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtTotalP;
        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.Button btnGerarPDF;
    }
}