/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 28/05/2017
 * Hora: 02:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MyMC
{
	partial class ProcessBar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.txtPercent = new System.Windows.Forms.Label();
			this.btnStopClose = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.txtFile = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 49);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(350, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// txtPercent
			// 
			this.txtPercent.Location = new System.Drawing.Point(160, 75);
			this.txtPercent.Name = "txtPercent";
			this.txtPercent.Size = new System.Drawing.Size(53, 23);
			this.txtPercent.TabIndex = 1;
			this.txtPercent.Text = "0%";
			this.txtPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnStopClose
			// 
			this.btnStopClose.Location = new System.Drawing.Point(149, 114);
			this.btnStopClose.Name = "btnStopClose";
			this.btnStopClose.Size = new System.Drawing.Size(75, 23);
			this.btnStopClose.TabIndex = 2;
			this.btnStopClose.Text = "Button";
			this.btnStopClose.UseVisualStyleBackColor = true;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerReportsProgress = true;
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(12, 23);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(350, 23);
			this.txtFile.TabIndex = 1;
			this.txtFile.Text = "Path:";
			this.txtFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ProcessBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 149);
			this.Controls.Add(this.btnStopClose);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.txtPercent);
			this.Controls.Add(this.progressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProcessBar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Processing Data";
			this.Load += new System.EventHandler(this.ProcessBarLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label txtFile;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btnStopClose;
		private System.Windows.Forms.Label txtPercent;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}
