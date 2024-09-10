using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Views.Bodega
{
    public partial class frm_Bodega_Principal : Form
    {
        public frm_Bodega_Principal()
        {
            InitializeComponent();
        }

        private void frm_Bodega_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_nuevo_producto _frm_Nuevo_Producto = new frm_nuevo_producto();
            _frm_Nuevo_Producto.ShowDialog();
        }
    }
}
