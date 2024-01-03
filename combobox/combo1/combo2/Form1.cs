using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            lbResult.Items.Add(cbTitle.Text+" " + tbFirstName.Text +" "+ tbLatName.Text);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
