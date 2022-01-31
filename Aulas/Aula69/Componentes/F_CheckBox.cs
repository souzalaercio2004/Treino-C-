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
    public partial class F_CheckBox : Form
    {
        F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
        public F_CheckBox()
        {
            InitializeComponent();
        }

        private void F_CheckBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_OpenCheckedListBox_Click(object sender, EventArgs e)
        {
            f_CheckedListBox.ShowDialog();
        }
    }
}
