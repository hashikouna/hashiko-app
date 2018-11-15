using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcionarios.Banco_de_Dados;

namespace Funcionarios
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
            Lista();
        }
        private void editar(Func funcionario)
        {
            Ligamento ligar = new Ligamento();
            funcionario.id = Convert.ToInt32(id.Text);
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

            ligar.Editar(funcionario);
            MessageBox.Show("Editado com Sucesso!!");
            Lista();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel.Location = new Point((this.Size.Width / 2) - (this.Panel.Size.Width / 2), (this.Size.Height / 2) - (this.Panel.Size.Height / 2));
        }
        private void Lista()
        {
            Ligamento ligar = new Ligamento();
            ListaCadastro.DataSource = ligar.Listar();
        }

        private void ListaCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = ListaCadastro.CurrentRow.Cells[0].Value.ToString();
            nome.Text = ListaCadastro.CurrentRow.Cells[1].Value.ToString();
            sobrenome.Text = ListaCadastro.CurrentRow.Cells[2].Value.ToString();
            cpf.Text = ListaCadastro.CurrentRow.Cells[3].Value.ToString();
            sexo.Text = ListaCadastro.CurrentRow.Cells[4].Value.ToString();
            nascimento.Text = ListaCadastro.CurrentRow.Cells[5].Value.ToString();
            email.Text = ListaCadastro.CurrentRow.Cells[6].Value.ToString();
            celular.Text = ListaCadastro.CurrentRow.Cells[7].Value.ToString();
            rua.Text = ListaCadastro.CurrentRow.Cells[8].Value.ToString();
            numero.Text = ListaCadastro.CurrentRow.Cells[9].Value.ToString();
            bairro.Text = ListaCadastro.CurrentRow.Cells[10].Value.ToString();
            cidade.Text = ListaCadastro.CurrentRow.Cells[11].Value.ToString();
            estado.Text = ListaCadastro.CurrentRow.Cells[12].Value.ToString();
            cep.Text = ListaCadastro.CurrentRow.Cells[13].Value.ToString();
            situacao.Text = ListaCadastro.CurrentRow.Cells[14].Value.ToString();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            Func funcionario = new Func();
            editar(funcionario);
        }
    }
}
