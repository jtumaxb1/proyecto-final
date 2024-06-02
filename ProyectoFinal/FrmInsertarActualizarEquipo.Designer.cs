namespace ProyectoFinal
{
    partial class FrmInsertarActualizarEquipo
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
            btnInsertarActualizar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtPais = new TextBox();
            txtLiga = new TextBox();
            lblNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnInsertarActualizar
            // 
            btnInsertarActualizar.Location = new Point(63, 209);
            btnInsertarActualizar.Name = "btnInsertarActualizar";
            btnInsertarActualizar.Size = new Size(97, 45);
            btnInsertarActualizar.TabIndex = 0;
            btnInsertarActualizar.Text = "Insertar";
            btnInsertarActualizar.UseVisualStyleBackColor = true;
            btnInsertarActualizar.Click += btnInsertarActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(200, 209);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 45);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(101, 95);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(193, 23);
            txtPais.TabIndex = 3;
            // 
            // txtLiga
            // 
            txtLiga.Location = new Point(101, 148);
            txtLiga.Name = "txtLiga";
            txtLiga.Size = new Size(193, 23);
            txtLiga.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 98);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "Pais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 151);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "Liga";
            // 
            // FrmInsertarActualizarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 295);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(txtLiga);
            Controls.Add(txtPais);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertarActualizar);
            Name = "FrmInsertarActualizarEquipo";
            Text = "FrmInsertarActualizarEquipo";
            Load += FrmInsertarActualizarEquipo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertarActualizar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtPais;
        private TextBox txtLiga;
        private Label lblNombre;
        private Label label2;
        private Label label3;
    }
}