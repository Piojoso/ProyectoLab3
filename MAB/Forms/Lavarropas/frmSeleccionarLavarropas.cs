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
using MAB.Forms.Clientes;

namespace MAB.Forms.Lavarropas
{
    public partial class frmSeleccionarLavarropas : Form
    {
        public frmSeleccionarLavarropas()
        {
            InitializeComponent();

            cargarLavarropas();

            ucBottom.Accion1 = "Seleccionar";
            ucBottom.Accion2 = "Buscar";
            ucBottom.Accion3 = "Nuevo";

            ucBottom.evAccion1 += seleccionarLavarropas;
            ucBottom.evAccion2 += buscarLavarropas;
            ucBottom.evAccion3 += agregarNuevo;
        }

        private int idLavarropas = -1;

        public int lavarropasSeleccionado
        {
            get { return idLavarropas; }
        }

        private void cargarLavarropas()
        {
            using (MABEntities db = new MABEntities())
            {
                var lavarropas = db.Lavarropas;

                ucDGVTabla.dataSource(lavarropas.ToList());
            }

            Text = "Seleccione un Lavarropas";

            ucDGVTabla.Columns["Id"].Visible = false;
            ucDGVTabla.Columns["ClienteId"].Visible = false;
            ucDGVTabla.Columns["Cliente"].Visible = false;
            ucDGVTabla.Columns["Reparacion"].Visible = false;
        }

        #region Eventos de los botones

        private void seleccionarLavarropas(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idLavarropas = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using (MABEntities db = new MABEntities())
                {
                    Models.Lavarropas lavarropas = db.Lavarropas.Find(idLavarropas);

                    DialogResult resp = MessageBox.Show(
                        "A seleccionado el lavarropas: \n" +
                        lavarropas.marca + " " + lavarropas.modelo + "\n" +
                        "del cliente: \n" +
                        lavarropas.Cliente.nombre + " " + lavarropas.Cliente.apellido + "\n" +
                        "¿Desea continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if(resp == DialogResult.Yes)
                    {
                        this.idLavarropas = lavarropas.Id;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay una fila seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarLavarropas(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "Existe 2 Maneras de buscar lavarropas. \n" +
                "1) Ver todos los lavarropas de un cliente en particular \n" +
                "2) Buscar un lavarropas dado su marca y modelo \n" +
                "¿Desea ver todos los lavarropas de un cliente en particular? (Opcion 1) \n" +
                "Al seleccionar \"NO\" la busqueda se realizara por el segundo metodo. (Opcion 2)",
                "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                frmSeleccionarCliente frm = new frmSeleccionarCliente();
                frm.ShowDialog();

                int idCliente = frm.ClienteSeleccionado;

                if (idCliente != -1)
                {
                    using (MABEntities db = new MABEntities())
                    {
                        var lavarropas = from lav in db.Lavarropas
                                         where lav.ClienteId == idCliente
                                         select lav;

                        ucDGVTabla.dataSource(lavarropas.ToList());
                    }
                }
            }
            else
            {
                frmBuscarLavarropas frm = new frmBuscarLavarropas();
                frm.ShowDialog();

                if (frm.getResultados.Count != 0)
                {
                    using (MABEntities db = new MABEntities())
                    {
                        List<Models.Lavarropas> lavarropas = new List<Models.Lavarropas>();

                        foreach (int id in frm.getResultados)
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
        }

        private void agregarNuevo(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Se necesita un cliente para poder agregarle un Lavarropas al mismo. \n" +
                "Es por este motivo que a continuacion se abrira una ventana para que pueda seleccionar uno.",
                "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();
            frmSeleccionarCliente.ShowDialog();

            int idCliente = frmSeleccionarCliente.ClienteSeleccionado;

            if (idCliente != -1)
            {
                frmAgregarLavarropas frm = new frmAgregarLavarropas(idCliente);
                frm.ShowDialog();
            }

            cargarLavarropas();
        }

        #endregion
    }
}
