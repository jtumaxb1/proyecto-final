using EstructuraDatos.Arbol;
using EstructuraDatos.Clases;
using EstructuraDatos.TablaHash;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {

        ArbolAVL arbolAVL = new ArbolAVL();
        TablaHashTorneo tablaHashTorneo = new TablaHashTorneo();
        TablaHashJugador tablaHashJugador = new TablaHashJugador();
        TablaHashPartido tablaHashPartido = new TablaHashPartido();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Equipo equipo = new Equipo(this.txtNombre.Text, this.txtPais.Text, this.txtLiga.Text);
            //arbolAVL.insertar(equipo);
            //String ejemplo = "Hola";
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            /* FrmEquipos frmEquipos = new FrmEquipos(arbolAVL);
            frmEquipos.ShowDialog(); */
        }

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            FrmTorneos frmTorneos = new FrmTorneos(tablaHashTorneo, tablaHashJugador, tablaHashPartido);
            frmTorneos.ShowDialog();
        }
    }
}
