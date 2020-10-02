using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class TRABAJADORESform : Form
    {
        public TRABAJADORESform()
        {
            InitializeComponent();
        }
        Trabajador trabajadorCargar = new Trabajador();
        
        private void btn_seleccionarFoto_Click(object sender, EventArgs e)
        {
            ofd_selectorFoto.ShowDialog();
            if(ofd_selectorFoto.FileName!="")
            {
                lbl_apellido.Text = ofd_selectorFoto.FileName;
                Image miImagen = Bitmap.FromFile(ofd_selectorFoto.FileName);
                MemoryStream ms = new MemoryStream();               
                miImagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                trabajadorCargar.Pfoto_trabajador = ms.GetBuffer();
                ms = new MemoryStream(trabajadorCargar.Pfoto_trabajador);
                pbx_foto.Image = Bitmap.FromStream(ms);
                pbx_foto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
