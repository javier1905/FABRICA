using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class PUESTOSform : Form
    {
        
        private bool insertar = false;
        private List<Puesto> vecPuesto = new List<Puesto>();
        private Puesto puestoCargar = new Puesto();
        private ConexionDB conectorPuesto = new ConexionDB();
        public PUESTOSform()
        {
            InitializeComponent();
        }
        
        private void HabilitarElementos(int puesto, int insertar, int modificar, int eliminar, int aceptar, int cancelar, int lista, int cerrar)
        {
            if (puesto == 1) { txt_puesto.Enabled = true; } else { txt_puesto.Enabled = false; }
            if (insertar == 1) { btn_insertar.Enabled = true; } else { btn_insertar.Enabled = false; }
            if (modificar == 1) { btn_modificar.Enabled = true; } else { btn_modificar.Enabled = false; }
            if (eliminar == 1) { btn_eliminar.Enabled = true; } else { btn_eliminar.Enabled = false; }
            if (aceptar == 1) { btn_aceptar.Enabled = true; } else { btn_aceptar.Enabled = false; }
            if (cancelar == 1) { btn_cancelar.Enabled = true; } else { btn_cancelar.Enabled = false; }
            if (lista == 1) { lbx_puesto.Enabled = true; } else { lbx_puesto.Enabled = false; }
            if (cerrar == 1) { btn_cerrar.Enabled = true; } else { btn_cerrar.Enabled = false; }
        }
        private void CargarLista(ListBox lista)
        {
            lista.Items.Clear();
            vecPuesto.RemoveRange(0, vecPuesto.Count);
            conectorPuesto.CargarLector(Puesto.PconsultaPuestoActivos);
            while(conectorPuesto.PmiLector.Read())
            {
                vecPuesto.Add(new Puesto {Pid_puesto = conectorPuesto.PmiLector.GetInt32(0), Pnombre_puesto = conectorPuesto.PmiLector.GetString(1)});
            }
            conectorPuesto.PmiLector.Close();
            conectorPuesto.Desconectar();
            for(int i=0;i<vecPuesto.Count;i++)
            {
                lista.Items.Add(vecPuesto[i].ToStringPuesto());
            }
            if(lista.Items.Count!=0)
            {
                lista.SelectedIndex = -1;   
            }
        }
        private void btn_insertar_Click(object sender, EventArgs e)
        {
            HabilitarElementos(1, 0, 0, 0, 0, 1, 0, 1);
            txt_puesto.Text = "";
            txt_puesto.Focus();
            insertar = true;
        }

        private void PUESTOSform_Load(object sender, EventArgs e)
        {
            HabilitarElementos(0, 1, 1, 1, 0, 0, 1, 1);
            CargarLista(lbx_puesto);
            lbx_puesto.SelectedIndex = -1;           
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            HabilitarElementos(1, 0, 0, 0, 0, 1, 0, 1);
            insertar = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            puestoCargar.Pid_puesto = vecPuesto[lbx_puesto.SelectedIndex].Pid_puesto;
            jMessajeBoxSiNo mens = new jMessajeBoxSiNo("Eliminar", "Esta seguro de elminar el elemento");
            if(mens.ShowDialog()==DialogResult.Yes)
            {
                puestoCargar.EliminaPuesto();
                HabilitarElementos(0, 1, 1, 1, 0, 0, 1, 1);
                CargarLista(lbx_puesto);
            }
        }

        private void txt_puesto_TextChanged(object sender, EventArgs e)
        {
            if(txt_puesto.Enabled==true)
            {
                if (txt_puesto.Text == "")
                {
                    btn_aceptar.Enabled = false;
                }
                else
                {
                    btn_aceptar.Enabled = true;
                }
            }           
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            puestoCargar.Pnombre_puesto = txt_puesto.Text;
            puestoCargar.Pid_puesto = vecPuesto[lbx_puesto.SelectedIndex].Pid_puesto;
            if (insertar)
            {
                jMessajeBoxSiNo miMensaje = new jMessajeBoxSiNo("Confirmacion", "Esta seguro de Insertar");
                if(miMensaje.ShowDialog()==DialogResult.Yes)
                {                    
                    string men = puestoCargar.InsertarPuesto();
                    jMessajeBoxAceptar confirmacion = new jMessajeBoxAceptar("Confirmacion", men);
                    confirmacion.ShowDialog();
                }
            }
            else
            {
                jMessajeBoxSiNo miMensaje = new jMessajeBoxSiNo("Confirmacion", "Esta seguro de Modificar");
                if(miMensaje.ShowDialog()==DialogResult.Yes)
                {
                    string mens = puestoCargar.ModificaPuesto();
                    jMessajeBoxAceptar confirmacion = new jMessajeBoxAceptar("Confirmacion", mens);
                    confirmacion.ShowDialog();
                }
            }
            insertar = false;
            HabilitarElementos(0, 1, 1, 1, 0, 0, 1, 1);
            CargarLista(lbx_puesto);
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            insertar = false;
            HabilitarElementos(0, 1, 1, 1, 0, 0, 1, 1);
            lbx_puesto.SelectedIndex = -1;
        }

        private void lbx_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selector(lbx_puesto.SelectedIndex);
        }
        public void Selector(int index)
        {
            txt_puesto.Text = vecPuesto[index].Pnombre_puesto;
            lbl_idPuesto.Text = vecPuesto[index].Pid_puesto.ToString();            
        }
    }
}
