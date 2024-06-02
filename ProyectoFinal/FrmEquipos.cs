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
    public partial class FrmEquipos : Form
    {
        public ArbolAVL arbol;
        public List<Object> listEquipo;
        public int idEquipo;
        public string liga;
        public FrmEquipos(ArbolAVL arbol, string liga)
        {
            this.arbol = arbol;
            InitializeComponent();
            this.liga = liga;
        }

        private void AgreUpdateEventHandler(object sender, FrmInsertarActualizarEquipo.UpdateEventArgs args)
        {
            if (this.arbol.raizArbol() != null)
            {
                CargarDatos();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertarActualizarEquipo frmInsertarActualizarEquipo = new FrmInsertarActualizarEquipo(this.arbol, this, null, this.liga);
            frmInsertarActualizarEquipo.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarActualizarEquipo.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {

            if (this.arbol.raizArbol() != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            this.dgvEquipos.Rows.Clear();
            listEquipo = ArbolAVL.orden(this.arbol.raizArbol(), new List<object>());
            for (int i = 0; i < listEquipo.Count; i++)
            {
                Equipo equipo = (Equipo)listEquipo[i];
                this.dgvEquipos.Rows.Add(equipo.id, equipo.nombre, equipo.pais, equipo.liga);
            }
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvObjeto = (DataGridView)sender;
            DataGridViewCellCollection posicion = dgvObjeto.CurrentRow.Cells;
            if (posicion[0].Value != null)
            {
                idEquipo = int.Parse(posicion[0].Value.ToString());
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Resp resp = (Resp)this.arbol.buscar(idEquipo);
            FrmInsertarActualizarEquipo frmInsertarActualizarEquipo = new FrmInsertarActualizarEquipo(this.arbol, this, resp.equipo, this.liga);
            frmInsertarActualizarEquipo.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarActualizarEquipo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Resp resp = (Resp)this.arbol.buscar(idEquipo);
            this.arbol.eliminar(resp.equipo);
            if (this.arbol.raizArbol() != null)
            {
                CargarDatos();
            } else
            {
                this.dgvEquipos.Rows.Clear();
            }
        }
    }
}
