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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Dash_Editar_Btn_Click(object sender, EventArgs e)
        {
            Editar ed = new Editar();
            this.Hide();
            ed.Show();
        }

        private void Dash_Favoritos_Btn_Click(object sender, EventArgs e)
        {
            Favoritos ed = new Favoritos();
            this.Hide();
            ed.Show();
        }

        private void Dash_Versiculos_Btn_Click(object sender, EventArgs e)
        {
            Versiculos ed = new Versiculos();
            this.Hide();
            ed.Show();
        }

        private void Dash_Busqueda_Btn_Click(object sender, EventArgs e)
        {
            Busqueda ed = new Busqueda();
            this.Hide();
            ed.Show();
        }

        private void Dash_CerrarSesion_Btn_Click(object sender, EventArgs e)
        {
            IniciarSesion ed = new IniciarSesion();
            this.Hide();
            ed.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
