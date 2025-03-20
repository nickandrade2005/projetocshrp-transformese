using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lojaabc
{
    //Criando variáveis para controle do menu
    public partial class FrmMenuprincipal : Form
    {
        public FrmMenuprincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Fmrlogin abrir = new Fmrlogin();
            abrir.Show();
            this.Hide();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmfuncionarios abrir = new frmfuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void FrmMenuprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
