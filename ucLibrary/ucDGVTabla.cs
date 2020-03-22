using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ucLibrary
{
    public partial class ucDGVTabla : UserControl
    {
        public ucDGVTabla()
        {
            InitializeComponent();
        }

        #region Colors of Button

        private Color fondoBotones;
        
        public Color FondoBotones
        {
            get { return fondoBotones; }
            set
            {
                fondoBotones = value;

                if (!fondoBotones.IsEmpty)
                {
                    foreach (IconButton btn in gbButtons.Controls)
                    {
                        btn.BackColor = fondoBotones;
                    }
                }
                else
                {
                    btnAdd.BackColor = colorsButtons.btnAdd;
                    btnModify.BackColor = colorsButtons.btnModify;
                    btnSeeAll.BackColor = colorsButtons.btnSeeAll;
                    btnSearch.BackColor = colorsButtons.btnSearch;
                    btnDelete.BackColor = colorsButtons.btnDelete;
                }
            }
        }

        private struct colorsButtons
        {
            public static Color btnAdd = Color.ForestGreen;
            public static Color btnModify = Color.FromArgb(192, 192, 0);
            public static Color btnSeeAll = Color.DarkGray;
            public static Color btnSearch = Color.SteelBlue;
            public static Color btnDelete = Color.IndianRed;
        }

        public Color buttonAdd
        {
            get { return colorsButtons.btnAdd; }
            set { colorsButtons.btnAdd = value; }
        }

        public Color buttonModify
        {
            get { return colorsButtons.btnModify; }
            set { colorsButtons.btnModify = value; }
        }

        public Color buttonSeeAll
        {
            get { return colorsButtons.btnSeeAll; }
            set { colorsButtons.btnSeeAll = value; }
        }

        public Color buttonSearch
        {
            get { return colorsButtons.btnSearch; }
            set { colorsButtons.btnSearch = value; }
        }

        public Color buttonDelete
        {
            get { return colorsButtons.btnDelete; }
            set { colorsButtons.btnDelete = value; }
        }

        #endregion

        #region DGVStyle
        
        private DataGridViewCellStyle columnHeaders;
        private DataGridViewCellStyle rowsHeaders;
        private DataGridViewCellStyle rowsCells;

        public DataGridViewCellStyle ColumnHeaderStyle
        {
            get { return columnHeaders; }
            set
            {
                columnHeaders = value;

                if(columnHeaders != null)
                    dgvPrincipal.ColumnHeadersDefaultCellStyle = columnHeaders;
            }
        }

        public DataGridViewCellStyle RowsHeaderStyle
        {
            get { return rowsHeaders; }
            set
            {
                rowsHeaders = value;

                if (columnHeaders != null)
                    dgvPrincipal.RowHeadersDefaultCellStyle = rowsHeaders;
            }
        }

        public DataGridViewCellStyle RowsCellStyle
        {
            get { return rowsCells; }
            set
            {
                rowsCells = value;

                if (columnHeaders != null)
                    dgvPrincipal.DefaultCellStyle = rowsCells;
            }
        }

        #endregion

        #region Botones y sus Forms

        private struct forms
        {
            public static Form frmAdd;
            public static Form frmModify;
            public static Form frmSeeAll;
            public static Form frmSearch;
            public static Form frmDelete;
        }

        public Form FrmAdd
        {
            get { return forms.frmAdd; }
            set { forms.frmAdd = value; }
        }

        public Form FrmModify
        {
            get { return forms.frmModify; }
            set { forms.frmModify = value; }
        }

        public Form FrmSeeAll
        {
            get { return forms.frmSeeAll; }
            set { forms.frmSeeAll = value; }
        }

        public Form FrmSearch
        {
            get { return forms.frmSearch; }
            set { forms.frmSearch = value; }
        }

        public Form FrmDelete
        {
            get { return forms.frmDelete; }
            set { forms.frmDelete = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            forms.frmAdd?.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            forms.frmModify?.ShowDialog();
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            forms.frmSeeAll?.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            forms.frmSearch?.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            forms.frmDelete?.ShowDialog();
        }

        #endregion

        public void dataSource(object data)
        {
            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = data;
            this.columns = dgvPrincipal.Columns;
        }

        #region DGVColumns

        private DataGridViewColumnCollection columns;

        public DataGridViewColumnCollection Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        #endregion
    }
}
