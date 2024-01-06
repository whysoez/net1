using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bchuyenphai_Click(object sender, EventArgs e)
        {
            lbphai.Items.Add(lbtrai.SelectedItem);
            lbtrai.Items.Remove(lbtrai.SelectedItem);
        }

        private void bchuyentrai_Click(object sender, EventArgs e)
        {
            lbtrai.Items.Add(lbphai.SelectedItem);
            lbphai.Items.Remove(lbphai.SelectedItem);
        }

        private void bchuyenphaihet_Click(object sender, EventArgs e)
        {
            lbphai.Items.AddRange(lbtrai.Items);
            lbtrai.Items.Clear();
        }

        private void bchuyentraihet_Click(object sender, EventArgs e)
        {
            lbtrai.Items.AddRange(lbphai.Items);
            lbphai.Items.Clear();
        }
    }
}
