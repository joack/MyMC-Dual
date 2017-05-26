/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 14:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;

namespace MyMC
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		/// 		
		
		[STAThread]
		private static void Main(string[] args)
		{  
			AppDomain.CurrentDomain.AssemblyResolve += OnResolveAssembly;
			
			if (args.Length > 0) 
			{
				if (args[0] == "/debug") 
				{
					NativeMethods.AllocConsole();
					Console.WriteLine("Debug console.");
				}	
			}
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);			
			Application.Run(new MainForm());
		}
		
		
		
        
// This function is not called if the Assembly is already previously loaded into memory.
// This function is not called if the Assembly is already in the same folder as the app.

		private static Assembly OnResolveAssembly(object sender, ResolveEventArgs e)
		{
		    var thisAssembly = Assembly.GetExecutingAssembly();
		
		    // Get the Name of the AssemblyFile
		    var assemblyName = new AssemblyName(e.Name);
		    var dllName = assemblyName.Name + ".dll";
		
		    // Load from Embedded Resources
		    var resources = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(dllName));
		    if (resources.Any())
		    {
		        // 99% of cases will only have one matching item, but if you don't,
		        // you will have to change the logic to handle those cases.
		        var resourceName = resources.First();
		        using (var stream = thisAssembly.GetManifestResourceStream(resourceName))
		        {
		            if (stream == null) return null;
		            var block = new byte[stream.Length];
		
		            // Safely try to load the assembly.
		            try
		            {
		                stream.Read(block, 0, block.Length);
		                return Assembly.Load(block);
		            }
		            catch (IOException)
		            {
		                return null;
		            }
		            catch (BadImageFormatException)
		            {
		                return null;
		            }
				}
			}
		
		    // in the case the resource doesn't exist, return null.
		    return null;        
				
		}
}
	
    internal static class NativeMethods
    {
        // http://msdn.microsoft.com/en-us/library/ms681944(VS.85).aspx
        /// <summary>
        /// Allocates a new console for the calling process.
        /// </summary>
        /// <returns>nonzero if the function succeeds; otherwise, zero.</returns>
        /// <remarks>
        /// A process can be associated with only one console,
        /// so the function fails if the calling process already has a console.
        /// </remarks>
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int AllocConsole();

        // http://msdn.microsoft.com/en-us/library/ms683150(VS.85).aspx
        /// <summary>
        /// Detaches the calling process from its console.
        /// </summary>
        /// <returns>nonzero if the function succeeds; otherwise, zero.</returns>
        /// <remarks>
        /// If the calling process is not already attached to a console,
        /// the error code returned is ERROR_INVALID_PARAMETER (87).
        /// </remarks>
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int FreeConsole();	
    }
}