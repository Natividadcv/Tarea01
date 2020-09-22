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
    public partial class Cuadrados : Form
    {
        public Cuadrados()
        {
            InitializeComponent();
        }

        private void Cuadrados_Load(object sender, EventArgs e)
        {
            picture2.Load(Application.StartupPath + @"\backgroun1.png");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
