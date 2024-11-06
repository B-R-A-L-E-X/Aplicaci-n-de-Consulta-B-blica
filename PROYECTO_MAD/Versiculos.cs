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
    public partial class Versiculos : Form
    {
        public Versiculos()
        {
            InitializeComponent();
        }

        private void Versiculos_Load(object sender, EventArgs e)
        {
            
        }

        private void Versiculos_Volver_Btn_Click(object sender, EventArgs e)
        {
            DashBoard ed = new DashBoard();
            this.Hide();
            ed.Show();
        }

        private void Versiculos_Fav_Btn_Click(object sender, EventArgs e)
        {
            //DashBoard ed = new DashBoard();
            //this.Hide();
            //ed.Show();

            if (Versiculos_idTxt.Text != "")
            {
                string id = Versiculos_idTxt.Text;
                int idaux = int.Parse(id);
                UsuarioDAO.GuardarFavorito(idaux, UsuarioDAO.usuarioActual.id);
            }
        }
        private void Versiculo_Libro_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elementoSeleccionado = Versiculo_Libro_CB.SelectedItem.ToString();
            Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculoslibro(elementoSeleccionado);
        }

        private void Versiculo_Capitulo_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elementoSeleccionado = Versiculo_Capitulo_CB.SelectedItem.ToString();
            Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosCapitulo(elementoSeleccionado);
        }

        private void Versiculo_Versiculo_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elementoSeleccionado = Versiculo_Versiculo_CB.SelectedItem.ToString();
            Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosVersiculo(elementoSeleccionado);
        }

        private void Versiculos_IdiomaE_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Versiculos_IdiomaE_RB.Checked)
            {
                Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosCheckIdiomaEsp();
            }
        }

        private void Versiculos_IdiomaI_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Versiculos_IdiomaI_RB.Checked)
            {
                Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosCheckIdiomaIng();
            }
        }

        private void Versiculos_NuevoTestamento_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Versiculos_NuevoTestamento_RB.Checked)
            {
                Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosCheckNuevoTest();
            }
        }

        private void Versiculos_ViejoTestamento_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Versiculos_ViejoTestamento_RB.Checked)
            {
                Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosCheckAntiguoTest();
            }
        }

        private void Versiculos_NewTestament_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Versiculos_NewTestament_RB.Checked)
            {
                Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosCheckNewTest();
            }
        }

        private void Versiculos_OldTestament_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Versiculos_OldTestament_RB.Checked)
            {
                Versiculos_DG.DataSource = VersiculoDAO.ObtenerVersiculosCheckOldTest();
            }
        }

        private void Versiculos_DG_SelectionChanged(object sender, EventArgs e)
        {
            Versiculos_idTxt.Text = Convert.ToString(Versiculos_DG.CurrentRow.Cells["ID"].Value);
        }

    }
}
