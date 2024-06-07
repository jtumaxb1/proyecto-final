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

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            FrmTorneos frmTorneos = new FrmTorneos(tablaHashTorneo, tablaHashJugador, tablaHashPartido);
            frmTorneos.ShowDialog();
        }
    }
}
