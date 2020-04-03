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
    public partial class frmAgregarTelefono : Form
    {
        Models.Clientes cliente;

        public frmAgregarTelefono(int idCliente)
        {
            InitializeComponent();

            cargarCliente(idCliente);

            Text = "Agregar Telefono a " + cliente.nombre + " " + cliente.apellido;

            ucBottom.NumButtons = 2;

            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += agregarTelefono;
            ucBottom.evAccion3 += cerrar;
        }

        private void cargarCliente(int id)
        {
            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(id);

                cclblIdCliente.Text = cliente.Id.ToString();
            }
        }

        private void agregarTelefono(object sender, EventArgs e)
        {
            /**
             * TODO: Tengo que agregarle un control, para que si el telefono ya existe, no agregarlo de nuevo, solamente cambiarle el estado.
             * NOTA: El telefono se deberia de estar queriendo agregar al mismo cliente, Ya que en ese caso, si volviera a agregarlo se repetirian claves. Malo Malo.
             * --- HECHO
             */

            int idCliente = cliente.Id;
            int numTelefono = Convert.ToInt32(cctbTelefono.Text);

            if(cctbTelefono.Text != string.Empty && cctbTelefono.TextLength < 8)
            {
                Models.Telefonos telefono;

                using (MABEntities db = new MABEntities())
                {
                    telefono = db.Telefonos.Find(idCliente, numTelefono);
                    

                    if(telefono != null)
                    {
                        DialogResult resp = MessageBox.Show(
                            "Datos a guardar: \n" +
                            "Nombre y Apellido del Cliente: " + cliente.nombre + " " + cliente.apellido + "\n" +
                            "Nuevo numero de Telefono: " + numTelefono + "\n" +
                            "¿Desea Continuar?",
                            "Atencion",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if(resp == DialogResult.Yes)
                        {
                            telefono = new Models.Telefonos();

                            telefono.ClienteId = cliente.Id;
                            telefono.telefono = Convert.ToInt64(cctbTelefono.Text);
                            telefono.estado = true;

                            db.Telefonos.Add(telefono);
                            db.SaveChanges();

                        }
                    }else
                    {
                        MessageBox.Show("Se a encontrado un numero igual que pertenecio a este cliente. \n" +
                            "Se procedera a recuperar el telefono.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        telefono.estado = true;

                        db.Entry(telefono).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero de telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
