namespace Funcionarios
{
    partial class Editar
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
            this.Panel = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.nascimento = new System.Windows.Forms.TextBox();
            this.sobrenome = new System.Windows.Forms.TextBox();
            this.labels = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rua = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaCadastro = new System.Windows.Forms.DataGridView();
            this.atualizar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.situacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.situacao);
            this.Panel.Controls.Add(this.label7);
            this.Panel.Controls.Add(this.id);
            this.Panel.Controls.Add(this.cep);
            this.Panel.Controls.Add(this.label6);
            this.Panel.Controls.Add(this.label100);
            this.Panel.Controls.Add(this.sexo);
            this.Panel.Controls.Add(this.nascimento);
            this.Panel.Controls.Add(this.sobrenome);
            this.Panel.Controls.Add(this.labels);
            this.Panel.Controls.Add(this.email);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.estado);
            this.Panel.Controls.Add(this.label20);
            this.Panel.Controls.Add(this.cidade);
            this.Panel.Controls.Add(this.label18);
            this.Panel.Controls.Add(this.label19);
            this.Panel.Controls.Add(this.bairro);
            this.Panel.Controls.Add(this.label16);
            this.Panel.Controls.Add(this.label17);
            this.Panel.Controls.Add(this.numero);
            this.Panel.Controls.Add(this.label15);
            this.Panel.Controls.Add(this.rua);
            this.Panel.Controls.Add(this.label12);
            this.Panel.Controls.Add(this.label11);
            this.Panel.Controls.Add(this.celular);
            this.Panel.Controls.Add(this.label10);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.cpf);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.nome);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.ListaCadastro);
            this.Panel.Controls.Add(this.atualizar);
            this.Panel.Controls.Add(this.cancelar);
            this.Panel.Controls.Add(this.label21);
            this.Panel.Controls.Add(this.label13);
            this.Panel.Location = new System.Drawing.Point(147, 90);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1041, 548);
            this.Panel.TabIndex = 6;
            this.Panel.TabStop = true;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(451, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(83, 20);
            this.id.TabIndex = 81;
            this.id.Visible = false;
            // 
            // cep
            // 
            this.cep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cep.Location = new System.Drawing.Point(217, 442);
            this.cep.MaxLength = 9;
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(139, 20);
            this.cep.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "CEP";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(214, 129);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(41, 16);
            this.label100.TabIndex = 79;
            this.label100.Text = "SEXO";
            // 
            // sexo
            // 
            this.sexo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexo.Location = new System.Drawing.Point(217, 151);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 54;
            // 
            // nascimento
            // 
            this.nascimento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nascimento.Location = new System.Drawing.Point(51, 151);
            this.nascimento.MaxLength = 11;
            this.nascimento.Name = "nascimento";
            this.nascimento.Size = new System.Drawing.Size(139, 20);
            this.nascimento.TabIndex = 53;
            this.nascimento.Text = "DD/MM/AAAA";
            // 
            // sobrenome
            // 
            this.sobrenome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sobrenome.Location = new System.Drawing.Point(217, 99);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(317, 20);
            this.sobrenome.TabIndex = 51;
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels.Location = new System.Drawing.Point(214, 80);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(84, 16);
            this.labels.TabIndex = 78;
            this.labels.Text = "SOBRENOME";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.email.Location = new System.Drawing.Point(217, 205);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(317, 20);
            this.email.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "E-MAIL";
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.estado.Location = new System.Drawing.Point(51, 441);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(127, 21);
            this.estado.TabIndex = 64;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 422);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 76;
            this.label20.Text = "ESTADO";
            // 
            // cidade
            // 
            this.cidade.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cidade.Location = new System.Drawing.Point(407, 389);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(127, 20);
            this.cidade.TabIndex = 63;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(404, 370);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 75;
            this.label18.Text = "CIDADE";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(206, 370);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 16);
            this.label19.TabIndex = 74;
            // 
            // bairro
            // 
            this.bairro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bairro.Location = new System.Drawing.Point(217, 389);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(139, 20);
            this.bairro.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(214, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 73;
            this.label16.Text = "BAIRRO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(243, 370);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 72;
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numero.Location = new System.Drawing.Point(51, 389);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(127, 20);
            this.numero.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(48, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 71;
            this.label15.Text = "NÚMERO";
            // 
            // rua
            // 
            this.rua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rua.Location = new System.Drawing.Point(51, 336);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(483, 20);
            this.rua.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "RUA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 19);
            this.label11.TabIndex = 69;
            this.label11.Text = "ENDEREÇO";
            // 
            // celular
            // 
            this.celular.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.celular.Location = new System.Drawing.Point(51, 205);
            this.celular.MaxLength = 11;
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(139, 20);
            this.celular.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "CELULAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "DATA DE NASCIMENTO";
            // 
            // cpf
            // 
            this.cpf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cpf.Location = new System.Drawing.Point(387, 152);
            this.cpf.MaxLength = 11;
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(147, 20);
            this.cpf.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "CPF";
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nome.Location = new System.Drawing.Point(51, 99);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(139, 20);
            this.nome.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "DADOS PESSOAIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "NOME";
            // 
            // ListaCadastro
            // 
            this.ListaCadastro.AllowUserToAddRows = false;
            this.ListaCadastro.AllowUserToDeleteRows = false;
            this.ListaCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCadastro.Location = new System.Drawing.Point(584, 21);
            this.ListaCadastro.Name = "ListaCadastro";
            this.ListaCadastro.ReadOnly = true;
            this.ListaCadastro.Size = new System.Drawing.Size(443, 500);
            this.ListaCadastro.TabIndex = 39;
            this.ListaCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaCadastro_CellDoubleClick);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.atualizar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.Location = new System.Drawing.Point(459, 494);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(90, 27);
            this.atualizar.TabIndex = 36;
            this.atualizar.Text = "ATUALIZAR";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(25, 494);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(90, 27);
            this.cancelar.TabIndex = 35;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(559, 361);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 16);
            this.label21.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(559, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 22;
            // 
            // situacao
            // 
            this.situacao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.situacao.FormattingEnabled = true;
            this.situacao.Items.AddRange(new object[] {
            "ATIVO",
            "FERIAS",
            "ATESTADO",
            "DEMITIDO"});
            this.situacao.Location = new System.Drawing.Point(407, 442);
            this.situacao.Name = "situacao";
            this.situacao.Size = new System.Drawing.Size(127, 21);
            this.situacao.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "SITUAÇÃO";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Funcionarios.Properties.Resources.Fundo_de_Tela;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Panel);
            this.MaximizeBox = false;
            this.Name = "Editar";
            this.Text = "EDIÇÃO DE FUNCIONÁRIOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ListaCadastro;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.TextBox nascimento;
        public System.Windows.Forms.TextBox sobrenome;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox situacao;
        private System.Windows.Forms.Label label7;
    }
}