using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormListView
{
    public partial class lb_produtos : Form
    {
        public lb_produtos()
        {
            InitializeComponent();
        }

        private void limpar() {
            tb_id.Clear();
            tb_produto.Clear();
            tb_quantidade.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }

        private void obter() {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_quantidade.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedItems.Count > 0)
            {

                obter();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            string[] pr = new string[4];

            if (tb_id.Text == "") {
                MessageBox.Show("Id não pode ser vazio");
                tb_id.Focus();
                return;
            }

            if (tb_produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio");
                tb_id.Focus();
                return;
            }

            if (tb_quantidade.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazio");
                tb_id.Focus();
                return;
            }

            if (tb_preco.Text == "")
            {
                MessageBox.Show("Preco não pode ser vazio");
                tb_id.Focus();
                return;
            }

            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_quantidade.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_produtos.Items.Add(l);
            limpar();

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            obter();
        }
    }
}
