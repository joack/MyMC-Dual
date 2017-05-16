/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 05/05/2017
 * Hora: 00:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMC
{
	/// <summary>
	/// Description of Preference.
	/// </summary>
	public partial class Preference : Form, IPreferencesPaths
	{
		private string saveExportPath	= String.Empty;
		private string cardsFolderPath	= String.Empty;
		private string savesFolderPath	= String.Empty;
		
		public Preference()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public string ExportPath
		{
			set{ saveExportPath = value;}
		}
		
		public string FolderCards
		{
			set{ cardsFolderPath = value;}
		}
		
		public string SavesFolder
		{
			set{ savesFolderPath = value;}
		}


		
		
		void PreferencesLoad(object sender, EventArgs e)
		{
			textBox1.Text = saveExportPath;
			textBox2.Text = cardsFolderPath;
			textBox3.Text = savesFolderPath;
		}
		
		void AccepButtonClick(object sender, EventArgs e)
		{
			IPreferencesPaths configuration = this.Owner as IPreferencesPaths;
			
			if( configuration != null )
			{
				configuration.SetPaths( textBox1.Text, textBox2.Text, textBox3.Text );
			}
			
			Close();
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			Close();
		}
		
		public void SetPath(string path)
		{
			throw new NotImplementedException();
		}
		
		public void SetPaths(string saveExportPath, string cardsFolderPath, string saveFolderPath){}
	}
}
