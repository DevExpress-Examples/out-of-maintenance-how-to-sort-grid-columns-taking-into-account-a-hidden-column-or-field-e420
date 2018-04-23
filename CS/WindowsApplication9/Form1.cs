using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace WindowsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++) {
                dataTable1.Rows.Add(new object[] { "Product"+ i,i, i%3});
            }
        }

        private void gridView1_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
				GridView view = sender as GridView;
                BindingSource ds = view.DataSource as BindingSource;
                int category1 = (int)((DataRowView)ds[e.ListSourceRowIndex1])["CategoryID"];
                int category2 = (int)((DataRowView)ds[e.ListSourceRowIndex2])["CategoryID"];
				e.Handled = true;
                if (category1 > category2 && e.SortOrder == DevExpress.Data.ColumnSortOrder.Ascending
                    || category1 < category2 && e.SortOrder == DevExpress.Data.ColumnSortOrder.Descending)
					e.Result = 1;
				else
                    if (category1 > category2 && e.SortOrder == DevExpress.Data.ColumnSortOrder.Descending 
                        || category1 < category2 && e.SortOrder == DevExpress.Data.ColumnSortOrder.Ascending)
                        e.Result = -1;
                    else
                    {
                        e.Result = Comparer.Default.Compare(e.Value1, e.Value2 );
                    }
        }
    }
}