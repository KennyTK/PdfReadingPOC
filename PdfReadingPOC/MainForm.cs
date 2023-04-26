using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Pdf.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace PdfReadingPOC
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
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
	}
}