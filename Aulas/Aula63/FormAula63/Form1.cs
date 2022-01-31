using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAula63
{
    public partial class F_Principal : Form
    {
        public F_Principal(string v)
        {
            InitializeComponent();
            F_Veiculos f_Veiculos = new F_Veiculos(v);
            f_Veiculos.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_Veiculos.Text == "") {
                MessageBox.Show("Digite um veiculo");
                tb_Veiculos.Focus();
                return;
            }
            tb_ListaVeiculos.Text+= tb_Veiculos.Text+", ";
            tb_Veiculos.Clear();
            tb_Veiculos.Focus();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_ListaVeiculos.Clear();
            tb_Veiculos.Clear();
            tb_Veiculos.Focus();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_ListaVeiculos.Text);
            f_Veiculos.ShowDialog();
        }
    }
}
