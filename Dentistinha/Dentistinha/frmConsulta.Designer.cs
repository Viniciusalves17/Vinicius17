namespace Dentistinha
{
    partial class frmConsulta
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
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Dentista = new System.Windows.Forms.ComboBox();
            this.cmb_Paciente = new System.Windows.Forms.ComboBox();
            this.txt_Motivo = new System.Windows.Forms.TextBox();
            this.txt_Diagnostico = new System.Windows.Forms.TextBox();
            this.txt_Receita = new System.Windows.Forms.TextBox();
            this.txt_Retorno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DT_Consulta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id_Consulta = new System.Windows.Forms.TextBox();
            this.DT_Retorno = new System.Windows.Forms.DateTimePicker();
            this.DTGW_Consulta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGW_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(6, 34);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(124, 34);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(240, 34);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(353, 34);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Novo);
            this.groupBox1.Controls.Add(this.btn_Excluir);
            this.groupBox1.Controls.Add(this.btn_Salvar);
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_Dentista);
            this.groupBox2.Controls.Add(this.cmb_Paciente);
            this.groupBox2.Controls.Add(this.txt_Motivo);
            this.groupBox2.Controls.Add(this.txt_Diagnostico);
            this.groupBox2.Controls.Add(this.txt_Receita);
            this.groupBox2.Controls.Add(this.txt_Retorno);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DT_Consulta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Id_Consulta);
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 241);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Consulta";
            // 
            // cmb_Dentista
            // 
            this.cmb_Dentista.FormattingEnabled = true;
            this.cmb_Dentista.Location = new System.Drawing.Point(101, 111);
            this.cmb_Dentista.Name = "cmb_Dentista";
            this.cmb_Dentista.Size = new System.Drawing.Size(327, 21);
            this.cmb_Dentista.TabIndex = 19;
            // 
            // cmb_Paciente
            // 
            this.cmb_Paciente.FormattingEnabled = true;
            this.cmb_Paciente.Location = new System.Drawing.Point(101, 87);
            this.cmb_Paciente.Name = "cmb_Paciente";
            this.cmb_Paciente.Size = new System.Drawing.Size(324, 21);
            this.cmb_Paciente.TabIndex = 18;
            // 
            // txt_Motivo
            // 
            this.txt_Motivo.Location = new System.Drawing.Point(107, 136);
            this.txt_Motivo.Name = "txt_Motivo";
            this.txt_Motivo.Size = new System.Drawing.Size(493, 20);
            this.txt_Motivo.TabIndex = 17;
            // 
            // txt_Diagnostico
            // 
            this.txt_Diagnostico.Location = new System.Drawing.Point(71, 164);
            this.txt_Diagnostico.Name = "txt_Diagnostico";
            this.txt_Diagnostico.Size = new System.Drawing.Size(407, 20);
            this.txt_Diagnostico.TabIndex = 16;
            // 
            // txt_Receita
            // 
            this.txt_Receita.Location = new System.Drawing.Point(53, 187);
            this.txt_Receita.Name = "txt_Receita";
            this.txt_Receita.Size = new System.Drawing.Size(425, 20);
            this.txt_Receita.TabIndex = 15;
            // 
            // txt_Retorno
            // 
            this.txt_Retorno.Location = new System.Drawing.Point(101, 213);
            this.txt_Retorno.Name = "txt_Retorno";
            this.txt_Retorno.Size = new System.Drawing.Size(511, 20);
            this.txt_Retorno.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Motivo de Retorno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Receita";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Diagnostico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Motivo da Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome do dentista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Retorno";
            // 
            // DT_Consulta
            // 
            this.DT_Consulta.Location = new System.Drawing.Point(101, 50);
            this.DT_Consulta.Name = "DT_Consulta";
            this.DT_Consulta.Size = new System.Drawing.Size(200, 20);
            this.DT_Consulta.TabIndex = 3;
            this.DT_Consulta.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data da Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Consulta";
            // 
            // txt_Id_Consulta
            // 
            this.txt_Id_Consulta.Location = new System.Drawing.Point(74, 23);
            this.txt_Id_Consulta.Name = "txt_Id_Consulta";
            this.txt_Id_Consulta.Size = new System.Drawing.Size(100, 20);
            this.txt_Id_Consulta.TabIndex = 0;
            // 
            // DT_Retorno
            // 
            this.DT_Retorno.Location = new System.Drawing.Point(442, 133);
            this.DT_Retorno.Name = "DT_Retorno";
            this.DT_Retorno.Size = new System.Drawing.Size(200, 20);
            this.DT_Retorno.TabIndex = 7;
            // 
            // DTGW_Consulta
            // 
            this.DTGW_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGW_Consulta.Location = new System.Drawing.Point(0, 329);
            this.DTGW_Consulta.Name = "DTGW_Consulta";
            this.DTGW_Consulta.Size = new System.Drawing.Size(633, 119);
            this.DTGW_Consulta.TabIndex = 8;
            this.DTGW_Consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGW_Consulta_CellContentClick);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.DTGW_Consulta);
            this.Controls.Add(this.DT_Retorno);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGW_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DT_Consulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id_Consulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DT_Retorno;
        private System.Windows.Forms.ComboBox cmb_Dentista;
        private System.Windows.Forms.ComboBox cmb_Paciente;
        private System.Windows.Forms.TextBox txt_Motivo;
        private System.Windows.Forms.TextBox txt_Diagnostico;
        private System.Windows.Forms.TextBox txt_Receita;
        private System.Windows.Forms.TextBox txt_Retorno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DTGW_Consulta;
    }
}