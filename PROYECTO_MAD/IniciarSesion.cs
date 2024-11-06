using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;

namespace PROYECTO_MAD
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        public static int Intentos;

        private void InicarSesion_Btn_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.correoElectronico = InicarSesion_correoTxt.Text;
            usuario.contrasena = InicarSesion_contrasenaTxt.Text;

            Usuario usuarioObtener = UsuarioDAO.ObtenerUsuario(usuario.correoElectronico, usuario.contrasena);

            if (usuarioObtener.habilitado == false && (usuarioObtener.contrasena == usuario.contrasena && (usuarioObtener.correoElectronico == usuario.correoElectronico)))
            {
                    Intentos = 0;

                    UsuarioDAO.usuarioActual = usuarioObtener;

                    Editar ed = new Editar();
                    this.Hide();
                    ed.Show();
                

            }else if (usuarioObtener.contrasena == usuario.contrasena && (usuarioObtener.correoElectronico == usuario.correoElectronico) && ((usuarioObtener.habilitado == true) && (usuarioObtener.loggin_attemps == false)))
            {
                Intentos = 0;

                UsuarioDAO.usuarioActual = usuarioObtener;

                DashBoard ed = new DashBoard();
                this.Hide();
                ed.Show();

            }
            else if(usuario.correoElectronico != "" && usuario.contrasena != "")
            {

                    Intentos++;

                if (Intentos > 3)
                {
                    UsuarioDAO.DeshabilitarUsuario(usuario.correoElectronico, usuario.contrasena);
                    MessageBox.Show("Inexistente o Desabilitado / Use Contraseña Temporal", "Usuario:", MessageBoxButtons.OK);

                    Usuario usuariotemp = UsuarioDAO.ObtenerUsuario(usuario.correoElectronico);
                    MessageBox.Show(usuariotemp.contrasena, "Contraseña Temporal:", MessageBoxButtons.OK);
                    Intentos = 0;
                    IniciarSesion ed = new IniciarSesion();
                    this.Hide();
                    ed.Show();
                }

            }
            
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            Intentos = 0;
        }

    }
}
