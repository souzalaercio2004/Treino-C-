using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm61
{
    public partial class FormAula61 : Form
    {
        public FormAula61()
        {
            InitializeComponent();
        }

        private void FormAula61_Load(object sender, EventArgs e)
        {

        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            lb_texto.Text = tb_texto.Text;
        }
    }
}
