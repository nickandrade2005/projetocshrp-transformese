namespace calculadora
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
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbnSomar = new System.Windows.Forms.RadioButton();
            this.rbnSubitrair = new System.Windows.Forms.RadioButton();
            this.rbnMutiplicar = new System.Windows.Forms.RadioButton();
            this.rbnDividir = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnCaucular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero1.Location = new System.Drawing.Point(24, 69);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(71, 18);
            this.lblnumero1.TabIndex = 0;
            this.lblnumero1.Text = "numero 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbnSomar
            // 
            this.rbnSomar.AutoSize = true;
            this.rbnSomar.Location = new System.Drawing.Point(38, 36);
            this.rbnSomar.Name = "rbnSomar";
            this.rbnSomar.Size = new System.Drawing.Size(74, 24);
            this.rbnSomar.TabIndex = 2;
            this.rbnSomar.TabStop = true;
            this.rbnSomar.Text = "Somar";
            this.rbnSomar.UseVisualStyleBackColor = true;
            // 
            // rbnSubitrair
            // 
            this.rbnSubitrair.AutoSize = true;
            this.rbnSubitrair.Location = new System.Drawing.Point(38, 59);
            this.rbnSubitrair.Name = "rbnSubitrair";
            this.rbnSubitrair.Size = new System.Drawing.Size(86, 24);
            this.rbnSubitrair.TabIndex = 3;
            this.rbnSubitrair.TabStop = true;
            this.rbnSubitrair.Text = "Subitrair";
            this.rbnSubitrair.UseVisualStyleBackColor = true;
            // 
            // rbnMutiplicar
            // 
            this.rbnMutiplicar.AutoSize = true;
            this.rbnMutiplicar.Location = new System.Drawing.Point(38, 81);
            this.rbnMutiplicar.Name = "rbnMutiplicar";
            this.rbnMutiplicar.Size = new System.Drawing.Size(94, 24);
            this.rbnMutiplicar.TabIndex = 4;
            this.rbnMutiplicar.TabStop = true;
            this.rbnMutiplicar.Text = "Mutiplicar";
            this.rbnMutiplicar.UseVisualStyleBackColor = true;
            // 
            // rbnDividir
            // 
            this.rbnDividir.AutoSize = true;
            this.rbnDividir.Location = new System.Drawing.Point(39, 104);
            this.rbnDividir.Name = "rbnDividir";
            this.rbnDividir.Size = new System.Drawing.Size(69, 24);
            this.rbnDividir.TabIndex = 5;
            this.rbnDividir.TabStop = true;
            this.rbnDividir.Text = "Dividir";
            this.rbnDividir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnSomar);
            this.groupBox1.Controls.Add(this.rbnDividir);
            this.groupBox1.Controls.Add(this.rbnSubitrair);
            this.groupBox1.Controls.Add(this.rbnMutiplicar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(258, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "operaçoes";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero2.Location = new System.Drawing.Point(24, 137);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(71, 18);
            this.lblnumero2.TabIndex = 9;
            this.lblnumero2.Text = "numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resposta";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(622, 178);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 91);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(622, 298);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(154, 91);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // btnCaucular
            // 
            this.btnCaucular.Location = new System.Drawing.Point(622, 69);
            this.btnCaucular.Name = "btnCaucular";
            this.btnCaucular.Size = new System.Drawing.Size(154, 91);
            this.btnCaucular.TabIndex = 11;
            this.btnCaucular.Text = "Caucular";
            this.btnCaucular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCaucular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblnumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbnSomar;
        private System.Windows.Forms.RadioButton rbnSubitrair;
        private System.Windows.Forms.RadioButton rbnMutiplicar;
        private System.Windows.Forms.RadioButton rbnDividir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnCaucular;
    }
}

