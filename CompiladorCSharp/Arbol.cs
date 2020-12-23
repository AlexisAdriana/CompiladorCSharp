using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorCSharp
{
    public partial class Arbol : Form
    {
        Image gImagen;

        public Arbol()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void ObtenerImagen(Image imagen)
        {
            gImagen = imagen;
            pictureBox1.Image = imagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gImagen.Save(saveFileDialog1.FileName);
            }
        }
    }
}
