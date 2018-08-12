using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImageWatermarkPro
{
	public partial class frmMain : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.MenuStrip1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.HelpToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(734, 24);
			this.MenuStrip1.TabIndex = 4;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Image = ImageCopyrighter.UI.Properties.Resources.x;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			//
			//HelpToolStripMenuItem
			//
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AboutThisProgramToolStripMenuItem, this.ToolStripSeparator3});
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.HelpToolStripMenuItem.Text = "Help";
			//
			//AboutThisProgramToolStripMenuItem
			//
			this.AboutThisProgramToolStripMenuItem.Image = ImageCopyrighter.UI.Properties.Resources.root;
			this.AboutThisProgramToolStripMenuItem.Name = "AboutThisProgramToolStripMenuItem";
			this.AboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
			this.AboutThisProgramToolStripMenuItem.Text = "About this program";
			//
			//ToolStripSeparator3
			//
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			this.ToolStripSeparator3.Size = new System.Drawing.Size(215, 6);
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(215, 6);
			//
			//Panel1
			//
			this.Panel1.Location = new System.Drawing.Point(12, 27);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(710, 335);
			this.Panel1.TabIndex = 5;
			//
			//StatusStrip1
			//
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.lblMessage, this.ToolStripStatusLabel4});
			this.StatusStrip1.Location = new System.Drawing.Point(0, 365);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new System.Drawing.Size(734, 22);
			this.StatusStrip1.SizingGrip = false;
			this.StatusStrip1.TabIndex = 6;
			this.StatusStrip1.Text = "StatusStrip1";
			//
			//lblMessage
			//
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(0, 17);
			//
			//ToolStripStatusLabel4
			//
			this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
			this.ToolStripStatusLabel4.Size = new System.Drawing.Size(719, 17);
			this.ToolStripStatusLabel4.Spring = true;
			//
			//frmMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 387);
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.MenuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximumSize = new System.Drawing.Size(750, 425);
			this.MinimumSize = new System.Drawing.Size(750, 425);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			this.Load += new System.EventHandler(frmMain_Load);
			AboutThisProgramToolStripMenuItem.Click += new System.EventHandler(AboutThisProgramToolStripMenuItem_Click);
			ExitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItem_Click);
		}

		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutThisProgramToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel lblMessage;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;

	}

}