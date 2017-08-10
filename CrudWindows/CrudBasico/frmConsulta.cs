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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        #region Métodos 
        private void CarregarListView()
        {
            Dados objDados = new Dados();
            List<CrudBasico.Dados.Clientes> listaClientes = new List<Dados.Clientes>();
            listaClientes = objDados.Consultar();            

            foreach (var itemLista in listaClientes)
            {
                ListViewItem objListViewItem = new ListViewItem();
                objListViewItem.Text = itemLista.IdCliente.ToString();
                objListViewItem.SubItems.Add(itemLista.Nome);
                objListViewItem.SubItems.Add(itemLista.Endereco);
                objListViewItem.SubItems.Add(itemLista.Telefone);
                objListViewItem.SubItems.Add(itemLista.Sexo);

                if (itemLista.Ativo)
                    objListViewItem.SubItems.Add("Sim");
                else
                    objListViewItem.SubItems.Add("Não");

                objListViewItem.SubItems.Add(itemLista.DataCadastro.ToShortDateString());
                lstClientes.Items.Add(objListViewItem);

            }
        }

        private void EditarRegistro()
        {
            int Codigo;
            string Nome;
            string Endereco;
            string Telefone;
            string Sexo;
            bool Ativo;
            DateTime DataCadastro;

            try
            {
                if(lstClientes.SelectedItems.Count > 0)
                {
                    Codigo = Convert.ToInt32(lstClientes.SelectedItems[0].Text);
                    Nome = lstClientes.SelectedItems[0].SubItems[1].Text;
                    Endereco = lstClientes.SelectedItems[0].SubItems[2].Text;
                    Telefone = lstClientes.SelectedItems[0].SubItems[3].Text;
                    Sexo = lstClientes.SelectedItems[0].SubItems[4].Text;

                    if (lstClientes.SelectedItems[0].SubItems[5].Text.Equals("Sim"))
                        Ativo = true;
                    else
                        Ativo = false;

                    DataCadastro = Convert.ToDateTime(lstClientes.SelectedItems[0].SubItems[6].Text);

                    frmCadastro objFrmCadasro = new frmCadastro();
                    objFrmCadasro.Codigo = Codigo;
                    objFrmCadasro.Nome = Nome;
                    objFrmCadasro.Endereco = Endereco;
                    objFrmCadasro.Telefone = Telefone;
                    objFrmCadasro.Sexo = Sexo;
                    objFrmCadasro.Ativo = Ativo;
                    objFrmCadasro.DataCadastro = DataCadastro;
                    objFrmCadasro.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }
        private void ExcluirRegistro()
        {
            int Codigo = 0;
            try
            {
                if (lstClientes.SelectedItems.Count > 0)
                    Codigo = Convert.ToInt32(lstClientes.SelectedItems[0].Text);
                Dados objDados = new Dados();
                if (Codigo > 0)
                    objDados.Excluir(Codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }

        }
        private void IrCadastro()
        {
            frmCadastro objFrmCadastro = new frmCadastro();
            objFrmCadastro.ShowDialog();
        }
        #endregion
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region botões
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
            this.lstClientes.Items.Clear();
            CarregarListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            IrCadastro();
        }
    }
}
