/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 21/05/2017
 * Hora: 03:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using log4net;


namespace MyMC
{
	/// <summary>
	/// Description of Utils_Vars.
	/// </summary>
	partial class Utils
	{
		//private static readonly ILog log = LogHelper.GetLogger();
		
		public partial class Card
		{
			private static Process process;		
					
			private static int aSize = 1;
			private static int aDate = 2;
			private static int aHour = 3;
			private static int aDirName = 4;

			private static string utilFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Util";
			private static string tempFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\temp";	

			private static string mymc = utilFolder + "\\mymc.exe";
			private static string genvmc = utilFolder + "\\genvmc.exe";
			

			
			public static void lalilulelo()
			{
				throw new NotImplementedException();
			}
		}
	
		
		public partial class ECCChecker
		{
			private static Process p;
			private static string utilFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Util";
		}

		

		public partial class Convert
		{
			private static Process p;
			private static string utilFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Util";
			private static string tempFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\temp";
		}


		
		

		public partial class Cleaner
		{
			private static Process p;
			private static string tempFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\temp";
		}
	}
}
