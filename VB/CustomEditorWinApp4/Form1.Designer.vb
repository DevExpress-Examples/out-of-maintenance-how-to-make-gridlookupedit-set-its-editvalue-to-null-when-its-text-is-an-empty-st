Imports Microsoft.VisualBasic
Imports System
Namespace CustomEditor
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.nwindDataSet = New CustomEditorWinApp3.nwindDataSet()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsTableAdapter = New CustomEditorWinApp3.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCustomLookUpEdit1 = New CustomEditor.RepositoryItemCustomGridLookUpEdit()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.categoriesTableAdapter = New CustomEditorWinApp3.nwindDataSetTableAdapters.CategoriesTableAdapter()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCustomLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.productsBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCustomLookUpEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(572, 306)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductName, Me.colCategoryID})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 0
			Me.colProductName.Width = 265
			' 
			' colCategoryID
			' 
			Me.colCategoryID.ColumnEdit = Me.repositoryItemCustomLookUpEdit1
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 1
			Me.colCategoryID.Width = 286
			' 
			' repositoryItemCustomLookUpEdit1
			' 
			Me.repositoryItemCustomLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.repositoryItemCustomLookUpEdit1.AutoHeight = False
			Me.repositoryItemCustomLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCustomLookUpEdit1.DataSource = Me.categoriesBindingSource
			Me.repositoryItemCustomLookUpEdit1.DisplayMember = "CategoryName"
			Me.repositoryItemCustomLookUpEdit1.Name = "repositoryItemCustomLookUpEdit1"
			Me.repositoryItemCustomLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.repositoryItemCustomLookUpEdit1.ValueMember = "CategoryID"
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(572, 306)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCustomLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private nwindDataSet As CustomEditorWinApp3.nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As CustomEditorWinApp3.nwindDataSetTableAdapters.ProductsTableAdapter
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemCustomLookUpEdit1 As RepositoryItemCustomGridLookUpEdit
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As CustomEditorWinApp3.nwindDataSetTableAdapters.CategoriesTableAdapter



	End Class
End Namespace

