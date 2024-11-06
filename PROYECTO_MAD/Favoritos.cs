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
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();
        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            Favoritos_DG.DataSource = VersiculoDAO.ObtenerFavoritos(UsuarioDAO.usuarioActual.id);
            
        }
        private void Favs_Volver_Btn_Click(object sender, EventArgs e)
        {
            DashBoard ed = new DashBoard();
            this.Hide();
            ed.Show();
        }
        private void Favoritos_Fav_Btn_Click(object sender, EventArgs e)
        {
            if (Favoritos_idTxt.Text != "")
            {
                string id = Favoritos_idTxt.Text;
                int idaux = int.Parse(id);
                VersiculoDAO.BorrarFavorito(UsuarioDAO.usuarioActual.id, idaux);

                Favoritos ed = new Favoritos();
                this.Hide();
                ed.Show();
            }
        }
        

        private void Favoritos_DG_SelectionChanged(object sender, EventArgs e)
        {
            Favoritos_idTxt.Text = Convert.ToString(Favoritos_DG.CurrentRow.Cells["ID"].Value);
        }


    }
}
