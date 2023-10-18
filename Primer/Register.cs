using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{

    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string correo = this.txtMail.Text;
            string clave = this.txtContraseña.Text;
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;

            listaUsuarios = Archivos.DeserealizarUsuarios();

            Usuario usuario = new Usuario(clave, correo, nombre, apellido);
            listaUsuarios.Add(usuario);
            Archivos.SerealizarUsuarios(listaUsuarios);
            this.Close();

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese su nombre";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ingrese su nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "minombre@ejemplo.com")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.Black;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "minombre@ejemplo.com";
                txtMail.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese su usuario";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Ingrese su usuario")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingrese una contraseña";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese una contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
