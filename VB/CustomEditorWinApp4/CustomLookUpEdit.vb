Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace CustomEditor
	Friend Class CustomGridLookUpEdit
		Inherits GridLookUpEdit
		Shared Sub New()
			RepositoryItemCustomGridLookUpEdit.Register()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomGridLookUpEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomGridLookUpEdit)
			End Get
		End Property

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomGridLookUpEdit.EditorName
			End Get
		End Property

		Protected Overrides Function CheckInputNewValue(ByVal [partial] As Boolean) As Boolean
			If Me.Properties.IsNullInputAllowed AndAlso String.IsNullOrEmpty(MaskBox.MaskBoxText) Then
				Me.EditValue = Nothing
				Return True
			End If

			Return MyBase.CheckInputNewValue([partial])
		End Function
	End Class
End Namespace
