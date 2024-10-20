namespace teste
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.pictureBoxIFSP = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIFSP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIFSP
            // 
            this.pictureBoxIFSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIFSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxIFSP.Image = global::teste.Properties.Resources.logo_ADS;
            this.pictureBoxIFSP.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxIFSP.Name = "pictureBoxIFSP";
            this.pictureBoxIFSP.Size = new System.Drawing.Size(439, 178);
            this.pictureBoxIFSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIFSP.TabIndex = 0;
            this.pictureBoxIFSP.TabStop = false;
            // 
            // listBox
            // 
            this.listBox.Enabled = false;
            this.listBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Items.AddRange(new object[] {
            "Desenvolvido por :",
            "",
            "\t\t   Janaina C. Godoi",
            "             \t\t&",
            "\t\tRoberto Forti Antonio",
            "",
            "",
            "",
            "Copyright(C) 2014.",
            "Todos os direitos reservados"});
            this.listBox.Location = new System.Drawing.Point(2, 186);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(439, 184);
            this.listBox.TabIndex = 1;
            this.listBox.TabStop = false;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 374);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pictureBoxIFSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Sobre o Controle Financeiro :.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIFSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIFSP;
        private System.Windows.Forms.ListBox listBox;
    }
}