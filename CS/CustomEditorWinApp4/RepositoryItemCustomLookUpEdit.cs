using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace CustomEditor
{
	class RepositoryItemCustomGridLookUpEdit : RepositoryItemGridLookUpEdit
	{
		internal const string EditorName = "CustomGridLookUpEdit";

		static RepositoryItemCustomGridLookUpEdit()
		{
			Register();
		}
		public RepositoryItemCustomGridLookUpEdit()
		{
		}

		public static void Register()
		{
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
			  typeof(CustomGridLookUpEdit), typeof(RepositoryItemCustomGridLookUpEdit),
				typeof(ButtonEditViewInfo), new ButtonEditPainter(), true));
		}

		public override string EditorTypeName
		{
			get
			{
				return EditorName;
			}
		}

		protected internal new bool IsNullInputAllowed
		{
			get
			{
				return base.IsNullInputAllowed;
			}
		}
	}
}
