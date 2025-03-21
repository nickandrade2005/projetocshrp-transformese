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
using System.Security.Cryptography.X509Certificates;


namespace lojaabc
{
    public partial class frmfuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmfuncionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Criando variáveis para controle do menu

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmfuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }


        //desabilitar os componentes
        public void desabilitarcampos()
        {
            txtnome.Enabled = true;
            txtemail.Enabled = true;
            txtCPF.Enabled = true;
            dtpdatadenacimento.Enabled = true;
            mskcelular.Enabled = true;
            gpbsexo.Enabled = true;

            txtlogradouro.Enabled = false;
            txtnumero.Enabled = false;
            mskCEP.Enabled = true;
            txtnumero.Enabled = true;
            txtcomplemento.Enabled = true;

            btncadastrar.Enabled = true;
            btnaltera.Enabled = false;
            btnexcluir.Enabled = false;
            btnlimpar.Enabled = true;

            btnnovo.Enabled = false;

            txtnome.Focus();
        }

        public void limparCampos()
        {
            txtnome.Clear();
            txtemail.Clear();
            txtCPF.Clear();
            dtpdatadenacimento.Text = "";
            mskcelular.Clear();
            rdbfeminino.Checked = false;
            rdbmasculino.Checked = false;
            rdbnaoqueroinformar.Checked = false;

            txtlogradouro.Clear();
            txtnumero.Clear();
            mskCEP.Clear();
            txtcidade.Clear();
            txtestado.Clear();
            cbbuf.Text = "";
            txtcomplemento.Clear();

            txtnome.Focus();
        }
        private void btnnovo_Click(object sender, EventArgs e)
        {
            //executando habilitar campos

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            





         }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            frmfuncionarios abrir = new frmfuncionarios();
            abrir.ShowDialog();

    }
    }
}
