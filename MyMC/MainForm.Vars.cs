/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 17/04/2017
 * Hora: 12:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;

namespace MyMC
{
	/// <summary>
	/// Description of MainForm_Vars.
	/// </summary>
	partial class MainForm
	{
#region Variables

		private static string 	rootPath	  = Application.StartupPath + "\\";
		private static string	utilPath	  = rootPath + "Util\\";
		private static string  	util_MyMc 	  = utilPath + "mymc.exe";
		private static string	util_VMC	  = utilPath + "genvmc.exe";
		private static string	tempFolder 	  = rootPath + "temp"; 
		private static string	exportFolder  = rootPath + "Exported Files";
		
		private MemoryCard memoryCardOne;
		private MemoryCard memoryCardTwo;
		private Util util;
		
		private DataGridView focusedMemmoryCard; 
		
		private const string NO_CARD  		= "Memory Card not Inserted";
		private const string EMPTY_CARD 	= "Empty";

		private const string MODE_PSU = "-p";
		private const string MODE_MAX = "-m";
		
		private string mode 			= MODE_PSU;
		private string userExportFolder = String.Empty;
		private string lastOpenMcDir 	= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		private string lastOpenSaveDir 	= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


		
#endregion		
	}
}
