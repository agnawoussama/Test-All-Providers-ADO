using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;


namespace Test_All_Providers_ADO
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        OleDbDataReader olrd;

        OdbcConnection odbconn;
        OdbcCommand odbcmd;
        OdbcDataReader odbcrd;

        SqlDataReader dr;
        DataTable dt = new DataTable();
         
        public Form1()
        {
            InitializeComponent();
        }    


        private void sqlClient_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stock;Integrated Security=True");
            string command = "SELECT * FROM client";
            cmd = new SqlCommand(command, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void oledb_Click(object sender, EventArgs e)
        {
            OleDbConnection oledb = new OleDbConnection(@"Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog=stock");
            string command = "SELECT * FROM produit";
            OleDbCommand oledbcmd = new OleDbCommand(command, oledb);
            oledb.Open();
            olrd = oledbcmd.ExecuteReader();
            dt.Load(olrd);
            dataGridView1.DataSource = dt;

            oledb.Close();
        }

        private void odbc_Click(object sender, EventArgs e)
        {
            
            odbconn = new OdbcConnection(@"Dsn=localhost;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=OUSSAMA;database=stock");
            string command = "select * from produit where idClient=2";
            odbcmd = new OdbcCommand(command, odbconn);
            odbconn.Open();
            odbcrd = odbcmd.ExecuteReader();
            dt.Load(odbcrd);
            dataGridView1.DataSource = dt;

            odbconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=localhost;Initial Catalog=stock;Integrated Security=True");
            string command = "select * from client where IdClient = @id_Client";
            cmd = new SqlCommand(command, con);         
            cmd.Parameters.AddWithValue("id_Client", textBox1.Text);
            con.Open();
            DataTable DT = (DataTable)dataGridView1.DataSource;
            if (DT != null)
                DT.Clear();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            

            con.Close();
        }
    }
}
