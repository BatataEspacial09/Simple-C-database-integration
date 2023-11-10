namespace POO_WF_TrabalhoFinal
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TB_Aluno_CPF = new TextBox();
            TB_Aluno_Matricula = new TextBox();
            TB_Aluno_Nome = new TextBox();
            BT_Aluno_Gravar = new Button();
            BT_Aluno_Atualizar = new Button();
            BT_Aluno_Deletar = new Button();
            BT_Aluno_Exibir = new Button();
            TC = new TabControl();
            Aluno = new TabPage();
            dGV_Aluno = new DataGridView();
            Livro = new TabPage();
            dGV_Livro = new DataGridView();
            BT_Livro_Deletar = new Button();
            BT_Livro_Exibir = new Button();
            BT_Livro_Gravar = new Button();
            BT_Livro_Atualizar = new Button();
            TB_Livro_Ano = new TextBox();
            TB_Livro_Autor = new TextBox();
            TB_Livro_Nome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Emprestimo = new TabPage();
            dGV_Emprestimo = new DataGridView();
            BT_Emprestimo_Relatorio = new Button();
            BT_Emprestimo_Deletar = new Button();
            BT_Emprestimo_Atualizar = new Button();
            BT_Emprestimo_Gravar = new Button();
            label8 = new Label();
            lb1 = new Label();
            TB_Emprestimo_AlunoCPF = new TextBox();
            TB_Emprestimo_LivroID = new TextBox();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            TC.SuspendLayout();
            Aluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Aluno).BeginInit();
            Livro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Livro).BeginInit();
            Emprestimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Emprestimo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 68);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Matricula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // TB_Aluno_CPF
            // 
            TB_Aluno_CPF.Location = new Point(272, 107);
            TB_Aluno_CPF.Name = "TB_Aluno_CPF";
            TB_Aluno_CPF.Size = new Size(274, 27);
            TB_Aluno_CPF.TabIndex = 3;
            // 
            // TB_Aluno_Matricula
            // 
            TB_Aluno_Matricula.Location = new Point(272, 65);
            TB_Aluno_Matricula.Name = "TB_Aluno_Matricula";
            TB_Aluno_Matricula.Size = new Size(274, 27);
            TB_Aluno_Matricula.TabIndex = 4;
            // 
            // TB_Aluno_Nome
            // 
            TB_Aluno_Nome.Location = new Point(272, 22);
            TB_Aluno_Nome.Name = "TB_Aluno_Nome";
            TB_Aluno_Nome.Size = new Size(274, 27);
            TB_Aluno_Nome.TabIndex = 5;
            // 
            // BT_Aluno_Gravar
            // 
            BT_Aluno_Gravar.Location = new Point(160, 160);
            BT_Aluno_Gravar.Name = "BT_Aluno_Gravar";
            BT_Aluno_Gravar.Size = new Size(94, 29);
            BT_Aluno_Gravar.TabIndex = 6;
            BT_Aluno_Gravar.Text = "GRAVAR";
            BT_Aluno_Gravar.UseVisualStyleBackColor = true;
            BT_Aluno_Gravar.MouseClick += BT_Aluno_Gravar_MouseClick;
            // 
            // BT_Aluno_Atualizar
            // 
            BT_Aluno_Atualizar.Location = new Point(290, 160);
            BT_Aluno_Atualizar.Name = "BT_Aluno_Atualizar";
            BT_Aluno_Atualizar.Size = new Size(94, 29);
            BT_Aluno_Atualizar.TabIndex = 7;
            BT_Aluno_Atualizar.Text = "ATUALIZAR";
            BT_Aluno_Atualizar.UseVisualStyleBackColor = true;
            BT_Aluno_Atualizar.MouseClick += BT_Aluno_Atualizar_MouseClick;
            // 
            // BT_Aluno_Deletar
            // 
            BT_Aluno_Deletar.Location = new Point(418, 160);
            BT_Aluno_Deletar.Name = "BT_Aluno_Deletar";
            BT_Aluno_Deletar.Size = new Size(94, 29);
            BT_Aluno_Deletar.TabIndex = 8;
            BT_Aluno_Deletar.Text = "DELETAR";
            BT_Aluno_Deletar.UseVisualStyleBackColor = true;
            BT_Aluno_Deletar.MouseClick += BT_Aluno_Deletar_MouseClick;
            // 
            // BT_Aluno_Exibir
            // 
            BT_Aluno_Exibir.Location = new Point(550, 160);
            BT_Aluno_Exibir.Name = "BT_Aluno_Exibir";
            BT_Aluno_Exibir.Size = new Size(94, 29);
            BT_Aluno_Exibir.TabIndex = 9;
            BT_Aluno_Exibir.Text = "EXIBIR";
            BT_Aluno_Exibir.UseVisualStyleBackColor = true;
            BT_Aluno_Exibir.MouseClick += BT_Aluno_Exibir_MouseClick;
            // 
            // TC
            // 
            TC.Controls.Add(Aluno);
            TC.Controls.Add(Livro);
            TC.Controls.Add(Emprestimo);
            TC.Location = new Point(0, 0);
            TC.Name = "TC";
            TC.SelectedIndex = 0;
            TC.Size = new Size(795, 449);
            TC.TabIndex = 10;
            // 
            // Aluno
            // 
            Aluno.Controls.Add(dGV_Aluno);
            Aluno.Controls.Add(TB_Aluno_Matricula);
            Aluno.Controls.Add(BT_Aluno_Exibir);
            Aluno.Controls.Add(label1);
            Aluno.Controls.Add(BT_Aluno_Deletar);
            Aluno.Controls.Add(label2);
            Aluno.Controls.Add(BT_Aluno_Atualizar);
            Aluno.Controls.Add(label3);
            Aluno.Controls.Add(BT_Aluno_Gravar);
            Aluno.Controls.Add(TB_Aluno_CPF);
            Aluno.Controls.Add(TB_Aluno_Nome);
            Aluno.Location = new Point(4, 29);
            Aluno.Name = "Aluno";
            Aluno.Padding = new Padding(3);
            Aluno.Size = new Size(787, 416);
            Aluno.TabIndex = 0;
            Aluno.Text = "Aluno";
            Aluno.UseVisualStyleBackColor = true;
            Aluno.Click += tabPage1_Click;
            // 
            // dGV_Aluno
            // 
            dGV_Aluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Aluno.Location = new Point(160, 209);
            dGV_Aluno.Name = "dGV_Aluno";
            dGV_Aluno.RowHeadersWidth = 51;
            dGV_Aluno.RowTemplate.Height = 29;
            dGV_Aluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV_Aluno.Size = new Size(484, 204);
            dGV_Aluno.TabIndex = 10;
            // 
            // Livro
            // 
            Livro.Controls.Add(dGV_Livro);
            Livro.Controls.Add(BT_Livro_Deletar);
            Livro.Controls.Add(BT_Livro_Exibir);
            Livro.Controls.Add(BT_Livro_Gravar);
            Livro.Controls.Add(BT_Livro_Atualizar);
            Livro.Controls.Add(TB_Livro_Ano);
            Livro.Controls.Add(TB_Livro_Autor);
            Livro.Controls.Add(TB_Livro_Nome);
            Livro.Controls.Add(label6);
            Livro.Controls.Add(label5);
            Livro.Controls.Add(label4);
            Livro.Location = new Point(4, 29);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3);
            Livro.Size = new Size(787, 416);
            Livro.TabIndex = 1;
            Livro.Text = "Livro";
            Livro.UseVisualStyleBackColor = true;
            // 
            // dGV_Livro
            // 
            dGV_Livro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Livro.Location = new Point(160, 204);
            dGV_Livro.Name = "dGV_Livro";
            dGV_Livro.RowHeadersWidth = 51;
            dGV_Livro.RowTemplate.Height = 29;
            dGV_Livro.Size = new Size(458, 209);
            dGV_Livro.TabIndex = 10;
            // 
            // BT_Livro_Deletar
            // 
            BT_Livro_Deletar.Location = new Point(399, 153);
            BT_Livro_Deletar.Name = "BT_Livro_Deletar";
            BT_Livro_Deletar.Size = new Size(94, 29);
            BT_Livro_Deletar.TabIndex = 9;
            BT_Livro_Deletar.Text = "Deletar";
            BT_Livro_Deletar.UseVisualStyleBackColor = true;
            BT_Livro_Deletar.MouseClick += BT_Livro_Deletar_MouseClick;
            // 
            // BT_Livro_Exibir
            // 
            BT_Livro_Exibir.Location = new Point(524, 153);
            BT_Livro_Exibir.Name = "BT_Livro_Exibir";
            BT_Livro_Exibir.Size = new Size(94, 29);
            BT_Livro_Exibir.TabIndex = 8;
            BT_Livro_Exibir.Text = "Exibir";
            BT_Livro_Exibir.UseVisualStyleBackColor = true;
            BT_Livro_Exibir.MouseClick += BT_Livro_Exibir_MouseClick;
            // 
            // BT_Livro_Gravar
            // 
            BT_Livro_Gravar.Location = new Point(160, 153);
            BT_Livro_Gravar.Name = "BT_Livro_Gravar";
            BT_Livro_Gravar.Size = new Size(94, 29);
            BT_Livro_Gravar.TabIndex = 7;
            BT_Livro_Gravar.Text = "Gravar";
            BT_Livro_Gravar.UseVisualStyleBackColor = true;
            BT_Livro_Gravar.MouseClick += BT_Livro_Gravar_MouseClick;
            // 
            // BT_Livro_Atualizar
            // 
            BT_Livro_Atualizar.Location = new Point(280, 153);
            BT_Livro_Atualizar.Name = "BT_Livro_Atualizar";
            BT_Livro_Atualizar.Size = new Size(94, 29);
            BT_Livro_Atualizar.TabIndex = 6;
            BT_Livro_Atualizar.Text = "Atualizar";
            BT_Livro_Atualizar.UseVisualStyleBackColor = true;
            BT_Livro_Atualizar.MouseClick += BT_Livro_Atualizar_MouseClick;
            // 
            // TB_Livro_Ano
            // 
            TB_Livro_Ano.Location = new Point(280, 95);
            TB_Livro_Ano.Name = "TB_Livro_Ano";
            TB_Livro_Ano.Size = new Size(243, 27);
            TB_Livro_Ano.TabIndex = 5;
            // 
            // TB_Livro_Autor
            // 
            TB_Livro_Autor.Location = new Point(280, 60);
            TB_Livro_Autor.Name = "TB_Livro_Autor";
            TB_Livro_Autor.Size = new Size(243, 27);
            TB_Livro_Autor.TabIndex = 4;
            // 
            // TB_Livro_Nome
            // 
            TB_Livro_Nome.Location = new Point(280, 20);
            TB_Livro_Nome.Name = "TB_Livro_Nome";
            TB_Livro_Nome.Size = new Size(243, 27);
            TB_Livro_Nome.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 63);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 2;
            label6.Text = "Autor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 98);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 1;
            label5.Text = "Ano:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 23);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 0;
            label4.Text = "Nome:";
            // 
            // Emprestimo
            // 
            Emprestimo.Controls.Add(dGV_Emprestimo);
            Emprestimo.Controls.Add(BT_Emprestimo_Relatorio);
            Emprestimo.Controls.Add(BT_Emprestimo_Deletar);
            Emprestimo.Controls.Add(BT_Emprestimo_Atualizar);
            Emprestimo.Controls.Add(BT_Emprestimo_Gravar);
            Emprestimo.Controls.Add(label8);
            Emprestimo.Controls.Add(lb1);
            Emprestimo.Controls.Add(TB_Emprestimo_AlunoCPF);
            Emprestimo.Controls.Add(TB_Emprestimo_LivroID);
            Emprestimo.Location = new Point(4, 29);
            Emprestimo.Name = "Emprestimo";
            Emprestimo.Padding = new Padding(3);
            Emprestimo.Size = new Size(787, 416);
            Emprestimo.TabIndex = 2;
            Emprestimo.Text = "Emprestimo";
            Emprestimo.UseVisualStyleBackColor = true;
            // 
            // dGV_Emprestimo
            // 
            dGV_Emprestimo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Emprestimo.Location = new Point(174, 181);
            dGV_Emprestimo.Name = "dGV_Emprestimo";
            dGV_Emprestimo.RowHeadersWidth = 51;
            dGV_Emprestimo.RowTemplate.Height = 29;
            dGV_Emprestimo.Size = new Size(448, 218);
            dGV_Emprestimo.TabIndex = 8;
            // 
            // BT_Emprestimo_Relatorio
            // 
            BT_Emprestimo_Relatorio.Location = new Point(528, 123);
            BT_Emprestimo_Relatorio.Name = "BT_Emprestimo_Relatorio";
            BT_Emprestimo_Relatorio.Size = new Size(94, 29);
            BT_Emprestimo_Relatorio.TabIndex = 7;
            BT_Emprestimo_Relatorio.Text = "Relatorio";
            BT_Emprestimo_Relatorio.UseVisualStyleBackColor = true;
            BT_Emprestimo_Relatorio.MouseClick += BT_Emprestimo_Relatorio_MouseClick;
            // 
            // BT_Emprestimo_Deletar
            // 
            BT_Emprestimo_Deletar.Location = new Point(415, 123);
            BT_Emprestimo_Deletar.Name = "BT_Emprestimo_Deletar";
            BT_Emprestimo_Deletar.Size = new Size(94, 29);
            BT_Emprestimo_Deletar.TabIndex = 6;
            BT_Emprestimo_Deletar.Text = "Deletar";
            BT_Emprestimo_Deletar.UseVisualStyleBackColor = true;
            BT_Emprestimo_Deletar.MouseClick += BT_Emprestimo_Deletar_MouseClick;
            // 
            // BT_Emprestimo_Atualizar
            // 
            BT_Emprestimo_Atualizar.Location = new Point(297, 123);
            BT_Emprestimo_Atualizar.Name = "BT_Emprestimo_Atualizar";
            BT_Emprestimo_Atualizar.Size = new Size(94, 29);
            BT_Emprestimo_Atualizar.TabIndex = 5;
            BT_Emprestimo_Atualizar.Text = "Atualizar";
            BT_Emprestimo_Atualizar.UseVisualStyleBackColor = true;
            BT_Emprestimo_Atualizar.MouseClick += BT_Emprestimo_Atualizar_MouseClick;
            // 
            // BT_Emprestimo_Gravar
            // 
            BT_Emprestimo_Gravar.Location = new Point(174, 123);
            BT_Emprestimo_Gravar.Name = "BT_Emprestimo_Gravar";
            BT_Emprestimo_Gravar.Size = new Size(94, 29);
            BT_Emprestimo_Gravar.TabIndex = 4;
            BT_Emprestimo_Gravar.Text = "Gravar";
            BT_Emprestimo_Gravar.UseVisualStyleBackColor = true;
            BT_Emprestimo_Gravar.MouseClick += BT_Emprestimo_Gravar_MouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 66);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 3;
            label8.Text = "Livro ID:";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(193, 32);
            lb1.Name = "lb1";
            lb1.Size = new Size(79, 20);
            lb1.TabIndex = 2;
            lb1.Text = "Aluno CPF:";
            // 
            // TB_Emprestimo_AlunoCPF
            // 
            TB_Emprestimo_AlunoCPF.AutoCompleteSource = AutoCompleteSource.FileSystem;
            TB_Emprestimo_AlunoCPF.Location = new Point(278, 29);
            TB_Emprestimo_AlunoCPF.Name = "TB_Emprestimo_AlunoCPF";
            TB_Emprestimo_AlunoCPF.Size = new Size(259, 27);
            TB_Emprestimo_AlunoCPF.TabIndex = 1;
            // 
            // TB_Emprestimo_LivroID
            // 
            TB_Emprestimo_LivroID.Location = new Point(278, 62);
            TB_Emprestimo_LivroID.Name = "TB_Emprestimo_LivroID";
            TB_Emprestimo_LivroID.Size = new Size(259, 27);
            TB_Emprestimo_LivroID.TabIndex = 0;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TC);
            Name = "Form1";
            Text = "Emprestimo de Livros";
            Load += Form1_Load;
            TC.ResumeLayout(false);
            Aluno.ResumeLayout(false);
            Aluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Aluno).EndInit();
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Livro).EndInit();
            Emprestimo.ResumeLayout(false);
            Emprestimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Emprestimo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TB_Aluno_CPF;
        private TextBox TB_Aluno_Matricula;
        private TextBox TB_Aluno_Nome;
        private Button BT_Aluno_Gravar;
        private Button BT_Aluno_Atualizar;
        private Button BT_Aluno_Deletar;
        private Button BT_Aluno_Exibir;
        private TabControl TC;
        private TabPage Aluno;
        private TabPage Livro;
        private TextBox TB_Livro_Ano;
        private TextBox TB_Livro_Autor;
        private TextBox TB_Livro_Nome;
        private Label label6;
        private Label label5;
        private Label label4;
        private TabPage Emprestimo;
        private Button BT_Livro_Deletar;
        private Button BT_Livro_Exibir;
        private Button BT_Livro_Gravar;
        private Button BT_Livro_Atualizar;
        private Button BT_Emprestimo_Relatorio;
        private Button BT_Emprestimo_Deletar;
        private Button BT_Emprestimo_Atualizar;
        private Button BT_Emprestimo_Gravar;
        private Label label8;
        private Label lb1;
        private TextBox TB_Emprestimo_AlunoCPF;
        private TextBox TB_Emprestimo_LivroID;
        private DataGridView dGV_Aluno;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dGV_Livro;
        private DataGridView dGV_Emprestimo;
    }
}