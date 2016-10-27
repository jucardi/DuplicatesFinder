// <copyright file="DuplicatesDisplayer.designer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>8/7/2013 2:57:24 PM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

namespace DuplicatesFinder
{
	partial class DuplicatesDisplayer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.line1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.treeView = new System.Windows.Forms.TreeView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblCount = new System.Windows.Forms.Label();
			this.line3 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pblStats = new System.Windows.Forms.Panel();
			this.lblHash = new System.Windows.Forms.Label();
			this.lblSize = new System.Windows.Forms.Label();
			this.lblHashTitle = new System.Windows.Forms.Label();
			this.lblSizeTitle = new System.Windows.Forms.Label();
			this.line2 = new System.Windows.Forms.Label();
			this.line4 = new System.Windows.Forms.Label();
			this.line5 = new System.Windows.Forms.Label();
			this.pnlPreview = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.pblStats.SuspendLayout();
			this.SuspendLayout();
			//
			// panel1
			//
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
			this.panel1.Controls.Add(this.line1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 457);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 54);
			this.panel1.TabIndex = 0;
			//
			// line1
			//
			this.line1.BackColor = System.Drawing.Color.Black;
			this.line1.Dock = System.Windows.Forms.DockStyle.Top;
			this.line1.Location = new System.Drawing.Point(0, 1);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(784, 1);
			this.line1.TabIndex = 2;
			//
			// label1
			//
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(784, 1);
			this.label1.TabIndex = 1;
			//
			// btnClose
			//
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(314, 10);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(156, 34);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.OnCloseClick);
			//
			// treeView
			//
			this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView.Location = new System.Drawing.Point(0, 0);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(561, 362);
			this.treeView.TabIndex = 1;
			this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnTreeViewAfterSelect);
			this.treeView.DoubleClick += new System.EventHandler(this.OnTreeViewDoubleClick);
			this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTreeViewKeyDown);
			//
			// panel2
			//
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(155)))));
			this.panel2.Controls.Add(this.lblCount);
			this.panel2.Controls.Add(this.line3);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 43);
			this.panel2.TabIndex = 2;
			//
			// lblCount
			//
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCount.ForeColor = System.Drawing.Color.White;
			this.lblCount.Location = new System.Drawing.Point(232, 10);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(0, 23);
			this.lblCount.TabIndex = 4;
			//
			// line3
			//
			this.line3.BackColor = System.Drawing.Color.Black;
			this.line3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.line3.Location = new System.Drawing.Point(0, 42);
			this.line3.Name = "line3";
			this.line3.Size = new System.Drawing.Size(784, 1);
			this.line3.TabIndex = 3;
			//
			// label3
			//
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(643, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "Preview";
			//
			// label2
			//
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(66, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Duplicate sets found";
			//
			// splitContainer1
			//
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 43);
			this.splitContainer1.Name = "splitContainer1";
			//
			// splitContainer1.Panel1
			//
			this.splitContainer1.Panel1.Controls.Add(this.treeView);
			this.splitContainer1.Panel1.Controls.Add(this.pblStats);
			this.splitContainer1.Panel1.Controls.Add(this.line4);
			//
			// splitContainer1.Panel2
			//
			this.splitContainer1.Panel2.Controls.Add(this.line5);
			this.splitContainer1.Panel2.Controls.Add(this.pnlPreview);
			this.splitContainer1.Size = new System.Drawing.Size(784, 414);
			this.splitContainer1.SplitterDistance = 562;
			this.splitContainer1.TabIndex = 3;
			//
			// pblStats
			//
			this.pblStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.pblStats.Controls.Add(this.lblHash);
			this.pblStats.Controls.Add(this.lblSize);
			this.pblStats.Controls.Add(this.lblHashTitle);
			this.pblStats.Controls.Add(this.lblSizeTitle);
			this.pblStats.Controls.Add(this.line2);
			this.pblStats.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pblStats.Location = new System.Drawing.Point(0, 362);
			this.pblStats.Name = "pblStats";
			this.pblStats.Size = new System.Drawing.Size(561, 52);
			this.pblStats.TabIndex = 2;
			//
			// lblHash
			//
			this.lblHash.AutoSize = true;
			this.lblHash.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHash.Location = new System.Drawing.Point(69, 29);
			this.lblHash.Name = "lblHash";
			this.lblHash.Size = new System.Drawing.Size(0, 15);
			this.lblHash.TabIndex = 7;
			//
			// lblSize
			//
			this.lblSize.AutoSize = true;
			this.lblSize.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSize.Location = new System.Drawing.Point(69, 9);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(0, 15);
			this.lblSize.TabIndex = 6;
			//
			// lblHashTitle
			//
			this.lblHashTitle.AutoSize = true;
			this.lblHashTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHashTitle.Location = new System.Drawing.Point(13, 29);
			this.lblHashTitle.Name = "lblHashTitle";
			this.lblHashTitle.Size = new System.Drawing.Size(33, 15);
			this.lblHashTitle.TabIndex = 5;
			this.lblHashTitle.Text = "Hash";
			//
			// lblSizeTitle
			//
			this.lblSizeTitle.AutoSize = true;
			this.lblSizeTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeTitle.Location = new System.Drawing.Point(13, 9);
			this.lblSizeTitle.Name = "lblSizeTitle";
			this.lblSizeTitle.Size = new System.Drawing.Size(28, 15);
			this.lblSizeTitle.TabIndex = 4;
			this.lblSizeTitle.Text = "Size";
			//
			// line2
			//
			this.line2.BackColor = System.Drawing.Color.Black;
			this.line2.Dock = System.Windows.Forms.DockStyle.Top;
			this.line2.Location = new System.Drawing.Point(0, 0);
			this.line2.Name = "line2";
			this.line2.Size = new System.Drawing.Size(561, 1);
			this.line2.TabIndex = 3;
			//
			// line4
			//
			this.line4.BackColor = System.Drawing.Color.Black;
			this.line4.Dock = System.Windows.Forms.DockStyle.Right;
			this.line4.Location = new System.Drawing.Point(561, 0);
			this.line4.Name = "line4";
			this.line4.Size = new System.Drawing.Size(1, 414);
			this.line4.TabIndex = 4;
			//
			// line5
			//
			this.line5.BackColor = System.Drawing.Color.Black;
			this.line5.Dock = System.Windows.Forms.DockStyle.Left;
			this.line5.Location = new System.Drawing.Point(0, 0);
			this.line5.Name = "line5";
			this.line5.Size = new System.Drawing.Size(1, 414);
			this.line5.TabIndex = 5;
			//
			// pnlPreview
			//
			this.pnlPreview.BackColor = System.Drawing.Color.White;
			this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPreview.Location = new System.Drawing.Point(0, 0);
			this.pnlPreview.Name = "pnlPreview";
			this.pnlPreview.Size = new System.Drawing.Size(218, 414);
			this.pnlPreview.TabIndex = 0;
			//
			// DuplicatesDisplayer
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 511);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "DuplicatesDisplayer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Results";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.pblStats.ResumeLayout(false);
			this.pblStats.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel pnlPreview;
		private System.Windows.Forms.Label line1;
		private System.Windows.Forms.Label line3;
		private System.Windows.Forms.Panel pblStats;
		private System.Windows.Forms.Label line2;
		private System.Windows.Forms.Label line4;
		private System.Windows.Forms.Label lblHash;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.Label lblHashTitle;
		private System.Windows.Forms.Label lblSizeTitle;
		private System.Windows.Forms.Label line5;
		private System.Windows.Forms.Label lblCount;
	}
}
