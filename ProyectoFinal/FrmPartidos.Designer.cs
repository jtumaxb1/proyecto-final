namespace ProyectoFinal
{
    partial class FrmPartidos
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
            dgvPartidos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            equipoLocal = new DataGridViewTextBoxColumn();
            marcadorLocal = new DataGridViewTextBoxColumn();
            equipoVisitante = new DataGridViewTextBoxColumn();
            marcadorVisitante = new DataGridViewTextBoxColumn();
            flag = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnTerminarPartido = new Button();
            btnRegresar = new Button();
            btnAumentarGolesVisitante = new Button();
            btnAumentarGolesLocal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPartidos
            // 
            dgvPartidos.BackgroundColor = SystemColors.ControlText;
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Columns.AddRange(new DataGridViewColumn[] { id, equipoLocal, marcadorLocal, equipoVisitante, marcadorVisitante, flag });
            dgvPartidos.Location = new Point(12, 12);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.Size = new Size(443, 360);
            dgvPartidos.TabIndex = 0;
            dgvPartidos.CellClick += dgvPartidos_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // equipoLocal
            // 
            equipoLocal.HeaderText = "Equipo Local";
            equipoLocal.Name = "equipoLocal";
            // 
            // marcadorLocal
            // 
            marcadorLocal.HeaderText = "Marcador Local";
            marcadorLocal.Name = "marcadorLocal";
            // 
            // equipoVisitante
            // 
            equipoVisitante.HeaderText = "Equipo Visitante";
            equipoVisitante.Name = "equipoVisitante";
            // 
            // marcadorVisitante
            // 
            marcadorVisitante.HeaderText = "Marcador Visitante";
            marcadorVisitante.Name = "marcadorVisitante";
            // 
            // flag
            // 
            flag.HeaderText = "flag";
            flag.Name = "flag";
            flag.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.MenuText;
            btnAgregar.Font = new Font("Showcard Gothic", 12F);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(461, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 66);
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
            btnActualizar.Location = new Point(461, 84);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(143, 66);
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
            btnEliminar.Location = new Point(461, 156);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 66);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnTerminarPartido
            // 
            btnTerminarPartido.BackColor = SystemColors.MenuText;
            btnTerminarPartido.Enabled = false;
            btnTerminarPartido.Font = new Font("Showcard Gothic", 12F);
            btnTerminarPartido.ForeColor = SystemColors.ControlLightLight;
            btnTerminarPartido.Location = new Point(461, 228);
            btnTerminarPartido.Name = "btnTerminarPartido";
            btnTerminarPartido.Size = new Size(143, 72);
            btnTerminarPartido.TabIndex = 3;
            btnTerminarPartido.Text = "Terminar Partido";
            btnTerminarPartido.UseVisualStyleBackColor = false;
            btnTerminarPartido.Click += btnTerminarPartido_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.MenuText;
            btnRegresar.Font = new Font("Showcard Gothic", 12F);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.Location = new Point(461, 306);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(143, 66);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAumentarGolesVisitante
            // 
            btnAumentarGolesVisitante.BackColor = SystemColors.MenuText;
            btnAumentarGolesVisitante.Enabled = false;
            btnAumentarGolesVisitante.Font = new Font("Showcard Gothic", 12F);
            btnAumentarGolesVisitante.ForeColor = SystemColors.ControlLightLight;
            btnAumentarGolesVisitante.Location = new Point(610, 203);
            btnAumentarGolesVisitante.Name = "btnAumentarGolesVisitante";
            btnAumentarGolesVisitante.Size = new Size(201, 97);
            btnAumentarGolesVisitante.TabIndex = 6;
            btnAumentarGolesVisitante.Text = "Aumentar Goles Visitante";
            btnAumentarGolesVisitante.UseVisualStyleBackColor = false;
            btnAumentarGolesVisitante.Click += btnAumentarGolesVisitante_Click;
            // 
            // btnAumentarGolesLocal
            // 
            btnAumentarGolesLocal.BackColor = SystemColors.MenuText;
            btnAumentarGolesLocal.Enabled = false;
            btnAumentarGolesLocal.Font = new Font("Showcard Gothic", 12F);
            btnAumentarGolesLocal.ForeColor = SystemColors.ControlLightLight;
            btnAumentarGolesLocal.Location = new Point(610, 84);
            btnAumentarGolesLocal.Name = "btnAumentarGolesLocal";
            btnAumentarGolesLocal.Size = new Size(201, 97);
            btnAumentarGolesLocal.TabIndex = 7;
            btnAumentarGolesLocal.Text = "Aumentar Goles Local";
            btnAumentarGolesLocal.UseVisualStyleBackColor = false;
            btnAumentarGolesLocal.Click += btnAumentarGolesLocal_Click;
            // 
            // FrmPartidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(823, 380);
            Controls.Add(btnAumentarGolesLocal);
            Controls.Add(btnAumentarGolesVisitante);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnTerminarPartido);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPartidos);
            Name = "FrmPartidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPartidos";
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPartidos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnTerminarPartido;
        private Button btnRegresar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn equipoLocal;
        private DataGridViewTextBoxColumn marcadorLocal;
        private DataGridViewTextBoxColumn equipoVisitante;
        private DataGridViewTextBoxColumn marcadorVisitante;
        private DataGridViewTextBoxColumn flag;
        private Button btnAumentarGolesVisitante;
        private Button btnAumentarGolesLocal;
    }
}