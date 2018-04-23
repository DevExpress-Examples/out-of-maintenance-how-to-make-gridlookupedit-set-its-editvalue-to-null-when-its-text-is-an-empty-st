using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace CustomEditor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
			this.productsTableAdapter.Fill(this.nwindDataSet.Products);
		}
	}
}