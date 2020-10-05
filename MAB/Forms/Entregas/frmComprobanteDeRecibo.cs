using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MAB.Reports;
using MAB.Models;

namespace MAB.Forms.Entregas
{
    public partial class frmComprobanteDeRecibo : Form
    {
        public frmComprobanteDeRecibo(Models.Entregas entrega)
        {
            InitializeComponent();

            Models.Clientes cliente;

            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(entrega.ClientesId);
            }

            crComprobanteDeRecibo report = new crComprobanteDeRecibo();

            report.SetParameterValue("nombreCompletoCliente", cliente.nombre + " " + cliente.apellido);
            report.SetParameterValue("montoDeEntrega", entrega.monto);
            report.SetParameterValue("fechaDeEntrega", entrega.fecha);
            
            crvComprobanteDeRecibo.ReportSource = report;
        }
    }
}
