using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;

namespace Comandos
{
    public partial class ComandosApp : Form
    {
        private int fy = 0;
        private int by = 0;
        private string secAnt = "";
        private string secAux = "";
        Comandos objComandos = new Comandos();  //objeto de la clase Comandos
        Informacion objInfo = new Informacion();    //objeto de la clase Comandos()

        public ComandosApp() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /*
         *Accion que se realiza cuando se selecciona un elemento del controlador cmbComandos
         */
        private void cmbComandos_SelectedIndexChanged(object sender, EventArgs e) 
        {
            int indice = cmbComandos.SelectedIndex; 
            int espacio = 0;
            string contenido = cmbComandos.Items[indice].ToString(); //comando seleccionado del cmb

            for (int i = 0; i < contenido.Length; i++)  //con el ciclo recorremos la cadena para revisar si contiene argumentos el comando seleccionado
            {
                if (contenido[i] == ' ') //si el caracter en la cadena es igual a un espacio se toma su indice para separar el comando del argumento 
                {
                    espacio = i;
                    break;
                }
            }
            if (espacio == 0)   //si espacio es igual a 0 no hay argumentos
            {
                objComandos.Nombre = contenido;
                objComandos.Args = "";
            }
            else //si espacio es diferente de cero, se separa la cadena en comando y argumentos
            {
                objComandos.Nombre = contenido.Substring(0, espacio);
                objComandos.Args = contenido.Substring(espacio + 1);
            }

            FlowLayoutPanel flyOcultar = this.Controls.OfType<FlowLayoutPanel>().Where(c => c.Name.Equals("flyp" + secAnt)).FirstOrDefault();
            if (Controls.Contains(flyOcultar)) //si se muestra un panel vinculado a una seccion que no pertenece al comando seleccionado actualmente entonces este se remueve de la GUI
                this.Controls.Remove(flyOcultar);

            objInfo.guardaInformacion(objComandos.Nombre, objComandos.Args);    //se llama al metodo de la clase Informacion que se encarga de guardar la informacion obtenida del proceso (ejecucion del comando seleccionado)

            if (cmbSeccion.Items.Count > 0) { //si contiene secciones de un comando anterior las remueve para agregar los del nuevo comando
                cmbSeccion.Items.Clear();
            }
             
            foreach (DictionaryEntry de in objInfo.TablaSecciones) //recorre los elementos que contiene la Hashtable TablaSecciones de la clase Informacion
                cmbSeccion.Items.Add(de.Key); //agrega las secciones a su ComboBox

        }

        /*
         * Accion que se realiza cuando se selecciona un elemento del controlador cmbSeccion
         */
        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e) 
        {
            //Para desplegar las propiedades de cada seccion se crean botones dinamicos dentro de un panel, esto para que 
            //cada vez que la seccion cambie también los botones respectivamente
             
            int indice = cmbSeccion.SelectedIndex;
            string contenido = cmbSeccion.Items[indice].ToString();
            Hashtable ht = (Hashtable)objInfo.TablaSecciones[contenido];
            fy = labelProp.Location.Y + 35;
            by = labelProp.Location.Y + 35;
            
            FlowLayoutPanel flyOcultar = this.Controls.OfType<FlowLayoutPanel>().Where(c => c.Name.Equals("flyp" + secAnt)).FirstOrDefault();
            
            if (Controls.Contains(flyOcultar)) //si se muestra un panel vinculado a una seccion diferente a la seleccionada actualmente entonces este se remueve de la GUI
                this.Controls.Remove(flyOcultar);

            //se crea el panel
            FlowLayoutPanel fly = new FlowLayoutPanel();
            fly.Height = 400;
            fly.Width = 600;
            fly.Location = new Point(57, fy);
            fly.Name = "flyp" + contenido;
            fly.WrapContents = true;
            fly.TabIndex = 11;
            Controls.Add(fly); //se agrega el panel a la GUI

            foreach (DictionaryEntry de in ht) //recorre los elementos que contiene la Hashtable ht, a esta se le asigna la coleccion de valores de la seccion seleccionada
            {
                Button btn = new Button();
                btn.Height = 30;
                btn.Width = 200;
                btn.Location = new Point(58, by);
                by += 25;
                btn.BackColor = Color.FromArgb(5, 46, 95);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Name = "btn" + de.Key;
                btn.Text = (string)de.Key; //se le agrega el nombre de cada propiedad para desplegarlas en la pantalla
                btn.Click += new EventHandler(btnComun_Click); //se le agrega el método que se va a ejecutar cuando se de clic en cada boton
                Controls.Add(btn); //se agrega el boton a la GUI
                fly.Controls.Add(btn); //se agrega el boton al panel creado anteriormente
            }

            secAnt = contenido;
        }

        /*
         * Cuando se de clic en cada boton con este metodo se va a desplegar la informacion correspondiente a cada propiedad seleccionada
         */
        private void btnComun_Click(object sender, EventArgs e) 
        {
            int indice = cmbSeccion.SelectedIndex;
            string seccion = cmbSeccion.Items[indice].ToString(); //se obtiene la seccion seleccionada
            string valor = (string)((Hashtable)objInfo.TablaSecciones[seccion])[((Button)sender).Text]; //se busca el valor de la propiedad seleccionada con las llaves correspondientes en la Hashtable

            //se despliega la informacion en el TextBox
            if (seccion == secAux) //si la seccion seleccionada es igual a la anterior se agrega la propiedad en seguida
            {
                txbInfo.Text = txbInfo.Text + "       " + ((Button)sender).Text + " : " + valor + "\r\n";
            }
            else //sino, se muestra un nuevo formato para identificar mejor los datos
            {
                txbInfo.Text = txbInfo.Text + "\r\n--> " + seccion + "\r\n       " + ((Button)sender).Text + " : " + valor + "\r\n";
            }

            secAux = seccion; //se guarda el valor de la seccion seleccionada anteriormente para mostrar informacion de manera mas ordenada
        }

        /*
         * Metodo que limpia el contenido del TextBox cada que el boton Limpiar recibe un clic
         */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbInfo.Text = ""; 
        }
    }
}