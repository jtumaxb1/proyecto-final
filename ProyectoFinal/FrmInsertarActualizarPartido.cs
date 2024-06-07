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
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmInsertarActualizarPartido : Form
    {
        public ArbolAVL arbol;
        public List<Equipo> listEquipo;
        public TablaHashPartido tablaHashPartido;
        public Partido partido;
        public string liga;
        public FrmInsertarActualizarPartido(ArbolAVL arbol, String liga, TablaHashPartido tablaHashPartido, FrmPartidos partidos, Partido partido)
        {
            InitializeComponent();
            this.arbol = arbol;
            this.liga = liga;
            this.partido = partido;
            this.tablaHashPartido = tablaHashPartido;
            if (partido != null)
            {
                this.cmbEquipoLocal.Text = partido.equipoLocal;
                this.cmbEquipoVisitante.Text = partido.equipoVisitante;
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


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInsertarActualizarPartido_Load(object sender, EventArgs e)
        {
            this.listEquipo = ArbolAVL.orden(this.arbol.raizArbol(), new List<Equipo>());
            foreach (Object obj in this.listEquipo)
            {
                Equipo equipo = (Equipo)obj;
                this.cmbEquipoLocal.Items.Add(equipo.nombre);
                this.cmbEquipoVisitante.Items.Add(equipo.nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.partido == null)
            {
                Partido partido;
                Lista listaPartido = this.tablaHashPartido.buscarLista(this.liga);
                if (listaPartido == null)
                {
                    partido = new Partido(1, this.cmbEquipoLocal.Text, this.cmbEquipoVisitante.Text);
                }
                else
                {
                    partido = new Partido((listaPartido.cantidad + 1), this.cmbEquipoLocal.Text, this.cmbEquipoVisitante.Text);
                }
                this.tablaHashPartido.Insertar(partido, liga);
                MessageBox.Show("Partido ingresado correctamente", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agregar();
                this.Close();
            } else
            {
                this.partido.equipoLocal = this.cmbEquipoLocal.Text;
                this.partido.equipoVisitante = this.cmbEquipoVisitante.Text;
                this.tablaHashPartido.Actualizar(this.partido, liga, this.partido.id);
                MessageBox.Show("Partido Actualizado correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agregar();
                this.Close();
            }
        }
    }
}
