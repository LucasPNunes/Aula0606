using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public SqlConnection conexao;
        public List<Contato> contatos;
        public Form1()
        {

            InitializeComponent();
            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aula;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contatos;
            dataGridView1.Refresh();
            try
            {
                conexao.Open();
                Console.WriteLine("Conexao aberta kkkk");
                var selectCmd = conexao.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Contato";

                SqlDataReader leitorDados = selectCmd.ExecuteReader();

                while (leitorDados.Read())
                {

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {   

                conexao.Close();
                Console.WriteLine("Conexao fechada kkkk");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}
