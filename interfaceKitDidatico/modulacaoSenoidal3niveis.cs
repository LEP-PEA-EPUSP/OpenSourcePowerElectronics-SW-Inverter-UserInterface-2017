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
    public partial class modulacaoSenoidal3niveis : Form
    {
        PaginaInicial parent;
        int tamanho_palavra;
        tela1 tela1;
        public modulacaoSenoidal3niveis(PaginaInicial parent, tela1 tela1, int tamanho_palavra)
        {
            InitializeComponent();
            this.parent = parent;
            this.tamanho_palavra = tamanho_palavra;
            this.tela1 = tela1;
        }

        private void modulacaoSenoidal3niveis_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela1.Enabled = true;            
        }
    }
}
