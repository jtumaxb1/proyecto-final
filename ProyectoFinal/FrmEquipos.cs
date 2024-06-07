using EstructuraDatos.Arbol;
using EstructuraDatos.Clases;
using EstructuraDatos.ListaEnlazada;
using EstructuraDatos.TablaHash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmEquipos : Form
    {
        public ArbolAVL arbol;
        public TablaHashJugador tablaHashJugador;
        public List<Equipo> listEquipo;
        public int idEquipo;
        public string nombreEquipo;
        public string liga;
        public FrmEquipos(ArbolAVL arbol, string liga, TablaHashJugador tablaHashJugador)
        {
            this.arbol = arbol;
            this.tablaHashJugador = tablaHashJugador;
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
            Nodo indice;
            Lista listaNueva = new Lista();
            this.dgvEquipos.Rows.Clear();
            listEquipo = ArbolAVL.orden(this.arbol.raizArbol(), new List<Equipo>());
            var listaOrdenada = listEquipo.OrderByDescending(e => e.puntos).ToList();
            // listaNueva.insertarOrdenado(listEquipo);
            foreach (Equipo equipo in listaOrdenada)
            {
                this.dgvEquipos.Rows.Add(equipo.id, equipo.nombre, equipo.liga, equipo.pais, equipo.puntos);
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
            if (MessageBox.Show("¿Desea eliminar este equipo?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Resp resp = (Resp)this.arbol.buscar(idEquipo);
                this.arbol.eliminar(resp.equipo);
                MessageBox.Show("El equipo fue eliminado con exito", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.arbol.raizArbol() != null)
                {
                    CargarDatos();
                }
                else
                {
                    this.dgvEquipos.Rows.Clear();
                }
            }
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FrmJugadores frmJugadores = new FrmJugadores(this.tablaHashJugador, this.nombreEquipo);
            frmJugadores.ShowDialog();
        }

        private void dgvEquipos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvObjeto = (DataGridView)sender;
            DataGridViewCellCollection posicion = dgvObjeto.CurrentRow.Cells;
            if (posicion[0].Value != null)
            {
                idEquipo = int.Parse(posicion[0].Value.ToString());
                nombreEquipo = posicion[1].Value.ToString();
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnJugadores.Enabled = true;
            }
            else
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnJugadores.Enabled = false;
            }
        }
    }
}
