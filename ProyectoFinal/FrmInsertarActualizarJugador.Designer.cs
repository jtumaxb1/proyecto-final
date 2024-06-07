namespace ProyectoFinal
{
    partial class FrmInsertarActualizarJugador
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
            txtApellido = new TextBox();
            txtDorsal = new TextBox();
            txtPosicion = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(177, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(159, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDorsal
            // 
            txtDorsal.Location = new Point(342, 37);
            txtDorsal.Name = "txtDorsal";
            txtDorsal.Size = new Size(159, 23);
            txtDorsal.TabIndex = 2;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(177, 86);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(159, 23);
            txtPosicion.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.WindowText;
            btnGuardar.Font = new Font("Showcard Gothic", 12F);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(16, 67);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 55);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(384, 9);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 9;
            label2.Text = "Dorsal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(219, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(219, 63);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 11;
            label4.Text = "Posicion";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.WindowText;
            btnRegresar.Font = new Font("Showcard Gothic", 12F);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.Location = new Point(342, 67);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 55);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmInsertarActualizarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(519, 143);
            Controls.Add(btnRegresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtPosicion);
            Controls.Add(txtDorsal);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FrmInsertarActualizarJugador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsertarActualizarJugador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDorsal;
        private TextBox txtPosicion;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegresar;
    }
}