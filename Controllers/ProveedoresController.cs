using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Models;
namespace Login.Controllers
{
    class ProveedoresController
    {
        ProveedoresModel _proveedoreModel = new ProveedoresModel();

        public List<ProveedoresModel> todos()
        {
            return _proveedoreModel.todos();
        }
    }
}
