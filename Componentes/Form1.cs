using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Livros");
                pctimgens.Load(@".\imagens\Livro.png");
            }
        }

        private void btncarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "selecionar imagem";
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pctimgens.ImageLocation = ofd.FileName;
                pctimgens.Load();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctimgens.Image = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            pctimgens.Image = null;
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("banana");
                pctimgens.Load(@".\imagens\banana.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove(0);

            }
        }


        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("computador");
                pctimgens.Load(@".\imagens\computador.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove(0);

            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("mesa" + "");
                pctimgens.Load(@".\imagens\mesa.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove(0);
            }
        }
    }
}


