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
        public string liga;
        public FrmTorneos(TablaHashTorneo torneo)
        {
            this.tablaHashTorneo = torneo;
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
            }
            else
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnEquipos.Enabled = false;
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
                MessageBox.Show("El torneo fue eliminado con exito", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            Torneo torneoSeleccionado = (Torneo)tablaHashTorneo.Buscar(this.liga);
            FrmEquipos frmEquipos = new FrmEquipos(torneoSeleccionado.arbol, this.liga);
            frmEquipos.ShowDialog();
        }
    }
}
