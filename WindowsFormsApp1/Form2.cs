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
    public partial class Form2 : Form
    {
        Form1 home;
        public Form2(Form1 _home)
        {
            home = _home;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.contatos.Add(new Contato(textBox1.Text, textBox2.Text));
            var selectCmd = home.conexao.CreateCommand();
            selectCmd.CommandText = $"INSERT INTO Contato (Nome, Telefone) VALUES ({textBox1.Text}, {textBox2.Text})";
            SqlDataReader leitorDados = selectCmd.ExecuteReader();
            home.dataGridView1.DataSource = null;
            home.dataGridView1.DataSource = home.contatos;
            home.dataGridView1.Refresh();
            Close();
        }
    }
}
