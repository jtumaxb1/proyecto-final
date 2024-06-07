namespace ProyectoFinal
{
    partial class FrmTorneos
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
            dgvTorneos = new DataGridView();
            Liga = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnEquipos = new Button();
            btnRegresar = new Button();
            btnPartidos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTorneos).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.MenuText;
            btnInsertar.Font = new Font("Showcard Gothic", 12F);
            btnInsertar.ForeColor = SystemColors.ControlLightLight;
            btnInsertar.Location = new Point(392, 22);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(138, 64);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dgvTorneos
            // 
            dgvTorneos.BackgroundColor = SystemColors.ControlText;
            dgvTorneos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTorneos.Columns.AddRange(new DataGridViewColumn[] { Liga });
            dgvTorneos.Location = new Point(12, 22);
            dgvTorneos.Name = "dgvTorneos";
            dgvTorneos.Size = new Size(374, 414);
            dgvTorneos.TabIndex = 1;
            dgvTorneos.CellClick += dgvTorneos_CellClick;
            // 
            // Liga
            // 
            Liga.HeaderText = "Liga";
            Liga.Name = "Liga";
            Liga.Width = 331;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.MenuText;
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Showcard Gothic", 12F);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(392, 92);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 64);
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
            btnEliminar.Location = new Point(392, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 64);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.BackColor = SystemColors.MenuText;
            btnEquipos.Enabled = false;
            btnEquipos.Font = new Font("Showcard Gothic", 12F);
            btnEquipos.ForeColor = SystemColors.ControlLightLight;
            btnEquipos.Location = new Point(392, 232);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(138, 64);
            btnEquipos.TabIndex = 4;
            btnEquipos.Text = "Ver Equipos";
            btnEquipos.UseVisualStyleBackColor = false;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.MenuText;
            btnRegresar.Font = new Font("Showcard Gothic", 12F);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.Location = new Point(392, 372);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(138, 64);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnPartidos
            // 
            btnPartidos.BackColor = SystemColors.MenuText;
            btnPartidos.Enabled = false;
            btnPartidos.Font = new Font("Showcard Gothic", 12F);
            btnPartidos.ForeColor = SystemColors.ControlLightLight;
            btnPartidos.Location = new Point(392, 302);
            btnPartidos.Name = "btnPartidos";
            btnPartidos.Size = new Size(138, 64);
            btnPartidos.TabIndex = 7;
            btnPartidos.Text = "Partidos";
            btnPartidos.UseVisualStyleBackColor = false;
            btnPartidos.Click += btnPartidos_Click;
            // 
            // FrmTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(544, 451);
            Controls.Add(btnPartidos);
            Controls.Add(btnRegresar);
            Controls.Add(btnEquipos);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvTorneos);
            Controls.Add(btnInsertar);
            Name = "FrmTorneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTorneos";
            Load += FrmTorneos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTorneos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dgvTorneos;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnEquipos;
        private Button btnRegresar;
        private DataGridViewTextBoxColumn Liga;
        private Button btnPartidos;
    }
}