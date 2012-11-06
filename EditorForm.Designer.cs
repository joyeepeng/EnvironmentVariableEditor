/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012/10/31
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EnvironmentVariableEditor
{
	partial class EditorForm
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
			this.cbxTarget = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxKey = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxValue = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbxTarget
			// 
			this.cbxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTarget.FormattingEnabled = true;
			this.cbxTarget.Items.AddRange(new object[] {
									"User",
									"Machine"});
			this.cbxTarget.Location = new System.Drawing.Point(74, 14);
			this.cbxTarget.Name = "cbxTarget";
			this.cbxTarget.Size = new System.Drawing.Size(121, 20);
			this.cbxTarget.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Orange;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Target:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Orange;
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbxKey
			// 
			this.tbxKey.Location = new System.Drawing.Point(74, 41);
			this.tbxKey.Name = "tbxKey";
			this.tbxKey.Size = new System.Drawing.Size(121, 21);
			this.tbxKey.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Orange;
			this.label3.Location = new System.Drawing.Point(13, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Value:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbxValue
			// 
			this.tbxValue.BackColor = System.Drawing.Color.Black;
			this.tbxValue.ForeColor = System.Drawing.Color.Lime;
			this.tbxValue.Location = new System.Drawing.Point(13, 94);
			this.tbxValue.Multiline = true;
			this.tbxValue.Name = "tbxValue";
			this.tbxValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbxValue.Size = new System.Drawing.Size(293, 102);
			this.tbxValue.TabIndex = 5;
			this.tbxValue.WordWrap = false;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.ForeColor = System.Drawing.Color.Orange;
			this.btnOK.Location = new System.Drawing.Point(231, 14);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.Color.Orange;
			this.btnCancel.Location = new System.Drawing.Point(231, 41);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// EditorForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(318, 211);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tbxValue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxKey);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxTarget);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Editor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox tbxValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxKey;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxTarget;
	}
}
