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
    public partial class FormBASEtradicional : Form
    {
         PictureBox cerrar = new PictureBox();
         PictureBox maximizar = new PictureBox();
         PictureBox restaurar = new PictureBox();
         PictureBox minimizar = new PictureBox();
         Size ultimoTamaño = new Size();
         Point ultimaPosicion = new Point();
        public FormBASEtradicional()
        {
            InitializeComponent();
            //-------PANEL BARRA
            pn_barraTitulo.BackColor = Color.FromArgb(51, 51, 255);
            //------- BOTON CERRAR
            cerrar.Image = Image.FromFile("E:/Proyectos Visual Basic/EMSturam/Iconos/cerrar.gif");
            cerrar.Visible = true;
            cerrar.Cursor = Cursors.Hand;           
            cerrar.Size = new Size(30, 30);
            cerrar.Location = new Point(this.Width - cerrar.Width-5, 5);            
            cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            cerrar.Anchor = AnchorStyles.Top;
            cerrar.Anchor = AnchorStyles.Right;
            pn_barraTitulo.Controls.Add(cerrar);
            cerrar.Click += new EventHandler(EventoCerrar);
            cerrar.MouseEnter += new EventHandler(EfectoEntrar);
            cerrar.MouseLeave += new EventHandler(EfectoSalir);

            //------ BOTON MAXIMIZAR-------
            maximizar.Image = Image.FromFile("E:/Proyectos Visual Basic/EMSturam/Iconos/maximizar.gif");
            maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            maximizar.Cursor = Cursors.Hand;
            maximizar.Visible = true;
            maximizar.Size = new Size(30,30);
            maximizar.Location = new Point(this.Width-cerrar.Width-5-maximizar.Width-5,5);
            maximizar.Anchor = AnchorStyles.Top;
            maximizar.Anchor = AnchorStyles.Right;
            pn_barraTitulo.Controls.Add(maximizar);
            maximizar.BringToFront(); // envia el elemento al frente
            maximizar.Click += new EventHandler(EventoMaximizar);
            maximizar.MouseEnter += new EventHandler(EfectoEntrar);
            maximizar.MouseLeave += new EventHandler(EfectoSalir);
            // ------BOTON MINIMIZAR------
            minimizar.Image = Image.FromFile("E:/Proyectos Visual Basic/EMSturam/Iconos/minimizar.gif");
            minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            minimizar.Visible = true;
            minimizar.Cursor = Cursors.Hand;
            minimizar.Size = new Size(30,30);
            minimizar.Location = new Point(maximizar.Location.X-minimizar.Width-5,5);
            minimizar.Anchor = AnchorStyles.Top;
            minimizar.Anchor = AnchorStyles.Right;
            pn_barraTitulo.Controls.Add(minimizar);
            minimizar.Click += new EventHandler(EventoMinimizar);
            minimizar.MouseEnter += new EventHandler(EfectoEntrar);
            minimizar.MouseLeave += new EventHandler(EfectoSalir);

            restaurar.Image = Image.FromFile("E:/Proyectos Visual Basic/EMSturam/Iconos/restaurar.gif");
            restaurar.SizeMode = PictureBoxSizeMode.Zoom;
            restaurar.Visible = true;
            restaurar.Cursor = Cursors.Hand;
            restaurar.Size = new Size(30, 30);
            restaurar.Location = new Point(this.Width - cerrar.Width - 5 - maximizar.Width - 5, 5);
            restaurar.Anchor = AnchorStyles.Top;
            restaurar.Anchor = AnchorStyles.Right;
            pn_barraTitulo.Controls.Add(restaurar);
            restaurar.SendToBack();
            restaurar.Click += new EventHandler(EventoRestaurar);
            restaurar.MouseEnter += new EventHandler(EfectoEntrar);
            restaurar.MouseLeave += new EventHandler(EfectoSalir);
            pn_barraTitulo.MouseDown +=new MouseEventHandler(BarraTitulo_MouseDown);
        }

        // ------- MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //------ FIN MOVER VENTANA
        private void EfectoEntrar(object sender, EventArgs e)
        {
            PictureBox oo = new PictureBox();
            oo = (PictureBox)sender;
            oo.BackColor= Color.FromArgb(97, 156, 241);
        }
        private void EfectoSalir(object sender, EventArgs e)
        {
            PictureBox oo = new PictureBox();
            oo = (PictureBox)sender;
            oo.BackColor = Color.FromArgb(51, 51, 255);
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (this.WindowState == FormWindowState.Normal)
            {                
                maximizar.Visible = true;
                restaurar.Visible = false;
            }
            ultimaPosicion = this.Location;
            
            if(this.Size== Screen.PrimaryScreen.WorkingArea.Size )
            {
                this.Size = ultimoTamaño;
            }          
        }
       
        public void AgregarBotones()
        {

        }
        public void EventoCerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void EventoMaximizar(object sender, EventArgs e)
        {
            if (this.Size != Screen.PrimaryScreen.WorkingArea.Size && this.Location != Screen.PrimaryScreen.WorkingArea.Location)         
            {
                ultimoTamaño = this.Size;
                ultimaPosicion = this.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                maximizar.Visible = false;
                restaurar.Visible = true;
            }
        }
        public void EventoMinimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void EventoRestaurar(object sender, EventArgs e)
        {
            if (this.Size== Screen.PrimaryScreen.WorkingArea.Size)
            {
                this.Size = ultimoTamaño;
                this.Location = ultimaPosicion;
                restaurar.Visible = false;
                maximizar.Visible = true;
            }
        }

        //OPCION 2 CON PANELES
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pn_principal.Region = region;
            this.Invalidate();           
            restaurar.Visible = false;
            maximizar.Visible = true;

        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
    }
}
