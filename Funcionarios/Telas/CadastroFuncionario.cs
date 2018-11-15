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
            nome.CharacterCasing = CharacterCasing.Upper;
            sobrenome.CharacterCasing = CharacterCasing.Upper;
            cpf.CharacterCasing = CharacterCasing.Upper;
            nascimento.CharacterCasing = CharacterCasing.Upper;
            email.CharacterCasing = CharacterCasing.Upper;
            celular.CharacterCasing = CharacterCasing.Upper;
            rua.CharacterCasing = CharacterCasing.Upper;
            numero.CharacterCasing = CharacterCasing.Upper;
            bairro.CharacterCasing = CharacterCasing.Upper;
            cidade.CharacterCasing = CharacterCasing.Upper;
            cep.CharacterCasing = CharacterCasing.Upper;
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
            Menu menufuncionario = new Menu();
            menufuncionario.Closed += (s, args) => this.Close();
            menufuncionario.Show();
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
            nome.Clear();
            sobrenome.Clear();
            cpf.Clear();
            sexo.Text = string.Empty;
            nascimento.Clear();
            email.Clear();
            celular.Clear();
            rua.Clear();
            numero.Clear();
            bairro.Clear();
            cidade.Clear();
            estado.Text = string.Empty;
            cep.Clear();
            situacao.Text = string.Empty;
        }
    }
}
