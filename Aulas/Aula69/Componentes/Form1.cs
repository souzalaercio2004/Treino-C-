using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class f_Principal : Form
    {
        public  int num;
        public f_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Veiculos.Text == "") {
                MessageBox.Show("Digite um veiculo");
                tb_Veiculos.Focus();
                return;
            }
            tb_ListaVeiculos.Text += tb_Veiculos.Text + ", ";
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
            F_Veiculos f_Veiculos= new F_Veiculos(tb_ListaVeiculos.Text, this);
            f_Veiculos.ShowDialog();
        }

        private void btn_ValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());

        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_checkBox = new F_CheckBox();
            f_checkBox.Show();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();

        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }
    }
}
