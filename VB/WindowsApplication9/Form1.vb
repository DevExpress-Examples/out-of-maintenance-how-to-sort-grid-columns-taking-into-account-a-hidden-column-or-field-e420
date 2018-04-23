Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections

Namespace WindowsApplication9
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 19
				dataTable1.Rows.Add(New Object() { "Product" & i,i, i Mod 3})
			Next i
		End Sub

		Private Sub gridView1_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs) Handles gridView1.CustomColumnSort
				Dim view As GridView = TryCast(sender, GridView)
				Dim ds As BindingSource = TryCast(view.DataSource, BindingSource)
				Dim category1 As Integer = CInt(Fix((CType(ds(e.ListSourceRowIndex1), DataRowView))("CategoryID")))
				Dim category2 As Integer = CInt(Fix((CType(ds(e.ListSourceRowIndex2), DataRowView))("CategoryID")))
				e.Handled = True
				If category1 > category2 AndAlso e.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending OrElse category1 < category2 AndAlso e.SortOrder = DevExpress.Data.ColumnSortOrder.Descending Then
					e.Result = 1
				Else
					If category1 > category2 AndAlso e.SortOrder = DevExpress.Data.ColumnSortOrder.Descending OrElse category1 < category2 AndAlso e.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending Then
						e.Result = -1
					Else
						e.Result = Comparer.Default.Compare(e.Value1, e.Value2)
					End If
				End If
		End Sub
	End Class
End Namespace