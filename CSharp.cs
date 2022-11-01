using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {   // TIPO STRING
                string mysqlClientString = "server = localhost; user id = root; database = lista_compras";
                // PODE CRIAR UMA VARIÁVEL EM CIMA DA FUNÇÃO
                MySqlConnection conn = new MySqlConnection(mysqlClientString);
                //VÍNCULO COM BANCO
                conn.Open();
                // RETORNA DENTRO UMA TABELA
                DataTable dt = new DataTable();
                //BUSCA OS DADOS
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM acomprar", conn);
                // FILTRADO
                da.Fill(dt);
                // COLOCAR NO BLOCO
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Verifique os parâmetros");

            }
        }
    }
}