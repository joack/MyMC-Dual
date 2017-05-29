/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 28/05/2017
 * Hora: 02:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using log4net;

namespace MyMC
{
	/// <summary>
	/// Description of ProcessBar.
	/// </summary>
	public partial class ProcessBar : Form
	{
		private static readonly ILog log = LogHelper.GetLogger();
		
		private IEnumerable<FileInfo> list;
		private int totalFiles;
		private int actualPercent;
		
		public ProcessBar(){InitializeComponent();}
		
		public string McPath{ get; set;}
		
		public IEnumerable<FileInfo> SetList
		{ set
			{ 
				list = value;
				totalFiles = list.Count();
			}
		}
		
		
		void ProcessBarLoad(object sender, EventArgs e)
		{
			actualPercent = 0; 
			DoWork();
		}	

		void Cancel(object sender, EventArgs e)
		{
			backgroundWorker1.CancelAsync();
			
		}
		
		void Close(object sender, EventArgs e)
		{
			Close();
		}		
		
		private void DoWork()
		{
			btnStopClose.Text = "Stop";
			btnStopClose.Click += Cancel;
			
			backgroundWorker1.RunWorkerAsync();
		}
		
		private int CalculatePercent( int num )
		{
			return (num * 100) / totalFiles;
		}	
		
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Thread.Sleep(500);
			foreach(var file in list)
			{
				if (backgroundWorker1.CancellationPending) 
				{
					e.Cancel = true;
					break;
				}else{
					this.Invoke( new Action(()=>
					{
					    ++actualPercent;
					    log.Info("Importing: " + file.FullName);
					    
					    backgroundWorker1.ReportProgress(CalculatePercent(actualPercent));
					    txtFile.Text = String.Format("File: {0}", file.Name);
					    
					    Utils.Card.ImportSave(McPath, file.FullName);
					}));
					Thread.Sleep(50);				
				}
			}
		}
		
		void BackgroundWorker1ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar1.Value = e.ProgressPercentage;
			txtPercent.Text = String.Format("{0}%", e.ProgressPercentage);
		}
		
		void BackgroundWorker1RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if(e.Cancelled)
			{
				txtFile.TextAlign = ContentAlignment.MiddleCenter;
				txtFile.Text = "Import canceled.";
				log.Warn("Import was Cancel.");
			}else{
				txtFile.TextAlign = ContentAlignment.MiddleCenter;
				txtFile.Text = "Import complete.";
				log.Debug("Import files complete.");
			}
			
			btnStopClose.Text = "Close";
			btnStopClose.Click += Close;
		}
		

		

		

	}
}
