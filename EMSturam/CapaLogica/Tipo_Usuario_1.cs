using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    class Tipo_Usuario
    {
        private int id_tipo_usuarios;
        private string tipo_usuarios;
        public Tipo_Usuario()
        {

        }
        public string ToStringAreas()
        {
            return id_tipo_usuarios + " - " + tipo_usuarios;
        }

        public int Pid_tipo_usuarios { get => id_tipo_usuarios; set => id_tipo_usuarios = value; }
        public string Ptipo_usuarios { get => tipo_usuarios; set => tipo_usuarios = value; }
    }
}
