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
    public partial class ListaUsuariosForm : Form
    {
        UsuarioEntidad usuario = new UsuarioEntidad();
        string identificador = "";
        public ListaUsuariosForm()
        {
            InitializeComponent();
            panel_ContenedorUsuario.Visible = true;
            panel_ContenedorNuevoUsuario.Visible = false;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscarUsuarios();
        }

        public string _texto;

        private void ListaUsuariosForm_Load(object sender, EventArgs e)
        {
            labelUsuarioTitulo.Text = MetodosPresentacion.obtenerTexto();
            labelUsuario.Text = MetodosPresentacion.obtenerTexto();
            labelNuevoUsuario.Text = "Nuevo" + MetodosPresentacion.obtenerTexto();
            cargarUsuarios();

        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            panel_ContenedorNuevoUsuario.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.controlador = 0;
            this.Hide();
            
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarUsuario_Click(object sender, EventArgs e)
        {
            panel_ContenedorNuevoUsuario.Visible = false;

        }

        private void panel_ContenedorNuevoUsuario_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridViewUsuarios.CurrentRow;
            if (filaSeleccionada != null)
            {
              
                int id = Convert.ToInt32(filaSeleccionada.Cells[3].Value);
                obtenerUsuario(id);
            }

        }
        //guarda al usuario seleccionado
        private void obtenerUsuario(int id)
        {
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/DevolverUsuarioPorId?id=" + id);
            usuario = JsonConvert.DeserializeObject<UsuarioEntidad>(json);
            // MetodosPresentacion.enviarObjeto(usuario);
            textBoxNombreUsuario.Text = usuario.Username;

        }

        //carga la tabla de usuarios ya sea cliente o repartidor
        private void cargarUsuarios()
        {
            var tipo = MetodosPresentacion.obtenerParametro();
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/DevolverUsuarioPorNombre?nombre=null" + "&tipo="+tipo);
            var resultado = JsonConvert.DeserializeObject<DataTable>(json);
            dataGridViewUsuarios.DataSource = resultado;
        }

        //busca al usuario por nombre, apellido o username
        private void buscarUsuarios()
        {
            var tipo = MetodosPresentacion.obtenerParametro();
            var usuarioNombre = textBoxNombreUsuario.Text;
            if (usuarioNombre.Equals(""))
            {
                cargarUsuarios();
            }
            else
            {
                var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/DevolverUsuarioPorNombre?nombre=" + usuarioNombre + "&tipo=" + tipo);
                var resultado = JsonConvert.DeserializeObject<DataTable>(json);
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show(this, "No existe el usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewUsuarios.DataSource = resultado;
                }
            }

            
        }

        private void buttonAsignarUsuario_Click(object sender, EventArgs e)
        {
            asignarUsuario();
            MetodosPresentacion.controlador = 0;
            MetodosPresentacion.activarActualizacion();
            
            this.Hide();
        }
        
        private void asignarUsuario()
        {
            var tipo = MetodosPresentacion.obtenerParametro();
            identificador = MetodosPresentacion.obtenerIdentificador(); // obtiene el tipo de objeto q se esta enviando
            //se asegura de que el pedido al que va a asignar un repartidor exista
            if (tipo.Equals("R")&& identificador.Equals("pedido"))
            {
                PedidoEntidad pedido = (PedidoEntidad)MetodosPresentacion.obtenerObjeto();
                var idPedido = pedido.IdPedido;
                var idRepartidor = usuario.IdUsuario;
                var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Pedidos.svc/AsignarRepartidor?repartidor=" + idRepartidor + "&pedido=" + idPedido);
                //var resultado = JsonConvert.DeserializeObject<DataTable>(json);

            }
            else
            {
                MetodosPresentacion.enviarObjeto(usuario,"usuario");
            }
        }

        private void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            guardarUsuario();

        }

        private void guardarUsuario()
        {
            var nombre = textBoxNuevoNombreUsuario.Text;
            var apellido = textBoxNuevoApelidoUsuario.Text;
            var contrsena = textBoxNuevoContrasenaUsuario.Text;
            var username = textBoxNuevoUsernameUsuario.Text;
            var id =0;
            var tipo = MetodosPresentacion.obtenerParametro();
            
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/GuardarUsuarioGet?id=" + id+ "&username=" + username+ "&nombre=" + nombre+ "&apellido=" + apellido+ "&contrasena=" + contrsena+ "&tipo=" + tipo+ "&estado=H");
            var nuevoUsuario = JsonConvert.DeserializeObject<UsuarioEntidad>(json);
            
            if (nuevoUsuario == null)
            {
                MessageBox.Show(this, "Nombre de usuario ya existe", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Usuario guardado Correctamente ", "Usuario Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel_ContenedorNuevoUsuario.Visible = false;
                cargarUsuarios();
            }
        }
    }
}
