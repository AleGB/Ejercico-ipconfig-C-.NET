using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos
{
    public class Log
    {
        private string path = "";

        public Log()
        {
            this.path = @"..\logs\";
        }

        /*
         * Metodo que se encarga de escribir cada log en un archivo
         */
        public void Agregar(string logE)
        {
            CrearDirectorio();
            string nombre = NombreArchivo();
            string cadena = "";
            cadena += DateTime.Now + " - " + logE + Environment.NewLine;

            StreamWriter sw = new StreamWriter(path + "/" + nombre, true);
            sw.WriteLine(cadena);
            sw.Close();
        }

        /*
         * Metodo que verifica si existe el directorio donde se va a guardar el archivo para el registro de logs
         * Si no existe directorio entonces lo crea, de lo contrario lo sobreescribe con la nueva informacion
         */
        private void CrearDirectorio()
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /*
         * Metodo que se encarga de crear el nombre de cada archivo
         * Se crea un archivo por dia para registrar los logs 
         */
        private string NombreArchivo()
        {
            string nombre = "";
            nombre = "log_Comandos_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt"; 

            return nombre;
        }
    }
}
