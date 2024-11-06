using PROYECTO_MAD.DAO;
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
    public partial class HistorialBusquedas : Form
    {
        public HistorialBusquedas()
        {
            InitializeComponent();
        }

        private void Historial_Volver_Btn_Click(object sender, EventArgs e)
        {
            Busqueda ed = new Busqueda();
            this.Hide();
            ed.Show();
        }

        private void Historial_Eliminar_Btn_Click(object sender, EventArgs e)
        {
            HistorialBusquedaDAO.EliminarHistorial(UsuarioDAO.usuarioActual.id);
            HistorialBusquedas ed = new HistorialBusquedas();
            this.Hide();
            ed.Show();
        }

        private void HistorialBusquedas_Load(object sender, EventArgs e)
        {
            Historial_Historial_DG.DataSource = HistorialBusquedaDAO.ObtenerHistorial_Busquedas(UsuarioDAO.usuarioActual.id);
        }

        private void Historial_Historial_DG_SelectionChanged(object sender, EventArgs e)
        {

            string aux = Convert.ToString(Historial_Historial_DG.CurrentRow.Cells["Texto_Buscado"].Value);
            
            Historial_Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosBusquedaGeneral(aux);
        }
    }
}
