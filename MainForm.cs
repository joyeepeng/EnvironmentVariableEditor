/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012/10/31
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Collections;
using System.IO;

namespace EnvironmentVariableEditor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ShowException(string msg){
			MessageBox.Show(msg,"EXCEPTION",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}
		
		void ShowInformation(string msg){
			this.textBox1.Text += msg + Environment.NewLine;
			this.textBox1.SelectionStart = this.textBox1.TextLength;
			this.textBox1.ScrollToCaret();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.checkedListBox1.Items.Clear();
			this.checkedListBox2.Items.Clear();
			this.textBox1.Text = "";
			
			BtnScanClick(sender,e);
		}
		
		void BtnScanClick(object sender, EventArgs e)
		{
			try{
				this.checkedListBox1.Items.Clear();
				this.checkedListBox2.Items.Clear();
				// read the environment variable for the user
				foreach(DictionaryEntry de in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User)){
					string fmt = "[" + de.Key.ToString() + "]" + de.Value.ToString();
					this.checkedListBox1.Items.Add(fmt);
					ShowInformation("Find [" + de.Key.ToString() + "] in User.");
				}
				// read the environment variable for the machine
				foreach(DictionaryEntry de in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine)){
					string fmt = "[" + de.Key.ToString() + "]" + de.Value.ToString();
					this.checkedListBox2.Items.Add(fmt);
					ShowInformation("Find [" + de.Key.ToString() + "] in Machine.");
				}
			}catch(Exception ex){
				ShowException(ex.Message);
			}
		}
		
		void BtnExportClick(object sender, EventArgs e)
		{
			try{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "EVE File(*.eve)|*.eve";
				if(sfd.ShowDialog() == DialogResult.OK){
					if(this.checkedListBox1.SelectedItems.Count > 0){
						using(StreamWriter sw = new StreamWriter(sfd.FileName,false)){
							foreach(object o in this.checkedListBox1.CheckedItems){
								string line = "User\t";
								string fmt = o.ToString();
								string key = fmt.Substring(fmt.IndexOf('[') + 1,fmt.IndexOf(']') - fmt.IndexOf('[') - 1);
								string val = fmt.Substring(fmt.IndexOf(']') + 1);
								line += key + "\t" + val;
								sw.WriteLine(line);
								ShowInformation("Write [User][" + key + "] to " + sfd.FileName + ".");
							}
						}
					}
					
					if(this.checkedListBox2.SelectedItems.Count > 0){
						using(StreamWriter sw = new StreamWriter(sfd.FileName,true)){
							foreach(object o in this.checkedListBox2.CheckedItems){
								string line = "Machine\t";
								string fmt = o.ToString();
								string key = fmt.Substring(fmt.IndexOf('[') + 1,fmt.IndexOf(']') - fmt.IndexOf('[') - 1);
								string val = fmt.Substring(fmt.IndexOf(']') + 1);
								line += key + "\t" + val;
								sw.WriteLine(line);
								ShowInformation("Write [Machine][" + key + "] to " + sfd.FileName + ".");
							}
						}
					}
				}
			}catch(Exception ex){
				ShowException(ex.Message);
			}
		}
		
		void BtnImportClick(object sender, EventArgs e)
		{
			try{
				OpenFileDialog ofd = new OpenFileDialog();
				ofd.Filter = "EVE File(*.eve)|*.eve";
				if(ofd.ShowDialog() == DialogResult.OK){
					// read the environment variable editor file type
					using(StreamReader sr = new StreamReader(ofd.FileName)){
						while(!sr.EndOfStream){
							string line = sr.ReadLine();
							string[] parts = line.Split('\t');
							if(parts.Length == 3){
								if(parts[0].Equals("User")){
									Environment.SetEnvironmentVariable(parts[1], parts[2], EnvironmentVariableTarget.User);
									ShowInformation("Set User Variable [" + parts[1] + "] to " + parts[2] + ".");
								}
								
								if(parts[0].Equals("Machine")){
									Environment.SetEnvironmentVariable(parts[1], parts[2], EnvironmentVariableTarget.Machine);
									ShowInformation("Set Machine Variable [" + parts[1] + "] to " + parts[2] + ".");
								}
							}
						}
					}
					
					this.BtnScanClick(sender,e);
				}
			}catch(Exception ex){
				ShowException(ex.Message);
			}
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			try{
				if(this.checkedListBox1.CheckedItems.Count > 0){
					foreach(object o in this.checkedListBox1.CheckedItems){
						string fmt = o.ToString();
						string key = fmt.Substring(fmt.IndexOf('[') + 1,fmt.IndexOf(']') - fmt.IndexOf('[') - 1);
						string val = fmt.Substring(fmt.IndexOf(']') + 1);
						EnvironmentVariableEditor.EditorForm ef = new EditorForm("User", key, val);
						if( ef.ShowDialog() == DialogResult.OK){
							if(ef.key != string.Empty && ef.val != string.Empty && ef.target != string.Empty){
								if(ef.target.Equals("User")){
									Environment.SetEnvironmentVariable(ef.key, ef.val, EnvironmentVariableTarget.User);
									ShowInformation("Set User Variable [" + ef.key + "] to " + ef.val + ".");
								}
								
								if(ef.target.Equals("Machine")){
									Environment.SetEnvironmentVariable(ef.key, ef.val, EnvironmentVariableTarget.Machine);
									ShowInformation("Set Machine Variable [" + ef.key + "] to " + ef.val + ".");
								}
							}
						}
					}
				}
				
				if(this.checkedListBox2.CheckedItems.Count > 0){
					foreach(object o in this.checkedListBox2.CheckedItems){
						string fmt = o.ToString();
						string key = fmt.Substring(fmt.IndexOf('[') + 1,fmt.IndexOf(']') - fmt.IndexOf('[') - 1);
						string val = fmt.Substring(fmt.IndexOf(']') + 1);
						EnvironmentVariableEditor.EditorForm ef = new EditorForm("Machine", key, val);
						if( ef.ShowDialog() == DialogResult.OK){
							if(ef.key != string.Empty && ef.val != string.Empty && ef.target != string.Empty){
								if(ef.target.Equals("User")){
									Environment.SetEnvironmentVariable(ef.key, ef.val, EnvironmentVariableTarget.User);
									ShowInformation("Set User Variable [" + ef.key + "] to " + ef.val + ".");
								}
								
								if(ef.target.Equals("Machine")){
									Environment.SetEnvironmentVariable(ef.key, ef.val, EnvironmentVariableTarget.Machine);
									ShowInformation("Set Machine Variable [" + ef.key + "] to " + ef.val + ".");
								}
							}
						}
					}
				}
				
				this.BtnScanClick(sender,e);
			}catch(Exception ex){
				ShowException(ex.Message);
			}
		}
		
		void BtnNewClick(object sender, EventArgs e)
		{
			try{
				EnvironmentVariableEditor.EditorForm ef = new EditorForm("New","Key","");
				if(ef.ShowDialog() == DialogResult.OK){
					if(ef.target != string.Empty && ef.key != string.Empty && ef.val != string.Empty){
						if(ef.target.Equals("User")){
							Environment.SetEnvironmentVariable(ef.key, ef.val, EnvironmentVariableTarget.User);
							ShowInformation("Set User Variable [" + ef.key + "] to " + ef.val + ".");
						}
						
						if(ef.target.Equals("Machine")){
							Environment.SetEnvironmentVariable(ef.key, ef.val, EnvironmentVariableTarget.Machine);
							ShowInformation("Set Machine Variable [" + ef.key + "] to " + ef.val + ".");
						}
						
						this.BtnScanClick(sender,e);
					}
				}
			}catch(Exception ex){
				ShowException(ex.Message);
			}
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			try{
				foreach(object o in this.checkedListBox1.CheckedItems){
					string fmt = o.ToString();
					string key = fmt.Substring(fmt.IndexOf('[') + 1,fmt.IndexOf(']') - fmt.IndexOf('[') - 1);
					
					Environment.SetEnvironmentVariable(key, string.Empty, EnvironmentVariableTarget.User);
					ShowInformation("Delete User Variable [" + key + " ].");
				}
				
				foreach(object o in this.checkedListBox2.SelectedItems){
					string fmt = o.ToString();
					string key = fmt.Substring(fmt.IndexOf('[') + 1,fmt.IndexOf(']') - fmt.IndexOf('[') - 1);
					
					Environment.SetEnvironmentVariable(key, string.Empty, EnvironmentVariableTarget.Machine);
					ShowInformation("Delete Machine Variable [" + key + " ].");
				}
				
				this.BtnScanClick(sender,e);
			}catch(Exception ex){
				ShowException(ex.Message);
			}
		}
	}
}
