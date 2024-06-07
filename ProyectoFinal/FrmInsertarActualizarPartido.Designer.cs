namespace ProyectoFinal
{
    partial class FrmInsertarActualizarPartido
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
            cmbEquipoLocal = new ComboBox();
            label1 = new Label();
            cmbEquipoVisitante = new ComboBox();
            label4 = new Label();
            btnGuardar = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // cmbEquipoLocal
            // 
            cmbEquipoLocal.FormattingEnabled = true;
            cmbEquipoLocal.Location = new Point(12, 32);
            cmbEquipoLocal.Name = "cmbEquipoLocal";
            cmbEquipoLocal.Size = new Size(358, 23);
            cmbEquipoLocal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(132, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 2;
            label1.Text = "Equipo Local";
            // 
            // cmbEquipoVisitante
            // 
            cmbEquipoVisitante.FormattingEnabled = true;
            cmbEquipoVisitante.Location = new Point(12, 92);
            cmbEquipoVisitante.Name = "cmbEquipoVisitante";
            cmbEquipoVisitante.Size = new Size(358, 23);
            cmbEquipoVisitante.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(115, 69);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 7;
            label4.Text = "Equipo Visitante";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.WindowText;
            btnGuardar.Font = new Font("Showcard Gothic", 12F);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(12, 121);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(173, 55);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.WindowText;
            btnRegresar.Font = new Font("Showcard Gothic", 12F);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.Location = new Point(197, 121);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(173, 55);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmInsertarActualizarPartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(379, 196);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(cmbEquipoVisitante);
            Controls.Add(label1);
            Controls.Add(cmbEquipoLocal);
            Name = "FrmInsertarActualizarPartido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsertarActualizarPartido";
            Load += FrmInsertarActualizarPartido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEquipoLocal;
        private Label label1;
        private ComboBox cmbEquipoVisitante;
        private Label label4;
        private Button btnGuardar;
        private Button btnRegresar;
    }
}