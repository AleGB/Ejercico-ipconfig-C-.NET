using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandos
{
    public class Informacion
    {
        public Informacion()
        {
            _Seccion = "";
            _Propiedad = "";
            _Valor = "";
        }

        Log logE = new Log(); //objeto de la clase Log que ayuda con generar los registros asociados a los eventos dentro del programa
        private string _Seccion;
        private string _Propiedad;
        private string _Valor;
        private string[] array = new string[2];
        private Hashtable _TablaSecciones = new Hashtable(); //Estructura Hashtable donde se guarda cada seccion (key) y cada una contiene otra coleccion de datos que son sus respectivas propiedades (value)
        private Hashtable _TablaPropiedades = new Hashtable();  //Estructura Hashtable donde se guarda cada propiedad (key) de la coleccion anterior y su respectivo valor.

        public string Seccion { get => _Seccion; set => _Seccion = value; }
        public string Propiedad { get => _Propiedad; set => _Propiedad = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
        public Hashtable TablaSecciones { get => _TablaSecciones; set => _TablaSecciones = value; }
        public Hashtable TablaPropiedades { get => _TablaPropiedades; set => _TablaPropiedades = value; }



        public void guardaInformacion(string comando, string args)
        {
            try
            {
                var process = new ProcessStartInfo
                {
                    FileName = comando,
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = false,
                };
                var Proc = new Process
                {
                    StartInfo = process
                };
                Proc.Start();
                logE.Agregar("Se inicio el proceso: " + comando + " " + args);

                try
                {
                    _TablaSecciones.Clear();
                    _TablaPropiedades.Clear();
                    _Seccion = "";
                    string lineText = Proc.StandardOutput.ReadLine();

                    if (lineText != "Error: línea de comandos desconocida o incompleta.") {
                        while (!Proc.StandardOutput.EndOfStream)
                        {
                            lineText = Proc.StandardOutput.ReadLine();


                            if (lineText.Length == 0)
                                continue;


                            if (lineText[0] != ' ') //si el primer caracter de la cadena es diferente de ' ' significa que corresponde al nombre de una interfaz de red
                            {
                                if (_Seccion.Length != 0) //si se registro una seccion anteriormente entonces ahora tenemos que agregar la coleccion de valores guardados en la TablaPropiedades
                                {
                                    _TablaSecciones.Add(_Seccion, _TablaPropiedades);
                                }
                                _TablaPropiedades = new Hashtable(); //Cada vez que se encuentre una seccion nueva se creara su correspondiente Hashtable TablaPropiedades
                                _Seccion = lineText.Replace(":", ""); //Se da formato al nombre de la seccion quitando el caracter :
                            }
                            else
                            {
                                array = lineText.Split(" :"); //con el metodo Split separamos la cadena para guardar por separado los atributos y los valores 
                                if (array.Length > 1)
                                {
                                    _Propiedad = array[0].Replace(".", ""); //se da formato al nombre de la propiedad quitando los . por ""
                                    _Propiedad = _Propiedad.Trim(); //se eliminan los espacios en blanco antes y despues de la cadena 
                                    _Valor = array[1].Trim();
                                }
                                else
                                {
                                    _Propiedad = "Valor";
                                    _Valor = array[0].Trim();
                                }

                                _TablaPropiedades.Add(_Propiedad, _Valor); //se agrega la propiedad con su valor correspondiente 
                            }
                        }
                        if (_Seccion.Length != 0)
                        {
                            _TablaSecciones.Add(_Seccion, _TablaPropiedades);
                        }

                        logE.Agregar("Se guardo la informacion del proceso: " + comando + " " + args);
                    }
                    
                }
                catch (Exception ex)
                {
                    string error = "No se pudo ejecutar el comando '" + comando + "', es posible que los argumentos '" + args + "' de la línea de comandos sean desconocidos o incompletos. Intenta de nuevo.";
                    MsgBx msg = new MsgBx("error", error);
                    msg.ShowDialog();
                    logE.Agregar("No se pudo guardar la informacion del proceso: " + comando + " " + args + " - " + "ERROR: " + ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string alerta = "No se pudo ejecutar el comando '" + comando + "', es posible la línea de comandos sea desconocida o incompleta. Intenta de nuevo.";
                MsgBx msg = new MsgBx("alerta", alerta);
                msg.ShowDialog();
                logE.Agregar("No se pudo iniciar el proceso: " + comando + " " + args + " - " + "ERROR: " + ex.ToString());
            }
        }
    }
}
