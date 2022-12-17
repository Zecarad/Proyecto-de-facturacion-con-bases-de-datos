using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;

namespace negocios
{
    internal class text
    {

        public void archivo_guardar()
        {


            /*Crear botno donde se va a meter este codigo */

            StreamWriter escribir = new StreamWriter(@"C:\\Users\\Andrey\\Desktop\archivo_texto.txt", true);
            try
            {

                escribir.WriteLine("Nombre del label donde esta la informacion box" + /*Nombre del text box  --- sentencia = +textBox.Text*/);
                escribir.WriteLine("Nombre del label donde esta la informacion box" + /*Nombre del text box*/);
                escribir.WriteLine("Nombre del label donde esta la informacion box" + /*Nombre del text box*/);
                escribir.WriteLine("Nombre del label donde esta la informacion box" + /*Nombre del text box*/);
                escribir.WriteLine("Nombre del label donde esta la informacion box" + /*Nombre del text box*/);
                escribir.WriteLine("\n");

                

            }

            catch
            {
                
            }

        }





    }

 }
     

