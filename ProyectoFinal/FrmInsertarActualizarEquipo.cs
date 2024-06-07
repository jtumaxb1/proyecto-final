using EstructuraDatos.Arbol;
using EstructuraDatos.Clases;
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
    public partial class FrmInsertarActualizarEquipo : Form
    {
        public ArbolAVL arbol;
        public Equipo actualizarEquipo;
        public string nombreEquipo;
        public string liga;
        public FrmInsertarActualizarEquipo(ArbolAVL arbol, FrmEquipos frmEquipos, Equipo equipoActualizar, string liga)
        {
            InitializeComponent();
            this.arbol = arbol;
            if (equipoActualizar != null)
            {
                this.actualizarEquipo = equipoActualizar;
                this.btnInsertarActualizar.Text = "Actualizar";
                this.txtNombre.Text = equipoActualizar.nombre;
                this.txtPais.Text = equipoActualizar.pais;
                this.txtLiga.Text = equipoActualizar.liga;
                this.nombreEquipo = equipoActualizar.nombre;
            }
            else
            {
                actualizarEquipo = equipoActualizar;
            }
            this.liga = liga;
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

        private void btnInsertarActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (actualizarEquipo == null)
                {

                    Equipo equipo = new Equipo((this.arbol.cantidad + 1), this.txtNombre.Text, this.txtPais.Text, this.txtLiga.Text);
                    arbol.insertar(equipo);
                    MessageBox.Show("Equipo insertado con exito", "Insertar Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Agregar();
                    this.Close();
                }
                else
                {
                    Equipo nuevoActualizarEquipo = new Equipo(actualizarEquipo.id, this.txtNombre.Text, this.txtPais.Text, this.txtLiga.Text);
                    arbol.actualizar(nuevoActualizarEquipo, this.nombreEquipo);
                    MessageBox.Show("Equipo actualizado con exito", "Actualizar Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Agregar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar insertar/actualizar el Equipo => {ex.Message}", "Insertar/Actualizar Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmInsertarActualizarEquipo_Load(object sender, EventArgs e)
        {
            this.txtLiga.Text = liga;
            this.txtLiga.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
