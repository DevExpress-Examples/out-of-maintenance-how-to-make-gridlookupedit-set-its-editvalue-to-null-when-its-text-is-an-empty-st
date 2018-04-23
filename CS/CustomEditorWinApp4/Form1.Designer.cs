namespace CustomEditor
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.nwindDataSet = new CustomEditorWinApp3.nwindDataSet();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productsTableAdapter = new CustomEditorWinApp3.nwindDataSetTableAdapters.ProductsTableAdapter();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCustomLookUpEdit1 = new CustomEditor.RepositoryItemCustomGridLookUpEdit();
			this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.categoriesTableAdapter = new CustomEditorWinApp3.nwindDataSetTableAdapters.CategoriesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomLookUpEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nwindDataSet
			// 
			this.nwindDataSet.DataSetName = "nwindDataSet";
			this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.nwindDataSet;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.productsBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCustomLookUpEdit1});
			this.gridControl1.Size = new System.Drawing.Size(572, 306);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colCategoryID});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colProductName
			// 
			this.colProductName.FieldName = "ProductName";
			this.colProductName.Name = "colProductName";
			this.colProductName.Visible = true;
			this.colProductName.VisibleIndex = 0;
			this.colProductName.Width = 265;
			// 
			// colCategoryID
			// 
			this.colCategoryID.ColumnEdit = this.repositoryItemCustomLookUpEdit1;
			this.colCategoryID.FieldName = "CategoryID";
			this.colCategoryID.Name = "colCategoryID";
			this.colCategoryID.Visible = true;
			this.colCategoryID.VisibleIndex = 1;
			this.colCategoryID.Width = 286;
			// 
			// repositoryItemCustomLookUpEdit1
			// 
			this.repositoryItemCustomLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.repositoryItemCustomLookUpEdit1.AutoHeight = false;
			this.repositoryItemCustomLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemCustomLookUpEdit1.DataSource = this.categoriesBindingSource;
			this.repositoryItemCustomLookUpEdit1.DisplayMember = "CategoryName";
			this.repositoryItemCustomLookUpEdit1.Name = "repositoryItemCustomLookUpEdit1";
			this.repositoryItemCustomLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.repositoryItemCustomLookUpEdit1.ValueMember = "CategoryID";
			// 
			// categoriesBindingSource
			// 
			this.categoriesBindingSource.DataMember = "Categories";
			this.categoriesBindingSource.DataSource = this.nwindDataSet;
			// 
			// categoriesTableAdapter
			// 
			this.categoriesTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 306);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCustomLookUpEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomEditorWinApp3.nwindDataSet nwindDataSet;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private CustomEditorWinApp3.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colProductName;
		private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
		private RepositoryItemCustomGridLookUpEdit repositoryItemCustomLookUpEdit1;
		private System.Windows.Forms.BindingSource categoriesBindingSource;
		private CustomEditorWinApp3.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;



	}
}

