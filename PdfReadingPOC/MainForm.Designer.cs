﻿namespace PdfReadingPOC
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnCreate = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			SuspendLayout();
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(119, 39);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(75, 23);
			btnCreate.TabIndex = 0;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += BtnCreate_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(293, 32);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(226, 23);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(293, 77);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(226, 23);
			textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(293, 128);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(226, 23);
			textBox3.TabIndex = 3;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(785, 390);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(btnCreate);
			Name = "MainForm";
			Text = "MainForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCreate;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
	}
}