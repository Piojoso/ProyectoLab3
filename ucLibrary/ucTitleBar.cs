using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucLibrary
{
    public partial class ucTitleBar : UserControl
    {
        public ucTitleBar()
        {

            /**
             * TODO: selector de color de fondo
             * --- HECHO: en realidad solo acomode los colores del componente (hacerlos transparentes para que se vea el backcolor).
             * 
             * TODO: escribir titulo
             * --- HECHO
             * 
             * TODO: selector de iconos (Maximizar, Minimizar, Cerrar). Tambien permitir agregar uno personal.
             * 
             * TODO: Dar la chance de poder ocultar ciertos botones
             * 
             * TODO: Selector de alineacion de Titulo (Izq, Der, Centro)
             * 
             * TODO: Selector de alineacion de Botones (Izq, Der, Centro)
             * 
             * TODO: opcion de agregar imagen de app.
             * 
             * TODO: color de fondo de botones, y color de texto de los botones.
             * 
             * TODO: color de texto del titulo
             */

            InitializeComponent();
        }
        
        #region Titulo de la Ventana

        private string tituloVentana;

        public string TitleText
        {
            get { return tituloVentana; }
            set
            {
                tituloVentana = value;
                cclblTituloVentana.Text = tituloVentana;
            }
        }

        #endregion
    }
}
