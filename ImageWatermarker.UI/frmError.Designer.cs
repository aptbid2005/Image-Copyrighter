using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImageWatermarkPro
{
	public partial class frmError : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.inEmail = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(136, 124);
			this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(176, 24);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Send Error";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(320, 124);
			this.Button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(133, 24);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Close Window";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(41, 96);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(89, 15);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "Email Address:";
			//
			//inEmail
			//
			this.inEmail.Location = new System.Drawing.Point(136, 92);
			this.inEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.inEmail.Name = "inEmail";
			this.inEmail.Size = new System.Drawing.Size(317, 21);
			this.inEmail.TabIndex = 0;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(462, 96);
			this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(61, 15);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "(Optional)";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(11, 14);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(542, 75);
			this.Label1.TabIndex = 11;
			this.Label1.Text = resources.GetString("Label1.Text");
			//
			//frmError
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 169);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.inEmail);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "frmError";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Error";
			this.ResumeLayout(false);
			this.PerformLayout();

			Button2.Click += new System.EventHandler(Button2_Click);
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox inEmail;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label1;

		private static frmError _DefaultInstance;
		public static frmError DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new frmError();

				return _DefaultInstance;
			}
		}
	}

}