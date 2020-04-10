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

                    if(db.Lavarropas.ToList().LastOrDefault() != null)
                    {
                        int ultimoId = db.Lavarropas.ToList().LastOrDefault().Id;

                        var shortList = from lavarropas in db.Lavarropas
                                        where lavarropas.Id >= (ultimoId - 10)
                                        select lavarropas;

                        ucDGVTabla.ShortListData = shortList.ToList();
                    }

                    var fullList = db.Lavarropas.ToList();

                    ucDGVTabla.FullListData = fullList.ToList();

                    Text = "Lavarropas";
                }
            }
        }

        #region Eventos de Botones

        private void btnAdd(object sender, EventArgs e)
        {
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
            if(ucDGVTabla.selectedRow() != null)
            {
                int idLavarropas = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmModificarLavarropas frm = new frmModificarLavarropas(idLavarropas);
                frm.ShowDialog();

                if(cliente != null)
                {
                    cargarLavarropas(cliente.Id);
                }
                else
                {
                    cargarLavarropas(null);
                }
            }
        }

        private void btnSearch(object sender, EventArgs e)
        {
            /**
             * TODO: Abrir Formulario frmBuscarLavarropas para realizar la busqueda y luego enseñarlos en el ucDGVTabla.
             * --- HECHO
             */

            frmBuscarLavarropas frm = new frmBuscarLavarropas();
            frm.ShowDialog();

            if(frm.getResultados.Count != 0)
            {
                using (MABEntities db = new MABEntities())
                {
                    List<Models.Lavarropas> lavarropas = new List<Models.Lavarropas>();

                    foreach(int id in frm.getResultados)
                    {
                        lavarropas.Add(db.Lavarropas.Find(id));
                    }

                    ucDGVTabla.dataSource(lavarropas);
                }
            }
            else
            {
                MessageBox.Show("La busqueda fue cancelada o no se encontraron resultados", 
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
