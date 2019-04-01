using Oracle.ManagedDataAccess.Client;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            l1.ResetText();
            l2.ResetText();
            l3.ResetText();
            l4.ResetText();
            l5.ResetText();
            l6.ResetText();
            l7.ResetText();
            l8.ResetText();
            l9.Text="Please choose gender";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (t1.Text == "") l1.Text = "Enter first name";
            else l1.Text = "";
        }

        private void t2_Leave(object sender, EventArgs e)
        {
            
        }

        private void t3_Leave(object sender, EventArgs e)
        {
            if (t3.Text == "") l3.Text = "Enter last name";
            else l3.Text = "";
        }

        private void t3_TextChanged(object sender, EventArgs e)
        {
            if (t3.Text == "") l3.Text = "Enter last name";
            else l3.Text = "";
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {
            if (t1.Text == "") l1.Text = "Enter first name";
            else l1.Text = "";
        }

        private void rt1_Leave(object sender, EventArgs e)
        {
            if(rt1.Text == "") l4.Text = "Enter Address";
            else l4.Text = "";
        }

        private void rt1_TextChanged(object sender, EventArgs e)
        {
            if (rt1.Text == "") l4.Text = "Enter Address";
            else l4.Text = "";
        }

        private void t4_Leave(object sender, EventArgs e)
        {
            string str = t4.Text;
            string pat = @"^([1-9]{1})(\d{9})$";
            Match result = Regex.Match(str, pat);
            if (!result.Success)
                l5.Text = "Please enter valid mobile number";
            else if (t4.Text == "")
                l5.Text = "Enter mobile";
            else l5.Text = "";
        }

        private void t4_TextChanged(object sender, EventArgs e)
        {
            string str = t4.Text;
            string pat = @"^([1-9]{1})(\d{9})$";
            Match result = Regex.Match(str, pat);
            if (!result.Success)
                l5.Text = "Please enter valid mobile number";
            else if (t4.Text == "")
                l5.Text = "Enter mobile";
            else l5.Text = "";
        }

        private void t5_TextChanged(object sender, EventArgs e)
        {
            string str = t5.Text;
            string pat = @"^([a-zA-Z]+)([@]{1})([a-zA-Z]{3,6})([\.]{1})(com|in|org|co{1})$";
            Match result = Regex.Match(str, pat);
            if (!result.Success)
                l6.Text = "Please enter valid email";
            else if (str == "")
                l6.Text = "Enter email";
            else l6.Text = "";
        }

        private void t5_Leave(object sender, EventArgs e)
        {
            string str = t5.Text;
            string pat = @"^([a-zA-Z]+)([@]{1})([a-zA-Z]{3,6})([\.]{1})(com|in|org|co{1})$";
            Match result = Regex.Match(str, pat);
            if (!result.Success)
                l6.Text = "Please enter valid email";
            else if (str == "")
                l6.Text = "Enter email";
            else l6.Text = "";
        }

        private void t6_Leave(object sender, EventArgs e)
        {
            if (t6.Text == "") l7.Text = "Please enter password";
            else l7.Text = "";
        }

        private void t6_TextChanged(object sender, EventArgs e)
        {
            if (t6.Text == "") l7.Text = "Please enter password";
            else l7.Text = "";
        }

        private void t7_TextChanged(object sender, EventArgs e)
        {
            if (t7.Text == "") l8.Text = "Please confirm password";
            else if (t7.Text != t6.Text) l8.Text = "Password does not match";
            else l8.Text = "";
        }

        private void t7_Leave(object sender, EventArgs e)
        {
            if (t7.Text == "") l8.Text = "Please confirm password";
            else if (t7.Text != t6.Text) l8.Text = "Password does not match";
            else l8.Text = "";
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            if (rb1.Checked || rb2.Checked)
                l9.ResetText();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
                    "User Id = system; Password = password");
                con.Open();
                char gender = ' ';
                if (rb1.Checked) gender = 'M';
                else if (rb2.Checked) gender = 'F';
                OracleCommand cmd = new OracleCommand("insert into newuser values('" + t1.Text + "','" +
                    t2.Text + "','" + t3.Text + "','" + gender + "','" + rt1.Text + "'," + t4.Text + ",'" + t5.Text + "','"
                    + t7.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You May Login NOW!");
                new Form1().Show();
                this.Close();
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }
        }

        private void l3_Click(object sender, EventArgs e)
        {

        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void l4_Click(object sender, EventArgs e)
        {

        }

        private void l5_Click(object sender, EventArgs e)
        {

        }

        private void l9_Click(object sender, EventArgs e)
        {

        }

        private void l8_Click(object sender, EventArgs e)
        {

        }

        private void l7_Click(object sender, EventArgs e)
        {

        }

        private void l6_Click(object sender, EventArgs e)
        {

        }
    }
}
