using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios.Telas
{
    public partial class MenuHashiko : Form
    {
        public MenuHashiko()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel.Location = new Point((this.Size.Width / 2) - (this.Panel.Size.Width / 2), (this.Size.Height / 2) - (this.Panel.Size.Height / 2));
        }

        private void cadastrofuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu cadastrofuncionario = new Menu();
            cadastrofuncionario.Closed += (s, args) => this.Close();
            cadastrofuncionario.Show();
        }
    }
}
