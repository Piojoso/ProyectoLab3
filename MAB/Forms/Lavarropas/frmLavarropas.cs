using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Forms.Lavarropas;
using MAB.Forms.Clientes;
using MAB.Models;

namespace MAB.Forms.CRUD.Lavarropas
{
    public partial class frmLavarropas : Form
    {
        private Models.Clientes cliente;

        public frmLavarropas(int? idCliente = null)
        {
            InitializeComponent();

            cargarLavarropas(idCliente);

            ucDGVTabla.click_btnAdd += btnAdd;
            ucDGVTabla.click_btnModify += btnModify;
            ucDGVTabla.click_btnSearch += btnSearch;
        }

        private void cargarLavarropas(int? idCliente)
        {
            if(idCliente != null)
            {
                using (MABEntities db = new MABEntities())
                {
                    var lavarropas = from lav in db.Lavarropas
                                     where lav.ClienteId == idCliente
                                     select lav;

                    ucDGVTabla.dataSource(lavarropas.ToList());

                    cliente = db.Clientes.Find(idCliente);

                    Text = "Lavarropas de: " + cliente.nombre + " " + cliente.apellido;
                }
            }
            else
            {
                using (MABEntities db = new MABEntities())
                {
                    cliente = null;

                    int ultimoId = db.Lavarropas.LastOrDefault().Id;
                    var shortList = from lavarropas in db.Lavarropas
                                    where lavarropas.Id >= (ultimoId - 10)
                                    select lavarropas;

                    var fullList = db.Lavarropas;

                    ucDGVTabla.ShortListData = shortList;
                    ucDGVTabla.FullListData = fullList;

                    Text = "Lavarropas";
                }
            }
        }

        #region Eventos de Botones

        private void btnAdd(object sender, EventArgs e)
        {
            /**
             * TODO: estoy pensando en que quizas lo que aca podria hacer para que todo funcione, es abrir una pequeña ventana nueva
             * donde tenga listados todos los clientes, y 3 botones, uno seleccionar, otro buscar, y otro cerrar. el seleccionar retornara
             * el id del seleccionado, mientras que buscar abrira el frmBuscarCliente y el cerrar, claramente cerrara la ventana. Esto solo
             * si no hay un cliente ya en este form.
             * --- HECHO
             */

            if(cliente != null)
            {
                frmAgregarLavarropas frm = new frmAgregarLavarropas(cliente.Id);
                frm.ShowDialog();

                cargarLavarropas(cliente.Id);
            }
            else
            {
                MessageBox.Show(
                    "Se necesita un cliente para poder agregarle un Lavarropas al mismo. \n" +
                    "Es por este motivo que a continuacion se abrira una ventana para que pueda seleccionar uno.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();
                frmSeleccionarCliente.ShowDialog();

                int idCliente = frmSeleccionarCliente.ClienteSeleccionado;

                if(idCliente != -1)
                {
                    frmAgregarLavarropas frm = new frmAgregarLavarropas(idCliente);
                    frm.ShowDialog();
                }

                cargarLavarropas(null);
            }
        }

        private void btnModify(object sender, EventArgs e)
        {

        }

        private void btnSearch(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
