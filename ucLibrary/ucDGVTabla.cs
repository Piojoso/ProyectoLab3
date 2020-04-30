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

            dgvPrincipal.CellDoubleClick += dobleClickSobreItemDGV;
        }

        #region Evento de DobleClik sobre una item en el DGV

        public event EventHandler CellDoubleClick;
        
        private void dobleClickSobreItemDGV(object sender, EventArgs e)
        {
            CellDoubleClick?.Invoke(sender, e);

        }
        
        #endregion

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

                if (columnHeaders != null)
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

        #region Eventos de Botones

        public event EventHandler click_btnAdd;
        public event EventHandler click_btnModify;
        public event EventHandler click_btnSearch;
        public event EventHandler click_btnDelete;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            click_btnAdd?.Invoke(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            click_btnModify?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            click_btnSearch?.Invoke(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            click_btnDelete?.Invoke(sender, e);
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

        #region Delete Button

        private bool deleteVisibility = true;

        [DefaultValue(true)]
        public bool DeleteVisibility
        {
            get { return deleteVisibility; }
            set
            {
                deleteVisibility = value;

                btnDelete.Visible = deleteVisibility;
            }
        }

        #endregion

        public DataGridViewRow selectedRow()
        {
            if (dgvPrincipal.CurrentRow != null)
                return dgvPrincipal.Rows[dgvPrincipal.CurrentRow.Index];
            else
                return null;
        }

        #region Iconos de Botones

        private IconChar iconBtnAdd = IconChar.Plus;
        private IconChar iconBtnModify = IconChar.Edit;
        private IconChar iconBtnSeeAll = IconChar.Bars;
        private IconChar iconBtnSeeShort = IconChar.Minus;
        private IconChar iconBtnSearh = IconChar.Search;
        private IconChar iconBtnDelete = IconChar.Trash;

        [DefaultValue(IconChar.Plus)]
        public IconChar IconBtnAdd
        {
            get { return iconBtnAdd; }
            set
            {
                iconBtnAdd = value;

                btnAdd.IconChar = iconBtnAdd;
            }
        }

        [DefaultValue(IconChar.Edit)]
        public IconChar IconBtnModify
        {
            get { return iconBtnModify; }
            set
            {
                iconBtnModify = value;

                btnModify.IconChar = iconBtnModify;
            }
        }

        [DefaultValue(IconChar.Bars)]
        public IconChar IconBtnSeeAll
        {
            get { return iconBtnSeeAll; }
            set
            {
                iconBtnSeeAll = value;

                if (!cargadoShortList)
                {
                    btnSeeAll.IconChar = iconBtnSeeAll;
                }
            }
        }

        [DefaultValue(IconChar.Minus)]
        public IconChar IconBtnSeeShort
        {
            get { return iconBtnSeeShort; }
            set
            {
                iconBtnSeeShort = value;

                if (cargadoShortList)
                    btnSeeAll.IconChar = iconBtnSeeShort;
            }
        }

        [DefaultValue(IconChar.Search)]
        public IconChar IconBtnSearch
        {
            get { return iconBtnSearh; }
            set
            {
                iconBtnSearh = value;

                btnSearch.IconChar = iconBtnSearh;
            }
        }

        [DefaultValue(IconChar.Trash)]
        public IconChar IconBtnDelete
        {
            get { return iconBtnDelete; }
            set
            {
                iconBtnDelete = value;

                btnDelete.IconChar = iconBtnDelete;
            }
        }

        #endregion

        #region btnSeeAll
        
        private object all;
        private object shortList;

        public object FullListData
        {
            get { return all; }
            set
            {
                all = value;

                dataSource(all);
            }
        }

        public object ShortListData
        {
            get { return shortList; }
            set
            {
                shortList = value;

                dataSource(shortList);
            }
        }

        private bool cargadoShortList = true;

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            alternarDatosDGV();
        }

        private void alternarDatosDGV()
        {
            if(all != null && shortList != null)
            {
                if (cargadoShortList)
                {
                    dataSource(all);
                    btnSeeAll.IconChar = IconBtnSeeAll;
                    cargadoShortList = false;
                }
                else
                {
                    dataSource(shortList);
                    btnSeeAll.IconChar = IconBtnSeeShort;
                    cargadoShortList = true;
                }
            }
        }

        #endregion

        #region ContextMenuStrip (cms) para el DGV

        private ContextMenuStrip cms;

        public ContextMenuStrip cargarCMS
        {
            get { return cms; }
            set
            {
                cms = value;
                dgvPrincipal.ContextMenuStrip = cms;
            }
        }

        #endregion

        #region ocultar/mostrar Botonera

        private bool botonera = true;

        [DefaultValue(true)]
        public bool ButtonPadVisibility
        {
            get { return botonera; }
            set
            {
                botonera = value;

                if(botonera)
                {
                    pnlAside.Visible = true;
                    pnlAside.Width = 200;
                }
                else
                {
                    pnlAside.Visible = false;
                    pnlAside.Width = 0;
                }
            }
        }

        #endregion
    }
}
