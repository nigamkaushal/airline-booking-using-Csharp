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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream("resdetails.txt", FileMode.OpenOrCreate, FileAccess.Write);
                f.Close();
                StreamWriter fw = new StreamWriter("resdetails.txt");
                string fno = textBox1.Text;
                long cardno = long.Parse(textBox2.Text);
                string holdername = textBox3.Text;
                string expdate = textBox4.Text;
                fw.WriteLine(fno);
                fw.WriteLine(cardno);
                fw.WriteLine(holdername);
                fw.WriteLine(expdate);
                Random rand = new Random();
                int r = rand.Next(10000, 99999);
                fw.WriteLine(r);
                fw.Close();
                MessageBox.Show("Reservation Complete!\nPlease note your reference " +
                    "no: " + r);
                this.Close();
                new Form7().Show();
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Close();
        }
    }
}
