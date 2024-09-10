using Login.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    class stockModel
    {
        //idProveedor, idProducto, idusuario, cantidad, unidadmedidad
        public  int idStock { get; set; }
        public int idProveedor { get; set; }
        public int idProducto { get; set; }
        public int idusuario { get; set; }
        public int cantidad { get; set; }
        public string unidadmedidad { get; set; }


        public stockModel inserat(stockModel stock)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO stock (idProveedor,idProducto,idusuario,cantidad,unidadmedidad) " +
" VALUES(@idProveedor, @idProducto, @idusuario, @cantidad, @unidadmedidad)";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idProveedor", stock.idProveedor);
                        comando.Parameters.AddWithValue("@idProducto", stock.idProducto);
                        comando.Parameters.AddWithValue("@idusuario", stock.idusuario);
                        comando.Parameters.AddWithValue("@cantidad", stock.cantidad);
                        comando.Parameters.AddWithValue("@unidadmedidad", stock.unidadmedidad);

                        comando.ExecuteNonQuery();
                        return ultimoid();
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el usuario.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el usuario.");
            }
            return null;
        }

        public stockModel ultimoid()
        {        
               try
                {
                    using (var conexion = Conexion.GetConnection())
                    {
                        var consulta = "select top 1 * from stock order by idstock desc ";
                        using (var comando = new SqlCommand(consulta, conexion))
                        {
                            using (var lector = comando.ExecuteReader())
                            {
                                while (lector.Read())
                                {
                                return new stockModel
                                {
                                    idStock = Convert.ToInt32(lector["idStock"]),
                                    idProducto = Convert.ToInt32(lector["idProducto"]),
                                    idProveedor = Convert.ToInt32(lector["idProveedor"]),
                                    idusuario = Convert.ToInt32(lector["idusuario"]),
                                    cantidad = Convert.ToInt32(lector["cantidad"].ToString()),
                                    unidadmedidad = lector["unidadmedidad"].ToString()
                                };
                            }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de usuarios. SQL");
                }
                catch (Exception ex)
                {
                    ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de usuarios.");
                }
            return null;
                
            
        }


    }
}
