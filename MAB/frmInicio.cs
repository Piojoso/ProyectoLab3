using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ccLibrary;
using System.Runtime.InteropServices;
using MAB.Forms.CRUD.Clientes;
using MAB.Forms.CRUD.Lavarropas;
using MAB.Forms.CRUD.Reparaciones;
using MAB.Forms.Reparaciones;
using MAB.Forms.Repuestos;
using MAB.Models;
using MAB.Reports;
using MAB.DataSets.dsStockEscasoTableAdapters;

namespace MAB.Forms
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            /**
             * TODO: Analizar la posibilidad de colocar un mini reloj con la hora actual. ¿para que?: nose, solo por hacerlo.
             * No solo eso, Esta sera la ventana de inicio del proyecto y desde aca tengo pensado que se podrian llegar a enseñar ciertas
             * estadisticas. Como cantidad de Lavarropas ingresados del ultimo mes, Cantidad de Lavarropas finalizados, Suma recaudada, etc.
             * Alertas sobre Stock Faltante, Quizas la opcion de Filtrar informacion de alguna manera. Nose como aun.
             * 
             * Analizar la posibilidad de:
             * · Intentar agregar de alguna forma que se puedan filtrar aquellas reparaciones que faltan de pagar
             * · Pensandolo asi quizas deberia ponerle un nuevo estado a las reparaciones, para saber si estan o no pagadas.
             * · Con esta info podria sacar a aquellos clientes que mas se tardaron en pagar sus deudas.
             * 
             */

            InitializeComponent();

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ucBotonera.NumBotones = 5;
            ucBotonera.ColorAlternativo = Control.DefaultBackColor;

            ucBotonera.btnAccion1 = "Inicio";
            ucBotonera.btnAccion2 = "Clientes";
            ucBotonera.btnAccion3 = "Reparaciones";
            ucBotonera.btnAccion4 = "Lavarropas";
            ucBotonera.btnAccion5 = "Stock";

            ucBotonera.evClickAccion1 += verInicio;
            ucBotonera.evClickAccion2 += verClientes;
            ucBotonera.evClickAccion3 += verReparaciones;
            ucBotonera.evClickAccion4 += verLavarropas;
            ucBotonera.evClickAccion5 += verStock;

            ucBotonera.BotonInicial = 1;

            cargarReporteStockEscaso();

            cargarEstadisticasReparaciones();

            cargarEstadisticasGenerales();
        }

        #region estadisticas

        private string ultimoClienteAgregado()
        {
            using (MABEntities db = new MABEntities())
            {
                var cliente = db.Clientes.OrderByDescending(c => c.Id).FirstOrDefault();

                return (cliente.nombre + ' ' + cliente.apellido);
            }
        }

        private int totalClientesGuardados()
        {
            using (MABEntities db = new MABEntities())
            {
                return db.Clientes.Count();
            }
        }

        private string clienteConMasReparaciones()
        {
            using (MABEntities db = new MABEntities())
            {
                int idCliente = -1;
                int maxReparaciones = 0;
                foreach (Models.Clientes cliente in db.Clientes)
                {
                    int reparaciones = 0;

                    foreach (Models.Lavarropas lavarropa in cliente.Lavarropas)
                    {
                        reparaciones += lavarropa.Reparacion.Count();
                    }

                    if (reparaciones >= maxReparaciones)
                    {
                        idCliente = cliente.Id;
                    }
                }

                if (idCliente != -1)
                {
                    Models.Clientes c = db.Clientes.Find(idCliente);

                    return (c.nombre + ' ' + c.apellido);
                }
                else
                {
                    return "";
                }
            }
        }

        private string clienteConMasLavarropas()
        {
            using (MABEntities db = new MABEntities())
            {
                int idCliente = -1;
                int maxLavarropas = 0;
                foreach (Models.Clientes cliente in db.Clientes)
                {
                    int lavarropas = cliente.Lavarropas.Count();

                    if (lavarropas >= maxLavarropas)
                    {
                        idCliente = cliente.Id;
                    }
                }

                if (idCliente != -1)
                {
                    Models.Clientes c = db.Clientes.Find(idCliente);
                    return (c.nombre + " " + c.apellido);
                }
                else
                {
                    return "";
                }
            }
        }

        private string ultimoLavarropasAgregado()
        {
            using (MABEntities db = new MABEntities())
            {
                var lavarropa = db.Lavarropas.OrderByDescending(l => l.Id).FirstOrDefault();

                return (lavarropa.marca + " " + lavarropa.modelo + " del Cliente " + lavarropa.Cliente.nombre + " " + lavarropa.Cliente.apellido);
            }
        }

        private int totalDeLavarropasGuardados()
        {
            using (MABEntities db = new MABEntities())
            {
                return db.Lavarropas.Count();
            }
        }

        private string lavarropasConMasReparaciones()
        {
            using (MABEntities db = new MABEntities())
            {
                int idLavarropas = -1;
                int maxReparaciones = 0;

                foreach (Models.Lavarropas lavarropa in db.Lavarropas)
                {
                    int reparaciones = lavarropa.Reparacion.Count();

                    if (reparaciones >= maxReparaciones)
                    {
                        idLavarropas = lavarropa.Id;
                    }
                }

                if (idLavarropas != -1)
                {
                    Models.Lavarropas l = db.Lavarropas.Find(idLavarropas);

                    return (l.marca + " " + l.modelo + " del cliente " + l.Cliente.nombre + " " + l.Cliente.apellido);
                }
                else
                {
                    return "";
                }
            }
        }

        private string marcaMasReparada()
        {
            using (MABEntities db = new MABEntities())
            {
                return db.MarcaMasReparado().FirstOrDefault();;
            }
        }

        private string modeloMasReparado()
        {
            using(MABEntities db = new MABEntities())
            {
                return db.ModeloMasReparado().FirstOrDefault();
            }
        }

        #endregion

        private void cargarEstadisticasGenerales()
        {
            cclblUltimoClienteAgregado.Text = ultimoClienteAgregado();

            cclblTotalClientesGuardados.Text = totalClientesGuardados().ToString();

            cclblClienteConMasReparaciones.Text = clienteConMasReparaciones();

            cclblClienteConMasLavarropas.Text = clienteConMasLavarropas();

            cclblUltimoLavarropasAgregado.Text = ultimoLavarropasAgregado();

            cclblTotalLavarropasGuardados.Text = totalDeLavarropasGuardados().ToString();

            cclblLavarropasConMasReparaciones.Text = lavarropasConMasReparaciones();

            cclblMarcaMasReparada.Text = marcaMasReparada();

            cclblModeloMasReparado.Text = modeloMasReparado();
        }

        private void cargarReporteStockEscaso()
        {
            crStocks report = new crStocks();
            RepuestosTableAdapter ta = new RepuestosTableAdapter();

            DataSet ds = new DataSet();
            ds.Tables.Add(ta.GetData());

            report.SetDataSource(ds);
            crvRepuestos.ReportSource = report;
        }

        private void cargarEstadisticasReparaciones()
        {
            frmEstadisticas frm = new frmEstadisticas();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tcPrincipal.TabPages["tpReparaciones"].Controls.Add(frm);
            tcPrincipal.TabPages["tpReparaciones"].Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        #region Acciones Botones

        private void verInicio(object sender, EventArgs e)
        {
            if (hijoActual != null)
                hijoActual.Close();

            ucTitleBar.TitleText = "MAB";
        }

        private void verClientes(object sender, EventArgs e)
        {
            abrirFormulario(new frmClientes());
        }

        private void verReparaciones(object sender, EventArgs e)
        {
            abrirFormulario(new frmReparaciones());
        }

        private void verLavarropas(object sender, EventArgs e)
        {
            abrirFormulario(new frmLavarropas());
        }

        private void verStock(object sender, EventArgs e)
        {
            abrirFormulario(new frmRepuestos());
        }

        #endregion

        #region Formulario Hijo

        //Campos
        private Form hijoActual;

        private void abrirFormulario(Form hijo)
        {
            if (hijoActual != null)
            {
                hijoActual.Close();
                ucTitleBar.TitleText = "MAB";
            }
            hijoActual = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(hijo);
            pnlContent.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();

            ucTitleBar.TitleText = "MAB - " + hijo.Text;
        }

        #endregion

    }
}
