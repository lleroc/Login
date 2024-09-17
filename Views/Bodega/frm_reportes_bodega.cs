using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Controllers;
namespace Login.Views.Bodega
{
    public partial class frm_reportes_bodega : Form
    {
        ProductosController _productos = new ProductosController();
        public frm_reportes_bodega()
        {
            InitializeComponent();
        }

        private void frm_reportes_bodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProductos.DsTodos' Puede moverla o quitarla según sea necesario.
            // this.dsTodosTableAdapter.Fill(this.dsProductos.DsTodos);

            lstFiltro.DataSource = _productos.todos();
            lstFiltro.DisplayMember = "Nombre";
            lstFiltro.ValueMember = "IdProducto";
            
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstFiltro.SelectedIndex == -1)
            {

                MessageBox.Show("Selecciones un item de la lista");
                return;
            }
            else { 
            this.dSUnoTableAdapter.Fill(this.dsProductos.DSUno, Convert.ToInt16(lstFiltro.SelectedValue));
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
