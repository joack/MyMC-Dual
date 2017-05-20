/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 15/02/2017
 * Hora: 14:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MyMC
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMC2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exportSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.asPSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.asmaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.myMcDualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.hourLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.OpenMcOneButton = new System.Windows.Forms.ToolStripButton();
			this.OpenMcTwoButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.importToMcOneButton = new System.Windows.Forms.ToolStripButton();
			this.importToMcTwoButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.ExportSaveButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.mcOneToMcTwoButton = new System.Windows.Forms.ToolStripButton();
			this.mcTwoToMcOneButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteSaveButton = new System.Windows.Forms.ToolStripButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.file_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.file_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.file_Modyfied = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ContextMenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuItemCopySavesTo = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuItemCopyAllTo = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuItemMoveSavesTo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteSelectedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mcOpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.exportToolStripMenuItem,
									this.configToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(920, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.closeMC1ToolStripMenuItem,
									this.closeMC2ToolStripMenuItem,
									this.toolStripSeparator1,
									this.exportSaveToolStripMenuItem,
									this.toolStripSeparator3,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// closeMC1ToolStripMenuItem
			// 
			this.closeMC1ToolStripMenuItem.Enabled = false;
			this.closeMC1ToolStripMenuItem.Name = "closeMC1ToolStripMenuItem";
			this.closeMC1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.closeMC1ToolStripMenuItem.Text = "Close MC1";
			this.closeMC1ToolStripMenuItem.Click += new System.EventHandler(this.CloseMC1ToolStripMenuItemClick);
			// 
			// closeMC2ToolStripMenuItem
			// 
			this.closeMC2ToolStripMenuItem.Enabled = false;
			this.closeMC2ToolStripMenuItem.Name = "closeMC2ToolStripMenuItem";
			this.closeMC2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.closeMC2ToolStripMenuItem.Text = "Close MC2";
			this.closeMC2ToolStripMenuItem.Click += new System.EventHandler(this.CloseMC2ToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// exportSaveToolStripMenuItem
			// 
			this.exportSaveToolStripMenuItem.Name = "exportSaveToolStripMenuItem";
			this.exportSaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exportSaveToolStripMenuItem.Text = "C&reate MC...";
			this.exportSaveToolStripMenuItem.Click += new System.EventHandler(this.CreateMcToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.CheckOnClick = true;
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exportToolStripMenuItem1});
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.exportToolStripMenuItem.Text = "&Batch actions";
			// 
			// exportToolStripMenuItem1
			// 
			this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.asPSUToolStripMenuItem,
									this.asmaxToolStripMenuItem});
			this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
			this.exportToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.exportToolStripMenuItem1.Text = "Export";
			// 
			// asPSUToolStripMenuItem
			// 
			this.asPSUToolStripMenuItem.Checked = true;
			this.asPSUToolStripMenuItem.CheckOnClick = true;
			this.asPSUToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.asPSUToolStripMenuItem.Name = "asPSUToolStripMenuItem";
			this.asPSUToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.asPSUToolStripMenuItem.Text = "as .psu";
			// 
			// asmaxToolStripMenuItem
			// 
			this.asmaxToolStripMenuItem.CheckOnClick = true;
			this.asmaxToolStripMenuItem.Name = "asmaxToolStripMenuItem";
			this.asmaxToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.asmaxToolStripMenuItem.Text = "as .max";
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.preferencesToolStripMenuItem});
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "&Config";
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.preferencesToolStripMenuItem.Text = "Preferences...";
			this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.myMcDualToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// myMcDualToolStripMenuItem
			// 
			this.myMcDualToolStripMenuItem.Name = "myMcDualToolStripMenuItem";
			this.myMcDualToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.myMcDualToolStripMenuItem.Text = "MyMc Dual...";
			this.myMcDualToolStripMenuItem.Click += new System.EventHandler(this.MyMcDualToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripStatusLabel2,
									this.hourLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 446);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(920, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.AutoSize = false;
			this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
									| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
									| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(600, 19);
			this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1Click);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.AutoSize = false;
			this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
									| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
									| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(190, 19);
			// 
			// hourLabel
			// 
			this.hourLabel.AutoSize = false;
			this.hourLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
									| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
									| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.hourLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.hourLabel.Name = "hourLabel";
			this.hourLabel.Size = new System.Drawing.Size(127, 19);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.OpenMcOneButton,
									this.OpenMcTwoButton,
									this.toolStripSeparator4,
									this.importToMcOneButton,
									this.importToMcTwoButton,
									this.toolStripSeparator5,
									this.ExportSaveButton,
									this.toolStripSeparator6,
									this.mcOneToMcTwoButton,
									this.mcTwoToMcOneButton,
									this.toolStripSeparator7,
									this.deleteSaveButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(920, 39);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// OpenMcOneButton
			// 
			this.OpenMcOneButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenMcOneButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenMcOneButton.Image")));
			this.OpenMcOneButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.OpenMcOneButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenMcOneButton.Name = "OpenMcOneButton";
			this.OpenMcOneButton.Size = new System.Drawing.Size(36, 36);
			this.OpenMcOneButton.Text = "Open MC 1";
			this.OpenMcOneButton.Click += new System.EventHandler(this.OpenMcOneButtonClick);
			// 
			// OpenMcTwoButton
			// 
			this.OpenMcTwoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenMcTwoButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenMcTwoButton.Image")));
			this.OpenMcTwoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.OpenMcTwoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenMcTwoButton.Name = "OpenMcTwoButton";
			this.OpenMcTwoButton.Size = new System.Drawing.Size(36, 36);
			this.OpenMcTwoButton.Text = "Open MC2";
			this.OpenMcTwoButton.Click += new System.EventHandler(this.OpenMcTwoButtonClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
			// 
			// importToMcOneButton
			// 
			this.importToMcOneButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.importToMcOneButton.Enabled = false;
			this.importToMcOneButton.Image = ((System.Drawing.Image)(resources.GetObject("importToMcOneButton.Image")));
			this.importToMcOneButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.importToMcOneButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.importToMcOneButton.Name = "importToMcOneButton";
			this.importToMcOneButton.Size = new System.Drawing.Size(36, 36);
			this.importToMcOneButton.Text = "Import to MC1";
			this.importToMcOneButton.Click += new System.EventHandler(this.ImportToMcOneButtonClick);
			// 
			// importToMcTwoButton
			// 
			this.importToMcTwoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.importToMcTwoButton.Enabled = false;
			this.importToMcTwoButton.Image = ((System.Drawing.Image)(resources.GetObject("importToMcTwoButton.Image")));
			this.importToMcTwoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.importToMcTwoButton.Name = "importToMcTwoButton";
			this.importToMcTwoButton.Size = new System.Drawing.Size(36, 36);
			this.importToMcTwoButton.Text = "Import to MC2";
			this.importToMcTwoButton.Click += new System.EventHandler(this.ImportToMcTwoButtonClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
			// 
			// ExportSaveButton
			// 
			this.ExportSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ExportSaveButton.Enabled = false;
			this.ExportSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportSaveButton.Image")));
			this.ExportSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ExportSaveButton.Name = "ExportSaveButton";
			this.ExportSaveButton.Size = new System.Drawing.Size(36, 36);
			this.ExportSaveButton.Text = "Export save";
			this.ExportSaveButton.Click += new System.EventHandler(this.ExportSaveButtonClick);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
			// 
			// mcOneToMcTwoButton
			// 
			this.mcOneToMcTwoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.mcOneToMcTwoButton.Enabled = false;
			this.mcOneToMcTwoButton.Image = ((System.Drawing.Image)(resources.GetObject("mcOneToMcTwoButton.Image")));
			this.mcOneToMcTwoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mcOneToMcTwoButton.Name = "mcOneToMcTwoButton";
			this.mcOneToMcTwoButton.Size = new System.Drawing.Size(36, 36);
			this.mcOneToMcTwoButton.Text = "Transfer save MC1 to MC2";
			this.mcOneToMcTwoButton.Click += new System.EventHandler(this.McOneToMcTwoButtonClick);
			// 
			// mcTwoToMcOneButton
			// 
			this.mcTwoToMcOneButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.mcTwoToMcOneButton.Enabled = false;
			this.mcTwoToMcOneButton.Image = ((System.Drawing.Image)(resources.GetObject("mcTwoToMcOneButton.Image")));
			this.mcTwoToMcOneButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mcTwoToMcOneButton.Name = "mcTwoToMcOneButton";
			this.mcTwoToMcOneButton.Size = new System.Drawing.Size(36, 36);
			this.mcTwoToMcOneButton.Text = "Transfer save MC2 to MC1";
			this.mcTwoToMcOneButton.Click += new System.EventHandler(this.McTwoToMcOneButtonClick);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
			// 
			// deleteSaveButton
			// 
			this.deleteSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteSaveButton.Enabled = false;
			this.deleteSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSaveButton.Image")));
			this.deleteSaveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteSaveButton.Name = "deleteSaveButton";
			this.deleteSaveButton.Size = new System.Drawing.Size(36, 36);
			this.deleteSaveButton.Text = "Delete Save";
			this.deleteSaveButton.Click += new System.EventHandler(this.DeleteSaveButtonClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.groupBox1.Location = new System.Drawing.Point(12, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(434, 332);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Memory Card 1: ";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.file_Name,
									this.file_Size,
									this.file_Modyfied,
									this.Column1});
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(6, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.Size = new System.Drawing.Size(422, 307);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragAndDrop);
			this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGridViewDragEnter);
			this.dataGridView1.Enter += new System.EventHandler(this.OnFocusMemoryCard);
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewKeyDown);
			this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGridViewMouseUp);
			// 
			// file_Name
			// 
			this.file_Name.HeaderText = "Name";
			this.file_Name.Name = "file_Name";
			this.file_Name.ReadOnly = true;
			this.file_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.file_Name.Width = 130;
			// 
			// file_Size
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.file_Size.DefaultCellStyle = dataGridViewCellStyle1;
			this.file_Size.HeaderText = "Size";
			this.file_Size.Name = "file_Size";
			this.file_Size.ReadOnly = true;
			this.file_Size.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.file_Size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.file_Size.Width = 50;
			// 
			// file_Modyfied
			// 
			this.file_Modyfied.HeaderText = "Last Modified";
			this.file_Modyfied.Name = "file_Modyfied";
			this.file_Modyfied.ReadOnly = true;
			this.file_Modyfied.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.file_Modyfied.Width = 110;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Description";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ContextMenuItemSelectAll,
									this.ContextMenuItemCopySavesTo,
									this.ContextMenuItemCopyAllTo,
									this.ContextMenuItemMoveSavesTo,
									this.toolStripSeparator2,
									this.deleteSelectedsToolStripMenuItem,
									this.deleteAllToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(159, 142);
			// 
			// ContextMenuItemSelectAll
			// 
			this.ContextMenuItemSelectAll.Name = "ContextMenuItemSelectAll";
			this.ContextMenuItemSelectAll.Size = new System.Drawing.Size(158, 22);
			this.ContextMenuItemSelectAll.Text = "Select All";
			this.ContextMenuItemSelectAll.Click += new System.EventHandler(this.ContextMenuItemSelectAllClick);
			// 
			// ContextMenuItemCopySavesTo
			// 
			this.ContextMenuItemCopySavesTo.Name = "ContextMenuItemCopySavesTo";
			this.ContextMenuItemCopySavesTo.Size = new System.Drawing.Size(158, 22);
			this.ContextMenuItemCopySavesTo.Text = "Copy saves to";
			this.ContextMenuItemCopySavesTo.Click += new System.EventHandler(this.ContextMenuItemCopySavesToClick);
			// 
			// ContextMenuItemCopyAllTo
			// 
			this.ContextMenuItemCopyAllTo.Name = "ContextMenuItemCopyAllTo";
			this.ContextMenuItemCopyAllTo.Size = new System.Drawing.Size(158, 22);
			this.ContextMenuItemCopyAllTo.Text = "Copy All to";
			this.ContextMenuItemCopyAllTo.Click += new System.EventHandler(this.ContextMenuItemCopyAllToClick);
			// 
			// ContextMenuItemMoveSavesTo
			// 
			this.ContextMenuItemMoveSavesTo.Name = "ContextMenuItemMoveSavesTo";
			this.ContextMenuItemMoveSavesTo.Size = new System.Drawing.Size(158, 22);
			this.ContextMenuItemMoveSavesTo.Text = "Move saves to";
			this.ContextMenuItemMoveSavesTo.Click += new System.EventHandler(this.ContextMenuItemMoveSavesToClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
			// 
			// deleteSelectedsToolStripMenuItem
			// 
			this.deleteSelectedsToolStripMenuItem.Name = "deleteSelectedsToolStripMenuItem";
			this.deleteSelectedsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.deleteSelectedsToolStripMenuItem.Text = "Delete selecteds";
			this.deleteSelectedsToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItemDeleteSelectedsClick);
			// 
			// deleteAllToolStripMenuItem
			// 
			this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
			this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.deleteAllToolStripMenuItem.Text = "Delete All";
			this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItemClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Location = new System.Drawing.Point(474, 69);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(434, 332);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Memory Card 2: ";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowDrop = true;
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToOrderColumns = true;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4});
			this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView2.Location = new System.Drawing.Point(6, 19);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView2.Size = new System.Drawing.Size(422, 307);
			this.dataGridView2.TabIndex = 1;
			this.dataGridView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragAndDrop);
			this.dataGridView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGridViewDragEnter);
			this.dataGridView2.Enter += new System.EventHandler(this.OnFocusMemoryCard);
			this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewKeyDown);
			this.dataGridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGridViewMouseUp);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn1.Width = 130;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn2.HeaderText = "Size";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn2.Width = 50;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Last Modified";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn3.Width = 110;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.HeaderText = "Description";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 404);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(434, 21);
			this.label1.TabIndex = 5;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(474, 404);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(434, 21);
			this.label2.TabIndex = 6;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(920, 470);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyMC Dual";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteSelectedsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCopyAllTo;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuItemMoveSavesTo;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCopySavesTo;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuItemSelectAll;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem myMcDualToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem asmaxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem asPSUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton deleteSaveButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog mcOpenDialog;
		private System.Windows.Forms.ToolStripStatusLabel hourLabel;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn file_Modyfied;
		private System.Windows.Forms.DataGridViewTextBoxColumn file_Size;
		private System.Windows.Forms.DataGridViewTextBoxColumn file_Name;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStripButton mcTwoToMcOneButton;
		private System.Windows.Forms.ToolStripButton mcOneToMcTwoButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton ExportSaveButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton importToMcTwoButton;
		private System.Windows.Forms.ToolStripButton importToMcOneButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton OpenMcTwoButton;
		private System.Windows.Forms.ToolStripButton OpenMcOneButton;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem exportSaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem closeMC2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeMC1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
