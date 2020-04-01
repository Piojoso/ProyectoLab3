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
    public partial class frmAgregarCliente : Form
    {
        private Models.Clientes cliente;

        public frmAgregarCliente()
        {
            InitializeComponent();
            
            ucTop.Titulo = "Agregar Nuevo Cliente";

            ucBottom.NumButtons = 2;

            ucBottom.Accion1 = "Crear";
            ucBottom.Accion3 = "Cancelar";

            ucBottom.evAccion1 += crearCliente;
            ucBottom.evAccion3 += cancelarCreacion;
        }

        private void crearCliente(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea agregarle un telefono a este cliente?", "Agregar Telefonos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                /**
                 * Esta seccion sera la encargada de:
                 * 1. Guardar el Cliente                --- HECHO
                 * 2. Abrir el formulario de Telefono   --- HECHO
                 */

                guardarCliente();

                frmAgregarTelefono frm = new frmAgregarTelefono(cliente.Id);
                frm.ShowDialog();
            }
            else
            {
                guardarCliente();
            }
        }

        private void cancelarCreacion(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarCliente()
        {
            using (MABEntities db = new MABEntities())
            {
                /**
                 * Guarda incluso si no hay info, hay que arreglarlo.
                 */
                cliente = new Models.Clientes();

                cliente.nombre = cctbNombre.Text;
                cliente.apellido = cctbApellido.Text;
                cliente.direccion = cctbDireccion.Text;

                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }
    }
}
