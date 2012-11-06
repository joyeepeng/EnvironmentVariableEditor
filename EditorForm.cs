/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012/10/31
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnvironmentVariableEditor
{
	/// <summary>
	/// Description of EditorForm.
	/// </summary>
	public partial class EditorForm : Form
	{
		public string target = string.Empty;
		public string key = string.Empty;
		public string val = string.Empty;
		
		public EditorForm(string target, string key, string val)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			if(target.Equals("User")){
				this.cbxTarget.SelectedIndex = 0;
			}else if(target.Equals("Machine")){
				this.cbxTarget.SelectedIndex = 1;
			}else{
				if(!target.Equals("New")){
					MessageBox.Show("Unknown target parameter!","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
			}
			
			this.tbxKey.Text = key;
			this.tbxValue.Text = val;
			
			this.target = target;
			this.key = key;
			this.val = val;
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			try{
				this.target = this.cbxTarget.SelectedItem.ToString();
				if(this.tbxKey.TextLength > 0)
					this.key = this.tbxKey.Text;
				if(this.tbxValue.TextLength >0)
					this.val = this.tbxValue.Text;
			}catch(Exception ex){
				MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
	}
}
