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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Cuadrados cuadrado = new Cuadrados();
            cuadrado.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rectanguloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // menuToolStripMenuItem.BackColor = Color.DarkBlue;
            //menuToolStripMenuItem.BackColorChanged = Color.DarkBlue;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            calculo_del_area frmlcal = new calculo_del_area();
            frmlcal.Show();


        }

        private void pictu_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Circulo frmcirculo = new Circulo();
            frmcirculo.Show();
        }

        private void calculoDelÁreaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculo_del_area frmlcal = new calculo_del_area();
            frmlcal.Show();

        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Show();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuadrados cuadrado = new Cuadrados();
            cuadrado.Show();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circulo frmcirculo = new Circulo();
            frmcirculo.Show();
        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
