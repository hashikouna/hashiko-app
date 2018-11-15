using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Funcionarios.Banco_de_Dados;

namespace Funcionarios
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel.Location = new Point((this.Size.Width / 2) - (this.Panel.Size.Width / 2), (this.Size.Height / 2) - (this.Panel.Size.Height / 2));
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //salvar
        private void Salvar(Func funcionario)
        {
            Ligamento ligar = new Ligamento();
            funcionario.name = nome.Text;
            funcionario.lastname = sobrenome.Text;
            funcionario.cpf = cpf.Text;
            funcionario.sex = sexo.Text;
            funcionario.birth_day = nascimento.Text;
            funcionario.email = email.Text;
            funcionario.phone = celular.Text;
            funcionario.street = rua.Text;
            funcionario.number = numero.Text;
            funcionario.district = bairro.Text;
            funcionario.city = cidade.Text;
            funcionario.state = estado.Text;
            funcionario.zipcode = cep.Text;
            funcionario.situation = situacao.Text;

            ligar.Salvar(funcionario);
            MessageBox.Show("Salvo com Sucesso!!");
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Func funcionario = new Func();
            Salvar(funcionario);
        }
    }
}
