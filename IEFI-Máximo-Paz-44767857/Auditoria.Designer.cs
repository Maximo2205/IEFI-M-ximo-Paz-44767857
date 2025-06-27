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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auditoria));
            this.btnOperador = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMostrarTareas = new System.Windows.Forms.Button();
            this.btnRegistrarTarea = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlPaginaPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnlPaginaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperador
            // 
            this.btnOperador.Location = new System.Drawing.Point(423, 34);
            this.btnOperador.Name = "btnOperador";
            this.btnOperador.Size = new System.Drawing.Size(135, 32);
            this.btnOperador.TabIndex = 8;
            this.btnOperador.Text = "Operador";
            this.btnOperador.UseVisualStyleBackColor = true;
            this.btnOperador.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(585, 34);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(135, 32);
            this.btnAdministrador.TabIndex = 9;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Enabled = false;
            this.dgvMostrar.Location = new System.Drawing.Point(205, 156);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(515, 292);
            this.dgvMostrar.TabIndex = 10;
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Enabled = false;
            this.btnAuditoria.Location = new System.Drawing.Point(26, 185);
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
            this.btnRegistar.Location = new System.Drawing.Point(27, 270);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(134, 59);
            this.btnRegistar.TabIndex = 12;
            this.btnRegistar.Text = "Registrar Usuario";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(645, 464);
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
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Tan;
            this.lblTitulo.Location = new System.Drawing.Point(20, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 42);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "PAGINA PRINCIPAL";
            // 
            // btnMostrarTareas
            // 
            this.btnMostrarTareas.Enabled = false;
            this.btnMostrarTareas.Location = new System.Drawing.Point(205, 127);
            this.btnMostrarTareas.Name = "btnMostrarTareas";
            this.btnMostrarTareas.Size = new System.Drawing.Size(121, 23);
            this.btnMostrarTareas.TabIndex = 15;
            this.btnMostrarTareas.Text = "Mostrar Tareas";
            this.btnMostrarTareas.UseVisualStyleBackColor = true;
            this.btnMostrarTareas.Click += new System.EventHandler(this.btnMostrarTareas_Click);
            // 
            // btnRegistrarTarea
            // 
            this.btnRegistrarTarea.Enabled = false;
            this.btnRegistrarTarea.Location = new System.Drawing.Point(27, 357);
            this.btnRegistrarTarea.Name = "btnRegistrarTarea";
            this.btnRegistrarTarea.Size = new System.Drawing.Size(134, 59);
            this.btnRegistrarTarea.TabIndex = 16;
            this.btnRegistrarTarea.Text = "Registrar Tarea";
            this.btnRegistrarTarea.UseVisualStyleBackColor = true;
            this.btnRegistrarTarea.Click += new System.EventHandler(this.btnRegistrarTarea_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Tan;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslConexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslConexion
            // 
            this.tslConexion.BackColor = System.Drawing.Color.Transparent;
            this.tslConexion.Name = "tslConexion";
            this.tslConexion.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlPaginaPrincipal
            // 
            this.pnlPaginaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlPaginaPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPaginaPrincipal.Controls.Add(this.btnOperador);
            this.pnlPaginaPrincipal.Controls.Add(this.btnAdministrador);
            this.pnlPaginaPrincipal.Location = new System.Drawing.Point(0, 1);
            this.pnlPaginaPrincipal.Name = "pnlPaginaPrincipal";
            this.pnlPaginaPrincipal.Size = new System.Drawing.Size(756, 100);
            this.pnlPaginaPrincipal.TabIndex = 18;
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::IEFI_Máximo_Paz_44767857.Properties.Resources.Lugar_de_trabajo;
            this.ClientSize = new System.Drawing.Size(756, 530);
            this.Controls.Add(this.pnlPaginaPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRegistrarTarea);
            this.Controls.Add(this.btnMostrarTareas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnAuditoria);
            this.Controls.Add(this.dgvMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auditoria";
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlPaginaPrincipal.ResumeLayout(false);
            this.pnlPaginaPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOperador;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMostrarTareas;
        private System.Windows.Forms.Button btnRegistrarTarea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslConexion;
        private System.Windows.Forms.Panel pnlPaginaPrincipal;
    }
}