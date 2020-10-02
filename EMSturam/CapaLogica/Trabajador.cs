using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Trabajador
    {
        private int id_trabajador;
        private string nombre_trabajador;
        private string apellido_trabajador;
        private DateTime f_nacimiento_trabajador;
        private Puesto puesto_trabajador = new Puesto();
        private DateTime f_ingreso_trabajador;
        private Area area_trabajador=new Area();
        private byte[] foto_trabajador;
        public Trabajador()
        {
        id_trabajador=0;
        nombre_trabajador="";
        apellido_trabajador="";
        f_nacimiento_trabajador=DateTime.Today;         
        f_ingreso_trabajador=DateTime.Today;          
        }
        public string ToStringTrabajador()
        {
            return id_trabajador + " - " + nombre_trabajador + " " + apellido_trabajador;
        }
        public int Pid_trabajador { get => id_trabajador; set => id_trabajador = value; }
        public string Pnombre_trabajador { get => nombre_trabajador; set => nombre_trabajador = value; }
        public string Papellido_trabajador { get => apellido_trabajador; set => apellido_trabajador = value; }
        public DateTime Pf_nacimiento_trabajador { get => f_nacimiento_trabajador; set => f_nacimiento_trabajador = value; }
        public DateTime Pf_ingreso_trabajador { get => f_ingreso_trabajador; set => f_ingreso_trabajador = value; }
        public Area Parea_trabajador { get => area_trabajador; set => area_trabajador = value; }
        public byte[] Pfoto_trabajador { get => foto_trabajador; set => foto_trabajador = value; }
        internal Puesto Ppuesto_trabajador { get => puesto_trabajador; set => puesto_trabajador = value; }
    }
}
