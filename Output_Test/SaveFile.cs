/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 19/02/2017
 * Hora: 22:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Output_Test
{
	/// <summary>
	/// Description of SaveFile.
	/// </summary>
	public class SaveFile
	{

		private string fileName 		= String.Empty;
		private double fileSize 		= 0;
		private string fileDate 		= String.Empty;
		private string fileDescription 	= String.Empty;		
		
		public SaveFile( string aName, double aSize, string aDate, string aDescription )
		{
			fileName 			= aName;
			fileSize 			= aSize;
			fileDate 			= aDate;
			fileDescription 	= aDescription;
		}
		
		public string FileName
		{
			get{ return fileName;}
		}
		
		public double FileSize
		{
			get{return fileSize;}
		}
		
		public string FileDate
		{
			get{return fileDate;}
		}
		
		public string FileDescription
		{
			get{return fileDescription;}
		}			
			
		}
}
