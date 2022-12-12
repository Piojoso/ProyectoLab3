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

namespace MAB.Forms.CRUD.Clientes
{
    public partial class frmBuscarCliente : Form
    {
        public List<int> idClientes;

        public frmBuscarCliente()
        {
            /**
             * TODO: Revisar el correcto Funcionamiento
             */

            InitializeComponent();

            Text = "Buscar Cliente";
            
            ucBottom.Accion1 = "Buscar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += buscarCliente;
            ucBottom.evAccion2 += cerrarBusqueda;

            string messageError = "Solo se permiten Letras, no se permiten numeros.";

            cctbNombre.CaracterIncorrectErrorMessage = messageError;
            cctbApellido.CaracterIncorrectErrorMessage = messageError;
        }
        
        private void buscarCliente(object sender, EventArgs e)
        {
            idClientes = buscar();

            if (idClientes.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontraron registros", "No hubo resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cctbNombre.Focus();
            }
        }

        private List<int> buscar()
        {
            List<int> resp = new List<int>();

            bool nombre = cctbNombre.Text != string.Empty ? true : false;
            bool apellido = cctbApellido.Text != string.Empty ? true : false;
            bool direccion = cctbDireccion.Text != string.Empty ? true : false;

            using (MABEntities db = new MABEntities())
            {
                if(nombre)
                {
                    var clientes = db.Clientes.Where(c => c.nombre.Contains(cctbNombre.Text));

                    foreach (var cliente in clientes)
                    {
                        if (!resp.Contains(cliente.Id))
                        {
                            resp.Add(cliente.Id);
                        }
                    }
                }
                if (apellido)
                {
                    var clientes = db.Clientes.Where(c => c.apellido.Contains(cctbApellido.Text));

                    foreach (var cliente in clientes)
                    {
                        if (!resp.Contains(cliente.Id))
                        {
                            resp.Add(cliente.Id);
                        }
                    }
                }
                if (direccion)
                {
                    var clientes = db.Clientes.Where(c => c.direccion.Contains(cctbDireccion.Text));

                    foreach (var cliente in clientes)
                    {
                        if (!resp.Contains(cliente.Id))
                        {
                            resp.Add(cliente.Id);
                        }
                    }
                }
            }

            return resp;
        }

        private void cerrarBusqueda(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
