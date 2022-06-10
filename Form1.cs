using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2OptimizacionAlg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("Romance");
            comboBox1.Items.Add("Comedia");
            comboBox1.Items.Add("Suspenso");
            comboBox1.Items.Add("Drama");

            
            comboBox2.Items.Add("1 H");
            comboBox2.Items.Add("2 H");

           
            comboBox3.Items.Add("*");
            comboBox3.Items.Add("**");
            comboBox3.Items.Add("***");
            comboBox3.Items.Add("****");
            comboBox3.Items.Add("*****");



        }

        public string a = @"C:/Users/Laura/source/repos/Clase2OptimizacionAlg/text2.txt";
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(a, true);
            
                    var d2 = new Datos();
                    Console.WriteLine("Escriba titulo ");
                    d2.titulo = textBox1.Text;
                    escribir.WriteLine("Titulo: "+d2.titulo);

                    Console.WriteLine("Escriba director ");
                    d2.director = textBox2.Text;
                    escribir.WriteLine("Director: " + d2.director);


                    Console.WriteLine("Escriba escritor ");
                    d2.escritor = textBox3.Text;
                    escribir.WriteLine("Escritor: " + d2.escritor);


                    Console.WriteLine("Escriba genero ");
                    d2.genero = comboBox1.Text;
                    escribir.WriteLine("Genero: " + d2.genero);

                    Console.WriteLine("Escriba duracion ");
                    d2.duracion = comboBox2.Text;
                    escribir.WriteLine("Duracion: " + d2.duracion);


                    Console.WriteLine("Escriba clasificacion ");
                    d2.clasificacion = comboBox3.Text;
                    escribir.WriteLine("Calificacion: " + d2.clasificacion);

                    Console.WriteLine("Escriba productora ");
                    d2.productora = textBox4.Text;
                    escribir.WriteLine("Titulo: " + d2.productora);

            escribir.Close();

            StreamReader leer = new StreamReader(a);
            string linea;

            linea = leer.ReadLine();

            while(linea!=null)
            {
                listBox1.Items.Add(linea+ "\n");
                linea = leer.ReadLine();
            }

            leer.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            listBox1.Items.Clear();

        }
    }
}
