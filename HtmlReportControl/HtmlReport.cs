using System;
using System.IO;
using System.Windows.Forms;

using mshtml;

namespace HtmlReportControl
{
	public partial class HtmlReport : UserControl
	{
		public HtmlReport()
		{
			InitializeComponent();

			ValidateSearchButtons();
			_webBrowser.Navigate("about:blank");
		}

		/// <summary>
		/// Load report to the browser control
		/// </summary>
		/// <param name="htmlData">Report html text</param>
		/// <returns></returns>
		public bool LoadReport(string htmlData)
		{
			if(_webBrowser.Document == null)
				return false;

			_webBrowser.Document.Write(htmlData);

			return true;
		}
		
		private void OnButtonExportClick(object sender, EventArgs e)
		{
			if(_saveFileDialog.ShowDialog() == DialogResult.OK)
				File.WriteAllText(_saveFileDialog.FileName, _webBrowser.DocumentText);
		}

		private void OnButtonPrintClick(object sender, EventArgs e)
		{
			//const string keyName = @"Software\Microsoft\Internet Explorer\PageSetup";
			//using(var key = Registry.CurrentUser.OpenSubKey(keyName, true))
			//{
			//	if(key == null)
			//		return;

			//	var oldFooter = (string)key.GetValue("footer");
			//	var oldHeader = (string)key.GetValue("header");

			//	try
			//	{
			//		key.SetValue("footer", "");
			//		key.SetValue("header", "");

			_webBrowser.ShowPrintPreviewDialog();
			//_webBrowser.Pr
			//	}
			//	finally
			//	{
			//		key.SetValue("footer", oldFooter);
			//		key.SetValue("header", oldHeader);
			//	}
			//}
		}
		
		private void OnButtonSearchClick(object sender, EventArgs e)
		{
			Search();
		}

		private void Search()
		{
			if(_webBrowser.Document == null)
				return;

			var htmlDocument = _webBrowser.Document.DomDocument as IHTMLDocument2;

			if(htmlDocument == null)
				return;

			var textRange = (IHTMLTxtRange)htmlDocument.selection.createRange();

			textRange.collapse(false);
			textRange.findText(_textBoxSearchText.Text, 1); // positive value, should search forward, negative backward
			textRange.@select();

			//if(result == false)
			//ProgramHelper.ShowMessageBox()
		}

		private void OnSearchTextChanged(object sender, EventArgs e)
		{
			ValidateSearchButtons();
		}

		private void ValidateSearchButtons()
		{
			_buttonSearch.Enabled = _textBoxSearchText.Text.Length > 0;
		}

		//private void OnExportToMsExcel(object sender, EventArgs e)
		//{
			//if(File.Exists("test.xlsx"))
			//	File.Delete("test.xlsx");

			//// templateName = the name of .xlsx file
			//using(var result = new FileStream("test.xlsx", FileMode.CreateNew))
			//{
			//	//using (var source = System.IO.File.OpenRead(""))
			//	using(var excel = new OfficeOpenXml.ExcelPackage(result))
			//	{

			//		// Fill cells here
			//		// Leave headers etc as is
			//		excel.Workbook.Worksheets.Add("April 2012");
			//		ExcelWorksheet ws = excel.Workbook.Worksheets[1]; // 1 is the position of the worksheet
			//		ws.Name = "April 2012";

			//		int rowIndex = 1;
			//		int colIndex = 1;

			//		do
			//		{
			//			// Set the background colours
			//			var cell = ws.Cells[rowIndex, colIndex];
			//			var fill = cell.Style.Fill;
			//			fill.PatternType = ExcelFillStyle.Solid;
			//			fill.BackgroundColor.SetColor(Color.LightGray);
			//			colIndex++;
			//		}
			//		while(colIndex != 4);

			//		// Set the cell values
			//		var cell_actionName = ws.Cells[1, 1];
			//		var cell_timeTaken = ws.Cells[1, 2];
			//		var cell_processorsUsed = ws.Cells[1, 3];

			//		cell_actionName.Value = "Action Name";
			//		cell_timeTaken.Value = "Time Taken";
			//		cell_processorsUsed.Value = "Processing Unit";

			//		excel.Save();
			//	}
			//}
		//}

		//private void OnExportToPdf(object sender, EventArgs e)
		//{
			//iTextSharp.text.DocWriter
			//using (Stream stream = new FileStream("test.pdf", FileMode.CreateNew))
			//{
			//	var pdfWorker = new HtmlToPdfConverter();
			//	pdfWorker.Open(stream);
			//	pdfWorker.Run("test");
			//	pdfWorker.Close();
			//}

			//createPDF(_webBrowser.DocumentText);
			//a.S
		//}

		//private void createPDF(string html)
		//{
		//	if (File.Exists("test.pdf"))
		//		File.Delete("test.pdf");

		//	using (Stream stream = new FileStream("test.pdf", FileMode.CreateNew))
		//	{
		//		//MemoryStream msOutput = new MemoryStream();
		//		TextReader reader = new StringReader(html);

		//		// step 1: creation of a document-object
		//		Document document = new Document(PageSize.A4, 30, 30, 30, 30);

		//		// step 2:
		//		// we create a writer that listens to the document
		//		// and directs a XML-stream to a file
		//		PdfWriter writer = PdfWriter.GetInstance(document, stream);

		//		// step 3: we create a worker parse the document
		//		HTMLWorker worker = new HTMLWorker(document);

		//		// step 4: we open document and start the worker on the document
		//		document.Open();
		//		worker.StartDocument();

		//		// step 5: parse the html into the document
		//		worker.Parse(reader);

		//		// step 6: close the document and the worker
		//		worker.EndDocument();
		//		worker.Close();
		//		document.Close();
		//	}

		//	//return msOutput;
		//}
	}
}
