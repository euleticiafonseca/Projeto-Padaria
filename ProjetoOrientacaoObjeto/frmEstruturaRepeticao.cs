using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmEstruturaRepeticao : Form
    {
        public frmEstruturaRepeticao()
        {
            InitializeComponent();
            carregaCombo();
            txtInserirEstado.Focus();
      
        }

      
        //criando método carrega combo
         public void carregaCombo()
        {
            cbbEstado.Items.Clear();
            cbbEstado.Items.Add("Capão Redondo");
            cbbEstado.Items.Add("Campo Limpo");
            cbbEstado.Items.Add("São Luiz");
            cbbEstado.Items.Add("Campo Grande");
            cbbEstado.Items.Add("Jardim Nakamura");
            cbbEstado.Items.Add("Jardim Ângela");
            cbbEstado.Items.Add("Jardim Jacira");
            cbbEstado.Items.Add("Capelinha");
            cbbEstado.Items.Add("Piraporinha");
            cbbEstado.Items.Add("Vila Remo");

        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            carregaCombo();
        }

        private void btnCarregaListaEstados_Click(object sender, EventArgs e)
        {
            carregaListaEstado();
        }
        public void carregaListaEstado()
        {
            ltbListaEstados.Items.Clear();
            ltbListaEstados.Items.Add("santo Amaro");
            ltbListaEstados.Items.Add("Ibirapuera");
            ltbListaEstados.Items.Add("Moema");
            ltbListaEstados.Items.Add("Borba Gato");
            ltbListaEstados.Items.Add("Granja Julieta");
            ltbListaEstados.Items.Add("Morumbi");
            ltbListaEstados.Items.Add("lto da Boa Vista");
            ltbListaEstados.Items.Add("Vila Olimpia");
            ltbListaEstados.Items.Add("Broklin");
            ltbListaEstados.Items.Add("Cidade Jardim");
        }

        private void btnInserirEstado_Click(object sender, EventArgs e)
        {
            if (txtInserirEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um estado");
            }
            else
            {
               inserirEstado();
            }
        }
        public void inserirEstado()
        {
            ltbListaEstados.Items.Add(txtInserirEstado.Text);
            txtInserirEstado.Clear();
            txtInserirEstado.Focus();
        }

        private void btnLimparEstado_Click(object sender, EventArgs e)
        {
            //limpar campos
            txtInserirEstado.Text = "";
            ltbListaEstados.Items.Clear();
        }

        private void btnLimpaItemSelecionado_Click(object sender, EventArgs e)
        {
            //limpar o item selecionado
            ltbListaEstados.Items.RemoveAt(ltbListaEstados.SelectedIndex);
        }
    }
}
