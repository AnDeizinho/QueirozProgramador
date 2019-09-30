namespace SistemaClientes
{
    partial class FrmCadCliente
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
            this.txtpai = new System.Windows.Forms.TextBox();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.cpfpai = new System.Windows.Forms.MaskedTextBox();
            this.cpfmae = new System.Windows.Forms.MaskedTextBox();
            this.fonepai = new System.Windows.Forms.MaskedTextBox();
            this.fonemae = new System.Windows.Forms.MaskedTextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.lblpai = new System.Windows.Forms.Label();
            this.lblmae = new System.Windows.Forms.Label();
            this.lblcpfpai = new System.Windows.Forms.Label();
            this.lblcpfmae = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpai
            // 
            this.txtpai.BackColor = System.Drawing.Color.Plum;
            this.txtpai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtpai.Location = new System.Drawing.Point(62, 38);
            this.txtpai.MaxLength = 100;
            this.txtpai.Name = "txtpai";
            this.txtpai.Size = new System.Drawing.Size(292, 26);
            this.txtpai.TabIndex = 1;
            this.txtpai.Validated += new System.EventHandler(this.txtpai_Validated);
            // 
            // txtMae
            // 
            this.txtMae.BackColor = System.Drawing.Color.Plum;
            this.txtMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMae.Location = new System.Drawing.Point(72, 77);
            this.txtMae.MaxLength = 100;
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(282, 26);
            this.txtMae.TabIndex = 2;
            this.txtMae.Validated += new System.EventHandler(this.txtMae_Validated);
            // 
            // txtendereco
            // 
            this.txtendereco.BackColor = System.Drawing.Color.Plum;
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtendereco.Location = new System.Drawing.Point(109, 35);
            this.txtendereco.MaxLength = 150;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(251, 26);
            this.txtendereco.TabIndex = 8;
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.Color.Plum;
            this.txtnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtnumero.Location = new System.Drawing.Point(101, 74);
            this.txtnumero.MaxLength = 10;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(143, 26);
            this.txtnumero.TabIndex = 9;
            // 
            // txtbairro
            // 
            this.txtbairro.BackColor = System.Drawing.Color.Plum;
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtbairro.Location = new System.Drawing.Point(87, 113);
            this.txtbairro.MaxLength = 150;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(273, 26);
            this.txtbairro.TabIndex = 10;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BackColor = System.Drawing.Color.Plum;
            this.txtcomplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcomplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtcomplemento.Location = new System.Drawing.Point(144, 152);
            this.txtcomplemento.MaxLength = 150;
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(216, 26);
            this.txtcomplemento.TabIndex = 11;
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.Color.Plum;
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtcidade.Location = new System.Drawing.Point(96, 191);
            this.txtcidade.MaxLength = 50;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(264, 26);
            this.txtcidade.TabIndex = 12;
            // 
            // txtestado
            // 
            this.txtestado.BackColor = System.Drawing.Color.Plum;
            this.txtestado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtestado.Location = new System.Drawing.Point(96, 230);
            this.txtestado.MaxLength = 3;
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(53, 26);
            this.txtestado.TabIndex = 13;
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.Color.Plum;
            this.txtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtRG.Location = new System.Drawing.Point(66, 268);
            this.txtRG.MaxLength = 8;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(288, 26);
            this.txtRG.TabIndex = 7;
            // 
            // cpfpai
            // 
            this.cpfpai.BackColor = System.Drawing.Color.Plum;
            this.cpfpai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cpfpai.Location = new System.Drawing.Point(99, 116);
            this.cpfpai.Mask = "000.000.000-00";
            this.cpfpai.Name = "cpfpai";
            this.cpfpai.Size = new System.Drawing.Size(255, 26);
            this.cpfpai.TabIndex = 3;
            // 
            // cpfmae
            // 
            this.cpfmae.BackColor = System.Drawing.Color.Plum;
            this.cpfmae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cpfmae.Location = new System.Drawing.Point(107, 155);
            this.cpfmae.Mask = "000.000.000-00";
            this.cpfmae.Name = "cpfmae";
            this.cpfmae.Size = new System.Drawing.Size(247, 26);
            this.cpfmae.TabIndex = 4;
            // 
            // fonepai
            // 
            this.fonepai.BackColor = System.Drawing.Color.Plum;
            this.fonepai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fonepai.Location = new System.Drawing.Point(99, 194);
            this.fonepai.Mask = "(00) 00000-0000";
            this.fonepai.Name = "fonepai";
            this.fonepai.Size = new System.Drawing.Size(255, 26);
            this.fonepai.TabIndex = 5;
            // 
            // fonemae
            // 
            this.fonemae.BackColor = System.Drawing.Color.Plum;
            this.fonemae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fonemae.Location = new System.Drawing.Point(113, 233);
            this.fonemae.Mask = "(00) 00000-0000";
            this.fonemae.Name = "fonemae";
            this.fonemae.Size = new System.Drawing.Size(241, 26);
            this.fonemae.TabIndex = 6;
            // 
            // txtcep
            // 
            this.txtcep.BackColor = System.Drawing.Color.Plum;
            this.txtcep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtcep.Location = new System.Drawing.Point(76, 269);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(223, 26);
            this.txtcep.TabIndex = 14;
            // 
            // lblpai
            // 
            this.lblpai.AutoSize = true;
            this.lblpai.Location = new System.Drawing.Point(26, 41);
            this.lblpai.Name = "lblpai";
            this.lblpai.Size = new System.Drawing.Size(31, 20);
            this.lblpai.TabIndex = 17;
            this.lblpai.Text = "Pai";
            // 
            // lblmae
            // 
            this.lblmae.AutoSize = true;
            this.lblmae.Location = new System.Drawing.Point(26, 80);
            this.lblmae.Name = "lblmae";
            this.lblmae.Size = new System.Drawing.Size(40, 20);
            this.lblmae.TabIndex = 18;
            this.lblmae.Text = "Mãe";
            // 
            // lblcpfpai
            // 
            this.lblcpfpai.AutoSize = true;
            this.lblcpfpai.Location = new System.Drawing.Point(26, 119);
            this.lblcpfpai.Name = "lblcpfpai";
            this.lblcpfpai.Size = new System.Drawing.Size(65, 20);
            this.lblcpfpai.TabIndex = 19;
            this.lblcpfpai.Text = "CPF pai";
            // 
            // lblcpfmae
            // 
            this.lblcpfmae.AutoSize = true;
            this.lblcpfmae.Location = new System.Drawing.Point(26, 158);
            this.lblcpfmae.Name = "lblcpfmae";
            this.lblcpfmae.Size = new System.Drawing.Size(75, 20);
            this.lblcpfmae.TabIndex = 20;
            this.lblcpfmae.Text = "CPF Mãe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fone Pai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fone Mãe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Número";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Estado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "CEP";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(26, 271);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(34, 20);
            this.lblrg.TabIndex = 31;
            this.lblrg.Text = "RG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Purple;
            this.groupBox1.Controls.Add(this.lblrg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblcpfmae);
            this.groupBox1.Controls.Add(this.lblcpfpai);
            this.groupBox1.Controls.Add(this.lblmae);
            this.groupBox1.Controls.Add(this.lblpai);
            this.groupBox1.Controls.Add(this.fonemae);
            this.groupBox1.Controls.Add(this.fonepai);
            this.groupBox1.Controls.Add(this.cpfmae);
            this.groupBox1.Controls.Add(this.cpfpai);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.txtMae);
            this.groupBox1.Controls.Add(this.txtpai);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 374);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados dos Responsáveis";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Purple;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtcep);
            this.groupBox2.Controls.Add(this.txtestado);
            this.groupBox2.Controls.Add(this.txtcidade);
            this.groupBox2.Controls.Add(this.txtcomplemento);
            this.groupBox2.Controls.Add(this.txtbairro);
            this.groupBox2.Controls.Add(this.txtnumero);
            this.groupBox2.Controls.Add(this.txtendereco);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(424, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 374);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local de Moradia";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(94, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(230, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(818, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadCliente";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.FrmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtpai;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.MaskedTextBox cpfpai;
        private System.Windows.Forms.MaskedTextBox cpfmae;
        private System.Windows.Forms.MaskedTextBox fonepai;
        private System.Windows.Forms.MaskedTextBox fonemae;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label lblpai;
        private System.Windows.Forms.Label lblmae;
        private System.Windows.Forms.Label lblcpfpai;
        private System.Windows.Forms.Label lblcpfmae;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}