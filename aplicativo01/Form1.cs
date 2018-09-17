using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace aplicativo01
{
    public partial class Form1 : Form
    {
		formulario formul;
      
        public Form1()
        {
            InitializeComponent();
			formul = new formulario();


		}
        public void test(object sender, EventArgs e)
        {

            formul.criartheard(0);
			
		}
		private void button2_Click(object sender, EventArgs e)
		{
			
           formul.texto[0] = texto.Text;
			formul.lancar(0);
		}

		private void parando(object sender, EventArgs e)
		{
			formul.parar(0);
		}

		private void excluir0(object sender, EventArgs e)
		{
			formul.exclur(0);
		}

		private void criar0(object sender, EventArgs e)
		{
			formul.criartheard(1);
		}

		private void lancar0(object sender, EventArgs e)
		{

            formul.texto[1] = texto.Text;
            formul.lancar(1);
		}

		private void parar0(object sender, EventArgs e)
		{
			formul.parar(1);
		}

		private void excluir1(object sender, EventArgs e)
		{
			formul.exclur(1);
		}

		private void criar2(object sender, EventArgs e)
		{
			formul.criartheard(2);
		}

		private void lancar2(object sender, EventArgs e)
		{
           formul.texto[2] = texto.Text;
			formul.lancar(2);
		}

		private void parar(object sender, EventArgs e)
		{
			formul.parar(2);
		}

		private void excluir2(object sender, EventArgs e)
		{
			formul.exclur(2);
		}
	}
}
