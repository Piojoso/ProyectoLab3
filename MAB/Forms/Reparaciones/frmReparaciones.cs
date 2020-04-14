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
using MAB.Forms.Lavarropas;

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmReparaciones : Form
    {
        public frmReparaciones(int? idLavarropas = null)
        {
            /**
             * TODO: Revisar el correcto funcionamiento
             */

            InitializeComponent();
            
            cargarDGV(idLavarropas);

            ucDGVTabla.click_btnAdd += btnAgregar;
            ucDGVTabla.click_btnModify += btnModificar;
            ucDGVTabla.click_btnSearch += btnBuscar;
        }

        private Models.Lavarropas lavarropas;

        private void cargarDGV(int? idLavarropas)
        {
            if(idLavarropas != null)
            {
                using (MABEntities db = new MABEntities())
                {
                    lavarropas = db.Lavarropas.Find(idLavarropas);

                    var data = from reparaciones in db.Reparaciones
                               where reparaciones.LavarropasId == lavarropas.Id
                               select reparaciones;

                    ucDGVTabla.dataSource(data.ToList());
                }

                Text = "Reparaciones del Lavarropas " + lavarropas.marca + lavarropas.modelo;
            }
            else
            {
                using (MABEntities db = new MABEntities())
                {
                    lavarropas = null;

                    var shortList = from reparaciones in db.Reparaciones
                               where reparaciones.estadoReparacion == estadosReparacion.EnCurso
                               select reparaciones;

                    ucDGVTabla.ShortListData = shortList.ToList();

                    var fullList = db.Reparaciones;

                    ucDGVTabla.FullListData = fullList.ToList();
                    
                }

                Text = "Reparaciones";
            }
        }

        #region Eventos de Botones

        private void btnAgregar(object sender, EventArgs e)
        {
            if (lavarropas != null)
            {
                frmAgregarReparaciones frm = new frmAgregarReparaciones(lavarropas.Id);
                frm.ShowDialog();

                cargarDGV(lavarropas.Id);
            }
            else
            {
                DialogResult resp = MessageBox.Show(
                    "Se necesita un lavarropas al cual poder agregarle una Reparacion \n" +
                    "Es por este motivo que a continuacion se abrira una ventana para que pueda seleccionar el \n" +
                    "Lavarropas al que quiere agregarle una reparacion.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmSeleccionarLavarropas frmSeleccionarLavarropas = new frmSeleccionarLavarropas();
                frmSeleccionarLavarropas.ShowDialog();

                int idLavarropas = frmSeleccionarLavarropas.lavarropasSeleccionado;
                
                if(idLavarropas != -1)
                {
                    frmAgregarReparaciones frmAgregarReparaciones = new frmAgregarReparaciones(lavarropas.Id);
                    frmAgregarReparaciones.ShowDialog();
                }

                cargarDGV(null);
            }
        }

        private void btnModificar(object sender, EventArgs e)
        {
            /**
             * TODO: Acomodar la funcion Modificar
             * --- HECHO
             */

            if(ucDGVTabla.selectedRow() != null)
            {
                int idReparacion = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmModificarReparacion frm = new frmModificarReparacion(idReparacion);
                frm.ShowDialog();

                if(lavarropas != null)
                {
                    cargarDGV(lavarropas.Id);
                }
                else
                {
                    cargarDGV(null);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna Reparacion seleccionada.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
