namespace MediaAlunos
{
    partial class frmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBancoSQL = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCaminho = new System.Windows.Forms.Button();
            this.btoOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarBanco = new System.Windows.Forms.Button();
            this.btnCancelarBanco = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCaminho);
            this.groupBox1.Controls.Add(this.txtCaminho);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com arquivos xml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasta";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(43, 19);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Size = new System.Drawing.Size(312, 20);
            this.txtCaminho.TabIndex = 0;
            this.txtCaminho.Text = "C:\\Base";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnTestarConexao);
            this.groupBox2.Controls.Add(this.txtBancoSQL);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Com SQL Server Autenticação do Windows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Servidor";
            // 
            // txtBancoSQL
            // 
            this.txtBancoSQL.Location = new System.Drawing.Point(104, 19);
            this.txtBancoSQL.Name = "txtBancoSQL";
            this.txtBancoSQL.Size = new System.Drawing.Size(251, 20);
            this.txtBancoSQL.TabIndex = 0;
            this.txtBancoSQL.Text = "DESKTOP-15SRLCA\\SQLEXPRESS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 148);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btoOk);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivos XML";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConfirmarBanco);
            this.tabPage2.Controls.Add(this.btnCancelarBanco);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCaminho
            // 
            this.btnCaminho.Image = global::MediaAlunos.Properties.Resources.folder__1_;
            this.btnCaminho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaminho.Location = new System.Drawing.Point(361, 15);
            this.btnCaminho.Name = "btnCaminho";
            this.btnCaminho.Size = new System.Drawing.Size(111, 27);
            this.btnCaminho.TabIndex = 1;
            this.btnCaminho.Text = "Selecionar pasta";
            this.btnCaminho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click);
            // 
            // btoOk
            // 
            this.btoOk.Image = global::MediaAlunos.Properties.Resources.folder_check;
            this.btoOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoOk.Location = new System.Drawing.Point(318, 64);
            this.btoOk.Name = "btoOk";
            this.btoOk.Size = new System.Drawing.Size(83, 35);
            this.btoOk.TabIndex = 2;
            this.btoOk.Text = "Confirmar";
            this.btoOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btoOk.UseVisualStyleBackColor = true;
            this.btoOk.Click += new System.EventHandler(this.btoOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MediaAlunos.Properties.Resources.folder_close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(403, 64);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmarBanco
            // 
            this.btnConfirmarBanco.Image = global::MediaAlunos.Properties.Resources.microsoft_sql_server_check;
            this.btnConfirmarBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarBanco.Location = new System.Drawing.Point(318, 64);
            this.btnConfirmarBanco.Name = "btnConfirmarBanco";
            this.btnConfirmarBanco.Size = new System.Drawing.Size(83, 35);
            this.btnConfirmarBanco.TabIndex = 5;
            this.btnConfirmarBanco.Text = "Confirmar";
            this.btnConfirmarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarBanco.UseVisualStyleBackColor = true;
            this.btnConfirmarBanco.Click += new System.EventHandler(this.btnConfirmarBanco_Click);
            // 
            // btnCancelarBanco
            // 
            this.btnCancelarBanco.Image = global::MediaAlunos.Properties.Resources.microsoft_sql_server_close;
            this.btnCancelarBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarBanco.Location = new System.Drawing.Point(403, 64);
            this.btnCancelarBanco.Name = "btnCancelarBanco";
            this.btnCancelarBanco.Size = new System.Drawing.Size(83, 35);
            this.btnCancelarBanco.TabIndex = 4;
            this.btnCancelarBanco.Text = "Cancelar";
            this.btnCancelarBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarBanco.UseVisualStyleBackColor = true;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Image = global::MediaAlunos.Properties.Resources.microsoft_sql_server;
            this.btnTestarConexao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestarConexao.Location = new System.Drawing.Point(361, 15);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(111, 27);
            this.btnTestarConexao.TabIndex = 1;
            this.btnTestarConexao.Text = "Testar conexão";
            this.btnTestarConexao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 158);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Pasta";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmInicio_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCaminho;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btoOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.TextBox txtBancoSQL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConfirmarBanco;
        private System.Windows.Forms.Button btnCancelarBanco;
    }
}

