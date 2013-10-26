namespace HtmlReportControl
{
	partial class HtmlReport
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlReport));
			this._webBrowser = new System.Windows.Forms.WebBrowser();
			this._buttonPrint = new System.Windows.Forms.Button();
			this._buttonExport = new System.Windows.Forms.Button();
			this._buttonSearch = new System.Windows.Forms.Button();
			this._textBoxSearchText = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _webBrowser
			// 
			resources.ApplyResources(this._webBrowser, "_webBrowser");
			this._webBrowser.Name = "_webBrowser";
			// 
			// _buttonPrint
			// 
			resources.ApplyResources(this._buttonPrint, "_buttonPrint");
			this._buttonPrint.Name = "_buttonPrint";
			this._buttonPrint.UseVisualStyleBackColor = true;
			this._buttonPrint.Click += new System.EventHandler(this.OnButtonPrintClick);
			// 
			// _buttonExport
			// 
			resources.ApplyResources(this._buttonExport, "_buttonExport");
			this._buttonExport.Name = "_buttonExport";
			this._buttonExport.UseVisualStyleBackColor = true;
			this._buttonExport.Click += new System.EventHandler(this.OnButtonExportClick);
			// 
			// _buttonSearch
			// 
			resources.ApplyResources(this._buttonSearch, "_buttonSearch");
			this._buttonSearch.Name = "_buttonSearch";
			this._buttonSearch.UseVisualStyleBackColor = true;
			this._buttonSearch.Click += new System.EventHandler(this.OnButtonSearchClick);
			// 
			// _textBoxSearchText
			// 
			resources.ApplyResources(this._textBoxSearchText, "_textBoxSearchText");
			this._textBoxSearchText.Name = "_textBoxSearchText";
			this._textBoxSearchText.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this._buttonSearch);
			this.panel1.Controls.Add(this._buttonExport);
			this.panel1.Controls.Add(this._textBoxSearchText);
			this.panel1.Controls.Add(this._buttonPrint);
			this.panel1.Name = "panel1";
			// 
			// _saveFileDialog
			// 
			this._saveFileDialog.DefaultExt = "html";
			resources.ApplyResources(this._saveFileDialog, "_saveFileDialog");
			// 
			// HtmlReport
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this._webBrowser);
			this.Name = "HtmlReport";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser _webBrowser;
		private System.Windows.Forms.Button _buttonPrint;
		private System.Windows.Forms.Button _buttonExport;
		private System.Windows.Forms.Button _buttonSearch;
		private System.Windows.Forms.TextBox _textBoxSearchText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SaveFileDialog _saveFileDialog;
	}
}
