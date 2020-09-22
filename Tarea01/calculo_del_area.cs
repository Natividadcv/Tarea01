using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea01
{
    public partial class calculo_del_area : Form
    {
        public calculo_del_area()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaracion de varibales
            double basee, altura;

            basee = Convert.ToDouble(txt_b.Text);
            altura = Convert.ToDouble(txt_a.Text);
            

            txt_resul.Text =  Convert.ToString(basee * altura);

      







        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double b, a;

            b = Convert.ToDouble(txt_base.Text);
            a = Convert.ToDouble(txt_altura.Text);

            txt_result.Text = Convert.ToString(b * a / 2) ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarbox();
        }


        //crear metodo
        public void limpiarbox()
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_resul.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_base.Clear();
            txt_altura.Clear();
            txt_result.Clear();
        }
    }
}
