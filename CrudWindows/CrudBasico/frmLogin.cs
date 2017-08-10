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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtSenha.Text))
            AcessarSistema(this.txtSenha.Text,this.txtSenha.Text);
        }

        private void AcessarSistema(string Login, string Senha)
        {
            Dados objDados = new Dados();
            List<Dados.LoginModelo> lstRetorno = objDados.ConsultarLogin(Login, Senha);

            if(lstRetorno != null && lstRetorno.Count > 0)
            {
                frmCadastro objFrmCadastro = new frmCadastro();
                objFrmCadastro.ShowDialog();
            }
        }
    }
}
