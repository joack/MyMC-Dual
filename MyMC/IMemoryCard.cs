/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 18:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MyMC
{
	/// <summary>
	/// Description of IMemoryCard.
	/// </summary>
	public interface IMemoryCard
	{		
		string GetFreeSpace();
		
		string GetPath();
		
		List<SaveFile> LoadSaves();
		
	}
}
