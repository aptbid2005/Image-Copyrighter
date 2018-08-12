//INSTANT C# NOTE: Formerly VB project-level imports:

using System.Drawing;

namespace ImageCopyrightCtrl
{
	public partial class ImagePreview
	{

		private Bitmap _bmp;
		public Bitmap BMP
		{
			get
			{
				return _bmp;
			}
			set
			{
				_bmp = value;
			}
		}


		private void ImagePreview_Load(object sender, System.EventArgs e)
		{
			PictureBox1.Image = BMP;
		}

	}
}