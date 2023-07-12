using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLogin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {

        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {

        }

        private void buttonRepartidores_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.AbrirFormHijo(new PedidosForm(), this.panel_Contenedor);
        }

        private void linkLabelSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cerrarSesion();
        }

        private void linkLabelPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MetodosPresentacion.AbrirFormHijo(new PerfilForm(), this.panel_Contenedor);
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxPerfil_Click(object sender, EventArgs e)
        {
            
            MetodosPresentacion.AbrirFormHijo(new PerfilForm(), this.panel_Contenedor);
        }

        private void linkLabelPedidos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            MetodosPresentacion.AbrirFormHijo(new PedidosForm(), this.panel_Contenedor);
            
            
        }

        private void linkLabelRepartidores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MetodosPresentacion.AbrirFormHijo(new RepartidoresForm(), panel_Contenedor);
        }

        private void linkLabelReportes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MetodosPresentacion.AbrirFormHijo(new ReportesForm(), panel_Contenedor);
        }

        private void pictureBoxReportes_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.AbrirFormHijo(new ReportesForm(), panel_Contenedor);
        }

        private void pictureBoxRepartidores_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.AbrirFormHijo(new RepartidoresForm(), panel_Contenedor);
        }

        private void cerrarSesion()
        {
            string mensaje = "¿Está seguro de Cerrar Sesión?";
            string caption = "Cerrar Sesión";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensaje, caption, botones, MessageBoxIcon.Question);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MetodosPresentacion.abrirForm(new Form1());
                MetodosPresentacion.controlador = 0;
                this.Hide();
            }

        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Está seguro de Cerrar la Aplicación?\n Si los datos no estan guardados,\n estos se eliminarán.";
            string caption = "Cerrar Sesión";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensaje, caption, botones, MessageBoxIcon.Warning);
            if (resultado == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel=true;
            }

        }

        
    }
}
