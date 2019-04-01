using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }
    }
}
