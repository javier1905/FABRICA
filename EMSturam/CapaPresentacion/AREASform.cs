using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using CapaLogica;
using CapaDatos;
namespace CapaPresentacion
{
    public partial class AREASform : Form
    {
        private bool insertar = false;
        List<Area> vecArea = new List<Area>();
        Area nuevaArea = new Area();
        ConexionDB conectorA = new ConexionDB();
        public AREASform()
        {
            InitializeComponent();
            txt_nombreArea.CargaCordenadasLinea(lin_nArea);
            lbx_areas.Focus();
        }
       private void CargarLista(ListBox lista)
        {            
            conectorA.CargarLector(Area.ConsultaAreaActivos);
            vecArea.RemoveRange(0, vecArea.Count);
            while(conectorA.PmiLector.Read())
            {
               if(!conectorA.PmiLector.IsDBNull(0) && !conectorA.PmiLector.IsDBNull(1))
                {
                    vecArea.Add(new Area {Pid_area=conectorA.PmiLector.GetInt32(0),Pnombre_area=conectorA.PmiLector.GetString(1)});
                }
            }
            conectorA.Desconectar();
            conectorA.PmiLector.Close();
            lista.Items.Clear();
            for(int i=0;i<vecArea.Count;i++) { lbx_areas.Items.Add(vecArea[i].ToStringAreas()); }
            if (lbx_areas.Items.Count != 0) { lbx_areas.SelectedIndex = 0; }
        }
        private void RellenaCampos(int index)
        {
            lbl_idArea.Text = vecArea[index].Pid_area.ToString();
            txt_nombreArea.Text = vecArea[index].Pnombre_area;
        }
        private void HablilitarElementos(int area,int insertar,int modificar, int eliminar, int aceptar, int cancelar, int lista,int cerrar)
        {
            if (area == 1) { txt_nombreArea.Enabled = true; } else { txt_nombreArea.Enabled = false; }
            if (insertar == 1) { btn_insertar.Enabled = true; } else { btn_insertar.Enabled = false; }
            if (modificar == 1) { btn_modificar.Enabled = true; } else { btn_modificar.Enabled = false; }
            if (eliminar == 1) { btn_eliminar.Enabled = true; } else { btn_eliminar.Enabled = false; }
            if (aceptar == 1) { btn_aceptar.Enabled = true; } else { btn_aceptar.Enabled = false; }
            if (cancelar == 1) { btn_cancelar.Enabled = true; } else { btn_cancelar.Enabled = false; }
            if (lista == 1) { lbx_areas.Enabled = true; } else { lbx_areas.Enabled = false; }
            if (cerrar == 1) { btn_cerrar.Enabled = true; } else { btn_cerrar.Enabled = false; }
        }

        private void AREASform_Load(object sender, EventArgs e)
        {
            CargarLista(lbx_areas);
            HablilitarElementos(0, 1, 1, 1, 0, 0, 1, 1);
        }

        private void lbx_areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenaCampos(lbx_areas.SelectedIndex);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            HablilitarElementos(1, 0, 0, 0, 0, 1, 0, 1);
            txt_nombreArea.Text = "";
            txt_nombreArea.Focus();
            insertar = true;
            //lbl_idArea.Text = (vecArea[vecArea.Count-1].Pid_area + 1).ToString();
            lbl_idArea.Text = "x";
        }

        private void txt_nombreArea_TextChanged(object sender, EventArgs e)
        {
            if(btn_insertar.Enabled==false && btn_modificar.Enabled==false)
            {
                if (txt_nombreArea.Text == "") { btn_aceptar.Enabled = false; } else { btn_aceptar.Enabled = true; }
            }            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            nuevaArea.Pid_area = vecArea[lbx_areas.SelectedIndex].Pid_area;
            nuevaArea.Pnombre_area = txt_nombreArea.Text;            
            if(insertar)
            {
                jMessajeBoxSiNo msj = new jMessajeBoxSiNo("Advertencia", "Esta seguro de insertar una nueva Area");
                if (msj.ShowDialog() == DialogResult.Yes) { nuevaArea.InsertarArea(); }                                
            }
            else
            {
                jMessajeBoxSiNo msj = new jMessajeBoxSiNo("Advertencia", "Esta seguro de modificar el nombre del area");
                if (msj.ShowDialog() == DialogResult.Yes) { nuevaArea.ModificaArea(); }                
            }
            CargarLista(lbx_areas);
            HablilitarElementos(0, 1, 1, 1, 0, 0, 1, 1);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            insertar = false;
            HablilitarElementos(1, 0, 0, 0, 0, 1, 0, 0);
            txt_nombreArea.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {            
            HablilitarElementos(0, 1, 1, 1, 0, 0, 1, 1);
            CargarLista(lbx_areas);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            nuevaArea.Pid_area = vecArea[lbx_areas.SelectedIndex].Pid_area;
            jMessajeBoxSiNo msj = new jMessajeBoxSiNo("Advertencia", "Esta seguro de eliminar el nombre del area");
            if (msj.ShowDialog() == DialogResult.Yes)
            {
               string men= nuevaArea.EliminaArea();
                jMessajeBoxAceptar mostrar = new jMessajeBoxAceptar("Aviso", men);
                mostrar.ShowDialog();

                CargarLista(lbx_areas);
            }
        }
    }
}
