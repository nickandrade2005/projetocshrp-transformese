namespace fmrFolha_de_pagamento
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
            this.ckbclubedelazer = new System.Windows.Forms.CheckBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.cbxclubedelazer = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtsalariodafolha = new System.Windows.Forms.TextBox();
            this.txtimpostoderenda = new System.Windows.Forms.TextBox();
            this.txtSalarioliquido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDatadaFolha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbclubedelazer
            // 
            this.ckbclubedelazer.AutoSize = true;
            this.ckbclubedelazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbclubedelazer.Location = new System.Drawing.Point(18, 173);
            this.ckbclubedelazer.Name = "ckbclubedelazer";
            this.ckbclubedelazer.Size = new System.Drawing.Size(119, 22);
            this.ckbclubedelazer.TabIndex = 0;
            this.ckbclubedelazer.Text = "plano de lazer";
            this.ckbclubedelazer.UseVisualStyleBackColor = true;
            this.ckbclubedelazer.CheckedChanged += new System.EventHandler(this.ckbclubedelazer_CheckedChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(503, 290);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(160, 34);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // cbxclubedelazer
            // 
            this.cbxclubedelazer.FormattingEnabled = true;
            this.cbxclubedelazer.Location = new System.Drawing.Point(16, 230);
            this.cbxclubedelazer.Name = "cbxclubedelazer";
            this.cbxclubedelazer.Size = new System.Drawing.Size(121, 21);
            this.cbxclubedelazer.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 127);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(139, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // txtsalariodafolha
            // 
            this.txtsalariodafolha.Location = new System.Drawing.Point(561, 110);
            this.txtsalariodafolha.Name = "txtsalariodafolha";
            this.txtsalariodafolha.Size = new System.Drawing.Size(139, 20);
            this.txtsalariodafolha.TabIndex = 4;
            // 
            // txtimpostoderenda
            // 
            this.txtimpostoderenda.Location = new System.Drawing.Point(561, 175);
            this.txtimpostoderenda.Name = "txtimpostoderenda";
            this.txtimpostoderenda.Size = new System.Drawing.Size(139, 20);
            this.txtimpostoderenda.TabIndex = 5;
            // 
            // txtSalarioliquido
            // 
            this.txtSalarioliquido.Location = new System.Drawing.Point(561, 250);
            this.txtSalarioliquido.Name = "txtSalarioliquido";
            this.txtSalarioliquido.Size = new System.Drawing.Size(139, 20);
            this.txtSalarioliquido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "salario folha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "imposto de Renda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salário Liquido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Clube de lazer";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(13, 106);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(54, 18);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salario";
            // 
            // lblDatadaFolha
            // 
            this.lblDatadaFolha.AutoSize = true;
            this.lblDatadaFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatadaFolha.Location = new System.Drawing.Point(13, 41);
            this.lblDatadaFolha.Name = "lblDatadaFolha";
            this.lblDatadaFolha.Size = new System.Drawing.Size(100, 18);
            this.lblDatadaFolha.TabIndex = 14;
            this.lblDatadaFolha.Text = "Data da Folha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(503, 330);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 28);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(503, 364);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(160, 32);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDatadaFolha);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalarioliquido);
            this.Controls.Add(this.txtimpostoderenda);
            this.Controls.Add(this.txtsalariodafolha);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cbxclubedelazer);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.ckbclubedelazer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbclubedelazer;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cbxclubedelazer;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtsalariodafolha;
        private System.Windows.Forms.TextBox txtimpostoderenda;
        private System.Windows.Forms.TextBox txtSalarioliquido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDatadaFolha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

