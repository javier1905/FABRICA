using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Windows.Forms;
namespace CapaLogica
{    
    public class Area
    {
        ConexionDB conectorArea = new ConexionDB();
        private int id_area;
        private string nombre_area;
        private const string consultaAreaActivos = "select id,descripcion from AREA where estado=1";
        public Area() {}     //----CONSTRUCTOR   
        public void InsertarArea() //----INSERTAR AREA
        {
            try {conectorArea.EjecutaConsulta(String.Format("exec pa_insertarArea '{0}'", nombre_area));}
            catch (Exception ex) { }          
        }
        public string ModificaArea() //----MODIFICAR AREA
        {
            try {              
                conectorArea.CargarTabla(String.Format("declare @msj varchar(30) exec pa_modificaArea " +
                    "@id={0},@descripcion='{1}',@mensaje=@msj output select @msj", id_area, nombre_area));
                return conectorArea.PmiTabla.Rows[0][conectorArea.PmiTabla.Columns[0]].ToString();                
                }
            catch (Exception ex) {return ex.Message;}
        }
        public string EliminaArea() //----ELIMINAR AREA
        {
            try {                
                conectorArea.CargarTabla(String.Format("declare @msj varchar(50) " +
                                "exec pa_eliminarArea @id={0},@mensaje=@msj output select @msj", this.Pid_area));                
                return conectorArea.PmiTabla.Rows[0][conectorArea.PmiTabla.Columns[0]].ToString();
                }
            catch(Exception ex) {return ex.Message;}            
        }
        public string ToStringAreas()
        {
            return id_area + " - " + nombre_area;
        }
        public int Pid_area { get => id_area; set => id_area = value; }
        public string Pnombre_area { get => nombre_area; set => nombre_area = value; }

        public static string ConsultaAreaActivos => consultaAreaActivos;
    }
}
