using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace WinFormOrder
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Order order1 = new Order();
            DetailWin detailWin = new DetailWin();
            detailWin.Show();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            DetailWin detailWin = new DetailWin();
            detailWin.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DetailWin detailWin1 = new DetailWin();
        }
    }
}
