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
    public partial class FrmInsertarActualizarJugador : Form
    {
        public TablaHashJugador hashJugador;
        public Jugador jugador;
        public string clave;
        public FrmInsertarActualizarJugador(TablaHashJugador tablaHashJugador, FrmJugadores jugadores, Jugador jugador, String clave)
        {
            InitializeComponent();
            this.hashJugador = tablaHashJugador;
            this.jugador = jugador;
            this.clave = clave;
            if (jugador != null)
            {
                this.txtNombre.Text = jugador.nombre;
                this.txtApellido.Text = jugador.apellido;
                this.txtPosicion.Text = jugador.posicion;
                this.txtDorsal.Text = jugador.dorsal.ToString();
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
            if (this.jugador == null)
            {
                Jugador jugador;
                Lista listaJugadores = this.hashJugador.buscarLista(clave);
                if (listaJugadores == null)
                {
                    jugador = new Jugador(1, this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtDorsal.Text), this.txtPosicion.Text);
                }
                else
                {
                    jugador = new Jugador((listaJugadores.cantidad + 1), this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtDorsal.Text), this.txtPosicion.Text);
                }
                this.hashJugador.Insertar(jugador, clave);
                MessageBox.Show("Jugador ingresado correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agregar();
                this.Close();
            }
            else
            {
                Lista listaJugadores = this.hashJugador.buscarLista(clave);
                this.jugador.nombre = this.txtNombre.Text;
                this.jugador.apellido = this.txtApellido.Text;
                this.jugador.posicion = this.txtPosicion.Text;
                this.jugador.dorsal = Convert.ToInt32(this.txtDorsal.Text);
                this.hashJugador.Actualizar(this.jugador, this.clave, this.jugador.id);
                MessageBox.Show("Jugador Actualizado correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agregar();
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
