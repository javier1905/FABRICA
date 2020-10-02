using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class Puesto
    {
        private int id_puesto;
        private string nombre_puesto;
        const  string consultaPuestoActivos = "select * from PUESTO where estado=1";
        private ConexionDB conectorPuesto = new ConexionDB();

        public Puesto()
        {

        }
        public string InsertarPuesto()
        {
            try {
                conectorPuesto.CargarDataSet(String.Format("declare @msj varchar(50) exec pa_insertarPuesto @descripcion='{0}'," +
                    " @mensaje=@msj output select @msj", nombre_puesto));
                return conectorPuesto.PmiDataSet.Tables[0].Rows[0][0].ToString();
                }
            catch(Exception ex) { return ex.Message; }
            
        }
        public string ModificaPuesto() //----MODIFICAR PUESTO
        {
            //try
            //{
                conectorPuesto.CargarTabla(String.Format("declare @msj varchar(30) exec pa_modificaPuesto " +
                    "@id={0},@descripcion='{1}',@mensaje=@msj output select @msj", id_puesto, nombre_puesto));
                return conectorPuesto.PmiTabla.Rows[0][conectorPuesto.PmiTabla.Columns[0]].ToString();
        //    }
        //    catch (Exception ex) { return ex.Message; }
        }
        public string EliminaPuesto() //----ELIMINAR PUESTO
        {
            try
            {
                conectorPuesto.CargarTabla(String.Format("declare @msj varchar(50) " +
                                "exec pa_eliminarPuesto @id={0},@mensaje=@msj output select @msj", this.id_puesto));
                return conectorPuesto.PmiTabla.Rows[0][conectorPuesto.PmiTabla.Columns[0]].ToString();
            }
            catch (Exception ex) { return ex.Message; }
        }

        public string ToStringPuesto()
        {
            return id_puesto + " - " + nombre_puesto;
        }


        public int Pid_puesto { get => id_puesto; set => id_puesto = value; }
        public string Pnombre_puesto { get => nombre_puesto; set => nombre_puesto = value; }

        public static string PconsultaPuestoActivos => consultaPuestoActivos;
    }
}

