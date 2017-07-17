/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 21/05/2017
 * Hora: 02:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using log4net;
using MyMCLibrary.StrBuilderMethods;

namespace MyMCLibrary
{
	/// <summary>
	/// Description of Utils.
	/// </summary>
	public partial class Utils
	{
		//private static readonly ILog log = LogHelper.GetLogger();
		
		public partial class Card
		{
			static Card()
			{
				process = new Process();
				process.StartInfo.FileName = mymc;			
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.RedirectStandardOutput = true; 
			}
			
	
			public static List<SaveFile> LoadFiles( string mcPath )
			{			
				process.StartInfo.Arguments = mcPath + " ls";
				process.Start();
					
				return ProcessOutPut( mcPath);
			}
			
			public static void ExportSave( string mcPath, string fileName, string outPutDir, string exportMode )
			{
				process.StartInfo.Arguments = String.Format("\"{0}\" {1} {2} {3} \"{4}\" {5}", mcPath, "export", exportMode, "-d", outPutDir, fileName);
				
				process.Start();
				process.WaitForExit();
			}			

			public static void ImportSave( string mcPath, string pathFile )
			{
				process.StartInfo.Arguments = String.Format("\"{0}\" {1} \"{2}\"", mcPath, "import", pathFile);
				process.Start();
				process.WaitForExit();
			}	
		
			public static void DeleteSave( string mcPath, string fileName )
			{
				process.StartInfo.Arguments = String.Format("\"{0}\" {1} {2}", mcPath, "delete", fileName);
				process.Start();
				process.WaitForExit();	
			}

			public static string GetMcFreeSpace( string mcPath )
			{
				StartProcess( mcPath, "dir" );
				
				return GetFreeSpace( process.StandardOutput.ReadToEnd(), mcPath );
			}			
			
			public static void AddRawFile( string mcPath, string folderPath )
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
			
			public static void CopyAllCard( string mcPathFrom, string mcPathTo )
			{
				var listSaves = LoadFiles(mcPathFrom);
				var filePath = String.Empty;
				
				foreach (var save in listSaves) 
				{
					filePath = String.Format("{0}\\{1}.psu", tempFolder, save.FileName);
					
					ExportSave( mcPathFrom, save.FileName, tempFolder, "-p");
					ImportSave( mcPathTo, filePath );
					
					Cleaner.DeleteTemp( filePath );
				}
				//log.Debug("Utils.Card class");
			}
	
			public static string CreateCard( string size, string fileName )
			{
				var p = new Process();
				
				p.StartInfo.FileName = genvmc;
				p.StartInfo.Arguments = String.Format("{0} \"{1}\\{2}.bin\"", size, tempFolder, fileName);
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.CreateNoWindow = true;
				p.StartInfo.RedirectStandardOutput = true; 	

				p.Start();
				p.WaitForExit();
				
				return String.Format("{0}\\{1}.bin", tempFolder, fileName );
			}
			
			public static string CreateCard( string size, string path, string fileName, string extension )
			{
				var p = new Process();
				
				p.StartInfo.FileName = genvmc;
				p.StartInfo.Arguments = String.Format("{0} \"{1}\\{2}{3}\"", size, path, fileName, extension);
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.CreateNoWindow = true;
				p.StartInfo.RedirectStandardOutput = true; 	

				p.Start();
				p.WaitForExit();
				
				return String.Format("{0}\\{1}{2}", path, fileName, extension );
			}			
			
//			public static void CopyToCard( string mcPathFrom, string mcPathTo, IEnumerable listSaves )
//			{
//				//var listSaves = LoadFiles(mcPathFrom);
//				var filePath = String.Empty;
//				
//				foreach (var save in listSaves) 
//				{
//					filePath = String.Format("{0}\\{1}.psu", tempFolder, save.FileName);
//					
//					ExportSave( mcPathFrom, save.FileName, tempFolder, "-p");
//					ImportSave( mcPathTo, filePath );
//					
//					Cleaner.DeleteTemp( filePath );
//				}
//				log.Debug("Utils.Card class");
//			}			
			
			
			
			//===========================================================================================================

			private static List<SaveFile> ProcessOutPut( string mcPath )
			{				
				return UpdateFiles(mcPath, MakeFiles( mcPath ));
			}

			private static List<SaveFile> UpdateFiles( string mcPath, List<SaveFile> files )
			{
				StartProcess(mcPath, "dir");
				
				return UpdateSaves(files, process.StandardOutput.ReadToEnd(), mcPath);
			}

			private static List<SaveFile> UpdateSaves( List<SaveFile> files, string output, string mcPath )
			{
				List<string> saveStringList = GetInfo( output, mcPath );
				
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

			private static List<SaveFile> MakeFiles( string mcPath )
			{
				StartProcess(mcPath, "ls");
			
				return DoFiles(GetInfo( process.StandardOutput.ReadToEnd(), mcPath ));
			}

			private static List<SaveFile> DoFiles( List<string> information )
			{
				List<SaveFile> saveFiles = new List<SaveFile>();
				
				foreach( string element in information )
				{
					saveFiles.Add(CreateFile( element ));
				}
	
				return saveFiles;
			}


			private static string GetFreeSpace( string output, string mcPath )
			{
				List<string> list = GetInfo(output, mcPath);
				
				return list[list.Count -1];
			}
			

			private static SaveFile CreateFile( string info )
			{
				List<string> data;
				
				data = ProcessData( info, ' ');
					
				return new SaveFile( data[aDirName], data[aSize], data[aDate] +" "+ data[aHour], data[aDirName] );	
			}			
			
			
			
			private static List<string> GetInfo( string outPutText, string mcPath)
			{
				List<string> result;
				
				result = ProcessData( outPutText, '\r', '\n' );
				
				if (ECCChecker.DoCheck(mcPath)) 
				{
					return result;	
				}else{
					var sets = new HashSet<string>(){"corrected 1", "corrected 2", "corrected 3"};
					
					if (sets.Contains(result[2]))
					{
						result.RemoveRange(0,3);
						
					}else{
						result.RemoveRange(0,2);
					}
					
					return result;
				}
						
			}			

			private static List<string> ProcessData( string text, params char[] separators )
			{
				List<string> processedData = new List<string>();
				
				processedData.AddRange( text.Split(separators) );
				processedData.RemoveAll( item => item == String.Empty );
				
				return processedData;
			}
			
			
			
			private static void StartProcess( string mcPath, string command )
			{
				process.StartInfo.Arguments = String.Format("\"{0}\" {1}", mcPath, command);
				process.Start();			
			}			
		
			private static void MakeDir(string mcPath, string folderName)
			{
				Console.WriteLine("Creating folder: {0}\n", folderName );
				
				process.StartInfo.Arguments = String.Format("\"{0}\" {1} \"{2}\"", mcPath, "mkdir", folderName);
				process.Start();
				process.WaitForExit();		
			}

			private static void AddFiles( string mcPath, string folderName, string[] files )
			{
				foreach (string file in files) 
				{
					Console.WriteLine("Copying file: {0}", file);
					
					process.StartInfo.Arguments = String.Format("\"{0}\" {1} \"{2}\" \"{3}\"", mcPath, "add -d", folderName, file);
					process.Start();
					process.WaitForExit();					
				}
			}
	

			private static void DoCopy( List<SaveFile> listSave )
			{
			
			}
		}
		
		
		
		public partial class ECCChecker
		{			
			static ECCChecker()
			{
				p = new Process();
			
				p.StartInfo.FileName = utilFolder + "\\ECC_Checker.exe";
			
			
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.CreateNoWindow = true;
				p.StartInfo.RedirectStandardOutput = true;
			}
			
			public static bool DoCheck( string mcPath )
			{
				p.StartInfo.Arguments = String.Format( "\"{0}\"", mcPath );
				
				p.Start();
				
				return Boolean.Parse(p.StandardOutput.ReadToEnd());	
			}
			

		}
	
	
		
		public partial class Convert
		{
			static Convert()
			{
				p = new Process();
				p.StartInfo.FileName = utilFolder + "\\convpcsx.exe";
				p.StartInfo.WorkingDirectory = tempFolder;
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.CreateNoWindow = true;
				p.StartInfo.RedirectStandardOutput = true;			
			}
			
			public static void ConvertToBin(string cardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2b \"{2}\\{1}.bin\"", tempFolder, cardName, outputDir);
				Start();
			}

			public static void ConvertToBin(string cardName, string newCardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2b \"{2}\\{3}.bin\"", tempFolder, cardName, outputDir, newCardName);
				Start();
			}
			
			public static void ConvertToPs2(string cardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2b \"{2}\\{1}.ps2\"", tempFolder, cardName, outputDir);
				Start();			
			}
	
			public static void ConvertToPs2(string cardName, string newCardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2b \"{2}\\{3}.ps2\"", tempFolder, cardName, outputDir, newCardName);
				Start();			
			}
			
			public static void ConvertToBinECC(string cardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2p \"{2}\\{1}.bin\"", tempFolder, cardName, outputDir);
				Start();
			}
			
			public static void ConvertToBinECC(string cardName, string newCardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2p \"{2}\\{3}.bin\"", tempFolder, cardName, outputDir, newCardName);
				Start();
			}			
			
			public static void ConvertToPs2ECC(string cardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2p \"{2}\\{1}.ps2\"", tempFolder, cardName, outputDir);
				Start();			
			}
			
			public static void ConvertToPs2ECC(string cardName, string newCardName, string outputDir)
			{
				p.StartInfo.Arguments = String.Format("\"{0}\\{1}.bin\" -2p \"{2}\\{3}.ps2\"", tempFolder, cardName, outputDir, newCardName);
				Start();			
			}			

			private static void Start()
			{
				p.Start();
				p.WaitForExit();
			}
			
		}
		
		
		
		public partial class Cleaner
		{
			static Cleaner()
			{
				p = new Process();
				p.StartInfo.FileName = tempFolder + "\\Cleaner.bat";
				p.StartInfo.WorkingDirectory = tempFolder;
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.CreateNoWindow = true;
				p.StartInfo.RedirectStandardOutput = true;	
			}
					
			public static void DeleteTemp( string tempFile )
			{
				p.StartInfo.Arguments = tempFile;
				
				p.Start();
				p.WaitForExit();		
			}		
		}
		
		
		
	}
}
