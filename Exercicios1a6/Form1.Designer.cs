
namespace Exercicios1a6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_proocessa_potencia = new System.Windows.Forms.Button();
            this.TB_expoente = new System.Windows.Forms.TextBox();
            this.TB_base = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_resultados = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_processar_cubos = new System.Windows.Forms.Button();
            this.TB_n = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_processamdc = new System.Windows.Forms.Button();
            this.TB_y = new System.Windows.Forms.TextBox();
            this.TB_x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BT_processarCoverterparaBinario = new System.Windows.Forms.Button();
            this.TB_numeroInteiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BT_processafibonacci = new System.Windows.Forms.Button();
            this.TB_nfibonacci = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_proocessa_potencia);
            this.groupBox1.Controls.Add(this.TB_expoente);
            this.groupBox1.Controls.Add(this.TB_base);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potência";
            // 
            // BT_proocessa_potencia
            // 
            this.BT_proocessa_potencia.Location = new System.Drawing.Point(190, 51);
            this.BT_proocessa_potencia.Name = "BT_proocessa_potencia";
            this.BT_proocessa_potencia.Size = new System.Drawing.Size(75, 23);
            this.BT_proocessa_potencia.TabIndex = 1;
            this.BT_proocessa_potencia.Text = "Processar";
            this.BT_proocessa_potencia.UseVisualStyleBackColor = true;
            this.BT_proocessa_potencia.Click += new System.EventHandler(this.BT_proocessa_potencia_Click);
            // 
            // TB_expoente
            // 
            this.TB_expoente.Location = new System.Drawing.Point(64, 61);
            this.TB_expoente.Name = "TB_expoente";
            this.TB_expoente.Size = new System.Drawing.Size(100, 20);
            this.TB_expoente.TabIndex = 2;
            // 
            // TB_base
            // 
            this.TB_base.Location = new System.Drawing.Point(64, 33);
            this.TB_base.Name = "TB_base";
            this.TB_base.Size = new System.Drawing.Size(100, 20);
            this.TB_base.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expoente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // LB_resultados
            // 
            this.LB_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LB_resultados.FormattingEnabled = true;
            this.LB_resultados.ItemHeight = 20;
            this.LB_resultados.Location = new System.Drawing.Point(295, 177);
            this.LB_resultados.Name = "LB_resultados";
            this.LB_resultados.Size = new System.Drawing.Size(572, 464);
            this.LB_resultados.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_processar_cubos);
            this.groupBox2.Controls.Add(this.TB_n);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(1, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cubos";
            // 
            // BT_processar_cubos
            // 
            this.BT_processar_cubos.Location = new System.Drawing.Point(190, 51);
            this.BT_processar_cubos.Name = "BT_processar_cubos";
            this.BT_processar_cubos.Size = new System.Drawing.Size(75, 23);
            this.BT_processar_cubos.TabIndex = 1;
            this.BT_processar_cubos.Text = "Processar";
            this.BT_processar_cubos.UseVisualStyleBackColor = true;
            this.BT_processar_cubos.Click += new System.EventHandler(this.BT_processar_cubos_Click);
            // 
            // TB_n
            // 
            this.TB_n.Location = new System.Drawing.Point(55, 53);
            this.TB_n.Name = "TB_n";
            this.TB_n.Size = new System.Drawing.Size(100, 20);
            this.TB_n.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BT_processamdc);
            this.groupBox3.Controls.Add(this.TB_y);
            this.groupBox3.Controls.Add(this.TB_x);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 145);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minimo Divisor Comum";
            // 
            // BT_processamdc
            // 
            this.BT_processamdc.Location = new System.Drawing.Point(190, 51);
            this.BT_processamdc.Name = "BT_processamdc";
            this.BT_processamdc.Size = new System.Drawing.Size(75, 23);
            this.BT_processamdc.TabIndex = 1;
            this.BT_processamdc.Text = "Processar";
            this.BT_processamdc.UseVisualStyleBackColor = true;
            this.BT_processamdc.Click += new System.EventHandler(this.BT_processamdc_Click);
            // 
            // TB_y
            // 
            this.TB_y.Location = new System.Drawing.Point(64, 65);
            this.TB_y.Name = "TB_y";
            this.TB_y.Size = new System.Drawing.Size(100, 20);
            this.TB_y.TabIndex = 2;
            // 
            // TB_x
            // 
            this.TB_x.Location = new System.Drawing.Point(64, 33);
            this.TB_x.Name = "TB_x";
            this.TB_x.Size = new System.Drawing.Size(100, 20);
            this.TB_x.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BT_processarCoverterparaBinario);
            this.groupBox4.Controls.Add(this.TB_numeroInteiro);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(295, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 170);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inteiro para binário";
            // 
            // BT_processarCoverterparaBinario
            // 
            this.BT_processarCoverterparaBinario.Location = new System.Drawing.Point(190, 51);
            this.BT_processarCoverterparaBinario.Name = "BT_processarCoverterparaBinario";
            this.BT_processarCoverterparaBinario.Size = new System.Drawing.Size(75, 23);
            this.BT_processarCoverterparaBinario.TabIndex = 1;
            this.BT_processarCoverterparaBinario.Text = "Processar";
            this.BT_processarCoverterparaBinario.UseVisualStyleBackColor = true;
            this.BT_processarCoverterparaBinario.Click += new System.EventHandler(this.BT_processarCoverterparaBinario_Click);
            // 
            // TB_numeroInteiro
            // 
            this.TB_numeroInteiro.Location = new System.Drawing.Point(65, 54);
            this.TB_numeroInteiro.Name = "TB_numeroInteiro";
            this.TB_numeroInteiro.Size = new System.Drawing.Size(100, 20);
            this.TB_numeroInteiro.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Número";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BT_processafibonacci);
            this.groupBox5.Controls.Add(this.TB_nfibonacci);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(589, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 170);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fibonacci";
            // 
            // BT_processafibonacci
            // 
            this.BT_processafibonacci.Location = new System.Drawing.Point(190, 51);
            this.BT_processafibonacci.Name = "BT_processafibonacci";
            this.BT_processafibonacci.Size = new System.Drawing.Size(75, 23);
            this.BT_processafibonacci.TabIndex = 1;
            this.BT_processafibonacci.Text = "Processar";
            this.BT_processafibonacci.UseVisualStyleBackColor = true;
            this.BT_processafibonacci.Click += new System.EventHandler(this.BT_processafibonacci_Click);
            // 
            // TB_nfibonacci
            // 
            this.TB_nfibonacci.Location = new System.Drawing.Point(55, 53);
            this.TB_nfibonacci.Name = "TB_nfibonacci";
            this.TB_nfibonacci.Size = new System.Drawing.Size(100, 20);
            this.TB_nfibonacci.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 654);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LB_resultados);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Recursividade Diversos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_proocessa_potencia;
        private System.Windows.Forms.TextBox TB_expoente;
        private System.Windows.Forms.TextBox TB_base;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB_resultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BT_processar_cubos;
        private System.Windows.Forms.TextBox TB_n;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BT_processamdc;
        private System.Windows.Forms.TextBox TB_y;
        private System.Windows.Forms.TextBox TB_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BT_processarCoverterparaBinario;
        private System.Windows.Forms.TextBox TB_numeroInteiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BT_processafibonacci;
        private System.Windows.Forms.TextBox TB_nfibonacci;
        private System.Windows.Forms.Label label7;
    }
}

