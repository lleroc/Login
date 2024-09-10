using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Models;
namespace Login.Controllers
{
    class ProductosController
    {
        ProductosModel _productosModel = new ProductosModel();
        public List<ProductosModel> todos() {

            return _productosModel.todos();
        }
        public ProductosModel insertar(ProductosModel productosModel) {

            return _productosModel.inserat(productosModel);
        
        }
    }
}
