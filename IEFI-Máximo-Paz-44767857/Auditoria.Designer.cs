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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.strConnectionStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // strConnectionStatus
            // 
            this.strConnectionStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrConnectioStatus});
            this.strConnectionStatus.Location = new System.Drawing.Point(0, 428);
            this.strConnectionStatus.Name = "strConnectionStatus";
            this.strConnectionStatus.Size = new System.Drawing.Size(506, 22);
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
            this.btnOperador.Location = new System.Drawing.Point(61, 59);
            this.btnOperador.Name = "btnOperador";
            this.btnOperador.Size = new System.Drawing.Size(134, 23);
            this.btnOperador.TabIndex = 8;
            this.btnOperador.Text = "Operador";
            this.btnOperador.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Administrador";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 113);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(240, 292);
            this.dgvMostrar.TabIndex = 10;
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Location = new System.Drawing.Point(316, 113);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(134, 59);
            this.btnAuditoria.TabIndex = 11;
            this.btnAuditoria.Text = "Auditoria";
            this.btnAuditoria.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(316, 187);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(134, 59);
            this.btnRegistar.TabIndex = 12;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(419, 382);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnAuditoria);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnCerrar;
    }
}