using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace interfaceKitDidatico
{
    public partial class abrirArquivoCSV : Form
    {
        public abrirArquivoCSV()
        {
            InitializeComponent();
        }

        private void button_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog1.FileName;
            }
        }

        //O usuario deve escrever na caixa de texto ao lado do botao "Planilha" o nome EXATO da planilha em que estao os dados
        //Lembrando que em um arquivo .csv eh possivel guardar mais de uma planilha


        private void button_sheet_Click(object sender, EventArgs e)
        {
            string PathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_path.Text + ";Extended Properties=\"Excel 8.0; HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PathConn);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBox_sheet.Text + "$]", conn);

            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
