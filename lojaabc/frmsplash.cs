using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaabc
{
    public partial class tmr : Form
    {
        public tmr()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmrsplash_Load(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 10;
                lblNumero.Text = pgbSplash.Value.ToString() + " %";
            }

        }

        private void pgbSplash_Click(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 10;
                lblNumero.Text = pgbSplash.Value.ToString() + " %";
            }
            else
            {
                Fmrlogin login = new Fmrlogin();
                login.Show();
                this.Hide();
                TmrSplash.Enabled = false;
            }
        }
    }
}
