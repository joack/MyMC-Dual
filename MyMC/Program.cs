/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 14:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyMC
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		/// 		
		
		[STAThread]
		private static void Main(string[] args)
		{   
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);			
			Application.Run(new MainForm());
		}
	}
}
