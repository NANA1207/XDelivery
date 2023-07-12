using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLogin
{
    public  class MetodosPresentacion
    {
        static string _texto=" ";
        static string _parametro = "";
        public static int controlador;
        static object _objeto;
        static string _identificador="";//identifica a que entidad pertenese
        static int _actualizar; //muestra si una pagina se debe actualizar
        public static string usuario;

        
        public static void abrirForm(object form)
        {
            Form fh = form as Form;
            
            fh.Show();

            //this.Hide();
        }
        public static void abrirDialogo(object formHijo, object formPadre)
        {
            Form fh = formHijo as Form;
            Form fp = formPadre as Form;
            MetodosPresentacion metodo = new MetodosPresentacion();
            metodo.abrirDialog(fh, fp);
        }
        public void abrirDialog(Form formHijo, Form formPadre)
        {
            if (controlador == 0)
            {
                controlador += 1;
                formHijo.Owner = formPadre;
                formHijo.FormClosed += new FormClosedEventHandler(fh_FormClosed);
                
                formHijo.Show();
                
            }
            else
            {
                formHijo.Activate();
            }

            //this.Hide();
        }
        void fh_FormClosed(object send, FormClosedEventArgs e)
        {
           controlador = 0;
        }
        
        public static void AbrirFormHijo(object formHijo, object panel)
        {
            Form fh = formHijo as Form;
            Panel p = panel as Panel;
            if (p.Controls.Count > 0)
                p.Controls.RemoveAt(0);
            
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            p.Controls.Add(fh);
            p.Tag = fh;
            fh.Show();
        }

        public static void enviarTexto(string texto, string parametro)
        {
            _texto = texto;
            _parametro = parametro;
        }

        public static string obtenerTexto()
        {
            return _texto;
        }
        public static string obtenerParametro()
        {
            return _parametro;
        }

        public static void enviarObjeto(object objecto, string identificador)
        {
            _objeto = objecto;
            _identificador = identificador;
        }

        public static object obtenerObjeto()
        {
            return _objeto;
        }
        public static string obtenerIdentificador()
        {
            return _identificador;
        }

        public static void activarActualizacion()
        {
            _actualizar = 1;
        }
        public static void cancelarActualizacion()
        {
            _actualizar = 0;
        }
        public static int obtenerActualizacion()
        {
            return _actualizar;
        }
    }
}
