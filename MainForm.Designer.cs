/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012/10/31
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EnvironmentVariableEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.btnScan = new System.Windows.Forms.Button();
			this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BackColor = System.Drawing.Color.Black;
			this.checkedListBox1.ForeColor = System.Drawing.Color.Lime;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.HorizontalScrollbar = true;
			this.checkedListBox1.Location = new System.Drawing.Point(12, 33);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.ScrollAlwaysVisible = true;
			this.checkedListBox1.Size = new System.Drawing.Size(490, 116);
			this.checkedListBox1.TabIndex = 0;
			// 
			// btnScan
			// 
			this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnScan.ForeColor = System.Drawing.Color.Orange;
			this.btnScan.Location = new System.Drawing.Point(11, 296);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(75, 23);
			this.btnScan.TabIndex = 1;
			this.btnScan.Text = "Scan";
			this.btnScan.UseVisualStyleBackColor = true;
			this.btnScan.Click += new System.EventHandler(this.BtnScanClick);
			// 
			// checkedListBox2
			// 
			this.checkedListBox2.BackColor = System.Drawing.Color.Black;
			this.checkedListBox2.ForeColor = System.Drawing.Color.Lime;
			this.checkedListBox2.FormattingEnabled = true;
			this.checkedListBox2.HorizontalScrollbar = true;
			this.checkedListBox2.Location = new System.Drawing.Point(11, 174);
			this.checkedListBox2.Name = "checkedListBox2";
			this.checkedListBox2.ScrollAlwaysVisible = true;
			this.checkedListBox2.Size = new System.Drawing.Size(491, 116);
			this.checkedListBox2.TabIndex = 2;
			// 
			// btnExport
			// 
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.ForeColor = System.Drawing.Color.Orange;
			this.btnExport.Location = new System.Drawing.Point(94, 296);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 3;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
			// 
			// btnImport
			// 
			this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImport.ForeColor = System.Drawing.Color.Orange;
			this.btnImport.Location = new System.Drawing.Point(177, 296);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 4;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.BtnImportClick);
			// 
			// btnEdit
			// 
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.ForeColor = System.Drawing.Color.Orange;
			this.btnEdit.Location = new System.Drawing.Point(343, 296);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.ForeColor = System.Drawing.Color.Orange;
			this.btnDelete.Location = new System.Drawing.Point(426, 296);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Black;
			this.textBox1.ForeColor = System.Drawing.Color.Lime;
			this.textBox1.Location = new System.Drawing.Point(11, 326);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(491, 53);
			this.textBox1.TabIndex = 7;
			this.textBox1.WordWrap = false;
			// 
			// btnNew
			// 
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.ForeColor = System.Drawing.Color.Orange;
			this.btnNew.Location = new System.Drawing.Point(260, 296);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 8;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.BtnNewClick);
			// 
			// linkLabel1
			// 
			this.linkLabel1.ForeColor = System.Drawing.Color.Orange;
			this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
			this.linkLabel1.Location = new System.Drawing.Point(11, 384);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(158, 23);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Visit My Blog";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Orange;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "User Variables:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Orange;
			this.label2.Location = new System.Drawing.Point(12, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 19);
			this.label2.TabIndex = 11;
			this.label2.Text = "Machine Variables:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(515, 412);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.checkedListBox2);
			this.Controls.Add(this.btnScan);
			this.Controls.Add(this.checkedListBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EnvironmentVariableEditor";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.CheckedListBox checkedListBox2;
		private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
	}
}
