using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.Show();
        }

        private void listar_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar();
            listar.Show();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel.Location = new Point((this.Size.Width / 2) - (this.Panel.Size.Width / 2), (this.Size.Height / 2) - (this.Panel.Size.Height / 2));
        }
    }
}
