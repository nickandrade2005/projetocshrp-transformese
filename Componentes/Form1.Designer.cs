namespace Componentes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblListarNome = new System.Windows.Forms.Label();
            this.lblListarProdutos = new System.Windows.Forms.Label();
            this.ltbListarProdutos = new System.Windows.Forms.ListBox();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.btncarregar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pctimgens = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctimgens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // lblListarNome
            // 
            this.lblListarNome.AutoSize = true;
            this.lblListarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarNome.Location = new System.Drawing.Point(440, 34);
            this.lblListarNome.Name = "lblListarNome";
            this.lblListarNome.Size = new System.Drawing.Size(102, 18);
            this.lblListarNome.TabIndex = 1;
            this.lblListarNome.Text = "listar produtos";
            // 
            // lblListarProdutos
            // 
            this.lblListarProdutos.AutoSize = true;
            this.lblListarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarProdutos.Location = new System.Drawing.Point(53, 125);
            this.lblListarProdutos.Name = "lblListarProdutos";
            this.lblListarProdutos.Size = new System.Drawing.Size(86, 18);
            this.lblListarProdutos.TabIndex = 2;
            this.lblListarProdutos.Text = "Listar nome";
            // 
            // ltbListarProdutos
            // 
            this.ltbListarProdutos.FormattingEnabled = true;
            this.ltbListarProdutos.Location = new System.Drawing.Point(443, 69);
            this.ltbListarProdutos.Name = "ltbListarProdutos";
            this.ltbListarProdutos.Size = new System.Drawing.Size(120, 95);
            this.ltbListarProdutos.TabIndex = 3;
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Location = new System.Drawing.Point(71, 233);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(54, 17);
            this.ckbLivros.TabIndex = 4;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            this.ckbLivros.CheckedChanged += new System.EventHandler(this.ckbLivros_CheckedChanged);
            // 
            // ckbComputador
            // 
            this.ckbComputador.AutoSize = true;
            this.ckbComputador.Location = new System.Drawing.Point(71, 256);
            this.ckbComputador.Name = "ckbComputador";
            this.ckbComputador.Size = new System.Drawing.Size(83, 17);
            this.ckbComputador.TabIndex = 5;
            this.ckbComputador.Text = "Computador";
            this.ckbComputador.UseVisualStyleBackColor = true;
            this.ckbComputador.CheckedChanged += new System.EventHandler(this.ckbComputador_CheckedChanged);
            // 
            // ckbMesa
            // 
            this.ckbMesa.AutoSize = true;
            this.ckbMesa.Location = new System.Drawing.Point(71, 279);
            this.ckbMesa.Name = "ckbMesa";
            this.ckbMesa.Size = new System.Drawing.Size(52, 17);
            this.ckbMesa.TabIndex = 6;
            this.ckbMesa.Text = "Mesa";
            this.ckbMesa.UseVisualStyleBackColor = true;
            this.ckbMesa.CheckedChanged += new System.EventHandler(this.ckbMesa_CheckedChanged);
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Location = new System.Drawing.Point(71, 302);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(63, 17);
            this.ckbBanana.TabIndex = 7;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            this.ckbBanana.CheckedChanged += new System.EventHandler(this.ckbBanana_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(68, 200);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(56, 16);
            this.lblEscolha.TabIndex = 11;
            this.lblEscolha.Text = "Escolha";
            // 
            // btncarregar
            // 
            this.btncarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncarregar.Location = new System.Drawing.Point(457, 372);
            this.btncarregar.Name = "btncarregar";
            this.btncarregar.Size = new System.Drawing.Size(152, 43);
            this.btncarregar.TabIndex = 12;
            this.btncarregar.Text = "carregar imagens";
            this.btncarregar.UseVisualStyleBackColor = true;
            this.btncarregar.Click += new System.EventHandler(this.btncarregar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pctimgens
            // 
            this.pctimgens.Location = new System.Drawing.Point(422, 170);
            this.pctimgens.Name = "pctimgens";
            this.pctimgens.Size = new System.Drawing.Size(247, 196);
            this.pctimgens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctimgens.TabIndex = 13;
            this.pctimgens.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(301, 372);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 43);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(282, 241);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 43);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pctimgens);
            this.Controls.Add(this.btncarregar);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ckbBanana);
            this.Controls.Add(this.ckbMesa);
            this.Controls.Add(this.ckbComputador);
            this.Controls.Add(this.ckbLivros);
            this.Controls.Add(this.ltbListarProdutos);
            this.Controls.Add(this.lblListarProdutos);
            this.Controls.Add(this.lblListarNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctimgens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListarNome;
        private System.Windows.Forms.Label lblListarProdutos;
        private System.Windows.Forms.ListBox ltbListarProdutos;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.CheckBox ckbComputador;
        private System.Windows.Forms.CheckBox ckbMesa;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Button btncarregar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pctimgens;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

