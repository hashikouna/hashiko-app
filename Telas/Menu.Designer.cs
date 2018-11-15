namespace Funcionarios
{
    partial class Menu
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
            this.listar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.listar);
            this.Panel.Controls.Add(this.button3);
            this.Panel.Controls.Add(this.editar);
            this.Panel.Controls.Add(this.cadastrar);
            this.Panel.Controls.Add(this.label21);
            this.Panel.Controls.Add(this.label13);
            this.Panel.Location = new System.Drawing.Point(384, 90);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(583, 548);
            this.Panel.TabIndex = 6;
            this.Panel.TabStop = true;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // listar
            // 
            this.listar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listar.Location = new System.Drawing.Point(172, 342);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(210, 93);
            this.listar.TabIndex = 37;
            this.listar.Text = "FUNCIONÁRIOS";
            this.listar.UseVisualStyleBackColor = false;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(40, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 39);
            this.button3.TabIndex = 36;
            this.button3.Text = "INICIO";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.Location = new System.Drawing.Point(172, 182);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(210, 93);
            this.editar.TabIndex = 35;
            this.editar.Text = "EDITAR";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(172, 29);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(210, 93);
            this.cadastrar.TabIndex = 34;
            this.cadastrar.Text = "CADASTRAR";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Funcionarios.Properties.Resources.Fundo_de_Tela;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Panel);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "MENU FUNCIONÁRIOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button listar;
    }
}