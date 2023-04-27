using System.Diagnostics;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace PdfReadingPOC
{
	internal class Pig
	{
		String filePath = "";

		public Pig(String filePath)
		{
			this.filePath = filePath;
		}

		private List<String> words = new List<String>();

		public List<String> run()
		{
			using (PdfDocument document = PdfDocument.Open(filePath)) //@"C:\Users\kenny\Desktop\files2\TEST.pdf"
			{
				foreach (Page page in document.GetPages())
				{
					string pageText = page.Text;

					foreach (Word word in page.GetWords())
					{
						words.Add(word.ToString());
						//Debug.WriteLine(word.Text);
					}
				}
			}

			return words;
		}
	}
}