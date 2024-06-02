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
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTorneos).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(413, 56);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(89, 29);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dgvTorneos
            // 
            dgvTorneos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTorneos.Columns.AddRange(new DataGridViewColumn[] { Liga });
            dgvTorneos.Location = new Point(12, 22);
            dgvTorneos.Name = "dgvTorneos";
            dgvTorneos.Size = new Size(374, 293);
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
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(413, 105);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(89, 29);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(413, 155);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.Enabled = false;
            btnEquipos.Location = new Point(413, 205);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(89, 29);
            btnEquipos.TabIndex = 4;
            btnEquipos.Text = "Ver Equipos";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // button6
            // 
            button6.Location = new Point(413, 255);
            button6.Name = "button6";
            button6.Size = new Size(89, 29);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // FrmTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 336);
            Controls.Add(button6);
            Controls.Add(btnEquipos);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvTorneos);
            Controls.Add(btnInsertar);
            Name = "FrmTorneos";
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
        private Button button6;
        private DataGridViewTextBoxColumn Liga;
    }
}