using System;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace CustomEditor
{
	class CustomGridLookUpEdit : GridLookUpEdit
	{
		static CustomGridLookUpEdit()
		{
			RepositoryItemCustomGridLookUpEdit.Register();
		}
		public CustomGridLookUpEdit()
			: base()
		{
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemCustomGridLookUpEdit Properties
		{
			get
			{
				return base.Properties as RepositoryItemCustomGridLookUpEdit;
			}
		}

		public override string EditorTypeName
		{
			get
			{
				return RepositoryItemCustomGridLookUpEdit.EditorName;
			}
		}

		protected override bool CheckInputNewValue(bool partial)
		{
			if ( this.Properties.IsNullInputAllowed && String.IsNullOrEmpty(MaskBox.MaskBoxText) )
			{
				this.EditValue = null;
				return true;
			}

			return base.CheckInputNewValue(partial);
		}
	}
}
