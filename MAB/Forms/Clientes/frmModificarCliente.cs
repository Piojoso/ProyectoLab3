using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Models;
using MAB.Forms.CRUD.Telefonos;

namespace MAB.Forms.CRUD.Clientes
{
    public partial class frmModificarCliente : Form
    {
        Models.Clientes cliente;

        public frmModificarCliente(int idCliente)
        {
            /**
             * TODO: Revisar el correcto funcionamiento
             */

            InitializeComponent();

            cargarCliente(idCliente);

            Text = "Modificar al Cliente: " + cliente.nombre + " " + cliente.apellido;

            ucBottom.Accion1 = "Guardar";
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += confirmarCambios;
            ucBottom.evAccion3 += cancelarModificacion;

            string messageError = "Solo se permiten Letras, no se permiten Numeros.";

            cctbNombre.CaracterIncorrectErrorMessage = messageError;
            cctbApellido.CaracterIncorrectErrorMessage = messageError;
            cctbDireccion.CaracterIncorrectErrorMessage = messageError;

            cargarDatos();
        }

        private void cargarCliente(int idCliente)
        {
            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(idCliente);
            }
        }

        private void cargarDatos()
        {
            cctbNombre.Text = cliente.nombre;
            cctbApellido.Text = cliente.apellido;
            cctbDireccion.Text = cliente.direccion;
            refreshNumTelefonos();
        }

        private void confirmarCambios(object sender, EventArgs e)
        {
            if((cctbDireccion.Text != string.Empty) && (cctbApellido.Text != string.Empty) && (cctbDireccion.Text != string.Empty))
            {
                DialogResult resp = MessageBox.Show(
                    "¿Desea continuar con la modificacion? \n" +
                    "Nombre cambiara de: " + cliente.nombre + " a " + cctbNombre.Text + "\n" +
                    "Apellido cambiara de: " + cliente.apellido + " a " + cctbApellido.Text + "\n" +
                    "Direccion cambiara de: " + cliente.direccion + " a " + cctbDireccion.Text + "\n" +
                    "Tenga en cuenta que la informacion anterior se perdera", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    cliente.nombre = cctbNombre.Text;
                    cliente.apellido = cctbApellido.Text;
                    cliente.direccion = cctbDireccion.Text;

                    using (MABEntities db = new MABEntities())
                    {
                        db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        MessageBox.Show("Cliente modificado Correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarModificacion(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmTelefonos frm = new frmTelefonos(cliente.Id);
            frm.ShowDialog();

            refreshNumTelefonos();
        }

        private void refreshNumTelefonos()
        {
            using (MABEntities db = new MABEntities())
            {
                cclblNumTelefonos.Text = cliente.Telefonos.Count.ToString();
            }
        }
    }
}
