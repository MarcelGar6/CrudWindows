using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBasico
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (Codigo > 0)
            {
                btnGravar.Text = "Atualizar";
                txtNome.Text = Nome;
                txtEndereco.Text = Endereco;
                mtbTelefone.Text = Telefone;

                if (Sexo.Equals("M"))
                    rbtMasculino.Checked = true;
                else
                    rbtFeminino.Checked = true;
                if (Ativo)
                    rbtAtivo.Checked = true;
                else
                    rbtInativo.Checked = true;
            }
            else
                btnGravar.Text = "Gravar";
        }
        #region Variáveis Públicas
        public int Codigo = 0;
        public string Nome;
        public string Endereco;
        public string Telefone;
        public string Sexo;
        public bool Ativo;
        public DateTime DataCadastro;
        #endregion
        #region Métodos
        private void Atualizar(int idCliente,string Nome, string Endereco, string Telefone, string Sexo, bool Ativo)
        {
            try
            {
                Dados objDados = new Dados();
                objDados.Atualizar(idCliente, Nome, Endereco, Telefone, Sexo, Ativo, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
        private void Gravar(string Nome, string Endereco, string Telefone, string Sexo, bool Ativo)
        {
            try
            {
                Dados objDados = new Dados();
                objDados.Gravar(Nome, Endereco, Telefone, Sexo, Ativo, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            

        }
        private void IrConsulta()
        {
            frmConsulta objFrmConsulta = new frmConsulta();
            objFrmConsulta.ShowDialog();
        }
        #endregion
        #region Botões        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            IrConsulta();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome.Text) &&
               !String.IsNullOrEmpty(txtEndereco.Text))
            {
                string strSexo = string.Empty;
                bool blnAtivo = false;

                if (rbtMasculino.Checked)
                    strSexo = "M";
                else
                    strSexo = "F";
                if (rbtAtivo.Checked)
                    blnAtivo = true;
                else
                    blnAtivo = false;
                if (Codigo == 0)
                    Gravar(txtNome.Text, txtEndereco.Text, mtbTelefone.Text, strSexo, blnAtivo);
                else
                    Atualizar(Codigo, txtNome.Text, txtEndereco.Text, mtbTelefone.Text, strSexo, blnAtivo);

                this.Hide();
                IrConsulta();
            }
            else
            {
                if (String.IsNullOrEmpty(txtNome.Text))
                    epErro.SetError(txtNome, "Informe o Nome");
                if (String.IsNullOrEmpty(txtEndereco.Text))
                    epErro.SetError(txtEndereco, "Informe o Endereço");
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
