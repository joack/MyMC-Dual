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
using System.Windows.Forms;
using MyMCLibrary;

namespace MyMC_XP
{
	/// <summary>
	/// Description of GenMc.
	/// </summary>
	public partial class GenMc : Form, IInfoForm, IEditPaths
	{

#region Vars
		
		Process process;
		private string utilVMC			= String.Empty;
//		private string utilConverter	= String.Empty;
//		private string utilTempCleaner	= String.Empty;
		
		private string tempFolder		= String.Empty;
		
		InfoVMC info;
		private string startUpDirectory = String.Empty;
		
#endregion
		
		public GenMc()
		{
			InitializeComponent();
		}

#region OnLoad & event Buttons
		
		void GenMcLoad(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
			extensionChooser.SelectedIndex = 0;
			textBox2.Text = startUpDirectory;
				
		}

		void BrowseButtonClick(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.SelectedPath = startUpDirectory;
			
			if(fbd.ShowDialog() == DialogResult.OK )
			{
				textBox2.Text = fbd.SelectedPath;
				
				SaveOption(fbd.SelectedPath);
			}
		}		
	
		void CreateButtonClick(object sender, EventArgs e)
		{
			string 	size 		= comboBox1.SelectedItem.ToString();
			string 	dirPath 	= textBox2.Text;
			string 	cardName	= FormatedMcName( textBox1.Text );
			bool	isECC		= eccBlockCheck.Checked;
			string 	extension	= extensionChooser.SelectedItem.ToString();
			
			
			InitInfo();
			
			
			// Si isECC es true:
			// Creo una memory card en la carpeta temp
			// convierto esa memory card 
			// muevo la memory card a su destino.
			
			if (isECC) 
			{
				Update("\nMemory card with ECC Block.\n");
				
				DoCreate( utilVMC,  String.Format("{0} \"{1}\\{2}.bin\"", size, tempFolder, cardName) );
				DoConvert(cardName, dirPath, extension);
				DoDeleteTemp( String.Format("{0}.bin", cardName));
					
			}else{
				DoCreate( utilVMC,  String.Format("{0} \"{1}\\{2}{3}\"", size, dirPath, cardName, extension) );
			}
			
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
		
//		public string SetConverter
//		{
//			set{this.utilConverter = value;}
//		}

		public string SetTempFolder
		{
			set{this.tempFolder = value;}
		}
		
//		public string SetTempCleaner
//		{
//			set{this.utilTempCleaner = value;}
//		}
	
		public string SetDirectory
		{
			set{startUpDirectory = value;}
		}
		
#endregion
				
#region Interface Method		

		public void UpdateTextBox( string updateText ){}
		
		public void SetOptionPath(string anOption, string aValue){}
		
		public void SetPaths(string saveExportPath, string cardsFolderPath, string saveFolderPath, string newCardsPath){}		

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
			process.WaitForExit();
			process.BeginOutputReadLine();
			
		}

		private void Update( string updateText )
		{
			if ( info != null ) 
			{
				IInfoForm form = info as IInfoForm;	

				form.UpdateTextBox(updateText);				
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

		private void DoCreate(string utility, string args )
		{
			SetProcess(utility, args);
			DoProcess();
		}
		
		private void DoConvert(string cardName, string dirPath)
		{
			Utils.Convert.ConvertToBin(cardName, dirPath );
		}
		
		private void DoConvert(string cardName, string dirPath, string extension )
		{
			Action<string, string> ConvertEccMethod = GetEccMethod(extension);
			
			ConvertEccMethod(cardName, dirPath);
		}
		
		private Action<string, string> GetEccMethod(string extension)
		{
			if(extension == ".bin")
			{
				return Utils.Convert.ConvertToBinECC;
			}
			
			return Utils.Convert.ConvertToPs2ECC;
		}	
		
		private void DoDeleteTemp( string tempFile )
		{		
			Utils.Cleaner.DeleteTemp(tempFile);
		}

		private void SaveOption(string path)
		{
			IEditPaths configPath = this.Owner as IEditPaths;
			
			if (configPath != null) 
			{
				configPath.SetOptionPath("NewCardsFolder", path);
			}
		}
		
#endregion

	}
}
