using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Usuario
    {

        public int id { get; set; }
        public string correoElectronico { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool genero { get; set; }
        public bool habilitado { get; set; }
        public bool loggin_attemps { get; set; }
        public DateTime fecha_Registro { get; set; }
        public DateTime fecha_Baja { get; set; }
        public bool User_Admin { get; set; }

        public Usuario() { }

        public Usuario(int id, string correoElectronico, string contrasena, string nombre, DateTime fechaNacimiento, 
                       bool genero, bool habilitado, bool loggin_attemps, DateTime fecha_Registro, DateTime fecha_Baja, bool User_Admin)
        {
            this.id = id;
            this.correoElectronico = correoElectronico;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.habilitado = habilitado;
            this.loggin_attemps = loggin_attemps;
            this.fecha_Registro = fecha_Registro;
            this.fecha_Baja = fecha_Baja;
            this.User_Admin = User_Admin;
        }
    }
}


