namespace IEFI_Máximo_Paz_44767857
{
    partial class Auditoria
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
            this.strConnectionStatus = new System.Windows.Forms.StatusStrip();
            this.tstrConnectioStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOperador = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMostrarTareas = new System.Windows.Forms.Button();
            this.strConnectionStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // strConnectionStatus
            // 
            this.strConnectionStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrConnectioStatus});
            this.strConnectionStatus.Location = new System.Drawing.Point(0, 532);
            this.strConnectionStatus.Name = "strConnectionStatus";
            this.strConnectionStatus.Size = new System.Drawing.Size(510, 22);
            this.strConnectionStatus.TabIndex = 7;
            this.strConnectionStatus.Text = "statusStrip1";
            // 
            // tstrConnectioStatus
            // 
            this.tstrConnectioStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tstrConnectioStatus.Name = "tstrConnectioStatus";
            this.tstrConnectioStatus.Size = new System.Drawing.Size(118, 17);
            this.tstrConnectioStatus.Text = "toolStripStatusLabel1";
            // 
            // btnOperador
            // 
            this.btnOperador.Location = new System.Drawing.Point(37, 120);
            this.btnOperador.Name = "btnOperador";
            this.btnOperador.Size = new System.Drawing.Size(183, 23);
            this.btnOperador.TabIndex = 8;
            this.btnOperador.Text = "Operador";
            this.btnOperador.UseVisualStyleBackColor = true;
            this.btnOperador.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(288, 120);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(183, 23);
            this.btnAdministrador.TabIndex = 9;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Enabled = false;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 226);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(240, 292);
            this.dgvMostrar.TabIndex = 10;
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Enabled = false;
            this.btnAuditoria.Location = new System.Drawing.Point(316, 226);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(134, 59);
            this.btnAuditoria.TabIndex = 11;
            this.btnAuditoria.Text = "Auditoria";
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Enabled = false;
            this.btnRegistar.Location = new System.Drawing.Point(316, 300);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(134, 59);
            this.btnRegistar.TabIndex = 12;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(423, 495);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(78, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 42);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "PAGINA PRINCIPAL";
            // 
            // btnMostrarTareas
            // 
            this.btnMostrarTareas.Enabled = false;
            this.btnMostrarTareas.Location = new System.Drawing.Point(13, 194);
            this.btnMostrarTareas.Name = "btnMostrarTareas";
            this.btnMostrarTareas.Size = new System.Drawing.Size(121, 23);
            this.btnMostrarTareas.TabIndex = 15;
            this.btnMostrarTareas.Text = "Mostrar Tareas";
            this.btnMostrarTareas.UseVisualStyleBackColor = true;
            this.btnMostrarTareas.Click += new System.EventHandler(this.btnMostrarTareas_Click);
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(510, 554);
            this.Controls.Add(this.btnMostrarTareas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnAuditoria);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnOperador);
            this.Controls.Add(this.strConnectionStatus);
            this.Name = "Auditoria";
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            this.strConnectionStatus.ResumeLayout(false);
            this.strConnectionStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip strConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel tstrConnectioStatus;
        private System.Windows.Forms.Button btnOperador;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMostrarTareas;
    }
}