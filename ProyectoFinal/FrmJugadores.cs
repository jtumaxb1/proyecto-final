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
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmJugadores : Form
    {
        TablaHashJugador tablaHashJugador;
        public string equipo;
        public int idJugador;
        public FrmJugadores(TablaHashJugador tablaHashJugador, string equipo)
        {
            InitializeComponent();
            this.tablaHashJugador = tablaHashJugador;
            this.equipo = equipo;
        }

        private void AgreUpdateEventHandler(object sender, FrmInsertarActualizarJugador.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Nodo indice;
            this.dgvJugadores.Rows.Clear();
            Lista listaJugador = tablaHashJugador.buscarLista(equipo);

            if (listaJugador != null)
            {
                for (indice = listaJugador.primero; indice != null; indice = indice.Enlace)
                {
                    Jugador jugador = (Jugador)indice.Dato;
                    this.dgvJugadores.Rows.Add(jugador.id, jugador.nombre, jugador.apellido, jugador.dorsal, jugador.posicion, jugador.goles, jugador.tarjetaAmarillas, jugador.tarjetaRojas);
                }
            }
        }

        private void FrmJugadores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmInsertarActualizarJugador frmInsertarActualizarJugador = new FrmInsertarActualizarJugador(this.tablaHashJugador, this, null, this.equipo);
            frmInsertarActualizarJugador.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarActualizarJugador.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Lista listaJugadores = tablaHashJugador.buscarLista(equipo);
            Jugador jugador = (Jugador)listaJugadores.buscarNodo(idJugador);
            FrmInsertarActualizarJugador frmInsertarActualizarJugador = new FrmInsertarActualizarJugador(this.tablaHashJugador, this, jugador, this.equipo);
            frmInsertarActualizarJugador.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarActualizarJugador.ShowDialog();
        }

        private void dgvJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvObjeto = (DataGridView)sender;
            DataGridViewCellCollection posicion = dgvObjeto.CurrentRow.Cells;
            if (posicion[0].Value != null)
            {
                idJugador = int.Parse(posicion[0].Value.ToString());
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnAumetarGoles.Enabled = true;
                this.btnTarjetaAmarillas.Enabled = true;
                this.btnTarjetaRojas.Enabled = true;
            }
            else
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnAumetarGoles.Enabled = false;
                this.btnTarjetaAmarillas.Enabled = false;
                this.btnTarjetaRojas.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este Jugador?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Lista listaJugadores = tablaHashJugador.buscarLista(equipo);
                Jugador jugador = (Jugador)listaJugadores.buscarNodo(idJugador);
                listaJugadores.eliminar(jugador);
                MessageBox.Show("El jugador fue eliminado con exito", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnAumetarGoles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea aumentar los goles de este jugador?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tablaHashJugador.ActualizarGoles(equipo, idJugador);
                MessageBox.Show("Los goles del jugador fueron actualizados con exito", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnTarjetaAmarillas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea aumentar las tarjetas amarillas de este jugador?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tablaHashJugador.ActualizarTarjetasAmarillas(equipo, idJugador);
                MessageBox.Show("Las tarjetas amarillas del jugador fueron actualizados con exito", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnTarjetaRojas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea aumentar las tarjetas rojas de este jugador?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tablaHashJugador.ActualizarTarjetasRojas(equipo, idJugador);
                MessageBox.Show("Las tarjetas rojas del jugador fueron actualizados con exito", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
