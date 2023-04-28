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
			splitContainer1 = new SplitContainer();
			dataGridView2 = new DataGridView();
			dataGridView1 = new DataGridView();
			openFileDialog1 = new OpenFileDialog();
			BtnReadBatch = new Button();
			folderBrowserDialog1 = new FolderBrowserDialog();
			LblCount = new Label();
			LblCountValue = new Label();
			BtnClear = new Button();
			button1 = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
			BtnRead.Location = new Point(12, 41);
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
			tabPage2.Controls.Add(splitContainer1);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(672, 338);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(3, 3);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(dataGridView2);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(dataGridView1);
			splitContainer1.Size = new Size(666, 332);
			splitContainer1.SplitterDistance = 76;
			splitContainer1.TabIndex = 9;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Dock = DockStyle.Fill;
			dataGridView2.Location = new Point(0, 0);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.Size = new Size(666, 76);
			dataGridView2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(0, 0);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(666, 252);
			dataGridView1.TabIndex = 0;
			// 
			// BtnReadBatch
			// 
			BtnReadBatch.Location = new Point(12, 70);
			BtnReadBatch.Name = "BtnReadBatch";
			BtnReadBatch.Size = new Size(75, 23);
			BtnReadBatch.TabIndex = 6;
			BtnReadBatch.Text = "Read Batch";
			BtnReadBatch.UseVisualStyleBackColor = true;
			BtnReadBatch.Click += BtnReadBatch_Click;
			// 
			// LblCount
			// 
			LblCount.AutoSize = true;
			LblCount.Location = new Point(12, 195);
			LblCount.Name = "LblCount";
			LblCount.Size = new Size(43, 15);
			LblCount.TabIndex = 7;
			LblCount.Text = "Count:";
			// 
			// LblCountValue
			// 
			LblCountValue.AutoSize = true;
			LblCountValue.Location = new Point(58, 195);
			LblCountValue.Name = "LblCountValue";
			LblCountValue.Size = new Size(13, 15);
			LblCountValue.TabIndex = 8;
			LblCountValue.Text = "0";
			// 
			// BtnClear
			// 
			BtnClear.Location = new Point(12, 99);
			BtnClear.Name = "BtnClear";
			BtnClear.Size = new Size(75, 23);
			BtnClear.TabIndex = 9;
			BtnClear.Text = "Clear";
			BtnClear.UseVisualStyleBackColor = true;
			BtnClear.Click += BtnClear_Click;
			// 
			// button1
			// 
			button1.Location = new Point(12, 128);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 10;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(785, 390);
			Controls.Add(button1);
			Controls.Add(BtnClear);
			Controls.Add(LblCountValue);
			Controls.Add(LblCount);
			Controls.Add(BtnReadBatch);
			Controls.Add(tabControl1);
			Controls.Add(BtnRead);
			Controls.Add(btnCreate);
			Name = "MainForm";
			Text = "PDF Reader Writer";
			Load += MainForm_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
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
		private DataGridView dataGridView2;
		private Label LblCount;
		private Label LblCountValue;
		private SplitContainer splitContainer1;
		private Button BtnClear;
		private Button button1;
	}
}