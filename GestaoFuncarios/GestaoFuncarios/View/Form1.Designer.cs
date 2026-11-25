namespace GestaoFuncarios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalcularRemuneracao = new System.Windows.Forms.Button();
            this.txtSalarioCalculado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtTotalVendas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtSalarioBase);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTipoFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 269);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Funcionário";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCalcularRemuneracao);
            this.groupBox3.Controls.Add(this.txtSalarioCalculado);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(298, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 137);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btnCalcularRemuneracao
            // 
            this.btnCalcularRemuneracao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularRemuneracao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCalcularRemuneracao.Location = new System.Drawing.Point(17, 99);
            this.btnCalcularRemuneracao.Name = "btnCalcularRemuneracao";
            this.btnCalcularRemuneracao.Size = new System.Drawing.Size(147, 28);
            this.btnCalcularRemuneracao.TabIndex = 7;
            this.btnCalcularRemuneracao.Text = "Calcular Remuneração";
            this.btnCalcularRemuneracao.UseVisualStyleBackColor = true;
            this.btnCalcularRemuneracao.Click += new System.EventHandler(this.btnCalcularRemuneracao_Click);
            // 
            // txtSalarioCalculado
            // 
            this.txtSalarioCalculado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSalarioCalculado.Location = new System.Drawing.Point(17, 64);
            this.txtSalarioCalculado.Name = "txtSalarioCalculado";
            this.txtSalarioCalculado.Size = new System.Drawing.Size(147, 29);
            this.txtSalarioCalculado.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Salário calculado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComissao);
            this.groupBox2.Controls.Add(this.txtTotalVendas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(176, 36);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(100, 29);
            this.txtComissao.TabIndex = 5;
            // 
            // txtTotalVendas
            // 
            this.txtTotalVendas.Location = new System.Drawing.Point(10, 36);
            this.txtTotalVendas.Name = "txtTotalVendas";
            this.txtTotalVendas.Size = new System.Drawing.Size(160, 29);
            this.txtTotalVendas.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(176, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Comissão (%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total de vendas (R$):";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 29);
            this.txtNome.TabIndex = 2;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(126, 136);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(166, 29);
            this.txtSalarioBase.TabIndex = 3;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(13, 101);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 29);
            this.txtMatricula.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salário-base(R$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(108, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matrícula:";
            // 
            // cmbTipoFuncionario
            // 
            this.cmbTipoFuncionario.FormattingEnabled = true;
            this.cmbTipoFuncionario.Location = new System.Drawing.Point(13, 49);
            this.cmbTipoFuncionario.Name = "cmbTipoFuncionario";
            this.cmbTipoFuncionario.Size = new System.Drawing.Size(279, 29);
            this.cmbTipoFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Funcionário:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 287);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(78, 46);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "📄 Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(96, 287);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(78, 46);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "💾 Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "🗑 Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(324, 287);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(78, 46);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "◀ Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(408, 287);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(78, 46);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Text = "Próximo ▶";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 345);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestão de Funcionários";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtComissao;
        private TextBox txtTotalVendas;
        private Label label6;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtSalarioBase;
        private TextBox txtMatricula;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbTipoFuncionario;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnCalcularRemuneracao;
        private TextBox txtSalarioCalculado;
        private Label label7;
        private Button btnNovo;
        private Button btnGravar;
        private Button button3;
        private Button btnAnterior;
        private Button btnProximo;
    }
}