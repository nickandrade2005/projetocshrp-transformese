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

namespace lojaabc
{
    public partial class ltbpesquisar : Form
    {
        public ltbpesquisar()
        {
            InitializeComponent();
        }
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ltbpesquisar_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }
        public void limparcampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;

            txtDiscrição.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
        }
    }
    }
