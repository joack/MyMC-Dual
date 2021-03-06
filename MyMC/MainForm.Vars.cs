﻿/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 17/04/2017
 * Hora: 12:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using MyMCLibrary;

namespace MyMC
{
	/// <summary>
	/// Description of MainForm_Vars.
	/// </summary>
	partial class MainForm
	{
#region Variables
		private static string	VERSION			= "v5";
		
		private static string 	rootPath	  	= Application.StartupPath + "\\";
		
		private static string	configFile		= rootPath + "config.ini";
		private static string	utilPath	  	= rootPath + "Util\\";
		private static string	tempFolder 	  	= rootPath + "temp";
		private static string	exportFolder  	= rootPath + "Exported Files";

		private static string  	util_MyMc			= utilPath + "mymc.exe";
		private static string	util_VMC			= utilPath + "genvmc.exe";
		private static string	util_Converter		= utilPath + "convpcsx.exe";
		private static string	util_ECCChecker		= utilPath + "ECC_Checker.exe";
		private static string	util_TempCleaner	= tempFolder + "\\Cleaner.bat"; 
		
		
		private MemoryCard memoryCardOne;
		private MemoryCard memoryCardTwo;
		
		private DataGridView focusedMemoryCard; 
		
		private const string NO_CARD  		= "Memory Card not Inserted";
		private const string EMPTY_CARD 	= "Empty";

		private const string MODE_PSU = "-p";
		private const string MODE_MAX = "-m";
		
		private string mode 			= MODE_PSU;
		private string userExportFolder = String.Empty;
		private string lastOpenMcDir 	= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		private string lastOpenSaveDir 	= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		private string newCardsFolder	= String.Empty;

		
#endregion		
	}
}
