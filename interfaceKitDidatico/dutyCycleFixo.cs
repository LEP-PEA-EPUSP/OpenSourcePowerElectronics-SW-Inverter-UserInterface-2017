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
    public partial class dutyCycleFixo : Form
    {
        private PaginaInicial parent;
        private tela1 tela1;
        public int tamanho_palavra;
        public dutyCycleFixo(PaginaInicial parent,tela1 tela1, int tamanho_palavra)
        {
            this.parent = parent;
            this.tela1 = tela1;
            this.tamanho_palavra = tamanho_palavra;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pegar os dados 
            byte[] buffer = new byte[tamanho_palavra];

            //opcao de duty cycle fixo - byte 0
            buffer[0] = 0;

            //calculo PSC - bytes 1 e 2
            buffer[1] = 0x00;

            if (freqChaveamento.Text == "1200")
            {
                buffer[2] = 0x45;
            }
            if (freqChaveamento.Text == "2400")
            {
                buffer[2] = 0x22;
            }
            if (freqChaveamento.Text == "4800")
            {
                buffer[2] = 0x11;
            }
            if (freqChaveamento.Text == "9600")
            {
                buffer[2] = 0x08;
            }


            // calculo ARR - bytes 3 e 4 -- setar em 2000
            buffer[3] = 0x07;
            buffer[4] = 0xD0;

            // fator multiplcador da senoide - byte 5
            buffer[5] = 0x00;

            // amplitude da senoide - byte 6
            buffer[6] = 0x01;

            // calculo CCR - bytes 7 e 8 
            if (dutyCycle.SelectedIndex == 0) //0% de duty cycle 
            {
                buffer[7] = 0x00;
                buffer[8] = 0x00;
            }
            if (dutyCycle.SelectedIndex == 1) //10% de duty cycle CCR = 200 
            {
                buffer[7] = 0x00;
                buffer[8] = 0xC8;
            }
            if (dutyCycle.SelectedIndex == 2) //15% de duty cycle CCR = 300
            {
                buffer[7] = 0x01;
                buffer[8] = 0x2C;
            }
            if (dutyCycle.SelectedIndex == 3) //20% de duty cycle CCR = 400
            {
                buffer[7] = 0x01;
                buffer[8] = 0x90;
            }
            if (dutyCycle.SelectedIndex == 4) //25% de duty cycle CCR = 500
            {
                buffer[7] = 0x01;
                buffer[8] = 0xF4;
            }
            if (dutyCycle.SelectedIndex == 5) //30% de duty cycle CCR = 600
            {
                buffer[7] = 0x02;
                buffer[8] = 0x58;
            }
            if (dutyCycle.SelectedIndex == 6) //35% de duty cycle CCR = 700
            {
                buffer[7] = 0x02;
                buffer[8] = 0xBC;
            }
            if (dutyCycle.SelectedIndex == 7) //40% de duty cycle CCR = 800
            {
                buffer[7] = 0x03;
                buffer[8] = 0x20;
            }
            if (dutyCycle.SelectedIndex == 8) //45% de duty cycle CCR = 900
            {
                buffer[7] = 0x03;
                buffer[8] = 0x84;
            }
            if (dutyCycle.SelectedIndex == 9) //50% de duty cycle CCR = 1000
            {
                buffer[7] = 0x03;
                buffer[8] = 0xE8;
            }
            if (dutyCycle.SelectedIndex == 10) //55% de duty cycle CCR = 1100
            {
                buffer[7] = 0x04;
                buffer[8] = 0x4C;
            }
            if (dutyCycle.SelectedIndex == 11) //60% de duty cycle CCR = 1200
            {
                buffer[7] = 0x04;
                buffer[8] = 0xB0;
            }
            if (dutyCycle.SelectedIndex == 12) //65% de duty cycle CCR = 1300
            {
                buffer[7] = 0x05;
                buffer[8] = 0x14;
            }
            if (dutyCycle.SelectedIndex == 13) //70% de duty cycle CCR = 1400
            {
                buffer[7] = 0x05;
                buffer[8] = 0x78;
            }
            if (dutyCycle.SelectedIndex == 14) //75% de duty cycle CCR = 1500
            {
                buffer[7] = 0x05;
                buffer[8] = 0xDC;
            }
            if (dutyCycle.SelectedIndex == 15) //80% de duty cycle CCR = 1600
            {
                buffer[7] = 0x06;
                buffer[8] = 0x40;
            }
            if (dutyCycle.SelectedIndex == 16) //85% de duty cycle CCR = 1700
            {
                buffer[7] = 0x06;
                buffer[8] = 0xA4;
            }
            if (dutyCycle.SelectedIndex == 17) //90% de duty cycle CCR = 1800
            {
                buffer[7] = 0x07;
                buffer[8] = 0x08;
            }
            if (dutyCycle.SelectedIndex == 18) //95% de duty cycle CCR = 1900
            {
                buffer[7] = 0x07;
                buffer[8] = 0x6C;
            }
            if (dutyCycle.SelectedIndex == 19) //100% de duty cycle CCR = 2000
            {
                buffer[7] = 0x07;
                buffer[8] = 0xD0;
            }
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
            for (i=0; i<tamanho_palavra; i++)
            {
                PaginaInicial.buffer[i] = buffer[i];
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dutyCycleFixo_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Ligar Inversor")
            {
                button2.BackColor = Color.Red;
                button2.Text = "Desligar Inversor";
            }
            else
            {
                button2.BackColor = Color.Lime;
                button2.Text = "Ligar Inversor";
            }
        }
    }
}
