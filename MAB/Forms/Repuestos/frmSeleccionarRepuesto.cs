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

namespace MAB.Forms.Repuestos
{
    public partial class frmSeleccionarRepuesto : Form
    {
        public frmSeleccionarRepuesto()
        {
            InitializeComponent();

            cargarRepuestos();

            ucBottom.Accion1 = "Seleccionar";
            ucBottom.Accion2 = "Buscar";
            ucBottom.Accion3 = "Nuevo";

            ucBottom.evAccion1 += seleccionarReparacion;
            ucBottom.evAccion2 += buscarReparacion;
            ucBottom.evAccion3 += agregarNuevo;
        }

        private int idRepuesto = -1;

        public int repuestoSeleccionado
        {
            get { return idRepuesto; }
        }

        private void cargarRepuestos()
        {
            using (MABEntities db = new MABEntities())
            {
                var repuestos = db.Repuestos.ToList();

                ucDGVTabla.dataSource(repuestos);
            }

            Text = "Seleccione un Repuesto";

            ucDGVTabla.Columns["Id"].Visible = false;
            ucDGVTabla.Columns["Reparaciones"].Visible = false;
        }

        #region eventos de ucBottom

        private void seleccionarReparacion(object sender, EventArgs e)
        {
            if (ucDGVTabla.selectedRow() != null)
            {
                int idRepuesto = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using (MABEntities db = new MABEntities())
                {
                    Models.Repuestos repuesto = db.Repuestos.Find(idRepuesto);
                    
                    this.idRepuesto = repuesto.Id;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Repuesto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarReparacion(object sender, EventArgs e)
        {
            frmBuscarRepuesto frm = new frmBuscarRepuesto();
            frm.ShowDialog();

            if (frm.getRepuestos.Count != 0)
            {
                using (MABEntities db = new MABEntities())
                {
                    List<Models.Repuestos> repuestos= new List<Models.Repuestos>();

                    foreach (int id in frm.getRepuestos)
                    {
                        var repuesto = db.Repuestos.Find(id);

                        if (!repuestos.Contains(repuesto))
                        {
                            repuestos.Add(repuesto);
                        }
                    }

                    ucDGVTabla.dataSource(repuestos);
                }
            }
        }

        private void agregarNuevo(object sender, EventArgs e)
        {
            frmAgregarRepuesto frm = new frmAgregarRepuesto();
            frm.ShowDialog();

            cargarRepuestos();
        }

        #endregion
    }
}
