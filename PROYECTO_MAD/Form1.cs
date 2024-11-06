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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertarUsuarioBtn_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.correoElectronico = correoTxt.Text;
            usuario.contrasena = contrasenaTxt.Text;
            //usuario.nombre = nombreTxt.Text;

            //usuario.fechaNacimiento = fechaNacimientoDtPk.Value.Date;

            //if (generoRdH.Checked)
            //    usuario.genero = 0;
            //else
            //    usuario.genero = 1;

            //UsuarioDAO.InsertarUsuario(usuario);
            //refrescar();

            Editar ed = new Editar();
            this.Hide();
            ed.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UsuarioDAO.ObtenerUsuarios();
        }

        private void refrescar() {

            dataGridView1.DataSource = UsuarioDAO.ObtenerUsuarios();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            nombreTxt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void correoTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
