/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 25/03/2017
 * Hora: 00:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMC
{
	/// <summary>
	/// Description of ExportPathChooser.
	/// </summary>
	public partial class ExportPathChooser : Form, ISetExportPath
	{
		
		private string selectedPath = String.Empty;
		
		public ExportPathChooser()
		{
			InitializeComponent();
		}
		
#region Interface Method
		
		public void SetPath( string Path){}

#endregion		
		
#region Property		
		
		public string Path
		{
			set{selectedPath = value;}
		}
		
#endregion
		
#region OnLoad & Event Buttons
		
		void ExportPathChooserLoad(object sender, EventArgs e)
		{
			textBox1.Text = selectedPath;
		}
			
		void BrowseButtonClick(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.SelectedPath = selectedPath;
			fbd.ShowNewFolderButton = true;
			
			if (fbd.ShowDialog() == DialogResult.OK) 
			{
				textBox1.Text = fbd.SelectedPath;	
			}
		}
		
		void AcceptButtonClick(object sender, EventArgs e)
		{
			ISetExportPath IForm = this.Owner as ISetExportPath;

			if (IForm != null) 
			{
				IForm.SetPath(textBox1.Text);
			}			
		}
	
		void CloseButtonClick(object sender, EventArgs e)
		{
			Close();
		}	

#endregion
		
	}
}
