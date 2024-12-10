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
    public partial class OpenSV : Form
    {
        public OpenSV()
        {
            InitializeComponent();
        }

        private void OpenSV_Load(object sender, EventArgs e)
        {
            //làm dữ liệu. (Không cần làm nếu sau này có kết nối với CSDL
            List<SinhVien> sv = new List<SinhVien>()
            {
                new SinhVien(1, "Phùng"),
                new SinhVien(2, "Quang"),
                new SinhVien(3, "Tú"),
                new SinhVien(4, "Đẳng sờ cấp"),
            };
            //B2: Load dữ liệu lên trên Datagridview
            dataGridView1.DataSource = sv;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac chan muon thoat", 
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
