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
            btnInsertarActualizar.BackColor = SystemColors.MenuText;
            btnInsertarActualizar.Font = new Font("Showcard Gothic", 12F);
            btnInsertarActualizar.ForeColor = SystemColors.ControlLightLight;
            btnInsertarActualizar.Location = new Point(13, 141);
            btnInsertarActualizar.Name = "btnInsertarActualizar";
            btnInsertarActualizar.Size = new Size(134, 58);
            btnInsertarActualizar.TabIndex = 0;
            btnInsertarActualizar.Text = "Guardar";
            btnInsertarActualizar.UseVisualStyleBackColor = false;
            btnInsertarActualizar.Click += btnInsertarActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.MenuText;
            btnCancelar.Font = new Font("Showcard Gothic", 12F);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(155, 141);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 58);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Regresar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 11);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(96, 64);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(193, 23);
            txtPais.TabIndex = 3;
            // 
            // txtLiga
            // 
            txtLiga.Location = new Point(96, 112);
            txtLiga.Name = "txtLiga";
            txtLiga.Size = new Size(193, 23);
            txtLiga.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Showcard Gothic", 12F);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Pais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(13, 115);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Liga";
            // 
            // FrmInsertarActualizarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(303, 212);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(txtLiga);
            Controls.Add(txtPais);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertarActualizar);
            Name = "FrmInsertarActualizarEquipo";
            StartPosition = FormStartPosition.CenterScreen;
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