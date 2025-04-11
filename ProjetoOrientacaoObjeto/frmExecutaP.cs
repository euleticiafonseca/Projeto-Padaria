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
    public partial class frmExecutaP : Form
    {
        public frmExecutaP()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            ps.setNome(txtNome.Text);

            lblNome.Text = ps.getNome();

            ps.setEmail(txtEmail.Text);

            lblEmail.Text = ps.getEmail();

            ps.setcpf(mskCPF.Text);

            lblCPF.Text = ps.getcpf();

            ps.setTelefone(mktTelefone.Text);

            lblTelefone.Text = ps.getTelefone();

           ps.setIdade(Convert.ToInt32(txtIdade.Text));
            lblIdade.Text = ps.getIdade().ToString();

        } 
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtEmail.Clear();

            mskCPF.Clear();
            mktTelefone.Clear();

            lblNome2.Text = "Nome";
            lblEmail2.Text = "Email";
            lblIdade2.Text = "Idade";
            lblTelefone2.Text = "Telefone";

            txtNome.Focus();
        }
        
        private void txtIdade_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
