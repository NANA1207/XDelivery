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
//using PresentacionLogin.wcfUsuarios;


namespace PresentacionLogin
{
   
    public partial class Form1 : Form
    {
        //UsuariosClient us = new UsuariosClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();

           // MetodosPresentacion.abrirForm(new Menu());
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            string user = textBoxUsername.Text;
            string contra = textBoxContrasena.Text;
            if (user.Equals("") || contra.Equals(""))
            {
                MessageBox.Show("Llenar todos los campos");
            }
            else
            {
                var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Usuarios.svc/Login?usuario=" + user + "&tipo=A&contrasena=" + contra);
                var ingresar = JsonConvert.DeserializeObject<Boolean>(json);
                // Boolean ingresar = us.Login(user,"A",contra);
                if (ingresar)
                {
                    
                    MetodosPresentacion.abrirForm(new Menu());
                    MetodosPresentacion.usuario = user;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(this,"Datos Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

       


       
    }
}
