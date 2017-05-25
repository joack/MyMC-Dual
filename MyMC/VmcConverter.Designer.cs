/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 24/05/2017
 * Hora: 01:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MyMC
{
	partial class VmcConverter
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button browseFileBtn;
		private System.Windows.Forms.TextBox txtInputPath;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton ps2RadioBtn;
		private System.Windows.Forms.RadioButton binRadioBtn;
		private System.Windows.Forms.Button browseFolderBtn;
		private System.Windows.Forms.TextBox txtFolderPath;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox eccCheck;
		private System.Windows.Forms.Button convertBtn;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog mcOpenDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.browseFileBtn = new System.Windows.Forms.Button();
			this.txtInputPath = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.browseFolderBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFolderPath = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.eccCheck = new System.Windows.Forms.CheckBox();
			this.ps2RadioBtn = new System.Windows.Forms.RadioButton();
			this.binRadioBtn = new System.Windows.Forms.RadioButton();
			this.convertBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.mcOpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.browseFileBtn);
			this.groupBox1.Controls.Add(this.txtInputPath);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 83);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input card:";
			// 
			// browseFileBtn
			// 
			this.browseFileBtn.Location = new System.Drawing.Point(152, 45);
			this.browseFileBtn.Name = "browseFileBtn";
			this.browseFileBtn.Size = new System.Drawing.Size(75, 23);
			this.browseFileBtn.TabIndex = 1;
			this.browseFileBtn.Text = "Browse";
			this.browseFileBtn.UseVisualStyleBackColor = true;
			this.browseFileBtn.Click += new System.EventHandler(this.BrowseFileBtnClick);
			// 
			// txtInputPath
			// 
			this.txtInputPath.Location = new System.Drawing.Point(6, 19);
			this.txtInputPath.Name = "txtInputPath";
			this.txtInputPath.Size = new System.Drawing.Size(374, 20);
			this.txtInputPath.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.browseFolderBtn);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtFolderPath);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(12, 108);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(386, 257);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output card: ";
			// 
			// browseFolderBtn
			// 
			this.browseFolderBtn.Location = new System.Drawing.Point(152, 206);
			this.browseFolderBtn.Name = "browseFolderBtn";
			this.browseFolderBtn.Size = new System.Drawing.Size(75, 23);
			this.browseFolderBtn.TabIndex = 1;
			this.browseFolderBtn.Text = "Browse";
			this.browseFolderBtn.UseVisualStyleBackColor = true;
			this.browseFolderBtn.Click += new System.EventHandler(this.BrowseFolderBtnClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Output folder: ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "New name: ";
			// 
			// txtFolderPath
			// 
			this.txtFolderPath.Location = new System.Drawing.Point(6, 180);
			this.txtFolderPath.Name = "txtFolderPath";
			this.txtFolderPath.Size = new System.Drawing.Size(374, 20);
			this.txtFolderPath.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 130);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(155, 20);
			this.textBox2.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.eccCheck);
			this.groupBox3.Controls.Add(this.ps2RadioBtn);
			this.groupBox3.Controls.Add(this.binRadioBtn);
			this.groupBox3.Location = new System.Drawing.Point(6, 30);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(374, 62);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Output options:  ";
			// 
			// eccCheck
			// 
			this.eccCheck.Location = new System.Drawing.Point(257, 20);
			this.eccCheck.Name = "eccCheck";
			this.eccCheck.Size = new System.Drawing.Size(87, 24);
			this.eccCheck.TabIndex = 2;
			this.eccCheck.Text = "ECC Block";
			this.eccCheck.UseVisualStyleBackColor = true;
			this.eccCheck.MouseEnter += new System.EventHandler(this.EccCheckMouseEnter);
			this.eccCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EccCheckMouseUp);
			// 
			// ps2RadioBtn
			// 
			this.ps2RadioBtn.Location = new System.Drawing.Point(146, 19);
			this.ps2RadioBtn.Name = "ps2RadioBtn";
			this.ps2RadioBtn.Size = new System.Drawing.Size(75, 24);
			this.ps2RadioBtn.TabIndex = 0;
			this.ps2RadioBtn.TabStop = true;
			this.ps2RadioBtn.Text = ".ps2";
			this.ps2RadioBtn.UseVisualStyleBackColor = true;
			// 
			// binRadioBtn
			// 
			this.binRadioBtn.Location = new System.Drawing.Point(35, 19);
			this.binRadioBtn.Name = "binRadioBtn";
			this.binRadioBtn.Size = new System.Drawing.Size(69, 24);
			this.binRadioBtn.TabIndex = 0;
			this.binRadioBtn.TabStop = true;
			this.binRadioBtn.Text = ".bin";
			this.binRadioBtn.UseVisualStyleBackColor = true;
			// 
			// convertBtn
			// 
			this.convertBtn.Location = new System.Drawing.Point(47, 381);
			this.convertBtn.Name = "convertBtn";
			this.convertBtn.Size = new System.Drawing.Size(75, 23);
			this.convertBtn.TabIndex = 2;
			this.convertBtn.Text = "Convert";
			this.convertBtn.UseVisualStyleBackColor = true;
			this.convertBtn.Click += new System.EventHandler(this.ConvertBtnClick);
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(276, 381);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(75, 23);
			this.closeBtn.TabIndex = 2;
			this.closeBtn.Text = "Close";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.CloseBtnClick);
			// 
			// mcOpenDialog
			// 
			this.mcOpenDialog.FileName = "openFileDialog1";
			// 
			// VmcConverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 426);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.convertBtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "VmcConverter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "VmcConverter";
			this.Load += new System.EventHandler(this.VmcConverterLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
