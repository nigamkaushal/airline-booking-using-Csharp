using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fno = textBox1.Text;
                string rno = textBox2.Text;
                MessageBox.Show("Cancellled Succesfully!");
                FileStream f = new FileStream("candetails.txt", FileMode.OpenOrCreate);
                f.Close();
                StreamWriter fw = new StreamWriter("candetails.txt", true);
                fw.WriteLine(fno);
                fw.WriteLine(rno);
                fw.WriteLine("\n");
                fw.Close();
                new Form7().Show();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
