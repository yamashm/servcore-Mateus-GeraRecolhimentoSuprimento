namespace GeraRecolhimentoSuprimento
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
            this.txbEntradaTarefas = new System.Windows.Forms.TextBox();
            this.txbEntradaSaldoCedula = new System.Windows.Forms.TextBox();
            this.btnRecolhimento = new System.Windows.Forms.Button();
            this.btnConcluirTarefa = new System.Windows.Forms.Button();
            this.btnVerificaTarefas = new System.Windows.Forms.Button();
            this.cbbTarefas_nu_os = new System.Windows.Forms.ComboBox();
            this.label105 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbConcluirTarefas_tp_atendimento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbConcluirTarefas_id_tarefa = new System.Windows.Forms.ComboBox();
            this.btnSuprimento = new System.Windows.Forms.Button();
            this.txbSaida = new System.Windows.Forms.TextBox();
            this.txbTerminal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_URLServivos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbEntradaTarefas
            // 
            this.txbEntradaTarefas.Location = new System.Drawing.Point(12, 113);
            this.txbEntradaTarefas.Multiline = true;
            this.txbEntradaTarefas.Name = "txbEntradaTarefas";
            this.txbEntradaTarefas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbEntradaTarefas.Size = new System.Drawing.Size(371, 325);
            this.txbEntradaTarefas.TabIndex = 0;
            // 
            // txbEntradaSaldoCedula
            // 
            this.txbEntradaSaldoCedula.Location = new System.Drawing.Point(389, 113);
            this.txbEntradaSaldoCedula.Multiline = true;
            this.txbEntradaSaldoCedula.Name = "txbEntradaSaldoCedula";
            this.txbEntradaSaldoCedula.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbEntradaSaldoCedula.Size = new System.Drawing.Size(371, 325);
            this.txbEntradaSaldoCedula.TabIndex = 1;
            // 
            // btnRecolhimento
            // 
            this.btnRecolhimento.Location = new System.Drawing.Point(12, 41);
            this.btnRecolhimento.Name = "btnRecolhimento";
            this.btnRecolhimento.Size = new System.Drawing.Size(119, 23);
            this.btnRecolhimento.TabIndex = 2;
            this.btnRecolhimento.Text = "Gera Recolhimento";
            this.btnRecolhimento.UseVisualStyleBackColor = true;
            this.btnRecolhimento.Click += new System.EventHandler(this.btnRecolhimento_Click);
            // 
            // btnConcluirTarefa
            // 
            this.btnConcluirTarefa.Location = new System.Drawing.Point(417, 14);
            this.btnConcluirTarefa.Name = "btnConcluirTarefa";
            this.btnConcluirTarefa.Size = new System.Drawing.Size(119, 23);
            this.btnConcluirTarefa.TabIndex = 5;
            this.btnConcluirTarefa.Text = "Gera Concluir";
            this.btnConcluirTarefa.UseVisualStyleBackColor = true;
            this.btnConcluirTarefa.Click += new System.EventHandler(this.btnConcluirTarefa_Click);
            // 
            // btnVerificaTarefas
            // 
            this.btnVerificaTarefas.Location = new System.Drawing.Point(12, 12);
            this.btnVerificaTarefas.Name = "btnVerificaTarefas";
            this.btnVerificaTarefas.Size = new System.Drawing.Size(119, 23);
            this.btnVerificaTarefas.TabIndex = 6;
            this.btnVerificaTarefas.Text = "Verifica Tarefas";
            this.btnVerificaTarefas.UseVisualStyleBackColor = true;
            this.btnVerificaTarefas.Click += new System.EventHandler(this.btnVerificaTarefas_Click);
            // 
            // cbbTarefas_nu_os
            // 
            this.cbbTarefas_nu_os.FormattingEnabled = true;
            this.cbbTarefas_nu_os.Location = new System.Drawing.Point(234, 75);
            this.cbbTarefas_nu_os.Name = "cbbTarefas_nu_os";
            this.cbbTarefas_nu_os.Size = new System.Drawing.Size(121, 21);
            this.cbbTarefas_nu_os.TabIndex = 210;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(192, 75);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(36, 13);
            this.label105.TabIndex = 209;
            this.label105.Text = "nu_os";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 208;
            this.label7.Text = "tp_atendimento";
            // 
            // cbbConcluirTarefas_tp_atendimento
            // 
            this.cbbConcluirTarefas_tp_atendimento.FormattingEnabled = true;
            this.cbbConcluirTarefas_tp_atendimento.Items.AddRange(new object[] {
            "P",
            "T",
            "N"});
            this.cbbConcluirTarefas_tp_atendimento.Location = new System.Drawing.Point(234, 43);
            this.cbbConcluirTarefas_tp_atendimento.Name = "cbbConcluirTarefas_tp_atendimento";
            this.cbbConcluirTarefas_tp_atendimento.Size = new System.Drawing.Size(121, 21);
            this.cbbConcluirTarefas_tp_atendimento.TabIndex = 207;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 206;
            this.label10.Text = "id_tarefa";
            // 
            // cbbConcluirTarefas_id_tarefa
            // 
            this.cbbConcluirTarefas_id_tarefa.FormattingEnabled = true;
            this.cbbConcluirTarefas_id_tarefa.Location = new System.Drawing.Point(234, 14);
            this.cbbConcluirTarefas_id_tarefa.Name = "cbbConcluirTarefas_id_tarefa";
            this.cbbConcluirTarefas_id_tarefa.Size = new System.Drawing.Size(121, 21);
            this.cbbConcluirTarefas_id_tarefa.TabIndex = 205;
            // 
            // btnSuprimento
            // 
            this.btnSuprimento.Location = new System.Drawing.Point(12, 70);
            this.btnSuprimento.Name = "btnSuprimento";
            this.btnSuprimento.Size = new System.Drawing.Size(119, 23);
            this.btnSuprimento.TabIndex = 211;
            this.btnSuprimento.Text = "Gera Suprimento";
            this.btnSuprimento.UseVisualStyleBackColor = true;
            this.btnSuprimento.Click += new System.EventHandler(this.btnSuprimento_Click);
            // 
            // txbSaida
            // 
            this.txbSaida.Location = new System.Drawing.Point(766, 113);
            this.txbSaida.Multiline = true;
            this.txbSaida.Name = "txbSaida";
            this.txbSaida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbSaida.Size = new System.Drawing.Size(371, 325);
            this.txbSaida.TabIndex = 212;
            // 
            // txbTerminal
            // 
            this.txbTerminal.Location = new System.Drawing.Point(436, 73);
            this.txbTerminal.MaxLength = 3;
            this.txbTerminal.Name = "txbTerminal";
            this.txbTerminal.Size = new System.Drawing.Size(32, 20);
            this.txbTerminal.TabIndex = 213;
            this.txbTerminal.Text = "168";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 214;
            this.label1.Text = "terminal";
            // 
            // txb_URLServivos
            // 
            this.txb_URLServivos.Location = new System.Drawing.Point(675, 17);
            this.txb_URLServivos.Name = "txb_URLServivos";
            this.txb_URLServivos.Size = new System.Drawing.Size(319, 20);
            this.txb_URLServivos.TabIndex = 216;
            this.txb_URLServivos.Text = "https://homologacao.crednosso.com.br/wsatmrest/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 215;
            this.label2.Text = "URLServivos";
            // 
            // btnExecuta
            // 
            this.btnExecuta.Location = new System.Drawing.Point(1017, 84);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(119, 23);
            this.btnExecuta.TabIndex = 217;
            this.btnExecuta.Text = "Executa";
            this.btnExecuta.UseVisualStyleBackColor = true;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.txb_URLServivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTerminal);
            this.Controls.Add(this.txbSaida);
            this.Controls.Add(this.btnSuprimento);
            this.Controls.Add(this.cbbTarefas_nu_os);
            this.Controls.Add(this.label105);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbConcluirTarefas_tp_atendimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbConcluirTarefas_id_tarefa);
            this.Controls.Add(this.btnVerificaTarefas);
            this.Controls.Add(this.btnConcluirTarefa);
            this.Controls.Add(this.btnRecolhimento);
            this.Controls.Add(this.txbEntradaSaldoCedula);
            this.Controls.Add(this.txbEntradaTarefas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEntradaTarefas;
        private System.Windows.Forms.TextBox txbEntradaSaldoCedula;
        private System.Windows.Forms.Button btnRecolhimento;
        private System.Windows.Forms.Button btnConcluirTarefa;
        private System.Windows.Forms.Button btnVerificaTarefas;
        private System.Windows.Forms.ComboBox cbbTarefas_nu_os;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbConcluirTarefas_tp_atendimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbConcluirTarefas_id_tarefa;
        private System.Windows.Forms.Button btnSuprimento;
        private System.Windows.Forms.TextBox txbSaida;
        private System.Windows.Forms.TextBox txbTerminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_URLServivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecuta;
    }
}

