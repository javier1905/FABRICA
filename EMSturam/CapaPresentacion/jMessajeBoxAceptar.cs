using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class jMessajeBoxAceptar : Form
    {
        public jMessajeBoxAceptar(string Titulo, string mensaje)
        {
            InitializeComponent();
            lbl_titulo.Text = Titulo;
            lbl_mensaje.Text = mensaje;
        }
        // ------- MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //------ FIN MOVER VENTANA

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
