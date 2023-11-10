using Npgsql;
using System.Data;
using System.Windows.Forms;
using System;

namespace POO_WF_TrabalhoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BT_Aluno_Gravar_MouseClick(object sender, MouseEventArgs e)
        {
            Aluno Novoaluno = new Aluno(TB_Aluno_Nome.Text, TB_Aluno_Matricula.Text, TB_Aluno_CPF.Text);

            ConexaoString stringconexao = new ConexaoString();

            string conexao = stringconexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("INSERT INTO alunos(aluno_cpf, aluno_nome, aluno_matricula)" +
                                                "values('{0}', '{1}', '{2}' )", Novoaluno.Cpf, Novoaluno.Nome, Novoaluno.Matricula);

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro feito com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Aluno_Nome.Clear();
            TB_Aluno_Matricula.Clear();
            TB_Aluno_CPF.Clear();
        }

        private void BT_Aluno_Atualizar_MouseClick(object sender, MouseEventArgs e)
        {
            string cpf = TB_Aluno_CPF.Text;

            Aluno AlterarAluno = new Aluno(TB_Aluno_Nome.Text, TB_Aluno_Matricula.Text, TB_Aluno_CPF.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = string.Format("UPDATE alunos SET aluno_cpf = '" + AlterarAluno.Cpf + "', aluno_nome = '" + AlterarAluno.Nome + "', aluno_matricula = '" + AlterarAluno.Matricula + "'"
                                                + "Where aluno_cpf = '" + cpf + "'");

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Atualizacao feita com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Aluno_Nome.Clear();
            TB_Aluno_Matricula.Clear();
            TB_Aluno_CPF.Clear();
        }

        private void BT_Aluno_Deletar_MouseClick(object sender, MouseEventArgs e)
        {
            string cpf = TB_Aluno_CPF.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = string.Format("DELETE FROM alunos WHERE aluno_cpf = '{0}'", cpf);

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Atualizacao feita com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Aluno_Nome.Clear();
            TB_Aluno_Matricula.Clear();
            TB_Aluno_CPF.Clear();
        }

        private void BT_Aluno_Exibir_MouseClick(object sender, MouseEventArgs e)
        {
            ConexaoString stringconexao = new ConexaoString();

            string conexao = stringconexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable();

            string commandtext = "SELECT * FROM alunos";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandtext, con))
            {
                Adpt.Fill(dt);
            }

            dGV_Aluno.DataSource = dt;

            con.Close();
        }

        private void BT_Livro_Gravar_MouseClick(object sender, MouseEventArgs e)
        {
            Livro Novolivro = new Livro(TB_Livro_Nome.Text, TB_Livro_Autor.Text, TB_Livro_Ano.Text);

            ConexaoString stringconexao = new ConexaoString();

            string conexao = stringconexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("INSERT INTO livros(livro_nome, livro_autor, livro_ano)" +
                                                "values('{0}', '{1}', '{2}' )", Novolivro.Nome, Novolivro.Autor, Novolivro.Ano);

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro feito com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Livro_Nome.Clear();
            TB_Livro_Autor.Clear();
            TB_Livro_Ano.Clear();

        }

        private void BT_Livro_Atualizar_MouseClick(object sender, MouseEventArgs e)
        {
            string nome = TB_Livro_Nome.Text;

            Livro AlterarLivro = new Livro(TB_Livro_Nome.Text, TB_Livro_Autor.Text, TB_Livro_Ano.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = string.Format("UPDATE livros SET livro_nome = '" + AlterarLivro.Nome + "', livro_autor = '" + AlterarLivro.Autor + "', livro_ano = '" + AlterarLivro.Ano + "'"
                                                + "Where livro_nome = '" + nome + "'");

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Atualizacao feita com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Livro_Nome.Clear();
            TB_Livro_Autor.Clear();
            TB_Livro_Ano.Clear();
        }

        private void BT_Livro_Deletar_MouseClick(object sender, MouseEventArgs e)
        {
            string nome = TB_Livro_Nome.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = string.Format("DELETE FROM livros WHERE livro_nome = '{0}'", nome);

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Atualizacao feita com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Livro_Nome.Clear();
            TB_Livro_Autor.Clear();
            TB_Livro_Ano.Clear();
        }

        private void BT_Livro_Exibir_MouseClick(object sender, MouseEventArgs e)
        {
            ConexaoString stringconexao = new ConexaoString();

            string conexao = stringconexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable();

            string commandtext = "SELECT * FROM livros";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandtext, con))
            {
                Adpt.Fill(dt);
            }

            dGV_Livro.DataSource = dt;

            con.Close();
        }

        private void BT_Emprestimo_Gravar_MouseClick(object sender, MouseEventArgs e)
        {

            ConexaoString stringconexao = new ConexaoString();

            string conexao = stringconexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("INSERT INTO emprestimos(emprestimo_alunocpf, emprestimo_livroid)" +
                                                "values('{0}', '{1}' )", TB_Emprestimo_AlunoCPF.Text, TB_Emprestimo_LivroID.Text);

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro feito com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Emprestimo_AlunoCPF.Clear();
            TB_Emprestimo_LivroID.Clear();
        }

        private void BT_Emprestimo_Atualizar_MouseClick(object sender, MouseEventArgs e)
        {
            string cpf = TB_Emprestimo_AlunoCPF.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = string.Format("UPDATE emprestimos SET emprestimo_alunocpf = '" + TB_Emprestimo_AlunoCPF.Text + "', emprestimo_livroID = '" + TB_Emprestimo_LivroID.Text + "'"
                                                + "Where emprestimo_alunocpf = '" + cpf + "'");

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Atualizacao feita com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Emprestimo_AlunoCPF.Clear();
            TB_Emprestimo_LivroID.Clear();
        }

        private void BT_Emprestimo_Deletar_MouseClick(object sender, MouseEventArgs e)
        {
            string cpf = TB_Emprestimo_AlunoCPF.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = string.Format("DELETE FROM emprestimos WHERE emprestimo_alunocpf = '{0}'", cpf);

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                command.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Atualizacao feita com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            TB_Emprestimo_AlunoCPF.Clear();
            TB_Emprestimo_LivroID.Clear();
        }

        private void BT_Emprestimo_Relatorio_MouseClick(object sender, MouseEventArgs e)
        {
            ConexaoString stringconexao = new ConexaoString();

            string conexao = stringconexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            DataTable dt = new DataTable();

            string commandtext = "SELECT * FROM emprestimos";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandtext, con))
            {
                Adpt.Fill(dt);
            }

            dGV_Emprestimo.DataSource = dt;

            con.Close();
        }
    }
}