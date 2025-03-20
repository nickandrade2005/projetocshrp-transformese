using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Runtime.InteropServices;


namespace lojaabc
{
    public partial class Fmrlogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public Fmrlogin()
        {
            InitializeComponent();
        }

        private void Fmrlogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //declarando as variaveis do tipo string

            string usuario, senha;

            usuario = textUsuario.Text;
            senha = txtsenha.Text;

            if (usuario.Equals("senac") && senha.Equals("senac124"))
            {
                FrmMenuprincipal abrir = new FrmMenuprincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario ou senha invalidos", "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error,

                MessageBoxDefaultButton.Button1);
                limparCampos();

            }
        }

        private void pctlogo_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        //limpando campos
        public void limparCampos()
        {
            textUsuario.Clear();
            txtsenha.Clear();
            textUsuario.Focus();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void textUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus(); ;
            }
        }

        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus(); ;
                

            }
        }
    }
}