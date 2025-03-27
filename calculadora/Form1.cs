using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCaucular_Click(object sender, EventArgs e)
        {
            //declarando as vareaveis
            double num1, num2, resp = 0;

           

                try
                {
                    //inisializando as variaveis 
                    num1 = Convert.ToDouble(txtnumero1.Text);
                    num2 = Convert.ToDouble(txtnumero2.Text);

                if (rbnSomar.Checked == false && rbnSubitrair.Checked == false &&
               rbnMutiplicar.Checked == false && rbnDividir.Checked == false)
                {
                    MessageBox.Show("selscione um operação",
                                "mensagem do sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                }
                else
                {

                    //criando a estrutura de decisão
                    if (rbnSomar.Checked)
                    {
                        //somando so valores
                        resp = num1 + num2;

                    }
                    //subitraindo valores
                    if (rbnSubitrair.Checked)
                    {
                        resp = num2 - num1;
                    }
                    if (rbnMutiplicar.Checked)
                    {
                        resp = num1 * num2;
                    }
                    // dividindo valores
                    if (rbnDividir.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("impossivel dividir por 0",
                                "mensagem do sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            resp = num1 / num2;

                        }
                        txtresposta.Text = resp.ToString();
                    }
                }
                }

                catch (Exception)
                {
                    MessageBox.Show("por favor insira valores validos",
                               "mensagem do sistema",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error,
                               MessageBoxDefaultButton.Button1);
                }
            }
        }

    }




