using System;
using System.Collections.Generic;
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


        public stockModel insertar(stockModel _stockModel) {

            var stock = new stockModel();
            return stock;
        
        }


    }
}
