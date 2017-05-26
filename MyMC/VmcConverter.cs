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
using System.IO;
using System.Windows.Forms;
using log4net;

namespace MyMC
{
	/// <summary>
	/// Description of VmcConverter.
	/// </summary>
	public partial class VmcConverter : Form
	{
		private static readonly ILog log = LogHelper.GetLogger(); 
		
		private bool isECC = false;		
		private string extension = String.Empty;
		
		
		
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
			if(!String.IsNullOrEmpty(txtInputPath.Text) && !String.IsNullOrEmpty(txtOutputPath.Text))
			{
				string localFileName = FormatedMcName(txtNewName.Text);
				
				//isECC = Utils.ECCChecker.DoCheck(txtInputPath.Text);
				
				/*Creo memory card temporal
				 *Convierto la memory card al formato correcto en el path seleccionado.
				 *elimino la memory card temporal
				 *copio todos los datos de una memory a otra . 
				 */		
				
				
				if(eccCheck.Checked)
				{
					Action<string, string> DoEccConvert = GetEccConvertMethod(extension);
					string tempMc = Utils.Card.CreateCard(GetMcSize(), localFileName);
					
					DoEccConvert(localFileName, txtOutputPath.Text);
					
					Utils.Card.CopyAllCard(txtInputPath.Text, String.Format("{0}\\{1}{2}", txtOutputPath.Text, localFileName, extension ));
					
					
					Utils.Cleaner.DeleteTemp(tempMc);
				
					log.Debug("Con ecc");
				}else{
					//Utils.Convert.ConvertToBin(localFileName, txtOutputPath.Text );
					log.Debug("Sin ecc");
				}
				log.Debug("fin");
				//Utils.Cleaner.DeleteTemp(tempMc);				
			
			}else{
				MessageBox.Show("Debes completar todos los campos.");
			}
			

		}

	
#region private methods

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

		private int GetBytesReadable(long i)
		{
		    // Get absolute value
		    long absolute_i = (i < 0 ? -i : i);
		    
		    // Determine readable value
		   	double readable;
			
		   	if (absolute_i >= 0x100000) // Megabyte
		   	{
		        readable = (i >> 10);
			}else{
				return -1;
			}
			
		    // Divide by 1024 to get fractional value
		    readable = (readable / 1024);
		    
		    // Return number
		    return (int)readable;
		}

		private string GetMcSize()
		{
			var f = new FileInfo(txtInputPath.Text);
			var num = GetBytesReadable(f.Length);			
			
			if(num >= 32 && num <=33)
			{
				return Convert.ToString(32);
			}else {
				if (num >=64 && num <= 66)
				{
					return Convert.ToString(64);
				} 
			}
			return num.ToString();
		}			

		private Action<string, string> GetEccConvertMethod( string selector )
		{
			if (selector == ".bin") 
			{
				return Utils.Convert.ConvertToBinECC;
			}
			return Utils.Convert.ConvertToPs2ECC;
		}

		
#endregion
		


	
		
		void CloseBtnClick(object sender, EventArgs e)
		{
			Close();
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
				txtInputPath.Text = mcOpenDialog.FileName;
			}
		}
		
		void BrowseFolderBtnClick(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
			{
				txtOutputPath.Text = folderBrowserDialog1.SelectedPath;
			}	
		}
		
		
	
		
		void RadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			var radioButton = sender as RadioButton;
			
			if (radioButton.Checked) 
			{
				extension = radioButton.Text;
			}
		}


		
	}
}
