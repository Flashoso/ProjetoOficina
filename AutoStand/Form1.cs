using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGC_Click(object sender, EventArgs e)
        {
            new FormGC().Show();
            this.Hide();
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            new FormGO().Show();
            this.Hide();
        }

        private void labelGA_Click(object sender, EventArgs e)
        {
            new FormGA().Show();
            this.Hide();
        }

        private void buttonGA_Click(object sender, EventArgs e)
        {
            new FormGA().Show();
            this.Hide();
        }

        private void labelGV_Click(object sender, EventArgs e)
        {
            new FormGV().Show();
            this.Hide();
        }

        private void buttonGV_Click(object sender, EventArgs e)
        {
            new FormGV().Show();
            this.Hide();
        }
    }
}
