using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccLibrary
{
    public partial class ccTextBox : TextBox
    {
        public ccTextBox()
        {
            InitializeComponent();

            Anchor = AnchorStyles.None;
            Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            Size = new System.Drawing.Size(231, 20);
        }

        /**
         * TODO: Ponerle una propiedad que permita seleccionar si el tb sera alfanumero, solo de letras, solo de numeros, solo de letras
         * y caracteres especiales o solo de numeros y caracteres especiales. Y luego capturar el evento keypress para capturar la letra
         * que se ingreso y apartir de ahi continuar con lo que desee y no permitir el resto. Incluso se me ocurre que podria dejarle poner
         * un mensajito custom que salga si ingresa algun caracter invalido.
         * 
         */
    }
}
