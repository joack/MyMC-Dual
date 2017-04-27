/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 18:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace MyMC
{
	/// <summary>
	/// Description of MemoryCard.
	/// </summary>
	public class MemoryCard: IMemoryCard
	{
		List<SaveFile> savesFiles = new List<SaveFile>();
		private string mcPath;
		private string freeSpace;
		
		public MemoryCard(string memoryCardPath, List<SaveFile> files, string freeSpace )
		{
			this.mcPath = memoryCardPath;
			savesFiles = files;
			this.freeSpace = freeSpace;
		}
		
			
		public List<SaveFile> LoadSaves()
		{
			return savesFiles;	
		}
		
		public string GetFreeSpace()
		{
			return freeSpace;
		}
		
		public string GetPath()
		{
			return mcPath;
		}
	
	}
}
