using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//   Program Name:   Image Copyright Pro
//   Date:           8/15/2010
//   Author:         Jason Nowicki
//   Purpose:        Allow artists/photographers to digitally copyright their work by
//                   digitally signing with meta data as well as watermarking with
//                   text or an image.

// http://www.c-sharpcorner.com/UploadFile/mgold/PropertyGridInCSharp11302005004139AM/PropertyGridInCSharp.aspx
// http://msdn.microsoft.com/en-us/library/system.drawing.imaging.propertyitem.type.aspx
// Convert hex to dec http://bytes.com/forum/thread336748.html
// Property Items ordered with description and type http://msdn.microsoft.com/en-us/library/ms534416(VS.85).aspx
// Setting a property Item if it doesn't exist: http://bytes.com/forum/thread371156.html

namespace ImageCopyrightCtrl
{
	public partial class UserControl1
	{

		public delegate void StatusMessageUpdateEventHandler(string message);
		public event StatusMessageUpdateEventHandler StatusMessageUpdate;
		public delegate void ProcessingModeEventHandler(string mode);
		public event ProcessingModeEventHandler ProcessingMode;

		private CopyrightModeType copyrightMode;
		private enum CopyrightModeType
		{
			Multiple = 1,
			Individual = 2
		}

		public delegate void ProcessImageEventEventHandler();
		public event ProcessImageEventEventHandler ProcessImageEvent;
		private void ProcessImage()
		{
			Globals.ProcessImage();
		    ProcessImageEvent?.Invoke();
		}

		private enum WatermarkPlacement
		{
			TopLeft = 1,
			TopCenter = 2,
			TopRight = 3,
			LeftCenter = 4,
			MiddleLeft = 5,
			MiddleCenter = 6,
			MiddleRight = 7,
			RightCenter = 8,
			BottomLeft = 9,
			BottomCenter = 10,
			BottomRight = 11,
			RepeatTop = 12,
			RepeatMiddle = 13,
			RepeatBottom = 14,
			RepeatAll = 15
		}

		private Font style;
		private clsImage jsn;
		private int fileCount; // The # of images processed
		private int imageCount; // The # of images to process for multiple process mode
		private Color wmColor = Color.White;
		private WatermarkPlacement wmTextPlacement;
		private WatermarkPlacement wmImagePlacement;
		private string currentDirectory = string.Empty;
		private readonly List<string> fileTypes = new List<string>(new[] {".bmp", ".jpg", ".tif", ".png", ".exif", ".gif"});

		private void UserControl1_Load(object sender, EventArgs e)
		{
		    this.style = new Font("Verdana", 18, FontStyle.Regular);
		}

		private void LoadImage(string path)
		{
			if (this.jsn != null)
			{
			    this.jsn = null;
			}

		    this.jsn = CopyImage(path);

			if (this.jsn != null)
			{
				System.IO.MemoryStream ms = new System.IO.MemoryStream(this.jsn.PicData);
				Bitmap img = new Bitmap(ms);

				// 296 x 174
				int w = 296;
				int h = 174;
				if (img.Height > img.Width)
				{
					w = Convert.ToInt32(img.Width / (double)img.Height * 174);
					if (w > 296)
					{
						w = 296;
					}
				}
				else
				{
					h = Convert.ToInt32(img.Height / (double)img.Width * 296);
					if (h > 174)
					{
						h = 174;
					}
				}

				this.PictureBox1.Width = w;
				this.PictureBox1.Height = h;

				this.PictureBox1.Image = img;

			}
		}

		/// <summary>
		/// Copies the image from disk to memory
		/// </summary>
		/// <param name="path">Path of image to copy</param>
		private clsImage CopyImage(string path)
		{
			clsImage img = null;

			if (path.Trim().Length > 0)
			{
				System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open);

				if (fs.CanRead)
				{
					byte[] b = new byte[fs.Length + 1];
					fs.Read(b, 0, (int) fs.Length);

					img = new clsImage();
					img.PicData = b;
					img.FileName = fs.Name.Substring(fs.Name.LastIndexOf("\\") + 1);

					System.IO.FileInfo fi = new System.IO.FileInfo(fs.Name);
					fs.Close();

					img.FileType = fi.Extension;

					System.IO.MemoryStream ms = new System.IO.MemoryStream(b);
					Bitmap bmp = new Bitmap(ms);
					ms.Close();

					img.Height = bmp.Height;
					img.Width = bmp.Width;

					bmp.Dispose();
				}
				else
				{
					MessageBox.Show("Cannot read file, it might be locked", "Locked File", MessageBoxButtons.OK);
				}
			}

			return img;
		}

		private Bitmap DrawImageWatermark(Bitmap resultBm)
		{
			// http://www.vb-helper.com/howto_net_watermark.html

			if (System.IO.File.Exists(this.inWatermarkImagePath.Text.Trim()) == false)
			{
				MessageBox.Show("Please locate an image to use as a watermark or uncheck the 'Add Image Watermark' checkbox", "Missing Image", MessageBoxButtons.OK);
			}
			else
			{
				// Get path to image to be used as a watermark 
				Bitmap wmBmp = new Bitmap(this.inWatermarkImagePath.Text.Trim());

				// Set the alpha from the trackbar value
				int alpha = Convert.ToInt32((100 - this.TrackBar1.Value * 10) / 100.0 * 255);

				// Determine the position of the watermark on the image
				int x = 0;
				int y = 0;
				switch (this.wmImagePlacement)
				{
					case WatermarkPlacement.TopLeft:
						x = 0;
						y = 0;

						break;
					case WatermarkPlacement.TopCenter:
						x = Convert.ToInt32((resultBm.Width - wmBmp.Width) / 2.0);
						y = 0;

						break;
					case WatermarkPlacement.TopRight:
						x = resultBm.Width - wmBmp.Width;
						y = 0;

						break;
					case WatermarkPlacement.MiddleLeft:
						x = 0;
						y = Convert.ToInt32((resultBm.Height - wmBmp.Height) / 2.0);

						break;
					case WatermarkPlacement.MiddleCenter:
						x = Convert.ToInt32((resultBm.Width - wmBmp.Width) / 2.0);
						y = Convert.ToInt32((resultBm.Height - wmBmp.Height) / 2.0);

						break;
					case WatermarkPlacement.MiddleRight:
						x = resultBm.Width - wmBmp.Width;
						y = Convert.ToInt32((resultBm.Height - wmBmp.Height) / 2.0);

						break;
					case WatermarkPlacement.BottomCenter:
						x = Convert.ToInt32((resultBm.Width - wmBmp.Width) / 2.0);
						y = resultBm.Height - wmBmp.Height;

						break;
					case WatermarkPlacement.BottomLeft:
						x = 0;
						y = resultBm.Height - wmBmp.Height;

						break;
					case WatermarkPlacement.BottomRight:
						x = resultBm.Width - wmBmp.Width;
						y = resultBm.Height - wmBmp.Height;
						break;
				}

				// Loop through each pixel and set the alpha for that pixel then reset it into the image
				Color clr = new Color();
				try
				{
					for (int py = 0; py < wmBmp.Height; py++)
					{
						for (int px = 0; px < wmBmp.Width; px++)
						{
							clr = wmBmp.GetPixel(px, py);
							wmBmp.SetPixel(px, py, Color.FromArgb(alpha, clr.R, clr.G, clr.B));
						}
					}

				}
				catch (InvalidOperationException ex)
				{
					MessageBox.Show("Oops! The image you selected for a watermark is causing problems. Try another image or convert that image to another image type, like .BMP or .JPG", "Problem with the image you selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return resultBm;
				}

				// Set the watermark's transparent color.
				wmBmp.MakeTransparent(wmBmp.GetPixel(0, 0));

				// Copy onto the result image.
				Graphics gr = Graphics.FromImage(resultBm);
				gr.DrawImage(wmBmp, x, y);

				wmBmp.Dispose();

			}

			return resultBm;
		}

		private Bitmap DrawTextWatermark(Bitmap bmp, string strWatermark)
		{
			// http://www.codeproject.com/KB/GDI-plus/TransparentImageWatermark.aspx

			// generate a graphics canvas from the bmp to measure the string
			Graphics canvas = Graphics.FromImage(bmp);

			// Get size of string using the text and the styling applied
			SizeF size = canvas.MeasureString(strWatermark, this.style);

			// Get alpha from trackbar value
			int alpha = Convert.ToInt32((100 - this.TrackBar1.Value * 10) / 100.0 * 255);

			// Determine where to put the watermark on the image
			int x = 0;
			int y = 0;

			switch (this.wmTextPlacement)
			{
				case WatermarkPlacement.TopLeft:
					x = 0;
					y = 0;

					break;
				case WatermarkPlacement.TopCenter:
					x = Convert.ToInt32((bmp.Width - size.Width) / 2.0);
					y = 0;

					break;
				case WatermarkPlacement.TopRight:
					x = (int) (bmp.Width - size.Width);
					y = 0;

					break;
				case WatermarkPlacement.MiddleLeft:
					x = 0;
					y = Convert.ToInt32((bmp.Height - size.Height) / 2.0);

					break;
				case WatermarkPlacement.MiddleCenter:
					x = Convert.ToInt32((bmp.Width - size.Width) / 2.0);
					y = Convert.ToInt32((bmp.Height - size.Height) / 2.0);

					break;
				case WatermarkPlacement.MiddleRight:
					x = (int) (bmp.Width - size.Width);
					y = Convert.ToInt32((bmp.Height - size.Height) / 2.0);

					break;
				case WatermarkPlacement.BottomCenter:
					x = Convert.ToInt32((bmp.Width - size.Width) / 2.0);
					y = (int) (bmp.Height - size.Height);

					break;
				case WatermarkPlacement.BottomLeft:
					x = 0;
					y = (int) (bmp.Height - size.Height);

					break;
				case WatermarkPlacement.BottomRight:
					x = (int) (bmp.Width - size.Width);
					y = (int) (bmp.Height - size.Height);
					break;
			}


			// Draw the watermark string onto the Bitmap:
			canvas.DrawString(strWatermark, this.style, new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)), x + 2, y + 2);
			canvas.DrawString(strWatermark, this.style, new SolidBrush(Color.FromArgb(alpha, this.wmColor.R, this.wmColor.G, this.wmColor.B)), x, y);

			return bmp;
		}

		private void btnPreview_Click(object sender, EventArgs e)
		{
			if (this.jsn != null)
			{
			    this.jsn = null;
			}

			if (this.copyrightMode == CopyrightModeType.Individual)
			{
			    this.jsn = CopyImage(this.txtPath.Text.Trim());
				if (this.jsn.PicData.Length > 0)
				{
					System.IO.MemoryStream ms = new System.IO.MemoryStream(this.jsn.PicData);
					Bitmap bmp = new Bitmap(ms);
					PreviewImage(bmp);
				}
				else
				{
					MessageBox.Show("Select an image to watermark before clicking preview", "Missing Image", MessageBoxButtons.OK);
				}
			}
			else
			{

				// Get first image in list of images
				if (this.txtPath.Text.Trim().Length > 0)
				{
					if (System.IO.Directory.Exists(this.txtPath.Text.Trim()))
					{
						if (GetFirstImageInFolder(this.txtPath.Text.Trim()).Length == 0)
						{
							// No images found
							MessageBox.Show("Could not find any images in the folder you selected, please select another and try again.", "Missing Images", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
						    this.jsn = CopyImage(GetFirstImageInFolder(this.txtPath.Text.Trim()));
							System.IO.MemoryStream ms = new System.IO.MemoryStream(this.jsn.PicData);
							Bitmap bmp = new Bitmap(ms);
							PreviewImage(bmp);
						}
					}
				}

			}

		}

		private string GetFirstImageInFolder(string path)
		{
			string s = string.Empty;

			// Get list of images in the folder and then check for types
			string[] str = System.IO.Directory.GetFiles(path, "*.jpg");

			if (str.Length == 0)
			{
				str = System.IO.Directory.GetFiles(path, "*.gif");
			}

			if (str.Length == 0)
			{
				str = System.IO.Directory.GetFiles(path, "*.png");
			}

			if (str.Length == 0)
			{
				str = System.IO.Directory.GetFiles(path, "*.bmp");
			}

			if (str.Length == 0)
			{
				str = System.IO.Directory.GetFiles(path, "*.tif");
			}

			if (str.Length == 0)
			{
				str = System.IO.Directory.GetFiles(path, "*.exif");
			}

			if (str.Length > 0)
			{
				s = str[0];
			}

			return s;
		}

		private void PreviewImage(Bitmap bmp)
		{

			if (this.chkImageWatermark.Checked)
			{
				if (this.lstWMImagePlacement.SelectedItem == null)
				{
					MessageBox.Show("Please select a watermark placement from the drop down list before continuing.", "Missing watermark placement", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				SelectWmImagePlacement();
				bmp = DrawImageWatermark(bmp);
			}

			if (this.chkWatermark.Checked)
			{
				if (this.lstWMTextPlacement.SelectedItem == null)
				{
					MessageBox.Show("Please select a watermark placement from the drop down list before continuing.", "Missing watermark placement", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				SelectWmTextPlacement();
				bmp = DrawTextWatermark(bmp, this.inWatermark.Text.Trim());
			}

			ImagePreview frm = new ImagePreview();
			frm.BMP = bmp;
			frm.ShowDialog();

		}

		private void btnStartProcessing_Click(object sender, EventArgs e)
		{

			if (this.jsn == null)
			{
				if (this.copyrightMode == CopyrightModeType.Individual)
				{
					MessageBox.Show("Select an image before choosing the save button", "Missing Image", MessageBoxButtons.OK);
					return;
				}
			}

			if (this.chkImageWatermark.Checked && this.lstWMImagePlacement.SelectedItem == null)
			{
				MessageBox.Show("Please select a watermark placement from the drop down list before continuing.", "Missing watermark placement", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (this.chkWatermark.Checked && this.lstWMTextPlacement.SelectedItem == null)
			{
				MessageBox.Show("Please select a watermark placement from the drop down list before continuing.", "Missing watermark placement", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (this.copyrightMode == CopyrightModeType.Individual)
			{
				if (this.jsn != null)
				{
				    this.jsn = null;
				}

			    this.jsn = CopyImage(this.txtPath.Text.Trim());
			    this.lblCurrentImage.Text = this.jsn.FileName;
				System.IO.MemoryStream ms = new System.IO.MemoryStream(this.jsn.PicData);
				Bitmap bmp = new Bitmap(ms);
			    this.PictureBox1.Image = bmp;

				SaveImage(bmp, string.Concat(new[] {this.txtSavePath.Text.Trim(), "\\", this.jsn.FileName}));
				LoadImage(this.txtPath.Text.Trim());
				ProcessImage();
				MessageBox.Show("Image Data Saved", "Saved", MessageBoxButtons.OK);

			}
			else
			{
				if (System.IO.Directory.Exists(this.txtPath.Text.Trim()) == false)
				{
					MessageBox.Show("Please locate the folder of images you would like to watermark", "Missing image path", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (System.IO.Directory.Exists(this.txtSavePath.Text) == false)
				{
					MessageBox.Show("Please specify where you would like to save your watermarked images.", "Missing image path", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

			    this.imageCount = 0;

				// Get the count of images to process
				GetImageCountToProcess();
			    this.lblImagesToProcess.Text = this.imageCount.ToString();

				// Process images in selected folder
				ProcessFiles(this.txtPath.Text.Trim());

				// Now process sub folders if user selected that option.
				if (this.chkSubDirectories.Checked)
				{
					ProcessMultipleImages(this.txtPath.Text.Trim());
				}

				MessageBox.Show(this.fileCount + " image(s) watermarked", "Finished", MessageBoxButtons.OK);
			}

		}

		private void GetImageCountToProcess()
		{
			string[] str = System.IO.Directory.GetFiles(this.txtPath.Text.Trim());
			foreach (string s in str)
			{
				System.IO.FileInfo fi = new System.IO.FileInfo(s);
				if (this.fileTypes.Contains(fi.Extension.ToLowerInvariant()))
				{
				    this.imageCount += 1;
				}
			}

			if (this.chkSubDirectories.Checked)
			{
				GetSubImageCountToProcess(this.txtPath.Text.Trim());
			}
		}

		private void GetSubImageCountToProcess(string path)
		{
			foreach (string d in System.IO.Directory.GetDirectories(path))
			{
				string[] str = System.IO.Directory.GetFiles(d);
				foreach (string s in str)
				{
					System.IO.FileInfo fi = new System.IO.FileInfo(s);
					if (this.fileTypes.Contains(fi.Extension.ToLowerInvariant()))
					{
					    this.imageCount += 1;
					}
				}
				GetSubImageCountToProcess(d);
			}
		}

		private void ProcessMultipleImages(string path)
		{
			// TODO: Uncomment logic for unregistered software.

			if (System.IO.Directory.Exists(path))
			{
				foreach (string d in System.IO.Directory.GetDirectories(path))
				{
					System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(d);
				    this.currentDirectory = path.Replace(this.txtPath.Text.Trim(), "") + "\\" + di.Name;
					System.IO.Directory.CreateDirectory(this.txtSavePath.Text.Trim() + "\\" + this.currentDirectory);
					ProcessFiles(d);
					ProcessMultipleImages(d);
				}
			}
		}

		private void ProcessFiles(string dir)
		{
			string[] str = System.IO.Directory.GetFiles(dir);
			foreach (string s in str)
			{

				if (this.jsn != null)
				{
				    this.jsn = null;
				}

				System.IO.FileInfo fi = new System.IO.FileInfo(s);

				if (this.fileTypes.Contains(fi.Extension.ToLowerInvariant()))
				{
				    this.jsn = CopyImage(s);
				    this.lblCurrentImage.Text = this.jsn.FileName;
					System.IO.MemoryStream ms = new System.IO.MemoryStream(this.jsn.PicData);
					Bitmap bmp = new Bitmap(ms);
				    this.PictureBox1.Image = bmp;
					Application.DoEvents();
					SaveImage(bmp, string.Concat(new[] {this.txtSavePath.Text.Trim(), "\\", this.currentDirectory, "\\", fi.Name}));
				}
			}

		}

		private void SaveImage(Bitmap bmp, string path)
		{
			if (bmp.GetFrameCount(new System.Drawing.Imaging.FrameDimension(bmp.FrameDimensionsList[0])) > 1)
			{
				return;
			}

			if (this.chkImageWatermark.Checked)
			{
				SelectWmImagePlacement();
				bmp = DrawImageWatermark(bmp);
			}

			if (this.chkWatermark.Checked)
			{
				SelectWmTextPlacement();
				bmp = DrawTextWatermark(bmp, this.inWatermark.Text.Trim());
			}

			switch (this.jsn.FileType.ToLowerInvariant())
			{
				case ".bmp":
					bmp.Save(path + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
					break;
				case ".exif":
					bmp.Save(path + ".exif", System.Drawing.Imaging.ImageFormat.Exif);
					break;
				case ".gif":
					bmp.Save(path + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
					break;
				case ".jpg":
					bmp.Save(path + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
					break;
				case ".png":
					bmp.Save(path + ".png", System.Drawing.Imaging.ImageFormat.Png);
					break;
				case ".tif":
					bmp.Save(path + ".tif", System.Drawing.Imaging.ImageFormat.Tiff);
					break;
			}

		    this.fileCount += 1;
		    this.ProgressBar1.Value = Convert.ToInt32(this.fileCount / (double) this.imageCount * 100);
			ProcessImage();
			bmp.Dispose();
		}

		private void btnStyleText_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dr = this.FontDialog1.ShowDialog();

				if (dr == DialogResult.OK)
				{
					FontStyle fs;

					switch (this.FontDialog1.Font.Style)
					{
						case FontStyle.Regular:
							fs = FontStyle.Regular;
							break;
						case FontStyle.Italic:
							fs = FontStyle.Italic;
							break;
						case FontStyle.Bold:
							fs = FontStyle.Bold;
							break;
						default:
							fs = FontStyle.Regular;
							break;
					}

					if (this.FontDialog1.Font.Underline)
					{
						fs = FontStyle.Underline;
					}

					if (this.FontDialog1.Font.Strikeout)
					{
						fs = FontStyle.Strikeout;
					}

				    this.style = new Font(this.FontDialog1.Font.Name, this.FontDialog1.Font.Size, fs);

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("The font you chose is not a True Type Font, please choose another font", "Incompatible font type", MessageBoxButtons.OK);
				btnStyleText_Click(sender, e);
			}
		}

		private void chkWatermark_CheckedChanged(object sender, EventArgs e)
		{
		    this.inWatermark.Enabled = this.chkWatermark.Checked;
		    this.btnStyleText.Enabled = this.chkWatermark.Checked;
		    this.grpTextWatermark.Enabled = this.chkWatermark.Checked;
		    this.btnChangeColor.Enabled = this.chkWatermark.Checked;
		    this.lstWMTextPlacement.Enabled = this.chkWatermark.Checked;

			if (this.chkWatermark.Checked == false)
			{
			    this.inWatermark.Text = "";
			}
		}

		private void TrackBar1_Scroll(object sender, EventArgs e)
		{
			int value = this.TrackBar1.Value * 10;
		    this.lblWmPercentage.Text = "Watermark Transparency " + value + "%:";
		}

		private void chkImageWatermark_CheckedChanged(object sender, EventArgs e)
		{
		    this.inWatermarkImagePath.Enabled = this.chkImageWatermark.Checked;
		    this.btnBrowseForImageWatermark.Enabled = this.chkImageWatermark.Checked;
		    this.grpImageWatermark.Enabled = this.chkImageWatermark.Checked;
		    this.lblWMImageHelp.Enabled = this.chkImageWatermark.Checked;
		    this.lstWMImagePlacement.Enabled = this.chkImageWatermark.Checked;

			if (this.chkImageWatermark.Checked == false)
			{
			    this.inWatermarkImagePath.Text = "";
			    this.lstWMImagePlacement.SelectedItem = null;
			}
		}

		private void btnBrowseForImageWatermark_Click(object sender, EventArgs e)
		{
		    this.OpenFileDialog1.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap Image (*.bmp)|*.bmp";
			DialogResult dr = this.OpenFileDialog1.ShowDialog();

			if (dr == DialogResult.OK)
			{
			    this.inWatermarkImagePath.Text = this.OpenFileDialog1.FileName;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			DialogResult dr = this.ColorDialog1.ShowDialog();

			if (dr == DialogResult.OK)
			{
			    this.wmColor = this.ColorDialog1.Color;
			}
		}

		private void btnSingleImage_Click(object sender, EventArgs e)
		{
		    this.copyrightMode = CopyrightModeType.Individual;
		    this.txtPath.Text = "";
		    this.TabControl1.SelectTab(1);
		}

		private void btnBatchMode_Click(object sender, EventArgs e)
		{
		    this.copyrightMode = CopyrightModeType.Multiple;
		    this.txtPath.Text = "";
		    this.TabControl1.SelectTab(1);
		}

		private void btnBackToStep1_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(0);
		}

		private void btnToStep2_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(1);
		}

		private void btnBackToStep2_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(1);
		}

		private void btnToStep3_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(2);
		}

		private void btnBackToStep3_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(2);
		}

		private void btnBackToStep4_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(3);
		}

		private void btnGoToStep4_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(3);
		}

		private void btnToStep5_Click(object sender, EventArgs e)
		{
		    this.TabControl1.SelectTab(4);
		}

		private void btnBackToStep1_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Back to Step 1");
		}

		private void btnToStep2_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Go to Step 2");
		}

		private void btnBackToStep2_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Back to Step 2");
		}

		private void btnToStep3_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Go to Step 3");
		}

		private void btnBackToStep3_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Back to Step 3");
		}

		private void btnToStep4_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Go to Step 4");
		}

		private void btnBackToStep4_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Back to Step 4");
		}

		private void btnToStep5_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Go to Step 5");
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			BrowseLocation(0);
		}

		private void btnBrowseDesktop_Click(object sender, EventArgs e)
		{
			BrowseLocation(Environment.SpecialFolder.DesktopDirectory);
		}

		private void btnBrowsePictures_Click(object sender, EventArgs e)
		{
			BrowseLocation(Environment.SpecialFolder.MyPictures);
		}

		private void btnBrowseDocuments_Click(object sender, EventArgs e)
		{
			BrowseLocation(Environment.SpecialFolder.MyDocuments);
		}

		private void btnBrowseCDrive_Click(object sender, EventArgs e)
		{
			BrowseLocation(Environment.SpecialFolder.MyComputer);
		}

		private void BrowseLocation(Environment.SpecialFolder startLocation = 0)
		{
			if (this.copyrightMode == CopyrightModeType.Individual)
			{
				if (startLocation != 0)
				{
				    this.OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(startLocation);
				}

				DialogResult dr = this.OpenFileDialog1.ShowDialog();
				if (dr == DialogResult.OK)
				{
				    this.txtPath.Text = this.OpenFileDialog1.FileName;
				}
			}
			else
			{
				if (startLocation != 0)
				{
				    this.FolderBrowserDialog1.RootFolder = startLocation;
				}

				DialogResult dr = this.FolderBrowserDialog1.ShowDialog();
				if (dr == DialogResult.OK)
				{
				    this.txtPath.Text = this.FolderBrowserDialog1.SelectedPath;
				}
			}
		}

		private void btnSaveDesktop_Click(object sender, EventArgs e)
		{
			SaveLocation(Environment.SpecialFolder.DesktopDirectory);
		}

		private void btnSavePictures_Click(object sender, EventArgs e)
		{
			SaveLocation(Environment.SpecialFolder.MyPictures);
		}

		private void btnSaveDocuments_Click(object sender, EventArgs e)
		{
			SaveLocation(Environment.SpecialFolder.MyDocuments);
		}

		private void btnSaveCDrive_Click(object sender, EventArgs e)
		{
			SaveLocation(Environment.SpecialFolder.MyComputer);
		}

		private void btnSaveOther_Click(object sender, EventArgs e)
		{
			SaveLocation(0);
		}

		private void SaveLocation(Environment.SpecialFolder savePath = 0)
		{
			if (savePath != 0)
			{
			    this.FolderBrowserDialog1.RootFolder = savePath;
			}

			DialogResult dr = this.FolderBrowserDialog1.ShowDialog();
			if (dr == DialogResult.OK)
			{
			    this.txtSavePath.Text = this.FolderBrowserDialog1.SelectedPath;
			}
		}

		private void SelectWmImagePlacement()
		{
			switch (this.lstWMImagePlacement.SelectedItem.ToString())
			{
				case "Top Left":
				    this.wmImagePlacement = WatermarkPlacement.TopLeft;
					break;
				case "Top Center":
				    this.wmImagePlacement = WatermarkPlacement.TopCenter;
					break;
				case "Top Right":
				    this.wmImagePlacement = WatermarkPlacement.TopRight;
					break;
				case "Middle Left":
				    this.wmImagePlacement = WatermarkPlacement.MiddleLeft;
					break;
				case "Middle Center":
				    this.wmImagePlacement = WatermarkPlacement.MiddleCenter;
					break;
				case "Middle Right":
				    this.wmImagePlacement = WatermarkPlacement.MiddleRight;
					break;
				case "Bottom Left":
				    this.wmImagePlacement = WatermarkPlacement.BottomLeft;
					break;
				case "Bottom Center":
				    this.wmImagePlacement = WatermarkPlacement.BottomCenter;
					break;
				case "Bottom Right":
				    this.wmImagePlacement = WatermarkPlacement.BottomRight;
					break;
			}
		}

		private void SelectWmTextPlacement()
		{
			switch (this.lstWMTextPlacement.SelectedItem.ToString())
			{
				case "Top Left":
				    this.wmTextPlacement = WatermarkPlacement.TopLeft;
					break;
				case "Top Center":
				    this.wmTextPlacement = WatermarkPlacement.TopCenter;
					break;
				case "Top Right":
				    this.wmTextPlacement = WatermarkPlacement.TopRight;
					break;
				case "Middle Left":
				    this.wmTextPlacement = WatermarkPlacement.MiddleLeft;
					break;
				case "Middle Center":
				    this.wmTextPlacement = WatermarkPlacement.MiddleCenter;
					break;
				case "Middle Right":
				    this.wmTextPlacement = WatermarkPlacement.MiddleRight;
					break;
				case "Bottom Left":
				    this.wmTextPlacement = WatermarkPlacement.BottomLeft;
					break;
				case "Bottom Center":
				    this.wmTextPlacement = WatermarkPlacement.BottomCenter;
					break;
				case "Bottom Right":
				    this.wmTextPlacement = WatermarkPlacement.BottomRight;
					break;
			}
		}

		private void btnBatchMode_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Process multiple images in a batch process");
		}

		private void btnSingleImage_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Process a single image at a time");
		}

		private void btnBrowse_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Browse for images to watermark");
		}

		private void btnBrowseDesktop_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Shortcut to desktop");
		}

		private void btnBrowsePictures_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Shortcut to pictures");
		}

		private void btnBrowseDocuments_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Shortcut to My Documents");
		}

		private void btnBrowseCDrive_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Shortcut to C:\\ Drive");
		}

		private void btnSaveBrowse_MouseEnter(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("Browse for a location to save watermarked images");
		}

		private void btnBackToStep3_MouseLeave(object sender, EventArgs e)
		{
			if (StatusMessageUpdate != null)
				StatusMessageUpdate("");
		}

		private void DisplayEndOfTrialMessage()
		{
			MessageBox.Show("Trial expired! Please purchase the full version to continue using this program." + Environment.NewLine + "Click the 'Unlock this Program' link on the main menu to purchase your copy today.", "Trial expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

	}
}