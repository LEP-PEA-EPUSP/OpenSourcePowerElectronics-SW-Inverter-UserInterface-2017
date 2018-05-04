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
    public partial class tela1 : Form
    {
        private PaginaInicial parent;
        public int tamanho_palavra;
        public tela1(PaginaInicial parent, int tamanho_palavra)
        {
            this.parent = parent;
            this.tamanho_palavra = tamanho_palavra;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dutyCycleFixo telaDutyCycleFixo = new dutyCycleFixo(parent,this,tamanho_palavra);
            telaDutyCycleFixo.Show();
            Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modulacaoSenoidal telaModulacaoSenoidalDoisNiveis = new modulacaoSenoidal(parent,this,tamanho_palavra);
            telaModulacaoSenoidalDoisNiveis.Show();
            Enabled = false;
        }

        private void tela1_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modulacaoSenoidal3niveis msenoidal3niveis = new modulacaoSenoidal3niveis(parent, this, tamanho_palavra);
            msenoidal3niveis.Show();
            Enabled = false;
        }
    }
}
