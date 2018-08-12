using System;

namespace ImageWatermarkPro
{
	public partial class frmError
	{

		public frmError()
		{
			InitializeComponent();
		}

	    public Exception Ex { get; set; }


	    private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}