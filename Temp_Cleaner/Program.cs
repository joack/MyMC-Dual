/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 30/04/2017
 * Hora: 17:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Reflection;

namespace Temp_Cleaner
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length == 1 ) 
			{		
				string rootPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
				
				if (File.Exists(".\\" + args[0])) {
					File.Delete(".\\" + args[0]);
				}
			}
		}
	}
}