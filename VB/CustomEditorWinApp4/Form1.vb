Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace CustomEditor
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
		End Sub
	End Class
End Namespace