
namespace PresentacionLogin
{
    partial class ReportesForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ConsultasEntidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteEntidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTipoReporte = new System.Windows.Forms.ComboBox();
            this.comboBoxPeriodoTiempo = new System.Windows.Forms.ComboBox();
            this.comboBoxCantidadDatos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscarPedidos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasEntidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEntidadBindingSource)).BeginInit();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultasEntidadBindingSource
            // 
            this.ConsultasEntidadBindingSource.DataSource = typeof(Entidades.ConsultasEntidad);
            // 
            // ReporteEntidadBindingSource
            // 
            this.ReporteEntidadBindingSource.DataSource = typeof(Entidades.ReporteEntidad);
            // 
            // comboBoxTipoReporte
            // 
            this.comboBoxTipoReporte.FormattingEnabled = true;
            this.comboBoxTipoReporte.Location = new System.Drawing.Point(15, 85);
            this.comboBoxTipoReporte.Name = "comboBoxTipoReporte";
            this.comboBoxTipoReporte.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoReporte.TabIndex = 0;
            // 
            // comboBoxPeriodoTiempo
            // 
            this.comboBoxPeriodoTiempo.FormattingEnabled = true;
            this.comboBoxPeriodoTiempo.Location = new System.Drawing.Point(15, 172);
            this.comboBoxPeriodoTiempo.Name = "comboBoxPeriodoTiempo";
            this.comboBoxPeriodoTiempo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriodoTiempo.TabIndex = 1;
            // 
            // comboBoxCantidadDatos
            // 
            this.comboBoxCantidadDatos.FormattingEnabled = true;
            this.comboBoxCantidadDatos.Location = new System.Drawing.Point(15, 263);
            this.comboBoxCantidadDatos.Name = "comboBoxCantidadDatos";
            this.comboBoxCantidadDatos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCantidadDatos.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(12, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipo de Reporte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Periodo  de tiempo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cantidad de datos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(362, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Reportes";
            // 
            // buttonBuscarPedidos
            // 
            this.buttonBuscarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(60)))));
            this.buttonBuscarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonBuscarPedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscarPedidos.Location = new System.Drawing.Point(15, 389);
            this.buttonBuscarPedidos.Name = "buttonBuscarPedidos";
            this.buttonBuscarPedidos.Size = new System.Drawing.Size(121, 29);
            this.buttonBuscarPedidos.TabIndex = 30;
            this.buttonBuscarPedidos.Text = "Ver";
            this.buttonBuscarPedidos.UseVisualStyleBackColor = false;
            this.buttonBuscarPedidos.Click += new System.EventHandler(this.buttonBuscarPedidos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Filtrado por:";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(15, 347);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltro.TabIndex = 31;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataConsultas";
            reportDataSource3.Value = this.ConsultasEntidadBindingSource;
            reportDataSource4.Name = "DataReportes";
            reportDataSource4.Value = this.ReporteEntidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionLogin.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(155, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(620, 391);
            this.reportViewer1.TabIndex = 33;
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.pictureBox1);
            this.panelImagen.Location = new System.Drawing.Point(155, 50);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(620, 391);
            this.panelImagen.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentacionLogin.Properties.Resources.logoClaro;
            this.pictureBox1.Location = new System.Drawing.Point(158, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.buttonBuscarPedidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxCantidadDatos);
            this.Controls.Add(this.comboBoxPeriodoTiempo);
            this.Controls.Add(this.comboBoxTipoReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasEntidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEntidadBindingSource)).EndInit();
            this.panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoReporte;
        private System.Windows.Forms.ComboBox comboBoxPeriodoTiempo;
        private System.Windows.Forms.ComboBox comboBoxCantidadDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBuscarPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.BindingSource ConsultasEntidadBindingSource;
        private System.Windows.Forms.BindingSource ReporteEntidadBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.BindingSource ConsultasEntidadBindingSource;
    }
}