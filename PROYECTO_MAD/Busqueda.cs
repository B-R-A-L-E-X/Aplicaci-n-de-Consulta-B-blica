using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void Busqueda_Buscar_Btn_Click(object sender, EventArgs e)
        {
            if (Busqueda_Generaltext.Text !="")
            {
                if (Busqueda_LibroAct_RB.Checked)
                {
                    string txtBuscar = Busqueda_Generaltext.Text;
                    string elementoSeleccionado = Busqueda_Libro_CB.SelectedItem.ToString();
                    Busqueda_DG.DataSource = VersiculoDAO.ObtenerVersiculosBusquedalibro(elementoSeleccionado, txtBuscar);
                    HistorialBusquedaDAO.GuardarHistorial(UsuarioDAO.usuarioActual.id, txtBuscar);
                }
                else if (Busqueda_TestamentoAct_RB.Checked)
                {
                    string txtBuscar = Busqueda_Generaltext.Text;
                    string elementoSeleccionado = Busqueda_Test_CB.SelectedItem.ToString();
                    Busqueda_DG.DataSource = VersiculoDAO.ObtenerVersiculosBusquedaTest(elementoSeleccionado, txtBuscar);
                    HistorialBusquedaDAO.GuardarHistorial(UsuarioDAO.usuarioActual.id, txtBuscar);
                }
                else if (Busqueda_GeneralAct_RB.Checked)
                {
                    string txtBuscar = Busqueda_Generaltext.Text;
                    Busqueda_DG.DataSource = VersiculoDAO.ObtenerVersiculosBusquedaGeneral(txtBuscar);
                    HistorialBusquedaDAO.GuardarHistorial(UsuarioDAO.usuarioActual.id, txtBuscar);
                }
            }

        }
        private void Busqueda_Historial_Btn_Click(object sender, EventArgs e)
        {
            HistorialBusquedas ed = new HistorialBusquedas();
            this.Hide();
            ed.Show();
        }

        private void Busqueda_Volver_Btn_Click(object sender, EventArgs e)
        {
            DashBoard ed = new DashBoard();
            this.Hide();
            ed.Show();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            Busqueda_Libro_CB.SelectedIndex = 0;
            Busqueda_Test_CB.SelectedIndex=0;

        }



    }
}
