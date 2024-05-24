using EstructuraDatos.Arbol;
using EstructuraDatos.Clases;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        
        ArbolAVL arbolAVL = new ArbolAVL();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo(this.txtNombre.Text, this.txtPais.Text, this.txtLiga.Text);
            arbolAVL.insertar(equipo);
            String ejemplo = "Hola";
        }
    }
}
