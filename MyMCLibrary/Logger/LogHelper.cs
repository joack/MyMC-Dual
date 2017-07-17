/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 13/05/2017
 * Hora: 03:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Runtime.CompilerServices;

namespace MyMCLibrary
{
	/// <summary>
	/// Description of LogHelper.
	/// </summary>
	public class LogHelper
	{
        //public static log4net.ILog GetLogger([CallerFilePath] string filename = "")
        //{
        //    return log4net.LogManager.GetLogger(filename);
        //}

        public static log4net.ILog Get_Logger( string filename )
		{
			return log4net.LogManager.GetLogger(filename);
		}
	}
}
