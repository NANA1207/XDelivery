
namespace PresentacionLogin
{
    partial class ListaUsuariosForm
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
            this.labelUsuarioTitulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.USU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USU_USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USU_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USU_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USU_CONTRASENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USU_ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USU_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            this.buttonAsignarUsuario = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.panel_ContenedorUsuario = new System.Windows.Forms.Panel();
            this.panel_ContenedorNuevoUsuario = new System.Windows.Forms.Panel();
            this.labelNuevoUsuario = new System.Windows.Forms.Label();
            this.buttonCancelarUsuario = new System.Windows.Forms.Button();
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNuevoApelidoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNuevoContrasenaUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNuevoUsernameUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNuevoNombreUsuario = new System.Windows.Forms.TextBox();
            this.textIdUsuario = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.panel_ContenedorUsuario.SuspendLayout();
            this.panel_ContenedorNuevoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsuarioTitulo
            // 
            this.labelUsuarioTitulo.AutoSize = true;
            this.labelUsuarioTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.labelUsuarioTitulo.Location = new System.Drawing.Point(137, 7);
            this.labelUsuarioTitulo.Name = "labelUsuarioTitulo";
            this.labelUsuarioTitulo.Size = new System.Drawing.Size(93, 25);
            this.labelUsuarioTitulo.TabIndex = 0;
            this.labelUsuarioTitulo.Text = "Usuario";
            this.labelUsuarioTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewUsuarios);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 241);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USU_ID,
            this.USU_USERNAME,
            this.USU_NOMBRE,
            this.USU_APELLIDO,
            this.USU_CONTRASENA,
            this.USU_ESTADO,
            this.USU_TIPO});
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(344, 235);
            this.dataGridViewUsuarios.TabIndex = 0;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // USU_ID
            // 
            this.USU_ID.DataPropertyName = "IdUsuario";
            this.USU_ID.HeaderText = "ID";
            this.USU_ID.Name = "USU_ID";
            this.USU_ID.ReadOnly = true;
            this.USU_ID.Visible = false;
            // 
            // USU_USERNAME
            // 
            this.USU_USERNAME.DataPropertyName = "Username";
            this.USU_USERNAME.HeaderText = "USERNAME";
            this.USU_USERNAME.Name = "USU_USERNAME";
            this.USU_USERNAME.ReadOnly = true;
            // 
            // USU_NOMBRE
            // 
            this.USU_NOMBRE.DataPropertyName = "Nombre";
            this.USU_NOMBRE.HeaderText = "NOMBRE";
            this.USU_NOMBRE.Name = "USU_NOMBRE";
            this.USU_NOMBRE.ReadOnly = true;
            // 
            // USU_APELLIDO
            // 
            this.USU_APELLIDO.DataPropertyName = "Apellido";
            this.USU_APELLIDO.HeaderText = "APELLIDO";
            this.USU_APELLIDO.Name = "USU_APELLIDO";
            this.USU_APELLIDO.ReadOnly = true;
            // 
            // USU_CONTRASENA
            // 
            this.USU_CONTRASENA.DataPropertyName = "Contrasena";
            this.USU_CONTRASENA.HeaderText = "CONTRASENA";
            this.USU_CONTRASENA.Name = "USU_CONTRASENA";
            this.USU_CONTRASENA.ReadOnly = true;
            this.USU_CONTRASENA.Visible = false;
            // 
            // USU_ESTADO
            // 
            this.USU_ESTADO.DataPropertyName = "EstadoUsuario";
            this.USU_ESTADO.HeaderText = "ESTADO";
            this.USU_ESTADO.Name = "USU_ESTADO";
            this.USU_ESTADO.ReadOnly = true;
            this.USU_ESTADO.Visible = false;
            // 
            // USU_TIPO
            // 
            this.USU_TIPO.DataPropertyName = "TipoUsuario";
            this.USU_TIPO.HeaderText = "TIPO";
            this.USU_TIPO.Name = "USU_TIPO";
            this.USU_TIPO.ReadOnly = true;
            this.USU_TIPO.Visible = false;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(8, 77);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(146, 24);
            this.textBoxNombreUsuario.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelUsuario.Location = new System.Drawing.Point(11, 42);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 18);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonAgregarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(263, 73);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(91, 32);
            this.buttonAgregarUsuario.TabIndex = 4;
            this.buttonAgregarUsuario.Text = "Nuevo";
            this.buttonAgregarUsuario.UseVisualStyleBackColor = false;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // buttonAsignarUsuario
            // 
            this.buttonAsignarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonAsignarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonAsignarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAsignarUsuario.Location = new System.Drawing.Point(160, 385);
            this.buttonAsignarUsuario.Name = "buttonAsignarUsuario";
            this.buttonAsignarUsuario.Size = new System.Drawing.Size(88, 32);
            this.buttonAsignarUsuario.TabIndex = 5;
            this.buttonAsignarUsuario.Text = "Asignar";
            this.buttonAsignarUsuario.UseVisualStyleBackColor = false;
            this.buttonAsignarUsuario.Click += new System.EventHandler(this.buttonAsignarUsuario_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(263, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonBuscarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(160, 73);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(88, 32);
            this.buttonBuscarUsuario.TabIndex = 7;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel_ContenedorUsuario
            // 
            this.panel_ContenedorUsuario.Controls.Add(this.panel_ContenedorNuevoUsuario);
            this.panel_ContenedorUsuario.Controls.Add(this.labelUsuarioTitulo);
            this.panel_ContenedorUsuario.Controls.Add(this.buttonBuscarUsuario);
            this.panel_ContenedorUsuario.Controls.Add(this.flowLayoutPanel1);
            this.panel_ContenedorUsuario.Controls.Add(this.button3);
            this.panel_ContenedorUsuario.Controls.Add(this.textBoxNombreUsuario);
            this.panel_ContenedorUsuario.Controls.Add(this.buttonAsignarUsuario);
            this.panel_ContenedorUsuario.Controls.Add(this.labelUsuario);
            this.panel_ContenedorUsuario.Controls.Add(this.buttonAgregarUsuario);
            this.panel_ContenedorUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContenedorUsuario.Location = new System.Drawing.Point(0, 0);
            this.panel_ContenedorUsuario.Name = "panel_ContenedorUsuario";
            this.panel_ContenedorUsuario.Size = new System.Drawing.Size(375, 450);
            this.panel_ContenedorUsuario.TabIndex = 8;
            // 
            // panel_ContenedorNuevoUsuario
            // 
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.labelNuevoUsuario);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.buttonCancelarUsuario);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.buttonGuardarUsuario);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.label5);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.label4);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.label3);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.label2);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.label6);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.textBoxNuevoApelidoUsuario);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.textBoxNuevoContrasenaUsuario);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.textBoxNuevoUsernameUsuario);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.textBoxNuevoNombreUsuario);
            this.panel_ContenedorNuevoUsuario.Controls.Add(this.textIdUsuario);
            this.panel_ContenedorNuevoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContenedorNuevoUsuario.Location = new System.Drawing.Point(0, 0);
            this.panel_ContenedorNuevoUsuario.Name = "panel_ContenedorNuevoUsuario";
            this.panel_ContenedorNuevoUsuario.Size = new System.Drawing.Size(375, 450);
            this.panel_ContenedorNuevoUsuario.TabIndex = 9;
            this.panel_ContenedorNuevoUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ContenedorNuevoUsuario_Paint);
            // 
            // labelNuevoUsuario
            // 
            this.labelNuevoUsuario.AutoSize = true;
            this.labelNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.labelNuevoUsuario.Location = new System.Drawing.Point(103, 11);
            this.labelNuevoUsuario.Name = "labelNuevoUsuario";
            this.labelNuevoUsuario.Size = new System.Drawing.Size(79, 25);
            this.labelNuevoUsuario.TabIndex = 40;
            this.labelNuevoUsuario.Text = "Nuevo";
            // 
            // buttonCancelarUsuario
            // 
            this.buttonCancelarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancelarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancelarUsuario.Location = new System.Drawing.Point(263, 385);
            this.buttonCancelarUsuario.Name = "buttonCancelarUsuario";
            this.buttonCancelarUsuario.Size = new System.Drawing.Size(91, 32);
            this.buttonCancelarUsuario.TabIndex = 39;
            this.buttonCancelarUsuario.Text = "Cancelar";
            this.buttonCancelarUsuario.UseVisualStyleBackColor = false;
            this.buttonCancelarUsuario.Click += new System.EventHandler(this.buttonCancelarUsuario_Click);
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonGuardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(160, 385);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(88, 32);
            this.buttonGuardarUsuario.TabIndex = 38;
            this.buttonGuardarUsuario.Text = "Guardar";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = false;
            this.buttonGuardarUsuario.Click += new System.EventHandler(this.buttonGuardarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Id:";
            // 
            // textBoxNuevoApelidoUsuario
            // 
            this.textBoxNuevoApelidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNuevoApelidoUsuario.Location = new System.Drawing.Point(160, 234);
            this.textBoxNuevoApelidoUsuario.Name = "textBoxNuevoApelidoUsuario";
            this.textBoxNuevoApelidoUsuario.Size = new System.Drawing.Size(116, 24);
            this.textBoxNuevoApelidoUsuario.TabIndex = 32;
            // 
            // textBoxNuevoContrasenaUsuario
            // 
            this.textBoxNuevoContrasenaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNuevoContrasenaUsuario.Location = new System.Drawing.Point(160, 289);
            this.textBoxNuevoContrasenaUsuario.Name = "textBoxNuevoContrasenaUsuario";
            this.textBoxNuevoContrasenaUsuario.Size = new System.Drawing.Size(116, 24);
            this.textBoxNuevoContrasenaUsuario.TabIndex = 31;
            // 
            // textBoxNuevoUsernameUsuario
            // 
            this.textBoxNuevoUsernameUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNuevoUsernameUsuario.Location = new System.Drawing.Point(160, 117);
            this.textBoxNuevoUsernameUsuario.Name = "textBoxNuevoUsernameUsuario";
            this.textBoxNuevoUsernameUsuario.Size = new System.Drawing.Size(116, 24);
            this.textBoxNuevoUsernameUsuario.TabIndex = 30;
            // 
            // textBoxNuevoNombreUsuario
            // 
            this.textBoxNuevoNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxNuevoNombreUsuario.Location = new System.Drawing.Point(160, 174);
            this.textBoxNuevoNombreUsuario.Name = "textBoxNuevoNombreUsuario";
            this.textBoxNuevoNombreUsuario.Size = new System.Drawing.Size(116, 24);
            this.textBoxNuevoNombreUsuario.TabIndex = 29;
            // 
            // textIdUsuario
            // 
            this.textIdUsuario.Enabled = false;
            this.textIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textIdUsuario.Location = new System.Drawing.Point(160, 63);
            this.textIdUsuario.Name = "textIdUsuario";
            this.textIdUsuario.Size = new System.Drawing.Size(49, 24);
            this.textIdUsuario.TabIndex = 28;
            // 
            // ListaUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.panel_ContenedorUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListaUsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.ListaUsuariosForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.panel_ContenedorUsuario.ResumeLayout(false);
            this.panel_ContenedorUsuario.PerformLayout();
            this.panel_ContenedorNuevoUsuario.ResumeLayout(false);
            this.panel_ContenedorNuevoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsuarioTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonAgregarUsuario;
        private System.Windows.Forms.Button buttonAsignarUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Label labelNuevoUsuario;
        private System.Windows.Forms.Button buttonCancelarUsuario;
        private System.Windows.Forms.Button buttonGuardarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNuevoApelidoUsuario;
        private System.Windows.Forms.TextBox textBoxNuevoContrasenaUsuario;
        private System.Windows.Forms.TextBox textBoxNuevoUsernameUsuario;
        private System.Windows.Forms.TextBox textBoxNuevoNombreUsuario;
        private System.Windows.Forms.TextBox textIdUsuario;
        private System.Windows.Forms.Panel panel_ContenedorNuevoUsuario;
        private System.Windows.Forms.Panel panel_ContenedorUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_CONTRASENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_TIPO;
    }
}