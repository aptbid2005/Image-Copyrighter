using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImageCopyrightCtrl
{
public partial class UserControl1 : System.Windows.Forms.UserControl
	{
		//UserControl1 overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.btnToStep2 = new System.Windows.Forms.Button();
			this.grpbox1 = new System.Windows.Forms.GroupBox();
			this.btnBatchMode = new System.Windows.Forms.Button();
			this.Label19 = new System.Windows.Forms.Label();
			this.btnSingleImage = new System.Windows.Forms.Button();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.btnToStep3 = new System.Windows.Forms.Button();
			this.btnBackToStep1 = new System.Windows.Forms.Button();
			this.grpbox2 = new System.Windows.Forms.GroupBox();
			this.btnBrowseCDrive = new System.Windows.Forms.Button();
			this.btnBrowseDocuments = new System.Windows.Forms.Button();
			this.btnBrowsePictures = new System.Windows.Forms.Button();
			this.btnBrowseDesktop = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.btnGoToStep4 = new System.Windows.Forms.Button();
			this.btnBackToStep2 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSaveCDrive = new System.Windows.Forms.Button();
			this.btnSaveDocuments = new System.Windows.Forms.Button();
			this.btnSavePictures = new System.Windows.Forms.Button();
			this.btnSaveDesktop = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtSavePath = new System.Windows.Forms.TextBox();
			this.btnSaveBrowse = new System.Windows.Forms.Button();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.chkSubDirectories = new System.Windows.Forms.CheckBox();
			this.lblWmPercentage = new System.Windows.Forms.Label();
			this.TrackBar1 = new System.Windows.Forms.TrackBar();
			this.chkWatermark = new System.Windows.Forms.CheckBox();
			this.chkImageWatermark = new System.Windows.Forms.CheckBox();
			this.grpImageWatermark = new System.Windows.Forms.GroupBox();
			this.lblWMImageHelp = new System.Windows.Forms.Label();
			this.lstWMImagePlacement = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnBrowseForImageWatermark = new System.Windows.Forms.Button();
			this.inWatermarkImagePath = new System.Windows.Forms.TextBox();
			this.grpTextWatermark = new System.Windows.Forms.GroupBox();
			this.lstWMTextPlacement = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnChangeColor = new System.Windows.Forms.Button();
			this.btnStyleText = new System.Windows.Forms.Button();
			this.inWatermark = new System.Windows.Forms.TextBox();
			this.btnBackToStep3 = new System.Windows.Forms.Button();
			this.btnToStep5 = new System.Windows.Forms.Button();
			this.btnPreview = new System.Windows.Forms.Button();
			this.TabPage5 = new System.Windows.Forms.TabPage();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.btnStartProcessing = new System.Windows.Forms.Button();
			this.lblImagesToProcess = new System.Windows.Forms.Label();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblCurrentImage = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.btnBackToStep4 = new System.Windows.Forms.Button();
			this.FontDialog1 = new System.Windows.Forms.FontDialog();
			this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.grpbox1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.grpbox2.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.TabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.TrackBar1).BeginInit();
			this.grpImageWatermark.SuspendLayout();
			this.grpTextWatermark.SuspendLayout();
			this.TabPage5.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Controls.Add(this.TabPage5);
			this.TabControl1.Location = new System.Drawing.Point(3, 3);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(605, 263);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.btnToStep2);
			this.TabPage1.Controls.Add(this.grpbox1);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(597, 237);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Step 1: Mode";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//btnToStep2
			//
			this.btnToStep2.Image = ImageCopyrightCtrl.Properties.Resources.rightarrow;
			this.btnToStep2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnToStep2.Location = new System.Drawing.Point(446, 200);
			this.btnToStep2.Name = "btnToStep2";
			this.btnToStep2.Size = new System.Drawing.Size(145, 23);
			this.btnToStep2.TabIndex = 3;
			this.btnToStep2.Text = "To Step 2";
			this.btnToStep2.UseVisualStyleBackColor = true;
			//
			//grpbox1
			//
			this.grpbox1.Controls.Add(this.btnBatchMode);
			this.grpbox1.Controls.Add(this.Label19);
			this.grpbox1.Controls.Add(this.btnSingleImage);
			this.grpbox1.Controls.Add(this.Label21);
			this.grpbox1.Controls.Add(this.Label20);
			this.grpbox1.ForeColor = System.Drawing.Color.Black;
			this.grpbox1.Location = new System.Drawing.Point(8, 6);
			this.grpbox1.Name = "grpbox1";
			this.grpbox1.Size = new System.Drawing.Size(581, 180);
			this.grpbox1.TabIndex = 2;
			this.grpbox1.TabStop = false;
			this.grpbox1.Text = "Please choose a Watermarkinging Mode:";
			//
			//btnBatchMode
			//
			this.btnBatchMode.BackColor = System.Drawing.Color.White;
			this.btnBatchMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBatchMode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBatchMode.Image = ImageCopyrightCtrl.Properties.Resources.multiple;
			this.btnBatchMode.Location = new System.Drawing.Point(24, 43);
			this.btnBatchMode.Name = "btnBatchMode";
			this.btnBatchMode.Size = new System.Drawing.Size(237, 128);
			this.btnBatchMode.TabIndex = 2;
			this.btnBatchMode.UseVisualStyleBackColor = false;
			//
			//Label19
			//
			this.Label19.BackColor = System.Drawing.Color.Black;
			this.Label19.Location = new System.Drawing.Point(290, 15);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(1, 150);
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Label19";
			//
			//btnSingleImage
			//
			this.btnSingleImage.BackColor = System.Drawing.Color.White;
			this.btnSingleImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSingleImage.Image = ImageCopyrightCtrl.Properties.Resources._single;
			this.btnSingleImage.Location = new System.Drawing.Point(320, 43);
			this.btnSingleImage.Name = "btnSingleImage";
			this.btnSingleImage.Size = new System.Drawing.Size(237, 128);
			this.btnSingleImage.TabIndex = 3;
			this.btnSingleImage.UseVisualStyleBackColor = false;
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label21.Location = new System.Drawing.Point(342, 27);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(186, 13);
			this.Label21.TabIndex = 0;
			this.Label21.Text = "Watermark a Single Image:";
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label20.Location = new System.Drawing.Point(49, 27);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(188, 13);
			this.Label20.TabIndex = 0;
			this.Label20.Text = "Watermark Mutiple Images:";
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.btnToStep3);
			this.TabPage2.Controls.Add(this.btnBackToStep1);
			this.TabPage2.Controls.Add(this.grpbox2);
			this.TabPage2.Controls.Add(this.Label4);
			this.TabPage2.Controls.Add(this.txtPath);
			this.TabPage2.Controls.Add(this.btnBrowse);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(597, 237);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Step 2: Browse For Images";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//btnToStep3
			//
			this.btnToStep3.Image = ImageCopyrightCtrl.Properties.Resources.rightarrow;
			this.btnToStep3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnToStep3.Location = new System.Drawing.Point(446, 200);
			this.btnToStep3.Name = "btnToStep3";
			this.btnToStep3.Size = new System.Drawing.Size(145, 23);
			this.btnToStep3.TabIndex = 19;
			this.btnToStep3.Text = "To Step 3";
			this.btnToStep3.UseVisualStyleBackColor = true;
			//
			//btnBackToStep1
			//
			this.btnBackToStep1.Image = ImageCopyrightCtrl.Properties.Resources.leftarrow;
			this.btnBackToStep1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackToStep1.Location = new System.Drawing.Point(6, 200);
			this.btnBackToStep1.Name = "btnBackToStep1";
			this.btnBackToStep1.Size = new System.Drawing.Size(145, 23);
			this.btnBackToStep1.TabIndex = 18;
			this.btnBackToStep1.Text = "Back to Step 1";
			this.btnBackToStep1.UseVisualStyleBackColor = true;
			//
			//grpbox2
			//
			this.grpbox2.Controls.Add(this.btnBrowseCDrive);
			this.grpbox2.Controls.Add(this.btnBrowseDocuments);
			this.grpbox2.Controls.Add(this.btnBrowsePictures);
			this.grpbox2.Controls.Add(this.btnBrowseDesktop);
			this.grpbox2.ForeColor = System.Drawing.Color.Black;
			this.grpbox2.Location = new System.Drawing.Point(68, 54);
			this.grpbox2.Name = "grpbox2";
			this.grpbox2.Size = new System.Drawing.Size(461, 140);
			this.grpbox2.TabIndex = 17;
			this.grpbox2.TabStop = false;
			this.grpbox2.Text = "Shortcuts";
			//
			//btnBrowseCDrive
			//
			this.btnBrowseCDrive.AutoSize = true;
			this.btnBrowseCDrive.BackColor = System.Drawing.Color.White;
			this.btnBrowseCDrive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowseCDrive.Image = ImageCopyrightCtrl.Properties.Resources.C_Drive;
			this.btnBrowseCDrive.Location = new System.Drawing.Point(343, 19);
			this.btnBrowseCDrive.Name = "btnBrowseCDrive";
			this.btnBrowseCDrive.Size = new System.Drawing.Size(106, 116);
			this.btnBrowseCDrive.TabIndex = 6;
			this.btnBrowseCDrive.UseVisualStyleBackColor = false;
			//
			//btnBrowseDocuments
			//
			this.btnBrowseDocuments.AutoSize = true;
			this.btnBrowseDocuments.BackColor = System.Drawing.Color.White;
			this.btnBrowseDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowseDocuments.Image = ImageCopyrightCtrl.Properties.Resources.documents;
			this.btnBrowseDocuments.Location = new System.Drawing.Point(231, 19);
			this.btnBrowseDocuments.Name = "btnBrowseDocuments";
			this.btnBrowseDocuments.Size = new System.Drawing.Size(106, 116);
			this.btnBrowseDocuments.TabIndex = 5;
			this.btnBrowseDocuments.UseVisualStyleBackColor = false;
			//
			//btnBrowsePictures
			//
			this.btnBrowsePictures.AutoSize = true;
			this.btnBrowsePictures.BackColor = System.Drawing.Color.White;
			this.btnBrowsePictures.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowsePictures.Image = ImageCopyrightCtrl.Properties.Resources.pictures;
			this.btnBrowsePictures.Location = new System.Drawing.Point(119, 19);
			this.btnBrowsePictures.Name = "btnBrowsePictures";
			this.btnBrowsePictures.Size = new System.Drawing.Size(106, 116);
			this.btnBrowsePictures.TabIndex = 4;
			this.btnBrowsePictures.UseVisualStyleBackColor = false;
			//
			//btnBrowseDesktop
			//
			this.btnBrowseDesktop.AutoSize = true;
			this.btnBrowseDesktop.BackColor = System.Drawing.Color.White;
			this.btnBrowseDesktop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBrowseDesktop.Image = ImageCopyrightCtrl.Properties.Resources.mydesktop;
			this.btnBrowseDesktop.Location = new System.Drawing.Point(7, 19);
			this.btnBrowseDesktop.Name = "btnBrowseDesktop";
			this.btnBrowseDesktop.Size = new System.Drawing.Size(106, 116);
			this.btnBrowseDesktop.TabIndex = 3;
			this.btnBrowseDesktop.UseVisualStyleBackColor = false;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(3, 10);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(265, 13);
			this.Label4.TabIndex = 16;
			this.Label4.Text = "Please locate the image(s) you would like to watermark";
			//
			//txtPath
			//
			this.txtPath.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtPath.Location = new System.Drawing.Point(6, 28);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(490, 20);
			this.txtPath.TabIndex = 14;
			//
			//btnBrowse
			//
			this.btnBrowse.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnBrowse.Image = ImageCopyrightCtrl.Properties.Resources.folderopen;
			this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnBrowse.Location = new System.Drawing.Point(502, 26);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(80, 23);
			this.btnBrowse.TabIndex = 15;
			this.btnBrowse.Text = "Browse  ";
			this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBrowse.UseVisualStyleBackColor = true;
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.btnGoToStep4);
			this.TabPage3.Controls.Add(this.btnBackToStep2);
			this.TabPage3.Controls.Add(this.GroupBox1);
			this.TabPage3.Controls.Add(this.Label3);
			this.TabPage3.Controls.Add(this.txtSavePath);
			this.TabPage3.Controls.Add(this.btnSaveBrowse);
			this.TabPage3.Location = new System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new System.Drawing.Size(597, 237);
			this.TabPage3.TabIndex = 5;
			this.TabPage3.Text = "Step 3: Save Location";
			this.TabPage3.UseVisualStyleBackColor = true;
			//
			//btnGoToStep4
			//
			this.btnGoToStep4.Image = ImageCopyrightCtrl.Properties.Resources.rightarrow;
			this.btnGoToStep4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGoToStep4.Location = new System.Drawing.Point(446, 200);
			this.btnGoToStep4.Name = "btnGoToStep4";
			this.btnGoToStep4.Size = new System.Drawing.Size(145, 23);
			this.btnGoToStep4.TabIndex = 25;
			this.btnGoToStep4.Text = "To Step 4";
			this.btnGoToStep4.UseVisualStyleBackColor = true;
			//
			//btnBackToStep2
			//
			this.btnBackToStep2.Image = ImageCopyrightCtrl.Properties.Resources.leftarrow;
			this.btnBackToStep2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackToStep2.Location = new System.Drawing.Point(6, 200);
			this.btnBackToStep2.Name = "btnBackToStep2";
			this.btnBackToStep2.Size = new System.Drawing.Size(145, 23);
			this.btnBackToStep2.TabIndex = 24;
			this.btnBackToStep2.Text = "Back to Step 2";
			this.btnBackToStep2.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.btnSaveCDrive);
			this.GroupBox1.Controls.Add(this.btnSaveDocuments);
			this.GroupBox1.Controls.Add(this.btnSavePictures);
			this.GroupBox1.Controls.Add(this.btnSaveDesktop);
			this.GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.GroupBox1.Location = new System.Drawing.Point(68, 54);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(460, 140);
			this.GroupBox1.TabIndex = 23;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Shortcuts";
			//
			//btnSaveCDrive
			//
			this.btnSaveCDrive.AutoSize = true;
			this.btnSaveCDrive.BackColor = System.Drawing.Color.White;
			this.btnSaveCDrive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveCDrive.Image = ImageCopyrightCtrl.Properties.Resources.C_Drive;
			this.btnSaveCDrive.Location = new System.Drawing.Point(343, 19);
			this.btnSaveCDrive.Name = "btnSaveCDrive";
			this.btnSaveCDrive.Size = new System.Drawing.Size(106, 116);
			this.btnSaveCDrive.TabIndex = 6;
			this.btnSaveCDrive.UseVisualStyleBackColor = false;
			//
			//btnSaveDocuments
			//
			this.btnSaveDocuments.AutoSize = true;
			this.btnSaveDocuments.BackColor = System.Drawing.Color.White;
			this.btnSaveDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveDocuments.Image = ImageCopyrightCtrl.Properties.Resources.documents;
			this.btnSaveDocuments.Location = new System.Drawing.Point(231, 19);
			this.btnSaveDocuments.Name = "btnSaveDocuments";
			this.btnSaveDocuments.Size = new System.Drawing.Size(106, 116);
			this.btnSaveDocuments.TabIndex = 5;
			this.btnSaveDocuments.UseVisualStyleBackColor = false;
			//
			//btnSavePictures
			//
			this.btnSavePictures.AutoSize = true;
			this.btnSavePictures.BackColor = System.Drawing.Color.White;
			this.btnSavePictures.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSavePictures.Image = ImageCopyrightCtrl.Properties.Resources.pictures;
			this.btnSavePictures.Location = new System.Drawing.Point(119, 19);
			this.btnSavePictures.Name = "btnSavePictures";
			this.btnSavePictures.Size = new System.Drawing.Size(106, 116);
			this.btnSavePictures.TabIndex = 4;
			this.btnSavePictures.UseVisualStyleBackColor = false;
			//
			//btnSaveDesktop
			//
			this.btnSaveDesktop.AutoSize = true;
			this.btnSaveDesktop.BackColor = System.Drawing.Color.White;
			this.btnSaveDesktop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveDesktop.Image = ImageCopyrightCtrl.Properties.Resources.mydesktop;
			this.btnSaveDesktop.Location = new System.Drawing.Point(7, 19);
			this.btnSaveDesktop.Name = "btnSaveDesktop";
			this.btnSaveDesktop.Size = new System.Drawing.Size(106, 116);
			this.btnSaveDesktop.TabIndex = 3;
			this.btnSaveDesktop.UseVisualStyleBackColor = false;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(3, 10);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(277, 13);
			this.Label3.TabIndex = 22;
			this.Label3.Text = "Where would you like to save the watermarked image(s)?";
			//
			//txtSavePath
			//
			this.txtSavePath.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtSavePath.Location = new System.Drawing.Point(6, 28);
			this.txtSavePath.Name = "txtSavePath";
			this.txtSavePath.Size = new System.Drawing.Size(490, 20);
			this.txtSavePath.TabIndex = 20;
			//
			//btnSaveBrowse
			//
			this.btnSaveBrowse.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnSaveBrowse.Image = ImageCopyrightCtrl.Properties.Resources.folderopen;
			this.btnSaveBrowse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnSaveBrowse.Location = new System.Drawing.Point(502, 26);
			this.btnSaveBrowse.Name = "btnSaveBrowse";
			this.btnSaveBrowse.Size = new System.Drawing.Size(80, 23);
			this.btnSaveBrowse.TabIndex = 21;
			this.btnSaveBrowse.Text = "Browse  ";
			this.btnSaveBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSaveBrowse.UseVisualStyleBackColor = true;
			//
			//TabPage4
			//
			this.TabPage4.Controls.Add(this.chkSubDirectories);
			this.TabPage4.Controls.Add(this.lblWmPercentage);
			this.TabPage4.Controls.Add(this.TrackBar1);
			this.TabPage4.Controls.Add(this.chkWatermark);
			this.TabPage4.Controls.Add(this.chkImageWatermark);
			this.TabPage4.Controls.Add(this.grpImageWatermark);
			this.TabPage4.Controls.Add(this.grpTextWatermark);
			this.TabPage4.Controls.Add(this.btnBackToStep3);
			this.TabPage4.Controls.Add(this.btnToStep5);
			this.TabPage4.Controls.Add(this.btnPreview);
			this.TabPage4.Location = new System.Drawing.Point(4, 22);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage4.Size = new System.Drawing.Size(597, 237);
			this.TabPage4.TabIndex = 3;
			this.TabPage4.Text = "Step 4: Settings";
			this.TabPage4.UseVisualStyleBackColor = true;
			//
			//chkSubDirectories
			//
			this.chkSubDirectories.AutoSize = true;
			this.chkSubDirectories.Location = new System.Drawing.Point(409, 161);
			this.chkSubDirectories.Name = "chkSubDirectories";
			this.chkSubDirectories.Size = new System.Drawing.Size(182, 17);
			this.chkSubDirectories.TabIndex = 29;
			this.chkSubDirectories.Text = "Process images in sub directories";
			this.chkSubDirectories.UseVisualStyleBackColor = true;
			//
			//lblWmPercentage
			//
			this.lblWmPercentage.AutoSize = true;
			this.lblWmPercentage.Location = new System.Drawing.Point(435, 15);
			this.lblWmPercentage.Name = "lblWmPercentage";
			this.lblWmPercentage.Size = new System.Drawing.Size(153, 13);
			this.lblWmPercentage.TabIndex = 22;
			this.lblWmPercentage.Text = "Watermark Transparency 50%:";
			//
			//TrackBar1
			//
			this.TrackBar1.BackColor = System.Drawing.Color.White;
			this.TrackBar1.LargeChange = 10;
			this.TrackBar1.Location = new System.Drawing.Point(438, 31);
			this.TrackBar1.Name = "TrackBar1";
			this.TrackBar1.Size = new System.Drawing.Size(153, 45);
			this.TrackBar1.SmallChange = 5;
			this.TrackBar1.TabIndex = 21;
			this.TrackBar1.Value = 5;
			//
			//chkWatermark
			//
			this.chkWatermark.AutoSize = true;
			this.chkWatermark.Location = new System.Drawing.Point(6, 8);
			this.chkWatermark.Name = "chkWatermark";
			this.chkWatermark.Size = new System.Drawing.Size(124, 17);
			this.chkWatermark.TabIndex = 26;
			this.chkWatermark.Text = "Add Text Watermark";
			this.chkWatermark.UseVisualStyleBackColor = true;
			//
			//chkImageWatermark
			//
			this.chkImageWatermark.AutoSize = true;
			this.chkImageWatermark.Location = new System.Drawing.Point(230, 8);
			this.chkImageWatermark.Name = "chkImageWatermark";
			this.chkImageWatermark.Size = new System.Drawing.Size(132, 17);
			this.chkImageWatermark.TabIndex = 25;
			this.chkImageWatermark.Text = "Add Image Watermark";
			this.chkImageWatermark.UseVisualStyleBackColor = true;
			//
			//grpImageWatermark
			//
			this.grpImageWatermark.Controls.Add(this.lblWMImageHelp);
			this.grpImageWatermark.Controls.Add(this.lstWMImagePlacement);
			this.grpImageWatermark.Controls.Add(this.Label2);
			this.grpImageWatermark.Controls.Add(this.btnBrowseForImageWatermark);
			this.grpImageWatermark.Controls.Add(this.inWatermarkImagePath);
			this.grpImageWatermark.Location = new System.Drawing.Point(230, 31);
			this.grpImageWatermark.Name = "grpImageWatermark";
			this.grpImageWatermark.Size = new System.Drawing.Size(202, 124);
			this.grpImageWatermark.TabIndex = 1;
			this.grpImageWatermark.TabStop = false;
			this.grpImageWatermark.Text = "Image Watermark";
			//
			//lblWMImageHelp
			//
			this.lblWMImageHelp.AutoSize = true;
			this.lblWMImageHelp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblWMImageHelp.Enabled = false;
			this.lblWMImageHelp.Image = ImageCopyrightCtrl.Properties.Resources.HelpMe;
			this.lblWMImageHelp.Location = new System.Drawing.Point(171, 48);
			this.lblWMImageHelp.MinimumSize = new System.Drawing.Size(20, 20);
			this.lblWMImageHelp.Name = "lblWMImageHelp";
			this.lblWMImageHelp.Size = new System.Drawing.Size(20, 20);
			this.lblWMImageHelp.TabIndex = 30;
			this.ToolTip1.SetToolTip(this.lblWMImageHelp, resources.GetString("lblWMImageHelp.ToolTip"));
			//
			//lstWMImagePlacement
			//
			this.lstWMImagePlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstWMImagePlacement.Enabled = false;
			this.lstWMImagePlacement.FormattingEnabled = true;
			this.lstWMImagePlacement.Items.AddRange(new object[] {"Top Left", "Top Center", "Top Right", "Middle Left", "Middle Center", "Middle Right", "Bottom Left", "Bottom Center", "Bottom Right"});
			this.lstWMImagePlacement.Location = new System.Drawing.Point(14, 92);
			this.lstWMImagePlacement.Name = "lstWMImagePlacement";
			this.lstWMImagePlacement.Size = new System.Drawing.Size(177, 21);
			this.lstWMImagePlacement.TabIndex = 29;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(11, 75);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(144, 13);
			this.Label2.TabIndex = 28;
			this.Label2.Text = "Image Watermark Placement";
			//
			//btnBrowseForImageWatermark
			//
			this.btnBrowseForImageWatermark.Enabled = false;
			this.btnBrowseForImageWatermark.Image = ImageCopyrightCtrl.Properties.Resources.folderopen;
			this.btnBrowseForImageWatermark.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnBrowseForImageWatermark.Location = new System.Drawing.Point(44, 44);
			this.btnBrowseForImageWatermark.Name = "btnBrowseForImageWatermark";
			this.btnBrowseForImageWatermark.Size = new System.Drawing.Size(121, 24);
			this.btnBrowseForImageWatermark.TabIndex = 27;
			this.btnBrowseForImageWatermark.Text = "Browse For Image";
			this.btnBrowseForImageWatermark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBrowseForImageWatermark.UseVisualStyleBackColor = true;
			//
			//inWatermarkImagePath
			//
			this.inWatermarkImagePath.Enabled = false;
			this.inWatermarkImagePath.Location = new System.Drawing.Point(14, 19);
			this.inWatermarkImagePath.Name = "inWatermarkImagePath";
			this.inWatermarkImagePath.Size = new System.Drawing.Size(177, 20);
			this.inWatermarkImagePath.TabIndex = 26;
			//
			//grpTextWatermark
			//
			this.grpTextWatermark.Controls.Add(this.lstWMTextPlacement);
			this.grpTextWatermark.Controls.Add(this.Label1);
			this.grpTextWatermark.Controls.Add(this.btnChangeColor);
			this.grpTextWatermark.Controls.Add(this.btnStyleText);
			this.grpTextWatermark.Controls.Add(this.inWatermark);
			this.grpTextWatermark.Location = new System.Drawing.Point(6, 31);
			this.grpTextWatermark.Name = "grpTextWatermark";
			this.grpTextWatermark.Size = new System.Drawing.Size(218, 124);
			this.grpTextWatermark.TabIndex = 0;
			this.grpTextWatermark.TabStop = false;
			this.grpTextWatermark.Text = "Text Watermark";
			//
			//lstWMTextPlacement
			//
			this.lstWMTextPlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstWMTextPlacement.Enabled = false;
			this.lstWMTextPlacement.FormattingEnabled = true;
			this.lstWMTextPlacement.Items.AddRange(new object[] {"Top Left", "Top Center", "Top Right", "Middle Left", "Middle Center", "Middle Right", "Bottom Left", "Bottom Center", "Bottom Right"});
			this.lstWMTextPlacement.Location = new System.Drawing.Point(12, 92);
			this.lstWMTextPlacement.Name = "lstWMTextPlacement";
			this.lstWMTextPlacement.Size = new System.Drawing.Size(197, 21);
			this.lstWMTextPlacement.TabIndex = 32;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(9, 75);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(136, 13);
			this.Label1.TabIndex = 31;
			this.Label1.Text = "Text Watermark Placement";
			//
			//btnChangeColor
			//
			this.btnChangeColor.Enabled = false;
			this.btnChangeColor.Image = ImageCopyrightCtrl.Properties.Resources.fontcolor;
			this.btnChangeColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChangeColor.Location = new System.Drawing.Point(12, 45);
			this.btnChangeColor.Name = "btnChangeColor";
			this.btnChangeColor.Size = new System.Drawing.Size(100, 23);
			this.btnChangeColor.TabIndex = 30;
			this.btnChangeColor.Text = "Change Color";
			this.btnChangeColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnChangeColor.UseVisualStyleBackColor = true;
			//
			//btnStyleText
			//
			this.btnStyleText.Enabled = false;
			this.btnStyleText.Image = ImageCopyrightCtrl.Properties.Resources.underline;
			this.btnStyleText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStyleText.Location = new System.Drawing.Point(118, 45);
			this.btnStyleText.Name = "btnStyleText";
			this.btnStyleText.Size = new System.Drawing.Size(91, 23);
			this.btnStyleText.TabIndex = 28;
			this.btnStyleText.Text = "Format Text";
			this.btnStyleText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnStyleText.UseVisualStyleBackColor = true;
			//
			//inWatermark
			//
			this.inWatermark.Enabled = false;
			this.inWatermark.Location = new System.Drawing.Point(12, 19);
			this.inWatermark.Name = "inWatermark";
			this.inWatermark.Size = new System.Drawing.Size(197, 20);
			this.inWatermark.TabIndex = 27;
			//
			//btnBackToStep3
			//
			this.btnBackToStep3.Image = ImageCopyrightCtrl.Properties.Resources.leftarrow;
			this.btnBackToStep3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackToStep3.Location = new System.Drawing.Point(6, 200);
			this.btnBackToStep3.Name = "btnBackToStep3";
			this.btnBackToStep3.Size = new System.Drawing.Size(145, 23);
			this.btnBackToStep3.TabIndex = 28;
			this.btnBackToStep3.Text = "Back to Step 3";
			this.btnBackToStep3.UseVisualStyleBackColor = true;
			//
			//btnToStep5
			//
			this.btnToStep5.Image = ImageCopyrightCtrl.Properties.Resources.rightarrow;
			this.btnToStep5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnToStep5.Location = new System.Drawing.Point(446, 200);
			this.btnToStep5.Name = "btnToStep5";
			this.btnToStep5.Size = new System.Drawing.Size(145, 23);
			this.btnToStep5.TabIndex = 27;
			this.btnToStep5.Text = "To Step 5";
			this.btnToStep5.UseVisualStyleBackColor = true;
			//
			//btnPreview
			//
			this.btnPreview.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnPreview.Image = ImageCopyrightCtrl.Properties.Resources.zoomORANGE;
			this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPreview.Location = new System.Drawing.Point(463, 76);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(131, 23);
			this.btnPreview.TabIndex = 23;
			this.btnPreview.Text = "Preview Settings   ";
			this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPreview.UseVisualStyleBackColor = true;
			//
			//TabPage5
			//
			this.TabPage5.Controls.Add(this.GroupBox3);
			this.TabPage5.Controls.Add(this.GroupBox2);
			this.TabPage5.Controls.Add(this.btnBackToStep4);
			this.TabPage5.Location = new System.Drawing.Point(4, 22);
			this.TabPage5.Name = "TabPage5";
			this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage5.Size = new System.Drawing.Size(597, 237);
			this.TabPage5.TabIndex = 4;
			this.TabPage5.Text = "Step 5: Process Images";
			this.TabPage5.UseVisualStyleBackColor = true;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.PictureBox1);
			this.GroupBox3.Location = new System.Drawing.Point(7, 7);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(229, 181);
			this.GroupBox3.TabIndex = 16;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Current Image";
			//
			//PictureBox1
			//
			this.PictureBox1.Location = new System.Drawing.Point(6, 19);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(217, 156);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 7;
			this.PictureBox1.TabStop = false;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.btnStartProcessing);
			this.GroupBox2.Controls.Add(this.lblImagesToProcess);
			this.GroupBox2.Controls.Add(this.ProgressBar1);
			this.GroupBox2.Controls.Add(this.lblCurrentImage);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Location = new System.Drawing.Point(242, 6);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(349, 182);
			this.GroupBox2.TabIndex = 15;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Process Details:";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(18, 61);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(76, 13);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "Current Image:";
			//
			//btnStartProcessing
			//
			this.btnStartProcessing.Image = ImageCopyrightCtrl.Properties.Resources.play;
			this.btnStartProcessing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStartProcessing.Location = new System.Drawing.Point(103, 126);
			this.btnStartProcessing.Name = "btnStartProcessing";
			this.btnStartProcessing.Size = new System.Drawing.Size(148, 23);
			this.btnStartProcessing.TabIndex = 12;
			this.btnStartProcessing.Text = "Start Processing";
			this.btnStartProcessing.UseVisualStyleBackColor = true;
			//
			//lblImagesToProcess
			//
			this.lblImagesToProcess.AutoSize = true;
			this.lblImagesToProcess.Location = new System.Drawing.Point(122, 33);
			this.lblImagesToProcess.Name = "lblImagesToProcess";
			this.lblImagesToProcess.Size = new System.Drawing.Size(0, 13);
			this.lblImagesToProcess.TabIndex = 14;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(21, 97);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(309, 23);
			this.ProgressBar1.TabIndex = 11;
			//
			//lblCurrentImage
			//
			this.lblCurrentImage.AutoSize = true;
			this.lblCurrentImage.Location = new System.Drawing.Point(100, 61);
			this.lblCurrentImage.Name = "lblCurrentImage";
			this.lblCurrentImage.Size = new System.Drawing.Size(0, 13);
			this.lblCurrentImage.TabIndex = 10;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(18, 33);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(97, 13);
			this.Label7.TabIndex = 13;
			this.Label7.Text = "Images to Process:";
			//
			//btnBackToStep4
			//
			this.btnBackToStep4.Image = ImageCopyrightCtrl.Properties.Resources.leftarrow;
			this.btnBackToStep4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackToStep4.Location = new System.Drawing.Point(6, 200);
			this.btnBackToStep4.Name = "btnBackToStep4";
			this.btnBackToStep4.Size = new System.Drawing.Size(145, 23);
			this.btnBackToStep4.TabIndex = 8;
			this.btnBackToStep4.Text = "Back to Step 4";
			this.btnBackToStep4.UseVisualStyleBackColor = true;
			//
			//FolderBrowserDialog1
			//
			this.FolderBrowserDialog1.Description = "Locate the images that you would like to watermark.";
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.Filter = "Images Files|*.jpg;*.gif;*.png;*.bmp;*.tif;*.exif";
			//
			//UserControl1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TabControl1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(616, 274);
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.grpbox1.ResumeLayout(false);
			this.grpbox1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.grpbox2.ResumeLayout(false);
			this.grpbox2.PerformLayout();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.TabPage4.ResumeLayout(false);
			this.TabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.TrackBar1).EndInit();
			this.grpImageWatermark.ResumeLayout(false);
			this.grpImageWatermark.PerformLayout();
			this.grpTextWatermark.ResumeLayout(false);
			this.grpTextWatermark.PerformLayout();
			this.TabPage5.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Load += new System.EventHandler(UserControl1_Load);
			btnPreview.Click += new System.EventHandler(btnPreview_Click);
			btnStartProcessing.Click += new System.EventHandler(btnStartProcessing_Click);
			btnStyleText.Click += new System.EventHandler(btnStyleText_Click);
			chkWatermark.CheckedChanged += new System.EventHandler(chkWatermark_CheckedChanged);
			TrackBar1.Scroll += new System.EventHandler(TrackBar1_Scroll);
			chkImageWatermark.CheckedChanged += new System.EventHandler(chkImageWatermark_CheckedChanged);
			btnBrowseForImageWatermark.Click += new System.EventHandler(btnBrowseForImageWatermark_Click);
			btnChangeColor.Click += new System.EventHandler(Button1_Click);
			btnSingleImage.Click += new System.EventHandler(btnSingleImage_Click);
			btnBatchMode.Click += new System.EventHandler(btnBatchMode_Click);
			btnBackToStep1.Click += new System.EventHandler(btnBackToStep1_Click);
			btnToStep2.Click += new System.EventHandler(btnToStep2_Click);
			btnBackToStep2.Click += new System.EventHandler(btnBackToStep2_Click);
			btnToStep3.Click += new System.EventHandler(btnToStep3_Click);
			btnBackToStep3.Click += new System.EventHandler(btnBackToStep3_Click);
			btnBackToStep4.Click += new System.EventHandler(btnBackToStep4_Click);
			btnGoToStep4.Click += new System.EventHandler(btnGoToStep4_Click);
			btnToStep5.Click += new System.EventHandler(btnToStep5_Click);
			btnBackToStep1.MouseEnter += new System.EventHandler(btnBackToStep1_MouseEnter);
			btnToStep2.MouseEnter += new System.EventHandler(btnToStep2_MouseEnter);
			btnBackToStep2.MouseEnter += new System.EventHandler(btnBackToStep2_MouseEnter);
			btnToStep3.MouseEnter += new System.EventHandler(btnToStep3_MouseEnter);
			btnBackToStep3.MouseEnter += new System.EventHandler(btnBackToStep3_MouseEnter);
			btnGoToStep4.MouseEnter += new System.EventHandler(btnToStep4_MouseEnter);
			btnBackToStep4.MouseEnter += new System.EventHandler(btnBackToStep4_MouseEnter);
			btnToStep5.MouseEnter += new System.EventHandler(btnToStep5_MouseEnter);
			btnBrowse.Click += new System.EventHandler(btnBrowse_Click);
			btnBrowseDesktop.Click += new System.EventHandler(btnBrowseDesktop_Click);
			btnBrowsePictures.Click += new System.EventHandler(btnBrowsePictures_Click);
			btnBrowseDocuments.Click += new System.EventHandler(btnBrowseDocuments_Click);
			btnBrowseCDrive.Click += new System.EventHandler(btnBrowseCDrive_Click);
			btnSaveDesktop.Click += new System.EventHandler(btnSaveDesktop_Click);
			btnSavePictures.Click += new System.EventHandler(btnSavePictures_Click);
			btnSaveDocuments.Click += new System.EventHandler(btnSaveDocuments_Click);
			btnSaveCDrive.Click += new System.EventHandler(btnSaveCDrive_Click);
			btnSaveBrowse.Click += new System.EventHandler(btnSaveOther_Click);
			btnBatchMode.MouseEnter += new System.EventHandler(btnBatchMode_MouseEnter);
			btnSingleImage.MouseEnter += new System.EventHandler(btnSingleImage_MouseEnter);
			btnBrowse.MouseEnter += new System.EventHandler(btnBrowse_MouseEnter);
			btnBrowseDesktop.MouseEnter += new System.EventHandler(btnBrowseDesktop_MouseEnter);
			btnSaveDesktop.MouseEnter += new System.EventHandler(btnBrowseDesktop_MouseEnter);
			btnBrowsePictures.MouseEnter += new System.EventHandler(btnBrowsePictures_MouseEnter);
			btnSavePictures.MouseEnter += new System.EventHandler(btnBrowsePictures_MouseEnter);
			btnBrowseDocuments.MouseEnter += new System.EventHandler(btnBrowseDocuments_MouseEnter);
			btnSaveDocuments.MouseEnter += new System.EventHandler(btnBrowseDocuments_MouseEnter);
			btnBrowseCDrive.MouseEnter += new System.EventHandler(btnBrowseCDrive_MouseEnter);
			btnSaveCDrive.MouseEnter += new System.EventHandler(btnBrowseCDrive_MouseEnter);
			btnSaveBrowse.MouseEnter += new System.EventHandler(btnSaveBrowse_MouseEnter);
			btnBackToStep1.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBackToStep2.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBackToStep3.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBackToStep4.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnToStep2.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnToStep3.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnGoToStep4.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnToStep5.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBatchMode.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnSingleImage.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBrowse.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBrowseDesktop.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnSaveDesktop.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBrowsePictures.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnSavePictures.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBrowseDocuments.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnSaveDocuments.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnBrowseCDrive.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnSaveCDrive.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
			btnSaveBrowse.MouseLeave += new System.EventHandler(btnBackToStep3_MouseLeave);
		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button btnBrowse;
		internal System.Windows.Forms.TextBox txtPath;
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.GroupBox grpImageWatermark;
		internal System.Windows.Forms.GroupBox grpTextWatermark;
		internal System.Windows.Forms.Button btnChangeColor;
		internal System.Windows.Forms.CheckBox chkWatermark;
		internal System.Windows.Forms.Button btnStyleText;
		internal System.Windows.Forms.TextBox inWatermark;
		internal System.Windows.Forms.Button btnBrowseForImageWatermark;
		internal System.Windows.Forms.TextBox inWatermarkImagePath;
		internal System.Windows.Forms.CheckBox chkImageWatermark;
		internal System.Windows.Forms.Label lblWmPercentage;
		internal System.Windows.Forms.TrackBar TrackBar1;
		internal System.Windows.Forms.TabPage TabPage5;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Button btnPreview;
		internal System.Windows.Forms.FontDialog FontDialog1;
		internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.ColorDialog ColorDialog1;
		internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
		internal System.Windows.Forms.GroupBox grpbox1;
		internal System.Windows.Forms.Button btnBatchMode;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Button btnSingleImage;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.GroupBox grpbox2;
		internal System.Windows.Forms.Button btnBrowseCDrive;
		internal System.Windows.Forms.Button btnBrowseDocuments;
		internal System.Windows.Forms.Button btnBrowsePictures;
		internal System.Windows.Forms.Button btnBrowseDesktop;
		internal System.Windows.Forms.ComboBox lstWMImagePlacement;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox lstWMTextPlacement;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnToStep2;
		internal System.Windows.Forms.Button btnToStep3;
		internal System.Windows.Forms.Button btnBackToStep1;
		internal System.Windows.Forms.Button btnBackToStep3;
		internal System.Windows.Forms.Button btnToStep5;
		internal System.Windows.Forms.Button btnBackToStep4;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.Button btnGoToStep4;
		internal System.Windows.Forms.Button btnBackToStep2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btnSaveCDrive;
		internal System.Windows.Forms.Button btnSaveDocuments;
		internal System.Windows.Forms.Button btnSavePictures;
		internal System.Windows.Forms.Button btnSaveDesktop;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button btnSaveBrowse;
		internal System.Windows.Forms.TextBox txtSavePath;
		internal System.Windows.Forms.CheckBox chkSubDirectories;
		internal System.Windows.Forms.Button btnStartProcessing;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal System.Windows.Forms.Label lblCurrentImage;
		internal System.Windows.Forms.Label Label5;

		public UserControl1()
		{

			// This call is required by the designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.

		}

		public UserControl1(string _RegKey)
		{
			Globals.RegKey = _RegKey;

			// This call is required by the designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.

		}
		internal System.Windows.Forms.Label lblWMImageHelp;
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label lblImagesToProcess;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.GroupBox GroupBox3;

	}
}