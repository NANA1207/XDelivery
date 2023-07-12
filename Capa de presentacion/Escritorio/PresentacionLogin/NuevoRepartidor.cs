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

//using PresentacionLogin.wcfUsuarios;
using Entidades;
using Newtonsoft.Json;


//using Entidades;

namespace PresentacionLogin
{
    public partial class NuevoRepartidor : Form
    {
        UsuarioEntidad repartidor = new UsuarioEntidad();
        //UsuariosClient us = new UsuariosClient();
        public NuevoRepartidor()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodosPresentacion.controlador = 0;
        }

        private void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            guardarRepartidor();
            MetodosPresentacion.activarActualizacion();
            this.Hide();
            MetodosPresentacion.controlador = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoRepartidor_Load(object sender, EventArgs e)
        {
            labelTituloRepartidor.Text = MetodosPresentacion.obtenerTexto();
            var text = MetodosPresentacion.obtenerTexto();
            CargarComboBoxEstado();
            if (text.Equals("Actualizar Repartidor"))
            {
                cargarRepartidor();
            }
            else if (text.Equals("Nuevo Repartidor")) 
            {
                comboBoxEstadoRepartidor.Enabled = false;
            }
            
        }

        private void guardarRepartidor()
        {
            var id=0;
            var estado = "H";
            if (repartidor != null)
            {
                 id = repartidor.IdUsuario;
                estado = comboBoxEstadoRepartidor.SelectedValue.ToString();
            }
            
            
                var username = textBoxUsernameRepartidor.Text;
                var contrasena = textBoxContrasenaRepartidor.Text;
                var nombre = textBoxNombreRepartidor.Text;
                var apellido = textBoxApellidoRepartidor.Text;

                var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/GuardarUsuarioGet?id=" + id + "&username=" + username + "&nombre=" + nombre + "&apellido=" + apellido + "&contrasena=" + contrasena + "&tipo=R&estado="+estado);
                repartidor = JsonConvert.DeserializeObject<UsuarioEntidad>(json);

                if (repartidor == null)
                {
                MessageBox.Show(this, "Nombre de Usuario ya existe", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                {
                MessageBox.Show(this, "Guardado Correctamente ", "Usuario Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }

        //se carga los datos del repartidor en el form
        private void cargarRepartidor()
        {
           
            
            repartidor = (UsuarioEntidad)MetodosPresentacion.obtenerObjeto();
            if (repartidor != null)
            {
                textBoxUsernameRepartidor.Text=repartidor.Username ;
                textBoxContrasenaRepartidor.Text=repartidor.Contrasena;
                textBoxNombreRepartidor.Text=repartidor.Nombre;
                textBoxApellidoRepartidor.Text=repartidor.Apellido;
                textBoxIdRepartidor.Text = repartidor.IdUsuario.ToString();
                comboBoxEstadoRepartidor.SelectedValue = repartidor.EstadoUsuario.ToString().ToUpper();

            }
            

        }
        //carga comboBox de estado
        private void CargarComboBoxEstado()
        {


            comboBoxEstadoRepartidor.DisplayMember = "estado";
            comboBoxEstadoRepartidor.ValueMember = "id";
            comboBoxEstadoRepartidor.SelectedValue = "H";

            var estados = new[] {
            new { estado = "Habilitado", id = "H" },
            new { estado = "Deshasbilitado", id = "I" }
            };
            comboBoxEstadoRepartidor.DataSource = estados;

        }
    }
}
