using Oracle.ManagedDataAccess.Client;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = textBox1.Text;
            string pass = textBox2.Text;
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
                "User Id = system; Password = password");
            con.Open();
            string query = "select * from newuser where email='" + uid + "' AND password='" + pass + "'";
            OracleDataAdapter da = new OracleDataAdapter(query, con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            if (ds.Rows.Count > 0)
            {
                new Form7().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserID/Password");
            }
            con.Close();
        }
    }
}
