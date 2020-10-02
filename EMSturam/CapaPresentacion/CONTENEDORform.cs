using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CONTENEDORform : FormBASEtradicional
    {
        public CONTENEDORform()
        {
            InitializeComponent();
        }
      
        private void InsertaContenedor(object formHijo)
        {
            if (pn_contenedor.Controls.Count > 0)
            {
                pn_contenedor.Controls.RemoveAt(0);
            }
            Form hijo = (Form)formHijo;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;            
            pn_contenedor.Controls.Add(hijo);           
            pn_contenedor.Tag = hijo;
            hijo.Show();
        }
      

        private void pn_menuIzquierdo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pn_menuIzquierdo.Width == 220)
            {
                pn_menuIzquierdo.Width = 15;
            }
            else
            {
                pn_menuIzquierdo.Width = 220;
            }
        }

        private void btn_ingenieria_Click(object sender, EventArgs e)
        {
            InsertaContenedor(new AREASform());
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            if(pn_login.Height==45)
            {
                pn_login.Height = 350;
            }
            else
            {
                pn_login.Height = 45;
            }
        }
    }
}
