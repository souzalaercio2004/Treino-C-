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
    
    public partial class F_Veiculos : Form
    {

        f_Principal fp;
        public F_Veiculos(string v, f_Principal f)
        {
            InitializeComponent();
            tb_ListaVeiculos.Text = v;
            fp = f;
            f.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_ListaVeiculos.Text = tb_ListaVeiculos.Text;
        }
    }
}
