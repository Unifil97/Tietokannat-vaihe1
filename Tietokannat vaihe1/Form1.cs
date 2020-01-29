using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tietokannat_vaihe1
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection=new SqlConnection ("Data Source = (localdb)\\MSSQLLocalDB; " +
            "Initial Catalog = forms tietokanta; Integrated Security = True; " +
            "Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'forms_tietokantaDataSet.Nimet' table. You can move, or remove it, as needed.
            //this.nimetTableAdapter.Fill(this.forms_tietokantaDataSet.Nimet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
               
            }
            catch (Exception es)
            {
                Console.WriteLine(es.ToString());
            }
            SqlCommand query  = new SqlCommand(
            "INSERT INTO Nimet(Nimi,Ryhma_Id)VALUES ('"+ textBox1.Text+"',"+comboBox1.SelectedValue+")", myConnection);
            query.ExecuteNonQuery();
            textBox1.Clear();
            myConnection.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            using(var datagrid = new Datagrid(this))
           
            {
               
                datagrid.ShowDialog();
            
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            List<Ryhma> ryhlista = new List<Ryhma>();
            SqlCommand query1 = new SqlCommand("Select*from Opiskelijaryhma", myConnection);
            SqlDataReader dr = query1.ExecuteReader();

            while (dr.Read())
            {
                Ryhma Ryhmaoppi = new Ryhma();
                Ryhmaoppi.Id1 = (int)dr["Id"];
                Ryhmaoppi.Nimi1 = (string)dr["Nimi"];
                ryhlista.Add(Ryhmaoppi);

            }
           
            comboBox1.DataSource = ryhlista;
            comboBox1.DisplayMember = "Nimi1";
            comboBox1.ValueMember = "Id1";
            myConnection.Close();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}   
