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

            KeyPress += keyPress;
        }

        #region Controlador de caracteres

        public enum dataType : int
        {
            Alfabetico = 0,
            Numerico = 1,
            AlfaNumerico = 3,
        }

        private dataType tipoDeDato = dataType.AlfaNumerico;

        [DefaultValue(dataType.AlfaNumerico)]
        public dataType DataType
        {
            get { return tipoDeDato; }
            set { tipoDeDato = value; }
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
            {
                if (char.IsLetter(e.KeyChar) && tipoDeDato == dataType.Alfabetico)
                    e.Handled = false;
                else if (char.IsDigit(e.KeyChar) && tipoDeDato == dataType.Numerico)
                    e.Handled = false;
                else if (char.IsLetterOrDigit(e.KeyChar) && tipoDeDato == dataType.AlfaNumerico)
                    e.Handled = false;
                else
                {
                    e.Handled = true;

                    if (messageError != string.Empty)
                        MessageBox.Show(messageError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private string messageError = string.Empty;

        public string CaracterIncorrectErrorMessage
        {
            get { return messageError; }
            set { messageError = value; }
        }

        /**
         * TODO: Ponerle una propiedad que permita seleccionar si el tb sera alfanumero, solo de letras, solo de numeros, solo de letras
         * y caracteres especiales o solo de numeros y caracteres especiales. Y luego capturar el evento keypress para capturar la letra
         * que se ingreso y apartir de ahi continuar con lo que desee y no permitir el resto. Incluso se me ocurre que podria dejarle poner
         * un mensajito custom que salga si ingresa algun caracter invalido.
         * 
         * Lo de letras y caracteres especiales, y numeros y caracteres especiales, es descartado, porque es al pedo.
         * 
         * --- HECHO
         */
    }
}
