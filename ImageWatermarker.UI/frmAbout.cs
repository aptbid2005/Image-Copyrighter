using System.Windows.Forms;

namespace ImageWatermarkPro
{
	public sealed partial class frmAbout
	{

		public frmAbout()
		{
			InitializeComponent();
		}

		private void frmAbout_Load(System.Object sender, System.EventArgs e)
		{
			// Set the title of the form.
			string applicationTitle  = Application.ProductName;
            this.Text = $"About {applicationTitle}";


			this.LabelProductName.Text = applicationTitle;
			this.LabelVersion.Text = string.Format("Version {0}", Application.ProductVersion);
			//this.LabelCopyright.Text = Application.;
			//this.LabelCompanyName.Text = My.MyApplication.Application.Info.CompanyName;
			//this.TextBoxDescription.Text = My.MyApplication.Application.Info.Description;
		}

		private void OKButton_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

	}

}