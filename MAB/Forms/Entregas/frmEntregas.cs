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

namespace MAB.Forms.Entregas
{
    public partial class frmEntregas : Form
    {
        public frmEntregas(int? idReparacion = null, int? idCliente = null)
        {
            InitializeComponent();

            cargarEntregas(idReparacion, idCliente);

            ucDGVTabla.Columns["ClientesId"].Visible = false;
            ucDGVTabla.Columns["ReparacionesId"].Visible = false;
            ucDGVTabla.Columns["Clientes"].Visible = false;
            ucDGVTabla.Columns["Reparaciones"].Visible = false;

            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion2 = "Modificar";
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += agregarEntrega;
            ucBottom.evAccion2 += modificarEntrega;
            ucBottom.evAccion3 += cerrarVentana;
        }

        Models.Clientes cliente;
        Models.Reparaciones reparacion;

        List<Models.Entregas> entregas;

        private void cargarEntregas(int? idReparacion, int? idCliente)
        {
            if(idReparacion != null && idCliente == null)
            {
                using (MABEntities db = new MABEntities())
                {
                    reparacion = db.Reparaciones.Find(idReparacion);

                    entregas = reparacion.Entregas.ToList();
                }

                Text = "Entregas de la reparacion: " + reparacion.Id;

                ucDGVTabla.dataSource(entregas);
            }
            else if(idReparacion == null && idCliente != null)
            {
                using(MABEntities db = new MABEntities())
                {
                    cliente = db.Clientes.Find(idCliente);

                    entregas = cliente.Entregas.ToList();
                }

                Text = "Entregas del cliente: " + cliente.nombre + " " + cliente.apellido;

                ucDGVTabla.dataSource(entregas);
            }
        }

        #region eventos de ucBottom

        private void agregarEntrega(object sender, EventArgs e)
        {
            if(cliente != null)
            {
                MessageBox.Show(
                    "Se requiere seleccionar una reparacion a la cual agregarle la nueva entrega. \n" +
                    "Por este motivo a continuacion se abrira una ventana para que pueda seleccionar una reparacion.");

                /**
                 * TODO: abrir el formulario de seleccionarReparacion. Aun no creado.
                 * En el cual se podra buscar la reparacion deseada y seleccionarla.
                 * TODO: Luego hay que obtener la reparacion seleccionada
                 * TODO: y con la info anterior abrir el formulario de agregarEntrega. Aun no creado.
                 * En el cual se realizara la pedida de info necesario, para poder agregar una nueva entrega.
                 * TODO: finalmente hay que volver a cargar la lista de entregas. con la funcion cargarEntregas(cliente.Id);
                 */
            }
            else
            {
                /**
                 * Dado que si tenemos una reparacion podemos obtener el cliente al cual pertenese el lavarropas de la reparacion
                 * podemos facilmente suponer cual es el cliente que esta haciendo la entrega (o en nombre de quien se esta realizando)
                 * 
                 * TODO: abrir formulario de agregarEntrega. con el cliente que realizara la misma y la reparacion.
                 */
            }
        }

        private void modificarEntrega(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idEntrega = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using (MABEntities db = new MABEntities())
                {
                    Models.Entregas entrega = db.Entregas.Find(idEntrega);

                    /**
                     * TODO: abrir formulario de modificarEntrega. Aun no creado.
                     */
                }
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
