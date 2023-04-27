namespace PdfReadingPOC
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
			BtnRead = new Button();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			dataGridView1 = new DataGridView();
			openFileDialog1 = new OpenFileDialog();
			BtnReadBatch = new Button();
			folderBrowserDialog1 = new FolderBrowserDialog();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(12, 12);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(75, 23);
			btnCreate.TabIndex = 0;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += BtnCreate_Click;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(0, 6);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(1033, 632);
			textBox1.TabIndex = 1;
			// 
			// BtnRead
			// 
			BtnRead.Location = new Point(12, 50);
			BtnRead.Name = "BtnRead";
			BtnRead.Size = new Size(75, 23);
			BtnRead.TabIndex = 4;
			BtnRead.Text = "Read";
			BtnRead.UseVisualStyleBackColor = true;
			BtnRead.Click += BtnRead_Click;
			// 
			// tabControl1
			// 
			tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(93, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(680, 366);
			tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(textBox1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(672, 338);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "tabPage1";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(dataGridView1);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(672, 338);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(666, 332);
			dataGridView1.TabIndex = 0;
			// 
			// BtnReadBatch
			// 
			BtnReadBatch.Location = new Point(12, 79);
			BtnReadBatch.Name = "BtnReadBatch";
			BtnReadBatch.Size = new Size(75, 23);
			BtnReadBatch.TabIndex = 6;
			BtnReadBatch.Text = "Read Batch";
			BtnReadBatch.UseVisualStyleBackColor = true;
			BtnReadBatch.Click += BtnReadBatch_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(785, 390);
			Controls.Add(BtnReadBatch);
			Controls.Add(tabControl1);
			Controls.Add(BtnRead);
			Controls.Add(btnCreate);
			Name = "MainForm";
			Text = "S";
			Load += MainForm_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnCreate;
		private TextBox textBox1;
		private Button BtnRead;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private DataGridView dataGridView1;
		private OpenFileDialog openFileDialog1;
		private Button BtnReadBatch;
		private FolderBrowserDialog folderBrowserDialog1;
	}
}