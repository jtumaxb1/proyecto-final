using EstructuraDatos.TablaHash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmInsertarActualizarTorneo : Form
    {
        public TablaHashTorneo tablaHashTorneo;
        public string clave;
        public FrmInsertarActualizarTorneo(TablaHashTorneo torneo, FrmTorneos frmTorneos, string clave)
        {
            this.tablaHashTorneo = torneo;
            this.clave = clave;
            InitializeComponent();
            if (this.clave != "")
            {
                this.txtNombre.Text = clave;
            }
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);

        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.clave == "")
            {
                if (this.txtNombre.Text == "")
                {
                    MessageBox.Show("Los campos no estan llenos, por favor llenar todos los campos", "Insertar/Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.tablaHashTorneo.Insertar(this.txtNombre.Text);
                    MessageBox.Show("Torneo ingresado correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Agregar();
                    this.Close();
                }
            }
            else
            {
                if (this.txtNombre.Text == "")
                {
                    MessageBox.Show("Los campos no estan llenos, por favor llenar todos los campos", "Insertar/Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.tablaHashTorneo.Actualizar(this.txtNombre.Text, this.clave);
                    MessageBox.Show("Torneo Actualizado correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Agregar();
                    this.Close();
                }
            }
        }

        private void FrmInsertarActualizarTorneo_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
