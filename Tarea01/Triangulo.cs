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
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form1 primeraForm = new Form1();
            primeraForm.Show();
        }

        private void Triangulo_Load(object sender, EventArgs e)
        {
            picture1.Load(Application.StartupPath + @"\backgroun.png");
        }
    }
}
