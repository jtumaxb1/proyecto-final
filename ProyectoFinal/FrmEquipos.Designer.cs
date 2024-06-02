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
            dgvEquipos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Liga = new DataGridViewTextBoxColumn();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Pais, Liga });
            dgvEquipos.Location = new Point(12, 12);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.Size = new Size(374, 293);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.CellClick += dgvEquipos_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 111;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            Pais.ReadOnly = true;
            Pais.Width = 111;
            // 
            // Liga
            // 
            Liga.HeaderText = "Liga";
            Liga.Name = "Liga";
            Liga.ReadOnly = true;
            Liga.Width = 110;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(424, 45);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(89, 35);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(424, 109);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(89, 35);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(424, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 35);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(424, 238);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 35);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 317);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvEquipos);
            Name = "FrmEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEquipos";
            Load += FrmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEquipos;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Liga;
    }
}