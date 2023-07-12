using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Entidades;

namespace PresentacionLogin
{
    
    public partial class ReportesForm : Form
    {
        List<ConsultasEntidad> resultado = new List<ConsultasEntidad>();
        ReporteEntidad reporte = new ReporteEntidad();
        public ReportesForm()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void buttonBuscarPedidos_Click(object sender, EventArgs e)
        {
            cargarReporte();
            panelImagen.Visible = false;
        }

       

        private void CargarComboBox()
        {

            //cantidad Datos
            comboBoxCantidadDatos.DisplayMember = "nombre";
            comboBoxCantidadDatos.ValueMember = "id";
            comboBoxCantidadDatos.SelectedItem = 1;

            var cantidad = new[] {
            new { nombre = "5", id = 5 },
            new { nombre = "10", id = 10 },
            new { nombre = "20", id = 20 },
            
            };
            comboBoxCantidadDatos.DataSource = cantidad;

            //cargar comboBox periodo tiempo
            comboBoxPeriodoTiempo.DisplayMember = "periodo";
            comboBoxPeriodoTiempo.ValueMember = "id";
            comboBoxPeriodoTiempo.SelectedItem = 1;

            var periodos = new[] {
            new { periodo = "Este Año", id = 'a' },
            new { periodo = "Ultimos 3 Meses", id = '3' },
            new { periodo = "Ultimos 6 Meses", id = '6' },

            };
            comboBoxPeriodoTiempo.DataSource = periodos;

            //cargar comboBox tipo
            comboBoxTipoReporte.DisplayMember = "tipo";
            comboBoxTipoReporte.ValueMember = "id";
            comboBoxTipoReporte.SelectedItem = 1;

            var tipos = new[] {
            new { tipo = "Repartidores", id = "r" },
            new { tipo = "Clientes", id = "c" },
            new { tipo = "Productos", id = "p" },

            };
            comboBoxTipoReporte.DataSource = tipos;

            //cargar comBox Filtro

            comboBoxFiltro.DisplayMember = "filtro";
            comboBoxFiltro.ValueMember = "id";
            comboBoxFiltro.SelectedItem = 1;

            var filtros = new[] {
            new { filtro = "Monto", id = "monto" },
            new { filtro = "Cantidad", id = "cantidad" },
            

            };
            comboBoxFiltro.DataSource = filtros;
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {



            /* this.reportViewer1.RefreshReport();
             this.reportViewer1.RefreshReport();*/
            this.reportViewer1.RefreshReport();
        }

        private void cargarReporte()
        {
            var tipo = comboBoxTipoReporte.SelectedValue;
            reporte.FechaReporte = DateTime.Now;
            reporte.FechaFin= DateTime.Now;
            devolverFechaInicial();
            var cantidad = comboBoxCantidadDatos.SelectedValue;
            var filtro = comboBoxFiltro.SelectedValue;

            switch (tipo)
            {
                case "r":
                         
                    reporte.Titulo = "Reporte de Repartidores";
                    var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Consultas.svc/ConsultaRepartidores?fechaInicial=" + reporte.FechaInicio+"&fechaFinal="+reporte.FechaFin+"&cantidad="+cantidad+"&filtro="+filtro);
                    resultado = JsonConvert.DeserializeObject<List<ConsultasEntidad>>(json);
                    ConsultasEntidadBindingSource.DataSource = resultado;
                    ReporteEntidadBindingSource.DataSource = reporte;
                    this.reportViewer1.RefreshReport();

                    break;
                case "c":
                    reporte.Titulo = "Reporte de Repartidores";
                    json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Consultas.svc/ConsultaClientes?fechaInicial=" + reporte.FechaInicio + "&fechaFinal=" + reporte.FechaFin + "&cantidad=" + cantidad + "&filtro=" + filtro);
                    resultado = JsonConvert.DeserializeObject<List<ConsultasEntidad>>(json);
                    ConsultasEntidadBindingSource.DataSource = resultado;
                    ReporteEntidadBindingSource.DataSource = reporte;
                    this.reportViewer1.RefreshReport();
                    break;
                case "p":
                    reporte.Titulo = "Reporte de Repartidores";
                    json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Consultas.svc/ConsultaProductos?fechaInicial=" + reporte.FechaInicio + "&fechaFinal=" + reporte.FechaFin + "&cantidad=" + cantidad + "&filtro=" + filtro);
                    resultado = JsonConvert.DeserializeObject<List<ConsultasEntidad>>(json);
                    ConsultasEntidadBindingSource.DataSource = resultado;
                    ReporteEntidadBindingSource.DataSource = reporte;
                    this.reportViewer1.RefreshReport();
                    break;
            }
        }
        // devuelve la fechaInicial segun la eleccion del comboBoxPeriodoTiempo
        private void devolverFechaInicial()
        {
            var periodo = comboBoxPeriodoTiempo.SelectedValue;
            var mes =new DateTime() ;
            switch (periodo)
            {
                case 'a':
                    reporte.FechaInicio = new DateTime(DateTime.Now.Year,1,1);
                    break;

                case '6':
                    mes= DateTime.Today.AddMonths(-6);
                    reporte.FechaInicio = new DateTime(DateTime.Now.Year, mes.Month, 1);

                    break;
                case '3':
                    mes = DateTime.Today.AddMonths(-3);
                    reporte.FechaInicio = new DateTime(DateTime.Now.Year, mes.Month, 1);
                    break;
            }
        }
        
    }
}
