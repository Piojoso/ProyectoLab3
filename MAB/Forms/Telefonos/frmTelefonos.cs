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

namespace MAB.Forms.CRUD.Telefonos
{
    public partial class frmTelefonos : Form
    {
        Models.Clientes cliente;

        public frmTelefonos(int idCliente)
        {
            /**
             * TODO: Agregar un ContextMenuStrip para el dgv
             */

            InitializeComponent();

            refrescarTelefonos(idCliente);

            Text = "Telefonos del Cliente: " + cliente.nombre + " " + cliente.apellido;

            ucBottom.NumButtons = 2;

            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion3 = "Eliminar";

            ucBottom.evAccion1 += agregarNuevo;
            ucBottom.evAccion3 += eliminarSeleccionado;
            
        }

        private void agregarNuevo(object sender, EventArgs e)
        {
            frmAgregarTelefono frm = new frmAgregarTelefono(cliente.Id);
            frm.ShowDialog();

            refrescarTelefonos(cliente.Id);
        }
        
        private void eliminarSeleccionado(object sender, EventArgs e)
        {
            /**
             * TODO: Probar su correcto funcionamiento
             */

            if (ucDGVTabla.selectedRow() != null)
            {
                int telefono = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Telefono"].Value);

                using (MABEntities db = new MABEntities())
                {
                    var Telefono = (from tel in db.Telefonos
                                    where tel.telefono == telefono
                                    where tel.estado != false
                                    select tel).First();

                    DialogResult resp = MessageBox.Show(
                        "Esta a punto de eliminar el Telefono " + Telefono.telefono + Environment.NewLine +
                        "del Cliente " + Telefono.Cliente.nombre + " " + Telefono.Cliente.apellido + Environment.NewLine +
                        "¿Quiere continuar con la eliminacion?", "Estas a Punto de eliminar un Telefono", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resp == DialogResult.Yes)
                    {
                        Telefono.estado = false;

                        db.Entry(Telefono).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                    }
                }
            }

            refrescarTelefonos(cliente.Id);
        } 
        
        private void refrescarTelefonos(int idCliente)
        {
            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(idCliente);

                var data = (from telefonos in db.Telefonos
                            where telefonos.ClienteId == cliente.Id
                            where telefonos.estado == true
                            select telefonos);

                ucDGVTabla.dataSource(data.ToList());
            }

        }
    }
}
