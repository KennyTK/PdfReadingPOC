using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Pdf.IO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using Microsoft.Extensions.Primitives;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PdfReadingPOC
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			openFileDialog1.InitialDirectory = "@C:\\Users\\kenny\\Desktop";
			openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			folderBrowserDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			// Create a new PDF document
			PdfDocument document = new PdfDocument();
			document.Info.Title = "Created with PDFsharp";

			// Create an empty page
			PdfPage page = document.AddPage();

			// Get an XGraphics object for drawing
			XGraphics gfx = XGraphics.FromPdfPage(page);

			// Create a font
			XFont font = new XFont("Arial", 20, XFontStyleEx.Regular);

			// Draw the text
			gfx.DrawString("Hello, World!", font, XBrushes.Black,
			  new XRect(0, 0, page.Width, page.Height),
			  XStringFormats.Center);

			// Save the document...
			const string filename = "HelloWorld.pdf";
			document.Save("C:/Users/kenny/Documents" + filename);
			// ...and start a viewer.
			Process.Start("explorer", filename);
		}



		private void BtnRead_Click(object sender, EventArgs e)
		{
			String filePath = "";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//Get the path of specified file
				filePath = openFileDialog1.FileName;

				Pig pig = new Pig(filePath);

				StringBuilder sb = new StringBuilder();

				int i = 0;

				dataGridView1.Columns.Insert(0, new DataGridViewColumn());

				foreach (String s in pig.run())
				{
					dataGridView1.Rows.Insert(i, s);

					sb.Append(s + " ");

					i++;
				}

				textBox1.Text = sb.ToString();
			}
		}

		private void BtnReadBatch_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				//Get the path of specified file
				//filePath = folderBrowserDialog1.SelectedPath;

				dataGridView2.Columns.Add("placeholder", "placeholder");
				dataGridView2.Rows.Add(5);
				dataGridView2.Rows[0].HeaderCell.Value = "Title";
				dataGridView2.Rows[1].HeaderCell.Value = "Page Count";
				dataGridView2.Rows[2].HeaderCell.Value = "Revision Date";
				dataGridView2.Rows[3].HeaderCell.Value = "Revision Number";
				dataGridView2.Rows[4].HeaderCell.Value = "";

				string[] filepaths = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.pdf", SearchOption.AllDirectories);

				List<string> fileNames = new List<string>();

				foreach (string s in filepaths)
				{
					string tempFileName = Path.GetFileName(s);

					fileNames.Add(tempFileName);

					dataGridView1.Columns.Add(tempFileName, tempFileName);
					dataGridView2.Columns.Add(tempFileName, tempFileName);

					temporaryMethod(s, tempFileName);
				}
			}

			dataGridView1.AutoResizeColumns();
			dataGridView2.AutoResizeColumns();

			LblCountValue.Text = dataGridView1.Columns.Count.ToString();
		}

		private void temporaryMethod(string filePath, string fileName)
		{
			Pig pig = new Pig(filePath);

			List<String> piggy = pig.run();

			for (int i = 1; i < piggy.Count - 1; i++)
			{
				if (dataGridView1.Rows.Count > i)
				{
					dataGridView1[fileName, (i - 1)].Value = piggy[i - 1];
				}
				else
				{
					dataGridView1.Rows.Add(piggy[i - 1]);
				}
			}

			addTitle(piggy, fileName);
		}

		private string[] endingStrings = { "Procedure", "Date", "Job", "Customer", "Procedure:", "Date:", "Job:", "Customer:", "this", "Description", "Date:_________________________________", "Date(s):" };

		private void addTitle(List<String> listOfStrings, string columnName)
		{
			bool hasFoundProcedure = false;
			bool checkedForFirstFor = false;
			StringBuilder title = new StringBuilder();

			foreach (string str in listOfStrings)
			{
				if (hasFoundProcedure)
				{
					if (!checkedForFirstFor)
					{
						checkedForFirstFor = true;
						if (str.Equals("for", StringComparison.OrdinalIgnoreCase))
						{
							continue;
						}
					}

					foreach (string ending in endingStrings)
					{
						if (str.Equals(ending, StringComparison.OrdinalIgnoreCase))
						{


							dataGridView2[columnName, 0].Value = title.ToString();
							return;
						}
					}

					title.Append(str + " ");
				}

				if (str.Equals("procedure", StringComparison.OrdinalIgnoreCase))
				{
					hasFoundProcedure = true;
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			dataGridView1.Columns.Clear();
			dataGridView1.Rows.Clear();
			dataGridView2.Columns.Clear();
			dataGridView2.Rows.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.AutoResizeColumns();
			dataGridView2.AutoResizeColumns();
		}
	}
}