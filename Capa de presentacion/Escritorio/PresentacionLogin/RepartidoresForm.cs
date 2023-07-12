using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PresentacionLogin
{
    public partial class RepartidoresForm : Form
    {
        UsuarioEntidad repartidor = new UsuarioEntidad();
        public RepartidoresForm()
        {
            InitializeComponent();
            buttonBloquearRepartidor.Enabled = false;
        }

        private void buttonNuevoRepartidor_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarTexto("Nuevo Repartidor","R");
            MetodosPresentacion.abrirDialogo(new NuevoRepartidor(), this);
        }

        private void buttonVerRepartidor_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarTexto("Actualizar Repartidor","R");
            MetodosPresentacion.enviarObjeto(repartidor, "usuario");
            MetodosPresentacion.abrirDialogo(new NuevoRepartidor(), this);
            
        }

        private void RepartidoresForm_Load(object sender, EventArgs e)
        {
            buttonVerRepartidor.Enabled = false;
            cargarTablaRepartidores();
        }

        private void cargarTablaRepartidores()
        {
            var  json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/DevolverListadoUsuarios?tipo=R");  
            var resultado = JsonConvert.DeserializeObject<DataTable>(json);
            dataGridViewRepartidores.DataSource = resultado;
        }

        private void buttonBloquearRepartidor_Click(object sender, EventArgs e)
        {
            bloquearRepartidor();
            MetodosPresentacion.activarActualizacion();
        }

        private void seleccionarRepartidor(int id)
        {
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/DevolverUsuarioPorId?id=" + id);
            repartidor = JsonConvert.DeserializeObject<UsuarioEntidad>(json);

            // habilita o deshabilita el boton de bloquear
            if (repartidor.EstadoUsuario.Equals("H"))
            {
                buttonBloquearRepartidor.Enabled = true;
            }
            else
            {
                buttonBloquearRepartidor.Enabled = false;
            }
        }

        private void dataGridViewRepartidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonVerRepartidor.Enabled = true;
            var filaSeleccionada = dataGridViewRepartidores.CurrentRow;
            if (filaSeleccionada != null && !filaSeleccionada.Cells[3].Value.ToString().Equals(""))

            {
               
                int id = Convert.ToInt32(filaSeleccionada.Cells[3].Value);

                seleccionarRepartidor(id);
            }
            
        }

        private void bloquearRepartidor()
        {
            var id =  repartidor.IdUsuario;
            var nombre = repartidor.Nombre;
            var apellido = repartidor.Apellido;
            var contrsena = repartidor.Contrasena;
            var tipo = repartidor.TipoUsuario;
            var username = repartidor.Username;
            
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/GuardarUsuarioGet?id=" + id+"&username="+username+"&nombre="+nombre+"&apellido="+apellido+"&contrasena="+contrsena+"&tipo="+tipo+"&estado=I");
            repartidor = JsonConvert.DeserializeObject<UsuarioEntidad>(json);
            MessageBox.Show(this, "Repartidor bloqueado correctamente ", "Bloquear Repartidor", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridViewRepartidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRepartidores_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void RepartidoresForm_Paint(object sender, PaintEventArgs e)
        {
            var act = MetodosPresentacion.obtenerActualizacion();
            if (act == 1)
            {
                cargarTablaRepartidores();
            }
            MetodosPresentacion.cancelarActualizacion();
        }
    }
}
