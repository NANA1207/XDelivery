
namespace PresentacionLogin
{
    partial class RepartidoresForm
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
            this.dataGridViewRepartidores = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNuevoRepartidor = new System.Windows.Forms.Button();
            this.buttonVerRepartidor = new System.Windows.Forms.Button();
            this.buttonBloquearRepartidor = new System.Windows.Forms.Button();
            this.USE_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APE_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CON_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EST_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIP_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepartidores)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewRepartidores);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(113, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 299);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewRepartidores
            // 
            this.dataGridViewRepartidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepartidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USE_REP,
            this.APE_REP,
            this.NOM_REP,
            this.CON_REP,
            this.EST_REP,
            this.TIP_REP,
            this.ID_REP});
            this.dataGridViewRepartidores.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRepartidores.Name = "dataGridViewRepartidores";
            this.dataGridViewRepartidores.Size = new System.Drawing.Size(544, 296);
            this.dataGridViewRepartidores.TabIndex = 0;
            this.dataGridViewRepartidores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRepartidores_CellClick);
            this.dataGridViewRepartidores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRepartidores_CellContentClick);
            this.dataGridViewRepartidores.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewRepartidores_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(362, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Repartidores";
            // 
            // buttonNuevoRepartidor
            // 
            this.buttonNuevoRepartidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonNuevoRepartidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonNuevoRepartidor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNuevoRepartidor.Location = new System.Drawing.Point(113, 49);
            this.buttonNuevoRepartidor.Name = "buttonNuevoRepartidor";
            this.buttonNuevoRepartidor.Size = new System.Drawing.Size(114, 29);
            this.buttonNuevoRepartidor.TabIndex = 29;
            this.buttonNuevoRepartidor.Text = "Agregar";
            this.buttonNuevoRepartidor.UseVisualStyleBackColor = false;
            this.buttonNuevoRepartidor.Click += new System.EventHandler(this.buttonNuevoRepartidor_Click);
            // 
            // buttonVerRepartidor
            // 
            this.buttonVerRepartidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVerRepartidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonVerRepartidor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVerRepartidor.Location = new System.Drawing.Point(256, 49);
            this.buttonVerRepartidor.Name = "buttonVerRepartidor";
            this.buttonVerRepartidor.Size = new System.Drawing.Size(114, 29);
            this.buttonVerRepartidor.TabIndex = 30;
            this.buttonVerRepartidor.Text = "Ver";
            this.buttonVerRepartidor.UseVisualStyleBackColor = false;
            this.buttonVerRepartidor.Click += new System.EventHandler(this.buttonVerRepartidor_Click);
            // 
            // buttonBloquearRepartidor
            // 
            this.buttonBloquearRepartidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBloquearRepartidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonBloquearRepartidor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBloquearRepartidor.Location = new System.Drawing.Point(113, 412);
            this.buttonBloquearRepartidor.Name = "buttonBloquearRepartidor";
            this.buttonBloquearRepartidor.Size = new System.Drawing.Size(114, 29);
            this.buttonBloquearRepartidor.TabIndex = 31;
            this.buttonBloquearRepartidor.Text = "Bloquear";
            this.buttonBloquearRepartidor.UseVisualStyleBackColor = false;
            this.buttonBloquearRepartidor.Click += new System.EventHandler(this.buttonBloquearRepartidor_Click);
            // 
            // USE_REP
            // 
            this.USE_REP.DataPropertyName = "Username";
            this.USE_REP.HeaderText = "USERNAME";
            this.USE_REP.Name = "USE_REP";
            this.USE_REP.ReadOnly = true;
            // 
            // APE_REP
            // 
            this.APE_REP.DataPropertyName = "Apellido";
            this.APE_REP.HeaderText = "APELLIDO";
            this.APE_REP.Name = "APE_REP";
            this.APE_REP.ReadOnly = true;
            // 
            // NOM_REP
            // 
            this.NOM_REP.DataPropertyName = "Nombre";
            this.NOM_REP.HeaderText = "NOMBRE";
            this.NOM_REP.Name = "NOM_REP";
            this.NOM_REP.ReadOnly = true;
            // 
            // CON_REP
            // 
            this.CON_REP.DataPropertyName = "Contrasena";
            this.CON_REP.HeaderText = "CONTRASEÑA";
            this.CON_REP.Name = "CON_REP";
            this.CON_REP.ReadOnly = true;
            // 
            // EST_REP
            // 
            this.EST_REP.DataPropertyName = "EstadoUsuario";
            this.EST_REP.HeaderText = "ESTADO";
            this.EST_REP.Name = "EST_REP";
            this.EST_REP.ReadOnly = true;
            // 
            // TIP_REP
            // 
            this.TIP_REP.DataPropertyName = "TipoUsuario";
            this.TIP_REP.HeaderText = "TIPO";
            this.TIP_REP.Name = "TIP_REP";
            this.TIP_REP.ReadOnly = true;
            this.TIP_REP.Visible = false;
            // 
            // ID_REP
            // 
            this.ID_REP.DataPropertyName = "IdUsuario";
            this.ID_REP.HeaderText = "ID";
            this.ID_REP.Name = "ID_REP";
            this.ID_REP.ReadOnly = true;
            this.ID_REP.Visible = false;
            // 
            // RepartidoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(this.buttonBloquearRepartidor);
            this.Controls.Add(this.buttonVerRepartidor);
            this.Controls.Add(this.buttonNuevoRepartidor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepartidoresForm";
            this.Text = "RepartidoresForm";
            this.Load += new System.EventHandler(this.RepartidoresForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RepartidoresForm_Paint);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepartidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewRepartidores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNuevoRepartidor;
        private System.Windows.Forms.Button buttonVerRepartidor;
        private System.Windows.Forms.Button buttonBloquearRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn USE_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn APE_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CON_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn EST_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIP_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REP;
    }
}