/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 19:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MyMC
{
	/// <summary>
	/// Description of ITransferSaves.
	/// </summary>
	public interface ITransferSaves
	{
		void TransferSave( string aFile, IMemoryCard mcOne, IMemoryCard mcTwo);
	}
}
