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
using MySql.Data.MySqlClient;

namespace Funcionarios
{
    public partial class Listar : Form
    {
        DataSet ds = new DataSet();
        public Listar()
        {
            InitializeComponent();
            Lista();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel.Location = new Point((this.Size.Width / 2) - (this.Panel.Size.Width / 2), (this.Size.Height / 2) - (this.Panel.Size.Height / 2));
        }

        //listar
        private void Lista()
        {
            Ligamento ligar = new Ligamento();
            ListaCadastro.DataSource = ligar.Listarlista();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Menu menufuncionario = new Menu();
            menufuncionario.Closed += (s, args) => this.Close();
            menufuncionario.Show();
        }

        private void filtrar_Click(object sender, EventArgs e)
        { 
            if (filtro.Text == "ATIVO")
            {
                Ligamento ligar = new Ligamento();
                ListaCadastro.DataSource = ligar.FiltroAtivos();
            }
            else if (filtro.Text == "FERIAS")
            {
                Ligamento ligar = new Ligamento();
                ListaCadastro.DataSource = ligar.FiltroFerias();
            }
            else if (filtro.Text == "ATESTADO")
            {
                Ligamento ligar = new Ligamento();
                ListaCadastro.DataSource = ligar.FiltroAtestado();
            }
            else if (filtro.Text == "DEMITIDO")
            {
                Ligamento ligar = new Ligamento();
                ListaCadastro.DataSource = ligar.FiltroDemitido();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista();
        }
    }
}
