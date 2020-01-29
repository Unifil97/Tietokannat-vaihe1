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
    public partial class Datagrid : Form
    {
        SqlConnection myConnection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; " +
        "Initial Catalog = forms tietokanta; Integrated Security = True; " +
        "Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private Form1 form1;

        public Datagrid(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
       
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            int rowID = ((int)dataGridView1.CurrentRow.Cells[0].Value);
            SqlCommand com2 = new SqlCommand("Delete from Nimet where Id= @Id", myConnection);
            try
            {
                
                myConnection.Open();        

            }
            catch (Exception es)
            {
                
                Console.WriteLine(es.ToString());
            }
            SqlParameter myParam = new SqlParameter("@Id",rowID);
            com2.Parameters.Add(myParam);
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            com2.ExecuteNonQuery();
            myConnection.Close();
        }
        
        private void Datagrid_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Nimet", myConnection);
            try
            {
                cmd.ExecuteNonQuery();
                myConnection.Open();
               

            }
            catch (Exception es)
            {
                
                Console.WriteLine(es.ToString());
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();

        }
    }
}
