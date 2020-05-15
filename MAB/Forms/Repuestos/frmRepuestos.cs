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
    public partial class frmRepuestos : Form
    {
        public frmRepuestos(int? idReparacion = null)
        {
            InitializeComponent();

            cargarDGV(idReparacion);

            ucDGVTabla.click_btnAdd += btnAgregar;
            ucDGVTabla.click_btnModify += btnModificar;
            ucDGVTabla.click_btnSearch += btnBuscar;
        }

        private Models.Reparaciones reparacion = null;

        private void cargarDGV(int? idReparacion)
        {
            if(idReparacion != null)
            {
                using (MABEntities db = new MABEntities())
                {
                    reparacion = db.Reparaciones.Find(idReparacion);

                    List<Models.Repuestos> repuestos = new List<Models.Repuestos>();

                    foreach(ReparacionesRepuestos r in reparacion.Repuestos)
                    {
                        repuestos.Add(db.Repuestos.Find(r.RepuestosId));
                    }

                    var data = from r in repuestos
                                    select new { r.Id, r.nombre, r.descripcion, stock = r.Stock.Disponibilidad, precio = r.Stock.Precio };

                    ucDGVTabla.dataSource(data.ToList());
                }
            }
            else
            {
                using (MABEntities db = new MABEntities())
                {
                    var repuestos = db.Repuestos;

                    var data = from r in repuestos
                                select new { r.Id, r.nombre, r.descripcion, stock = r.Stock.Disponibilidad, precio = r.Stock.Precio };

                    ucDGVTabla.FullListData = data.ToList();
                }
            }
        }

        #region eventos de botones

        private void btnAgregar(object sender, EventArgs e)
        {
            frmAgregarRepuesto frm = new frmAgregarRepuesto();
            frm.ShowDialog();

            if(reparacion != null)
                cargarDGV(reparacion.Id);
            else
                cargarDGV(null);
        }

        private void btnModificar(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idRepuesto = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmModificarRepuesto frm = new frmModificarRepuesto(idRepuesto);
                frm.ShowDialog();

                if (reparacion != null)
                {
                    cargarDGV(reparacion.Id);
                }
                else
                {
                    cargarDGV(null);
                }
            }
        }

        private void btnBuscar(object sender, EventArgs e)
        {
            frmBuscarRepuesto frm = new frmBuscarRepuesto();
            frm.ShowDialog();

            if (frm.getRepuestos.Count != 0)
            {
                using (MABEntities db = new MABEntities())
                {
                    List<Models.Reparaciones> reparaciones = new List<Models.Reparaciones>();

                    foreach (int id in frm.getRepuestos)
                    {
                        reparaciones.Add(db.Reparaciones.Find(id));
                    }

                    ucDGVTabla.dataSource(reparaciones);
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
