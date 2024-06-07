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
    public partial class FrmPartidos : Form
    {

        public ArbolAVL arbol;
        public List<Object> listEquipo;
        public TablaHashPartido tablaHashPartido;
        public string liga;
        public int idPartido;
        public string equipoLocalPartido;
        public string equipoVisitantePartido;

        public FrmPartidos(ArbolAVL arbol, string liga, TablaHashPartido tablaHashPartido)
        {
            this.arbol = arbol;
            this.liga = liga;
            this.tablaHashPartido = tablaHashPartido;
            InitializeComponent();
        }

        private void AgreUpdateEventHandler(object sender, FrmInsertarActualizarPartido.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Nodo indice;
            this.dgvPartidos.Rows.Clear();
            Lista listaPartido = tablaHashPartido.buscarLista(liga);
            if (listaPartido != null)
            {
                for (indice = listaPartido.primero; indice != null; indice = indice.Enlace)
                {
                    Partido partido = (Partido)indice.Dato;
                    this.dgvPartidos.Rows.Add(partido.id, partido.equipoLocal, partido.marcadorLocal, partido.equipoVisitante, partido.marcadorVisitante, partido.flag);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmInsertarActualizarPartido frmInsertarActualizarPartido = new FrmInsertarActualizarPartido(this.arbol, this.liga, this.tablaHashPartido, this, null);
            frmInsertarActualizarPartido.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarActualizarPartido.ShowDialog();
        }

        private void dgvPartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvObjeto = (DataGridView)sender;
            DataGridViewCellCollection posicion = dgvObjeto.CurrentRow.Cells;
            if (posicion[0].Value != null && posicion[5].Value.Equals(true))
            {
                idPartido = int.Parse(posicion[0].Value.ToString());
                this.equipoLocalPartido = posicion[1].Value.ToString();
                this.equipoVisitantePartido = posicion[3].Value.ToString();
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnAumentarGolesLocal.Enabled = true;
                this.btnAumentarGolesVisitante.Enabled = true;
                this.btnTerminarPartido.Enabled = true;
            }
            else
            {
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnAumentarGolesLocal.Enabled = false;
                this.btnAumentarGolesVisitante.Enabled = false;
                this.btnTerminarPartido.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Lista listaPartido = tablaHashPartido.buscarLista(liga);
            Partido partido = (Partido)listaPartido.buscarNodoPartido(idPartido);
            FrmInsertarActualizarPartido frmInsertarActualizarPartido = new FrmInsertarActualizarPartido(this.arbol, this.liga, this.tablaHashPartido, this, partido);
            frmInsertarActualizarPartido.UpdateEventHandler += AgreUpdateEventHandler;
            frmInsertarActualizarPartido.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este Partido?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Lista listaPartido = tablaHashPartido.buscarLista(liga);
                Partido partido = (Partido)listaPartido.buscarNodoPartido(idPartido);
                listaPartido.eliminar(partido);
                MessageBox.Show("El partido fue eliminado con exito", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnAumentarGolesLocal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea aumentar goles del equipo local?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Lista listaPartido = tablaHashPartido.buscarLista(liga);
                listaPartido.actualizarGolesLocal(idPartido);
                MessageBox.Show("Se aumento los goles del equipo local", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnAumentarGolesVisitante_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea aumentar goles del equipo visitante?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Lista listaPartido = tablaHashPartido.buscarLista(liga);
                listaPartido.actualizarGolesVisitante(idPartido);
                MessageBox.Show("Se aumento los goles del equipo visitante", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnTerminarPartido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea terminar el partido?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Lista listaPartido = tablaHashPartido.buscarLista(liga);
                Partido partido = (Partido)listaPartido.buscarNodoPartido(idPartido);
                Equipo equipoLocalPartidoActual = (Equipo)arbol.buscarPorNombre(this.equipoLocalPartido);
                Equipo equipoVisitantePartidoActual = (Equipo)arbol.buscarPorNombre(this.equipoVisitantePartido);
                if (partido.marcadorLocal == partido.marcadorVisitante)
                {
                    equipoLocalPartidoActual.puntos += 1;
                    equipoVisitantePartidoActual.puntos += 1;
                    arbol.actualizar(equipoLocalPartidoActual, equipoLocalPartidoActual.nombre);
                    arbol.actualizar(equipoVisitantePartidoActual, equipoVisitantePartidoActual.nombre);
                    MessageBox.Show($"El partido finalizo con un empate | marcador: {partido.marcadorLocal} - {partido.marcadorVisitante}", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (partido.marcadorLocal > partido.marcadorVisitante)
                {
                    equipoLocalPartidoActual.puntos += 3;
                    arbol.actualizar(equipoLocalPartidoActual, equipoLocalPartidoActual.nombre);
                    MessageBox.Show($"El partido finalizo con el equipo local como vencedor | marcador: {partido.marcadorLocal} - {partido.marcadorVisitante}", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    equipoVisitantePartidoActual.puntos += 3;
                    arbol.actualizar(equipoVisitantePartidoActual, equipoVisitantePartidoActual.nombre);
                    MessageBox.Show($"El partido finalizo con el equipo visitante como vencedor | marcador: {partido.marcadorLocal} - {partido.marcadorVisitante}", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.btnActualizar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnAumentarGolesLocal.Enabled = false;
                this.btnAumentarGolesVisitante.Enabled = false;
                this.btnTerminarPartido.Enabled = false;
                partido.flag = false;
                this.tablaHashPartido.Actualizar(partido, this.liga, idPartido);
                CargarDatos();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
