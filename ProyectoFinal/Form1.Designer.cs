namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTorneos = new Button();
            SuspendLayout();
            // 
            // btnTorneos
            // 
            btnTorneos.BackColor = SystemColors.WindowText;
            btnTorneos.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTorneos.ForeColor = SystemColors.ControlLightLight;
            btnTorneos.Location = new Point(108, 59);
            btnTorneos.Name = "btnTorneos";
            btnTorneos.Size = new Size(122, 50);
            btnTorneos.TabIndex = 1;
            btnTorneos.Text = "Torneo";
            btnTorneos.UseVisualStyleBackColor = false;
            btnTorneos.Click += btnTorneos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(337, 168);
            Controls.Add(btnTorneos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnTorneos;
    }
}
