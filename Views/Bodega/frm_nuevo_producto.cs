using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Models;
using Login.Controllers;
using Login.config;
namespace Login.Views.Bodega
{
    public partial class frm_nuevo_producto : Form
    {

        ProductosController _productosController = new ProductosController();
        ProveedoresController _proveedoresController = new ProveedoresController();
        StockController _stockController = new StockController();
        


        public frm_nuevo_producto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            1 validar campos
            2 insertar producto
            3 insertar el stock
             */
            if (txtcantidad.Text == "" || txtcodigobarras.Text == "" || txtNombre.Text == "" ||
                cmbproveedor.SelectedIndex == -1 || cmbunidadmedida.SelectedIndex == -1) {
                ErrorHandler.ManejarErrorGeneral(null, "Complete todos los campos, por favor");
                return;           
            }

            var producto = new ProductosModel
            {
                Codigo_Barras = txtcodigobarras.Text.Trim(),
                Nombre = txtNombre.Text.Trim()
            };

            var validaproducto = _productosController.insertar(producto);

            if(validaproducto.IdProducto == 0)
            {
                ErrorHandler.ManejarErrorGeneral(null, "Ocurrio un error al guardar, consulte m,as tarde, ojala pueda");
                return;
            }

            //controlador devuelve el producto insertado
            var stock = new stockModel
            {
                cantidad = Convert.ToInt32(txtcantidad.Text.Trim()),
                idProducto = validaproducto.IdProducto,
                idProveedor = Convert.ToInt32(cmbproveedor.SelectedValue),
                idusuario = ConfiguracionProyecto.IDusuario,
                unidadmedidad = cmbunidadmedida.SelectedItem.ToString()
            };
            var respuestaStock = _stockController.insertar(stock);
            if (respuestaStock.idStock == 0) {
                ErrorHandler.ManejarErrorGeneral(null, "Ocurrio un error al guardar, consulte m,as tarde, ojala pueda");
                return;

            }
            ErrorHandler.ManejarInsertar();
            this.Close();
        }

        private void frm_nuevo_producto_Load(object sender, EventArgs e)
        {
            var proveedores = _proveedoresController.todos();
            cmbproveedor.DataSource = null;
            cmbproveedor.DataSource = proveedores;
            cmbproveedor.DisplayMember = "NombreEmpresa";
            cmbproveedor.ValueMember = "IdProveedor";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
