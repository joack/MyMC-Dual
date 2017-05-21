/*
 * Creado por SharpDevelop.
 * Usuario: Joack
 * Fecha: 05/05/2017
 * Hora: 00:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MyMC
{
	partial class Preference
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AccepBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(20, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(340, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(366, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(68, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "Browse...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(366, 81);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 20);
			this.button2.TabIndex = 3;
			this.button2.Text = "Browse...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(20, 81);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(340, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Save Export Path: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Load Cards Path:";
			// 
			// AccepBtn
			// 
			this.AccepBtn.Location = new System.Drawing.Point(135, 256);
			this.AccepBtn.Name = "AccepBtn";
			this.AccepBtn.Size = new System.Drawing.Size(75, 23);
			this.AccepBtn.TabIndex = 6;
			this.AccepBtn.Text = "Accept";
			this.AccepBtn.UseVisualStyleBackColor = true;
			this.AccepBtn.Click += new System.EventHandler(this.AccepButtonClick);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(283, 256);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 7;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Saves Folder Path:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(366, 130);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(68, 20);
			this.button3.TabIndex = 9;
			this.button3.Text = "Browse...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(20, 130);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(340, 20);
			this.textBox3.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "New Cards Path:";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(366, 183);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(68, 20);
			this.button4.TabIndex = 12;
			this.button4.Text = "Browse...";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(20, 183);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(340, 20);
			this.textBox4.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(20, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(454, 223);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Paths:";
			// 
			// Preference
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 291);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.AccepBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Preference";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.PreferencesLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.Button AccepBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
