/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 26/03/2017
 * Hora: 02:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MyMC
{
	/// <summary>
	/// Description of ISetExportPath.
	/// </summary>
	public interface IEditPaths
	{
		void SetOptionPath( string anOption, string aValue );
		
		void SetPaths( string saveExportPath, string cardsFolderPath, string saveFolderPath, string newCardsPath );
	}
}
