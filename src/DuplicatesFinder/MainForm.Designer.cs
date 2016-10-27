// <copyright file="MainForm.designer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>8/7/2013 1:09:47 PM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

namespace DuplicatesFinder
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.pBar = new System.Windows.Forms.ToolStripProgressBar();
			this.txtLog = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.workingTimer = new System.Windows.Forms.Timer(this.components);
			this.progressTimer = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkDisplayDetails = new System.Windows.Forms.CheckBox();
			this.separator1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnOpenConsole = new System.Windows.Forms.Button();
			this.lblDuplicatesCount = new System.Windows.Forms.Label();
			this.lblSizeMatchCount = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			//
			// btnFind
			//
			this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFind.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Location = new System.Drawing.Point(471, 46);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(98, 30);
			this.btnFind.TabIndex = 0;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.OnFindClick);
			//
			// txtPath
			//
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPath.Location = new System.Drawing.Point(48, 13);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(487, 23);
			this.txtPath.TabIndex = 1;
			//
			// btnBrowse
			//
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.Location = new System.Drawing.Point(541, 12);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(28, 25);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = false;
			this.btnBrowse.Click += new System.EventHandler(this.OnBrowseClick);
			//
			// statusStrip1
			//
			this.statusStrip1.BackColor = System.Drawing.Color.White;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblProgress,
            this.toolStripStatusLabel1,
            this.pBar});
			this.statusStrip1.Location = new System.Drawing.Point(1, 338);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(582, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			//
			// lblStatus
			//
			this.lblStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(42, 17);
			this.lblStatus.Text = "Ready.";
			//
			// lblProgress
			//
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(0, 17);
			//
			// toolStripStatusLabel1
			//
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(525, 17);
			this.toolStripStatusLabel1.Spring = true;
			//
			// pBar
			//
			this.pBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.pBar.Name = "pBar";
			this.pBar.Size = new System.Drawing.Size(200, 16);
			this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pBar.Visible = false;
			//
			// txtLog
			//
			this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLog.Location = new System.Drawing.Point(1, 128);
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(582, 208);
			this.txtLog.TabIndex = 4;
			this.txtLog.Text = "";
			//
			// label1
			//
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Path";
			//
			// label2
			//
			this.label2.BackColor = System.Drawing.Color.Silver;
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.Location = new System.Drawing.Point(1, 337);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(582, 1);
			this.label2.TabIndex = 6;
			//
			// workingTimer
			//
			this.workingTimer.Interval = 1000;
			this.workingTimer.Tick += new System.EventHandler(this.OnWorkingTimerTick);
			//
			// progressTimer
			//
			this.progressTimer.Interval = 20;
			this.progressTimer.Tick += new System.EventHandler(this.OnProgressTimerTick);
			//
			// panel1
			//
			this.panel1.Controls.Add(this.chkDisplayDetails);
			this.panel1.Controls.Add(this.txtPath);
			this.panel1.Controls.Add(this.btnFind);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnBrowse);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(582, 95);
			this.panel1.TabIndex = 7;
			//
			// chkDisplayDetails
			//
			this.chkDisplayDetails.AutoSize = true;
			this.chkDisplayDetails.Checked = true;
			this.chkDisplayDetails.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDisplayDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkDisplayDetails.Location = new System.Drawing.Point(18, 44);
			this.chkDisplayDetails.Name = "chkDisplayDetails";
			this.chkDisplayDetails.Size = new System.Drawing.Size(110, 19);
			this.chkDisplayDetails.TabIndex = 6;
			this.chkDisplayDetails.Text = "Display Details";
			this.chkDisplayDetails.UseVisualStyleBackColor = true;
			//
			// separator1
			//
			this.separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
			this.separator1.Location = new System.Drawing.Point(1, 96);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(582, 1);
			this.separator1.TabIndex = 8;
			//
			// label3
			//
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.label3.Dock = System.Windows.Forms.DockStyle.Right;
			this.label3.Location = new System.Drawing.Point(583, 1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1, 360);
			this.label3.TabIndex = 9;
			//
			// label4
			//
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.label4.Dock = System.Windows.Forms.DockStyle.Left;
			this.label4.Location = new System.Drawing.Point(0, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(1, 360);
			this.label4.TabIndex = 10;
			//
			// label5
			//
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label5.Location = new System.Drawing.Point(1, 336);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(582, 1);
			this.label5.TabIndex = 11;
			//
			// label6
			//
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label6.Location = new System.Drawing.Point(1, 360);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(582, 1);
			this.label6.TabIndex = 12;
			//
			// label7
			//
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(584, 1);
			this.label7.TabIndex = 13;
			//
			// panel2
			//
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(155)))));
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Controls.Add(this.btnOpenConsole);
			this.panel2.Controls.Add(this.lblDuplicatesCount);
			this.panel2.Controls.Add(this.lblSizeMatchCount);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(1, 97);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(582, 31);
			this.panel2.TabIndex = 14;
			//
			// btnOpenConsole
			//
			this.btnOpenConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
			this.btnOpenConsole.BackgroundImage = global::DuplicatesFinder.Properties.Resources.ArrowUp;
			this.btnOpenConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnOpenConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenConsole.Location = new System.Drawing.Point(551, 3);
			this.btnOpenConsole.Name = "btnOpenConsole";
			this.btnOpenConsole.Size = new System.Drawing.Size(28, 25);
			this.btnOpenConsole.TabIndex = 15;
			this.btnOpenConsole.Text = "\r\n";
			this.btnOpenConsole.UseVisualStyleBackColor = false;
			this.btnOpenConsole.Click += new System.EventHandler(this.OnOpenConsoleClick);
			//
			// lblDuplicatesCount
			//
			this.lblDuplicatesCount.AutoSize = true;
			this.lblDuplicatesCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDuplicatesCount.ForeColor = System.Drawing.Color.White;
			this.lblDuplicatesCount.Location = new System.Drawing.Point(429, 6);
			this.lblDuplicatesCount.Name = "lblDuplicatesCount";
			this.lblDuplicatesCount.Size = new System.Drawing.Size(17, 19);
			this.lblDuplicatesCount.TabIndex = 18;
			this.lblDuplicatesCount.Text = "0";
			//
			// lblSizeMatchCount
			//
			this.lblSizeMatchCount.AutoSize = true;
			this.lblSizeMatchCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeMatchCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblSizeMatchCount.Location = new System.Drawing.Point(178, 8);
			this.lblSizeMatchCount.Name = "lblSizeMatchCount";
			this.lblSizeMatchCount.Size = new System.Drawing.Size(14, 15);
			this.lblSizeMatchCount.TabIndex = 17;
			this.lblSizeMatchCount.Text = "0";
			//
			// label9
			//
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(314, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 15);
			this.label9.TabIndex = 16;
			this.label9.Text = "Duplicates found";
			//
			// label8
			//
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(151, 15);
			this.label8.TabIndex = 15;
			this.label8.Text = "Possible Duplicates found";
			//
			// MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.separator1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.MinimumSize = new System.Drawing.Size(600, 192);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Duplicates Finder";
			this.Resize += new System.EventHandler(this.OnMainFormResize);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.RichTextBox txtLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer workingTimer;
		private System.Windows.Forms.ToolStripStatusLabel lblProgress;
		private System.Windows.Forms.ToolStripProgressBar pBar;
		private System.Windows.Forms.Timer progressTimer;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label separator1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblDuplicatesCount;
		private System.Windows.Forms.Label lblSizeMatchCount;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox chkDisplayDetails;
		private System.Windows.Forms.Button btnOpenConsole;
	}
}
