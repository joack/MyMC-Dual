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
			this.AccepButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(43, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(340, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(389, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(68, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "Browse...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(389, 87);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 20);
			this.button2.TabIndex = 3;
			this.button2.Text = "Browse...";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(43, 87);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(340, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(43, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Save Export Path: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(43, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Load Cards Path:";
			// 
			// AccepButton
			// 
			this.AccepButton.Location = new System.Drawing.Point(127, 190);
			this.AccepButton.Name = "AccepButton";
			this.AccepButton.Size = new System.Drawing.Size(75, 23);
			this.AccepButton.TabIndex = 6;
			this.AccepButton.Text = "Accept";
			this.AccepButton.UseVisualStyleBackColor = true;
			this.AccepButton.Click += new System.EventHandler(this.AccepButtonClick);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(275, 190);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 7;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(43, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Saves Folder Path:";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(389, 136);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(68, 20);
			this.button5.TabIndex = 9;
			this.button5.Text = "Browse...";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(43, 136);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(340, 20);
			this.textBox3.TabIndex = 8;
			// 
			// Preferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 231);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AccepButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Preferences";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.PreferencesLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button AccepButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
