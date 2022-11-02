namespace MediaAlunos
{
    partial class frmApuracao
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota03DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota04DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAlunoMediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlunoMediaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alunoDataGridViewTextBoxColumn,
            this.nota01DataGridViewTextBoxColumn,
            this.nota02DataGridViewTextBoxColumn,
            this.nota03DataGridViewTextBoxColumn,
            this.nota04DataGridViewTextBoxColumn,
            this.mediaDataGridViewTextBoxColumn,
            this.resultadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewAlunoMediaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            this.alunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota01DataGridViewTextBoxColumn
            // 
            this.nota01DataGridViewTextBoxColumn.DataPropertyName = "Nota_01";
            this.nota01DataGridViewTextBoxColumn.HeaderText = "Nota_01";
            this.nota01DataGridViewTextBoxColumn.Name = "nota01DataGridViewTextBoxColumn";
            this.nota01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota02DataGridViewTextBoxColumn
            // 
            this.nota02DataGridViewTextBoxColumn.DataPropertyName = "Nota_02";
            this.nota02DataGridViewTextBoxColumn.HeaderText = "Nota_02";
            this.nota02DataGridViewTextBoxColumn.Name = "nota02DataGridViewTextBoxColumn";
            this.nota02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota03DataGridViewTextBoxColumn
            // 
            this.nota03DataGridViewTextBoxColumn.DataPropertyName = "Nota_03";
            this.nota03DataGridViewTextBoxColumn.HeaderText = "Nota_03";
            this.nota03DataGridViewTextBoxColumn.Name = "nota03DataGridViewTextBoxColumn";
            this.nota03DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nota04DataGridViewTextBoxColumn
            // 
            this.nota04DataGridViewTextBoxColumn.DataPropertyName = "Nota_04";
            this.nota04DataGridViewTextBoxColumn.HeaderText = "Nota_04";
            this.nota04DataGridViewTextBoxColumn.Name = "nota04DataGridViewTextBoxColumn";
            this.nota04DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            this.mediaDataGridViewTextBoxColumn.HeaderText = "Media";
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultadoDataGridViewTextBoxColumn
            // 
            this.resultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.HeaderText = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.Name = "resultadoDataGridViewTextBoxColumn";
            this.resultadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewAlunoMediaBindingSource
            // 
            this.viewAlunoMediaBindingSource.DataSource = typeof(MediaAlunos.ViewAlunoMedia);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MediaAlunos.Properties.Resources.folder_close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(673, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmApuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 356);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmApuracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apuração de notas";
            this.Load += new System.EventHandler(this.frmApuracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlunoMediaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota03DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota04DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewAlunoMediaBindingSource;
        private System.Windows.Forms.Button btnCancelar;
    }
}