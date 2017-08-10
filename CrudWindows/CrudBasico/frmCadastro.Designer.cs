namespace CrudBasico
{
    partial class frmCadastro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            this.gpbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(95, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(304, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEndereco.Location = new System.Drawing.Point(95, 53);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(304, 23);
            this.txtEndereco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone: ";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mtbTelefone.Location = new System.Drawing.Point(95, 88);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(112, 23);
            this.mtbTelefone.TabIndex = 5;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtFeminino);
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(15, 130);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(384, 52);
            this.gpbSexo.TabIndex = 6;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(231, 19);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 1;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(87, 19);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(236, 19);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(57, 17);
            this.rbtInativo.TabIndex = 1;
            this.rbtInativo.TabStop = true;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Location = new System.Drawing.Point(92, 19);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbtAtivo.TabIndex = 0;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.rbtInativo);
            this.gpbStatus.Controls.Add(this.rbtAtivo);
            this.gpbStatus.Location = new System.Drawing.Point(15, 201);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(384, 52);
            this.gpbStatus.TabIndex = 7;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Text = "Status";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(82, 287);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // epErro
            // 
            this.epErro.ContainerControl = this;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(262, 287);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 336);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gpbStatus);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ErrorProvider epErro;
        private System.Windows.Forms.Button btnConsultar;
    }
}