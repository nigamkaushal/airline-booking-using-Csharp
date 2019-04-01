using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PROJECT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader f = new StreamReader("temp.txt");
                OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
                "User Id = system; Password = password");
                con.Open();
                char tf = f.ReadLine()[0];
                char cls = f.ReadLine()[0];
                string src = f.ReadLine();
                string des = f.ReadLine();
                string date = f.ReadLine();
                int noa = int.Parse(f.ReadLine());
                int noc = int.Parse(f.ReadLine());
                int nop = noa + noc;
                f.Close();
                String query = "select F_id \"Flight ID\",F_name \"Flight Name\"," +
                    "source \"Source\",destination \"Destination\",DOT \"Date\"" +
                    ",price \"Price\" from flight" +
                    " where type_flight='" + tf + "'" +
                    " AND class='" + cls + "' AND source ='" + src + "' AND destination='"
                    + des + "' AND dot='" + date + "' AND no_of_seats>=" + nop;
                OracleDataAdapter da = new OracleDataAdapter(query, con);
                DataSet DS = new DataSet();
                da.Fill(DS);
                DataSet MyData = DS;
                dataGridView1.DataSource = DS.Tables[0].DefaultView;
                dataGridView1.DataBindings.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Close();
        }
    }
}
