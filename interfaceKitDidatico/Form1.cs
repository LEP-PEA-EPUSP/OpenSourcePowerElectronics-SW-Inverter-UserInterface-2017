using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceKitDidatico
{
    public partial class PaginaInicial : Form
    {
       
        int contador;
        int tamanho_palavra = 10;
        public static byte[] buffer = new byte[10];
        int tamanho_max_buffer_dados = 1024;
        public static byte[] bufferdados = new byte[1024];
        byte buffer0;
        public PaginaInicial()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Write(buffer, 0, tamanho_palavra);
            if (buffer[0] == 3)
            {
                timer1.Enabled = false;
                serialPort1.Read(bufferdados, 0, tamanho_palavra);
                buffer[0] = buffer0;
            }
            if (buffer[0] != 3) buffer0 = buffer[0];
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            //MessageBox.Show("Error");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iniciarVerificacao_Click(object sender, EventArgs e)
        {
            textBox9.Text = "Verificando";
            comunicacao();
        }
        
        public void comunicacao()
        {
            //repete 10x e diz que foi bem sucedido
            contador = 1;
            while (contador < 11)
            {
                textBox6.Text = contador.ToString();
                //Teste de Comunicacao
                int i;
                for (i = 0; i < tamanho_palavra; i++)
                {
                    buffer[i] = 0x41;
                }

                byte[] buffer2 = new byte[tamanho_palavra];
                serialPort1.Write(buffer, 0, tamanho_palavra);
                serialPort1.Read(buffer2, 0, tamanho_palavra);

                string[] texto = new string[tamanho_palavra];
                for (i = 0; i < tamanho_palavra; i++)
                {
                    texto[i] = buffer[i].ToString();
                }

                textBox4.Text = texto[0] + texto[1] + texto[2] + texto[3] + texto[4] + texto[5] + texto[6] + texto[7] + texto[8];


                string[] texto2 = new string[tamanho_palavra];
                for (i = 0; i < tamanho_palavra; i++)
                {
                    texto2[i] = buffer[i].ToString();
                }

                textBox5.Text = texto2[0] + texto2[1] + texto2[2] + texto2[3] + texto2[4] + texto2[5] + texto2[6] + texto2[7] + texto2[8];

                if (contador == 10)
                {
                    textBox9.Text = "Verificacao com sucesso";
                    timer1.Enabled = true;
                    tela1 tela = new tela1(this, tamanho_palavra);
                    Enabled = false;
                    tela.Show();
                }
                contador++;
            }
        }
    }
}
