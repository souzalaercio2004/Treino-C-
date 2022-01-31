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
    public partial class F_FilhoCheckBox : Form
    {
        public F_CheckedListBox f_cb;
            public F_FilhoCheckBox()
        {
            
            InitializeComponent();
            try
            {
                f_cb = Application.OpenForms["F_CheckedListBox"] as F_CheckedListBox;
                cb_Carro.Checked = f_cb.cb_Carro.Checked;
                cb_Aviao.Checked = f_cb.cb_Aviao.Checked;
                cb_Navio.Checked = f_cb.cb_Navio.Checked;
                cb_Onibus.Checked = f_cb.cb_Onibus.Checked;
            }
            catch 
            {
                MessageBox.Show("Erro ao abrir formulário");
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cb_Carro_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_Carro.Checked = cb_Carro.Checked;
        }

        private void cb_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_Aviao.Checked = cb_Aviao.Checked;
        }

        private void cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            
            f_cb.cb_Navio.Checked = cb_Navio.Checked;
        }

        private void cb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_Onibus.Checked = cb_Onibus.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_cb = Application.OpenForms["F_CheckedListBox"] as F_CheckedListBox; 
            f_cb.ShowDialog();
        }
    }
}
