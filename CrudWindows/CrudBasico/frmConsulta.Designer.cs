namespace CrudBasico
{
    partial class frmConsulta
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
            this.lstClientes = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.AllowColumnReorder = true;
            this.lstClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nome,
            this.Endereco,
            this.Telefone,
            this.Sexo,
            this.Ativo,
            this.DataCadastro});
            this.lstClientes.FullRowSelect = true;
            this.lstClientes.GridLines = true;
            this.lstClientes.LabelWrap = false;
            this.lstClientes.Location = new System.Drawing.Point(24, 21);
            this.lstClientes.MultiSelect = false;
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(539, 237);
            this.lstClientes.TabIndex = 1;
            this.lstClientes.UseCompatibleStateImageBehavior = false;
            this.lstClientes.View = System.Windows.Forms.View.Details;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 45;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereço";
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            // 
            // Ativo
            // 
            this.Ativo.Text = "Ativo";
            // 
            // DataCadastro
            // 
            this.DataCadastro.Text = "Data do cadastro";
            this.DataCadastro.Width = 25;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(258, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(443, 296);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(73, 296);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 350);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lstClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstClientes;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Ativo;
        private System.Windows.Forms.ColumnHeader DataCadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
    }
}