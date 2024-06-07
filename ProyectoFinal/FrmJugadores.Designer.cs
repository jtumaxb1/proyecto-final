namespace ProyectoFinal
{
    partial class FrmJugadores
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
            dgvJugadores = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Dorsal = new DataGridViewTextBoxColumn();
            Posicion = new DataGridViewTextBoxColumn();
            Goles = new DataGridViewTextBoxColumn();
            TarjetaAmarillas = new DataGridViewTextBoxColumn();
            TarjetaRojas = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            btnAumetarGoles = new Button();
            btnTarjetaAmarillas = new Button();
            btnTarjetaRojas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // dgvJugadores
            // 
            dgvJugadores.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Apellido, Dorsal, Posicion, Goles, TarjetaAmarillas, TarjetaRojas });
            dgvJugadores.Location = new Point(12, 12);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.Size = new Size(743, 322);
            dgvJugadores.TabIndex = 0;
            dgvJugadores.CellClick += dgvJugadores_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Dorsal
            // 
            Dorsal.HeaderText = "Dorsal";
            Dorsal.Name = "Dorsal";
            // 
            // Posicion
            // 
            Posicion.HeaderText = "Posicion";
            Posicion.Name = "Posicion";
            // 
            // Goles
            // 
            Goles.HeaderText = "Goles";
            Goles.Name = "Goles";
            // 
            // TarjetaAmarillas
            // 
            TarjetaAmarillas.HeaderText = "Tarjetas Amarillas";
            TarjetaAmarillas.Name = "TarjetaAmarillas";
            // 
            // TarjetaRojas
            // 
            TarjetaRojas.HeaderText = "Tarjetas Rojas";
            TarjetaRojas.Name = "TarjetaRojas";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.MenuText;
            btnAgregar.Font = new Font("Showcard Gothic", 12F);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(761, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(184, 76);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.MenuText;
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Showcard Gothic", 12F);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(761, 94);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(184, 76);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.MenuText;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Showcard Gothic", 12F);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(761, 176);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 76);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.MenuText;
            btnRegresar.Font = new Font("Showcard Gothic", 12F);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.Location = new Point(761, 258);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(184, 76);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAumetarGoles
            // 
            btnAumetarGoles.BackColor = SystemColors.MenuText;
            btnAumetarGoles.Enabled = false;
            btnAumetarGoles.Font = new Font("Showcard Gothic", 12F);
            btnAumetarGoles.ForeColor = SystemColors.ControlLightLight;
            btnAumetarGoles.Location = new Point(951, 12);
            btnAumetarGoles.Name = "btnAumetarGoles";
            btnAumetarGoles.Size = new Size(184, 88);
            btnAumetarGoles.TabIndex = 5;
            btnAumetarGoles.Text = "Aumentar goles";
            btnAumetarGoles.UseVisualStyleBackColor = false;
            btnAumetarGoles.Click += btnAumetarGoles_Click;
            // 
            // btnTarjetaAmarillas
            // 
            btnTarjetaAmarillas.BackColor = SystemColors.MenuText;
            btnTarjetaAmarillas.Enabled = false;
            btnTarjetaAmarillas.Font = new Font("Showcard Gothic", 12F);
            btnTarjetaAmarillas.ForeColor = SystemColors.ControlLightLight;
            btnTarjetaAmarillas.Location = new Point(951, 131);
            btnTarjetaAmarillas.Name = "btnTarjetaAmarillas";
            btnTarjetaAmarillas.Size = new Size(184, 88);
            btnTarjetaAmarillas.TabIndex = 6;
            btnTarjetaAmarillas.Text = "Añadir tarjeta amarilla";
            btnTarjetaAmarillas.UseVisualStyleBackColor = false;
            btnTarjetaAmarillas.Click += btnTarjetaAmarillas_Click;
            // 
            // btnTarjetaRojas
            // 
            btnTarjetaRojas.BackColor = SystemColors.MenuText;
            btnTarjetaRojas.Enabled = false;
            btnTarjetaRojas.Font = new Font("Showcard Gothic", 12F);
            btnTarjetaRojas.ForeColor = SystemColors.ControlLightLight;
            btnTarjetaRojas.Location = new Point(951, 246);
            btnTarjetaRojas.Name = "btnTarjetaRojas";
            btnTarjetaRojas.Size = new Size(184, 88);
            btnTarjetaRojas.TabIndex = 7;
            btnTarjetaRojas.Text = "Añadir tarjeta rojas";
            btnTarjetaRojas.UseVisualStyleBackColor = false;
            btnTarjetaRojas.Click += btnTarjetaRojas_Click;
            // 
            // FrmJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1147, 346);
            Controls.Add(btnTarjetaRojas);
            Controls.Add(btnTarjetaAmarillas);
            Controls.Add(btnAumetarGoles);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvJugadores);
            Name = "FrmJugadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmJugadores";
            Load += FrmJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJugadores;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnRegresar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Dorsal;
        private DataGridViewTextBoxColumn Posicion;
        private DataGridViewTextBoxColumn Goles;
        private DataGridViewTextBoxColumn TarjetaAmarillas;
        private DataGridViewTextBoxColumn TarjetaRojas;
        private Button btnAumetarGoles;
        private Button btnTarjetaAmarillas;
        private Button btnTarjetaRojas;
    }
}