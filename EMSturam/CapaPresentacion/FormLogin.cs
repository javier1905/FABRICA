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
using CapaLogica;
namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        PictureBox cerrar = new PictureBox();
        Area miArea = new Area();
        public FormLogin()
        {            
            
            InitializeComponent();
            cerrar.Image = Image.FromFile("E:/Proyectos Visual Basic/EMS/Iconos/cerrar.gif");
            cerrar.Visible = true;
            cerrar.Cursor = Cursors.Hand;
            cerrar.Size = new Size(30, 30);
            cerrar.Location = new Point(this.Width - cerrar.Width - 5, 5);
            cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            cerrar.Anchor = AnchorStyles.Top;
            cerrar.Anchor = AnchorStyles.Right;
            pn_barraTitulo.Controls.Add(cerrar);
            cerrar.Click += new EventHandler(EventoCerrar);
            cerrar.MouseEnter += new EventHandler(EfectoEntrar);
            cerrar.MouseLeave += new EventHandler(EfectoSalir);            
            txt_pass.Text = "Password";
            txt_pass.ForeColor = Color.FromArgb(213, 219, 219);
        }
        public void EventoCerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EfectoEntrar(object sender, EventArgs e)
        {
            PictureBox oo = new PictureBox();
            oo = (PictureBox)sender;
            oo.BackColor = Color.FromArgb(97, 156, 241);
        }
        private void EfectoSalir(object sender, EventArgs e)
        {
            PictureBox oo = new PictureBox();
            oo = (PictureBox)sender;
            oo.BackColor = Color.FromArgb(51, 51, 255);
        }
        //private void AbrirHija(object formHija)
        //{
        //    if (pn_contenedorFILL.Controls.Count > 0)
        //    {
        //        pn_contenedorFILL.Controls.RemoveAt(0);
        //    }
        //    Form hija = (Form)formHija;
        //    //Form hija =formHija as Form;
        //    hija.Dock = DockStyle.Fill;
        //    hija.TopLevel = false;
        //    pn_contenedorFILL.Tag = hija;
        //    pn_contenedorFILL.Controls.Add(hija);
        //    hija.Show();
        //}


        private void FormLogin_Load(object sender, EventArgs e)
        {
            pn_barraTitulo.BackColor = Color.FromArgb(51, 51, 255);
            txt_usuario.Focus();
            btn_aceptar.Enabled = false;
            //AbrirHija(new AREASform());
        }

        private void Pn_barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // ------- MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TXT_usuario_Entra(object sender, EventArgs e)
        {
            if(txt_usuario.Text=="Usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.FromArgb(86, 101, 115);
            }
        }
        private void TXT_usuario_Sale(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.FromArgb(213, 219, 219);
            }
        }

        private void TXT_pass_Entra(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Password")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.FromArgb(86, 101, 115);              
                txt_pass.UseSystemPasswordChar = true;                
            }
        }
        private void TXT_pass_Sale(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Password";
                txt_pass.ForeColor = Color.FromArgb(213, 219, 219);                
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            jMessajeBoxSiNo oo = new jMessajeBoxSiNo("Confirmacion", "Esta seguro de modificar el elemento ");
            if(oo.ShowDialog()==DialogResult.Yes)
            {
                miArea.Pid_area = Convert.ToInt32(txt_usuario.Text);
                miArea.Pnombre_area = txt_pass.Text;
                string msj = miArea.ModificaArea();
                jMessajeBoxAceptar miMensaje = new jMessajeBoxAceptar("Atencion", msj);
                miMensaje.ShowDialog();
            }           
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            if(txt_usuario.Text=="" || txt_pass.Text=="" || txt_usuario.Text == "Usuario" || txt_pass.Text == "Password")
            {
                btn_aceptar.Enabled = false;
            }
            else
            {
                btn_aceptar.Enabled = true;
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
