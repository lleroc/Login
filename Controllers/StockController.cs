using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Controllers
{
    class StockController
    {
        stockModel _stockModel = new stockModel();

        public stockModel insertar(stockModel stock) {
            return _stockModel.insertar(stock);
        }
       
    }
}
