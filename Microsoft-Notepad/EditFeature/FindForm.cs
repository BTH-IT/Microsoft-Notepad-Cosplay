using Microsoft_Notepad.EditFeature;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft_Notepad
{
	public partial class FindForm : Form
	{
		public static string TxtToFind { get; set; }
		public static bool IsShowed = false;
		public FindNextSearch qry = new FindNextSearch();
		public FindForm()
		{
			InitializeComponent();
			qry.Success = false;
			if(TxtToFind != null  && TxtToFind.Length !=0)
			{
				this.textBox1.Text = TxtToFind;	
			}	
			UpdateSearchQuery();	
		}
		public void UpdateSearchQuery()
		{
			qry.SearchString = textBox1.Text;
			qry.Direction = upDirectionRdoBtn.Checked ? "UP" : "DOWN";
			qry.MatchCase = matchCaseCb.Checked;
			qry.Content = Notepad.Instance.richTextBox1.Text;
			qry.Position = Notepad.Instance.richTextBox1.SelectionStart;
			qry.WrapAround = wrapAroundCbx.Checked;
		}
		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Hide();	
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			TxtToFind = textBox1.Text;
			UpdateSearchQuery();
			if (TxtToFind.Length <= 0 )
			{
				this.btnFind.Enabled = false;
			}
			else
			{
				this.btnFind.Enabled = true;
			}
		}
		public FindNextResult FindNext(FindNextSearch search,string mode="")
		{
			FindNextResult result = new FindNextResult();
			int position = -1;
			StringComparison s = search.MatchCase ? StringComparison.CurrentCulture :
				StringComparison.CurrentCultureIgnoreCase;
			if (mode.Trim().Length != 0)
			{
				qry.Direction = mode;
			}
			if (search.Direction == "UP")
			{
				position = search.Content.Substring(0, search.Position)
					.LastIndexOf(search.SearchString, s);
				if(position < 0  && search.WrapAround)
				{
					search.Position = search.Content.Length;
					position = search.Content.Substring(0, search.Position)
					.LastIndexOf(search.SearchString, s);
				}	
				search.Success = position >= 0 ? true : false;
				result.SearchStatus = search.Success;
			}
			else
			{
				int start = search.Success ? search.Position + search.SearchString.Length :
					search.Position;
				position = start + search.Content
					.Substring(start, search.Content.Length - start)
					.IndexOf(search.SearchString, s);
				if (position - start < 0 && search.WrapAround)
				{
					start = 0;
					position = start + search.Content
					.Substring(start, search.Content.Length - start)
					.IndexOf(search.SearchString, s);

				}	
				search.Success = position - start >= 0 ? true : false;
				result.SearchStatus = search.Success;
			}
			result.SelectionStart = result.SearchStatus ? position : -1;
			return result;
		}
		private void btnFind_Click(object sender, EventArgs e)
		{

			handleFindEvent();
		}

		public void handleFindEvent(string mode="")
		{
			UpdateSearchQuery();
			FindNextResult result = FindNext(qry,mode);
			if (result.SearchStatus)
			{
				Notepad.Instance.richTextBox1.Select(result.SelectionStart,textBox1.Text.Length);
			}
			else
			{
				MessageBox.Show($"Cannot find \"{qry.SearchString}\" ","NotePad",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}

		private void FindForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			IsShowed = false;
		}

		private void downDirectionRdoBtn_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}

		private void upDirectionRdoBtn_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}

		private void matchCaseCb_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}

		private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			IsShowed = false;
			this.Hide();
			e.Cancel = true;
		}

		private void FindForm_Load(object sender, EventArgs e)
		{
			IsShowed=true;
		}
	}
}
