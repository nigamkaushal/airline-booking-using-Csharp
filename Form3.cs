using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROJECT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("temp.txt",FileMode.OpenOrCreate);
            char tf=' ', cls=' ';
            if (rb1.Checked)
                tf = 'D';
            else if (rb2.Checked)
                tf = 'I';
            if (lb1.SelectedIndex == 0)
                cls = 'E';
            else if (lb1.SelectedIndex == 1)
                cls = 'B';
            string src = cb1.SelectedItem.ToString();
            string des = cb2.SelectedItem.ToString();
            string date = dtp1.Value.ToLongDateString().ToString();
            int no_of_adults = int.Parse(cb3.SelectedItem.ToString());
            int no_of_child = int.Parse(cb4.SelectedItem.ToString());
            f.Close();
            StreamWriter f1 = new StreamWriter("temp.txt");
            f1.WriteLine(tf);
            f1.WriteLine(cls);
            f1.WriteLine(src);
            f1.WriteLine(des);
            f1.WriteLine(date);
            f1.WriteLine(no_of_adults);
            f1.WriteLine(no_of_child);
            f1.Close();
            new Form4().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Close();
        }
    }
}
