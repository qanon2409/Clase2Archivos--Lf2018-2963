using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Clase2OptimizacionAlg
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            /*
            Datos[] d = new Datos[1];
            var a= @"C:/Users/Laura/source/repos/Clase2OptimizacionAlg/texto.txt";

            
            using (TextWriter tx = File.CreateText(a))
            {
                for (int i = 0; i < 1; i++)
                {
                    var d2 = new Datos();
                    Console.WriteLine("Escriba titulo ");
                    d2.titulo = Console.ReadLine();

                    Console.WriteLine("Escriba director ");
                    d2.director = Console.ReadLine();
                    ;
                    Console.WriteLine("Escriba escritor ");
                    d2.escritor = Console.ReadLine();

                    Console.WriteLine("Escriba genero ");
                    d2.genero=Console.ReadLine();

                    Console.WriteLine("Escriba duracion ");
                    d2.duracion = Console.ReadLine();

                    Console.WriteLine("Escriba clasificacion ");
                    d2.clasificacion = Console.ReadLine();


                    d[i] = d2;


                }

            }
            

            using (TextWriter tx = File.CreateText(a))
            {
                foreach (var i in d.ToList())
                {
                    
                    
                    tx.WriteLine(i.titulo);

                    tx.WriteLine(i.director);
                    
                    
                    tx.WriteLine(i.escritor);

                    
                    tx.WriteLine(i.genero);

                    
                    tx.WriteLine(i.duracion);

                    
                    tx.WriteLine(i.clasificacion);


                }

            }


            foreach (var d1 in d.ToList())
            {
                Console.WriteLine("titulo "+d1.titulo);
               
                Console.WriteLine("director "+ d1.director);
               
                Console.WriteLine("escritor "+ d1.escritor);
                
                Console.WriteLine("Escriba genero "+ d1.genero);
               
                Console.WriteLine("Escriba duracion "+d1.duracion);
                
                Console.WriteLine("Clasificacion "+ d1.clasificacion);
                

            }

            Console.ReadKey();*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
            
    }
}
