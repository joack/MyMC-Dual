/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 26/03/2017
 * Hora: 06:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MyMC
{
	partial class GenMc
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.extensionChooser = new System.Windows.Forms.ComboBox();
			this.eccBlockCheck = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.extensionChooser);
			this.groupBox1.Controls.Add(this.eccBlockCheck);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 190);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New VMC: ";
			// 
			// extensionChooser
			// 
			this.extensionChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.extensionChooser.FormattingEnabled = true;
			this.extensionChooser.Items.AddRange(new object[] {
			".bin",
			".ps2"});
			this.extensionChooser.Location = new System.Drawing.Point(193, 39);
			this.extensionChooser.Name = "extensionChooser";
			this.extensionChooser.Size = new System.Drawing.Size(58, 21);
			this.extensionChooser.TabIndex = 0;
			// 
			// eccBlockCheck
			// 
			this.eccBlockCheck.Location = new System.Drawing.Point(181, 86);
			this.eccBlockCheck.Name = "eccBlockCheck";
			this.eccBlockCheck.Size = new System.Drawing.Size(91, 17);
			this.eccBlockCheck.TabIndex = 3;
			this.eccBlockCheck.Text = "ECC Block";
			this.eccBlockCheck.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(142, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 14);
			this.label5.TabIndex = 6;
			this.label5.Text = "Mb.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Folder Path:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 14);
			this.label2.TabIndex = 5;
			this.label2.Text = "Size:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(112, 157);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 20);
			this.button3.TabIndex = 5;
			this.button3.Text = "Browse";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(15, 131);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(257, 20);
			this.textBox2.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"8",
			"16",
			"32",
			"64"});
			this.comboBox1.Location = new System.Drawing.Point(15, 84);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 14);
			this.label1.TabIndex = 7;
			this.label1.Text = "Name:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(172, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(60, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.CreateButtonClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(179, 220);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// GenMc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 260);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "GenMc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GenMc";
			this.Load += new System.EventHandler(this.GenMcLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox extensionChooser;
		private System.Windows.Forms.CheckBox eccBlockCheck;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
