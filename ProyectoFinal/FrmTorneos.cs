using EstructuraDatos.Clases;
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
    public partial class FrmTorneos : Form
    {
        public TablaHashTorneo tablaHashTorneo;
        public TablaHashJugador tablaHashJugador;
        public TablaHashPartido tablaHashPartido;

        public string liga;
        public FrmTorneos(TablaHashTorneo torneo, TablaHashJugador tablaHashJugador, TablaHashPartido tablaHashPartido)
        {
            this.tablaHashTorneo = torneo;
            this.tablaHashJugador = tablaHashJugador;
            this.tablaHashPartido = tablaHashPartido;
            InitializeComponent();
        }

        private void AgreUpdateEventHandler(object sender, FrmInsertarActualizarTorneo.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertarActualizarTorneo frmInsertarTorneo = new FrmInsertarActualizarTorneo(this.tablaHashTorneo, this, "");
            frmInsertarTorneo.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarTorneo.ShowDialog();
        }

        private void CargarDatos()
        {
            this.dgvTorneos.Rows.Clear();
            foreach (var item in tablaHashTorneo.tabla)
            {
                if (item != null)
                {
                    this.dgvTorneos.Rows.Add(item.nombre);
                }
            }
        }

        private void FrmTorneos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvTorneos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvObjeto = (DataGridView)sender;
            DataGridViewCellCollection posicion = dgvObjeto.CurrentRow.Cells;
            if (posicion[0].Value != null)
            {
                liga = posicion[0].Value.ToString();
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnEquipos.Enabled = true;
                this.btnPartidos.Enabled = true;
            }
            else
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnEquipos.Enabled = false;
                this.btnPartidos.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmInsertarActualizarTorneo frmInsertarActualizarTorneo = new FrmInsertarActualizarTorneo(this.tablaHashTorneo, this, liga);
            frmInsertarActualizarTorneo.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarActualizarTorneo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este torneo?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tablaHashTorneo.Eliminar(liga);
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnEquipos.Enabled = false;
                this.btnPartidos.Enabled = false;
                MessageBox.Show("El torneo fue eliminado con exito", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            Torneo torneoSeleccionado = (Torneo)tablaHashTorneo.Buscar(this.liga);
            FrmEquipos frmEquipos = new FrmEquipos(torneoSeleccionado.arbol, this.liga, this.tablaHashJugador);
            frmEquipos.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            Torneo torneoSeleccionado = (Torneo)tablaHashTorneo.Buscar(this.liga);
            int numNodos = torneoSeleccionado.arbol.numNodos(torneoSeleccionado.arbol.raizArbol());
            if (numNodos > 1) {
                FrmPartidos frmPartidos = new FrmPartidos(torneoSeleccionado.arbol, this.liga, this.tablaHashPartido);
                frmPartidos.ShowDialog();
            } else
            {
                MessageBox.Show("La cantidad de equipos es muy baja, por favor ingrese minimo 2 equipos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
