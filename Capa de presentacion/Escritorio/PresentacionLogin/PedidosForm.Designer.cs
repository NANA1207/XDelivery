
namespace PresentacionLogin
{
    partial class PedidosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewListaPedidos = new System.Windows.Forms.DataGridView();
            this.comboBoxPedidosEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNuevoPedido = new System.Windows.Forms.Button();
            this.buttonAgregarRepartidor = new System.Windows.Forms.Button();
            this.panel_ContenedorNuevoPedidos = new System.Windows.Forms.Panel();
            this.buttonGuardarNuevoPedido = new System.Windows.Forms.Button();
            this.buttonCancelarNuevoPedido = new System.Windows.Forms.Button();
            this.checkedListBoxProductos = new System.Windows.Forms.CheckedListBox();
            this.textBoxRepartidorAsignado = new System.Windows.Forms.TextBox();
            this.textBoxClienteAsignado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.buttonAsignarRepartidorNuevoP = new System.Windows.Forms.Button();
            this.buttonAsignarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_ContenedorPedido = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCLIENTE_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDREPARTIDOR_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REP_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIR_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EST_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOT_PED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPedidos)).BeginInit();
            this.panel_ContenedorNuevoPedidos.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel_ContenedorPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewListaPedidos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 317);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // dataGridViewListaPedidos
            // 
            this.dataGridViewListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PED,
            this.Estado,
            this.FECHA_PED,
            this.IDCLIENTE_PED,
            this.IDREPARTIDOR_PED,
            this.CLI_PED,
            this.REP_PED,
            this.DIR_PED,
            this.EST_PED,
            this.TOT_PED});
            this.dataGridViewListaPedidos.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewListaPedidos.Name = "dataGridViewListaPedidos";
            this.dataGridViewListaPedidos.Size = new System.Drawing.Size(775, 314);
            this.dataGridViewListaPedidos.TabIndex = 0;
            this.dataGridViewListaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaPedidos_CellClick);
            this.dataGridViewListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewListaPedidos.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewListaPedidos_Paint);
            // 
            // comboBoxPedidosEstado
            // 
            this.comboBoxPedidosEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBoxPedidosEstado.FormattingEnabled = true;
            this.comboBoxPedidosEstado.Location = new System.Drawing.Point(170, 44);
            this.comboBoxPedidosEstado.Name = "comboBoxPedidosEstado";
            this.comboBoxPedidosEstado.Size = new System.Drawing.Size(138, 26);
            this.comboBoxPedidosEstado.TabIndex = 1;
            this.comboBoxPedidosEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado del pedido:";
            // 
            // buttonNuevoPedido
            // 
            this.buttonNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonNuevoPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNuevoPedido.Location = new System.Drawing.Point(665, 44);
            this.buttonNuevoPedido.Name = "buttonNuevoPedido";
            this.buttonNuevoPedido.Size = new System.Drawing.Size(126, 33);
            this.buttonNuevoPedido.TabIndex = 4;
            this.buttonNuevoPedido.Text = "Nuevo Pedido";
            this.buttonNuevoPedido.UseVisualStyleBackColor = false;
            this.buttonNuevoPedido.Click += new System.EventHandler(this.buttonNuevoPedido_Click);
            // 
            // buttonAgregarRepartidor
            // 
            this.buttonAgregarRepartidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAgregarRepartidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonAgregarRepartidor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregarRepartidor.Location = new System.Drawing.Point(13, 428);
            this.buttonAgregarRepartidor.Name = "buttonAgregarRepartidor";
            this.buttonAgregarRepartidor.Size = new System.Drawing.Size(162, 33);
            this.buttonAgregarRepartidor.TabIndex = 5;
            this.buttonAgregarRepartidor.Text = "Asignar Repartidor";
            this.buttonAgregarRepartidor.UseVisualStyleBackColor = false;
            this.buttonAgregarRepartidor.Click += new System.EventHandler(this.buttonAgregarRepartidor_Click);
            // 
            // panel_ContenedorNuevoPedidos
            // 
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.buttonGuardarNuevoPedido);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.buttonCancelarNuevoPedido);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.checkedListBoxProductos);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.textBoxRepartidorAsignado);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.textBoxClienteAsignado);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.label8);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.labelTotal);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.label6);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.flowLayoutPanel2);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.label5);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.dateTimePickerFecha);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.textBoxDireccion);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.buttonAsignarRepartidorNuevoP);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.buttonAsignarCliente);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.label4);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.label3);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.label9);
            this.panel_ContenedorNuevoPedidos.Controls.Add(this.label10);
            this.panel_ContenedorNuevoPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContenedorNuevoPedidos.Location = new System.Drawing.Point(0, 0);
            this.panel_ContenedorNuevoPedidos.Name = "panel_ContenedorNuevoPedidos";
            this.panel_ContenedorNuevoPedidos.Size = new System.Drawing.Size(803, 492);
            this.panel_ContenedorNuevoPedidos.TabIndex = 6;
            this.panel_ContenedorNuevoPedidos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ContenedorNuevoPedidos_Paint);
            // 
            // buttonGuardarNuevoPedido
            // 
            this.buttonGuardarNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonGuardarNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonGuardarNuevoPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardarNuevoPedido.Location = new System.Drawing.Point(462, 373);
            this.buttonGuardarNuevoPedido.Name = "buttonGuardarNuevoPedido";
            this.buttonGuardarNuevoPedido.Size = new System.Drawing.Size(114, 29);
            this.buttonGuardarNuevoPedido.TabIndex = 36;
            this.buttonGuardarNuevoPedido.Text = "Guardar";
            this.buttonGuardarNuevoPedido.UseVisualStyleBackColor = false;
            this.buttonGuardarNuevoPedido.Click += new System.EventHandler(this.buttonGuardarNuevoPedido_Click);
            // 
            // buttonCancelarNuevoPedido
            // 
            this.buttonCancelarNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancelarNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonCancelarNuevoPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancelarNuevoPedido.Location = new System.Drawing.Point(637, 373);
            this.buttonCancelarNuevoPedido.Name = "buttonCancelarNuevoPedido";
            this.buttonCancelarNuevoPedido.Size = new System.Drawing.Size(114, 29);
            this.buttonCancelarNuevoPedido.TabIndex = 35;
            this.buttonCancelarNuevoPedido.Text = "Cancelar";
            this.buttonCancelarNuevoPedido.UseVisualStyleBackColor = false;
            this.buttonCancelarNuevoPedido.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkedListBoxProductos
            // 
            this.checkedListBoxProductos.FormattingEnabled = true;
            this.checkedListBoxProductos.Location = new System.Drawing.Point(129, 284);
            this.checkedListBoxProductos.Name = "checkedListBoxProductos";
            this.checkedListBoxProductos.Size = new System.Drawing.Size(154, 169);
            this.checkedListBoxProductos.TabIndex = 34;
            this.checkedListBoxProductos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxProductos_ItemCheck);
            this.checkedListBoxProductos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBoxRepartidorAsignado
            // 
            this.textBoxRepartidorAsignado.Enabled = false;
            this.textBoxRepartidorAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxRepartidorAsignado.Location = new System.Drawing.Point(129, 144);
            this.textBoxRepartidorAsignado.Name = "textBoxRepartidorAsignado";
            this.textBoxRepartidorAsignado.Size = new System.Drawing.Size(176, 24);
            this.textBoxRepartidorAsignado.TabIndex = 33;
            // 
            // textBoxClienteAsignado
            // 
            this.textBoxClienteAsignado.Enabled = false;
            this.textBoxClienteAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxClienteAsignado.Location = new System.Drawing.Point(129, 100);
            this.textBoxClienteAsignado.Name = "textBoxClienteAsignado";
            this.textBoxClienteAsignado.Size = new System.Drawing.Size(176, 24);
            this.textBoxClienteAsignado.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(31, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Productos:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(544, 306);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(78, 25);
            this.labelTotal.TabIndex = 30;
            this.labelTotal.Text = "0.00 $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(454, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dataGridViewProductos);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(459, 98);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(317, 155);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.PrecioProducto,
            this.Cantidad});
            this.dataGridViewProductos.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(314, 150);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            this.dataGridViewProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellValueChanged);
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IDPRODUCTO";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "PRODUCTO";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.DataPropertyName = "PrecioProducto";
            this.PrecioProducto.HeaderText = "PRECIO";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(362, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nuevo Pedido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(129, 235);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerFecha.TabIndex = 26;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxDireccion.Location = new System.Drawing.Point(129, 192);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(296, 24);
            this.textBoxDireccion.TabIndex = 25;
            // 
            // buttonAsignarRepartidorNuevoP
            // 
            this.buttonAsignarRepartidorNuevoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonAsignarRepartidorNuevoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonAsignarRepartidorNuevoP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAsignarRepartidorNuevoP.Location = new System.Drawing.Point(311, 142);
            this.buttonAsignarRepartidorNuevoP.Name = "buttonAsignarRepartidorNuevoP";
            this.buttonAsignarRepartidorNuevoP.Size = new System.Drawing.Size(114, 29);
            this.buttonAsignarRepartidorNuevoP.TabIndex = 24;
            this.buttonAsignarRepartidorNuevoP.Text = "Asignar";
            this.buttonAsignarRepartidorNuevoP.UseVisualStyleBackColor = false;
            this.buttonAsignarRepartidorNuevoP.Click += new System.EventHandler(this.buttonAsignarRepartidorNuevoP_Click);
            // 
            // buttonAsignarCliente
            // 
            this.buttonAsignarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonAsignarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonAsignarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAsignarCliente.Location = new System.Drawing.Point(311, 98);
            this.buttonAsignarCliente.Name = "buttonAsignarCliente";
            this.buttonAsignarCliente.Size = new System.Drawing.Size(114, 29);
            this.buttonAsignarCliente.TabIndex = 23;
            this.buttonAsignarCliente.Text = "Asignar";
            this.buttonAsignarCliente.UseVisualStyleBackColor = false;
            this.buttonAsignarCliente.Click += new System.EventHandler(this.buttonAsignarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(31, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Repartidor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(31, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(31, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cliente:";
            // 
            // panel_ContenedorPedido
            // 
            this.panel_ContenedorPedido.Controls.Add(this.panel_ContenedorNuevoPedidos);
            this.panel_ContenedorPedido.Controls.Add(this.label2);
            this.panel_ContenedorPedido.Controls.Add(this.buttonAgregarRepartidor);
            this.panel_ContenedorPedido.Controls.Add(this.comboBoxPedidosEstado);
            this.panel_ContenedorPedido.Controls.Add(this.flowLayoutPanel1);
            this.panel_ContenedorPedido.Controls.Add(this.buttonNuevoPedido);
            this.panel_ContenedorPedido.Controls.Add(this.label1);
            this.panel_ContenedorPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContenedorPedido.Location = new System.Drawing.Point(0, 0);
            this.panel_ContenedorPedido.Name = "panel_ContenedorPedido";
            this.panel_ContenedorPedido.Size = new System.Drawing.Size(803, 492);
            this.panel_ContenedorPedido.TabIndex = 6;
            this.panel_ContenedorPedido.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ContenedorNuevoPedido_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos";
            // 
            // ID_PED
            // 
            this.ID_PED.DataPropertyName = "IdPedido";
            this.ID_PED.HeaderText = "ID";
            this.ID_PED.Name = "ID_PED";
            this.ID_PED.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // FECHA_PED
            // 
            this.FECHA_PED.DataPropertyName = "FechaPedido";
            this.FECHA_PED.HeaderText = "FECHA";
            this.FECHA_PED.Name = "FECHA_PED";
            this.FECHA_PED.ReadOnly = true;
            // 
            // IDCLIENTE_PED
            // 
            this.IDCLIENTE_PED.DataPropertyName = "IdClientePedido";
            this.IDCLIENTE_PED.HeaderText = "IDCLIENTE";
            this.IDCLIENTE_PED.Name = "IDCLIENTE_PED";
            this.IDCLIENTE_PED.ReadOnly = true;
            this.IDCLIENTE_PED.Visible = false;
            // 
            // IDREPARTIDOR_PED
            // 
            this.IDREPARTIDOR_PED.DataPropertyName = "IdRepartidorPedido";
            this.IDREPARTIDOR_PED.HeaderText = "IDREPARTIDOR";
            this.IDREPARTIDOR_PED.Name = "IDREPARTIDOR_PED";
            this.IDREPARTIDOR_PED.ReadOnly = true;
            this.IDREPARTIDOR_PED.Visible = false;
            // 
            // CLI_PED
            // 
            this.CLI_PED.DataPropertyName = "NombreC";
            this.CLI_PED.HeaderText = "CLIENTE";
            this.CLI_PED.Name = "CLI_PED";
            this.CLI_PED.ReadOnly = true;
            // 
            // REP_PED
            // 
            this.REP_PED.DataPropertyName = "NombreR";
            this.REP_PED.HeaderText = "REPARTIDOR";
            this.REP_PED.Name = "REP_PED";
            this.REP_PED.ReadOnly = true;
            // 
            // DIR_PED
            // 
            this.DIR_PED.DataPropertyName = "Direccion";
            this.DIR_PED.HeaderText = "DIRECCIÓN";
            this.DIR_PED.Name = "DIR_PED";
            this.DIR_PED.ReadOnly = true;
            // 
            // EST_PED
            // 
            this.EST_PED.DataPropertyName = "EstadoPedido";
            this.EST_PED.HeaderText = "ESTADO";
            this.EST_PED.Name = "EST_PED";
            this.EST_PED.ReadOnly = true;
            // 
            // TOT_PED
            // 
            this.TOT_PED.DataPropertyName = "TotalPedido";
            this.TOT_PED.HeaderText = "TOTAL";
            this.TOT_PED.Name = "TOT_PED";
            this.TOT_PED.ReadOnly = true;
            // 
            // PedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 492);
            this.Controls.Add(this.panel_ContenedorPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.PedidosForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPedidos)).EndInit();
            this.panel_ContenedorNuevoPedidos.ResumeLayout(false);
            this.panel_ContenedorNuevoPedidos.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel_ContenedorPedido.ResumeLayout(false);
            this.panel_ContenedorPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewListaPedidos;
        private System.Windows.Forms.ComboBox comboBoxPedidosEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAgregarRepartidor;
        public System.Windows.Forms.Button buttonNuevoPedido;
        private System.Windows.Forms.Panel panel_ContenedorNuevoPedidos;
        private System.Windows.Forms.Panel panel_ContenedorPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardarNuevoPedido;
        private System.Windows.Forms.Button buttonCancelarNuevoPedido;
        private System.Windows.Forms.CheckedListBox checkedListBoxProductos;
        private System.Windows.Forms.TextBox textBoxRepartidorAsignado;
        private System.Windows.Forms.TextBox textBoxClienteAsignado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Button buttonAsignarRepartidorNuevoP;
        private System.Windows.Forms.Button buttonAsignarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLIENTE_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDREPARTIDOR_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn REP_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIR_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn EST_PED;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOT_PED;
    }
}