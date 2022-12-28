
using Microsoft.Bot.Builder.Dialogs;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace CRUD_Pessoa
{
    public partial class PessoaDataGrid : Form
    {
        PessoaRepository repository = new PessoaRepository();
        public PessoaDataGrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PessoaDataGrid_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            PessoaModel pessoa = new PessoaModel
            {
                Nome = txtNome.Text.ToString(),
                Cpf = int.Parse(txtCpf.Text.ToString()),
                Renda = decimal.Parse(txtRenda.Text.ToString()),
                Data = txtData.Text.ToString()
            };
            bool result = repository.AddPessoa(pessoa);
            if (result == true)
            {                
                MessageBox.Show("Pessoa adicionada com sucesso");
            }
            else
            {
                MessageBox.Show("Pessoa não adicionada");
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            PessoaModel pessoa = new PessoaModel
            {
                ClientId = int.Parse(txtId.Text.ToString()),
                Nome = txtNome.Text.ToString(),
                Cpf = int.Parse(txtCpf.Text.ToString()),
                Renda = decimal.Parse(txtRenda.Text.ToString()),
                Data = txtData.Text.ToString()
            };
            bool result = repository.AltPessoa(pessoa);
            if (result == true)
            {
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtRenda.Text = "";
                txtData.Text = "";
                MessageBox.Show("Pessoa alterada com sucesso");
            }
            else
            {
                MessageBox.Show("Pessoa não alterada");
            }

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            PessoaModel pessoa = new PessoaModel
            {
                ClientId = int.Parse(txtId.Text.ToString()),
                Nome = txtNome.Text.ToString(),
                Cpf = int.Parse(txtCpf.Text.ToString()),
                Renda = decimal.Parse(txtRenda.Text.ToString()),
                Data = txtData.Text.ToString()
            };
            bool result = repository.DeletePessoa(pessoa);
            if (result == true)
            {
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtRenda.Text = "";
                txtData.Text = "";
                MessageBox.Show("Pessoa deletada com sucesso");
            }
            else
            {
                MessageBox.Show("Pessoa não deletada");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PessoaModel pessoa = new PessoaModel
            {
                ClientId = int.Parse(txtId.Text.ToString()),
                Nome = "",
                Cpf = 0,
                Renda = 0,
                Data = ""
            };

            PessoaModel pessoaNova = repository.SelectPessoa(pessoa);

            if(pessoaNova != null)
            {
                txtNome.Text = pessoaNova.Nome.ToString();
                txtCpf.Text = pessoaNova.Cpf.ToString();
                txtRenda.Text = pessoaNova.Renda.ToString();
                txtData.Text = pessoaNova.Data.ToString();
                MessageBox.Show("Pessoa encontrada com sucesso");

            }
            else
            {
                txtNome.Text = "";
                txtCpf.Text = "";
                txtRenda.Text = "";
                txtData.Text = "";
                MessageBox.Show("Pessoa não encontrada");
            }

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}