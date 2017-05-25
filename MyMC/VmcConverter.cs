/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 24/05/2017
 * Hora: 01:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMC
{
	/// <summary>
	/// Description of VmcConverter.
	/// </summary>
	public partial class VmcConverter : Form
	{
		private bool isECC = false;
		ToolTip tip = new ToolTip();
			
		
		public VmcConverter()
		{
			InitializeComponent();			
		}
		
		void VmcConverterLoad(object sender, EventArgs e)
		{
			binRadioBtn.Checked = true;
			
		}
		
		
		
		
		void ConvertBtnClick(object sender, EventArgs e)
		{
	
		}		
		
		void CloseBtnClick(object sender, EventArgs e)
		{
			Close();
		}
		
		
		void EccCheckMouseUp(object sender, MouseEventArgs e)
		{
			try {
				if(isECC)
				{
					tip.ShowAlways = true;
					tip.AutoPopDelay = 5000;
	         		tip.InitialDelay = 100;
	         		tip.ReshowDelay = 500;
	         		
	         		tip.SetToolTip(eccCheck, "Hola");
	         		eccCheck.Checked = false;
				}		
			} catch (Exception ex) {
				
				MessageBox.Show("Input file not valid.");
				txtInputPath.Focus();
			}
		
			
		
		}
		
		void EccCheckMouseEnter(object sender, EventArgs e)
		{
			tip.RemoveAll();
		}

		void BrowseFileBtnClick(object sender, EventArgs e)
		{
			mcOpenDialog.Reset();
			mcOpenDialog.Filter = "PS2 File Format|*.ps2|PS2 File Bin Format|*.bin";
			mcOpenDialog.FilterIndex = 2;
			//mcOpenDialog.InitialDirectory = lastOpenMcDir;
			
			mcOpenDialog.FileName = "";
			mcOpenDialog.Multiselect = false;
			
			if (mcOpenDialog.ShowDialog() == DialogResult.OK) 
			{
				isECC = Utils.ECCChecker.DoCheck(mcOpenDialog.FileName);
				txtInputPath.Text = mcOpenDialog.FileName;
			}
		}
		
		void BrowseFolderBtnClick(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
			{
				txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
			}	
		}

	}
}
