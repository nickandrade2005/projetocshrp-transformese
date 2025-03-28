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

namespace fmrFolha_de_pagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salariodafolha, impostoderenda, salarioLiquido;

            salariodafolha = Convert.ToDouble(txtsalariodafolha.Text);
            impostoderenda = Convert.ToDouble(txtimpostoderenda.Text);

            salarioLiquido = salariodafolha - impostoderenda;
            if (salariodafolha < 2259.20)
            {
                salarioLiquido = 0;
            }
            else if (salariodafolha >= 2259.21 && salariodafolha <= 2826.65)
            {
                salarioLiquido = (salariodafolha - (salariodafolha * 7.5 / 100));
            }
            double salarioFolha, impostorenda;

            try
            {
                salariodafolha = Convert.ToDouble(txtsalariodafolha.Text);

            if (salariodafolha < 2259.20)
            {
                salarioLiquido = 0;
                    txtSalarioliquido.Text = txtsalariodafolha.Text;
            }
            else if (salariodafolha >= 2259.21 && salariodafolha <= 2826.65)
            {
                salarioLiquido = (salariodafolha - (salariodafolha * 7.5 / 100));
                    salarioLiquido = salariodafolha - impostoderenda;
            }
            else if (salariodafolha >= 2826.66 && salariodafolha <= 3751.05)
            {
                salariodafolha = (salariodafolha - (salariodafolha * 15 / 100));
                    salarioLiquido = salarioFolha - impostoderenda;
            }
            else if (salariodafolha >= 3751.06 && salariodafolha <= 4664.68)
            {
                salarioLiquido = salariodafolha - (salariodafolha * 22.5 / 100);

            }
            else if (salariodafolha >= 4664.69)
            {
                salarioLiquido = salariodafolha - (salariodafolha * 27.5 / 100);

            }

            txtSalarioliquido.Text = salarioLiquido.ToString();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtimpostoderenda.Clear();
            txtSalario.Clear();
            txtSalarioliquido.Clear();
            txtsalariodafolha.Clear();


        }

        private void ckbclubedelazer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbclubedelazer.Checked)
            {

            }
            else
            {

            }
        }
    }
}