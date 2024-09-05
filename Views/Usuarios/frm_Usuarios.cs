using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Login.Controllers;
using Login.Models;
using Login.Config;
using Login.config;

namespace Login.Views.Usuarios
{
    public partial class frm_Usuarios : Form
    {
        SerialPort _arduino;

        UsuariosController _usuariosController = new UsuariosController();
        UsuariosModel usuariosModel = new UsuariosModel();
        int id = 0;

        public frm_Usuarios()
        {
            InitializeComponent();
            /* _arduino = new SerialPort();
             _arduino.PortName = "COM4";
             _arduino.BaudRate = 9600;
             _arduino.Open();*/


        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            cargalista();
            cmb_roles.SelectedIndex = 0;

        }

        private void cargalista() {

            var listausuarios = _usuariosController.ObtenerTodosLosUsuarios();
            lst_usuarios.DataSource = null;
            lst_usuarios.DataSource = listausuarios;
            lst_usuarios.DisplayMember = "NombreUsuario";
            lst_usuarios.ValueMember = "ID";



        }

        private void frm_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_arduino.IsOpen) {
                _arduino.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_arduino.Write("E");

            // txt_nombre.Text = _arduino.Read().ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            _arduino.Write("F");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            if (comprobar())
            {
                var resultado = new UsuariosModel();
                var res = "";
                /*UsuariosModel usuario = new UsuariosModel();
                usuario.NombreUsuario = txt_nombre.Text.Trim();
                usuario.Password = txt_contrasenia.Text.Trim();
                usuario.Roles = cmb_roles.SelectedItem.ToString();*/

                var usuario = new UsuariosModel {
                ID = this.id,
                NombreUsuario = txt_nombre.Text.Trim().ToString(),
                Password = txt_contrasenia.Text.Trim().ToString(),
                Roles = cmb_roles.SelectedText
                };
                MessageBox.Show(cmb_roles.SelectedItem.ToString());
                if (this.id != 0)
                {
                    //resultado = _usuariosController.ActualizarUsuario(usuario);
                   res = UsuariosModel.Actualizar(usuario);
                }
                else {
                    resultado = _usuariosController.InsertarUsuario(usuario);
                    _ = resultado.ID > 0 ? res = "ok" : "eror";
                }
                if (res == "OK") {
                   MessageBox.Show("Se guardo con exito");
                    cargalista();
                    txt_contrasenia.Text = "";
                    txt_nombre.Text = "";
                    txt_repita.Text = "";
                    cmb_roles.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar, intentelo mas tarde");
                }

            }
        }

        public bool comprobar() {

            //txt_nombre.Text.Trim() == "" ? MessageBox.Show("Ingrese el nombres") : "" 
            if (txt_nombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario");
                return false;
            }
            else if (txt_contrasenia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la contrasenia");
                return false;
            }
            else if (txt_repita.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la contrasenia");
                return false;
            }
            else if (cmb_roles.SelectedIndex == -1 || cmb_roles.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccion un item de la lista de roles");
                return false;
            }
            else {
                return true;
            }

        }

        private void lst_usuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lst_usuarios.SelectedValue != null)
            {
                var usuario = _usuariosController.ObtenerUsuarioPorId((int)lst_usuarios.SelectedValue);
                this.id = (int)usuario.ID;
                txt_nombre.Text = usuario.NombreUsuario;
                txt_contrasenia.Text = usuario.Password;
                txt_repita.Text = usuario.Password;
                if (usuario.Roles == "Admin") cmb_roles.SelectedIndex = 1;
                if (usuario.Roles == "Guardia") cmb_roles.SelectedIndex = 2;
                if (usuario.Roles == "Financiero") cmb_roles.SelectedIndex = 3;
                if (usuario.Roles == "Bodega") cmb_roles.SelectedIndex = 4;
                

                
            }
            else {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un usuario de la lista");
            }
        }
    }
}
