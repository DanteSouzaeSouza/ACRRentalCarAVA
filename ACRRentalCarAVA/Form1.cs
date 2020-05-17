using System;
using System.Windows.Forms;

namespace ACRRentalCarAVA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário
            Form frm = new FrmCadastroCliente();
            // Define quem é o pai dessa janela
            frm.MdiParent = this;
            // Exibe o formulário
            frm.Show();
        }
    }
}