using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tắt form không muốn
            //1. Tắt hẳn;  2. Ẩn
            this.Hide();

            //Open 1 form mới
            OpenSV frmsv = new OpenSV();
            frmsv.ShowDialog();
        }

        private void stripOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
