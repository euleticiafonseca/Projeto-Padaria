using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmProdutos : Form
    {

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos ps = new Produtos();

            ps.setDescricao(txtDescricao.Text);

            lblDescricao.Text = ps.getDescricao();

            ps.setCodigo(Convert.ToInt32(txtCodigo.Text));
            lblCodigo.Text = ps.getCodigo().ToString();

            ps.setValor(Convert.ToInt32(txtValor.Text));
            lblValor.Text = ps.getValor().ToString();

            ps.setQuantidade(Convert.ToInt32(txtQuantidade.Text));
            lblQuantidade.Text = ps.getQuantidade().ToString();

            ps.setTotal(txtTotal.Text);

            lblTotal.Text = ps.getTotal().ToString();

            ps.setDataentrada(dtpDataEntrada.Text);

            lblDataEntrada.Text = ps.getDataEntrada();

            ps.setDataSaida(dtpDataSaida.Text);

            lblDataSaida.Text = ps.getDataSaida();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtCodigo.Clear();
            txtValor.Clear();
            txtQuantidade.Clear();
            txtTotal.Clear();


            lblMostrarDescricao.Text = "Descricao";
            lblMostrarCodigo.Text = "Codigo";
            lblMostrarValor.Text = "Valor";
            lblMostrarQuantidade.Text = "Quantidade";
            lblMostrarTotal.Text = "Total";

            txtDescricao.Focus();
        }
    }
}
