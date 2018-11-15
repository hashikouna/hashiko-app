namespace Funcionarios
{
    partial class Listar
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
            this.button1 = new System.Windows.Forms.Button();
            this.filtrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filtro = new System.Windows.Forms.ComboBox();
            this.voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaCadastro = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.button1);
            this.Panel.Controls.Add(this.filtrar);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.filtro);
            this.Panel.Controls.Add(this.voltar);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.ListaCadastro);
            this.Panel.Controls.Add(this.label21);
            this.Panel.Controls.Add(this.label13);
            this.Panel.Location = new System.Drawing.Point(32, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1044, 622);
            this.Panel.TabIndex = 7;
            this.Panel.TabStop = true;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(834, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 40;
            this.button1.Text = "RESETAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtrar
            // 
            this.filtrar.BackColor = System.Drawing.Color.Gold;
            this.filtrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrar.Location = new System.Drawing.Point(703, 582);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(90, 27);
            this.filtrar.TabIndex = 39;
            this.filtrar.Text = "FILTRAR";
            this.filtrar.UseVisualStyleBackColor = false;
            this.filtrar.Click += new System.EventHandler(this.filtrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "FILTROS";
            // 
            // filtro
            // 
            this.filtro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro.FormattingEnabled = true;
            this.filtro.Items.AddRange(new object[] {
            "ATIVO",
            "FERIAS",
            "ATESTADO",
            "DEMITIDO"});
            this.filtro.Location = new System.Drawing.Point(548, 584);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(121, 24);
            this.filtro.TabIndex = 37;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.voltar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(12, 582);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(90, 27);
            this.voltar.TabIndex = 36;
            this.voltar.Text = "VOLTAR";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "QUADRO DE FUNCIONÁRIOS";
            // 
            // ListaCadastro
            // 
            this.ListaCadastro.AllowUserToAddRows = false;
            this.ListaCadastro.AllowUserToDeleteRows = false;
            this.ListaCadastro.AllowUserToResizeRows = false;
            this.ListaCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCadastro.Location = new System.Drawing.Point(12, 46);
            this.ListaCadastro.Name = "ListaCadastro";
            this.ListaCadastro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.ListaCadastro.Size = new System.Drawing.Size(1019, 495);
            this.ListaCadastro.TabIndex = 34;
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
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Funcionarios.Properties.Resources.Fundo_de_Tela;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Panel);
            this.MaximizeBox = false;
            this.Name = "Listar";
            this.Text = "QUADRO DE FUNCIONÁRIOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.ComboBox filtro;
        private System.Windows.Forms.Button filtrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ListaCadastro;
        private System.Windows.Forms.Button button1;
    }
}