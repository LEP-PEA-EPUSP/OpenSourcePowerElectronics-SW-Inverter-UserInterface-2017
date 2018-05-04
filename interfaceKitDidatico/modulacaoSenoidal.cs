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
    public partial class modulacaoSenoidal : Form
    {
        private PaginaInicial parent;
        public int tamanho_palavra;
        tela1 tela1;
        public modulacaoSenoidal(PaginaInicial parent, tela1 tela1, int tamanho_palavra)
        {
            this.parent = parent;
            this.tela1 = tela1;
            InitializeComponent();
            this.tamanho_palavra = tamanho_palavra;
        }

        private void button_gerar_csv_Click(object sender, EventArgs e)
        {
            Form formGerarAquivoCSV = new gerarArquivoCSV();
            formGerarAquivoCSV.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Ligar Inversor")
            {
                button1.Text = "Desligar Inversor";
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.Text = "Ligar Inversor";
                button1.BackColor = Color.Lime;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pegar os dados 
            byte[] buffer = new byte[tamanho_palavra];

            //opcao de modulacao senoidal dois niveis - byte 0
            buffer[0] = 1;

            //calculo PSC - bytes 1 e 2
            buffer[1] = 0x00;

            if (comboBox1.Text == "1200")
            {
                buffer[2] = 0x88;
            }
            if (comboBox1.Text == "1800")
            {
                buffer[2] = 0x2E;
            }

            // calculo ARR - bytes 3 e 4 -- setar em 2000
            //buffer[3] = 0x07;
            //buffer[4] = 0xD0;
            buffer[3] = 0x04;
            buffer[4] = 0x00;

            // fator multiplcador da senoide - byte 5
            if (comboBox3.Text == "60Hz") buffer[5] = 0x01;
            if (comboBox3.Text == "120Hz") buffer[5] = 0x02;

            // amplitude da senoide - byte 6

            if (comboBox2.Text == "0%")
            {
                buffer[6] = 0x00;
            }
            if (comboBox2.Text == "5%")
            {
                buffer[6] = 0x05;
            }
            if (comboBox2.Text == "10%")
            {
                buffer[6] = 0x0A;
            }
            if (comboBox2.Text == "15%")
            {
                buffer[6] = 0x0F;
            }
            if (comboBox2.Text == "20%")
            {
                buffer[6] = 0x14;
            }
            if (comboBox2.Text == "25%")
            {
                buffer[6] = 0x19;
            }
            if (comboBox2.Text == "30%")
            {
                buffer[6] = 0x1E;
            }
            if (comboBox2.Text == "35%")
            {
                buffer[6] = 0x23;
            }
            if (comboBox2.Text == "40%")
            {
                buffer[6] = 0x28;
            }
            if (comboBox2.Text == "45%")
            {
                buffer[6] = 0x2D;
            }
            if (comboBox2.Text == "50%")
            {
                buffer[6] = 0x32;
            }
            if (comboBox2.Text == "55%")
            {
                buffer[6] = 0x37;
            }
            if (comboBox2.Text == "60%")
            {
                buffer[6] = 0x3C;
            }
            if (comboBox2.Text == "65%")
            {
                buffer[6] = 0x41;
            }
            if (comboBox2.Text == "70%")
            {
                buffer[6] = 0x046;
            }
            if (comboBox2.Text == "75%")
            {
                buffer[6] = 0x4B;
            }
            if (comboBox2.Text == "80%")
            {
                buffer[6] = 0x50;
            }
            if (comboBox2.Text == "85%")
            {
                buffer[6] = 0x55;
            }
            if (comboBox2.Text == "90%")
            {
                buffer[6] = 0x5A;
            }
            if (comboBox2.Text == "95%")
            {
                buffer[6] = 0x5F;
            }
            if (comboBox2.Text == "100%")
            {
                buffer[6] = 0x64;
            }
            if (comboBox2.Text == "105%")
            {
                buffer[6] = 0x69;
            }
            if (comboBox2.Text == "110%")
            {
                buffer[6] = 0x6E;
            }

            // calculo CCR - bytes 7 e 8 
            buffer[7] = 0x00;
            buffer[8] = 0x00;

            //Ligar/Desligar inversor
            if (button2.Text == "Ligar Inversor") //inversor desligado
            {
                buffer[9] = 0x00;
            }
            if (button2.Text == "Desligar Inversor") //inversor ligado
            {
                buffer[9] = 0x01;
            }


            //textBox4.Text = buffer
            int i = 0;
            for (i = 0; i < tamanho_palavra; i++)
            {
                PaginaInicial.buffer[i] = buffer[i];
            }
        }

        private void modulacaoSenoidal_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela1.Enabled = true;
        }
    }
}
