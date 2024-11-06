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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_MAD
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void Editar_Volver_Btn_Click(object sender, EventArgs e)
        {
            DashBoard ed = new DashBoard();
            this.Hide();
            ed.Show();
        }

        private void Editar_Usuario_Btn_Click(object sender, EventArgs e)
        {

            //UsuarioDAO.usuarioActual.correoElectronico = Editar_correoTxt.Text;
            //UsuarioDAO.usuarioActual.contrasena = Editar_contrasenaTxt.Text;
            //UsuarioDAO.usuarioActual.correoElectronico = Editar_correoTxt.Text;
            
            if(Editar_generoRdH.Checked){

                UsuarioDAO.usuarioActual.genero = false;
            }
            else{

                UsuarioDAO.usuarioActual.genero = true;
            }

            if (UsuarioDAO.usuarioActual.contrasena == Editar_contrasenaTxt.Text) {

                    UsuarioDAO.EditarUsuarioSinContra(UsuarioDAO.usuarioActual.id, Editar_nombreTxt.Text,
                                         Editar_correoTxt.Text,
                                         UsuarioDAO.usuarioActual.genero,
                                         Editar_fechaNacimientoDtPk.Value.ToString("yyyy-MM-dd"));

                    IniciarSesion ed = new IniciarSesion();
                    this.Hide();
                    ed.Show();   

            }
            else{
                if (HistorialContraDAO.RevisarHistorial(UsuarioDAO.usuarioActual.id, Editar_contrasenaTxt.Text) == false)
                {
                    string texto = Editar_contrasenaTxt.Text;
                    Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

                    if (regex.IsMatch(texto)){
                        Console.WriteLine("La contraseña cumple con los requisitos.");
                        UsuarioDAO.EditarUsuario(UsuarioDAO.usuarioActual.id, Editar_nombreTxt.Text,
                                        Editar_contrasenaTxt.Text, Editar_correoTxt.Text,
                                        UsuarioDAO.usuarioActual.genero,
                                        Editar_fechaNacimientoDtPk.Value.ToString("yyyy-MM-dd"));

                        IniciarSesion ed = new IniciarSesion();
                        this.Hide();
                        ed.Show();
                    }
                    else{
                        MessageBox.Show("NO cumple las Condiciones", "Contraseña ERROR", MessageBoxButtons.OK);
                    }
                 
                }

            }

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            
            Editar_correoTxt.Text = UsuarioDAO.usuarioActual.correoElectronico;
            Editar_contrasenaTxt.Text = UsuarioDAO.usuarioActual.contrasena ;
            Editar_nombreTxt.Text = UsuarioDAO.usuarioActual.nombre ;
            Editar_fechaNacimientoDtPk.Value = UsuarioDAO.usuarioActual.fechaNacimiento;


            if (UsuarioDAO.usuarioActual.genero == false)
                Editar_generoRdH.Checked = true;
            else
                Editar_generoRdM.Checked = true;

            //UsuarioDAO.EditarUsuario(usuario); *EDITAR*
            //refrescar();
        }

        private void Editar_Habilitado_Btn_Click(object sender, EventArgs e)
        {
            UsuarioDAO.EliminarUsuario(UsuarioDAO.usuarioActual.id);
            IniciarSesion ed = new IniciarSesion();
            this.Hide();
            ed.Show();
        }

    }
}
