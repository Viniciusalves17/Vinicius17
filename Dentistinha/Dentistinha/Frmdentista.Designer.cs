namespace Dentistinha
{
    partial class Frmdentista
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Novo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_CRO = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CH_Linkedin = new System.Windows.Forms.CheckBox();
            this.CH_Facebook = new System.Windows.Forms.CheckBox();
            this.CH_twitter = new System.Windows.Forms.CheckBox();
            this.CH_instagram = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_Masculino = new System.Windows.Forms.RadioButton();
            this.RB_Feminino = new System.Windows.Forms.RadioButton();
            this.DT_Dentista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Dentista)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(12, 12);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 29);
            this.btn_Novo.TabIndex = 1;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(114, 12);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 29);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(219, 12);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 29);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(319, 12);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.txt_CRO);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Dentista";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(47, 74);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(397, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_CRO
            // 
            this.txt_CRO.Location = new System.Drawing.Point(271, 43);
            this.txt_CRO.Name = "txt_CRO";
            this.txt_CRO.Size = new System.Drawing.Size(173, 20);
            this.txt_CRO.TabIndex = 4;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(47, 43);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(171, 20);
            this.txt_ID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CH_Linkedin);
            this.groupBox2.Controls.Add(this.CH_Facebook);
            this.groupBox2.Controls.Add(this.CH_twitter);
            this.groupBox2.Controls.Add(this.CH_instagram);
            this.groupBox2.Location = new System.Drawing.Point(264, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Redes Sociais";
            // 
            // CH_Linkedin
            // 
            this.CH_Linkedin.AutoSize = true;
            this.CH_Linkedin.Location = new System.Drawing.Point(102, 61);
            this.CH_Linkedin.Name = "CH_Linkedin";
            this.CH_Linkedin.Size = new System.Drawing.Size(66, 17);
            this.CH_Linkedin.TabIndex = 10;
            this.CH_Linkedin.Text = "Linkedin";
            this.CH_Linkedin.UseVisualStyleBackColor = true;
            // 
            // CH_Facebook
            // 
            this.CH_Facebook.AutoSize = true;
            this.CH_Facebook.Location = new System.Drawing.Point(6, 61);
            this.CH_Facebook.Name = "CH_Facebook";
            this.CH_Facebook.Size = new System.Drawing.Size(74, 17);
            this.CH_Facebook.TabIndex = 9;
            this.CH_Facebook.Text = "Facebook";
            this.CH_Facebook.UseVisualStyleBackColor = true;
            // 
            // CH_twitter
            // 
            this.CH_twitter.AutoSize = true;
            this.CH_twitter.Location = new System.Drawing.Point(102, 28);
            this.CH_twitter.Name = "CH_twitter";
            this.CH_twitter.Size = new System.Drawing.Size(58, 17);
            this.CH_twitter.TabIndex = 8;
            this.CH_twitter.Text = "Twitter";
            this.CH_twitter.UseVisualStyleBackColor = true;
            // 
            // CH_instagram
            // 
            this.CH_instagram.AutoSize = true;
            this.CH_instagram.Location = new System.Drawing.Point(6, 28);
            this.CH_instagram.Name = "CH_instagram";
            this.CH_instagram.Size = new System.Drawing.Size(72, 17);
            this.CH_instagram.TabIndex = 7;
            this.CH_instagram.Text = "Instagram";
            this.CH_instagram.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_Masculino);
            this.groupBox3.Controls.Add(this.RB_Feminino);
            this.groupBox3.Location = new System.Drawing.Point(12, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 84);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // RB_Masculino
            // 
            this.RB_Masculino.AutoSize = true;
            this.RB_Masculino.Location = new System.Drawing.Point(12, 51);
            this.RB_Masculino.Name = "RB_Masculino";
            this.RB_Masculino.Size = new System.Drawing.Size(73, 17);
            this.RB_Masculino.TabIndex = 1;
            this.RB_Masculino.TabStop = true;
            this.RB_Masculino.Text = "Masculino";
            this.RB_Masculino.UseVisualStyleBackColor = true;
            // 
            // RB_Feminino
            // 
            this.RB_Feminino.AutoSize = true;
            this.RB_Feminino.Location = new System.Drawing.Point(12, 19);
            this.RB_Feminino.Name = "RB_Feminino";
            this.RB_Feminino.Size = new System.Drawing.Size(67, 17);
            this.RB_Feminino.TabIndex = 0;
            this.RB_Feminino.TabStop = true;
            this.RB_Feminino.Text = "Feminino";
            this.RB_Feminino.UseVisualStyleBackColor = true;
            // 
            // DT_Dentista
            // 
            this.DT_Dentista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_Dentista.Location = new System.Drawing.Point(12, 288);
            this.DT_Dentista.Name = "DT_Dentista";
            this.DT_Dentista.Size = new System.Drawing.Size(452, 150);
            this.DT_Dentista.TabIndex = 8;
            this.DT_Dentista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_Dentista_CellClick);
            // 
            // Frmdentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.DT_Dentista);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Novo);
            this.Name = "Frmdentista";
            this.Text = "Dentista";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_Dentista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_CRO;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CH_Linkedin;
        private System.Windows.Forms.CheckBox CH_Facebook;
        private System.Windows.Forms.CheckBox CH_twitter;
        private System.Windows.Forms.CheckBox CH_instagram;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_Masculino;
        private System.Windows.Forms.RadioButton RB_Feminino;
        private System.Windows.Forms.DataGridView DT_Dentista;
    }
}

