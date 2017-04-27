/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 27/03/2017
 * Hora: 11:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMC
{
	/// <summary>
	/// Description of InfoVMC.
	/// </summary>
	public partial class InfoVMC : Form, IInfoForm
	{
		public InfoVMC()
		{
			InitializeComponent();
		}
	
#region Interface Method
		
		public void UpdateTextBox( string updateText )
		{
			Console.WriteLine(updateText);
			richTextBox1.Invoke(new Action (() => richTextBox1.AppendText(updateText + "\n")));
			richTextBox1.ScrollToCaret();			
		}
		
#endregion		

#region Event Button

		void HideButtonClick(object sender, EventArgs e)
		{
			this.Hide();			
		}

#endregion
		
	}
}
