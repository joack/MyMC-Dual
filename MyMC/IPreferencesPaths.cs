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
	public interface IPreferencesPaths
	{
		//void SetPath( string path );
		void SetPaths( string saveExportPath, string cardsFolderPath, string saveFolderPath );
	}
}
