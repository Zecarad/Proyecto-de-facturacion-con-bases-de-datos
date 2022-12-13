using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace datos
{
    public class cls_conex
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand ObjConex = new SqlCommand();
        SqlDataAdapter adaptador;
        DataTable TblUsuarios;


        public DataTable GetDireccion(int IdDireccion)
        {
            try
            {
                conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=Exam_Final;Integrated Security=True");
                adaptador = new SqlDataAdapter("select * from Direcciones WHERE ID_Direccion= '" + IdDireccion + "'", conexion);
                TblUsuarios = new DataTable();
                conexion.Open();
                adaptador.Fill(TblUsuarios);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }
            return TblUsuarios;
        }


        public void IngDireccion(int IdDireccion, string tipo_direccion, string linea1, int apartado_postal, float monto, int id_provincia, int id_pais, int id_cliente)
        {
            try
            {
                conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=Exam_Final;Integrated Security=True");

                SqlParameter p_direccion = new SqlParameter("@ID_Direccion", SqlDbType.Int);
                p_direccion.Value = IdDireccion;

                SqlParameter p_tipo = new SqlParameter("@Tipo_Direccion", SqlDbType.VarChar);
                p_tipo.Value = tipo_direccion;

                SqlParameter p_linea = new SqlParameter("@Linea1", SqlDbType.VarChar);
                p_linea.Value = linea1;

                SqlParameter p_apartado = new SqlParameter("@Apartado_Postal", SqlDbType.Int);
                p_apartado.Value = apartado_postal;

                SqlParameter p_monto = new SqlParameter("@Monto", SqlDbType.Float);
                p_monto.Value = monto;

                SqlParameter p_provincia = new SqlParameter("@ID_Provincia", SqlDbType.Int);
                p_provincia.Value = id_provincia;

                SqlParameter p_pais = new SqlParameter("@ID_Pais", SqlDbType.Int);
                p_pais.Value = id_pais;

                SqlParameter p_cliente = new SqlParameter("@ID_Cliente", SqlDbType.Int);
                p_cliente.Value = id_cliente;

                ObjConex.Parameters.Add(p_direccion);
                ObjConex.Parameters.Add(p_tipo);
                ObjConex.Parameters.Add(p_linea);
                ObjConex.Parameters.Add(p_apartado);
                ObjConex.Parameters.Add(p_monto);
                ObjConex.Parameters.Add(p_provincia);
                ObjConex.Parameters.Add(p_pais);
                ObjConex.Parameters.Add(p_cliente);
                


                ObjConex.CommandType = CommandType.StoredProcedure;
                ObjConex.CommandText = "SP_Insertar";
                conexion.Open();
                ObjConex.Connection = conexion;

                ObjConex.ExecuteNonQuery();
                conexion.Close();
                ObjConex.Parameters.Clear();


            }
            catch (System.IO.IOException ex)
            {
                throw ex;
            }
            finally
            {

            }




        }
    }
}
