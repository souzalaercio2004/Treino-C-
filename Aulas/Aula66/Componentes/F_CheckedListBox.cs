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
    public partial class F_CheckedListBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();


        public F_CheckedListBox()
        {
            InitializeComponent();
            transp.Add(cb_Aviao);
            transp.Add(cb_Carro);
            transp.Add(cb_Navio);
            transp.Add(cb_Onibus);
            transp.Add(cbx_Patinete);

        }
        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            String txt = "";

            foreach (CheckBox t in transp) {
                if (t.Checked) txt += t.Text+", ";
            }

            MessageBox.Show(txt);
        }

        private void cbx_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Patinete.Checked) {
                MessageBox.Show("Patinete Marcada");
            }
        }
    }
}
