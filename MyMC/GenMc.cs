/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 26/03/2017
 * Hora: 06:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MyMC
{
	/// <summary>
	/// Description of GenMc.
	/// </summary>
	public partial class GenMc : Form, IInfoForm
	{

#region Vars
		
		Process process;
		private string utilVMC = String.Empty;
		InfoVMC info;

#endregion
		
		public GenMc()
		{
			InitializeComponent();
		}

#region OnLoad & event Buttons
		
		void GenMcLoad(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
			textBox2.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				
		}

		void BrowseButtonClick(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			
			if(fbd.ShowDialog() == DialogResult.OK )
			{
				textBox2.Text = fbd.SelectedPath;
			}
		}		
	
		void CreateButtonClick(object sender, EventArgs e)
		{
			string size = comboBox1.SelectedItem.ToString();
			string dirPath = textBox2.Text;
			string cardName = FormatedMcName( textBox1.Text );
			
			InitInfo();
			
			SetProcess(utilVMC, String.Format("{0} {1}\\{2}.bin", size, dirPath, cardName));
			DoProcess();
			Thread thread = new Thread(() => process.WaitForExit());
			
			thread.Start();
		}
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			Close();
		}
	
#endregion

#region Property

		public string SetUtil
		{
			set{ this.utilVMC = value;}
		}

#endregion
				
#region Interface Method		

		public void UpdateTextBox( string updateText ){}

#endregion

#region My Methods

		private string FormatedMcName( string cardName )
		{
			if ( cardName != String.Empty) 
			{
				string[] values = cardName.Split(' ');
				
				return String.Join("_", values );
			}else{
				return "default";
			}
		}

		private void SetProcess( string path, string args)
		{
			process = new Process();
			process.StartInfo.FileName = path;
			process.StartInfo.Arguments = args;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true; 	
			process.OutputDataReceived += (send ,ev) => Update(ev.Data);
		}
		
		private void DoProcess()
		{
			process.Start();
			process.BeginOutputReadLine();			
		}

		private void Update( string updateText )
		{
			if ( info != null ) 
			{
				info.Invoke(new Action(()=> info.UpdateTextBox(updateText)));
			}
		}
	
		private void InitInfo()
		{
			if(info == null )
			{
				info = new InfoVMC();
			}else{
				info.Hide();
			}	
			info.Show(this);
		}

#endregion
		
	}
}
