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


namespace MyMC
{
	/// <summary>
	/// Description of Utils_Vars.
	/// </summary>
	public partial class Utils
	{
		partial class Card
		{
			private static Process process;		
					
			private static int aSize = 1;
			private static int aDate = 2;
			private static int aHour = 3;
			private static int aDirName = 4;

			private static string utilFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Util";			
		}
	
		
		partial class ECCChecker
		{
			private static Process p;
			private static string utilFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Util";
		}

		

		partial class Convert
		{
			private static Process p;
			private static string utilFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Util";
			private static string tempFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\temp";
		}


		
		

		partial class Cleaner
		{
			private static Process p;
			private static string tempFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\temp";
		}
	}
}
