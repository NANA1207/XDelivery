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
    public partial class PedidosForm : Form
    {
        PedidoEntidad pedido = new PedidoEntidad();
        List<ProductoEntidad> listaProductos = new List<ProductoEntidad>();
        UsuarioEntidad cliente = new UsuarioEntidad();
        UsuarioEntidad repartidor = new UsuarioEntidad();
        double total;
        string identificador = "";
        
        public PedidosForm()
        {
            InitializeComponent();
            panel_ContenedorNuevoPedidos.Visible = false;
            CargarComboBoxEstado();
            buttonAgregarRepartidor.Enabled = false;
            MetodosPresentacion.enviarObjeto(null, "no objeto");

        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxPedidosEstado.SelectedValue.ToString();
            cargarTablaPedidos(selectedValue);
        }

        private void buttonNuevoPedido_Click(object sender, EventArgs e)
        {
            
            panel_ContenedorNuevoPedidos.Visible = true;

            
          
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

    

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_ContenedorNuevoPedido_Paint(object sender, PaintEventArgs e)
        {
            var ac = MetodosPresentacion.obtenerActualizacion();
            if (ac==1)
            {
                cargarTablaPedidos("t");
                MetodosPresentacion.cancelarActualizacion();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_ContenedorNuevoPedidos.Visible = false;
            vaciarCampos();
        }

        private void vaciarCampos()
        {
            textBoxClienteAsignado.Text = "";
            textBoxRepartidorAsignado.Text ="";
            textBoxDireccion.Text = "";
            var item = checkedListBoxProductos.Items.Count;
            for (int i = 0; i < item; i++)
            {
                checkedListBoxProductos.SetItemChecked(i, false);
            }
            listaProductos.Clear();
            /* for (int i = 0; i < listaProductos.Count; i++)
             {
                 listaProductos.RemoveAt(i);
             }*/


            cliente =null;
            repartidor = null;
            identificador = "";
            
            MetodosPresentacion.enviarObjeto(cliente,identificador);
  
        }

        private void buttonAsignarCliente_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarTexto("Cliente","C");
           // MetodosPresentacion.abrirForm(new ListaUsuariosForm());
            MetodosPresentacion.abrirDialogo(new ListaUsuariosForm(), this);
            
        }

        private void buttonAsignarRepartidorNuevoP_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarTexto("Repartidor","R");
            MetodosPresentacion.abrirDialogo(new ListaUsuariosForm(), this);
        }

        private void buttonAgregarRepartidor_Click(object sender, EventArgs e)
        {
            MetodosPresentacion.enviarObjeto(pedido,"pedido");
            MetodosPresentacion.enviarTexto("Repartidor","R");
            MetodosPresentacion.abrirDialogo(new ListaUsuariosForm(), this);
            
        }
        //carga los datos de la tabla dinamicamente.
        public void cargarTablaPedidos(string estado)
        {
            var json=" ";
            if (estado.Equals("t"))
            {
                 json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Pedidos.svc/DevolverListadoPedidos");

            }
            else
            {
                 json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Pedidos.svc/cargarPedidosPorEstado?estado=" + estado);
            }
            var resultado = JsonConvert.DeserializeObject<DataTable>(json);
            dataGridViewListaPedidos.DataSource = resultado;
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {
            cargarTablaPedidos("t");
            cargarProductos();


        }
        //carga combobox
        private void CargarComboBoxEstado()
        {


            comboBoxPedidosEstado.DisplayMember = "estado";
            comboBoxPedidosEstado.ValueMember = "id";
            comboBoxPedidosEstado.SelectedValue = "t";

            var estados = new[] {
            new { estado = "Todos", id = "t" },
            new { estado = "No asignados", id = "na" },
            new { estado = "Pendientes", id = "p" },
            new { estado = "Entregados", id = "e" },
            };
            comboBoxPedidosEstado.DataSource = estados;
                               
        }

        private void dataGridViewListaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dataGridViewListaPedidos.CurrentRow;
            if (filaSeleccionada != null&& !filaSeleccionada.Cells[5].Value.ToString().Equals(""))
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[5].Value);

                obtenerPedido(id);
            }

        }
        //obtiene el pedido para enviar la entidad pedido y habilita el boton de "asignar Repartidor"
        private void obtenerPedido(int id)
        {

            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Pedidos.svc/ObtenerPedidoPorId?id=" + id);
             pedido = JsonConvert.DeserializeObject<PedidoEntidad>(json);
            
             if (pedido.EstadoPedido.Equals("na")|| pedido.EstadoPedido.Equals("Na"))
             {
                 buttonAgregarRepartidor.Enabled = true;
                 
             }
             else
             {
                 buttonAgregarRepartidor.Enabled = false;
             }
        }
        //obtiene el nombre del usuario para asignarlo en un nuevo pedido
        private void obtenerNombreUsuario()
        {
            identificador = MetodosPresentacion.obtenerIdentificador();
            //UsuarioEntidad usuario = (UsuarioEntidad)MetodosPresentacion.obtenerObjeto();
            if (identificador.Equals("usuario") )
            {
                UsuarioEntidad usuario = (UsuarioEntidad)MetodosPresentacion.obtenerObjeto();
                if (usuario != null) {
                    if (usuario.TipoUsuario.Equals("C"))
                    {
                        cliente = usuario;
                        textBoxClienteAsignado.Text = cliente.Nombre + " " + cliente.Apellido;
                    }
                    else if (usuario.TipoUsuario.Equals("R"))
                    {
                        repartidor = usuario;
                        textBoxRepartidorAsignado.Text = repartidor.Nombre + " " + repartidor.Apellido;
                    }
                }
            }
            else
            {
                textBoxClienteAsignado.Text = "";
                textBoxRepartidorAsignado.Text = "";
            }
        }

        private void panel_ContenedorNuevoPedidos_Paint(object sender, PaintEventArgs e)
        {
            obtenerNombreUsuario();
            

        }

        private void dataGridViewListaPedidos_Paint(object sender, PaintEventArgs e)
        {
            //cargarTablaPedidos("t");
        }

        private void buttonGuardarNuevoPedido_Click(object sender, EventArgs e)
        {
            cargarTablaPedidos("t");
            guardarPedido();
            vaciarCampos();
            panel_ContenedorNuevoPedidos.Visible = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cargarProductos()
        {
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Productos.svc/DevolverListadoProductos");
            var productos = JsonConvert.DeserializeObject<List<ProductoEntidad>>(json);
            checkedListBoxProductos.DataSource = productos;
            checkedListBoxProductos.ValueMember = "IdProducto";
            checkedListBoxProductos.DisplayMember = "NombreProducto";


        }

        private void cargarProductoEnTabla(int id)
        {
            var eliminado = false;
            var json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Productos.svc/DevolverProductoPorId?id=" + id);
            var producto = JsonConvert.DeserializeObject<ProductoEntidad>(json);
            
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].IdProducto == producto.IdProducto)
                {
                    listaProductos.RemoveAt(i);
                    dataGridViewProductos.DataSource = listaProductos.ToList();
                    eliminado = true;
                    break;
                }
                
            }
            if (!eliminado)
            {
                producto.Cantidad = 1;
                listaProductos.Add(producto);
                dataGridViewProductos.DataSource = listaProductos.ToList();
            }

           
        }

        private void calcularTotal()
        {
            var acumulador = 0.00;
            for (int i = 0; i < listaProductos.Count; i++)
            {

                acumulador += (listaProductos[i].Cantidad * listaProductos[i].PrecioProducto);

            }
            total = acumulador;
            labelTotal.Text = acumulador.ToString()+' '+'$';
        }

        private void checkedListBoxProductos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            var id = Convert.ToInt32(checkedListBoxProductos.SelectedValue);
            cargarProductoEnTabla(id);
            calcularTotal();

            
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calcularTotal();
        }
        //guardar pedidos
        private void guardarPedido()
        {
            
            var idCliente = cliente.IdUsuario;
            
            //var idRepartidor = repartidor.IdUsuario;
            var direccion = textBoxDireccion.Text;
            var fecha = dateTimePickerFecha.Value.ToString();
            
            
            if (textBoxClienteAsignado.Text.Equals("") || direccion == "" || fecha == null || listaProductos.Count==0)
            {
                MessageBox.Show(this, "Llenar todos los campos ", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel_ContenedorNuevoPedidos.Visible = true;

            }
            else
            {
                var json = "";
                if (textBoxRepartidorAsignado.Text.Equals(""))
                {
                    //id del repartidor se enviara como 1 debido a que ese es el usuario "no asignado" por defecto
                    

                      json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Pedidos.svc/GuardarPedidoGet?idCliente=" + idCliente + "&idRepartidor=1" + "&direccion=" + direccion +"&estado=Na&fecha=" + fecha+"&total=" + total+ "&eInicial=C"  );
                }
                else
                {
                    var idRepartidor = repartidor.IdUsuario;
                    json = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Pedidos.svc/GuardarPedidoGet?idCliente=" + idCliente + "&idRepartidor="+idRepartidor+"&direccion=" +direccion+"&estado=P&fecha=" + fecha +"&total=" + total + "&eInicial=C");
                }  
                    var pedidoGuardado = JsonConvert.DeserializeObject<PedidoEntidad>(json);
                //guarda detalle del pedido
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    var jsonDetalle = (new WebClient()).DownloadString("http://proyectoFinal.somee.com/proyectoFinal/Pedidos.svc/GuardarDetalleGet?pedido=" + pedidoGuardado.IdPedido+"&producto="+listaProductos[i].IdProducto+"&cantidad="+listaProductos[i].Cantidad);
                }

                MessageBox.Show(this, "Pedido guardado Correctamente ", "Pedido Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
