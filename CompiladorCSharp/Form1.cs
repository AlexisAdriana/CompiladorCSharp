using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompiladorCSharp.Recursos;
using Irony.Parsing;
using System.IO;
using System.Media;
using ProyectoCompilador.Recursos;

namespace CompiladorCSharp
{
    public partial class Principal : Form
    {
        bool activarArbol = false;
        Image imagenArbol;

        public Principal()
        {
            InitializeComponent();
            llenarTablaKeyTerm();
            Sonido(true);
            btnArbol.Enabled = activarArbol;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Analizar_Click(object sender, EventArgs e)
        {

            Gramatica gramatica = new Gramatica();
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser parser = new Parser(lenguaje);
            ParseTree arbol = parser.Parse(TextCode.Text);
            ParseTreeNode resultado = arbol.Root;

            if (resultado != null)
            {
                imagenArbol = Sintactico.getImage(resultado);
                activarArbol = true;
                btnArbol.Enabled = activarArbol;
                Consola1.BackColor = Color.Green;
                Consola1.Text = "EL CODIGO SE ANALIZO CORRECTAMENTE Y NO CONTIENE ERRORES";
                for (int i = 0; i < arbol.Tokens.Count; i++)
                {
                    string sim = "";
                    string desc = "";
                    string tok = arbol.Tokens.ElementAt(i).ToString();
                    //Console.WriteLine(tok);
                    if (i != (arbol.Tokens.Count - 1))
                    {
                        string[] arregloTokens = tok.Split(' ');
                        for (int c = 0; c < arregloTokens.Count(); c++)
                        {
                            if (c == 0)
                            {
                                sim = arregloTokens[c];
                            }
                            else
                            {
                                desc = desc + arregloTokens[c];
                            }
                        }
                        TableTok.Rows.Add();
                        TableTok.Rows[i].Cells[0].Value = sim;
                        TableTok.Rows[i].Cells[1].Value = desc;
                        //Console.WriteLine(sim);
                        //Console.WriteLine(desc);
                    }
                    else
                    {
                        TableTok.Rows.Add();
                        TableTok.Rows[i].Cells[0].Value = tok;
                        TableTok.Rows[i].Cells[1].Value = "Final";
                        //Console.WriteLine(tok);
                        //Console.WriteLine("Final");

                    }

                }
            }
            else
            {
                btnArbol.Enabled = activarArbol;
                TableTok.Rows.Clear();
                for (int i = 0; i < arbol.ParserMessages.Count; i++)
                {
                    
                    Consola1.BackColor = Color.Red;
                    Consola1.Text =
                             arbol.ParserMessages.ElementAt(i).Message + ". Linea: "
                            + arbol.ParserMessages.ElementAt(i).Location.Line
                            + ", Columna " + arbol.ParserMessages.ElementAt(i).Location.Column;
                }
            }
            //------------------Esta sirve
            //ParseTreeNode resultado = Sintactico.analizar(TextCode.Text);
            ////Console.WriteLine("resultado");
            //if (resultado != null)
            //{
            //    Consola1.BackColor = Color.Green;
            //    Consola1.Text = "EL CODIGO SE ANALIZO CORRECTAMENTE Y NO CONTIENE ERRORES";
            //    //Consola.Text = "La cadena es correcta";
            //    //Consola1.Write("La Cadena es incorrecta");
            //    //pictureBox1.Image = Sintactico.getImage(resultado);
            //    //Recorrido.resolverOperacion(resultado);
            //}
            //else
            //{
            //    Consola1.BackColor = Color.Red;
            //    Consola1.Text = "¡EL CODIGO GENERO UN ERROR!";
            //    //Consola.Text = "La cadena es incorrecta";
            //    //Consola1.Write("La Cadena es incorrecta");
            //}
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Aqui el codigo para abrir el archivo
                //Guardar.GuardarArchivo(saveFileDialog1.FileName, cuadroText.Text);
                //cuadroText.Text = saveFileDialog1.FileName;
                string textoCodigo = TextCode.Text;

                StreamWriter escribir = new StreamWriter(saveFileDialog1.FileName);
                try
                {
                    escribir.Write(textoCodigo);
                }
                catch
                {
                    MessageBox.Show("Error");

                }
                escribir.Close();
            }
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextCode.Text = "";
                //Aqui el codigo para abrir el archivo
                //Console.Write(openFileDialog1.FileName);
                //cuadroText.Text = openFileDialog1.FileName;
                StreamReader leer = new StreamReader(openFileDialog1.FileName);
                string linea;

                try
                {
                    linea = leer.ReadLine();
                    while (linea != null)
                    {
                        TextCode.AppendText(linea + "\n");
                        linea = leer.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        public void llenarTablaKeyTerm()
        {
            TableKT.Rows.Add();
            TableKT.Rows[0].Cells[0].Value = ":";
            TableKT.Rows[0].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[1].Cells[0].Value = ";";
            TableKT.Rows[1].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[2].Cells[0].Value = ".";
            TableKT.Rows[2].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[3].Cells[0].Value = ",";
            TableKT.Rows[3].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[4].Cells[0].Value = "(";
            TableKT.Rows[4].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[5].Cells[0].Value = ")";
            TableKT.Rows[5].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[6].Cells[0].Value = "{";
            TableKT.Rows[6].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[7].Cells[0].Value = "}";
            TableKT.Rows[7].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[8].Cells[0].Value = "[";
            TableKT.Rows[8].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[9].Cells[0].Value = "]";
            TableKT.Rows[9].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[10].Cells[0].Value = "+";
            TableKT.Rows[10].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[11].Cells[0].Value = "-";
            TableKT.Rows[11].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[12].Cells[0].Value = "*";
            TableKT.Rows[12].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[13].Cells[0].Value = "/";
            TableKT.Rows[13].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[14].Cells[0].Value = "++";
            TableKT.Rows[14].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[15].Cells[0].Value = "--";
            TableKT.Rows[15].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[16].Cells[0].Value = ">";
            TableKT.Rows[16].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[17].Cells[0].Value = "<";
            TableKT.Rows.Add();
            TableKT.Rows[17].Cells[0].Value = "=";
            TableKT.Rows[17].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[18].Cells[0].Value = ">=";
            TableKT.Rows[18].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[19].Cells[0].Value = "<=";
            TableKT.Rows[19].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[20].Cells[0].Value = ">=";
            TableKT.Rows[20].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[21].Cells[0].Value = "!=";
            TableKT.Rows[21].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[22].Cells[0].Value = "==";
            TableKT.Rows[22].Cells[1].Value = "signo de puntuación";
            TableKT.Rows.Add();
            TableKT.Rows[23].Cells[0].Value = "int";
            TableKT.Rows[23].Cells[1].Value = "Tipo de variable";
            TableKT.Rows.Add();
            TableKT.Rows[24].Cells[0].Value = "float";
            TableKT.Rows[24].Cells[1].Value = "Tipo de variable";
            TableKT.Rows.Add();
            TableKT.Rows[25].Cells[0].Value = "string";
            TableKT.Rows[25].Cells[1].Value = "Tipo de variable";
            TableKT.Rows.Add();
            TableKT.Rows[26].Cells[0].Value = "bool";
            TableKT.Rows[26].Cells[1].Value = "Tipo de variable";
            TableKT.Rows.Add();
            TableKT.Rows[27].Cells[0].Value = "if";
            TableKT.Rows[27].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[28].Cells[0].Value = "if";
            TableKT.Rows[28].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[29].Cells[0].Value = "elif";
            TableKT.Rows[29].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[30].Cells[0].Value = "else";
            TableKT.Rows[30].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[31].Cells[0].Value = "break";
            TableKT.Rows[31].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[32].Cells[0].Value = "case";
            TableKT.Rows[32].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[33].Cells[0].Value = "class";
            TableKT.Rows[33].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[34].Cells[0].Value = "Try";
            TableKT.Rows[34].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[35].Cells[0].Value = "Catch";
            TableKT.Rows[35].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[36].Cells[0].Value = "while";
            TableKT.Rows[36].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[37].Cells[0].Value = "Do";
            TableKT.Rows[37].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[38].Cells[0].Value = "for";
            TableKT.Rows[38].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[39].Cells[0].Value = "public";
            TableKT.Rows[39].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[40].Cells[0].Value = "Throw";
            TableKT.Rows[40].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[41].Cells[0].Value = "Void";
            TableKT.Rows[41].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[42].Cells[0].Value = "switch";
            TableKT.Rows[42].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[43].Cells[0].Value = "true";
            TableKT.Rows[43].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[44].Cells[0].Value = "false";
            TableKT.Rows[44].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[45].Cells[0].Value = "|";
            TableKT.Rows[45].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[46].Cells[0].Value = "&&";
            TableKT.Rows[46].Cells[1].Value = "Ciclo y condicionales";
            TableKT.Rows.Add();
            TableKT.Rows[47].Cells[0].Value = "using";
            TableKT.Rows[47].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[48].Cells[0].Value = "System";
            TableKT.Rows[48].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[49].Cells[0].Value = "Collection";
            TableKT.Rows[49].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[50].Cells[0].Value = "IO";
            TableKT.Rows[50].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[51].Cells[0].Value = "Generic";
            TableKT.Rows[51].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[52].Cells[0].Value = "Linq";
            TableKT.Rows[52].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[53].Cells[0].Value = "Text";
            TableKT.Rows[53].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[54].Cells[0].Value = "Threading";
            TableKT.Rows[54].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[55].Cells[0].Value = "Task";
            TableKT.Rows[55].Cells[1].Value = "Importados";
            TableKT.Rows.Add();
            TableKT.Rows[56].Cells[0].Value = "Console";
            TableKT.Rows[56].Cells[1].Value = "Imprimir";
            TableKT.Rows.Add();
            TableKT.Rows[57].Cells[0].Value = "Write";
            TableKT.Rows[57].Cells[1].Value = "Imprimir";
            TableKT.Rows.Add();
            TableKT.Rows[58].Cells[0].Value = "WriteLine";
            TableKT.Rows[58].Cells[1].Value = "Imprimir";



        }


        private void Principal_Load(object sender, EventArgs e)
        {

        }

        public void Sonido(bool activo)
        {

            SoundPlayer Player = new SoundPlayer();
            string absolute = AppDomain.CurrentDomain.BaseDirectory;
            Player.SoundLocation = absolute + "Musica/musicaFondo.wav";
            if(activo == true) {
                btnConSonido.Visible = false;
                btnSinSonido.Visible = true;
                Player.PlayLooping();
            }
            else if(activo == false)
            {
                btnConSonido.Visible = true;
                btnSinSonido.Visible = false;
                Player.Stop();
            }
            

        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            btnArbol.Enabled = activarArbol;
            Arbol formArbol = new Arbol();
            formArbol.Show();
            formArbol.ObtenerImagen(imagenArbol);
            activarArbol = false;
            btnArbol.Enabled = activarArbol;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //btnMaximizar.Visible = false;
            //btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //btnMaximizar.Visible = true;
            //btnRestaurar.Visible = false;
        }

        private void btnConSonido_Click(object sender, EventArgs e)
        {
            Sonido(true);
        }

        private void btnSinSonido_Click(object sender, EventArgs e)
        {
            Sonido(false);
        }
    }
}
