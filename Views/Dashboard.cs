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
using Login.Views.Acesos;
using Login.Views.Bodega;
using Login.Views.Financiero;
using Login.Views.Usuarios;

using Login.Views;
namespace Login.Views
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            var roles = ConfiguracionProyecto.rol;
            var nombreusuairo = ConfiguracionProyecto.usuario;
            var diusaurios = ConfiguracionProyecto.IDusuario;
            /*

            if (roles == "Admin")
            {
                menu.Items.Add("Usuarios", default(Image), frm_Usuarios_click);
                menu.Items.Add("Bodega", default(Image), frm_Usuarios_click);
                menu.Items.Add("Financiero", default(Image), frm_Usuarios_click);
                menu.Items.Add("Accesos", default(Image), frm_Usuarios_click);
            }
           
            else if (roles == "Guardia")
            {
                menu.Items.Add("Accesos", default(Image), frm_Usuarios_click);
                menu.Items.Add("Usuarios", default(Image), frm_Usuariosmodificar_click);
            }
            else if (roles == "Financiero")
            {
                menu.Items.Add("Financiero", default(Image), frm_Usuarios_click);

            }
            else if (roles == "Bodega")
            {
                menu.Items.Add("Bodega", default(Image), frm_Usuarios_click);

            }
            else
            {
                menu.Items.Add("Salir", default(Image), frm_Usuarios_click);
            }*/

        }
        private void frm_Usuarios_click(object sender, EventArgs e)
        {
            var roles = ConfiguracionProyecto.rol;

           /* frm_Usuarios _Usuarios = new frm_Usuarios();
            _Usuarios.ShowDialog();
            /*if (roles == "Admin")
            {
                Dashboard _dashboard = new Dashboard();
                this.Hide();
                _dashboard.Show();
            }
            else if (roles == "Guardia")
            {
                var _accesos = new frm_Accesos_Principal();
                _accesos.Show();
            }
            else if (roles == "Financiero")
            {
                //financiero
                var _fiananciero = new frm_Financiero_Principal();
                _fiananciero.Show();
            }
            else if (roles == "Bodega")
            {
                var _bodega = new frm_Bodega_Principal();
                _bodega.Show();
            }
            else
            {
                //lbl_mensaje.Text = "Usted no posee el nivel de acceso necesario";
            }*/
        }


        private void frm_Usuariosmodificar_click(object sender, EventArgs e)
        {

            var modificarcontrasenia = new frm_Usuarios_Contrsenia();
            modificarcontrasenia.Show();

        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Bodega_Principal _frm_Bodega_Principal = new frm_Bodega_Principal();
            _frm_Bodega_Principal.ShowDialog();
        }
    }
}
