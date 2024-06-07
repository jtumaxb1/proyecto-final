namespace ProyectoFinal
{
    partial class FrmInsertarActualizarTorneo
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
            txtNombre = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuText;
            btnGuardar.Font = new Font("Showcard Gothic", 12F);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(12, 61);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 55);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.MenuText;
            btnRegresar.Font = new Font("Showcard Gothic", 12F);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.Location = new Point(147, 61);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(125, 55);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmInsertarActualizarTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(284, 131);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "FrmInsertarActualizarTorneo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsertarActualizarTorneo";
            Load += FrmInsertarActualizarTorneo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Button btnGuardar;
        private Button btnRegresar;
    }
}