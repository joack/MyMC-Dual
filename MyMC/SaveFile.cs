/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 19:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MyMC
{
	/// <summary>
	/// Description of SaveFile.
	/// </summary>
	public class SaveFile
	{
		private string fileName 		= String.Empty;
		private string fileSize 		= String.Empty;
		private string fileDate 		= String.Empty;
		private string fileDescription 	= String.Empty;		
		
		public SaveFile( string aName, string aSize, string aDate, string aDescription )
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
		
		public string FileSize
		{
			get{return fileSize;}
			set{fileSize = value;}
		}
		
		public string FileDate
		{
			get{return fileDate;}
		}
		
		public string FileDescription
		{
			get{return fileDescription;}
			set{fileDescription = value;}
		}
		
		public void SetSizeAndDescrip( string size, string descrip )
		{
			fileSize = size;
			fileDescription = descrip;
		}
		
	}
}
