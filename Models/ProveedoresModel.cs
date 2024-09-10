using Login.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    class ProveedoresModel
    {
        public int IdProveedor { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion{ get; set; }
        public string Telefono { get; set; }


        public List<ProveedoresModel> todos()
        {
            var proveedores = new List<ProveedoresModel>();
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM productos";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                proveedores.Add(new ProveedoresModel
                                {
                                    IdProveedor = Convert.ToInt32(lector["IdProveedor"].ToString()),
                                    NombreEmpresa = lector["NombreEmpresa"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    Telefono   = lector["Direccion"].ToString(),
                                });
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
            return proveedores;

        }


        public 
    }
}
