using System.Windows.Forms;

namespace ImageWatermarkPro
{
	public partial class frmMain
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(System.Object sender, System.EventArgs e)
		{
			this.Text = Application.ProductName;

			ImageCopyrightCtrl.UserControl1 ctl = new ImageCopyrightCtrl.UserControl1("");
			ctl.StatusMessageUpdate += UpdateStatusMessage;
			Panel1.Controls.Add(ctl);
		}

		private void AboutThisProgramToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			frmAbout frm = new frmAbout();
			frm.ShowDialog();
		}


		private void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void UpdateStatusMessage(string Message)
		{
			lblMessage.Text = Message;
		}

	

		private static frmMain _DefaultInstance;
		public static frmMain DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new frmMain();

				return _DefaultInstance;
			}
		}
	}
}