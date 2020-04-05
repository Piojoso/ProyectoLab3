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
using MAB.Forms.Telefonos;

namespace MAB.Forms.CRUD.Telefonos
{
    public partial class frmTelefonos : Form
    {
        Models.Clientes cliente;

        public frmTelefonos(int idCliente)
        {
            /**
             * TODO: Probar su correcto funcionamiento cuando ya cree clientes en la DB
             */

            InitializeComponent();

            refrescarTelefonos(idCliente);

            Text = "Telefonos del Cliente: " + cliente.nombre + " " + cliente.apellido;
           
            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion2 = "Modificar";
            ucBottom.Accion3 = "Eliminar";

            ucBottom.evAccion1 += agregarNuevo;
            ucBottom.evAccion2 += modificarNumero;
            ucBottom.evAccion3 += eliminarSeleccionado;

            creacionCMS();
            
        }

        private void agregarNuevo(object sender, EventArgs e)
        {
            frmAgregarTelefono frm = new frmAgregarTelefono(cliente.Id);
            frm.ShowDialog();

            refrescarTelefonos(cliente.Id);
        }

        private void modificarNumero(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                /**
                 * TODO: Tomar el numero y abrir un formulario para modificar el numero. Se me ocurre usar el mismo frmAgregarTelefono
                 * Pero para ello tendre que modificarlo para que pueda aceptar un numero a modificar. Eso o crear un nuevo frm que reciba
                 * un numero de telefono y luego permita modificarlo, pero nose, ya vere, parece mas trabajo, pero tambien mas entendible.
                 * --- HECHO
                 */

                long numTelefono = Convert.ToInt64(ucDGVTabla.selectedRow().Cells["telefono"].Value);
                int idCliente = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["ClienteId"].Value);

                frmModificarTelefono frm = new frmModificarTelefono(idCliente, numTelefono);
                frm.ShowDialog();

                refrescarTelefonos(idCliente);
            }
        }
        
        private void eliminarSeleccionado(object sender, EventArgs e)
        {
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

        private void creacionCMS()
        {
            ToolStripMenuItem tsmiAgregar = new ToolStripMenuItem();
            tsmiAgregar.Name = "tsmiAgregar";
            tsmiAgregar.Size = new Size(148, 22);
            tsmiAgregar.Text = "Agregar Nuevo";
            tsmiAgregar.Click += agregarNuevo;

            ToolStripMenuItem tsmiModificar = new ToolStripMenuItem();
            tsmiModificar.Name = "tsmiModificar";
            tsmiModificar.Size = new Size(148, 22);
            tsmiModificar.Text = "Modificar Numero";
            tsmiModificar.Click += modificarNumero;

            ToolStripSeparator tssSeparator = new ToolStripSeparator();
            tssSeparator.Name = "tssSeparator";
            tssSeparator.Size = new Size(145, 6);

            ToolStripMenuItem tsmiEliminar = new ToolStripMenuItem();
            tsmiEliminar.Name = "tsmiEliminar";
            tsmiEliminar.Size = new Size(148, 22);
            tsmiEliminar.Text = "Eliminar Numero";
            tsmiEliminar.Click += eliminarSeleccionado;

            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.AddRange(new ToolStripItem[]
            {
                tsmiAgregar,
                tsmiModificar,
                tssSeparator,
                tsmiEliminar
            });
            cms.Name = "cmsDGV";

            ucDGVTabla.cargarCMS = cms;
        }
    }
}
