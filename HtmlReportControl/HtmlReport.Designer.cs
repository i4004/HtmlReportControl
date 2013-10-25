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
			this._webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._webBrowser.Location = new System.Drawing.Point(0, 43);
			this._webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this._webBrowser.Name = "_webBrowser";
			this._webBrowser.Size = new System.Drawing.Size(940, 567);
			this._webBrowser.TabIndex = 0;
			// 
			// _buttonPrint
			// 
			this._buttonPrint.Location = new System.Drawing.Point(87, 6);
			this._buttonPrint.Name = "_buttonPrint";
			this._buttonPrint.Size = new System.Drawing.Size(75, 23);
			this._buttonPrint.TabIndex = 6;
			this._buttonPrint.Text = "Печать...";
			this._buttonPrint.UseVisualStyleBackColor = true;
			this._buttonPrint.Click += new System.EventHandler(this.OnButtonPrintClick);
			// 
			// _buttonExport
			// 
			this._buttonExport.Location = new System.Drawing.Point(6, 6);
			this._buttonExport.Name = "_buttonExport";
			this._buttonExport.Size = new System.Drawing.Size(75, 23);
			this._buttonExport.TabIndex = 7;
			this._buttonExport.Text = "Экспорт...";
			this._buttonExport.UseVisualStyleBackColor = true;
			this._buttonExport.Click += new System.EventHandler(this.OnButtonExportClick);
			// 
			// _buttonSearch
			// 
			this._buttonSearch.Location = new System.Drawing.Point(369, 6);
			this._buttonSearch.Name = "_buttonSearch";
			this._buttonSearch.Size = new System.Drawing.Size(75, 23);
			this._buttonSearch.TabIndex = 8;
			this._buttonSearch.Text = "Поиск";
			this._buttonSearch.UseVisualStyleBackColor = true;
			this._buttonSearch.Click += new System.EventHandler(this.OnButtonSearchClick);
			// 
			// _textBoxSearchText
			// 
			this._textBoxSearchText.Location = new System.Drawing.Point(168, 8);
			this._textBoxSearchText.Name = "_textBoxSearchText";
			this._textBoxSearchText.Size = new System.Drawing.Size(195, 20);
			this._textBoxSearchText.TabIndex = 9;
			this._textBoxSearchText.TextChanged += new System.EventHandler(this.OnSearchTextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._buttonSearch);
			this.panel1.Controls.Add(this._buttonExport);
			this.panel1.Controls.Add(this._textBoxSearchText);
			this.panel1.Controls.Add(this._buttonPrint);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(3);
			this.panel1.Size = new System.Drawing.Size(940, 37);
			this.panel1.TabIndex = 10;
			// 
			// _saveFileDialog
			// 
			this._saveFileDialog.DefaultExt = "html";
			this._saveFileDialog.Filter = "HTML files|*.html";
			// 
			// HtmlReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this._webBrowser);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "HtmlReport";
			this.Size = new System.Drawing.Size(940, 610);
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
