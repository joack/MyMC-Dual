/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 19/02/2017
 * Hora: 21:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace MyMC
{
	/// <summary>
	/// Description of Util.
	/// </summary>
	public class Util
	{
		private static Util instance;
		private Process process;
		
		private const int aSize = 1;
		private const int aDate = 2;
		private const int aHour = 3;
		private const int aDirName = 4;
		
		private Util( string path )
		{
				process = new Process();
				process.StartInfo.FileName = path;			
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true; 
		}
		
		public static Util getUtil( string path )
		{
			if( instance == null )
			{
				instance = new Util( path );
			}
			
			return instance;
		}
		
		public List<SaveFile> loadFiles( string mcPath )
		{
			
			
			process.StartInfo.Arguments = mcPath + " ls";
			process.Start();
			
			return ProcessOutPut( mcPath);
		}
		
		public void ExportSaveUtil( string mcPath, string fileName )
		{
			process.StartInfo.Arguments = mcPath + " export " + fileName;
			process.Start();
			process.WaitForExit();
		}
		
		public void ExportSaveUtil( string mcPath, string fileName, string outPutDir )
		{
			process.StartInfo.Arguments = String.Format("\"{0}\" {1} {2} \"{3}\" {4}", mcPath, "export", "-d", outPutDir, fileName);
			
			process.Start();
			process.WaitForExit();
		}		
		
		public void ExportSaveUtil( string mcPath, string fileName, string outPutDir, string exportMode )
		{
			process.StartInfo.Arguments = String.Format("\"{0}\" {1} {2} {3} \"{4}\" {5}", mcPath, "export", exportMode, "-d", outPutDir, fileName);
			
			process.Start();
			process.WaitForExit();
		}
		
		public void ImportSaveUtil( string mcPath, string pathFile )
		{
			process.StartInfo.Arguments = String.Format("\"{0}\" {1} \"{2}\"", mcPath, "import", pathFile);
			process.Start();
			process.WaitForExit();
		}		
		
		
		public void DeleteSaveUtil( string mcPath, string fileName )
		{
			process.StartInfo.Arguments = String.Format("\"{0}\" {1} {2}", mcPath, "delete", fileName);
			process.Start();
			process.WaitForExit();	
		}

		public string GetMcFreeSpace( string mcPath )
		{
			StartProcess( mcPath, "dir" );
			
			return GetFreeSpace( process.StandardOutput.ReadToEnd() );
		}

		public void AddRawFile( string mcPath, string folderPath )
		{
			FileAttributes attr	= File.GetAttributes(folderPath);
			bool isFolder 		= (attr & FileAttributes.Directory) == FileAttributes.Directory;
			
			if (isFolder) 
			{
				string folderName 	= new DirectoryInfo(folderPath).Name;
				string[] files		= Directory.GetFiles(folderPath);

								
				MakeDir( mcPath, folderName );
				
				AddFiles( mcPath, folderName, files );
					
				Console.WriteLine();				
			}
	
		}
		

		
//===============================================================================================================


		private string GetFreeSpace( string output )
		{
			List<string> list = GetInfo(output);
			
			return list[list.Count -1];
		}
			
		private List<SaveFile> ProcessOutPut( string mcPath)
		{				
			return UpdateFiles(mcPath, MakeFiles( mcPath ));
		}	
		
		private List<SaveFile> MakeFiles( string mcPath )
		{
			StartProcess(mcPath, "ls");
		
			return DoFiles(GetInfo( process.StandardOutput.ReadToEnd()));
		}
		
		private List<SaveFile> UpdateFiles( string mcPath, List<SaveFile> files )
		{
			StartProcess(mcPath, "dir");
			
			return UpdateSaves(files, process.StandardOutput.ReadToEnd());
		}

		private List<SaveFile> UpdateSaves( List<SaveFile> files, string output )
		{
			List<string> saveStringList = GetInfo( output );
			
			StringBuilder _aDescrip = new StringBuilder();
			string _aDirName = String.Empty;
			string _aSize = String.Empty;
			List<string> values = new List<string>();
			
			for (int i = 0; i < saveStringList.Count -1; i++) 
			{
							
				if ( i%2 == 0)
				{
					values.AddRange( saveStringList[i].Split(' '));
					values.RemoveAll( item => item == String.Empty );					
					
					_aDirName = values[0];
					for (int j = 1; j <= values.Count -1; j++) 
					{
						_aDescrip.Append( values[j] + " " );
					}	
					
					
				}else{

					values.AddRange( saveStringList[i].Split(' '));
					values.RemoveAll( item => item == String.Empty );
					

					_aSize = values[0];
					for (int j = 3; j <= values.Count -1; j++) 
					{
						_aDescrip.Append( values[j] + " " );
					}	
					
					int index = files.FindIndex( save => (save as SaveFile).FileName == _aDirName );
					files[index].SetSizeAndDescrip(_aSize, _aDescrip.ToString() );
					//Console.WriteLine(aDirName +"\t"+ aSize +"\t"+ aName );
					_aDescrip.Clear();
					
				}
				values.Clear();	
			}
		
			return files;
		}
				
		private void StartProcess( string mcPath, string command )
		{
//			process.StartInfo.Arguments = mcPath + " " + command;
			process.StartInfo.Arguments = String.Format("\"{0}\" {1}", mcPath, command);
			process.Start();			
		}
		
		private List<string> GetInfo( string outPutText)
		{
			List<string> result;
			
			result = ProcessData( outPutText, '\r', '\n' );
			
			return result;		
		}

		private List<SaveFile> DoFiles( List<string> information )
		{
			List<SaveFile> saveFiles = new List<SaveFile>();
			
			foreach( string element in information )
			{
				saveFiles.Add(CreateFile( element ));
			}

			
			
			return saveFiles;
		}
				
		private SaveFile CreateFile( string info )
		{
			List<string> data;
			
			data = ProcessData( info, ' ');
				
			return new SaveFile( data[aDirName], data[aSize], data[aDate] +" "+ data[aHour], data[aDirName] );	
		}
				
		private List<string> ProcessData( string text, params char[] separators )
		{
			List<string> processedData = new List<string>();
			
			processedData.AddRange( text.Split(separators) );
			processedData.RemoveAll( item => item == String.Empty );
			
			return processedData;
		}
		
		private void MakeDir(string mcPath, string folderName)
		{
			Console.WriteLine("Creating folder: {0}\n", folderName );
			
			process.StartInfo.Arguments = String.Format("\"{0}\" {1} \"{2}\"", mcPath, "mkdir", folderName);
			process.Start();
			process.WaitForExit();		
		}

		private void AddFiles( string mcPath, string folderName, string[] files )
		{
			foreach (string file in files) 
			{
				Console.WriteLine("Copying file: {0}", file);
				
				process.StartInfo.Arguments = String.Format("\"{0}\" {1} \"{2}\" \"{3}\"", mcPath, "add -d", folderName, file);
				process.Start();
				process.WaitForExit();					
			}
		}


	}
}
