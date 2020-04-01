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
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += crearCliente;
            ucBottom.evAccion3 += cancelarCreacion;
        }

        private void crearCliente(object sender, EventArgs e)
        {
            /**
             * TODO: Preguntar por si realmente quiere guardar a este contacto con la info colocada en los textbox. Si lo hago asi
             * debere controlar que los textbox esten completos, sino.. podria llamar a la funcion guardarCliente y ahi preguntar si
             * quiere guardar, luego de haber chequeado que los tb sean correctos.
             * --- HECHO
             */

            int idCliente = guardarCliente();

            if(idCliente > -1)
            {
                DialogResult resp = MessageBox.Show(
                    "¿Desea agregarle telefonos a este cliente?", 
                    "¿Agregar Telefonos?", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                );

                if (resp == DialogResult.Yes)
                {
                    frmAgregarTelefono frm = new frmAgregarTelefono(cliente.Id);
                    frm.ShowDialog();
                }
            }
        }

        private void cancelarCreacion(object sender, EventArgs e)
        {
            this.Close();
        }

        private int guardarCliente()
        {
            /**
            * TODO: Guarda incluso si no hay info, hay que arreglarlo.
            * --- HECHO
            */
            if ((cctbNombre.Text != string.Empty) && (cctbApellido.Text != string.Empty) && (cctbDireccion.Text != string.Empty))
            {
                using (MABEntities db = new MABEntities())
                {
                    DialogResult resp = MessageBox.Show(
                        "Desea guardar al cliente: \n" + 
                        "Nombre: " + cctbNombre.Text + "\n" + 
                        "Apellido: " + cctbApellido.Text + "\n" +
                        "Direccion" + cctbDireccion.Text + "\n", 
                        "Atencion",
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning
                    );

                    if(resp == DialogResult.Yes)
                    {
                        cliente = new Models.Clientes();

                        cliente.nombre = cctbNombre.Text;
                        cliente.apellido = cctbApellido.Text;
                        cliente.direccion = cctbDireccion.Text;

                        db.Clientes.Add(cliente);
                        db.SaveChanges();

                        return cliente.Id;
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }
    }
}
