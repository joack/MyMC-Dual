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
using MyMCLibrary;

namespace MyMC_XP
{
	/// <summary>
	/// Description of Preference.
	/// </summary>
	public partial class Preference : Form, IEditPaths
	{
		private string saveExportPath		= String.Empty;
		private string cardsFolderPath		= String.Empty;
		private string savesFolderPath		= String.Empty;
		private string newCardsFolderPath	= String.Empty;
		
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

		public string NewCardsFolder
		{
			set{ newCardsFolderPath = value;}
		}
		
		
		void PreferencesLoad(object sender, EventArgs e)
		{
			textBox1.Text = saveExportPath;
			textBox2.Text = cardsFolderPath;
			textBox3.Text = savesFolderPath;
			textBox4.Text = newCardsFolderPath;
		}
		
		void AccepButtonClick(object sender, EventArgs e)
		{
			IEditPaths configuration = this.Owner as IEditPaths;
			
			if( configuration != null )
			{
				configuration.SetPaths( textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text );
			}
			
			Close();
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			Close();
		}
		

		public void SetOptionPath(string anOption, string aValue){}		
		public void SetPaths(string saveExportPath, string cardsFolderPath, string saveFolderPath, string newCardsPath){}
	
	
		void Button1Click(object sender, EventArgs e)
		{
			DoBrowse(textBox1, saveExportPath);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			DoBrowse(textBox2, cardsFolderPath);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			DoBrowse(textBox3, savesFolderPath);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			DoBrowse(textBox4, newCardsFolderPath);
		}

		
		private FolderBrowserDialog GetDialog( string rootDir )
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.SelectedPath = rootDir;
			
			return fbd;
		}
		
		private void DoBrowse( TextBox textBox, string path )
		{
			FolderBrowserDialog fbd = GetDialog( textBox.Text);
			
			if (fbd.ShowDialog() == DialogResult.OK) 
			{
				textBox.Text = fbd.SelectedPath;	
			}			
		}
		
	}
}
