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
using Newtonsoft.Json;

namespace PresentacionLogin
{
    public partial class PerfilForm : Form
    {
        string user=MetodosPresentacion.usuario;
        UsuarioEntidad usuario=new UsuarioEntidad();
        
        public PerfilForm()
        {
            InitializeComponent();
            obtenerDatos();
        }

        private void btnActualizarPerfil_Click(object sender, EventArgs e)
        {
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/GuardarUsuario?id=" + usuario.IdUsuario + "&username=" + textBoxUsername.Text + "&nombre=" + textBoxNombre.Text + "&apellido=" + textBoxApellido.Text + "&contrasena=" + textBoxContrasena.Text + "&tipo=A&estado=H");

            MessageBox.Show(this, "Usuario actualizado correctamente", "Actualización usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void obtenerDatos()
        {
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/DevolverUsername?username=" + user);
            usuario = JsonConvert.DeserializeObject<UsuarioEntidad>(json);
            textBoxApellido.Text = usuario.Apellido;
            textBoxContrasena.Text = usuario.Contrasena;
            textBoxNombre.Text = usuario.Nombre;
            textBoxUsername.Text = usuario.Username;
           
        }

       
    }
}
