/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 23:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Hosting;
using System.Text;

namespace MyMC_Debug
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Process process = new Process();
			process.StartInfo.FileName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\MyMC Dual.exe";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true; 
			
			process.StartInfo.Arguments = "/debug";
			process.Start();
		}
		
	}
}

