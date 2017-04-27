﻿/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 14:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MyMC
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form, ISetExportPath
	{
	
		public MainForm()
		{
			InitializeComponent();
		}
		

		void MainFormLoad(object sender, EventArgs e)
		{
			hourLabel.Text = DateTime.Now.ToString( "HH:mm:ss" );
			util = Util.getUtil( util_MyMc );
			
			label1.Text = "Memory Card Name: ";
			label2.Text = "Memory Card Name: ";
			
			userExportFolder = exportFolder;
			
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;			
			
		}

		
#region Interface methods

		public void SetPath( string path )
		{
			userExportFolder = path;
		}

#endregion
				

#region MenuStrip		

		void CloseMC1ToolStripMenuItemClick(object sender, EventArgs e)
		{
#region Debug
							 //┌─────────────────────────────────────────────────────────────────────────────┐
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
                  			  "Close Mc1 button click.");
#endregion

			memoryCardOne = null;
			
			DisableMcOneButtons();
			label1.Text = "Memory Card Name: ";
			
			if (memoryCardTwo != null )
			{
				toolStripStatusLabel1.Text = memoryCardTwo.GetPath();
				toolStripStatusLabel2.Text = memoryCardTwo.GetFreeSpace();
			}else{
				toolStripStatusLabel1.Text = NO_CARD;
				toolStripStatusLabel2.Text = EMPTY_CARD;
			}
#region Debug
			Console.WriteLine("Close Mc1 button click - Exit." +
                  			  "\n───────────────────────────────────────────────────────────────────────────────");
#endregion			
		}
		
		void CloseMC2ToolStripMenuItemClick(object sender, EventArgs e)
		{
#region Debug
							 //┌─────────────────────────────────────────────────────────────────────────────┐
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
                  			  "Close Mc2 button click.");
#endregion

			memoryCardTwo = null;
			
			DisableMcTwoButtons();
			label2.Text = "Memory Card Name: ";	
			
			if (memoryCardOne != null )
			{
				toolStripStatusLabel1.Text = memoryCardOne.GetPath();
				toolStripStatusLabel2.Text = memoryCardOne.GetFreeSpace();
			}else{
				toolStripStatusLabel1.Text = NO_CARD;
				toolStripStatusLabel2.Text = EMPTY_CARD;
			}			
#region Debug
			Console.WriteLine("Close Mc2 button click - Exit." +
                  			  "\n───────────────────────────────────────────────────────────────────────────────");
#endregion			
		}		

		void CreateMcToolStripMenuItemClick(object sender, EventArgs e)
		{
#region Debug
							 //┌─────────────────────────────────────────────────────────────────────────────┐
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
                  			  "Create Mc button click.");
#endregion
			GenMc vmcForm = new GenMc();
			vmcForm.SetUtil = util_VMC;
			vmcForm.ShowDialog();
#region Debug
			Console.WriteLine("Create Mc button click - Exit." +
                  			  "\n───────────────────────────────────────────────────────────────────────────────");
#endregion			
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		
		void AsPSUToolStripMenuItemCheckedChanged(object sender, EventArgs e)
		{
#region Debug
							 //┌─────────────────────────────────────────────────────────────────────────────┐
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
                  			  "As PSU Mc Checked.");
#endregion
			ToolStripMenuItem item = sender as ToolStripMenuItem;
			
			if( item.Checked )
			{
				mode = MODE_PSU;
			}			
#region Debug
			Console.WriteLine("\nMODE = {0}\n", mode);
			Console.WriteLine("As PSU Checked - Exit." +
                  			  "\n───────────────────────────────────────────────────────────────────────────────");
#endregion			
		}
		
		void AsmaxToolStripMenuItemCheckedChanged(object sender, EventArgs e)
		{
#region Debug
							 //┌─────────────────────────────────────────────────────────────────────────────┐
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
                  			  "As MAX Checked.");
#endregion
			ToolStripMenuItem item = sender as ToolStripMenuItem;
			
			if( item.Checked )
			{
				mode = MODE_MAX;
			}			
#region Debug
			Console.WriteLine("\nMODE = {0}\n", mode);
			Console.WriteLine("As MAX Checked - Exit." +
                  			  "\n───────────────────────────────────────────────────────────────────────────────");
#endregion
		}
			
		
		void OutputDirToolStripMenuItemClick(object sender, EventArgs e)
		{
#region Debug
							 //┌─────────────────────────────────────────────────────────────────────────────┐
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
                  			  "Output Dir button click.\n");
		 	Console.WriteLine("Old Path = {0}", userExportFolder);
#endregion
			ExportPathChooser form = new ExportPathChooser();
			form.Path = userExportFolder;
			
			form.ShowDialog(this);
#region Debug
			Console.WriteLine("New Path = {0}\n", userExportFolder);
			Console.WriteLine("Output Dir button click - Exit." +
                  			  "\n───────────────────────────────────────────────────────────────────────────────");
#endregion	
		}


		void MyMcDualToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("MyMc Dual:\n" +
			                "\tThis tool makes use of MYMC PS2 tool command line\n" +
			                "\tand Genvmc tool command line.\n" +
			                "\tThe thanks goes to the respective authors.\n\n" +
			               	"Author: Joack.", "About MyMc Dual");
		}
		
#endregion		

		
#region ToolStrip
		
		void OpenMcOneButtonClick(object sender, EventArgs e)
		{

#region	Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Open Mc1 button click.\n");
#endregion	
			memoryCardOne = OpenMc( memoryCardOne );
			
			if (memoryCardOne != null) 
			{
#region	Debug
				Console.WriteLine("\nMc1 is not null.\n");
				DebugMc(memoryCardOne);
#endregion				
				label1.Text = "Memory Card Name: " + Path.GetFileName(memoryCardOne.GetPath());
				EnableMcOneButtons();
				ShowMcContent( memoryCardOne, dataGridView1 );				
			}
#region	Debug		
			else{
				//Debug prupose
				Console.WriteLine("\nMc1 is null.\n");
			}
			
			Console.WriteLine("\nOpen Mc1 button click - Exit.\n" +
                  			  "───────────────────────────────────────────────────────────────────────────────\n");
#endregion						
		}
		
		void OpenMcTwoButtonClick(object sender, EventArgs e)
		{
			
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Open Mc2 button click.\n");	
#endregion
			memoryCardTwo = OpenMc( memoryCardTwo );
			
			if (memoryCardTwo != null) 
			{
				
#region Debug
				Console.WriteLine("\nMc2 is not null.\n");
				DebugMc(memoryCardTwo);
#endregion		
				label2.Text = "Memory Card Name: " + Path.GetFileName(memoryCardTwo.GetPath());
				EnableMcTwoButtons();
				ShowMcContent( memoryCardTwo, dataGridView2 );				
			}			
#region	Debug		
			else{
				//Debug prupose
				Console.WriteLine("\nMc2 is null.\n");
			}
			
			Console.WriteLine("Open Mc2 button click - Exit.\n" +
							  "───────────────────────────────────────────────────────────────────────────────\n");
#endregion			
		}


		void ImportToMcOneButtonClick(object sender, EventArgs e)
		{
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Import to Mc1 button click.\n");	
#endregion

			OpenFileDialog importOpenDialog = getImportFileDialog();
			
			if(importOpenDialog.ShowDialog() == DialogResult.OK )
			{
#region debug
				Console.WriteLine("Ok button.");
#endregion
				string mcPath = memoryCardOne.GetPath();
				lastOpenSaveDir = Path.GetDirectoryName( importOpenDialog.FileNames[0] );
#region Debug
				Console.WriteLine("Importing:\n");
#endregion				
				foreach( string importFile in importOpenDialog.FileNames)
				{
#region Debug
					Console.WriteLine(importFile);
#endregion
					util.ImportSaveUtil( mcPath, importFile );
				}
				
			}
#region debug
			else{
				Console.WriteLine("Cancel Button.");
			}
#endregion	
			memoryCardOne = RefreshMemoryCard(memoryCardOne, dataGridView1);
#region Debug
			DebugMc(memoryCardOne);
			Console.WriteLine("\nImport to Mc1 button click - Exit.\n" +
                  			  "───────────────────────────────────────────────────────────────────────────────");	
#endregion
			
		}
		
		void ImportToMcTwoButtonClick(object sender, EventArgs e)
		{
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Import to Mc2 button click.\n");	
#endregion
			OpenFileDialog importOpenDialog = getImportFileDialog();
			
			if(importOpenDialog.ShowDialog() == DialogResult.OK )
			{
				string mcPath = memoryCardTwo.GetPath();
#region Debug
				Console.WriteLine("Importing:\n");
#endregion
								
				foreach( string importFile in importOpenDialog.FileNames)
				{
#region Debug
					Console.WriteLine(importFile);
#endregion		
					util.ImportSaveUtil( mcPath, importFile );
				}
			}
			memoryCardTwo = RefreshMemoryCard(memoryCardTwo, dataGridView2);
			
#region Debug
			DebugMc(memoryCardTwo);
			Console.WriteLine("\nImport to Mc2 button click - Exit.\n" +
                  			  "───────────────────────────────────────────────────────────────────────────────");	
#endregion
		}

		
		void ExportSaveButtonClick(object sender, EventArgs e)
		{	
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Export Save Button Click\n");
#endregion
	
			MemoryCard memCard = null;
			
			
			switch (focusedMemmoryCard.Name) 
			{
				case "dataGridView1":
					memCard = memoryCardOne;
					break;
					
				case "dataGridView2":
					memCard = memoryCardTwo;
					break;
				default:
					
					break;
			}
			

			if (memCard != null) 
			{
				DataGridViewSelectedRowCollection savesCollection = focusedMemmoryCard.SelectedRows;
				string filePath = String.Empty;

#region Debug
				Console.WriteLine("Exporting files\n");
				Console.WriteLine("{0,-20} {1,5} {2,-25} {3}", "Name", "Size", "Date", "Description\n");
#endregion					
	
				foreach (DataGridViewRow row in savesCollection) 
				{
					util.ExportSaveUtil(memCard.GetPath(), row.Cells[0].Value.ToString(), userExportFolder, mode );
#region Debug
					Console.WriteLine("{0,-20} {1,5} {2,-25} {3}",row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), 
					                  								  row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
#endregion	

				}
#region Debug
				Console.WriteLine();
				
				MessageBox.Show("Finish export files.");
#endregion					
					
			}
#region Debug
			else{
				Console.WriteLine("No memory card opened.");
				
			}
#endregion				

#region Debug
			Console.WriteLine("Export Save Button Click - Exit\n" +
			                  "───────────────────────────────────────────────────────────────────────────────");
#endregion										
		}

	
		void McOneToMcTwoButtonClick(object sender, EventArgs e)
		{
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Mc1 to Mc2 file transfer Button Click\n");
#endregion
			if (memoryCardTwo != null)
			{
				TransferSaves( memoryCardOne, memoryCardTwo, dataGridView1 );
				memoryCardTwo = RefreshMemoryCard( memoryCardTwo, dataGridView2);
#region Debug
				DebugMc(memoryCardTwo);
#endregion
				
			}else{
				MessageBox.Show("You must open a memory card on the side 2.");
			}
#region debug
			Console.WriteLine("\nMc1 to Mc2 file transfer Button Click - Exit.\n" +
                  			  "───────────────────────────────────────────────────────────────────────────────");	
#endregion			
		}
		
		void McTwoToMcOneButtonClick(object sender, EventArgs e)
		{
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Mc2 to Mc1 file transfer Button Click\n");
#endregion
			if (memoryCardOne != null)
			{
				TransferSaves( memoryCardTwo, memoryCardOne, dataGridView2 );
				memoryCardOne = RefreshMemoryCard( memoryCardOne, dataGridView1);
				
#region	Debug
				DebugMc(memoryCardOne);	
#endregion				
			}else{
				MessageBox.Show("You must open a memory card on the side 1.");
			}
#region debug
			Console.WriteLine("\nMc2 to Mc1 file transfer Button Click - Exit.\n" +
                  			  "───────────────────────────────────────────────────────────────────────────────");	
#endregion			
		}		

		
		void DeleteSaveButtonClick(object sender, EventArgs e)
		{	
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Delete Save Button Click\n\n" +
                  			  "Deleting file(s):\n");
#endregion			
			if (focusedMemmoryCard.Name == "dataGridView1") 
			{
				memoryCardOne = DoDelete( ref memoryCardOne );
				
#region	Debug
				DebugMc(memoryCardOne);
#endregion				
			}else{
				memoryCardTwo = DoDelete( ref memoryCardTwo );
								
#region Debug
				DebugMc(memoryCardTwo);
#endregion
			}
#region debug
			Console.WriteLine("\nDelete Save Button Click - Exit.\n" +
                  			  "───────────────────────────────────────────────────────────────────────────────");	
#endregion
			
		}	
		
#endregion
		

#region StatusStrip		
		
		void ToolStripStatusLabel1Click(object sender, EventArgs e)
		{
			string pathDir = toolStripStatusLabel1.Text;
			
			if (pathDir != null && pathDir != String.Empty && pathDir != NO_CARD ) 
			{
				System.Diagnostics.Process.Start("explorer.exe", String.Format("/select, \"{0}\"", pathDir));
			}			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			hourLabel.Text = DateTime.Now.ToString( "HH:mm:ss" );
		}		
		
#endregion
		
		
#region My Methods
		
		private MemoryCard OpenMc( MemoryCard card )
		{
			mcOpenDialog.Reset();
			mcOpenDialog.Filter = "PS2 File Format|*.ps2|PS2 File Bin Format|*.bin";
			mcOpenDialog.FilterIndex = 2;
			mcOpenDialog.InitialDirectory = lastOpenMcDir;
			
			mcOpenDialog.FileName = "";
			mcOpenDialog.Multiselect = false;
			
			
			
			if( mcOpenDialog.ShowDialog() == DialogResult.OK )
			{
#region Debug
				Console.WriteLine("Ok button");
#endregion
				string mc = mcOpenDialog.FileName;
				lastOpenMcDir = Path.GetDirectoryName( mcOpenDialog.FileName );
	
				return new MemoryCard( mc, util.loadFiles( mc ), util.GetMcFreeSpace( mc ) );
			}	
#region Debug
				Console.WriteLine("Cancel button");
#endregion			
			return card;			
		}
				
		private void ShowMcContent( IMemoryCard card, DataGridView mcView )
		{
			mcView.Rows.Clear();
			
			
			List<SaveFile> listFiles = card.LoadSaves();
			
			for (int i = 2; i <= listFiles.Count -1; i++) 
			{
				SaveFile save = listFiles[i];
				mcView.Rows.Add( save.FileName, save.FileSize, save.FileDate, save.FileDescription );
			}
			
			toolStripStatusLabel1.Text = card.GetPath();
			toolStripStatusLabel2.Text = card.GetFreeSpace();
				
		}
			
		private void EnableMcOneButtons()
		{
			importToMcOneButton.Enabled 		= true;
			mcOneToMcTwoButton.Enabled 			= true;
			dataGridView1.Enabled 				= true;
			closeMC1ToolStripMenuItem.Enabled 	= true;
			deleteSaveButton.Enabled 			= true;	
			ExportSaveButton.Enabled 			= true;
		}
		
		private void EnableMcTwoButtons()
		{
			importToMcTwoButton.Enabled 		= true;
			mcTwoToMcOneButton.Enabled  		= true;
			dataGridView2.Enabled				= true;
			closeMC2ToolStripMenuItem.Enabled 	= true;
			deleteSaveButton.Enabled			= true;
			ExportSaveButton.Enabled 			= true;
		}	
	
		private void DisableMcOneButtons()
		{
			importToMcOneButton.Enabled = false;
			mcOneToMcTwoButton.Enabled = false;
			dataGridView1.Rows.Clear();
			dataGridView1.Enabled = false;
			closeMC1ToolStripMenuItem.Enabled = false;
			
			if (memoryCardTwo == null) 
			{
				ExportSaveButton.Enabled = false;
				deleteSaveButton.Enabled = false;
			}			
		}
		
		private void DisableMcTwoButtons()
		{
			importToMcTwoButton.Enabled = false;
			mcTwoToMcOneButton.Enabled = false;
			dataGridView2.Rows.Clear();
			dataGridView2.Enabled = false;
			closeMC2ToolStripMenuItem.Enabled = false;
			
			if (memoryCardOne == null)
			{
				ExportSaveButton.Enabled = false;
				deleteSaveButton.Enabled = false;
			}			
		}
		
		private void OnFocusMemoryCard(object sender, EventArgs e)
		{
		 	focusedMemmoryCard = sender as DataGridView;	

			
			switch (focusedMemmoryCard.Name) {
				case "dataGridView1":
		 			
		 			if (memoryCardOne != null)
		 			{
		 				toolStripStatusLabel1.Text = memoryCardOne.GetPath();
		 				toolStripStatusLabel2.Text = memoryCardOne.GetFreeSpace(); 
		 			}else{
		 				toolStripStatusLabel1.Text = NO_CARD;
		 				toolStripStatusLabel2.Text = EMPTY_CARD; 
		 				
		 				//focusedMemmoryCard = dataGridView2;
		 				
		 			}
		 			
		 			break;
					
				case "dataGridView2":
		 			
		 			if (memoryCardTwo != null)
		 			{
		 				toolStripStatusLabel1.Text = memoryCardTwo.GetPath();
		 				toolStripStatusLabel2.Text = memoryCardTwo.GetFreeSpace(); 
		 			}else{
		 				toolStripStatusLabel1.Text = NO_CARD;
		 				toolStripStatusLabel2.Text = EMPTY_CARD; 
		 			}
		 			
		 			break;
					
				default:
		 			toolStripStatusLabel1.Text = NO_CARD;
					toolStripStatusLabel2.Text = EMPTY_CARD;
					break;
			}
			
		 	//MessageBox.Show(focusedMemmoryCard.Name);
		}
		
		private string DoFileName( string sourceFile , string destinyDir )
		{
			string fileName = Path.GetFileNameWithoutExtension(sourceFile);
			string fileExt  = Path.GetExtension(sourceFile);
			string fileFullName = String.Format("{0}{1}", fileName, fileExt);
			
			int index = 1;
			
			while(File.Exists( destinyDir + "\\" + fileFullName) )
			{
				fileFullName = String.Format( "{0}({1}){2}", fileName, index, fileExt);
				index++;
			}
			return destinyDir + fileFullName;
		}
			
		private void TransferSaves( MemoryCard cardFrom, MemoryCard cardTo, DataGridView selectedCard )
		{
			if(	cardTo != null )
			{
#region Debug
				Console.WriteLine("Transferring files.\n");
				Console.WriteLine("From: {0}", cardFrom.GetPath());
				Console.WriteLine("To: {0}\n", cardTo.GetPath());
#endregion

				DataGridViewSelectedRowCollection savesCollection = selectedCard.SelectedRows;
				
				string filePath 	= String.Empty;
				string saveName		= String.Empty;
				string mcPathFrom 	= cardFrom.GetPath();
				string mcPathTo 	= cardTo.GetPath();
				
				foreach (DataGridViewRow row in savesCollection) 
				{
					saveName = row.Cells[0].Value.ToString();
#region Debug
					Console.WriteLine("Exporting file {0} from {1}", saveName, mcPathFrom );
#endregion					
					util.ExportSaveUtil(mcPathFrom, saveName, tempFolder, MODE_PSU);
					
					filePath = String.Format("{0}\\{1}{2}", tempFolder, saveName, ".psu");
#region Debug
					Console.WriteLine("Importing file {0} to {1}", saveName, mcPathTo );
#endregion						
					util.ImportSaveUtil(mcPathTo, filePath);
#region Debug
					Console.WriteLine("Deleting  file {0}\n", filePath);
#endregion					
					File.Delete(filePath);
				}	
			}
		}

		private MemoryCard DoDelete( ref MemoryCard card )
		{		
			if (card != null && card.LoadSaves().Count > 2)
			{
				DialogResult result = MessageBox.Show("This action can't be undone!\nAre you sure?", "Delete save(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			
				if (result == DialogResult.OK) 
				{
#region Debug
				Console.WriteLine("Ok button");
#endregion					
					string mcPath = card.GetPath();
					DataGridViewSelectedRowCollection savesCollection = focusedMemmoryCard.SelectedRows;
					
					
					foreach (DataGridViewRow row in savesCollection) 
					{
#region Debug
						Console.WriteLine(row.Cells[0].Value.ToString());
#endregion
						util.DeleteSaveUtil(mcPath, row.Cells[0].Value.ToString());
					}				
									
					return RefreshMemoryCard( card, focusedMemmoryCard);
				}						
#region Debug
				Console.WriteLine("Cancel button");
#endregion				
			}else{
				MessageBox.Show("Unable to delete.");
			}	

			return card;
		}
	
#region Others
//		private void RefreshMemoryCard(ref MemoryCard card, DataGridView view)
//		{
//			string mcPath = card.GetPath();
//			
//			card = null;
//			
//			card = new MemoryCard( mcPath, util.loadFiles( mcPath ), util.GetMcFreeSpace( mcPath ) );
//			
//			
//			ShowMcContent( card, view );	
//		}
#endregion
		
		private MemoryCard RefreshMemoryCard( MemoryCard memCard, DataGridView view)
		{
			string mcPath = memCard.GetPath();
			
			MemoryCard card = new MemoryCard( mcPath, util.loadFiles( mcPath ), util.GetMcFreeSpace( mcPath ) );
			
			
			ShowMcContent( card, view );

			return card;
		}		

		private OpenFileDialog getImportFileDialog()
		{
			OpenFileDialog openDialog = new OpenFileDialog();

			openDialog.Filter = "EMS file|*.psu|Max Drive file|*.max|Codebreaker file|*.cbs|SharkPort file|*.npo|All files|*.*";
			openDialog.FilterIndex = 1;
			openDialog.Multiselect = true;
			openDialog.InitialDirectory = lastOpenSaveDir;
			
			return openDialog;
		}

		private void UncheckOtherToolStripMenuItems(object sender, EventArgs e )
		{
			ToolStripMenuItem item = sender as ToolStripMenuItem;
			
			foreach (ToolStripMenuItem menuItem in item.GetCurrentParent().Items)
			{
				menuItem.Checked = false;
			}
	
			item.Checked = true;
		}
	
		private void OnDragAndDrop( object sender, DragEventArgs e )
		{
#region Debug
			Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
							  "Drag and Drop event\n");
#endregion			
			
			DataGridView focusedCard = sender as DataGridView;
			string[] droppedFolders = (string[])e.Data.GetData(DataFormats.FileDrop);
			
			switch (focusedCard.Name) 
			{
				case "dataGridView1":
					if (memoryCardOne != null) 
					{
						DoDragAndDrop( memoryCardOne, droppedFolders );
						memoryCardOne = RefreshMemoryCard(memoryCardOne, dataGridView1);
					}else{
						MessageBox.Show("You need to open a memory card.");
					}
					
					break;
					
				case "dataGridView2":
					if (memoryCardTwo != null) 
					{
						DoDragAndDrop( memoryCardTwo, droppedFolders );
						memoryCardTwo = RefreshMemoryCard(memoryCardTwo, dataGridView2);
					}else{
						MessageBox.Show("You need to open a memory card.");
					}	
					break;					
			}
#region debug
			Console.WriteLine("\nDrag and Drop event - exit.\n" +
                  			  "───────────────────────────────────────────────────────────────────────────────");	
#endregion		
		}

		private void DoDragAndDrop( MemoryCard card , string[] droppedFolders )
		{
			string mcPath = card.GetPath();
			
			foreach (string folder in droppedFolders ) 
			{
				util.AddRawFile( mcPath, folder);
			}
		}
		
#endregion		


#region MC Debug

	private void DebugMc(MemoryCard memory)
	{
		// ─ │┌ ┐└ ┘├ ┤┬ ┴ ┼
		Console.WriteLine("┌─────────────────────┐");
		Console.WriteLine("│     MEMORY CARD     │");
		Console.WriteLine("└─────────────────────┘\n");
		
		Console.WriteLine("Memory card Path: {0}", memory.GetPath());
		Console.WriteLine("Memory card Free space: {0}", memory.GetFreeSpace());
		Console.WriteLine("Memory card save count: {0}\n", memory.LoadSaves().Count -2);
		
		Console.WriteLine("Memory card Save List:\n");
		
		List<SaveFile> saveList = memory.LoadSaves();

		for( int i = 2; i < saveList.Count; i++ )
		{
			Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────┐");
			Console.WriteLine("│  FILE Nº {0,-67}│", String.Format("{0:D3}", i -1));
			Console.WriteLine("├─────────────────────────────────────────────────────────────────────────────┤");
			Console.WriteLine("│ Save Name: {0,-65}|", saveList[i].FileName );
			Console.WriteLine("│ Save Size: {0,-65}|", saveList[i].FileSize);
			Console.WriteLine("│ Save Date: {0,-65}|", saveList[i].FileDate);
			Console.WriteLine("│ Save Description: {0,-58}|", saveList[i].FileDescription);
			Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
			Console.WriteLine();
		}
	}

#endregion

	
		
		void DataGridViewDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true ) 
			{
				e.Effect = DragDropEffects.All;	
			}
		}
	}
}