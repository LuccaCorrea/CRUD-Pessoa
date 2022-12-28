namespace CRUD_Pessoa
{
    partial class PessoaDataGrid
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.pessoaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(72, 279);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(72, 322);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 1;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(264, 322);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 2;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(417, 322);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 3;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // pessoaModelBindingSource
            // 
            this.pessoaModelBindingSource.DataSource = typeof(CRUD_Pessoa.PessoaModel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "SelectById";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(72, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(318, 23);
            this.txtId.TabIndex = 6;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 23);
            this.txtNome.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(72, 135);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(318, 23);
            this.txtCpf.TabIndex = 8;
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(72, 180);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(318, 23);
            this.txtRenda.TabIndex = 9;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(19, 51);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(17, 15);
            this.label0.TabIndex = 10;
            this.label0.Text = "Id";
            this.label0.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Renda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID SERÁ IGNORADO CASO *ADICIONAR*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data Nascimento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(123, 220);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(65, 23);
            this.txtData.TabIndex = 16;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // PessoaDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 358);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Adicionar);
            this.MaximizeBox = false;
            this.Name = "PessoaDataGrid";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PessoaDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }     
        
        


        #endregion

        private Button Adicionar;
        private Button Alterar;
        private Button Excluir;
        private Button Sair;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private BindingSource pessoaModelBindingSource;
        private Button button1;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtRenda;
        private Label label0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtData;
    }
}