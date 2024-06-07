namespace ProyectoFinal
{
    partial class FrmEquipos
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
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnJugadores = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            dgvEquipos = new DataGridView();
            IdEquipo1 = new DataGridViewTextBoxColumn();
            nombreEquipo1 = new DataGridViewTextBoxColumn();
            ligaEquipo = new DataGridViewTextBoxColumn();
            paisEquipo = new DataGridViewTextBoxColumn();
            puntos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.WindowText;
            btnInsertar.Font = new Font("Showcard Gothic", 12F);
            btnInsertar.ForeColor = SystemColors.ControlLightLight;
            btnInsertar.Location = new Point(461, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(136, 53);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.WindowText;
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Showcard Gothic", 12F);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(461, 71);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 53);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.WindowText;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Showcard Gothic", 12F);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(461, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 53);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.WindowText;
            btnSalir.Font = new Font("Showcard Gothic", 12F);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(461, 189);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 53);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnJugadores
            // 
            btnJugadores.BackColor = SystemColors.WindowText;
            btnJugadores.Enabled = false;
            btnJugadores.Font = new Font("Showcard Gothic", 12F);
            btnJugadores.ForeColor = SystemColors.ControlLightLight;
            btnJugadores.Location = new Point(461, 248);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(136, 53);
            btnJugadores.TabIndex = 5;
            btnJugadores.Text = "Jugadores";
            btnJugadores.UseVisualStyleBackColor = false;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 111;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            Pais.Width = 111;
            // 
            // dgvEquipos
            // 
            dgvEquipos.BackgroundColor = SystemColors.WindowText;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { IdEquipo1, nombreEquipo1, ligaEquipo, paisEquipo, puntos });
            dgvEquipos.Location = new Point(12, 12);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.Size = new Size(443, 289);
            dgvEquipos.TabIndex = 6;
            dgvEquipos.CellClick += dgvEquipos_CellClick_1;
            // 
            // IdEquipo1
            // 
            IdEquipo1.HeaderText = "Id";
            IdEquipo1.Name = "IdEquipo1";
            IdEquipo1.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdEquipo1.Visible = false;
            // 
            // nombreEquipo1
            // 
            nombreEquipo1.HeaderText = "Nombre";
            nombreEquipo1.Name = "nombreEquipo1";
            nombreEquipo1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ligaEquipo
            // 
            ligaEquipo.HeaderText = "Liga";
            ligaEquipo.Name = "ligaEquipo";
            ligaEquipo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // paisEquipo
            // 
            paisEquipo.HeaderText = "Pais";
            paisEquipo.Name = "paisEquipo";
            paisEquipo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // puntos
            // 
            puntos.HeaderText = "Puntos";
            puntos.Name = "puntos";
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(610, 319);
            Controls.Add(dgvEquipos);
            Controls.Add(btnJugadores);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Name = "FrmEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEquipos";
            Load += FrmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnJugadores;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
        private DataGridView dgvEquipos;
        private DataGridViewTextBoxColumn IdEquipo1;
        private DataGridViewTextBoxColumn nombreEquipo1;
        private DataGridViewTextBoxColumn ligaEquipo;
        private DataGridViewTextBoxColumn paisEquipo;
        private DataGridViewTextBoxColumn puntos;
    }
}