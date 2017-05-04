/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 29/04/2017
 * Hora: 21:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ECC_Checker
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			if (args.Length == 1) 
			{
				Process process = new Process();
				process.StartInfo.FileName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\mymc.exe";
				process.StartInfo.Arguments = String.Format("\"{0}\" ls", args[0]);
				process.StartInfo.UseShellExecute = false;
				//process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true; 	
				
				process.Start();
				process.WaitForExit();
				
				
				
				Console.WriteLine(DoCheck(process.StandardOutput.ReadToEnd()).ToString());			

				
			}else{
				Console.WriteLine("This program determine if the memory card has ECC block or not.\n" +
				                  "True: has ECC.\n" +
				                  "False: hasn't ECC.");
				Console.ReadKey();
			}
			
			
			
		}
		
		
		public static bool DoCheck( string output )
		{
			List<string> list 	= new List<string>();
			bool result 		= false;
			
			var map = new Dictionary<string, bool>()
			{
				{"corrected 1", false},
				{".", true}
			};
			
			list = GetInfo(output);
			
			result = map.TryGetValue(list[0], out result);
		 	
		 	if (!result) {
				list = ProcessData(list[0], ' ');
				
		 		return map.TryGetValue(list[4], out result);	
		 	}
			
			return !result;
		}
				
		private static List<string> GetInfo( string outPutText)
		{
			List<string> result;
			
			result = ProcessData( outPutText, '\r', '\n' );
			
			return result;		
		}			
		
		private static List<string> ProcessData( string text, params char[] separators )
		{
			List<string> processedData = new List<string>();
			
			processedData.AddRange( text.Split(separators) );
			processedData.RemoveAll( item => item == String.Empty );
			
			return processedData;
		}
	
	}
}