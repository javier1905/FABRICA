using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    class Usuario
    {
        private string nick;
        private string pass;
        private Trabajador miTrabajador = new Trabajador();
        private Tipo_Usuario MiTipoUsuario=new Tipo_Usuario();
        public Usuario()
        {

        }
        public string Pnick { get => nick; set => nick = value; }
        public string Ppass { get => pass; set => pass = value; }
        internal Trabajador PmiTrabajador { get => miTrabajador; set => miTrabajador = value; }
        internal Tipo_Usuario PmiTipoUsuario { get => MiTipoUsuario; set => MiTipoUsuario = value; }
    }
}
