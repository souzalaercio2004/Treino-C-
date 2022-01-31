﻿using System;
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
    public partial class NovoCheckedListBox : Form
    {
        public NovoCheckedListBox()
        {
            InitializeComponent();
        }

        private void NovoCheckedListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            
            MessageBox.Show(txt);

        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            /*
            clb_transportes.Items.Add("Carro", false);
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Trem", false);
            clb_transportes.Items.Add("Onibus", false);
            */

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Trem");
            tr.Add("Ônibus");
            clb_transportes.Items.AddRange(tr.ToArray());

        }

        private void btn_AddNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_novoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
        }
    }
}
